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

using Amazon.IdentityManagement.Model;
using Amazon.IdentityManagement.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.IdentityManagement
{
    /// <summary>
    /// Implementation for accessing AmazonIdentityManagementService.
    ///  
    /// AWS Identity and Access Management <para>This guide provides descriptions of the Identity and Access Management (IAM) API as well as links
    /// to related content in the guide, Using IAM.</para> <para>IAM is a web service that enables AWS customers to manage users and user
    /// permissions under their AWS account. For more information about this product go to AWS Identity and Access Management (IAM). For information
    /// about setting up signatures and authorization through the API, go to Signing AWS API Requests in the <i>AWS General Reference</i> . For
    /// general information about using the Query API with IAM, go to Making Query Requests in <i>Using IAM</i> .</para> <para>If you're new to AWS
    /// and need additional technical information about a specific AWS product, you can find the product's technical documentation at
    /// http://aws.amazon.com/documentation/.</para>
    /// </summary>
    public class AmazonIdentityManagementServiceClient : AmazonWebServiceClient, AmazonIdentityManagementService
    {
    
        AbstractAWSSigner signer = new AWS4Signer();

        #region Constructors

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with the credentials loaded from the application's
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
        public AmazonIdentityManagementServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIdentityManagementServiceConfig(), true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with the credentials loaded from the application's
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
        public AmazonIdentityManagementServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIdentityManagementServiceConfig() { RegionEndpoint = region }, true, AuthenticationTypes.User) { }



        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIdentityManagementService Configuration Object</param>
        public AmazonIdentityManagementServiceClient(AmazonIdentityManagementServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIdentityManagementServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonIdentityManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIdentityManagementServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIdentityManagementServiceConfig() { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Credentials and an
        /// AmazonIdentityManagementServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIdentityManagementServiceClient Configuration Object</param>
        public AmazonIdentityManagementServiceClient(AWSCredentials credentials, AmazonIdentityManagementServiceConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User)
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIdentityManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIdentityManagementServiceConfig() { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIdentityManagementServiceClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIdentityManagementServiceClient Configuration Object</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIdentityManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User)
        {
        }
        

        #endregion
   
        #region DeleteAccountAlias

        /// <summary>
        /// <para>Deletes the specified AWS account alias. For information about using an AWS account alias, see Using an Alias for Your AWS Account ID
        /// in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteAccountAliasRequest">Container for the necessary parameters to execute the DeleteAccountAlias service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public DeleteAccountAliasResponse DeleteAccountAlias(DeleteAccountAliasRequest deleteAccountAliasRequest)
        {
            IAsyncResult asyncResult = invokeDeleteAccountAlias(deleteAccountAliasRequest, null, null, true);
            return EndDeleteAccountAlias(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteAccountAlias"/>
        /// </summary>
        /// 
        /// <param name="deleteAccountAliasRequest">Container for the necessary parameters to execute the DeleteAccountAlias operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteAccountAlias(DeleteAccountAliasRequest deleteAccountAliasRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteAccountAlias(deleteAccountAliasRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteAccountAlias"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountAlias.</param>
        public DeleteAccountAliasResponse EndDeleteAccountAlias(IAsyncResult asyncResult)
        {
            return endOperation<DeleteAccountAliasResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteAccountAlias(DeleteAccountAliasRequest deleteAccountAliasRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteAccountAliasRequestMarshaller().Marshall(deleteAccountAliasRequest);
            var unmarshaller = DeleteAccountAliasResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListGroups

        /// <summary>
        /// <para>Lists the groups that have the specified path prefix.</para> <para>You can paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listGroupsRequest">Container for the necessary parameters to execute the ListGroups service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public ListGroupsResponse ListGroups(ListGroupsRequest listGroupsRequest)
        {
            IAsyncResult asyncResult = invokeListGroups(listGroupsRequest, null, null, true);
            return EndListGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListGroups"/>
        /// </summary>
        /// 
        /// <param name="listGroupsRequest">Container for the necessary parameters to execute the ListGroups operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        public IAsyncResult BeginListGroups(ListGroupsRequest listGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeListGroups(listGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListGroups operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a ListGroupsResult from AmazonIdentityManagementService.</returns>
        public ListGroupsResponse EndListGroups(IAsyncResult asyncResult)
        {
            return endOperation<ListGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListGroups(ListGroupsRequest listGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListGroupsRequestMarshaller().Marshall(listGroupsRequest);
            var unmarshaller = ListGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Lists the groups that have the specified path prefix.</para> <para>You can paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public ListGroupsResponse ListGroups()
        {
            return ListGroups(new ListGroupsRequest());
        }
        

        #endregion
    
        #region DeleteAccessKey

        /// <summary>
        /// <para>Deletes the access key associated with the specified user.</para> <para>If you do not specify a user name, IAM determines the user
        /// name implicitly based on the AWS Access Key ID signing the request. Because this action works for access keys under the AWS account, you can
        /// use this API to manage root credentials even if the AWS account has no associated users.</para>
        /// </summary>
        /// 
        /// <param name="deleteAccessKeyRequest">Container for the necessary parameters to execute the DeleteAccessKey service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public DeleteAccessKeyResponse DeleteAccessKey(DeleteAccessKeyRequest deleteAccessKeyRequest)
        {
            IAsyncResult asyncResult = invokeDeleteAccessKey(deleteAccessKeyRequest, null, null, true);
            return EndDeleteAccessKey(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteAccessKey"/>
        /// </summary>
        /// 
        /// <param name="deleteAccessKeyRequest">Container for the necessary parameters to execute the DeleteAccessKey operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteAccessKey(DeleteAccessKeyRequest deleteAccessKeyRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteAccessKey(deleteAccessKeyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteAccessKey"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessKey.</param>
        public DeleteAccessKeyResponse EndDeleteAccessKey(IAsyncResult asyncResult)
        {
            return endOperation<DeleteAccessKeyResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteAccessKey(DeleteAccessKeyRequest deleteAccessKeyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteAccessKeyRequestMarshaller().Marshall(deleteAccessKeyRequest);
            var unmarshaller = DeleteAccessKeyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteVirtualMFADevice

        /// <summary>
        /// <para>Deletes a virtual MFA device.</para> <para><b>NOTE:</b>You must deactivate a user's virtual MFA device before you can delete it. For
        /// information about deactivating MFA devices, see DeactivateMFADevice.</para>
        /// </summary>
        /// 
        /// <param name="deleteVirtualMFADeviceRequest">Container for the necessary parameters to execute the DeleteVirtualMFADevice service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="DeleteConflictException"/>
        public DeleteVirtualMFADeviceResponse DeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest deleteVirtualMFADeviceRequest)
        {
            IAsyncResult asyncResult = invokeDeleteVirtualMFADevice(deleteVirtualMFADeviceRequest, null, null, true);
            return EndDeleteVirtualMFADevice(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteVirtualMFADevice"/>
        /// </summary>
        /// 
        /// <param name="deleteVirtualMFADeviceRequest">Container for the necessary parameters to execute the DeleteVirtualMFADevice operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest deleteVirtualMFADeviceRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteVirtualMFADevice(deleteVirtualMFADeviceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteVirtualMFADevice"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualMFADevice.</param>
        public DeleteVirtualMFADeviceResponse EndDeleteVirtualMFADevice(IAsyncResult asyncResult)
        {
            return endOperation<DeleteVirtualMFADeviceResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest deleteVirtualMFADeviceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteVirtualMFADeviceRequestMarshaller().Marshall(deleteVirtualMFADeviceRequest);
            var unmarshaller = DeleteVirtualMFADeviceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteUserPolicy

        /// <summary>
        /// <para>Deletes the specified policy associated with the specified user.</para>
        /// </summary>
        /// 
        /// <param name="deleteUserPolicyRequest">Container for the necessary parameters to execute the DeleteUserPolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public DeleteUserPolicyResponse DeleteUserPolicy(DeleteUserPolicyRequest deleteUserPolicyRequest)
        {
            IAsyncResult asyncResult = invokeDeleteUserPolicy(deleteUserPolicyRequest, null, null, true);
            return EndDeleteUserPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteUserPolicy"/>
        /// </summary>
        /// 
        /// <param name="deleteUserPolicyRequest">Container for the necessary parameters to execute the DeleteUserPolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteUserPolicy(DeleteUserPolicyRequest deleteUserPolicyRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteUserPolicy(deleteUserPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteUserPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserPolicy.</param>
        public DeleteUserPolicyResponse EndDeleteUserPolicy(IAsyncResult asyncResult)
        {
            return endOperation<DeleteUserPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteUserPolicy(DeleteUserPolicyRequest deleteUserPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteUserPolicyRequestMarshaller().Marshall(deleteUserPolicyRequest);
            var unmarshaller = DeleteUserPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PutUserPolicy

        /// <summary>
        /// <para>Adds (or updates) a policy document associated with the specified user. For information about policies, refer to Overview of Policies
        /// in <i>Using AWS Identity and Access Management</i> .</para> <para>For information about limits on the number of policies you can associate
        /// with a user, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>NOTE:</b>Because policy
        /// documents can be large, you should use POST rather than GET when calling PutUserPolicy. For information about setting up signatures and
        /// authorization through the API, go to Signing AWS API Requests in the AWS General Reference. For general information about using the Query
        /// API with IAM, go to Making Query Requests in Using IAM.</para>
        /// </summary>
        /// 
        /// <param name="putUserPolicyRequest">Container for the necessary parameters to execute the PutUserPolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        public PutUserPolicyResponse PutUserPolicy(PutUserPolicyRequest putUserPolicyRequest)
        {
            IAsyncResult asyncResult = invokePutUserPolicy(putUserPolicyRequest, null, null, true);
            return EndPutUserPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.PutUserPolicy"/>
        /// </summary>
        /// 
        /// <param name="putUserPolicyRequest">Container for the necessary parameters to execute the PutUserPolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutUserPolicy(PutUserPolicyRequest putUserPolicyRequest, AsyncCallback callback, object state)
        {
            return invokePutUserPolicy(putUserPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.PutUserPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutUserPolicy.</param>
        public PutUserPolicyResponse EndPutUserPolicy(IAsyncResult asyncResult)
        {
            return endOperation<PutUserPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokePutUserPolicy(PutUserPolicyRequest putUserPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutUserPolicyRequestMarshaller().Marshall(putUserPolicyRequest);
            var unmarshaller = PutUserPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListServerCertificates

        /// <summary>
        /// <para>Lists the server certificates that have the specified path prefix. If none exist, the action returns an empty list.</para> <para>You
        /// can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listServerCertificatesRequest">Container for the necessary parameters to execute the ListServerCertificates service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public ListServerCertificatesResponse ListServerCertificates(ListServerCertificatesRequest listServerCertificatesRequest)
        {
            IAsyncResult asyncResult = invokeListServerCertificates(listServerCertificatesRequest, null, null, true);
            return EndListServerCertificates(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListServerCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListServerCertificates"/>
        /// </summary>
        /// 
        /// <param name="listServerCertificatesRequest">Container for the necessary parameters to execute the ListServerCertificates operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListServerCertificates operation.</returns>
        public IAsyncResult BeginListServerCertificates(ListServerCertificatesRequest listServerCertificatesRequest, AsyncCallback callback, object state)
        {
            return invokeListServerCertificates(listServerCertificatesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListServerCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListServerCertificates"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServerCertificates.</param>
        /// 
        /// <returns>Returns a ListServerCertificatesResult from AmazonIdentityManagementService.</returns>
        public ListServerCertificatesResponse EndListServerCertificates(IAsyncResult asyncResult)
        {
            return endOperation<ListServerCertificatesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListServerCertificates(ListServerCertificatesRequest listServerCertificatesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListServerCertificatesRequestMarshaller().Marshall(listServerCertificatesRequest);
            var unmarshaller = ListServerCertificatesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Lists the server certificates that have the specified path prefix. If none exist, the action returns an empty list.</para> <para>You
        /// can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public ListServerCertificatesResponse ListServerCertificates()
        {
            return ListServerCertificates(new ListServerCertificatesRequest());
        }
        

        #endregion
    
        #region GetUserPolicy

        /// <summary>
        /// <para>Retrieves the specified policy document for the specified user. The returned policy is URL-encoded according to RFC 3986. For more
        /// information about RFC 3986, go to http://www.faqs.org/rfcs/rfc3986.html.</para>
        /// </summary>
        /// 
        /// <param name="getUserPolicyRequest">Container for the necessary parameters to execute the GetUserPolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetUserPolicy service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public GetUserPolicyResponse GetUserPolicy(GetUserPolicyRequest getUserPolicyRequest)
        {
            IAsyncResult asyncResult = invokeGetUserPolicy(getUserPolicyRequest, null, null, true);
            return EndGetUserPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetUserPolicy"/>
        /// </summary>
        /// 
        /// <param name="getUserPolicyRequest">Container for the necessary parameters to execute the GetUserPolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserPolicy
        ///         operation.</returns>
        public IAsyncResult BeginGetUserPolicy(GetUserPolicyRequest getUserPolicyRequest, AsyncCallback callback, object state)
        {
            return invokeGetUserPolicy(getUserPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetUserPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserPolicy.</param>
        /// 
        /// <returns>Returns a GetUserPolicyResult from AmazonIdentityManagementService.</returns>
        public GetUserPolicyResponse EndGetUserPolicy(IAsyncResult asyncResult)
        {
            return endOperation<GetUserPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetUserPolicy(GetUserPolicyRequest getUserPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetUserPolicyRequestMarshaller().Marshall(getUserPolicyRequest);
            var unmarshaller = GetUserPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateServerCertificate

        /// <summary>
        /// <para>Updates the name and/or the path of the specified server certificate.</para> <para><b>IMPORTANT:</b> You should understand the
        /// implications of changing a server certificate's path or name. For more information, see Managing Server Certificates in Using AWS Identity
        /// and Access Management. </para> <para><b>NOTE:</b>To change a server certificate name the requester must have appropriate permissions on both
        /// the source object and the target object. For example, to change the name from ProductionCert to ProdCert, the entity making the request
        /// must have permission on ProductionCert and ProdCert, or must have permission on all (*). For more information about permissions, see
        /// Permissions and Policies. </para>
        /// </summary>
        /// 
        /// <param name="updateServerCertificateRequest">Container for the necessary parameters to execute the UpdateServerCertificate service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        public UpdateServerCertificateResponse UpdateServerCertificate(UpdateServerCertificateRequest updateServerCertificateRequest)
        {
            IAsyncResult asyncResult = invokeUpdateServerCertificate(updateServerCertificateRequest, null, null, true);
            return EndUpdateServerCertificate(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="updateServerCertificateRequest">Container for the necessary parameters to execute the UpdateServerCertificate operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateServerCertificate(UpdateServerCertificateRequest updateServerCertificateRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateServerCertificate(updateServerCertificateRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServerCertificate.</param>
        public UpdateServerCertificateResponse EndUpdateServerCertificate(IAsyncResult asyncResult)
        {
            return endOperation<UpdateServerCertificateResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateServerCertificate(UpdateServerCertificateRequest updateServerCertificateRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateServerCertificateRequestMarshaller().Marshall(updateServerCertificateRequest);
            var unmarshaller = UpdateServerCertificateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateUser

        /// <summary>
        /// <para>Updates the name and/or the path of the specified user.</para> <para><b>IMPORTANT:</b> You should understand the implications of
        /// changing a user's path or name. For more information, see Renaming Users and Groups in Using AWS Identity and Access Management. </para>
        /// <para><b>NOTE:</b>To change a user name the requester must have appropriate permissions on both the source object and the target object.
        /// For example, to change Bob to Robert, the entity making the request must have permission on Bob and Robert, or must have permission on all
        /// (*). For more information about permissions, see Permissions and Policies. </para>
        /// </summary>
        /// 
        /// <param name="updateUserRequest">Container for the necessary parameters to execute the UpdateUser service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="EntityTemporarilyUnmodifiableException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        public UpdateUserResponse UpdateUser(UpdateUserRequest updateUserRequest)
        {
            IAsyncResult asyncResult = invokeUpdateUser(updateUserRequest, null, null, true);
            return EndUpdateUser(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateUser"/>
        /// </summary>
        /// 
        /// <param name="updateUserRequest">Container for the necessary parameters to execute the UpdateUser operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateUser(UpdateUserRequest updateUserRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateUser(updateUserRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateUser"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        public UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult)
        {
            return endOperation<UpdateUserResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateUser(UpdateUserRequest updateUserRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateUserRequestMarshaller().Marshall(updateUserRequest);
            var unmarshaller = UpdateUserResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PutRolePolicy

        /// <summary>
        /// <para>Adds (or updates) a policy document associated with the specified role. For information about policies, refer to Overview of Policies
        /// in <i>Using AWS Identity and Access Management</i> .</para> <para>For information about limits on the number of policies you can associate
        /// with a role, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>NOTE:</b>Because policy
        /// documents can be large, you should use POST rather than GET when calling PutRolePolicy. For information about setting up signatures and
        /// authorization through the API, go to Signing AWS API Requests in the AWS General Reference. For general information about using the Query
        /// API with IAM, go to Making Query Requests in Using IAM.</para>
        /// </summary>
        /// 
        /// <param name="putRolePolicyRequest">Container for the necessary parameters to execute the PutRolePolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        public PutRolePolicyResponse PutRolePolicy(PutRolePolicyRequest putRolePolicyRequest)
        {
            IAsyncResult asyncResult = invokePutRolePolicy(putRolePolicyRequest, null, null, true);
            return EndPutRolePolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.PutRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="putRolePolicyRequest">Container for the necessary parameters to execute the PutRolePolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutRolePolicy(PutRolePolicyRequest putRolePolicyRequest, AsyncCallback callback, object state)
        {
            return invokePutRolePolicy(putRolePolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.PutRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRolePolicy.</param>
        public PutRolePolicyResponse EndPutRolePolicy(IAsyncResult asyncResult)
        {
            return endOperation<PutRolePolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokePutRolePolicy(PutRolePolicyRequest putRolePolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutRolePolicyRequestMarshaller().Marshall(putRolePolicyRequest);
            var unmarshaller = PutRolePolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateSigningCertificate

        /// <summary>
        /// <para>Changes the status of the specified signing certificate from active to disabled, or vice versa. This action can be used to disable a
        /// user's signing certificate as part of a certificate rotation work flow.</para> <para>If the <c>UserName</c> field is not specified, the
        /// UserName is determined implicitly based on the AWS Access Key ID used to sign the request. Because this action works for access keys under
        /// the AWS account, this API can be used to manage root credentials even if the AWS account has no associated users.</para> <para>For
        /// information about rotating certificates, see Managing Keys and Certificates in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="updateSigningCertificateRequest">Container for the necessary parameters to execute the UpdateSigningCertificate service method
        ///          on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public UpdateSigningCertificateResponse UpdateSigningCertificate(UpdateSigningCertificateRequest updateSigningCertificateRequest)
        {
            IAsyncResult asyncResult = invokeUpdateSigningCertificate(updateSigningCertificateRequest, null, null, true);
            return EndUpdateSigningCertificate(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateSigningCertificate"/>
        /// </summary>
        /// 
        /// <param name="updateSigningCertificateRequest">Container for the necessary parameters to execute the UpdateSigningCertificate operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateSigningCertificate(UpdateSigningCertificateRequest updateSigningCertificateRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateSigningCertificate(updateSigningCertificateRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateSigningCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSigningCertificate.</param>
        public UpdateSigningCertificateResponse EndUpdateSigningCertificate(IAsyncResult asyncResult)
        {
            return endOperation<UpdateSigningCertificateResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateSigningCertificate(UpdateSigningCertificateRequest updateSigningCertificateRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateSigningCertificateRequestMarshaller().Marshall(updateSigningCertificateRequest);
            var unmarshaller = UpdateSigningCertificateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteGroupPolicy

        /// <summary>
        /// <para>Deletes the specified policy that is associated with the specified group.</para>
        /// </summary>
        /// 
        /// <param name="deleteGroupPolicyRequest">Container for the necessary parameters to execute the DeleteGroupPolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public DeleteGroupPolicyResponse DeleteGroupPolicy(DeleteGroupPolicyRequest deleteGroupPolicyRequest)
        {
            IAsyncResult asyncResult = invokeDeleteGroupPolicy(deleteGroupPolicyRequest, null, null, true);
            return EndDeleteGroupPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteGroupPolicy"/>
        /// </summary>
        /// 
        /// <param name="deleteGroupPolicyRequest">Container for the necessary parameters to execute the DeleteGroupPolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteGroupPolicy(DeleteGroupPolicyRequest deleteGroupPolicyRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteGroupPolicy(deleteGroupPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteGroupPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroupPolicy.</param>
        public DeleteGroupPolicyResponse EndDeleteGroupPolicy(IAsyncResult asyncResult)
        {
            return endOperation<DeleteGroupPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteGroupPolicy(DeleteGroupPolicyRequest deleteGroupPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteGroupPolicyRequestMarshaller().Marshall(deleteGroupPolicyRequest);
            var unmarshaller = DeleteGroupPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListUsers

        /// <summary>
        /// <para>Lists the users that have the specified path prefix. If there are none, the action returns an empty list.</para> <para>You can
        /// paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listUsersRequest">Container for the necessary parameters to execute the ListUsers service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public ListUsersResponse ListUsers(ListUsersRequest listUsersRequest)
        {
            IAsyncResult asyncResult = invokeListUsers(listUsersRequest, null, null, true);
            return EndListUsers(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListUsers"/>
        /// </summary>
        /// 
        /// <param name="listUsersRequest">Container for the necessary parameters to execute the ListUsers operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        public IAsyncResult BeginListUsers(ListUsersRequest listUsersRequest, AsyncCallback callback, object state)
        {
            return invokeListUsers(listUsersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListUsers operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListUsers"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a ListUsersResult from AmazonIdentityManagementService.</returns>
        public ListUsersResponse EndListUsers(IAsyncResult asyncResult)
        {
            return endOperation<ListUsersResponse>(asyncResult);
        }
        
        IAsyncResult invokeListUsers(ListUsersRequest listUsersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListUsersRequestMarshaller().Marshall(listUsersRequest);
            var unmarshaller = ListUsersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Lists the users that have the specified path prefix. If there are none, the action returns an empty list.</para> <para>You can
        /// paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public ListUsersResponse ListUsers()
        {
            return ListUsers(new ListUsersRequest());
        }
        

        #endregion
    
        #region UpdateGroup

        /// <summary>
        /// <para>Updates the name and/or the path of the specified group.</para> <para><b>IMPORTANT:</b> You should understand the implications of
        /// changing a group's path or name. For more information, see Renaming Users and Groups in Using AWS Identity and Access Management. </para>
        /// <para><b>NOTE:</b>To change a group name the requester must have appropriate permissions on both the source object and the target object.
        /// For example, to change Managers to MGRs, the entity making the request must have permission on Managers and MGRs, or must have permission on
        /// all (*). For more information about permissions, see Permissions and Policies. </para>
        /// </summary>
        /// 
        /// <param name="updateGroupRequest">Container for the necessary parameters to execute the UpdateGroup service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        public UpdateGroupResponse UpdateGroup(UpdateGroupRequest updateGroupRequest)
        {
            IAsyncResult asyncResult = invokeUpdateGroup(updateGroupRequest, null, null, true);
            return EndUpdateGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateGroup"/>
        /// </summary>
        /// 
        /// <param name="updateGroupRequest">Container for the necessary parameters to execute the UpdateGroup operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateGroup(UpdateGroupRequest updateGroupRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateGroup(updateGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        public UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult)
        {
            return endOperation<UpdateGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateGroup(UpdateGroupRequest updateGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateGroupRequestMarshaller().Marshall(updateGroupRequest);
            var unmarshaller = UpdateGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateUser

        /// <summary>
        /// <para>Creates a new user for your AWS account.</para> <para>For information about limitations on the number of users you can create, see
        /// Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="createUserRequest">Container for the necessary parameters to execute the CreateUser service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        public CreateUserResponse CreateUser(CreateUserRequest createUserRequest)
        {
            IAsyncResult asyncResult = invokeCreateUser(createUserRequest, null, null, true);
            return EndCreateUser(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateUser"/>
        /// </summary>
        /// 
        /// <param name="createUserRequest">Container for the necessary parameters to execute the CreateUser operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        public IAsyncResult BeginCreateUser(CreateUserRequest createUserRequest, AsyncCallback callback, object state)
        {
            return invokeCreateUser(createUserRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateUser"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a CreateUserResult from AmazonIdentityManagementService.</returns>
        public CreateUserResponse EndCreateUser(IAsyncResult asyncResult)
        {
            return endOperation<CreateUserResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateUser(CreateUserRequest createUserRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateUserRequestMarshaller().Marshall(createUserRequest);
            var unmarshaller = CreateUserResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region EnableMFADevice

        /// <summary>
        /// <para>Enables the specified MFA device and associates it with the specified user name. When enabled, the MFA device is required for every
        /// subsequent login by the user name associated with the device.</para>
        /// </summary>
        /// 
        /// <param name="enableMFADeviceRequest">Container for the necessary parameters to execute the EnableMFADevice service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="EntityTemporarilyUnmodifiableException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="InvalidAuthenticationCodeException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        public EnableMFADeviceResponse EnableMFADevice(EnableMFADeviceRequest enableMFADeviceRequest)
        {
            IAsyncResult asyncResult = invokeEnableMFADevice(enableMFADeviceRequest, null, null, true);
            return EndEnableMFADevice(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the EnableMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.EnableMFADevice"/>
        /// </summary>
        /// 
        /// <param name="enableMFADeviceRequest">Container for the necessary parameters to execute the EnableMFADevice operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginEnableMFADevice(EnableMFADeviceRequest enableMFADeviceRequest, AsyncCallback callback, object state)
        {
            return invokeEnableMFADevice(enableMFADeviceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the EnableMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.EnableMFADevice"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableMFADevice.</param>
        public EnableMFADeviceResponse EndEnableMFADevice(IAsyncResult asyncResult)
        {
            return endOperation<EnableMFADeviceResponse>(asyncResult);
        }
        
        IAsyncResult invokeEnableMFADevice(EnableMFADeviceRequest enableMFADeviceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new EnableMFADeviceRequestMarshaller().Marshall(enableMFADeviceRequest);
            var unmarshaller = EnableMFADeviceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteAccountPasswordPolicy

        /// <summary>
        /// <para>Deletes the password policy for the AWS account.</para>
        /// </summary>
        /// 
        /// <param name="deleteAccountPasswordPolicyRequest">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy service
        ///          method on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest deleteAccountPasswordPolicyRequest)
        {
            IAsyncResult asyncResult = invokeDeleteAccountPasswordPolicy(deleteAccountPasswordPolicyRequest, null, null, true);
            return EndDeleteAccountPasswordPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteAccountPasswordPolicy"/>
        /// </summary>
        /// 
        /// <param name="deleteAccountPasswordPolicyRequest">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy operation
        ///          on AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest deleteAccountPasswordPolicyRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteAccountPasswordPolicy(deleteAccountPasswordPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteAccountPasswordPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountPasswordPolicy.</param>
        public DeleteAccountPasswordPolicyResponse EndDeleteAccountPasswordPolicy(IAsyncResult asyncResult)
        {
            return endOperation<DeleteAccountPasswordPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest deleteAccountPasswordPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteAccountPasswordPolicyRequestMarshaller().Marshall(deleteAccountPasswordPolicyRequest);
            var unmarshaller = DeleteAccountPasswordPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Deletes the password policy for the AWS account.</para>
        /// </summary>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy()
        {
            return DeleteAccountPasswordPolicy(new DeleteAccountPasswordPolicyRequest());
        }
        

        #endregion
    
        #region GetLoginProfile

        /// <summary>
        /// <para>Retrieves the user name and password create date for the specified user.</para>
        /// </summary>
        /// 
        /// <param name="getLoginProfileRequest">Container for the necessary parameters to execute the GetLoginProfile service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetLoginProfile service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public GetLoginProfileResponse GetLoginProfile(GetLoginProfileRequest getLoginProfileRequest)
        {
            IAsyncResult asyncResult = invokeGetLoginProfile(getLoginProfileRequest, null, null, true);
            return EndGetLoginProfile(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="getLoginProfileRequest">Container for the necessary parameters to execute the GetLoginProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoginProfile
        ///         operation.</returns>
        public IAsyncResult BeginGetLoginProfile(GetLoginProfileRequest getLoginProfileRequest, AsyncCallback callback, object state)
        {
            return invokeGetLoginProfile(getLoginProfileRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoginProfile.</param>
        /// 
        /// <returns>Returns a GetLoginProfileResult from AmazonIdentityManagementService.</returns>
        public GetLoginProfileResponse EndGetLoginProfile(IAsyncResult asyncResult)
        {
            return endOperation<GetLoginProfileResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetLoginProfile(GetLoginProfileRequest getLoginProfileRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetLoginProfileRequestMarshaller().Marshall(getLoginProfileRequest);
            var unmarshaller = GetLoginProfileResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UploadServerCertificate

        /// <summary>
        /// <para>Uploads a server certificate entity for the AWS account. The server certificate entity includes a public key certificate, a private
        /// key, and an optional certificate chain, which should all be PEM-encoded.</para> <para>For information about the number of server
        /// certificates you can upload, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para>
        /// <para><b>NOTE:</b>Because the body of the public key certificate, private key, and the certificate chain can be large, you should use POST
        /// rather than GET when calling UploadServerCertificate. For information about setting up signatures and authorization through the API, go to
        /// Signing AWS API Requests in the AWS General Reference. For general information about using the Query API with IAM, go to Making Query
        /// Requests in Using IAM.</para>
        /// </summary>
        /// 
        /// <param name="uploadServerCertificateRequest">Container for the necessary parameters to execute the UploadServerCertificate service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the UploadServerCertificate service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="KeyPairMismatchException"/>
        /// <exception cref="MalformedCertificateException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        public UploadServerCertificateResponse UploadServerCertificate(UploadServerCertificateRequest uploadServerCertificateRequest)
        {
            IAsyncResult asyncResult = invokeUploadServerCertificate(uploadServerCertificateRequest, null, null, true);
            return EndUploadServerCertificate(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UploadServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UploadServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="uploadServerCertificateRequest">Container for the necessary parameters to execute the UploadServerCertificate operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUploadServerCertificate operation.</returns>
        public IAsyncResult BeginUploadServerCertificate(UploadServerCertificateRequest uploadServerCertificateRequest, AsyncCallback callback, object state)
        {
            return invokeUploadServerCertificate(uploadServerCertificateRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UploadServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UploadServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadServerCertificate.</param>
        /// 
        /// <returns>Returns a UploadServerCertificateResult from AmazonIdentityManagementService.</returns>
        public UploadServerCertificateResponse EndUploadServerCertificate(IAsyncResult asyncResult)
        {
            return endOperation<UploadServerCertificateResponse>(asyncResult);
        }
        
        IAsyncResult invokeUploadServerCertificate(UploadServerCertificateRequest uploadServerCertificateRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UploadServerCertificateRequestMarshaller().Marshall(uploadServerCertificateRequest);
            var unmarshaller = UploadServerCertificateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateGroup

        /// <summary>
        /// <para>Creates a new group.</para> <para>For information about the number of groups you can create, see Limitations on IAM Entities in
        /// <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="createGroupRequest">Container for the necessary parameters to execute the CreateGroup service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        public CreateGroupResponse CreateGroup(CreateGroupRequest createGroupRequest)
        {
            IAsyncResult asyncResult = invokeCreateGroup(createGroupRequest, null, null, true);
            return EndCreateGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateGroup"/>
        /// </summary>
        /// 
        /// <param name="createGroupRequest">Container for the necessary parameters to execute the CreateGroup operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        public IAsyncResult BeginCreateGroup(CreateGroupRequest createGroupRequest, AsyncCallback callback, object state)
        {
            return invokeCreateGroup(createGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a CreateGroupResult from AmazonIdentityManagementService.</returns>
        public CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult)
        {
            return endOperation<CreateGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateGroup(CreateGroupRequest createGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateGroupRequestMarshaller().Marshall(createGroupRequest);
            var unmarshaller = CreateGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateAccountAlias

        /// <summary>
        /// <para>This action creates an alias for your AWS account. For information about using an AWS account alias, see Using an Alias for Your AWS
        /// Account ID in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="createAccountAliasRequest">Container for the necessary parameters to execute the CreateAccountAlias service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="EntityAlreadyExistsException"/>
        public CreateAccountAliasResponse CreateAccountAlias(CreateAccountAliasRequest createAccountAliasRequest)
        {
            IAsyncResult asyncResult = invokeCreateAccountAlias(createAccountAliasRequest, null, null, true);
            return EndCreateAccountAlias(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateAccountAlias"/>
        /// </summary>
        /// 
        /// <param name="createAccountAliasRequest">Container for the necessary parameters to execute the CreateAccountAlias operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginCreateAccountAlias(CreateAccountAliasRequest createAccountAliasRequest, AsyncCallback callback, object state)
        {
            return invokeCreateAccountAlias(createAccountAliasRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateAccountAlias"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccountAlias.</param>
        public CreateAccountAliasResponse EndCreateAccountAlias(IAsyncResult asyncResult)
        {
            return endOperation<CreateAccountAliasResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateAccountAlias(CreateAccountAliasRequest createAccountAliasRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateAccountAliasRequestMarshaller().Marshall(createAccountAliasRequest);
            var unmarshaller = CreateAccountAliasResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteUser

        /// <summary>
        /// <para>Deletes the specified user. The user must not belong to any groups, have any keys or signing certificates, or have any attached
        /// policies.</para>
        /// </summary>
        /// 
        /// <param name="deleteUserRequest">Container for the necessary parameters to execute the DeleteUser service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="DeleteConflictException"/>
        public DeleteUserResponse DeleteUser(DeleteUserRequest deleteUserRequest)
        {
            IAsyncResult asyncResult = invokeDeleteUser(deleteUserRequest, null, null, true);
            return EndDeleteUser(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteUser"/>
        /// </summary>
        /// 
        /// <param name="deleteUserRequest">Container for the necessary parameters to execute the DeleteUser operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteUser(DeleteUserRequest deleteUserRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteUser(deleteUserRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteUser operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteUser"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        public DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult)
        {
            return endOperation<DeleteUserResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteUser(DeleteUserRequest deleteUserRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteUserRequestMarshaller().Marshall(deleteUserRequest);
            var unmarshaller = DeleteUserResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeactivateMFADevice

        /// <summary>
        /// <para>Deactivates the specified MFA device and removes it from association with the user name for which it was originally enabled.</para>
        /// </summary>
        /// 
        /// <param name="deactivateMFADeviceRequest">Container for the necessary parameters to execute the DeactivateMFADevice service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="EntityTemporarilyUnmodifiableException"/>
        /// <exception cref="NoSuchEntityException"/>
        public DeactivateMFADeviceResponse DeactivateMFADevice(DeactivateMFADeviceRequest deactivateMFADeviceRequest)
        {
            IAsyncResult asyncResult = invokeDeactivateMFADevice(deactivateMFADeviceRequest, null, null, true);
            return EndDeactivateMFADevice(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeactivateMFADevice"/>
        /// </summary>
        /// 
        /// <param name="deactivateMFADeviceRequest">Container for the necessary parameters to execute the DeactivateMFADevice operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeactivateMFADevice(DeactivateMFADeviceRequest deactivateMFADeviceRequest, AsyncCallback callback, object state)
        {
            return invokeDeactivateMFADevice(deactivateMFADeviceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeactivateMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeactivateMFADevice"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateMFADevice.</param>
        public DeactivateMFADeviceResponse EndDeactivateMFADevice(IAsyncResult asyncResult)
        {
            return endOperation<DeactivateMFADeviceResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeactivateMFADevice(DeactivateMFADeviceRequest deactivateMFADeviceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeactivateMFADeviceRequestMarshaller().Marshall(deactivateMFADeviceRequest);
            var unmarshaller = DeactivateMFADeviceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RemoveUserFromGroup

        /// <summary>
        /// <para>Removes the specified user from the specified group.</para>
        /// </summary>
        /// 
        /// <param name="removeUserFromGroupRequest">Container for the necessary parameters to execute the RemoveUserFromGroup service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest removeUserFromGroupRequest)
        {
            IAsyncResult asyncResult = invokeRemoveUserFromGroup(removeUserFromGroupRequest, null, null, true);
            return EndRemoveUserFromGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveUserFromGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.RemoveUserFromGroup"/>
        /// </summary>
        /// 
        /// <param name="removeUserFromGroupRequest">Container for the necessary parameters to execute the RemoveUserFromGroup operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRemoveUserFromGroup(RemoveUserFromGroupRequest removeUserFromGroupRequest, AsyncCallback callback, object state)
        {
            return invokeRemoveUserFromGroup(removeUserFromGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RemoveUserFromGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.RemoveUserFromGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveUserFromGroup.</param>
        public RemoveUserFromGroupResponse EndRemoveUserFromGroup(IAsyncResult asyncResult)
        {
            return endOperation<RemoveUserFromGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeRemoveUserFromGroup(RemoveUserFromGroupRequest removeUserFromGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RemoveUserFromGroupRequestMarshaller().Marshall(removeUserFromGroupRequest);
            var unmarshaller = RemoveUserFromGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteRole

        /// <summary>
        /// <para>Deletes the specified role. The role must not have any attached policies.</para>
        /// </summary>
        /// 
        /// <param name="deleteRoleRequest">Container for the necessary parameters to execute the DeleteRole service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="DeleteConflictException"/>
        public DeleteRoleResponse DeleteRole(DeleteRoleRequest deleteRoleRequest)
        {
            IAsyncResult asyncResult = invokeDeleteRole(deleteRoleRequest, null, null, true);
            return EndDeleteRole(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRole operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteRole"/>
        /// </summary>
        /// 
        /// <param name="deleteRoleRequest">Container for the necessary parameters to execute the DeleteRole operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteRole(DeleteRoleRequest deleteRoleRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteRole(deleteRoleRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteRole operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteRole"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRole.</param>
        public DeleteRoleResponse EndDeleteRole(IAsyncResult asyncResult)
        {
            return endOperation<DeleteRoleResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteRole(DeleteRoleRequest deleteRoleRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteRoleRequestMarshaller().Marshall(deleteRoleRequest);
            var unmarshaller = DeleteRoleResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteServerCertificate

        /// <summary>
        /// <para>Deletes the specified server certificate.</para> <para><b>IMPORTANT:</b>If you are using a server certificate with Elastic Load
        /// Balancing, deleting the certificate could have implications for your application. If Elastic Load Balancing doesn't detect the deletion of
        /// bound certificates, it may continue to use the certificates. This could cause Elastic Load Balancing to stop accepting traffic. We
        /// recommend that you remove the reference to the certificate from Elastic Load Balancing before using this command to delete the certificate.
        /// For more information, go to DeleteLoadBalancerListeners in the Elastic Load Balancing API Reference.</para>
        /// </summary>
        /// 
        /// <param name="deleteServerCertificateRequest">Container for the necessary parameters to execute the DeleteServerCertificate service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="DeleteConflictException"/>
        public DeleteServerCertificateResponse DeleteServerCertificate(DeleteServerCertificateRequest deleteServerCertificateRequest)
        {
            IAsyncResult asyncResult = invokeDeleteServerCertificate(deleteServerCertificateRequest, null, null, true);
            return EndDeleteServerCertificate(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="deleteServerCertificateRequest">Container for the necessary parameters to execute the DeleteServerCertificate operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteServerCertificate(DeleteServerCertificateRequest deleteServerCertificateRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteServerCertificate(deleteServerCertificateRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServerCertificate.</param>
        public DeleteServerCertificateResponse EndDeleteServerCertificate(IAsyncResult asyncResult)
        {
            return endOperation<DeleteServerCertificateResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteServerCertificate(DeleteServerCertificateRequest deleteServerCertificateRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteServerCertificateRequestMarshaller().Marshall(deleteServerCertificateRequest);
            var unmarshaller = DeleteServerCertificateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateAccessKey

        /// <summary>
        /// <para>Creates a new AWS Secret Access Key and corresponding AWS Access Key ID for the specified user. The default status for new keys is
        /// <c>Active</c> .</para> <para>If you do not specify a user name, IAM determines the user name implicitly based on the AWS Access Key ID
        /// signing the request. Because this action works for access keys under the AWS account, you can use this API to manage root credentials even
        /// if the AWS account has no associated users.</para> <para>For information about limits on the number of keys you can create, see Limitations
        /// on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>IMPORTANT:</b>To ensure the security of your AWS
        /// account, the Secret Access Key is accessible only during key and user creation. You must save the key (for example, in a text file) if you
        /// want to be able to access it again. If a secret key is lost, you can delete the access keys for the associated user and then create new
        /// keys.</para>
        /// </summary>
        /// 
        /// <param name="createAccessKeyRequest">Container for the necessary parameters to execute the CreateAccessKey service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        public CreateAccessKeyResponse CreateAccessKey(CreateAccessKeyRequest createAccessKeyRequest)
        {
            IAsyncResult asyncResult = invokeCreateAccessKey(createAccessKeyRequest, null, null, true);
            return EndCreateAccessKey(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateAccessKey"/>
        /// </summary>
        /// 
        /// <param name="createAccessKeyRequest">Container for the necessary parameters to execute the CreateAccessKey operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessKey
        ///         operation.</returns>
        public IAsyncResult BeginCreateAccessKey(CreateAccessKeyRequest createAccessKeyRequest, AsyncCallback callback, object state)
        {
            return invokeCreateAccessKey(createAccessKeyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateAccessKey"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessKey.</param>
        /// 
        /// <returns>Returns a CreateAccessKeyResult from AmazonIdentityManagementService.</returns>
        public CreateAccessKeyResponse EndCreateAccessKey(IAsyncResult asyncResult)
        {
            return endOperation<CreateAccessKeyResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateAccessKey(CreateAccessKeyRequest createAccessKeyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateAccessKeyRequestMarshaller().Marshall(createAccessKeyRequest);
            var unmarshaller = CreateAccessKeyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Creates a new AWS Secret Access Key and corresponding AWS Access Key ID for the specified user. The default status for new keys is
        /// <c>Active</c> .</para> <para>If you do not specify a user name, IAM determines the user name implicitly based on the AWS Access Key ID
        /// signing the request. Because this action works for access keys under the AWS account, you can use this API to manage root credentials even
        /// if the AWS account has no associated users.</para> <para>For information about limits on the number of keys you can create, see Limitations
        /// on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>IMPORTANT:</b>To ensure the security of your AWS
        /// account, the Secret Access Key is accessible only during key and user creation. You must save the key (for example, in a text file) if you
        /// want to be able to access it again. If a secret key is lost, you can delete the access keys for the associated user and then create new
        /// keys.</para>
        /// </summary>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        public CreateAccessKeyResponse CreateAccessKey()
        {
            return CreateAccessKey(new CreateAccessKeyRequest());
        }
        

        #endregion
    
        #region GetUser

        /// <summary>
        /// <para>Retrieves information about the specified user, including the user's path, GUID, and ARN.</para> <para>If you do not specify a user
        /// name, IAM determines the user name implicitly based on the AWS Access Key ID signing the request.</para>
        /// </summary>
        /// 
        /// <param name="getUserRequest">Container for the necessary parameters to execute the GetUser service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public GetUserResponse GetUser(GetUserRequest getUserRequest)
        {
            IAsyncResult asyncResult = invokeGetUser(getUserRequest, null, null, true);
            return EndGetUser(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetUser"/>
        /// </summary>
        /// 
        /// <param name="getUserRequest">Container for the necessary parameters to execute the GetUser operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUser
        ///         operation.</returns>
        public IAsyncResult BeginGetUser(GetUserRequest getUserRequest, AsyncCallback callback, object state)
        {
            return invokeGetUser(getUserRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetUser operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetUser"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUser.</param>
        /// 
        /// <returns>Returns a GetUserResult from AmazonIdentityManagementService.</returns>
        public GetUserResponse EndGetUser(IAsyncResult asyncResult)
        {
            return endOperation<GetUserResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetUser(GetUserRequest getUserRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetUserRequestMarshaller().Marshall(getUserRequest);
            var unmarshaller = GetUserResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Retrieves information about the specified user, including the user's path, GUID, and ARN.</para> <para>If you do not specify a user
        /// name, IAM determines the user name implicitly based on the AWS Access Key ID signing the request.</para>
        /// </summary>
        /// 
        /// <returns>The response from the GetUser service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public GetUserResponse GetUser()
        {
            return GetUser(new GetUserRequest());
        }
        

        #endregion
    
        #region ResyncMFADevice

        /// <summary>
        /// <para>Synchronizes the specified MFA device with AWS servers.</para>
        /// </summary>
        /// 
        /// <param name="resyncMFADeviceRequest">Container for the necessary parameters to execute the ResyncMFADevice service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="InvalidAuthenticationCodeException"/>
        public ResyncMFADeviceResponse ResyncMFADevice(ResyncMFADeviceRequest resyncMFADeviceRequest)
        {
            IAsyncResult asyncResult = invokeResyncMFADevice(resyncMFADeviceRequest, null, null, true);
            return EndResyncMFADevice(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ResyncMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ResyncMFADevice"/>
        /// </summary>
        /// 
        /// <param name="resyncMFADeviceRequest">Container for the necessary parameters to execute the ResyncMFADevice operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginResyncMFADevice(ResyncMFADeviceRequest resyncMFADeviceRequest, AsyncCallback callback, object state)
        {
            return invokeResyncMFADevice(resyncMFADeviceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ResyncMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ResyncMFADevice"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResyncMFADevice.</param>
        public ResyncMFADeviceResponse EndResyncMFADevice(IAsyncResult asyncResult)
        {
            return endOperation<ResyncMFADeviceResponse>(asyncResult);
        }
        
        IAsyncResult invokeResyncMFADevice(ResyncMFADeviceRequest resyncMFADeviceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ResyncMFADeviceRequestMarshaller().Marshall(resyncMFADeviceRequest);
            var unmarshaller = ResyncMFADeviceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListMFADevices

        /// <summary>
        /// <para>Lists the MFA devices. If the request includes the user name, then this action lists all the MFA devices associated with the specified
        /// user name. If you do not specify a user name, IAM determines the user name implicitly based on the AWS Access Key ID signing the
        /// request.</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listMFADevicesRequest">Container for the necessary parameters to execute the ListMFADevices service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public ListMFADevicesResponse ListMFADevices(ListMFADevicesRequest listMFADevicesRequest)
        {
            IAsyncResult asyncResult = invokeListMFADevices(listMFADevicesRequest, null, null, true);
            return EndListMFADevices(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListMFADevices"/>
        /// </summary>
        /// 
        /// <param name="listMFADevicesRequest">Container for the necessary parameters to execute the ListMFADevices operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMFADevices
        ///         operation.</returns>
        public IAsyncResult BeginListMFADevices(ListMFADevicesRequest listMFADevicesRequest, AsyncCallback callback, object state)
        {
            return invokeListMFADevices(listMFADevicesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListMFADevices"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMFADevices.</param>
        /// 
        /// <returns>Returns a ListMFADevicesResult from AmazonIdentityManagementService.</returns>
        public ListMFADevicesResponse EndListMFADevices(IAsyncResult asyncResult)
        {
            return endOperation<ListMFADevicesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListMFADevices(ListMFADevicesRequest listMFADevicesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListMFADevicesRequestMarshaller().Marshall(listMFADevicesRequest);
            var unmarshaller = ListMFADevicesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Lists the MFA devices. If the request includes the user name, then this action lists all the MFA devices associated with the specified
        /// user name. If you do not specify a user name, IAM determines the user name implicitly based on the AWS Access Key ID signing the
        /// request.</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public ListMFADevicesResponse ListMFADevices()
        {
            return ListMFADevices(new ListMFADevicesRequest());
        }
        

        #endregion
    
        #region CreateVirtualMFADevice

        /// <summary>
        /// <para>Creates a new virtual MFA device for the AWS account. After creating the virtual MFA, use EnableMFADevice to attach the MFA device to
        /// an IAM user. For more information about creating and working with virtual MFA devices, go to Using a Virtual MFA Device in <i>Using AWS
        /// Identity and Access Management</i> .</para> <para>For information about limits on the number of MFA devices you can create, see Limitations
        /// on Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>IMPORTANT:</b>The seed information contained in the QR code
        /// and the Base32 string should be treated like any other secret access information, such as your AWS access keys or your passwords. After you
        /// provision your virtual device, you should ensure that the information is destroyed following secure procedures.</para>
        /// </summary>
        /// 
        /// <param name="createVirtualMFADeviceRequest">Container for the necessary parameters to execute the CreateVirtualMFADevice service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateVirtualMFADevice service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        public CreateVirtualMFADeviceResponse CreateVirtualMFADevice(CreateVirtualMFADeviceRequest createVirtualMFADeviceRequest)
        {
            IAsyncResult asyncResult = invokeCreateVirtualMFADevice(createVirtualMFADeviceRequest, null, null, true);
            return EndCreateVirtualMFADevice(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateVirtualMFADevice"/>
        /// </summary>
        /// 
        /// <param name="createVirtualMFADeviceRequest">Container for the necessary parameters to execute the CreateVirtualMFADevice operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateVirtualMFADevice operation.</returns>
        public IAsyncResult BeginCreateVirtualMFADevice(CreateVirtualMFADeviceRequest createVirtualMFADeviceRequest, AsyncCallback callback, object state)
        {
            return invokeCreateVirtualMFADevice(createVirtualMFADeviceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateVirtualMFADevice"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVirtualMFADevice.</param>
        /// 
        /// <returns>Returns a CreateVirtualMFADeviceResult from AmazonIdentityManagementService.</returns>
        public CreateVirtualMFADeviceResponse EndCreateVirtualMFADevice(IAsyncResult asyncResult)
        {
            return endOperation<CreateVirtualMFADeviceResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateVirtualMFADevice(CreateVirtualMFADeviceRequest createVirtualMFADeviceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateVirtualMFADeviceRequestMarshaller().Marshall(createVirtualMFADeviceRequest);
            var unmarshaller = CreateVirtualMFADeviceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListInstanceProfiles

        /// <summary>
        /// <para>Lists the instance profiles that have the specified path prefix. If there are none, the action returns an empty list.</para> <para>You
        /// can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listInstanceProfilesRequest">Container for the necessary parameters to execute the ListInstanceProfiles service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public ListInstanceProfilesResponse ListInstanceProfiles(ListInstanceProfilesRequest listInstanceProfilesRequest)
        {
            IAsyncResult asyncResult = invokeListInstanceProfiles(listInstanceProfilesRequest, null, null, true);
            return EndListInstanceProfiles(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfiles operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListInstanceProfiles"/>
        /// </summary>
        /// 
        /// <param name="listInstanceProfilesRequest">Container for the necessary parameters to execute the ListInstanceProfiles operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListInstanceProfiles operation.</returns>
        public IAsyncResult BeginListInstanceProfiles(ListInstanceProfilesRequest listInstanceProfilesRequest, AsyncCallback callback, object state)
        {
            return invokeListInstanceProfiles(listInstanceProfilesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListInstanceProfiles operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListInstanceProfiles"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceProfiles.</param>
        /// 
        /// <returns>Returns a ListInstanceProfilesResult from AmazonIdentityManagementService.</returns>
        public ListInstanceProfilesResponse EndListInstanceProfiles(IAsyncResult asyncResult)
        {
            return endOperation<ListInstanceProfilesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListInstanceProfiles(ListInstanceProfilesRequest listInstanceProfilesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListInstanceProfilesRequestMarshaller().Marshall(listInstanceProfilesRequest);
            var unmarshaller = ListInstanceProfilesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Lists the instance profiles that have the specified path prefix. If there are none, the action returns an empty list.</para> <para>You
        /// can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public ListInstanceProfilesResponse ListInstanceProfiles()
        {
            return ListInstanceProfiles(new ListInstanceProfilesRequest());
        }
        

        #endregion
    
        #region UpdateAccessKey

        /// <summary>
        /// <para>Changes the status of the specified access key from Active to Inactive, or vice versa. This action can be used to disable a user's key
        /// as part of a key rotation work flow.</para> <para>If the <c>UserName</c> field is not specified, the UserName is determined implicitly based
        /// on the AWS Access Key ID used to sign the request. Because this action works for access keys under the AWS account, this API can be used to
        /// manage root credentials even if the AWS account has no associated users.</para> <para>For information about rotating keys, see Managing Keys
        /// and Certificates in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="updateAccessKeyRequest">Container for the necessary parameters to execute the UpdateAccessKey service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public UpdateAccessKeyResponse UpdateAccessKey(UpdateAccessKeyRequest updateAccessKeyRequest)
        {
            IAsyncResult asyncResult = invokeUpdateAccessKey(updateAccessKeyRequest, null, null, true);
            return EndUpdateAccessKey(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateAccessKey"/>
        /// </summary>
        /// 
        /// <param name="updateAccessKeyRequest">Container for the necessary parameters to execute the UpdateAccessKey operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateAccessKey(UpdateAccessKeyRequest updateAccessKeyRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateAccessKey(updateAccessKeyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateAccessKey"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccessKey.</param>
        public UpdateAccessKeyResponse EndUpdateAccessKey(IAsyncResult asyncResult)
        {
            return endOperation<UpdateAccessKeyResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateAccessKey(UpdateAccessKeyRequest updateAccessKeyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateAccessKeyRequestMarshaller().Marshall(updateAccessKeyRequest);
            var unmarshaller = UpdateAccessKeyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AddUserToGroup

        /// <summary>
        /// <para>Adds the specified user to the specified group.</para>
        /// </summary>
        /// 
        /// <param name="addUserToGroupRequest">Container for the necessary parameters to execute the AddUserToGroup service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        public AddUserToGroupResponse AddUserToGroup(AddUserToGroupRequest addUserToGroupRequest)
        {
            IAsyncResult asyncResult = invokeAddUserToGroup(addUserToGroupRequest, null, null, true);
            return EndAddUserToGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AddUserToGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.AddUserToGroup"/>
        /// </summary>
        /// 
        /// <param name="addUserToGroupRequest">Container for the necessary parameters to execute the AddUserToGroup operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginAddUserToGroup(AddUserToGroupRequest addUserToGroupRequest, AsyncCallback callback, object state)
        {
            return invokeAddUserToGroup(addUserToGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AddUserToGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.AddUserToGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddUserToGroup.</param>
        public AddUserToGroupResponse EndAddUserToGroup(IAsyncResult asyncResult)
        {
            return endOperation<AddUserToGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeAddUserToGroup(AddUserToGroupRequest addUserToGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddUserToGroupRequestMarshaller().Marshall(addUserToGroupRequest);
            var unmarshaller = AddUserToGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetGroup

        /// <summary>
        /// <para>Returns a list of users that are in the specified group. You can paginate the results using the <c>MaxItems</c> and <c>Marker</c>
        /// parameters.</para>
        /// </summary>
        /// 
        /// <param name="getGroupRequest">Container for the necessary parameters to execute the GetGroup service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public GetGroupResponse GetGroup(GetGroupRequest getGroupRequest)
        {
            IAsyncResult asyncResult = invokeGetGroup(getGroupRequest, null, null, true);
            return EndGetGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetGroup"/>
        /// </summary>
        /// 
        /// <param name="getGroupRequest">Container for the necessary parameters to execute the GetGroup operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroup
        ///         operation.</returns>
        public IAsyncResult BeginGetGroup(GetGroupRequest getGroupRequest, AsyncCallback callback, object state)
        {
            return invokeGetGroup(getGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a GetGroupResult from AmazonIdentityManagementService.</returns>
        public GetGroupResponse EndGetGroup(IAsyncResult asyncResult)
        {
            return endOperation<GetGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetGroup(GetGroupRequest getGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetGroupRequestMarshaller().Marshall(getGroupRequest);
            var unmarshaller = GetGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListAccountAliases

        /// <summary>
        /// <para>Lists the account aliases associated with the account. For information about using an AWS account alias, see Using an Alias for Your
        /// AWS Account ID in <i>Using AWS Identity and Access Management</i> .</para> <para>You can paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listAccountAliasesRequest">Container for the necessary parameters to execute the ListAccountAliases service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public ListAccountAliasesResponse ListAccountAliases(ListAccountAliasesRequest listAccountAliasesRequest)
        {
            IAsyncResult asyncResult = invokeListAccountAliases(listAccountAliasesRequest, null, null, true);
            return EndListAccountAliases(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAliases operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListAccountAliases"/>
        /// </summary>
        /// 
        /// <param name="listAccountAliasesRequest">Container for the necessary parameters to execute the ListAccountAliases operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListAccountAliases operation.</returns>
        public IAsyncResult BeginListAccountAliases(ListAccountAliasesRequest listAccountAliasesRequest, AsyncCallback callback, object state)
        {
            return invokeListAccountAliases(listAccountAliasesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListAccountAliases operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListAccountAliases"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAliases.</param>
        /// 
        /// <returns>Returns a ListAccountAliasesResult from AmazonIdentityManagementService.</returns>
        public ListAccountAliasesResponse EndListAccountAliases(IAsyncResult asyncResult)
        {
            return endOperation<ListAccountAliasesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListAccountAliases(ListAccountAliasesRequest listAccountAliasesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListAccountAliasesRequestMarshaller().Marshall(listAccountAliasesRequest);
            var unmarshaller = ListAccountAliasesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Lists the account aliases associated with the account. For information about using an AWS account alias, see Using an Alias for Your
        /// AWS Account ID in <i>Using AWS Identity and Access Management</i> .</para> <para>You can paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public ListAccountAliasesResponse ListAccountAliases()
        {
            return ListAccountAliases(new ListAccountAliasesRequest());
        }
        

        #endregion
    
        #region DeleteGroup

        /// <summary>
        /// <para>Deletes the specified group. The group must not contain any users or have any attached policies.</para>
        /// </summary>
        /// 
        /// <param name="deleteGroupRequest">Container for the necessary parameters to execute the DeleteGroup service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="DeleteConflictException"/>
        public DeleteGroupResponse DeleteGroup(DeleteGroupRequest deleteGroupRequest)
        {
            IAsyncResult asyncResult = invokeDeleteGroup(deleteGroupRequest, null, null, true);
            return EndDeleteGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteGroupRequest">Container for the necessary parameters to execute the DeleteGroup operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteGroup(DeleteGroupRequest deleteGroupRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteGroup(deleteGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        public DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult)
        {
            return endOperation<DeleteGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteGroup(DeleteGroupRequest deleteGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteGroupRequestMarshaller().Marshall(deleteGroupRequest);
            var unmarshaller = DeleteGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetRole

        /// <summary>
        /// <para>Retrieves information about the specified role, including the role's path, GUID, ARN, and the assume role policy.</para>
        /// </summary>
        /// 
        /// <param name="getRoleRequest">Container for the necessary parameters to execute the GetRole service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetRole service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public GetRoleResponse GetRole(GetRoleRequest getRoleRequest)
        {
            IAsyncResult asyncResult = invokeGetRole(getRoleRequest, null, null, true);
            return EndGetRole(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetRole operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetRole"/>
        /// </summary>
        /// 
        /// <param name="getRoleRequest">Container for the necessary parameters to execute the GetRole operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRole
        ///         operation.</returns>
        public IAsyncResult BeginGetRole(GetRoleRequest getRoleRequest, AsyncCallback callback, object state)
        {
            return invokeGetRole(getRoleRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetRole operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetRole"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRole.</param>
        /// 
        /// <returns>Returns a GetRoleResult from AmazonIdentityManagementService.</returns>
        public GetRoleResponse EndGetRole(IAsyncResult asyncResult)
        {
            return endOperation<GetRoleResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetRole(GetRoleRequest getRoleRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetRoleRequestMarshaller().Marshall(getRoleRequest);
            var unmarshaller = GetRoleResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListRolePolicies

        /// <summary>
        /// <para>Lists the names of the policies associated with the specified role. If there are none, the action returns an empty list.</para>
        /// <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listRolePoliciesRequest">Container for the necessary parameters to execute the ListRolePolicies service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListRolePolicies service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public ListRolePoliciesResponse ListRolePolicies(ListRolePoliciesRequest listRolePoliciesRequest)
        {
            IAsyncResult asyncResult = invokeListRolePolicies(listRolePoliciesRequest, null, null, true);
            return EndListRolePolicies(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListRolePolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListRolePolicies"/>
        /// </summary>
        /// 
        /// <param name="listRolePoliciesRequest">Container for the necessary parameters to execute the ListRolePolicies operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRolePolicies
        ///         operation.</returns>
        public IAsyncResult BeginListRolePolicies(ListRolePoliciesRequest listRolePoliciesRequest, AsyncCallback callback, object state)
        {
            return invokeListRolePolicies(listRolePoliciesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListRolePolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListRolePolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRolePolicies.</param>
        /// 
        /// <returns>Returns a ListRolePoliciesResult from AmazonIdentityManagementService.</returns>
        public ListRolePoliciesResponse EndListRolePolicies(IAsyncResult asyncResult)
        {
            return endOperation<ListRolePoliciesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListRolePolicies(ListRolePoliciesRequest listRolePoliciesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListRolePoliciesRequestMarshaller().Marshall(listRolePoliciesRequest);
            var unmarshaller = ListRolePoliciesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListSigningCertificates

        /// <summary>
        /// <para>Returns information about the signing certificates associated with the specified user. If there are none, the action returns an empty
        /// list.</para> <para>Although each user is limited to a small number of signing certificates, you can still paginate the results using the
        /// <c>MaxItems</c> and <c>Marker</c> parameters.</para> <para>If the <c>UserName</c> field is not specified, the user name is determined
        /// implicitly based on the AWS Access Key ID used to sign the request. Because this action works for access keys under the AWS account, this
        /// API can be used to manage root credentials even if the AWS account has no associated users.</para>
        /// </summary>
        /// 
        /// <param name="listSigningCertificatesRequest">Container for the necessary parameters to execute the ListSigningCertificates service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public ListSigningCertificatesResponse ListSigningCertificates(ListSigningCertificatesRequest listSigningCertificatesRequest)
        {
            IAsyncResult asyncResult = invokeListSigningCertificates(listSigningCertificatesRequest, null, null, true);
            return EndListSigningCertificates(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListSigningCertificates"/>
        /// </summary>
        /// 
        /// <param name="listSigningCertificatesRequest">Container for the necessary parameters to execute the ListSigningCertificates operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListSigningCertificates operation.</returns>
        public IAsyncResult BeginListSigningCertificates(ListSigningCertificatesRequest listSigningCertificatesRequest, AsyncCallback callback, object state)
        {
            return invokeListSigningCertificates(listSigningCertificatesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListSigningCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListSigningCertificates"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSigningCertificates.</param>
        /// 
        /// <returns>Returns a ListSigningCertificatesResult from AmazonIdentityManagementService.</returns>
        public ListSigningCertificatesResponse EndListSigningCertificates(IAsyncResult asyncResult)
        {
            return endOperation<ListSigningCertificatesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListSigningCertificates(ListSigningCertificatesRequest listSigningCertificatesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListSigningCertificatesRequestMarshaller().Marshall(listSigningCertificatesRequest);
            var unmarshaller = ListSigningCertificatesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns information about the signing certificates associated with the specified user. If there are none, the action returns an empty
        /// list.</para> <para>Although each user is limited to a small number of signing certificates, you can still paginate the results using the
        /// <c>MaxItems</c> and <c>Marker</c> parameters.</para> <para>If the <c>UserName</c> field is not specified, the user name is determined
        /// implicitly based on the AWS Access Key ID used to sign the request. Because this action works for access keys under the AWS account, this
        /// API can be used to manage root credentials even if the AWS account has no associated users.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public ListSigningCertificatesResponse ListSigningCertificates()
        {
            return ListSigningCertificates(new ListSigningCertificatesRequest());
        }
        

        #endregion
    
        #region UploadSigningCertificate

        /// <summary>
        /// <para>Uploads an X.509 signing certificate and associates it with the specified user. Some AWS services use X.509 signing certificates to
        /// validate requests that are signed with a corresponding private key. When you upload the certificate, its default status is <c>Active</c>
        /// .</para> <para>If the <c>UserName</c> field is not specified, the user name is determined implicitly based on the AWS Access Key ID used to
        /// sign the request. Because this action works for access keys under the AWS account, this API can be used to manage root credentials even if
        /// the AWS account has no associated users.</para> <para><b>NOTE:</b>Because the body of a X.509 certificate can be large, you should use POST
        /// rather than GET when calling UploadSigningCertificate. For information about setting up signatures and authorization through the API, go to
        /// Signing AWS API Requests in the AWS General Reference. For general information about using the Query API with IAM, go to Making Query
        /// Requests in Using IAM.</para>
        /// </summary>
        /// 
        /// <param name="uploadSigningCertificateRequest">Container for the necessary parameters to execute the UploadSigningCertificate service method
        ///          on AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the UploadSigningCertificate service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="DuplicateCertificateException"/>
        /// <exception cref="InvalidCertificateException"/>
        /// <exception cref="MalformedCertificateException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        public UploadSigningCertificateResponse UploadSigningCertificate(UploadSigningCertificateRequest uploadSigningCertificateRequest)
        {
            IAsyncResult asyncResult = invokeUploadSigningCertificate(uploadSigningCertificateRequest, null, null, true);
            return EndUploadSigningCertificate(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UploadSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UploadSigningCertificate"/>
        /// </summary>
        /// 
        /// <param name="uploadSigningCertificateRequest">Container for the necessary parameters to execute the UploadSigningCertificate operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUploadSigningCertificate operation.</returns>
        public IAsyncResult BeginUploadSigningCertificate(UploadSigningCertificateRequest uploadSigningCertificateRequest, AsyncCallback callback, object state)
        {
            return invokeUploadSigningCertificate(uploadSigningCertificateRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UploadSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UploadSigningCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadSigningCertificate.</param>
        /// 
        /// <returns>Returns a UploadSigningCertificateResult from AmazonIdentityManagementService.</returns>
        public UploadSigningCertificateResponse EndUploadSigningCertificate(IAsyncResult asyncResult)
        {
            return endOperation<UploadSigningCertificateResponse>(asyncResult);
        }
        
        IAsyncResult invokeUploadSigningCertificate(UploadSigningCertificateRequest uploadSigningCertificateRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UploadSigningCertificateRequestMarshaller().Marshall(uploadSigningCertificateRequest);
            var unmarshaller = UploadSigningCertificateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteInstanceProfile

        /// <summary>
        /// <para>Deletes the specified instance profile. The instance profile must have an associated role.</para>
        /// </summary>
        /// 
        /// <param name="deleteInstanceProfileRequest">Container for the necessary parameters to execute the DeleteInstanceProfile service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="DeleteConflictException"/>
        public DeleteInstanceProfileResponse DeleteInstanceProfile(DeleteInstanceProfileRequest deleteInstanceProfileRequest)
        {
            IAsyncResult asyncResult = invokeDeleteInstanceProfile(deleteInstanceProfileRequest, null, null, true);
            return EndDeleteInstanceProfile(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="deleteInstanceProfileRequest">Container for the necessary parameters to execute the DeleteInstanceProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteInstanceProfile(DeleteInstanceProfileRequest deleteInstanceProfileRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteInstanceProfile(deleteInstanceProfileRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstanceProfile.</param>
        public DeleteInstanceProfileResponse EndDeleteInstanceProfile(IAsyncResult asyncResult)
        {
            return endOperation<DeleteInstanceProfileResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteInstanceProfile(DeleteInstanceProfileRequest deleteInstanceProfileRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteInstanceProfileRequestMarshaller().Marshall(deleteInstanceProfileRequest);
            var unmarshaller = DeleteInstanceProfileResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateRole

        /// <summary>
        /// <para>Creates a new role for your AWS account.</para> <para>For information about limitations on the number of roles you can create, see
        /// Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="createRoleRequest">Container for the necessary parameters to execute the CreateRole service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateRole service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        public CreateRoleResponse CreateRole(CreateRoleRequest createRoleRequest)
        {
            IAsyncResult asyncResult = invokeCreateRole(createRoleRequest, null, null, true);
            return EndCreateRole(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRole operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateRole"/>
        /// </summary>
        /// 
        /// <param name="createRoleRequest">Container for the necessary parameters to execute the CreateRole operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRole
        ///         operation.</returns>
        public IAsyncResult BeginCreateRole(CreateRoleRequest createRoleRequest, AsyncCallback callback, object state)
        {
            return invokeCreateRole(createRoleRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateRole operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateRole"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRole.</param>
        /// 
        /// <returns>Returns a CreateRoleResult from AmazonIdentityManagementService.</returns>
        public CreateRoleResponse EndCreateRole(IAsyncResult asyncResult)
        {
            return endOperation<CreateRoleResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateRole(CreateRoleRequest createRoleRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateRoleRequestMarshaller().Marshall(createRoleRequest);
            var unmarshaller = CreateRoleResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateLoginProfile

        /// <summary>
        /// <para>Changes the password for the specified user.</para>
        /// </summary>
        /// 
        /// <param name="updateLoginProfileRequest">Container for the necessary parameters to execute the UpdateLoginProfile service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="PasswordPolicyViolationException"/>
        /// <exception cref="EntityTemporarilyUnmodifiableException"/>
        /// <exception cref="NoSuchEntityException"/>
        public UpdateLoginProfileResponse UpdateLoginProfile(UpdateLoginProfileRequest updateLoginProfileRequest)
        {
            IAsyncResult asyncResult = invokeUpdateLoginProfile(updateLoginProfileRequest, null, null, true);
            return EndUpdateLoginProfile(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="updateLoginProfileRequest">Container for the necessary parameters to execute the UpdateLoginProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateLoginProfile(UpdateLoginProfileRequest updateLoginProfileRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateLoginProfile(updateLoginProfileRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLoginProfile.</param>
        public UpdateLoginProfileResponse EndUpdateLoginProfile(IAsyncResult asyncResult)
        {
            return endOperation<UpdateLoginProfileResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateLoginProfile(UpdateLoginProfileRequest updateLoginProfileRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateLoginProfileRequestMarshaller().Marshall(updateLoginProfileRequest);
            var unmarshaller = UpdateLoginProfileResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteLoginProfile

        /// <summary>
        /// <para>Deletes the password for the specified user, which terminates the user's ability to access AWS services through the AWS Management
        /// Console.</para> <para><b>IMPORTANT:</b>Deleting a user's password does not prevent a user from accessing IAM through the command line
        /// interface or the API. To prevent all user access you must also either make the access key inactive or delete it. For more information
        /// about making keys inactive or deleting them, see UpdateAccessKey and DeleteAccessKey. </para>
        /// </summary>
        /// 
        /// <param name="deleteLoginProfileRequest">Container for the necessary parameters to execute the DeleteLoginProfile service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="EntityTemporarilyUnmodifiableException"/>
        /// <exception cref="NoSuchEntityException"/>
        public DeleteLoginProfileResponse DeleteLoginProfile(DeleteLoginProfileRequest deleteLoginProfileRequest)
        {
            IAsyncResult asyncResult = invokeDeleteLoginProfile(deleteLoginProfileRequest, null, null, true);
            return EndDeleteLoginProfile(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="deleteLoginProfileRequest">Container for the necessary parameters to execute the DeleteLoginProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteLoginProfile(DeleteLoginProfileRequest deleteLoginProfileRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteLoginProfile(deleteLoginProfileRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoginProfile.</param>
        public DeleteLoginProfileResponse EndDeleteLoginProfile(IAsyncResult asyncResult)
        {
            return endOperation<DeleteLoginProfileResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteLoginProfile(DeleteLoginProfileRequest deleteLoginProfileRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteLoginProfileRequestMarshaller().Marshall(deleteLoginProfileRequest);
            var unmarshaller = DeleteLoginProfileResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ChangePassword

        /// <summary>
        /// <para>Changes the password of the IAM user calling <c>ChangePassword</c> . The root account password is not affected by this action. For
        /// information about modifying passwords, see Managing Passwords.</para>
        /// </summary>
        /// 
        /// <param name="changePasswordRequest">Container for the necessary parameters to execute the ChangePassword service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="InvalidUserTypeException"/>
        public ChangePasswordResponse ChangePassword(ChangePasswordRequest changePasswordRequest)
        {
            IAsyncResult asyncResult = invokeChangePassword(changePasswordRequest, null, null, true);
            return EndChangePassword(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ChangePassword"/>
        /// </summary>
        /// 
        /// <param name="changePasswordRequest">Container for the necessary parameters to execute the ChangePassword operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginChangePassword(ChangePasswordRequest changePasswordRequest, AsyncCallback callback, object state)
        {
            return invokeChangePassword(changePasswordRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ChangePassword operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ChangePassword"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangePassword.</param>
        public ChangePasswordResponse EndChangePassword(IAsyncResult asyncResult)
        {
            return endOperation<ChangePasswordResponse>(asyncResult);
        }
        
        IAsyncResult invokeChangePassword(ChangePasswordRequest changePasswordRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ChangePasswordRequestMarshaller().Marshall(changePasswordRequest);
            var unmarshaller = ChangePasswordResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetServerCertificate

        /// <summary>
        /// <para>Retrieves information about the specified server certificate.</para>
        /// </summary>
        /// 
        /// <param name="getServerCertificateRequest">Container for the necessary parameters to execute the GetServerCertificate service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetServerCertificate service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public GetServerCertificateResponse GetServerCertificate(GetServerCertificateRequest getServerCertificateRequest)
        {
            IAsyncResult asyncResult = invokeGetServerCertificate(getServerCertificateRequest, null, null, true);
            return EndGetServerCertificate(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="getServerCertificateRequest">Container for the necessary parameters to execute the GetServerCertificate operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetServerCertificate operation.</returns>
        public IAsyncResult BeginGetServerCertificate(GetServerCertificateRequest getServerCertificateRequest, AsyncCallback callback, object state)
        {
            return invokeGetServerCertificate(getServerCertificateRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServerCertificate.</param>
        /// 
        /// <returns>Returns a GetServerCertificateResult from AmazonIdentityManagementService.</returns>
        public GetServerCertificateResponse EndGetServerCertificate(IAsyncResult asyncResult)
        {
            return endOperation<GetServerCertificateResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetServerCertificate(GetServerCertificateRequest getServerCertificateRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetServerCertificateRequestMarshaller().Marshall(getServerCertificateRequest);
            var unmarshaller = GetServerCertificateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PutGroupPolicy

        /// <summary>
        /// <para>Adds (or updates) a policy document associated with the specified group. For information about policies, refer to Overview of Policies
        /// in <i>Using AWS Identity and Access Management</i> .</para> <para>For information about limits on the number of policies you can associate
        /// with a group, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>NOTE:</b>Because policy
        /// documents can be large, you should use POST rather than GET when calling PutGroupPolicy. For information about setting up signatures and
        /// authorization through the API, go to Signing AWS API Requests in the AWS General Reference. For general information about using the Query
        /// API with IAM, go to Making Query Requests in Using IAM.</para>
        /// </summary>
        /// 
        /// <param name="putGroupPolicyRequest">Container for the necessary parameters to execute the PutGroupPolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        public PutGroupPolicyResponse PutGroupPolicy(PutGroupPolicyRequest putGroupPolicyRequest)
        {
            IAsyncResult asyncResult = invokePutGroupPolicy(putGroupPolicyRequest, null, null, true);
            return EndPutGroupPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.PutGroupPolicy"/>
        /// </summary>
        /// 
        /// <param name="putGroupPolicyRequest">Container for the necessary parameters to execute the PutGroupPolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutGroupPolicy(PutGroupPolicyRequest putGroupPolicyRequest, AsyncCallback callback, object state)
        {
            return invokePutGroupPolicy(putGroupPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.PutGroupPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGroupPolicy.</param>
        public PutGroupPolicyResponse EndPutGroupPolicy(IAsyncResult asyncResult)
        {
            return endOperation<PutGroupPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokePutGroupPolicy(PutGroupPolicyRequest putGroupPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutGroupPolicyRequestMarshaller().Marshall(putGroupPolicyRequest);
            var unmarshaller = PutGroupPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteSigningCertificate

        /// <summary>
        /// <para>Deletes the specified signing certificate associated with the specified user.</para> <para>If you do not specify a user name, IAM
        /// determines the user name implicitly based on the AWS Access Key ID signing the request. Because this action works for access keys under the
        /// AWS account, you can use this API to manage root credentials even if the AWS account has no associated users.</para>
        /// </summary>
        /// 
        /// <param name="deleteSigningCertificateRequest">Container for the necessary parameters to execute the DeleteSigningCertificate service method
        ///          on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public DeleteSigningCertificateResponse DeleteSigningCertificate(DeleteSigningCertificateRequest deleteSigningCertificateRequest)
        {
            IAsyncResult asyncResult = invokeDeleteSigningCertificate(deleteSigningCertificateRequest, null, null, true);
            return EndDeleteSigningCertificate(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteSigningCertificate"/>
        /// </summary>
        /// 
        /// <param name="deleteSigningCertificateRequest">Container for the necessary parameters to execute the DeleteSigningCertificate operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteSigningCertificate(DeleteSigningCertificateRequest deleteSigningCertificateRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteSigningCertificate(deleteSigningCertificateRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteSigningCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSigningCertificate.</param>
        public DeleteSigningCertificateResponse EndDeleteSigningCertificate(IAsyncResult asyncResult)
        {
            return endOperation<DeleteSigningCertificateResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteSigningCertificate(DeleteSigningCertificateRequest deleteSigningCertificateRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteSigningCertificateRequestMarshaller().Marshall(deleteSigningCertificateRequest);
            var unmarshaller = DeleteSigningCertificateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListUserPolicies

        /// <summary>
        /// <para>Lists the names of the policies associated with the specified user. If there are none, the action returns an empty list.</para>
        /// <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listUserPoliciesRequest">Container for the necessary parameters to execute the ListUserPolicies service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListUserPolicies service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public ListUserPoliciesResponse ListUserPolicies(ListUserPoliciesRequest listUserPoliciesRequest)
        {
            IAsyncResult asyncResult = invokeListUserPolicies(listUserPoliciesRequest, null, null, true);
            return EndListUserPolicies(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListUserPolicies"/>
        /// </summary>
        /// 
        /// <param name="listUserPoliciesRequest">Container for the necessary parameters to execute the ListUserPolicies operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserPolicies
        ///         operation.</returns>
        public IAsyncResult BeginListUserPolicies(ListUserPoliciesRequest listUserPoliciesRequest, AsyncCallback callback, object state)
        {
            return invokeListUserPolicies(listUserPoliciesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListUserPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListUserPolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserPolicies.</param>
        /// 
        /// <returns>Returns a ListUserPoliciesResult from AmazonIdentityManagementService.</returns>
        public ListUserPoliciesResponse EndListUserPolicies(IAsyncResult asyncResult)
        {
            return endOperation<ListUserPoliciesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListUserPolicies(ListUserPoliciesRequest listUserPoliciesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListUserPoliciesRequestMarshaller().Marshall(listUserPoliciesRequest);
            var unmarshaller = ListUserPoliciesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListAccessKeys

        /// <summary>
        /// <para>Returns information about the Access Key IDs associated with the specified user. If there are none, the action returns an empty
        /// list.</para> <para>Although each user is limited to a small number of keys, you can still paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para> <para>If the <c>UserName</c> field is not specified, the UserName is determined implicitly based on the AWS
        /// Access Key ID used to sign the request. Because this action works for access keys under the AWS account, this API can be used to manage root
        /// credentials even if the AWS account has no associated users.</para> <para><b>NOTE:</b>To ensure the security of your AWS account, the secret
        /// access key is accessible only during key and user creation.</para>
        /// </summary>
        /// 
        /// <param name="listAccessKeysRequest">Container for the necessary parameters to execute the ListAccessKeys service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public ListAccessKeysResponse ListAccessKeys(ListAccessKeysRequest listAccessKeysRequest)
        {
            IAsyncResult asyncResult = invokeListAccessKeys(listAccessKeysRequest, null, null, true);
            return EndListAccessKeys(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessKeys operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListAccessKeys"/>
        /// </summary>
        /// 
        /// <param name="listAccessKeysRequest">Container for the necessary parameters to execute the ListAccessKeys operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessKeys
        ///         operation.</returns>
        public IAsyncResult BeginListAccessKeys(ListAccessKeysRequest listAccessKeysRequest, AsyncCallback callback, object state)
        {
            return invokeListAccessKeys(listAccessKeysRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListAccessKeys operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListAccessKeys"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessKeys.</param>
        /// 
        /// <returns>Returns a ListAccessKeysResult from AmazonIdentityManagementService.</returns>
        public ListAccessKeysResponse EndListAccessKeys(IAsyncResult asyncResult)
        {
            return endOperation<ListAccessKeysResponse>(asyncResult);
        }
        
        IAsyncResult invokeListAccessKeys(ListAccessKeysRequest listAccessKeysRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListAccessKeysRequestMarshaller().Marshall(listAccessKeysRequest);
            var unmarshaller = ListAccessKeysResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns information about the Access Key IDs associated with the specified user. If there are none, the action returns an empty
        /// list.</para> <para>Although each user is limited to a small number of keys, you can still paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para> <para>If the <c>UserName</c> field is not specified, the UserName is determined implicitly based on the AWS
        /// Access Key ID used to sign the request. Because this action works for access keys under the AWS account, this API can be used to manage root
        /// credentials even if the AWS account has no associated users.</para> <para><b>NOTE:</b>To ensure the security of your AWS account, the secret
        /// access key is accessible only during key and user creation.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public ListAccessKeysResponse ListAccessKeys()
        {
            return ListAccessKeys(new ListAccessKeysRequest());
        }
        

        #endregion
    
        #region ListGroupsForUser

        /// <summary>
        /// <para>Lists the groups the specified user belongs to.</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c>
        /// parameters.</para>
        /// </summary>
        /// 
        /// <param name="listGroupsForUserRequest">Container for the necessary parameters to execute the ListGroupsForUser service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListGroupsForUser service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public ListGroupsForUserResponse ListGroupsForUser(ListGroupsForUserRequest listGroupsForUserRequest)
        {
            IAsyncResult asyncResult = invokeListGroupsForUser(listGroupsForUserRequest, null, null, true);
            return EndListGroupsForUser(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupsForUser operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListGroupsForUser"/>
        /// </summary>
        /// 
        /// <param name="listGroupsForUserRequest">Container for the necessary parameters to execute the ListGroupsForUser operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupsForUser
        ///         operation.</returns>
        public IAsyncResult BeginListGroupsForUser(ListGroupsForUserRequest listGroupsForUserRequest, AsyncCallback callback, object state)
        {
            return invokeListGroupsForUser(listGroupsForUserRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListGroupsForUser operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListGroupsForUser"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupsForUser.</param>
        /// 
        /// <returns>Returns a ListGroupsForUserResult from AmazonIdentityManagementService.</returns>
        public ListGroupsForUserResponse EndListGroupsForUser(IAsyncResult asyncResult)
        {
            return endOperation<ListGroupsForUserResponse>(asyncResult);
        }
        
        IAsyncResult invokeListGroupsForUser(ListGroupsForUserRequest listGroupsForUserRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListGroupsForUserRequestMarshaller().Marshall(listGroupsForUserRequest);
            var unmarshaller = ListGroupsForUserResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AddRoleToInstanceProfile

        /// <summary>
        /// <para>Adds the specified role to the specified instance profile.</para>
        /// </summary>
        /// 
        /// <param name="addRoleToInstanceProfileRequest">Container for the necessary parameters to execute the AddRoleToInstanceProfile service method
        ///          on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        public AddRoleToInstanceProfileResponse AddRoleToInstanceProfile(AddRoleToInstanceProfileRequest addRoleToInstanceProfileRequest)
        {
            IAsyncResult asyncResult = invokeAddRoleToInstanceProfile(addRoleToInstanceProfileRequest, null, null, true);
            return EndAddRoleToInstanceProfile(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AddRoleToInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.AddRoleToInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="addRoleToInstanceProfileRequest">Container for the necessary parameters to execute the AddRoleToInstanceProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginAddRoleToInstanceProfile(AddRoleToInstanceProfileRequest addRoleToInstanceProfileRequest, AsyncCallback callback, object state)
        {
            return invokeAddRoleToInstanceProfile(addRoleToInstanceProfileRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AddRoleToInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.AddRoleToInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddRoleToInstanceProfile.</param>
        public AddRoleToInstanceProfileResponse EndAddRoleToInstanceProfile(IAsyncResult asyncResult)
        {
            return endOperation<AddRoleToInstanceProfileResponse>(asyncResult);
        }
        
        IAsyncResult invokeAddRoleToInstanceProfile(AddRoleToInstanceProfileRequest addRoleToInstanceProfileRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddRoleToInstanceProfileRequestMarshaller().Marshall(addRoleToInstanceProfileRequest);
            var unmarshaller = AddRoleToInstanceProfileResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetGroupPolicy

        /// <summary>
        /// <para>Retrieves the specified policy document for the specified group. The returned policy is URL-encoded according to RFC 3986. For more
        /// information about RFC 3986, go to http://www.faqs.org/rfcs/rfc3986.html.</para>
        /// </summary>
        /// 
        /// <param name="getGroupPolicyRequest">Container for the necessary parameters to execute the GetGroupPolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetGroupPolicy service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public GetGroupPolicyResponse GetGroupPolicy(GetGroupPolicyRequest getGroupPolicyRequest)
        {
            IAsyncResult asyncResult = invokeGetGroupPolicy(getGroupPolicyRequest, null, null, true);
            return EndGetGroupPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetGroupPolicy"/>
        /// </summary>
        /// 
        /// <param name="getGroupPolicyRequest">Container for the necessary parameters to execute the GetGroupPolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupPolicy
        ///         operation.</returns>
        public IAsyncResult BeginGetGroupPolicy(GetGroupPolicyRequest getGroupPolicyRequest, AsyncCallback callback, object state)
        {
            return invokeGetGroupPolicy(getGroupPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetGroupPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupPolicy.</param>
        /// 
        /// <returns>Returns a GetGroupPolicyResult from AmazonIdentityManagementService.</returns>
        public GetGroupPolicyResponse EndGetGroupPolicy(IAsyncResult asyncResult)
        {
            return endOperation<GetGroupPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetGroupPolicy(GetGroupPolicyRequest getGroupPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetGroupPolicyRequestMarshaller().Marshall(getGroupPolicyRequest);
            var unmarshaller = GetGroupPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetRolePolicy

        /// <summary>
        /// <para>Retrieves the specified policy document for the specified role. The returned policy is URL-encoded according to RFC 3986. For more
        /// information about RFC 3986, go to http://www.faqs.org/rfcs/rfc3986.html.</para>
        /// </summary>
        /// 
        /// <param name="getRolePolicyRequest">Container for the necessary parameters to execute the GetRolePolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetRolePolicy service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public GetRolePolicyResponse GetRolePolicy(GetRolePolicyRequest getRolePolicyRequest)
        {
            IAsyncResult asyncResult = invokeGetRolePolicy(getRolePolicyRequest, null, null, true);
            return EndGetRolePolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="getRolePolicyRequest">Container for the necessary parameters to execute the GetRolePolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRolePolicy
        ///         operation.</returns>
        public IAsyncResult BeginGetRolePolicy(GetRolePolicyRequest getRolePolicyRequest, AsyncCallback callback, object state)
        {
            return invokeGetRolePolicy(getRolePolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRolePolicy.</param>
        /// 
        /// <returns>Returns a GetRolePolicyResult from AmazonIdentityManagementService.</returns>
        public GetRolePolicyResponse EndGetRolePolicy(IAsyncResult asyncResult)
        {
            return endOperation<GetRolePolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetRolePolicy(GetRolePolicyRequest getRolePolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetRolePolicyRequestMarshaller().Marshall(getRolePolicyRequest);
            var unmarshaller = GetRolePolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListInstanceProfilesForRole

        /// <summary>
        /// <para>Lists the instance profiles that have the specified associated role. If there are none, the action returns an empty list.</para>
        /// <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listInstanceProfilesForRoleRequest">Container for the necessary parameters to execute the ListInstanceProfilesForRole service
        ///          method on AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListInstanceProfilesForRole service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public ListInstanceProfilesForRoleResponse ListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest listInstanceProfilesForRoleRequest)
        {
            IAsyncResult asyncResult = invokeListInstanceProfilesForRole(listInstanceProfilesForRoleRequest, null, null, true);
            return EndListInstanceProfilesForRole(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfilesForRole operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListInstanceProfilesForRole"/>
        /// </summary>
        /// 
        /// <param name="listInstanceProfilesForRoleRequest">Container for the necessary parameters to execute the ListInstanceProfilesForRole operation
        ///          on AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListInstanceProfilesForRole operation.</returns>
        public IAsyncResult BeginListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest listInstanceProfilesForRoleRequest, AsyncCallback callback, object state)
        {
            return invokeListInstanceProfilesForRole(listInstanceProfilesForRoleRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListInstanceProfilesForRole operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListInstanceProfilesForRole"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceProfilesForRole.</param>
        /// 
        /// <returns>Returns a ListInstanceProfilesForRoleResult from AmazonIdentityManagementService.</returns>
        public ListInstanceProfilesForRoleResponse EndListInstanceProfilesForRole(IAsyncResult asyncResult)
        {
            return endOperation<ListInstanceProfilesForRoleResponse>(asyncResult);
        }
        
        IAsyncResult invokeListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest listInstanceProfilesForRoleRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListInstanceProfilesForRoleRequestMarshaller().Marshall(listInstanceProfilesForRoleRequest);
            var unmarshaller = ListInstanceProfilesForRoleResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListVirtualMFADevices

        /// <summary>
        /// <para> Lists the virtual MFA devices under the AWS account by assignment status. If you do not specify an assignment status, the action
        /// returns a list of all virtual MFA devices. Assignment status can be <c>Assigned</c> ,
        /// 
        /// <c>Unassigned</c> , or <c>Any</c> .
        /// </para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listVirtualMFADevicesRequest">Container for the necessary parameters to execute the ListVirtualMFADevices service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public ListVirtualMFADevicesResponse ListVirtualMFADevices(ListVirtualMFADevicesRequest listVirtualMFADevicesRequest)
        {
            IAsyncResult asyncResult = invokeListVirtualMFADevices(listVirtualMFADevicesRequest, null, null, true);
            return EndListVirtualMFADevices(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListVirtualMFADevices"/>
        /// </summary>
        /// 
        /// <param name="listVirtualMFADevicesRequest">Container for the necessary parameters to execute the ListVirtualMFADevices operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListVirtualMFADevices operation.</returns>
        public IAsyncResult BeginListVirtualMFADevices(ListVirtualMFADevicesRequest listVirtualMFADevicesRequest, AsyncCallback callback, object state)
        {
            return invokeListVirtualMFADevices(listVirtualMFADevicesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListVirtualMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListVirtualMFADevices"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVirtualMFADevices.</param>
        /// 
        /// <returns>Returns a ListVirtualMFADevicesResult from AmazonIdentityManagementService.</returns>
        public ListVirtualMFADevicesResponse EndListVirtualMFADevices(IAsyncResult asyncResult)
        {
            return endOperation<ListVirtualMFADevicesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListVirtualMFADevices(ListVirtualMFADevicesRequest listVirtualMFADevicesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListVirtualMFADevicesRequestMarshaller().Marshall(listVirtualMFADevicesRequest);
            var unmarshaller = ListVirtualMFADevicesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Lists the virtual MFA devices under the AWS account by assignment status. If you do not specify an assignment status, the action
        /// returns a list of all virtual MFA devices. Assignment status can be <c>Assigned</c> ,
        /// 
        /// <c>Unassigned</c> , or <c>Any</c> .
        /// </para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public ListVirtualMFADevicesResponse ListVirtualMFADevices()
        {
            return ListVirtualMFADevices(new ListVirtualMFADevicesRequest());
        }
        

        #endregion
    
        #region DeleteRolePolicy

        /// <summary>
        /// <para>Deletes the specified policy associated with the specified role.</para>
        /// </summary>
        /// 
        /// <param name="deleteRolePolicyRequest">Container for the necessary parameters to execute the DeleteRolePolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public DeleteRolePolicyResponse DeleteRolePolicy(DeleteRolePolicyRequest deleteRolePolicyRequest)
        {
            IAsyncResult asyncResult = invokeDeleteRolePolicy(deleteRolePolicyRequest, null, null, true);
            return EndDeleteRolePolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="deleteRolePolicyRequest">Container for the necessary parameters to execute the DeleteRolePolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteRolePolicy(DeleteRolePolicyRequest deleteRolePolicyRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteRolePolicy(deleteRolePolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRolePolicy.</param>
        public DeleteRolePolicyResponse EndDeleteRolePolicy(IAsyncResult asyncResult)
        {
            return endOperation<DeleteRolePolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteRolePolicy(DeleteRolePolicyRequest deleteRolePolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteRolePolicyRequestMarshaller().Marshall(deleteRolePolicyRequest);
            var unmarshaller = DeleteRolePolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateInstanceProfile

        /// <summary>
        /// <para>Creates a new instance profile.</para> <para>For information about the number of instance profiles you can create, see Limitations on
        /// IAM Entities in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="createInstanceProfileRequest">Container for the necessary parameters to execute the CreateInstanceProfile service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateInstanceProfile service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        public CreateInstanceProfileResponse CreateInstanceProfile(CreateInstanceProfileRequest createInstanceProfileRequest)
        {
            IAsyncResult asyncResult = invokeCreateInstanceProfile(createInstanceProfileRequest, null, null, true);
            return EndCreateInstanceProfile(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="createInstanceProfileRequest">Container for the necessary parameters to execute the CreateInstanceProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateInstanceProfile operation.</returns>
        public IAsyncResult BeginCreateInstanceProfile(CreateInstanceProfileRequest createInstanceProfileRequest, AsyncCallback callback, object state)
        {
            return invokeCreateInstanceProfile(createInstanceProfileRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceProfile.</param>
        /// 
        /// <returns>Returns a CreateInstanceProfileResult from AmazonIdentityManagementService.</returns>
        public CreateInstanceProfileResponse EndCreateInstanceProfile(IAsyncResult asyncResult)
        {
            return endOperation<CreateInstanceProfileResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateInstanceProfile(CreateInstanceProfileRequest createInstanceProfileRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateInstanceProfileRequestMarshaller().Marshall(createInstanceProfileRequest);
            var unmarshaller = CreateInstanceProfileResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListGroupPolicies

        /// <summary>
        /// <para>Lists the names of the policies associated with the specified group. If there are none, the action returns an empty list.</para>
        /// <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listGroupPoliciesRequest">Container for the necessary parameters to execute the ListGroupPolicies service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListGroupPolicies service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public ListGroupPoliciesResponse ListGroupPolicies(ListGroupPoliciesRequest listGroupPoliciesRequest)
        {
            IAsyncResult asyncResult = invokeListGroupPolicies(listGroupPoliciesRequest, null, null, true);
            return EndListGroupPolicies(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListGroupPolicies"/>
        /// </summary>
        /// 
        /// <param name="listGroupPoliciesRequest">Container for the necessary parameters to execute the ListGroupPolicies operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupPolicies
        ///         operation.</returns>
        public IAsyncResult BeginListGroupPolicies(ListGroupPoliciesRequest listGroupPoliciesRequest, AsyncCallback callback, object state)
        {
            return invokeListGroupPolicies(listGroupPoliciesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListGroupPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListGroupPolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupPolicies.</param>
        /// 
        /// <returns>Returns a ListGroupPoliciesResult from AmazonIdentityManagementService.</returns>
        public ListGroupPoliciesResponse EndListGroupPolicies(IAsyncResult asyncResult)
        {
            return endOperation<ListGroupPoliciesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListGroupPolicies(ListGroupPoliciesRequest listGroupPoliciesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListGroupPoliciesRequestMarshaller().Marshall(listGroupPoliciesRequest);
            var unmarshaller = ListGroupPoliciesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateLoginProfile

        /// <summary>
        /// <para>Creates a password for the specified user, giving the user the ability to access AWS services through the AWS Management Console. For
        /// more information about managing passwords, see Managing Passwords in <i>Using IAM</i> .</para>
        /// </summary>
        /// 
        /// <param name="createLoginProfileRequest">Container for the necessary parameters to execute the CreateLoginProfile service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateLoginProfile service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="PasswordPolicyViolationException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        public CreateLoginProfileResponse CreateLoginProfile(CreateLoginProfileRequest createLoginProfileRequest)
        {
            IAsyncResult asyncResult = invokeCreateLoginProfile(createLoginProfileRequest, null, null, true);
            return EndCreateLoginProfile(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="createLoginProfileRequest">Container for the necessary parameters to execute the CreateLoginProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateLoginProfile operation.</returns>
        public IAsyncResult BeginCreateLoginProfile(CreateLoginProfileRequest createLoginProfileRequest, AsyncCallback callback, object state)
        {
            return invokeCreateLoginProfile(createLoginProfileRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoginProfile.</param>
        /// 
        /// <returns>Returns a CreateLoginProfileResult from AmazonIdentityManagementService.</returns>
        public CreateLoginProfileResponse EndCreateLoginProfile(IAsyncResult asyncResult)
        {
            return endOperation<CreateLoginProfileResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateLoginProfile(CreateLoginProfileRequest createLoginProfileRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateLoginProfileRequestMarshaller().Marshall(createLoginProfileRequest);
            var unmarshaller = CreateLoginProfileResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RemoveRoleFromInstanceProfile

        /// <summary>
        /// <para>Removes the specified role from the specified instance profile.</para>
        /// </summary>
        /// 
        /// <param name="removeRoleFromInstanceProfileRequest">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile
        ///          service method on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public RemoveRoleFromInstanceProfileResponse RemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest removeRoleFromInstanceProfileRequest)
        {
            IAsyncResult asyncResult = invokeRemoveRoleFromInstanceProfile(removeRoleFromInstanceProfileRequest, null, null, true);
            return EndRemoveRoleFromInstanceProfile(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRoleFromInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.RemoveRoleFromInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="removeRoleFromInstanceProfileRequest">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile
        ///          operation on AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest removeRoleFromInstanceProfileRequest, AsyncCallback callback, object state)
        {
            return invokeRemoveRoleFromInstanceProfile(removeRoleFromInstanceProfileRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RemoveRoleFromInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.RemoveRoleFromInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveRoleFromInstanceProfile.</param>
        public RemoveRoleFromInstanceProfileResponse EndRemoveRoleFromInstanceProfile(IAsyncResult asyncResult)
        {
            return endOperation<RemoveRoleFromInstanceProfileResponse>(asyncResult);
        }
        
        IAsyncResult invokeRemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest removeRoleFromInstanceProfileRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RemoveRoleFromInstanceProfileRequestMarshaller().Marshall(removeRoleFromInstanceProfileRequest);
            var unmarshaller = RemoveRoleFromInstanceProfileResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateAccountPasswordPolicy

        /// <summary>
        /// <para>Updates the password policy settings for the account. For more information about using a password policy, go to Managing an IAM
        /// Password Policy.</para>
        /// </summary>
        /// 
        /// <param name="updateAccountPasswordPolicyRequest">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy service
        ///          method on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="NoSuchEntityException"/>
        public UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest updateAccountPasswordPolicyRequest)
        {
            IAsyncResult asyncResult = invokeUpdateAccountPasswordPolicy(updateAccountPasswordPolicyRequest, null, null, true);
            return EndUpdateAccountPasswordPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateAccountPasswordPolicy"/>
        /// </summary>
        /// 
        /// <param name="updateAccountPasswordPolicyRequest">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy operation
        ///          on AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest updateAccountPasswordPolicyRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateAccountPasswordPolicy(updateAccountPasswordPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateAccountPasswordPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountPasswordPolicy.</param>
        public UpdateAccountPasswordPolicyResponse EndUpdateAccountPasswordPolicy(IAsyncResult asyncResult)
        {
            return endOperation<UpdateAccountPasswordPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest updateAccountPasswordPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateAccountPasswordPolicyRequestMarshaller().Marshall(updateAccountPasswordPolicyRequest);
            var unmarshaller = UpdateAccountPasswordPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Updates the password policy settings for the account. For more information about using a password policy, go to Managing an IAM
        /// Password Policy.</para>
        /// </summary>
        /// 
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="NoSuchEntityException"/>
        public UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy()
        {
            return UpdateAccountPasswordPolicy(new UpdateAccountPasswordPolicyRequest());
        }
        

        #endregion
    
        #region UpdateAssumeRolePolicy

        /// <summary>
        /// <para>Updates the policy governing how the given role can be assumed.</para>
        /// </summary>
        /// 
        /// <param name="updateAssumeRolePolicyRequest">Container for the necessary parameters to execute the UpdateAssumeRolePolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="NoSuchEntityException"/>
        public UpdateAssumeRolePolicyResponse UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest updateAssumeRolePolicyRequest)
        {
            IAsyncResult asyncResult = invokeUpdateAssumeRolePolicy(updateAssumeRolePolicyRequest, null, null, true);
            return EndUpdateAssumeRolePolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssumeRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateAssumeRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="updateAssumeRolePolicyRequest">Container for the necessary parameters to execute the UpdateAssumeRolePolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest updateAssumeRolePolicyRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateAssumeRolePolicy(updateAssumeRolePolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateAssumeRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateAssumeRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssumeRolePolicy.</param>
        public UpdateAssumeRolePolicyResponse EndUpdateAssumeRolePolicy(IAsyncResult asyncResult)
        {
            return endOperation<UpdateAssumeRolePolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest updateAssumeRolePolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateAssumeRolePolicyRequestMarshaller().Marshall(updateAssumeRolePolicyRequest);
            var unmarshaller = UpdateAssumeRolePolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetInstanceProfile

        /// <summary>
        /// <para>Retrieves information about the specified instance profile, including the instance profile's path, GUID, ARN, and role.</para>
        /// </summary>
        /// 
        /// <param name="getInstanceProfileRequest">Container for the necessary parameters to execute the GetInstanceProfile service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetInstanceProfile service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public GetInstanceProfileResponse GetInstanceProfile(GetInstanceProfileRequest getInstanceProfileRequest)
        {
            IAsyncResult asyncResult = invokeGetInstanceProfile(getInstanceProfileRequest, null, null, true);
            return EndGetInstanceProfile(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="getInstanceProfileRequest">Container for the necessary parameters to execute the GetInstanceProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetInstanceProfile operation.</returns>
        public IAsyncResult BeginGetInstanceProfile(GetInstanceProfileRequest getInstanceProfileRequest, AsyncCallback callback, object state)
        {
            return invokeGetInstanceProfile(getInstanceProfileRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceProfile.</param>
        /// 
        /// <returns>Returns a GetInstanceProfileResult from AmazonIdentityManagementService.</returns>
        public GetInstanceProfileResponse EndGetInstanceProfile(IAsyncResult asyncResult)
        {
            return endOperation<GetInstanceProfileResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetInstanceProfile(GetInstanceProfileRequest getInstanceProfileRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetInstanceProfileRequestMarshaller().Marshall(getInstanceProfileRequest);
            var unmarshaller = GetInstanceProfileResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListRoles

        /// <summary>
        /// <para>Lists the roles have the specified path prefix. If there are none, the action returns an empty list.</para> <para>You can paginate the
        /// results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listRolesRequest">Container for the necessary parameters to execute the ListRoles service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public ListRolesResponse ListRoles(ListRolesRequest listRolesRequest)
        {
            IAsyncResult asyncResult = invokeListRoles(listRolesRequest, null, null, true);
            return EndListRoles(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoles operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListRoles"/>
        /// </summary>
        /// 
        /// <param name="listRolesRequest">Container for the necessary parameters to execute the ListRoles operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoles
        ///         operation.</returns>
        public IAsyncResult BeginListRoles(ListRolesRequest listRolesRequest, AsyncCallback callback, object state)
        {
            return invokeListRoles(listRolesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListRoles operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListRoles"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoles.</param>
        /// 
        /// <returns>Returns a ListRolesResult from AmazonIdentityManagementService.</returns>
        public ListRolesResponse EndListRoles(IAsyncResult asyncResult)
        {
            return endOperation<ListRolesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListRoles(ListRolesRequest listRolesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListRolesRequestMarshaller().Marshall(listRolesRequest);
            var unmarshaller = ListRolesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Lists the roles have the specified path prefix. If there are none, the action returns an empty list.</para> <para>You can paginate the
        /// results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public ListRolesResponse ListRoles()
        {
            return ListRoles(new ListRolesRequest());
        }
        

        #endregion
    
        #region GetAccountSummary

        /// <summary>
        /// <para>Retrieves account level information about account entity usage and IAM quotas.</para> <para>For information about limitations on IAM
        /// entities, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="getAccountSummaryRequest">Container for the necessary parameters to execute the GetAccountSummary service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public GetAccountSummaryResponse GetAccountSummary(GetAccountSummaryRequest getAccountSummaryRequest)
        {
            IAsyncResult asyncResult = invokeGetAccountSummary(getAccountSummaryRequest, null, null, true);
            return EndGetAccountSummary(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSummary operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetAccountSummary"/>
        /// </summary>
        /// 
        /// <param name="getAccountSummaryRequest">Container for the necessary parameters to execute the GetAccountSummary operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountSummary
        ///         operation.</returns>
        public IAsyncResult BeginGetAccountSummary(GetAccountSummaryRequest getAccountSummaryRequest, AsyncCallback callback, object state)
        {
            return invokeGetAccountSummary(getAccountSummaryRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetAccountSummary operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetAccountSummary"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSummary.</param>
        /// 
        /// <returns>Returns a GetAccountSummaryResult from AmazonIdentityManagementService.</returns>
        public GetAccountSummaryResponse EndGetAccountSummary(IAsyncResult asyncResult)
        {
            return endOperation<GetAccountSummaryResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetAccountSummary(GetAccountSummaryRequest getAccountSummaryRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetAccountSummaryRequestMarshaller().Marshall(getAccountSummaryRequest);
            var unmarshaller = GetAccountSummaryResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Retrieves account level information about account entity usage and IAM quotas.</para> <para>For information about limitations on IAM
        /// entities, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        public GetAccountSummaryResponse GetAccountSummary()
        {
            return GetAccountSummary(new GetAccountSummaryRequest());
        }
        

        #endregion
    
        #region GetAccountPasswordPolicy

        /// <summary>
        /// <para>Retrieves the password policy for the AWS account. For more information about using a password policy, go to Managing an IAM Password
        /// Policy.</para>
        /// </summary>
        /// 
        /// <param name="getAccountPasswordPolicyRequest">Container for the necessary parameters to execute the GetAccountPasswordPolicy service method
        ///          on AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetAccountPasswordPolicy service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public GetAccountPasswordPolicyResponse GetAccountPasswordPolicy(GetAccountPasswordPolicyRequest getAccountPasswordPolicyRequest)
        {
            IAsyncResult asyncResult = invokeGetAccountPasswordPolicy(getAccountPasswordPolicyRequest, null, null, true);
            return EndGetAccountPasswordPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetAccountPasswordPolicy"/>
        /// </summary>
        /// 
        /// <param name="getAccountPasswordPolicyRequest">Container for the necessary parameters to execute the GetAccountPasswordPolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetAccountPasswordPolicy operation.</returns>
        public IAsyncResult BeginGetAccountPasswordPolicy(GetAccountPasswordPolicyRequest getAccountPasswordPolicyRequest, AsyncCallback callback, object state)
        {
            return invokeGetAccountPasswordPolicy(getAccountPasswordPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.GetAccountPasswordPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountPasswordPolicy.</param>
        /// 
        /// <returns>Returns a GetAccountPasswordPolicyResult from AmazonIdentityManagementService.</returns>
        public GetAccountPasswordPolicyResponse EndGetAccountPasswordPolicy(IAsyncResult asyncResult)
        {
            return endOperation<GetAccountPasswordPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetAccountPasswordPolicy(GetAccountPasswordPolicyRequest getAccountPasswordPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetAccountPasswordPolicyRequestMarshaller().Marshall(getAccountPasswordPolicyRequest);
            var unmarshaller = GetAccountPasswordPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Retrieves the password policy for the AWS account. For more information about using a password policy, go to Managing an IAM Password
        /// Policy.</para>
        /// </summary>
        /// 
        /// <returns>The response from the GetAccountPasswordPolicy service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        public GetAccountPasswordPolicyResponse GetAccountPasswordPolicy()
        {
            return GetAccountPasswordPolicy(new GetAccountPasswordPolicyRequest());
        }
        

        #endregion
    
    }
}
    
