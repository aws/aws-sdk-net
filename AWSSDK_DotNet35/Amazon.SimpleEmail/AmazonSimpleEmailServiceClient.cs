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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.SimpleEmail.Model;
using Amazon.SimpleEmail.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleEmail
{
    /// <summary>
    /// Implementation for accessing SimpleEmailService
    ///
    /// Amazon Simple Email Service        
    /// <para>
    ///             This is the API Reference for Amazon Simple Email Service (Amazon SES).
    /// This documentation is intended to be            used in conjunction with the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/Welcome.html">Amazon
    /// SES Developer Guide</a>.        
    /// </para>
    ///         <note>For a list of Amazon SES endpoints to use in service requests, see <a
    /// href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/regions.html">Regions and
    /// Amazon SES</a>             in the Amazon SES Developer Guide.         </note>
    /// </summary>
    public partial class AmazonSimpleEmailServiceClient : AmazonServiceClient, IAmazonSimpleEmailService
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with the credentials loaded from the application's
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
        public AmazonSimpleEmailServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleEmailServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with the credentials loaded from the application's
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
        public AmazonSimpleEmailServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleEmailServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(AmazonSimpleEmailServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleEmailServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleEmailServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleEmailServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleEmailServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Credentials and an
        /// AmazonSimpleEmailServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(AWSCredentials credentials, AmazonSimpleEmailServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleEmailServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleEmailServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleEmailServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleEmailServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleEmailServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleEmailServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleEmailServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleEmailServiceConfig clientConfig)
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

        
        #region  DeleteIdentity

        /// <summary>
        /// Deletes the specified identity (email address or domain) from the list of verified
        /// identities.
        /// 
        ///         
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentity service method, as returned by SimpleEmailService.</returns>
        public DeleteIdentityResponse DeleteIdentity(DeleteIdentityRequest request)
        {
            var marshaller = new DeleteIdentityRequestMarshaller();
            var unmarshaller = DeleteIdentityResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityRequest,DeleteIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentity operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentity operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdentity
        ///         operation.</returns>
        public IAsyncResult BeginDeleteIdentity(DeleteIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteIdentityRequestMarshaller();
            var unmarshaller = DeleteIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentity operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentity.</param>
        /// 
        /// <returns>Returns a  DeleteIdentityResult from SimpleEmailService.</returns>
        public  DeleteIdentityResponse EndDeleteIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVerifiedEmailAddress

        /// <summary>
        /// Deletes the specified email address from the list of verified addresses.
        /// 
        ///         <important>The DeleteVerifiedEmailAddress action is deprecated as of the May
        /// 15, 2012 release        of Domain Verification. The DeleteIdentity action is now preferred.</important>
        ///        
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress service method.</param>
        /// 
        /// <returns>The response from the DeleteVerifiedEmailAddress service method, as returned by SimpleEmailService.</returns>
        public DeleteVerifiedEmailAddressResponse DeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest request)
        {
            var marshaller = new DeleteVerifiedEmailAddressRequestMarshaller();
            var unmarshaller = DeleteVerifiedEmailAddressResponseUnmarshaller.Instance;

            return Invoke<DeleteVerifiedEmailAddressRequest,DeleteVerifiedEmailAddressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVerifiedEmailAddress operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVerifiedEmailAddress
        ///         operation.</returns>
        public IAsyncResult BeginDeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteVerifiedEmailAddressRequestMarshaller();
            var unmarshaller = DeleteVerifiedEmailAddressResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteVerifiedEmailAddressRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVerifiedEmailAddress operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVerifiedEmailAddress.</param>
        /// 
        /// <returns>Returns a  DeleteVerifiedEmailAddressResult from SimpleEmailService.</returns>
        public  DeleteVerifiedEmailAddressResponse EndDeleteVerifiedEmailAddress(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVerifiedEmailAddressResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIdentityDkimAttributes

        /// <summary>
        /// Returns the current status of Easy DKIM signing for an entity. For domain name   
        ///         identities, this action also returns the DKIM tokens that are required for
        /// Easy DKIM            signing, and whether Amazon SES has successfully verified that
        /// these tokens have been            published.
        /// 
        ///         
        /// <para>
        /// This action takes a list of identities as input and returns the following        
        ///    information for each:
        /// </para>
        ///         <ul>            <li>Whether Easy DKIM signing is enabled or disabled.</li>
        ///            <li>A set of DKIM tokens that represent the identity. If the identity is
        /// an email                address, the tokens represent the domain of that address.</li>
        ///            <li>Whether Amazon SES has successfully verified the DKIM tokens published
        /// in the                domain's DNS.  This information is only returned for domain
        /// name identities, not for                email addresses.</li>        </ul>       
        /// 
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        ///         
        /// <para>
        /// For more information about creating DNS records using DKIM tokens, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim-dns-records.html">Amazon
        /// SES                Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityDkimAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityDkimAttributes service method, as returned by SimpleEmailService.</returns>
        public GetIdentityDkimAttributesResponse GetIdentityDkimAttributes(GetIdentityDkimAttributesRequest request)
        {
            var marshaller = new GetIdentityDkimAttributesRequestMarshaller();
            var unmarshaller = GetIdentityDkimAttributesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityDkimAttributesRequest,GetIdentityDkimAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityDkimAttributes operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityDkimAttributes operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityDkimAttributes
        ///         operation.</returns>
        public IAsyncResult BeginGetIdentityDkimAttributes(GetIdentityDkimAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetIdentityDkimAttributesRequestMarshaller();
            var unmarshaller = GetIdentityDkimAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<GetIdentityDkimAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityDkimAttributes operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityDkimAttributes.</param>
        /// 
        /// <returns>Returns a  GetIdentityDkimAttributesResult from SimpleEmailService.</returns>
        public  GetIdentityDkimAttributesResponse EndGetIdentityDkimAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdentityDkimAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIdentityNotificationAttributes

        /// <summary>
        /// Given a list of verified identities (email addresses and/or domains), returns a structure
        /// describing identity         notification attributes.
        /// 
        ///         
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        ///         
        /// <para>
        /// For more information about using notifications with Amazon SES, see the          
        ///  <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityNotificationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityNotificationAttributes service method, as returned by SimpleEmailService.</returns>
        public GetIdentityNotificationAttributesResponse GetIdentityNotificationAttributes(GetIdentityNotificationAttributesRequest request)
        {
            var marshaller = new GetIdentityNotificationAttributesRequestMarshaller();
            var unmarshaller = GetIdentityNotificationAttributesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityNotificationAttributesRequest,GetIdentityNotificationAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityNotificationAttributes operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityNotificationAttributes operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityNotificationAttributes
        ///         operation.</returns>
        public IAsyncResult BeginGetIdentityNotificationAttributes(GetIdentityNotificationAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetIdentityNotificationAttributesRequestMarshaller();
            var unmarshaller = GetIdentityNotificationAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<GetIdentityNotificationAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityNotificationAttributes operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityNotificationAttributes.</param>
        /// 
        /// <returns>Returns a  GetIdentityNotificationAttributesResult from SimpleEmailService.</returns>
        public  GetIdentityNotificationAttributesResponse EndGetIdentityNotificationAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdentityNotificationAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIdentityVerificationAttributes

        /// <summary>
        /// Given a list of identities (email addresses and/or domains), returns the verification
        ///        status and (for domain identities) the verification token for each identity.
        /// 
        ///         
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityVerificationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetIdentityVerificationAttributes service method, as returned by SimpleEmailService.</returns>
        public GetIdentityVerificationAttributesResponse GetIdentityVerificationAttributes(GetIdentityVerificationAttributesRequest request)
        {
            var marshaller = new GetIdentityVerificationAttributesRequestMarshaller();
            var unmarshaller = GetIdentityVerificationAttributesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityVerificationAttributesRequest,GetIdentityVerificationAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityVerificationAttributes operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityVerificationAttributes operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityVerificationAttributes
        ///         operation.</returns>
        public IAsyncResult BeginGetIdentityVerificationAttributes(GetIdentityVerificationAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetIdentityVerificationAttributesRequestMarshaller();
            var unmarshaller = GetIdentityVerificationAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<GetIdentityVerificationAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityVerificationAttributes operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityVerificationAttributes.</param>
        /// 
        /// <returns>Returns a  GetIdentityVerificationAttributesResult from SimpleEmailService.</returns>
        public  GetIdentityVerificationAttributesResponse EndGetIdentityVerificationAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdentityVerificationAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSendQuota

        /// <summary>
        /// Returns the user's current sending limits.
        /// 
        ///         
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by SimpleEmailService.</returns>
        public GetSendQuotaResponse GetSendQuota()
        {
            return GetSendQuota(new GetSendQuotaRequest());
        }

        /// <summary>
        /// Returns the user's current sending limits.
        /// 
        ///         
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSendQuota service method.</param>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by SimpleEmailService.</returns>
        public GetSendQuotaResponse GetSendQuota(GetSendQuotaRequest request)
        {
            var marshaller = new GetSendQuotaRequestMarshaller();
            var unmarshaller = GetSendQuotaResponseUnmarshaller.Instance;

            return Invoke<GetSendQuotaRequest,GetSendQuotaResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSendQuota operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSendQuota operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSendQuota
        ///         operation.</returns>
        public IAsyncResult BeginGetSendQuota(GetSendQuotaRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetSendQuotaRequestMarshaller();
            var unmarshaller = GetSendQuotaResponseUnmarshaller.Instance;

            return BeginInvoke<GetSendQuotaRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSendQuota operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSendQuota.</param>
        /// 
        /// <returns>Returns a  GetSendQuotaResult from SimpleEmailService.</returns>
        public  GetSendQuotaResponse EndGetSendQuota(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSendQuotaResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSendStatistics

        /// <summary>
        /// Returns the user's sending statistics. The result is a list of data points, representing
        /// the last two weeks of            sending activity.        
        /// 
        ///         
        /// <para>
        /// Each data point in the list contains statistics for a 15-minute interval.
        /// </para>
        ///         
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by SimpleEmailService.</returns>
        public GetSendStatisticsResponse GetSendStatistics()
        {
            return GetSendStatistics(new GetSendStatisticsRequest());
        }

        /// <summary>
        /// Returns the user's sending statistics. The result is a list of data points, representing
        /// the last two weeks of            sending activity.        
        /// 
        ///         
        /// <para>
        /// Each data point in the list contains statistics for a 15-minute interval.
        /// </para>
        ///         
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSendStatistics service method.</param>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by SimpleEmailService.</returns>
        public GetSendStatisticsResponse GetSendStatistics(GetSendStatisticsRequest request)
        {
            var marshaller = new GetSendStatisticsRequestMarshaller();
            var unmarshaller = GetSendStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetSendStatisticsRequest,GetSendStatisticsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSendStatistics operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSendStatistics operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSendStatistics
        ///         operation.</returns>
        public IAsyncResult BeginGetSendStatistics(GetSendStatisticsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetSendStatisticsRequestMarshaller();
            var unmarshaller = GetSendStatisticsResponseUnmarshaller.Instance;

            return BeginInvoke<GetSendStatisticsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSendStatistics operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSendStatistics.</param>
        /// 
        /// <returns>Returns a  GetSendStatisticsResult from SimpleEmailService.</returns>
        public  GetSendStatisticsResponse EndGetSendStatistics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSendStatisticsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIdentities

        /// <summary>
        /// Returns a list containing all of the identities (email addresses and domains) for
        ///         a specific AWS Account, regardless of verification status.
        /// 
        ///         
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by SimpleEmailService.</returns>
        public ListIdentitiesResponse ListIdentities()
        {
            return ListIdentities(new ListIdentitiesRequest());
        }

        /// <summary>
        /// Returns a list containing all of the identities (email addresses and domains) for
        ///         a specific AWS Account, regardless of verification status.
        /// 
        ///         
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities service method.</param>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by SimpleEmailService.</returns>
        public ListIdentitiesResponse ListIdentities(ListIdentitiesRequest request)
        {
            var marshaller = new ListIdentitiesRequestMarshaller();
            var unmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListIdentitiesRequest,ListIdentitiesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentities operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentities
        ///         operation.</returns>
        public IAsyncResult BeginListIdentities(ListIdentitiesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListIdentitiesRequestMarshaller();
            var unmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return BeginInvoke<ListIdentitiesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentities operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentities.</param>
        /// 
        /// <returns>Returns a  ListIdentitiesResult from SimpleEmailService.</returns>
        public  ListIdentitiesResponse EndListIdentities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdentitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVerifiedEmailAddresses

        /// <summary>
        /// Returns a list containing all of the email addresses that have been verified.
        /// 
        ///         <important>The ListVerifiedEmailAddresses action is deprecated as of the May
        /// 15, 2012 release of         Domain Verification. The ListIdentities action is now
        /// preferred.</important>        
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by SimpleEmailService.</returns>
        public ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses()
        {
            return ListVerifiedEmailAddresses(new ListVerifiedEmailAddressesRequest());
        }

        /// <summary>
        /// Returns a list containing all of the email addresses that have been verified.
        /// 
        ///         <important>The ListVerifiedEmailAddresses action is deprecated as of the May
        /// 15, 2012 release of         Domain Verification. The ListIdentities action is now
        /// preferred.</important>        
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVerifiedEmailAddresses service method.</param>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by SimpleEmailService.</returns>
        public ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest request)
        {
            var marshaller = new ListVerifiedEmailAddressesRequestMarshaller();
            var unmarshaller = ListVerifiedEmailAddressesResponseUnmarshaller.Instance;

            return Invoke<ListVerifiedEmailAddressesRequest,ListVerifiedEmailAddressesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVerifiedEmailAddresses operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVerifiedEmailAddresses operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVerifiedEmailAddresses
        ///         operation.</returns>
        public IAsyncResult BeginListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListVerifiedEmailAddressesRequestMarshaller();
            var unmarshaller = ListVerifiedEmailAddressesResponseUnmarshaller.Instance;

            return BeginInvoke<ListVerifiedEmailAddressesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVerifiedEmailAddresses operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVerifiedEmailAddresses.</param>
        /// 
        /// <returns>Returns a  ListVerifiedEmailAddressesResult from SimpleEmailService.</returns>
        public  ListVerifiedEmailAddressesResponse EndListVerifiedEmailAddresses(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVerifiedEmailAddressesResponse>(asyncResult);
        }

        #endregion
        
        #region  SendEmail

        /// <summary>
        /// Composes an email message based on input data, and then immediately queues the message
        ///            for sending.        
        /// 
        ///         <important>            You can only send email from verified email addresses
        /// and domains.             If you have not requested production access to Amazon SES,
        /// you must also             verify every recipient email address except for the recipients
        /// provided             by the Amazon SES mailbox simulator. For more information, go
        /// to the            <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon
        /// SES                Developer Guide</a>.        </important>        
        /// <para>
        /// The total size of the message cannot exceed 10 MB.
        /// </para>
        ///         
        /// <para>
        /// Amazon SES has a limit on the total number of recipients per message: The combined
        /// number            of To:, CC: and BCC: email addresses cannot exceed 50. If you need
        /// to send an email            message to a larger audience, you can divide your recipient
        /// list into groups of 50 or            fewer, and then call Amazon SES repeatedly to
        /// send the message to each group.        
        /// </para>
        ///         
        /// <para>
        /// For every message that you send, the total number of recipients (To:, CC: and BCC:)
        /// is            counted against your            <i>sending quota</i>            - the
        /// maximum number of emails you can send in            a 24-hour period. For information
        /// about your sending quota, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Amazon
        /// SES                Developer Guide</a>.        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmail service method.</param>
        /// 
        /// <returns>The response from the SendEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more        information about what caused the error.
        /// </exception>
        public SendEmailResponse SendEmail(SendEmailRequest request)
        {
            var marshaller = new SendEmailRequestMarshaller();
            var unmarshaller = SendEmailResponseUnmarshaller.Instance;

            return Invoke<SendEmailRequest,SendEmailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendEmail operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendEmail operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendEmail
        ///         operation.</returns>
        public IAsyncResult BeginSendEmail(SendEmailRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SendEmailRequestMarshaller();
            var unmarshaller = SendEmailResponseUnmarshaller.Instance;

            return BeginInvoke<SendEmailRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendEmail operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendEmail.</param>
        /// 
        /// <returns>Returns a  SendEmailResult from SimpleEmailService.</returns>
        public  SendEmailResponse EndSendEmail(IAsyncResult asyncResult)
        {
            return EndInvoke<SendEmailResponse>(asyncResult);
        }

        #endregion
        
        #region  SendRawEmail

        /// <summary>
        /// Sends an email message, with header and content specified by the client. The     
        ///       <code>SendRawEmail</code>            action is useful for sending multipart
        /// MIME emails. The raw text of the message must comply with Internet            email
        /// standards; otherwise, the message cannot be sent.        
        /// 
        ///         <important>            You can only send email from verified email addresses
        /// and domains.             If you have not requested production access to Amazon SES,
        /// you must also             verify every recipient email address except for the recipients
        /// provided             by the Amazon SES mailbox simulator. For more information, go
        /// to the            <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon
        /// SES                Developer Guide</a>.        </important>        
        /// <para>
        /// The total size of the message cannot exceed 10 MB. This includes any attachments that
        /// are part of the message.
        /// </para>
        ///         
        /// <para>
        /// Amazon SES has a limit on the total number of recipients per message: The combined
        /// number            of To:, CC: and BCC: email addresses cannot exceed 50. If you need
        /// to send an email            message to a larger audience, you can divide your recipient
        /// list into groups of 50 or            fewer, and then call Amazon SES repeatedly to
        /// send the message to each group.        
        /// </para>
        ///         
        /// <para>
        /// The To:, CC:, and BCC: headers in the raw message can contain a group list. Note that
        /// each recipient in a group list         counts towards the 50-recipient limit.    
        ///    
        /// </para>
        ///         
        /// <para>
        /// For every message that you send, the total number of recipients (To:, CC: and BCC:)
        /// is            counted against your            <i>sending quota</i>            - the
        /// maximum number of emails you can send in            a 24-hour period. For information
        /// about your sending quota, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Amazon
        /// SES                Developer Guide</a>.        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendRawEmail service method.</param>
        /// 
        /// <returns>The response from the SendRawEmail service method, as returned by SimpleEmailService.</returns>
        /// <exception cref="Amazon.SimpleEmail.Model.MessageRejectedException">
        /// Indicates that the action failed, and the message could not be sent. Check the error
        /// stack for more        information about what caused the error.
        /// </exception>
        public SendRawEmailResponse SendRawEmail(SendRawEmailRequest request)
        {
            var marshaller = new SendRawEmailRequestMarshaller();
            var unmarshaller = SendRawEmailResponseUnmarshaller.Instance;

            return Invoke<SendRawEmailRequest,SendRawEmailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendRawEmail operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendRawEmail operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendRawEmail
        ///         operation.</returns>
        public IAsyncResult BeginSendRawEmail(SendRawEmailRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SendRawEmailRequestMarshaller();
            var unmarshaller = SendRawEmailResponseUnmarshaller.Instance;

            return BeginInvoke<SendRawEmailRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendRawEmail operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendRawEmail.</param>
        /// 
        /// <returns>Returns a  SendRawEmailResult from SimpleEmailService.</returns>
        public  SendRawEmailResponse EndSendRawEmail(IAsyncResult asyncResult)
        {
            return EndInvoke<SendRawEmailResponse>(asyncResult);
        }

        #endregion
        
        #region  SetIdentityDkimEnabled

        /// <summary>
        /// Enables or disables Easy DKIM signing of email sent from an identity:
        /// 
        ///             <ul>                <li>If Easy DKIM            signing is enabled for
        /// a domain name identity (e.g., <code>example.com</code>), then Amazon SES will DKIM-sign
        ///            all email sent by addresses under that domain name (e.g.,             
        ///       <code>user@example.com</code>).</li>                <li>If Easy DKIM signing
        /// is enabled for an email address, then Amazon SES will DKIM-sign            all email
        /// sent by that email address.</li>            </ul>        
        /// <para>
        /// For email addresses (e.g., <code>user@example.com</code>), you can only enable Easy
        /// DKIM signing  if the        corresponding domain (e.g., <code>example.com</code>)
        /// has been set up for Easy DKIM using the AWS Console or             the <code>VerifyDomainDkim</code>
        /// action.
        /// </para>
        ///         
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        ///         
        /// <para>
        /// For more information about Easy DKIM signing, go to the             <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityDkimEnabled service method.</param>
        /// 
        /// <returns>The response from the SetIdentityDkimEnabled service method, as returned by SimpleEmailService.</returns>
        public SetIdentityDkimEnabledResponse SetIdentityDkimEnabled(SetIdentityDkimEnabledRequest request)
        {
            var marshaller = new SetIdentityDkimEnabledRequestMarshaller();
            var unmarshaller = SetIdentityDkimEnabledResponseUnmarshaller.Instance;

            return Invoke<SetIdentityDkimEnabledRequest,SetIdentityDkimEnabledResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityDkimEnabled operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityDkimEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetIdentityDkimEnabled
        ///         operation.</returns>
        public IAsyncResult BeginSetIdentityDkimEnabled(SetIdentityDkimEnabledRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SetIdentityDkimEnabledRequestMarshaller();
            var unmarshaller = SetIdentityDkimEnabledResponseUnmarshaller.Instance;

            return BeginInvoke<SetIdentityDkimEnabledRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetIdentityDkimEnabled operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIdentityDkimEnabled.</param>
        /// 
        /// <returns>Returns a  SetIdentityDkimEnabledResult from SimpleEmailService.</returns>
        public  SetIdentityDkimEnabledResponse EndSetIdentityDkimEnabled(IAsyncResult asyncResult)
        {
            return EndInvoke<SetIdentityDkimEnabledResponse>(asyncResult);
        }

        #endregion
        
        #region  SetIdentityFeedbackForwardingEnabled

        /// <summary>
        /// Given an identity (email address or domain), enables or disables whether Amazon SES
        /// forwards            bounce and complaint notifications as email. Feedback forwarding
        /// can only be disabled when            Amazon Simple Notification Service (Amazon SNS)
        /// topics are specified for both bounces and complaints.
        /// 
        ///         <note>Feedback forwarding does not apply to delivery notifications.      
        ///      Delivery notifications are only available through Amazon SNS.</note>        
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        ///         
        /// <para>
        /// For more information about using notifications with Amazon SES,            see the
        /// <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityFeedbackForwardingEnabled service method.</param>
        /// 
        /// <returns>The response from the SetIdentityFeedbackForwardingEnabled service method, as returned by SimpleEmailService.</returns>
        public SetIdentityFeedbackForwardingEnabledResponse SetIdentityFeedbackForwardingEnabled(SetIdentityFeedbackForwardingEnabledRequest request)
        {
            var marshaller = new SetIdentityFeedbackForwardingEnabledRequestMarshaller();
            var unmarshaller = SetIdentityFeedbackForwardingEnabledResponseUnmarshaller.Instance;

            return Invoke<SetIdentityFeedbackForwardingEnabledRequest,SetIdentityFeedbackForwardingEnabledResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityFeedbackForwardingEnabled operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityFeedbackForwardingEnabled operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetIdentityFeedbackForwardingEnabled
        ///         operation.</returns>
        public IAsyncResult BeginSetIdentityFeedbackForwardingEnabled(SetIdentityFeedbackForwardingEnabledRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SetIdentityFeedbackForwardingEnabledRequestMarshaller();
            var unmarshaller = SetIdentityFeedbackForwardingEnabledResponseUnmarshaller.Instance;

            return BeginInvoke<SetIdentityFeedbackForwardingEnabledRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetIdentityFeedbackForwardingEnabled operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIdentityFeedbackForwardingEnabled.</param>
        /// 
        /// <returns>Returns a  SetIdentityFeedbackForwardingEnabledResult from SimpleEmailService.</returns>
        public  SetIdentityFeedbackForwardingEnabledResponse EndSetIdentityFeedbackForwardingEnabled(IAsyncResult asyncResult)
        {
            return EndInvoke<SetIdentityFeedbackForwardingEnabledResponse>(asyncResult);
        }

        #endregion
        
        #region  SetIdentityNotificationTopic

        /// <summary>
        /// Given an identity (email address or domain), sets the Amazon Simple Notification Service
        /// (Amazon SNS) topic to which Amazon SES will publish        bounce, complaint, and/or
        /// delivery notifications for emails sent with that identity as the <code>Source</code>.
        /// 
        ///         <note>Unless feedback forwarding is enabled, you must specify Amazon SNS topics
        /// for bounce and complaint notifications.            For more information, see <code>SetIdentityFeedbackForwardingEnabled</code>.
        ///        </note>        
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        ///         
        /// <para>
        /// For more information about feedback notification, see the            <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityNotificationTopic service method.</param>
        /// 
        /// <returns>The response from the SetIdentityNotificationTopic service method, as returned by SimpleEmailService.</returns>
        public SetIdentityNotificationTopicResponse SetIdentityNotificationTopic(SetIdentityNotificationTopicRequest request)
        {
            var marshaller = new SetIdentityNotificationTopicRequestMarshaller();
            var unmarshaller = SetIdentityNotificationTopicResponseUnmarshaller.Instance;

            return Invoke<SetIdentityNotificationTopicRequest,SetIdentityNotificationTopicResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityNotificationTopic operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityNotificationTopic operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetIdentityNotificationTopic
        ///         operation.</returns>
        public IAsyncResult BeginSetIdentityNotificationTopic(SetIdentityNotificationTopicRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SetIdentityNotificationTopicRequestMarshaller();
            var unmarshaller = SetIdentityNotificationTopicResponseUnmarshaller.Instance;

            return BeginInvoke<SetIdentityNotificationTopicRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetIdentityNotificationTopic operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIdentityNotificationTopic.</param>
        /// 
        /// <returns>Returns a  SetIdentityNotificationTopicResult from SimpleEmailService.</returns>
        public  SetIdentityNotificationTopicResponse EndSetIdentityNotificationTopic(IAsyncResult asyncResult)
        {
            return EndInvoke<SetIdentityNotificationTopicResponse>(asyncResult);
        }

        #endregion
        
        #region  VerifyDomainDkim

        /// <summary>
        /// Returns a set of DKIM tokens for a domain. DKIM <i>tokens</i> are character strings
        /// that            represent your domain's identity. Using these tokens, you will need
        /// to create DNS CNAME            records that point to DKIM public keys hosted by Amazon
        /// SES. Amazon Web Services will            eventually detect that you have updated your
        /// DNS records; this detection process may            take up to 72 hours. Upon successful
        /// detection, Amazon SES will be able to DKIM-sign            email originating from
        /// that domain.
        /// 
        ///         
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        ///         
        /// <para>
        /// To enable or disable Easy DKIM signing for            a domain, use the <code>SetIdentityDkimEnabled</code>
        /// action.
        /// </para>
        ///         
        /// <para>
        /// For more information about creating DNS records using DKIM tokens, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim-dns-records.html">Amazon
        /// SES                Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainDkim service method.</param>
        /// 
        /// <returns>The response from the VerifyDomainDkim service method, as returned by SimpleEmailService.</returns>
        public VerifyDomainDkimResponse VerifyDomainDkim(VerifyDomainDkimRequest request)
        {
            var marshaller = new VerifyDomainDkimRequestMarshaller();
            var unmarshaller = VerifyDomainDkimResponseUnmarshaller.Instance;

            return Invoke<VerifyDomainDkimRequest,VerifyDomainDkimResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyDomainDkim operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainDkim operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyDomainDkim
        ///         operation.</returns>
        public IAsyncResult BeginVerifyDomainDkim(VerifyDomainDkimRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new VerifyDomainDkimRequestMarshaller();
            var unmarshaller = VerifyDomainDkimResponseUnmarshaller.Instance;

            return BeginInvoke<VerifyDomainDkimRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyDomainDkim operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyDomainDkim.</param>
        /// 
        /// <returns>Returns a  VerifyDomainDkimResult from SimpleEmailService.</returns>
        public  VerifyDomainDkimResponse EndVerifyDomainDkim(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyDomainDkimResponse>(asyncResult);
        }

        #endregion
        
        #region  VerifyDomainIdentity

        /// <summary>
        /// Verifies a domain.
        /// 
        ///         
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainIdentity service method.</param>
        /// 
        /// <returns>The response from the VerifyDomainIdentity service method, as returned by SimpleEmailService.</returns>
        public VerifyDomainIdentityResponse VerifyDomainIdentity(VerifyDomainIdentityRequest request)
        {
            var marshaller = new VerifyDomainIdentityRequestMarshaller();
            var unmarshaller = VerifyDomainIdentityResponseUnmarshaller.Instance;

            return Invoke<VerifyDomainIdentityRequest,VerifyDomainIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyDomainIdentity operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyDomainIdentity operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyDomainIdentity
        ///         operation.</returns>
        public IAsyncResult BeginVerifyDomainIdentity(VerifyDomainIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new VerifyDomainIdentityRequestMarshaller();
            var unmarshaller = VerifyDomainIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<VerifyDomainIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyDomainIdentity operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyDomainIdentity.</param>
        /// 
        /// <returns>Returns a  VerifyDomainIdentityResult from SimpleEmailService.</returns>
        public  VerifyDomainIdentityResponse EndVerifyDomainIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyDomainIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  VerifyEmailAddress

        /// <summary>
        /// Verifies an email address. This action causes a confirmation email message to be 
        ///        sent to the specified address.
        /// 
        ///         <important>The VerifyEmailAddress action is deprecated as of the May 15, 2012
        /// release        of Domain Verification. The VerifyEmailIdentity action is now preferred.</important>
        ///        
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailAddress service method.</param>
        /// 
        /// <returns>The response from the VerifyEmailAddress service method, as returned by SimpleEmailService.</returns>
        public VerifyEmailAddressResponse VerifyEmailAddress(VerifyEmailAddressRequest request)
        {
            var marshaller = new VerifyEmailAddressRequestMarshaller();
            var unmarshaller = VerifyEmailAddressResponseUnmarshaller.Instance;

            return Invoke<VerifyEmailAddressRequest,VerifyEmailAddressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyEmailAddress operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailAddress operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyEmailAddress
        ///         operation.</returns>
        public IAsyncResult BeginVerifyEmailAddress(VerifyEmailAddressRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new VerifyEmailAddressRequestMarshaller();
            var unmarshaller = VerifyEmailAddressResponseUnmarshaller.Instance;

            return BeginInvoke<VerifyEmailAddressRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyEmailAddress operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyEmailAddress.</param>
        /// 
        /// <returns>Returns a  VerifyEmailAddressResult from SimpleEmailService.</returns>
        public  VerifyEmailAddressResponse EndVerifyEmailAddress(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyEmailAddressResponse>(asyncResult);
        }

        #endregion
        
        #region  VerifyEmailIdentity

        /// <summary>
        /// Verifies an email address. This action causes a confirmation email message       
        /// to be sent to the specified address.
        /// 
        ///         
        /// <para>
        /// This action is throttled at one request per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the VerifyEmailIdentity service method, as returned by SimpleEmailService.</returns>
        public VerifyEmailIdentityResponse VerifyEmailIdentity(VerifyEmailIdentityRequest request)
        {
            var marshaller = new VerifyEmailIdentityRequestMarshaller();
            var unmarshaller = VerifyEmailIdentityResponseUnmarshaller.Instance;

            return Invoke<VerifyEmailIdentityRequest,VerifyEmailIdentityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyEmailIdentity operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyEmailIdentity operation on AmazonSimpleEmailServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyEmailIdentity
        ///         operation.</returns>
        public IAsyncResult BeginVerifyEmailIdentity(VerifyEmailIdentityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new VerifyEmailIdentityRequestMarshaller();
            var unmarshaller = VerifyEmailIdentityResponseUnmarshaller.Instance;

            return BeginInvoke<VerifyEmailIdentityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyEmailIdentity operation.
        /// <seealso cref="Amazon.SimpleEmail.IAmazonSimpleEmailService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyEmailIdentity.</param>
        /// 
        /// <returns>Returns a  VerifyEmailIdentityResult from SimpleEmailService.</returns>
        public  VerifyEmailIdentityResponse EndVerifyEmailIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyEmailIdentityResponse>(asyncResult);
        }

        #endregion
        
    }
}