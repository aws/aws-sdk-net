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

using Amazon.SimpleEmail.Model;
using Amazon.SimpleEmail.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.SimpleEmail
{
    /// <summary>
    /// Implementation for accessing AmazonSimpleEmailService.
    ///  
    /// Amazon Simple Email Service <para> This is the API Reference for Amazon Simple Email Service (Amazon SES). This documentation is intended to
    /// be used in conjunction with the Amazon SES Getting Started Guide and the Amazon SES Developer Guide. </para> <para> For specific details on
    /// how to construct a service request, please consult the Amazon SES Developer Guide. </para> <para><b>NOTE:</b>The endpoint for Amazon SES is
    /// located at: https://email.us-east-1.amazonaws.com </para>
    /// </summary>
    public class AmazonSimpleEmailServiceClient : AmazonWebServiceClient, AmazonSimpleEmailService
    {
    
        AbstractAWSSigner signer = new AWS3Signer();

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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSimpleEmailServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleEmailServiceConfig(), true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with the credentials loaded from the application's
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
        public AmazonSimpleEmailServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleEmailServiceConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimpleEmailService Configuration Object</param>        
        public AmazonSimpleEmailServiceClient(AmazonSimpleEmailServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User) { }

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
            : this(credentials, new AmazonSimpleEmailServiceConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleEmailServiceClient with AWS Credentials and an
        /// AmazonSimpleEmailServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(AWSCredentials credentials, AmazonSimpleEmailServiceConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User)
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
        /// AmazonSimpleEmailServiceClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleEmailServiceClient Configuration Object</param>
        public AmazonSimpleEmailServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleEmailServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User)
        {
        }
        

        #endregion
   
        #region DeleteIdentity

        /// <summary>
        /// <para>Deletes the specified identity (email address or domain) from the list of verified identities.</para>
        /// </summary>
        /// 
        /// <param name="deleteIdentityRequest">Container for the necessary parameters to execute the DeleteIdentity service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the DeleteIdentity service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public DeleteIdentityResponse DeleteIdentity(DeleteIdentityRequest deleteIdentityRequest)
        {
            IAsyncResult asyncResult = invokeDeleteIdentity(deleteIdentityRequest, null, null, true);
            return EndDeleteIdentity(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentity operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.DeleteIdentity"/>
        /// </summary>
        /// 
        /// <param name="deleteIdentityRequest">Container for the necessary parameters to execute the DeleteIdentity operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdentity
        ///         operation.</returns>
        public IAsyncResult BeginDeleteIdentity(DeleteIdentityRequest deleteIdentityRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteIdentity(deleteIdentityRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteIdentity operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.DeleteIdentity"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentity.</param>
        /// 
        /// <returns>Returns a DeleteIdentityResult from AmazonSimpleEmailService.</returns>
        public DeleteIdentityResponse EndDeleteIdentity(IAsyncResult asyncResult)
        {
            return endOperation<DeleteIdentityResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteIdentity(DeleteIdentityRequest deleteIdentityRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteIdentityRequestMarshaller().Marshall(deleteIdentityRequest);
            var unmarshaller = DeleteIdentityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListVerifiedEmailAddresses

        /// <summary>
        /// <para>Returns a list containing all of the email addresses that have been verified.</para> <para><b>IMPORTANT:</b>The
        /// ListVerifiedEmailAddresses action is deprecated as of the May 15, 2012 release of Domain Verification. The ListIdentities action is now
        /// preferred.</para>
        /// </summary>
        /// 
        /// <param name="listVerifiedEmailAddressesRequest">Container for the necessary parameters to execute the ListVerifiedEmailAddresses service
        ///          method on AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest listVerifiedEmailAddressesRequest)
        {
            IAsyncResult asyncResult = invokeListVerifiedEmailAddresses(listVerifiedEmailAddressesRequest, null, null, true);
            return EndListVerifiedEmailAddresses(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListVerifiedEmailAddresses operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.ListVerifiedEmailAddresses"/>
        /// </summary>
        /// 
        /// <param name="listVerifiedEmailAddressesRequest">Container for the necessary parameters to execute the ListVerifiedEmailAddresses operation
        ///          on AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListVerifiedEmailAddresses operation.</returns>
        public IAsyncResult BeginListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest listVerifiedEmailAddressesRequest, AsyncCallback callback, object state)
        {
            return invokeListVerifiedEmailAddresses(listVerifiedEmailAddressesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListVerifiedEmailAddresses operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.ListVerifiedEmailAddresses"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVerifiedEmailAddresses.</param>
        /// 
        /// <returns>Returns a ListVerifiedEmailAddressesResult from AmazonSimpleEmailService.</returns>
        public ListVerifiedEmailAddressesResponse EndListVerifiedEmailAddresses(IAsyncResult asyncResult)
        {
            return endOperation<ListVerifiedEmailAddressesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListVerifiedEmailAddresses(ListVerifiedEmailAddressesRequest listVerifiedEmailAddressesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListVerifiedEmailAddressesRequestMarshaller().Marshall(listVerifiedEmailAddressesRequest);
            var unmarshaller = ListVerifiedEmailAddressesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns a list containing all of the email addresses that have been verified.</para> <para><b>IMPORTANT:</b>The
        /// ListVerifiedEmailAddresses action is deprecated as of the May 15, 2012 release of Domain Verification. The ListIdentities action is now
        /// preferred.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public ListVerifiedEmailAddressesResponse ListVerifiedEmailAddresses()
        {
            return ListVerifiedEmailAddresses(new ListVerifiedEmailAddressesRequest());
        }
        

        #endregion
    
        #region GetSendStatistics

        /// <summary>
        /// <para>Returns the user's sending statistics. The result is a list of data points, representing the last two weeks of sending activity.
        /// </para> <para>Each data point in the list contains statistics for a 15-minute interval.</para>
        /// </summary>
        /// 
        /// <param name="getSendStatisticsRequest">Container for the necessary parameters to execute the GetSendStatistics service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public GetSendStatisticsResponse GetSendStatistics(GetSendStatisticsRequest getSendStatisticsRequest)
        {
            IAsyncResult asyncResult = invokeGetSendStatistics(getSendStatisticsRequest, null, null, true);
            return EndGetSendStatistics(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetSendStatistics operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.GetSendStatistics"/>
        /// </summary>
        /// 
        /// <param name="getSendStatisticsRequest">Container for the necessary parameters to execute the GetSendStatistics operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSendStatistics
        ///         operation.</returns>
        public IAsyncResult BeginGetSendStatistics(GetSendStatisticsRequest getSendStatisticsRequest, AsyncCallback callback, object state)
        {
            return invokeGetSendStatistics(getSendStatisticsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetSendStatistics operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.GetSendStatistics"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSendStatistics.</param>
        /// 
        /// <returns>Returns a GetSendStatisticsResult from AmazonSimpleEmailService.</returns>
        public GetSendStatisticsResponse EndGetSendStatistics(IAsyncResult asyncResult)
        {
            return endOperation<GetSendStatisticsResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetSendStatistics(GetSendStatisticsRequest getSendStatisticsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetSendStatisticsRequestMarshaller().Marshall(getSendStatisticsRequest);
            var unmarshaller = GetSendStatisticsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns the user's sending statistics. The result is a list of data points, representing the last two weeks of sending activity.
        /// </para> <para>Each data point in the list contains statistics for a 15-minute interval.</para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public GetSendStatisticsResponse GetSendStatistics()
        {
            return GetSendStatistics(new GetSendStatisticsRequest());
        }
        

        #endregion
    
        #region VerifyEmailIdentity

        /// <summary>
        /// <para>Verifies an email address. This action causes a confirmation email message to be sent to the specified address.</para>
        /// </summary>
        /// 
        /// <param name="verifyEmailIdentityRequest">Container for the necessary parameters to execute the VerifyEmailIdentity service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the VerifyEmailIdentity service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public VerifyEmailIdentityResponse VerifyEmailIdentity(VerifyEmailIdentityRequest verifyEmailIdentityRequest)
        {
            IAsyncResult asyncResult = invokeVerifyEmailIdentity(verifyEmailIdentityRequest, null, null, true);
            return EndVerifyEmailIdentity(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyEmailIdentity operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.VerifyEmailIdentity"/>
        /// </summary>
        /// 
        /// <param name="verifyEmailIdentityRequest">Container for the necessary parameters to execute the VerifyEmailIdentity operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndVerifyEmailIdentity operation.</returns>
        public IAsyncResult BeginVerifyEmailIdentity(VerifyEmailIdentityRequest verifyEmailIdentityRequest, AsyncCallback callback, object state)
        {
            return invokeVerifyEmailIdentity(verifyEmailIdentityRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the VerifyEmailIdentity operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.VerifyEmailIdentity"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyEmailIdentity.</param>
        /// 
        /// <returns>Returns a VerifyEmailIdentityResult from AmazonSimpleEmailService.</returns>
        public VerifyEmailIdentityResponse EndVerifyEmailIdentity(IAsyncResult asyncResult)
        {
            return endOperation<VerifyEmailIdentityResponse>(asyncResult);
        }
        
        IAsyncResult invokeVerifyEmailIdentity(VerifyEmailIdentityRequest verifyEmailIdentityRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new VerifyEmailIdentityRequestMarshaller().Marshall(verifyEmailIdentityRequest);
            var unmarshaller = VerifyEmailIdentityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetIdentityNotificationAttributes

        /// <summary>
        /// <para>Given a list of verified identities (email addresses and/or domains), returns a structure describing identity notification attributes.
        /// For more information about feedback notification, see the Amazon SES Developer Guide.</para>
        /// </summary>
        /// 
        /// <param name="getIdentityNotificationAttributesRequest">Container for the necessary parameters to execute the
        ///          GetIdentityNotificationAttributes service method on AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the GetIdentityNotificationAttributes service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public GetIdentityNotificationAttributesResponse GetIdentityNotificationAttributes(GetIdentityNotificationAttributesRequest getIdentityNotificationAttributesRequest)
        {
            IAsyncResult asyncResult = invokeGetIdentityNotificationAttributes(getIdentityNotificationAttributesRequest, null, null, true);
            return EndGetIdentityNotificationAttributes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityNotificationAttributes operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.GetIdentityNotificationAttributes"/>
        /// </summary>
        /// 
        /// <param name="getIdentityNotificationAttributesRequest">Container for the necessary parameters to execute the
        ///          GetIdentityNotificationAttributes operation on AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetIdentityNotificationAttributes operation.</returns>
        public IAsyncResult BeginGetIdentityNotificationAttributes(GetIdentityNotificationAttributesRequest getIdentityNotificationAttributesRequest, AsyncCallback callback, object state)
        {
            return invokeGetIdentityNotificationAttributes(getIdentityNotificationAttributesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetIdentityNotificationAttributes operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.GetIdentityNotificationAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityNotificationAttributes.</param>
        /// 
        /// <returns>Returns a GetIdentityNotificationAttributesResult from AmazonSimpleEmailService.</returns>
        public GetIdentityNotificationAttributesResponse EndGetIdentityNotificationAttributes(IAsyncResult asyncResult)
        {
            return endOperation<GetIdentityNotificationAttributesResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetIdentityNotificationAttributes(GetIdentityNotificationAttributesRequest getIdentityNotificationAttributesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetIdentityNotificationAttributesRequestMarshaller().Marshall(getIdentityNotificationAttributesRequest);
            var unmarshaller = GetIdentityNotificationAttributesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region VerifyDomainDkim

        /// <summary>
        /// <para>Returns a set of DNS records, or <i>tokens</i> , that must be published in the domain name's DNS to complete the DKIM verification
        /// process. These tokens are DNS <c>CNAME</c> records that point to DKIM public keys hosted by Amazon SES. To complete the DKIM verification
        /// process, these tokens must be published in the domain's DNS. The tokens must remain published in order for Easy DKIM signing to function
        /// correctly.</para> <para>After the tokens are added to the domain's DNS, Amazon SES will be able to DKIM-sign email originating from that
        /// domain. To enable or disable Easy DKIM signing for a domain, use the <c>SetIdentityDkimEnabled</c> action.</para> <para>For more information
        /// about Easy DKIM, go to the Amazon SES Developer Guide.</para>
        /// </summary>
        /// 
        /// <param name="verifyDomainDkimRequest">Container for the necessary parameters to execute the VerifyDomainDkim service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the VerifyDomainDkim service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public VerifyDomainDkimResponse VerifyDomainDkim(VerifyDomainDkimRequest verifyDomainDkimRequest)
        {
            IAsyncResult asyncResult = invokeVerifyDomainDkim(verifyDomainDkimRequest, null, null, true);
            return EndVerifyDomainDkim(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyDomainDkim operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.VerifyDomainDkim"/>
        /// </summary>
        /// 
        /// <param name="verifyDomainDkimRequest">Container for the necessary parameters to execute the VerifyDomainDkim operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyDomainDkim
        ///         operation.</returns>
        public IAsyncResult BeginVerifyDomainDkim(VerifyDomainDkimRequest verifyDomainDkimRequest, AsyncCallback callback, object state)
        {
            return invokeVerifyDomainDkim(verifyDomainDkimRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the VerifyDomainDkim operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.VerifyDomainDkim"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyDomainDkim.</param>
        /// 
        /// <returns>Returns a VerifyDomainDkimResult from AmazonSimpleEmailService.</returns>
        public VerifyDomainDkimResponse EndVerifyDomainDkim(IAsyncResult asyncResult)
        {
            return endOperation<VerifyDomainDkimResponse>(asyncResult);
        }
        
        IAsyncResult invokeVerifyDomainDkim(VerifyDomainDkimRequest verifyDomainDkimRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new VerifyDomainDkimRequestMarshaller().Marshall(verifyDomainDkimRequest);
            var unmarshaller = VerifyDomainDkimResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetIdentityDkimAttributes

        /// <summary>
        /// <para>Returns the DNS records, or <i>tokens</i> , that must be present in order for Easy DKIM to sign outgoing email messages.</para>
        /// <para>This action takes a list of verified identities as input. It then returns the following information for each identity:</para>
        /// <ul>
        /// <li>Whether Easy DKIM signing is enabled or disabled.</li>
        /// <li>The set of tokens that are required for Easy DKIM signing. These tokens must be published in the domain name's DNS records in order
        /// for DKIM verification to complete, and must remain published in order for Easy DKIM signing to operate correctly. (This information is only
        /// returned for domain name identities, not for email addresses.)</li>
        /// <li>Whether Amazon SES has successfully verified the DKIM tokens published in the domain name's DNS. (This information is only returned for
        /// domain name identities, not for email addresses.)</li>
        /// 
        /// </ul>
        /// <para>For more information about Easy DKIM signing, go to the Amazon SES Developer Guide.</para>
        /// </summary>
        /// 
        /// <param name="getIdentityDkimAttributesRequest">Container for the necessary parameters to execute the GetIdentityDkimAttributes service
        ///          method on AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the GetIdentityDkimAttributes service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public GetIdentityDkimAttributesResponse GetIdentityDkimAttributes(GetIdentityDkimAttributesRequest getIdentityDkimAttributesRequest)
        {
            IAsyncResult asyncResult = invokeGetIdentityDkimAttributes(getIdentityDkimAttributesRequest, null, null, true);
            return EndGetIdentityDkimAttributes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityDkimAttributes operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.GetIdentityDkimAttributes"/>
        /// </summary>
        /// 
        /// <param name="getIdentityDkimAttributesRequest">Container for the necessary parameters to execute the GetIdentityDkimAttributes operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetIdentityDkimAttributes operation.</returns>
        public IAsyncResult BeginGetIdentityDkimAttributes(GetIdentityDkimAttributesRequest getIdentityDkimAttributesRequest, AsyncCallback callback, object state)
        {
            return invokeGetIdentityDkimAttributes(getIdentityDkimAttributesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetIdentityDkimAttributes operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.GetIdentityDkimAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityDkimAttributes.</param>
        /// 
        /// <returns>Returns a GetIdentityDkimAttributesResult from AmazonSimpleEmailService.</returns>
        public GetIdentityDkimAttributesResponse EndGetIdentityDkimAttributes(IAsyncResult asyncResult)
        {
            return endOperation<GetIdentityDkimAttributesResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetIdentityDkimAttributes(GetIdentityDkimAttributesRequest getIdentityDkimAttributesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetIdentityDkimAttributesRequestMarshaller().Marshall(getIdentityDkimAttributesRequest);
            var unmarshaller = GetIdentityDkimAttributesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region VerifyEmailAddress

        /// <summary>
        /// <para>Verifies an email address. This action causes a confirmation email message to be sent to the specified address.</para>
        /// <para><b>IMPORTANT:</b>The VerifyEmailAddress action is deprecated as of the May 15, 2012 release of Domain Verification. The
        /// VerifyEmailIdentity action is now preferred.</para>
        /// </summary>
        /// 
        /// <param name="verifyEmailAddressRequest">Container for the necessary parameters to execute the VerifyEmailAddress service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        public VerifyEmailAddressResponse VerifyEmailAddress(VerifyEmailAddressRequest verifyEmailAddressRequest)
        {
            IAsyncResult asyncResult = invokeVerifyEmailAddress(verifyEmailAddressRequest, null, null, true);
            return EndVerifyEmailAddress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyEmailAddress operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.VerifyEmailAddress"/>
        /// </summary>
        /// 
        /// <param name="verifyEmailAddressRequest">Container for the necessary parameters to execute the VerifyEmailAddress operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginVerifyEmailAddress(VerifyEmailAddressRequest verifyEmailAddressRequest, AsyncCallback callback, object state)
        {
            return invokeVerifyEmailAddress(verifyEmailAddressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the VerifyEmailAddress operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.VerifyEmailAddress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyEmailAddress.</param>
        public VerifyEmailAddressResponse EndVerifyEmailAddress(IAsyncResult asyncResult)
        {
            return endOperation<VerifyEmailAddressResponse>(asyncResult);
        }
        
        IAsyncResult invokeVerifyEmailAddress(VerifyEmailAddressRequest verifyEmailAddressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new VerifyEmailAddressRequestMarshaller().Marshall(verifyEmailAddressRequest);
            var unmarshaller = VerifyEmailAddressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SendRawEmail

        /// <summary>
        /// <para>Sends an email message, with header and content specified by the client. The <c>SendRawEmail</c> action is useful for sending
        /// multipart MIME emails. The raw text of the message must comply with Internet email standards; otherwise, the message cannot be sent. </para>
        /// <para><b>IMPORTANT:</b>If you have not yet requested production access to Amazon SES, then you will only be able to send email to and from
        /// verified email addresses and domains. For more information, go to the Amazon SES Developer Guide. </para> <para>The total size of the
        /// message cannot exceed 10 MB. This includes any attachments that are part of the message.</para> <para>Amazon SES has a limit on the total
        /// number of recipients per message: The combined number of To:, CC: and BCC: email addresses cannot exceed 50. If you need to send an email
        /// message to a larger audience, you can divide your recipient list into groups of 50 or fewer, and then call Amazon SES repeatedly to send the
        /// message to each group. </para> <para>For every message that you send, the total number of recipients (To:, CC: and BCC:) is counted against
        /// your <i>sending quota</i> - the maximum number of emails you can send in a 24-hour period. For information about your sending quota, go to
        /// the "Managing Your Sending Activity" section of theAmazon SES Developer Guide. </para>
        /// </summary>
        /// 
        /// <param name="sendRawEmailRequest">Container for the necessary parameters to execute the SendRawEmail service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the SendRawEmail service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        /// <exception cref="MessageRejectedException"/>
        public SendRawEmailResponse SendRawEmail(SendRawEmailRequest sendRawEmailRequest)
        {
            IAsyncResult asyncResult = invokeSendRawEmail(sendRawEmailRequest, null, null, true);
            return EndSendRawEmail(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SendRawEmail operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SendRawEmail"/>
        /// </summary>
        /// 
        /// <param name="sendRawEmailRequest">Container for the necessary parameters to execute the SendRawEmail operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendRawEmail
        ///         operation.</returns>
        public IAsyncResult BeginSendRawEmail(SendRawEmailRequest sendRawEmailRequest, AsyncCallback callback, object state)
        {
            return invokeSendRawEmail(sendRawEmailRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SendRawEmail operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SendRawEmail"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendRawEmail.</param>
        /// 
        /// <returns>Returns a SendRawEmailResult from AmazonSimpleEmailService.</returns>
        public SendRawEmailResponse EndSendRawEmail(IAsyncResult asyncResult)
        {
            return endOperation<SendRawEmailResponse>(asyncResult);
        }
        
        IAsyncResult invokeSendRawEmail(SendRawEmailRequest sendRawEmailRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SendRawEmailRequestMarshaller().Marshall(sendRawEmailRequest);
            var unmarshaller = SendRawEmailResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListIdentities

        /// <summary>
        /// <para>Returns a list containing all of the identities (email addresses and domains) for a specific AWS Account, regardless of verification
        /// status.</para>
        /// </summary>
        /// 
        /// <param name="listIdentitiesRequest">Container for the necessary parameters to execute the ListIdentities service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public ListIdentitiesResponse ListIdentities(ListIdentitiesRequest listIdentitiesRequest)
        {
            IAsyncResult asyncResult = invokeListIdentities(listIdentitiesRequest, null, null, true);
            return EndListIdentities(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentities operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.ListIdentities"/>
        /// </summary>
        /// 
        /// <param name="listIdentitiesRequest">Container for the necessary parameters to execute the ListIdentities operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentities
        ///         operation.</returns>
        public IAsyncResult BeginListIdentities(ListIdentitiesRequest listIdentitiesRequest, AsyncCallback callback, object state)
        {
            return invokeListIdentities(listIdentitiesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListIdentities operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.ListIdentities"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentities.</param>
        /// 
        /// <returns>Returns a ListIdentitiesResult from AmazonSimpleEmailService.</returns>
        public ListIdentitiesResponse EndListIdentities(IAsyncResult asyncResult)
        {
            return endOperation<ListIdentitiesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListIdentities(ListIdentitiesRequest listIdentitiesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListIdentitiesRequestMarshaller().Marshall(listIdentitiesRequest);
            var unmarshaller = ListIdentitiesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns a list containing all of the identities (email addresses and domains) for a specific AWS Account, regardless of verification
        /// status.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public ListIdentitiesResponse ListIdentities()
        {
            return ListIdentities(new ListIdentitiesRequest());
        }
        

        #endregion
    
        #region GetIdentityVerificationAttributes

        /// <summary>
        /// <para>Given a list of identities (email addresses and/or domains), returns the verification status and (for domain identities) the
        /// verification token for each identity.</para>
        /// </summary>
        /// 
        /// <param name="getIdentityVerificationAttributesRequest">Container for the necessary parameters to execute the
        ///          GetIdentityVerificationAttributes service method on AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the GetIdentityVerificationAttributes service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public GetIdentityVerificationAttributesResponse GetIdentityVerificationAttributes(GetIdentityVerificationAttributesRequest getIdentityVerificationAttributesRequest)
        {
            IAsyncResult asyncResult = invokeGetIdentityVerificationAttributes(getIdentityVerificationAttributesRequest, null, null, true);
            return EndGetIdentityVerificationAttributes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityVerificationAttributes operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.GetIdentityVerificationAttributes"/>
        /// </summary>
        /// 
        /// <param name="getIdentityVerificationAttributesRequest">Container for the necessary parameters to execute the
        ///          GetIdentityVerificationAttributes operation on AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetIdentityVerificationAttributes operation.</returns>
        public IAsyncResult BeginGetIdentityVerificationAttributes(GetIdentityVerificationAttributesRequest getIdentityVerificationAttributesRequest, AsyncCallback callback, object state)
        {
            return invokeGetIdentityVerificationAttributes(getIdentityVerificationAttributesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetIdentityVerificationAttributes operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.GetIdentityVerificationAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityVerificationAttributes.</param>
        /// 
        /// <returns>Returns a GetIdentityVerificationAttributesResult from AmazonSimpleEmailService.</returns>
        public GetIdentityVerificationAttributesResponse EndGetIdentityVerificationAttributes(IAsyncResult asyncResult)
        {
            return endOperation<GetIdentityVerificationAttributesResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetIdentityVerificationAttributes(GetIdentityVerificationAttributesRequest getIdentityVerificationAttributesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetIdentityVerificationAttributesRequestMarshaller().Marshall(getIdentityVerificationAttributesRequest);
            var unmarshaller = GetIdentityVerificationAttributesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetIdentityDkimEnabled

        /// <summary>
        /// <para>Enables or disables Easy DKIM signing of email sent from an identity:</para>
        /// <ul>
        /// <li>If Easy DKIM signing is enabled for a domain name identity (e.g., <c>example.com</c> ), then Amazon SES will DKIM-sign all email sent
        /// by addresses under that domain name (e.g., <c>user@example.com</c> ).</li>
        /// <li>If Easy DKIM signing is enabled for an email address, then Amazon SES will DKIM-sign all email sent by that email address.</li>
        /// 
        /// </ul>
        /// <para>For email addresses (e.g., <c>user@example.com</c> ), you can only enable Easy DKIM signing if the corresponding domain (e.g.,
        /// <c>example.com</c> ) has been set up for Easy DKIM using the AWS Console or the <c>VerifyDomainDkim</c> action.</para> <para>For more
        /// information about Easy DKIM signing, go to the Amazon SES Developer Guide.</para>
        /// </summary>
        /// 
        /// <param name="setIdentityDkimEnabledRequest">Container for the necessary parameters to execute the SetIdentityDkimEnabled service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the SetIdentityDkimEnabled service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public SetIdentityDkimEnabledResponse SetIdentityDkimEnabled(SetIdentityDkimEnabledRequest setIdentityDkimEnabledRequest)
        {
            IAsyncResult asyncResult = invokeSetIdentityDkimEnabled(setIdentityDkimEnabledRequest, null, null, true);
            return EndSetIdentityDkimEnabled(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityDkimEnabled operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SetIdentityDkimEnabled"/>
        /// </summary>
        /// 
        /// <param name="setIdentityDkimEnabledRequest">Container for the necessary parameters to execute the SetIdentityDkimEnabled operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndSetIdentityDkimEnabled operation.</returns>
        public IAsyncResult BeginSetIdentityDkimEnabled(SetIdentityDkimEnabledRequest setIdentityDkimEnabledRequest, AsyncCallback callback, object state)
        {
            return invokeSetIdentityDkimEnabled(setIdentityDkimEnabledRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetIdentityDkimEnabled operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SetIdentityDkimEnabled"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIdentityDkimEnabled.</param>
        /// 
        /// <returns>Returns a SetIdentityDkimEnabledResult from AmazonSimpleEmailService.</returns>
        public SetIdentityDkimEnabledResponse EndSetIdentityDkimEnabled(IAsyncResult asyncResult)
        {
            return endOperation<SetIdentityDkimEnabledResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetIdentityDkimEnabled(SetIdentityDkimEnabledRequest setIdentityDkimEnabledRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetIdentityDkimEnabledRequestMarshaller().Marshall(setIdentityDkimEnabledRequest);
            var unmarshaller = SetIdentityDkimEnabledResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetSendQuota

        /// <summary>
        /// <para>Returns the user's current sending limits.</para>
        /// </summary>
        /// 
        /// <param name="getSendQuotaRequest">Container for the necessary parameters to execute the GetSendQuota service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public GetSendQuotaResponse GetSendQuota(GetSendQuotaRequest getSendQuotaRequest)
        {
            IAsyncResult asyncResult = invokeGetSendQuota(getSendQuotaRequest, null, null, true);
            return EndGetSendQuota(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetSendQuota operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.GetSendQuota"/>
        /// </summary>
        /// 
        /// <param name="getSendQuotaRequest">Container for the necessary parameters to execute the GetSendQuota operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSendQuota
        ///         operation.</returns>
        public IAsyncResult BeginGetSendQuota(GetSendQuotaRequest getSendQuotaRequest, AsyncCallback callback, object state)
        {
            return invokeGetSendQuota(getSendQuotaRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetSendQuota operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.GetSendQuota"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSendQuota.</param>
        /// 
        /// <returns>Returns a GetSendQuotaResult from AmazonSimpleEmailService.</returns>
        public GetSendQuotaResponse EndGetSendQuota(IAsyncResult asyncResult)
        {
            return endOperation<GetSendQuotaResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetSendQuota(GetSendQuotaRequest getSendQuotaRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetSendQuotaRequestMarshaller().Marshall(getSendQuotaRequest);
            var unmarshaller = GetSendQuotaResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns the user's current sending limits.</para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public GetSendQuotaResponse GetSendQuota()
        {
            return GetSendQuota(new GetSendQuotaRequest());
        }
        

        #endregion
    
        #region SetIdentityFeedbackForwardingEnabled

        /// <summary>
        /// <para>Given an identity (email address or domain), enables or disables whether Amazon SES forwards feedback notifications as email. Feedback
        /// forwarding may only be disabled when both complaint and bounce topics are set. For more information about feedback notification, see the
        /// Amazon SES Developer Guide.</para>
        /// </summary>
        /// 
        /// <param name="setIdentityFeedbackForwardingEnabledRequest">Container for the necessary parameters to execute the
        ///          SetIdentityFeedbackForwardingEnabled service method on AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the SetIdentityFeedbackForwardingEnabled service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public SetIdentityFeedbackForwardingEnabledResponse SetIdentityFeedbackForwardingEnabled(SetIdentityFeedbackForwardingEnabledRequest setIdentityFeedbackForwardingEnabledRequest)
        {
            IAsyncResult asyncResult = invokeSetIdentityFeedbackForwardingEnabled(setIdentityFeedbackForwardingEnabledRequest, null, null, true);
            return EndSetIdentityFeedbackForwardingEnabled(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityFeedbackForwardingEnabled operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SetIdentityFeedbackForwardingEnabled"/>
        /// </summary>
        /// 
        /// <param name="setIdentityFeedbackForwardingEnabledRequest">Container for the necessary parameters to execute the
        ///          SetIdentityFeedbackForwardingEnabled operation on AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndSetIdentityFeedbackForwardingEnabled operation.</returns>
        public IAsyncResult BeginSetIdentityFeedbackForwardingEnabled(SetIdentityFeedbackForwardingEnabledRequest setIdentityFeedbackForwardingEnabledRequest, AsyncCallback callback, object state)
        {
            return invokeSetIdentityFeedbackForwardingEnabled(setIdentityFeedbackForwardingEnabledRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetIdentityFeedbackForwardingEnabled operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SetIdentityFeedbackForwardingEnabled"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIdentityFeedbackForwardingEnabled.</param>
        /// 
        /// <returns>Returns a SetIdentityFeedbackForwardingEnabledResult from AmazonSimpleEmailService.</returns>
        public SetIdentityFeedbackForwardingEnabledResponse EndSetIdentityFeedbackForwardingEnabled(IAsyncResult asyncResult)
        {
            return endOperation<SetIdentityFeedbackForwardingEnabledResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetIdentityFeedbackForwardingEnabled(SetIdentityFeedbackForwardingEnabledRequest setIdentityFeedbackForwardingEnabledRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetIdentityFeedbackForwardingEnabledRequestMarshaller().Marshall(setIdentityFeedbackForwardingEnabledRequest);
            var unmarshaller = SetIdentityFeedbackForwardingEnabledResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region VerifyDomainIdentity

        /// <summary>
        /// <para>Verifies a domain.</para>
        /// </summary>
        /// 
        /// <param name="verifyDomainIdentityRequest">Container for the necessary parameters to execute the VerifyDomainIdentity service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the VerifyDomainIdentity service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public VerifyDomainIdentityResponse VerifyDomainIdentity(VerifyDomainIdentityRequest verifyDomainIdentityRequest)
        {
            IAsyncResult asyncResult = invokeVerifyDomainIdentity(verifyDomainIdentityRequest, null, null, true);
            return EndVerifyDomainIdentity(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyDomainIdentity operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.VerifyDomainIdentity"/>
        /// </summary>
        /// 
        /// <param name="verifyDomainIdentityRequest">Container for the necessary parameters to execute the VerifyDomainIdentity operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndVerifyDomainIdentity operation.</returns>
        public IAsyncResult BeginVerifyDomainIdentity(VerifyDomainIdentityRequest verifyDomainIdentityRequest, AsyncCallback callback, object state)
        {
            return invokeVerifyDomainIdentity(verifyDomainIdentityRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the VerifyDomainIdentity operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.VerifyDomainIdentity"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyDomainIdentity.</param>
        /// 
        /// <returns>Returns a VerifyDomainIdentityResult from AmazonSimpleEmailService.</returns>
        public VerifyDomainIdentityResponse EndVerifyDomainIdentity(IAsyncResult asyncResult)
        {
            return endOperation<VerifyDomainIdentityResponse>(asyncResult);
        }
        
        IAsyncResult invokeVerifyDomainIdentity(VerifyDomainIdentityRequest verifyDomainIdentityRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new VerifyDomainIdentityRequestMarshaller().Marshall(verifyDomainIdentityRequest);
            var unmarshaller = VerifyDomainIdentityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SendEmail

        /// <summary>
        /// <para>Composes an email message based on input data, and then immediately queues the message for sending. </para> <para><b>IMPORTANT:</b>If
        /// you have not yet requested production access to Amazon SES, then you will only be able to send email to and from verified email addresses
        /// and domains. For more information, go to the Amazon SES Developer Guide. </para> <para>The total size of the message cannot exceed 10
        /// MB.</para> <para>Amazon SES has a limit on the total number of recipients per message: The combined number of To:, CC: and BCC: email
        /// addresses cannot exceed 50. If you need to send an email message to a larger audience, you can divide your recipient list into groups of 50
        /// or fewer, and then call Amazon SES repeatedly to send the message to each group. </para> <para>For every message that you send, the total
        /// number of recipients (To:, CC: and BCC:) is counted against your <i>sending quota</i> - the maximum number of emails you can send in a
        /// 24-hour period. For information about your sending quota, go to the "Managing Your Sending Activity" section of theAmazon SES Developer
        /// Guide. </para>
        /// </summary>
        /// 
        /// <param name="sendEmailRequest">Container for the necessary parameters to execute the SendEmail service method on
        ///          AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the SendEmail service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        /// <exception cref="MessageRejectedException"/>
        public SendEmailResponse SendEmail(SendEmailRequest sendEmailRequest)
        {
            IAsyncResult asyncResult = invokeSendEmail(sendEmailRequest, null, null, true);
            return EndSendEmail(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SendEmail operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SendEmail"/>
        /// </summary>
        /// 
        /// <param name="sendEmailRequest">Container for the necessary parameters to execute the SendEmail operation on
        ///          AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendEmail
        ///         operation.</returns>
        public IAsyncResult BeginSendEmail(SendEmailRequest sendEmailRequest, AsyncCallback callback, object state)
        {
            return invokeSendEmail(sendEmailRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SendEmail operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SendEmail"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendEmail.</param>
        /// 
        /// <returns>Returns a SendEmailResult from AmazonSimpleEmailService.</returns>
        public SendEmailResponse EndSendEmail(IAsyncResult asyncResult)
        {
            return endOperation<SendEmailResponse>(asyncResult);
        }
        
        IAsyncResult invokeSendEmail(SendEmailRequest sendEmailRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SendEmailRequestMarshaller().Marshall(sendEmailRequest);
            var unmarshaller = SendEmailResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteVerifiedEmailAddress

        /// <summary>
        /// <para>Deletes the specified email address from the list of verified addresses.</para> <para><b>IMPORTANT:</b>The DeleteVerifiedEmailAddress
        /// action is deprecated as of the May 15, 2012 release of Domain Verification. The DeleteIdentity action is now preferred.</para>
        /// </summary>
        /// 
        /// <param name="deleteVerifiedEmailAddressRequest">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress service
        ///          method on AmazonSimpleEmailService.</param>
        /// 
        public DeleteVerifiedEmailAddressResponse DeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest deleteVerifiedEmailAddressRequest)
        {
            IAsyncResult asyncResult = invokeDeleteVerifiedEmailAddress(deleteVerifiedEmailAddressRequest, null, null, true);
            return EndDeleteVerifiedEmailAddress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVerifiedEmailAddress operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.DeleteVerifiedEmailAddress"/>
        /// </summary>
        /// 
        /// <param name="deleteVerifiedEmailAddressRequest">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress operation
        ///          on AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest deleteVerifiedEmailAddressRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteVerifiedEmailAddress(deleteVerifiedEmailAddressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVerifiedEmailAddress operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.DeleteVerifiedEmailAddress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVerifiedEmailAddress.</param>
        public DeleteVerifiedEmailAddressResponse EndDeleteVerifiedEmailAddress(IAsyncResult asyncResult)
        {
            return endOperation<DeleteVerifiedEmailAddressResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteVerifiedEmailAddress(DeleteVerifiedEmailAddressRequest deleteVerifiedEmailAddressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteVerifiedEmailAddressRequestMarshaller().Marshall(deleteVerifiedEmailAddressRequest);
            var unmarshaller = DeleteVerifiedEmailAddressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetIdentityNotificationTopic

        /// <summary>
        /// <para>Given an identity (email address or domain), sets the Amazon SNS topic to which Amazon SES will publish bounce and complaint
        /// notifications for emails sent with that identity as the <c>Source</c> .
        /// Publishing to topics may only be disabled when feedback forwarding is enabled. For more information about feedback notification, see
        /// the Amazon SES Developer Guide.</para>
        /// </summary>
        /// 
        /// <param name="setIdentityNotificationTopicRequest">Container for the necessary parameters to execute the SetIdentityNotificationTopic service
        ///          method on AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the SetIdentityNotificationTopic service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        public SetIdentityNotificationTopicResponse SetIdentityNotificationTopic(SetIdentityNotificationTopicRequest setIdentityNotificationTopicRequest)
        {
            IAsyncResult asyncResult = invokeSetIdentityNotificationTopic(setIdentityNotificationTopicRequest, null, null, true);
            return EndSetIdentityNotificationTopic(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityNotificationTopic operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SetIdentityNotificationTopic"/>
        /// </summary>
        /// 
        /// <param name="setIdentityNotificationTopicRequest">Container for the necessary parameters to execute the SetIdentityNotificationTopic
        ///          operation on AmazonSimpleEmailService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndSetIdentityNotificationTopic operation.</returns>
        public IAsyncResult BeginSetIdentityNotificationTopic(SetIdentityNotificationTopicRequest setIdentityNotificationTopicRequest, AsyncCallback callback, object state)
        {
            return invokeSetIdentityNotificationTopic(setIdentityNotificationTopicRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetIdentityNotificationTopic operation.
        /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SetIdentityNotificationTopic"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIdentityNotificationTopic.</param>
        /// 
        /// <returns>Returns a SetIdentityNotificationTopicResult from AmazonSimpleEmailService.</returns>
        public SetIdentityNotificationTopicResponse EndSetIdentityNotificationTopic(IAsyncResult asyncResult)
        {
            return endOperation<SetIdentityNotificationTopicResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetIdentityNotificationTopic(SetIdentityNotificationTopicRequest setIdentityNotificationTopicRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetIdentityNotificationTopicRequestMarshaller().Marshall(setIdentityNotificationTopicRequest);
            var unmarshaller = SetIdentityNotificationTopicResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
