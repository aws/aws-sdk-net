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

using Amazon.CloudFront.Model;
using Amazon.CloudFront.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.CloudFront
{
    /// <summary>
    /// Implementation for accessing AmazonCloudFront.
    ///  
    /// 
    /// </summary>
    public class AmazonCloudFrontClient : AmazonWebServiceClient, AmazonCloudFront
    {
    
        AbstractAWSSigner signer = new CloudFrontSigner();

        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudFrontClient with the credentials loaded from the application's
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
        public AmazonCloudFrontClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFrontConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with the credentials loaded from the application's
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
        public AmazonCloudFrontClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFrontConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudFront Configuration Object</param>
        public AmazonCloudFrontClient(AmazonCloudFrontConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudFrontClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudFrontConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudFrontConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Credentials and an
        /// AmazonCloudFrontClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(AWSCredentials credentials, AmazonCloudFrontConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFrontConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFrontConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFrontClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudFrontConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFrontConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFrontConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFrontClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFrontClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudFrontClient Configuration Object</param>
        public AmazonCloudFrontClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudFrontConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion
   
        #region CreateInvalidation

        /// <summary>
        /// <para> Create a new invalidation. </para>
        /// </summary>
        /// 
        /// <param name="createInvalidationRequest">Container for the necessary parameters to execute the CreateInvalidation service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the CreateInvalidation service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="TooManyInvalidationsInProgressException"/>
        /// <exception cref="MissingBodyException"/>
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="BatchTooLargeException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="InconsistentQuantitiesException"/>
        public CreateInvalidationResponse CreateInvalidation(CreateInvalidationRequest createInvalidationRequest)
        {
            IAsyncResult asyncResult = invokeCreateInvalidation(createInvalidationRequest, null, null, true);
            return EndCreateInvalidation(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateInvalidation"/>
        /// </summary>
        /// 
        /// <param name="createInvalidationRequest">Container for the necessary parameters to execute the CreateInvalidation operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateInvalidation operation.</returns>
        public IAsyncResult BeginCreateInvalidation(CreateInvalidationRequest createInvalidationRequest, AsyncCallback callback, object state)
        {
            return invokeCreateInvalidation(createInvalidationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateInvalidation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInvalidation.</param>
        /// 
        /// <returns>Returns a CreateInvalidationResult from AmazonCloudFront.</returns>
        public CreateInvalidationResponse EndCreateInvalidation(IAsyncResult asyncResult)
        {
            return endOperation<CreateInvalidationResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateInvalidation(CreateInvalidationRequest createInvalidationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateInvalidationRequestMarshaller().Marshall(createInvalidationRequest);
            var unmarshaller = CreateInvalidationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListCloudFrontOriginAccessIdentities

        /// <summary>
        /// <para> List origin access identities. </para>
        /// </summary>
        /// 
        /// <param name="listCloudFrontOriginAccessIdentitiesRequest">Container for the necessary parameters to execute the
        ///          ListCloudFrontOriginAccessIdentities service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidArgumentException"/>
        public ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest listCloudFrontOriginAccessIdentitiesRequest)
        {
            IAsyncResult asyncResult = invokeListCloudFrontOriginAccessIdentities(listCloudFrontOriginAccessIdentitiesRequest, null, null, true);
            return EndListCloudFrontOriginAccessIdentities(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudFrontOriginAccessIdentities operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListCloudFrontOriginAccessIdentities"/>
        /// </summary>
        /// 
        /// <param name="listCloudFrontOriginAccessIdentitiesRequest">Container for the necessary parameters to execute the
        ///          ListCloudFrontOriginAccessIdentities operation on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListCloudFrontOriginAccessIdentities operation.</returns>
        public IAsyncResult BeginListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest listCloudFrontOriginAccessIdentitiesRequest, AsyncCallback callback, object state)
        {
            return invokeListCloudFrontOriginAccessIdentities(listCloudFrontOriginAccessIdentitiesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListCloudFrontOriginAccessIdentities operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListCloudFrontOriginAccessIdentities"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudFrontOriginAccessIdentities.</param>
        /// 
        /// <returns>Returns a ListCloudFrontOriginAccessIdentitiesResult from AmazonCloudFront.</returns>
        public ListCloudFrontOriginAccessIdentitiesResponse EndListCloudFrontOriginAccessIdentities(IAsyncResult asyncResult)
        {
            return endOperation<ListCloudFrontOriginAccessIdentitiesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListCloudFrontOriginAccessIdentities(ListCloudFrontOriginAccessIdentitiesRequest listCloudFrontOriginAccessIdentitiesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListCloudFrontOriginAccessIdentitiesRequestMarshaller().Marshall(listCloudFrontOriginAccessIdentitiesRequest);
            var unmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> List origin access identities. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidArgumentException"/>
        public ListCloudFrontOriginAccessIdentitiesResponse ListCloudFrontOriginAccessIdentities()
        {
            return ListCloudFrontOriginAccessIdentities(new ListCloudFrontOriginAccessIdentitiesRequest());
        }
        

        #endregion
    
        #region UpdateCloudFrontOriginAccessIdentity

        /// <summary>
        /// <para> Update an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="updateCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          UpdateCloudFrontOriginAccessIdentity service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the UpdateCloudFrontOriginAccessIdentity service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="IllegalUpdateException"/>
        /// <exception cref="MissingBodyException"/>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="InconsistentQuantitiesException"/>
        public UpdateCloudFrontOriginAccessIdentityResponse UpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest updateCloudFrontOriginAccessIdentityRequest)
        {
            IAsyncResult asyncResult = invokeUpdateCloudFrontOriginAccessIdentity(updateCloudFrontOriginAccessIdentityRequest, null, null, true);
            return EndUpdateCloudFrontOriginAccessIdentity(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.UpdateCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="updateCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          UpdateCloudFrontOriginAccessIdentity operation on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateCloudFrontOriginAccessIdentity operation.</returns>
        public IAsyncResult BeginUpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest updateCloudFrontOriginAccessIdentityRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateCloudFrontOriginAccessIdentity(updateCloudFrontOriginAccessIdentityRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.UpdateCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a UpdateCloudFrontOriginAccessIdentityResult from AmazonCloudFront.</returns>
        public UpdateCloudFrontOriginAccessIdentityResponse EndUpdateCloudFrontOriginAccessIdentity(IAsyncResult asyncResult)
        {
            return endOperation<UpdateCloudFrontOriginAccessIdentityResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateCloudFrontOriginAccessIdentity(UpdateCloudFrontOriginAccessIdentityRequest updateCloudFrontOriginAccessIdentityRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller().Marshall(updateCloudFrontOriginAccessIdentityRequest);
            var unmarshaller = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetStreamingDistribution

        /// <summary>
        /// <para> Get the information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="getStreamingDistributionRequest">Container for the necessary parameters to execute the GetStreamingDistribution service method
        ///          on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchStreamingDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        public GetStreamingDistributionResponse GetStreamingDistribution(GetStreamingDistributionRequest getStreamingDistributionRequest)
        {
            IAsyncResult asyncResult = invokeGetStreamingDistribution(getStreamingDistributionRequest, null, null, true);
            return EndGetStreamingDistribution(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="getStreamingDistributionRequest">Container for the necessary parameters to execute the GetStreamingDistribution operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetStreamingDistribution operation.</returns>
        public IAsyncResult BeginGetStreamingDistribution(GetStreamingDistributionRequest getStreamingDistributionRequest, AsyncCallback callback, object state)
        {
            return invokeGetStreamingDistribution(getStreamingDistributionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingDistribution.</param>
        /// 
        /// <returns>Returns a GetStreamingDistributionResult from AmazonCloudFront.</returns>
        public GetStreamingDistributionResponse EndGetStreamingDistribution(IAsyncResult asyncResult)
        {
            return endOperation<GetStreamingDistributionResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetStreamingDistribution(GetStreamingDistributionRequest getStreamingDistributionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetStreamingDistributionRequestMarshaller().Marshall(getStreamingDistributionRequest);
            var unmarshaller = GetStreamingDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Get the information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchStreamingDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        public GetStreamingDistributionResponse GetStreamingDistribution()
        {
            return GetStreamingDistribution(new GetStreamingDistributionRequest());
        }
        

        #endregion
    
        #region DeleteDistribution

        /// <summary>
        /// <para> Delete a distribution. </para>
        /// </summary>
        /// 
        /// <param name="deleteDistributionRequest">Container for the necessary parameters to execute the DeleteDistribution service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="DistributionNotDisabledException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="AccessDeniedException"/>
        public DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest deleteDistributionRequest)
        {
            IAsyncResult asyncResult = invokeDeleteDistribution(deleteDistributionRequest, null, null, true);
            return EndDeleteDistribution(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.DeleteDistribution"/>
        /// </summary>
        /// 
        /// <param name="deleteDistributionRequest">Container for the necessary parameters to execute the DeleteDistribution operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteDistribution(DeleteDistributionRequest deleteDistributionRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteDistribution(deleteDistributionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.DeleteDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDistribution.</param>
        public DeleteDistributionResponse EndDeleteDistribution(IAsyncResult asyncResult)
        {
            return endOperation<DeleteDistributionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteDistribution(DeleteDistributionRequest deleteDistributionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteDistributionRequestMarshaller().Marshall(deleteDistributionRequest);
            var unmarshaller = DeleteDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Delete a distribution. </para>
        /// </summary>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="DistributionNotDisabledException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="AccessDeniedException"/>
        public DeleteDistributionResponse DeleteDistribution()
        {
            return DeleteDistribution(new DeleteDistributionRequest());
        }
        

        #endregion
    
        #region GetDistributionConfig

        /// <summary>
        /// <para> Get the configuration information about a distribution. </para>
        /// </summary>
        /// 
        /// <param name="getDistributionConfigRequest">Container for the necessary parameters to execute the GetDistributionConfig service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        public GetDistributionConfigResponse GetDistributionConfig(GetDistributionConfigRequest getDistributionConfigRequest)
        {
            IAsyncResult asyncResult = invokeGetDistributionConfig(getDistributionConfigRequest, null, null, true);
            return EndGetDistributionConfig(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetDistributionConfig"/>
        /// </summary>
        /// 
        /// <param name="getDistributionConfigRequest">Container for the necessary parameters to execute the GetDistributionConfig operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetDistributionConfig operation.</returns>
        public IAsyncResult BeginGetDistributionConfig(GetDistributionConfigRequest getDistributionConfigRequest, AsyncCallback callback, object state)
        {
            return invokeGetDistributionConfig(getDistributionConfigRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetDistributionConfig"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistributionConfig.</param>
        /// 
        /// <returns>Returns a GetDistributionConfigResult from AmazonCloudFront.</returns>
        public GetDistributionConfigResponse EndGetDistributionConfig(IAsyncResult asyncResult)
        {
            return endOperation<GetDistributionConfigResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetDistributionConfig(GetDistributionConfigRequest getDistributionConfigRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetDistributionConfigRequestMarshaller().Marshall(getDistributionConfigRequest);
            var unmarshaller = GetDistributionConfigResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Get the configuration information about a distribution. </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        public GetDistributionConfigResponse GetDistributionConfig()
        {
            return GetDistributionConfig(new GetDistributionConfigRequest());
        }
        

        #endregion
    
        #region UpdateDistribution

        /// <summary>
        /// <para> Update a distribution. </para>
        /// </summary>
        /// 
        /// <param name="updateDistributionRequest">Container for the necessary parameters to execute the UpdateDistribution service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the UpdateDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="TooManyCookieNamesInWhiteListException"/>
        /// <exception cref="InvalidDefaultRootObjectException"/>
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="IllegalUpdateException"/>
        /// <exception cref="MissingBodyException"/>
        /// <exception cref="TooManyDistributionCNAMEsException"/>
        /// <exception cref="InvalidForwardCookiesException"/>
        /// <exception cref="NoSuchOriginException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="InconsistentQuantitiesException"/>
        /// <exception cref="CNAMEAlreadyExistsException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="TrustedSignerDoesNotExistException"/>
        /// <exception cref="InvalidOriginAccessIdentityException"/>
        /// <exception cref="TooManyCacheBehaviorsException"/>
        /// <exception cref="TooManyTrustedSignersException"/>
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="TooManyOriginsException"/>
        /// <exception cref="InvalidRequiredProtocolException"/>
        public UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest updateDistributionRequest)
        {
            IAsyncResult asyncResult = invokeUpdateDistribution(updateDistributionRequest, null, null, true);
            return EndUpdateDistribution(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.UpdateDistribution"/>
        /// </summary>
        /// 
        /// <param name="updateDistributionRequest">Container for the necessary parameters to execute the UpdateDistribution operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateDistribution operation.</returns>
        public IAsyncResult BeginUpdateDistribution(UpdateDistributionRequest updateDistributionRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateDistribution(updateDistributionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.UpdateDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDistribution.</param>
        /// 
        /// <returns>Returns a UpdateDistributionResult from AmazonCloudFront.</returns>
        public UpdateDistributionResponse EndUpdateDistribution(IAsyncResult asyncResult)
        {
            return endOperation<UpdateDistributionResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateDistribution(UpdateDistributionRequest updateDistributionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateDistributionRequestMarshaller().Marshall(updateDistributionRequest);
            var unmarshaller = UpdateDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDistribution

        /// <summary>
        /// <para> Create a new distribution. </para>
        /// </summary>
        /// 
        /// <param name="createDistributionRequest">Container for the necessary parameters to execute the CreateDistribution service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the CreateDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="TooManyCookieNamesInWhiteListException"/>
        /// <exception cref="InvalidDefaultRootObjectException"/>
        /// <exception cref="MissingBodyException"/>
        /// <exception cref="TooManyDistributionCNAMEsException"/>
        /// <exception cref="InvalidForwardCookiesException"/>
        /// <exception cref="TooManyDistributionsException"/>
        /// <exception cref="NoSuchOriginException"/>
        /// <exception cref="InconsistentQuantitiesException"/>
        /// <exception cref="CNAMEAlreadyExistsException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="InvalidOriginAccessIdentityException"/>
        /// <exception cref="TrustedSignerDoesNotExistException"/>
        /// <exception cref="InvalidOriginException"/>
        /// <exception cref="TooManyCacheBehaviorsException"/>
        /// <exception cref="TooManyTrustedSignersException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="TooManyOriginsException"/>
        /// <exception cref="DistributionAlreadyExistsException"/>
        /// <exception cref="InvalidRequiredProtocolException"/>
        public CreateDistributionResponse CreateDistribution(CreateDistributionRequest createDistributionRequest)
        {
            IAsyncResult asyncResult = invokeCreateDistribution(createDistributionRequest, null, null, true);
            return EndCreateDistribution(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateDistribution"/>
        /// </summary>
        /// 
        /// <param name="createDistributionRequest">Container for the necessary parameters to execute the CreateDistribution operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateDistribution operation.</returns>
        public IAsyncResult BeginCreateDistribution(CreateDistributionRequest createDistributionRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDistribution(createDistributionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDistribution.</param>
        /// 
        /// <returns>Returns a CreateDistributionResult from AmazonCloudFront.</returns>
        public CreateDistributionResponse EndCreateDistribution(IAsyncResult asyncResult)
        {
            return endOperation<CreateDistributionResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDistribution(CreateDistributionRequest createDistributionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDistributionRequestMarshaller().Marshall(createDistributionRequest);
            var unmarshaller = CreateDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetCloudFrontOriginAccessIdentityConfig

        /// <summary>
        /// <para> Get the configuration information about an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="getCloudFrontOriginAccessIdentityConfigRequest">Container for the necessary parameters to execute the
        ///          GetCloudFrontOriginAccessIdentityConfig service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException"/>
        /// <exception cref="AccessDeniedException"/>
        public GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest getCloudFrontOriginAccessIdentityConfigRequest)
        {
            IAsyncResult asyncResult = invokeGetCloudFrontOriginAccessIdentityConfig(getCloudFrontOriginAccessIdentityConfigRequest, null, null, true);
            return EndGetCloudFrontOriginAccessIdentityConfig(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentityConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetCloudFrontOriginAccessIdentityConfig"/>
        /// </summary>
        /// 
        /// <param name="getCloudFrontOriginAccessIdentityConfigRequest">Container for the necessary parameters to execute the
        ///          GetCloudFrontOriginAccessIdentityConfig operation on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetCloudFrontOriginAccessIdentityConfig operation.</returns>
        public IAsyncResult BeginGetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest getCloudFrontOriginAccessIdentityConfigRequest, AsyncCallback callback, object state)
        {
            return invokeGetCloudFrontOriginAccessIdentityConfig(getCloudFrontOriginAccessIdentityConfigRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetCloudFrontOriginAccessIdentityConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetCloudFrontOriginAccessIdentityConfig"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudFrontOriginAccessIdentityConfig.</param>
        /// 
        /// <returns>Returns a GetCloudFrontOriginAccessIdentityConfigResult from AmazonCloudFront.</returns>
        public GetCloudFrontOriginAccessIdentityConfigResponse EndGetCloudFrontOriginAccessIdentityConfig(IAsyncResult asyncResult)
        {
            return endOperation<GetCloudFrontOriginAccessIdentityConfigResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetCloudFrontOriginAccessIdentityConfig(GetCloudFrontOriginAccessIdentityConfigRequest getCloudFrontOriginAccessIdentityConfigRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetCloudFrontOriginAccessIdentityConfigRequestMarshaller().Marshall(getCloudFrontOriginAccessIdentityConfigRequest);
            var unmarshaller = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Get the configuration information about an origin access identity. </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException"/>
        /// <exception cref="AccessDeniedException"/>
        public GetCloudFrontOriginAccessIdentityConfigResponse GetCloudFrontOriginAccessIdentityConfig()
        {
            return GetCloudFrontOriginAccessIdentityConfig(new GetCloudFrontOriginAccessIdentityConfigRequest());
        }
        

        #endregion
    
        #region ListInvalidations

        /// <summary>
        /// <para> List invalidation batches. </para>
        /// </summary>
        /// 
        /// <param name="listInvalidationsRequest">Container for the necessary parameters to execute the ListInvalidations service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListInvalidations service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="AccessDeniedException"/>
        public ListInvalidationsResponse ListInvalidations(ListInvalidationsRequest listInvalidationsRequest)
        {
            IAsyncResult asyncResult = invokeListInvalidations(listInvalidationsRequest, null, null, true);
            return EndListInvalidations(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvalidations operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListInvalidations"/>
        /// </summary>
        /// 
        /// <param name="listInvalidationsRequest">Container for the necessary parameters to execute the ListInvalidations operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvalidations
        ///         operation.</returns>
        public IAsyncResult BeginListInvalidations(ListInvalidationsRequest listInvalidationsRequest, AsyncCallback callback, object state)
        {
            return invokeListInvalidations(listInvalidationsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListInvalidations operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListInvalidations"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvalidations.</param>
        /// 
        /// <returns>Returns a ListInvalidationsResult from AmazonCloudFront.</returns>
        public ListInvalidationsResponse EndListInvalidations(IAsyncResult asyncResult)
        {
            return endOperation<ListInvalidationsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListInvalidations(ListInvalidationsRequest listInvalidationsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListInvalidationsRequestMarshaller().Marshall(listInvalidationsRequest);
            var unmarshaller = ListInvalidationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListDistributions

        /// <summary>
        /// <para> List distributions. </para>
        /// </summary>
        /// 
        /// <param name="listDistributionsRequest">Container for the necessary parameters to execute the ListDistributions service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidArgumentException"/>
        public ListDistributionsResponse ListDistributions(ListDistributionsRequest listDistributionsRequest)
        {
            IAsyncResult asyncResult = invokeListDistributions(listDistributionsRequest, null, null, true);
            return EndListDistributions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributions operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListDistributions"/>
        /// </summary>
        /// 
        /// <param name="listDistributionsRequest">Container for the necessary parameters to execute the ListDistributions operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributions
        ///         operation.</returns>
        public IAsyncResult BeginListDistributions(ListDistributionsRequest listDistributionsRequest, AsyncCallback callback, object state)
        {
            return invokeListDistributions(listDistributionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListDistributions operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListDistributions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributions.</param>
        /// 
        /// <returns>Returns a ListDistributionsResult from AmazonCloudFront.</returns>
        public ListDistributionsResponse EndListDistributions(IAsyncResult asyncResult)
        {
            return endOperation<ListDistributionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListDistributions(ListDistributionsRequest listDistributionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListDistributionsRequestMarshaller().Marshall(listDistributionsRequest);
            var unmarshaller = ListDistributionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> List distributions. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidArgumentException"/>
        public ListDistributionsResponse ListDistributions()
        {
            return ListDistributions(new ListDistributionsRequest());
        }
        

        #endregion
    
        #region GetStreamingDistributionConfig

        /// <summary>
        /// <para> Get the configuration information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="getStreamingDistributionConfigRequest">Container for the necessary parameters to execute the GetStreamingDistributionConfig
        ///          service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchStreamingDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        public GetStreamingDistributionConfigResponse GetStreamingDistributionConfig(GetStreamingDistributionConfigRequest getStreamingDistributionConfigRequest)
        {
            IAsyncResult asyncResult = invokeGetStreamingDistributionConfig(getStreamingDistributionConfigRequest, null, null, true);
            return EndGetStreamingDistributionConfig(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetStreamingDistributionConfig"/>
        /// </summary>
        /// 
        /// <param name="getStreamingDistributionConfigRequest">Container for the necessary parameters to execute the GetStreamingDistributionConfig
        ///          operation on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetStreamingDistributionConfig operation.</returns>
        public IAsyncResult BeginGetStreamingDistributionConfig(GetStreamingDistributionConfigRequest getStreamingDistributionConfigRequest, AsyncCallback callback, object state)
        {
            return invokeGetStreamingDistributionConfig(getStreamingDistributionConfigRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetStreamingDistributionConfig operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetStreamingDistributionConfig"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingDistributionConfig.</param>
        /// 
        /// <returns>Returns a GetStreamingDistributionConfigResult from AmazonCloudFront.</returns>
        public GetStreamingDistributionConfigResponse EndGetStreamingDistributionConfig(IAsyncResult asyncResult)
        {
            return endOperation<GetStreamingDistributionConfigResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetStreamingDistributionConfig(GetStreamingDistributionConfigRequest getStreamingDistributionConfigRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetStreamingDistributionConfigRequestMarshaller().Marshall(getStreamingDistributionConfigRequest);
            var unmarshaller = GetStreamingDistributionConfigResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Get the configuration information about a streaming distribution. </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchStreamingDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        public GetStreamingDistributionConfigResponse GetStreamingDistributionConfig()
        {
            return GetStreamingDistributionConfig(new GetStreamingDistributionConfigRequest());
        }
        

        #endregion
    
        #region GetDistribution

        /// <summary>
        /// <para> Get the information about a distribution. </para>
        /// </summary>
        /// 
        /// <param name="getDistributionRequest">Container for the necessary parameters to execute the GetDistribution service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        public GetDistributionResponse GetDistribution(GetDistributionRequest getDistributionRequest)
        {
            IAsyncResult asyncResult = invokeGetDistribution(getDistributionRequest, null, null, true);
            return EndGetDistribution(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetDistribution"/>
        /// </summary>
        /// 
        /// <param name="getDistributionRequest">Container for the necessary parameters to execute the GetDistribution operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDistribution
        ///         operation.</returns>
        public IAsyncResult BeginGetDistribution(GetDistributionRequest getDistributionRequest, AsyncCallback callback, object state)
        {
            return invokeGetDistribution(getDistributionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistribution.</param>
        /// 
        /// <returns>Returns a GetDistributionResult from AmazonCloudFront.</returns>
        public GetDistributionResponse EndGetDistribution(IAsyncResult asyncResult)
        {
            return endOperation<GetDistributionResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetDistribution(GetDistributionRequest getDistributionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetDistributionRequestMarshaller().Marshall(getDistributionRequest);
            var unmarshaller = GetDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Get the information about a distribution. </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        public GetDistributionResponse GetDistribution()
        {
            return GetDistribution(new GetDistributionRequest());
        }
        

        #endregion
    
        #region DeleteStreamingDistribution

        /// <summary>
        /// <para> Delete a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="deleteStreamingDistributionRequest">Container for the necessary parameters to execute the DeleteStreamingDistribution service
        ///          method on AmazonCloudFront.</param>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="NoSuchStreamingDistributionException"/>
        /// <exception cref="StreamingDistributionNotDisabledException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="AccessDeniedException"/>
        public DeleteStreamingDistributionResponse DeleteStreamingDistribution(DeleteStreamingDistributionRequest deleteStreamingDistributionRequest)
        {
            IAsyncResult asyncResult = invokeDeleteStreamingDistribution(deleteStreamingDistributionRequest, null, null, true);
            return EndDeleteStreamingDistribution(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.DeleteStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="deleteStreamingDistributionRequest">Container for the necessary parameters to execute the DeleteStreamingDistribution operation
        ///          on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteStreamingDistribution(DeleteStreamingDistributionRequest deleteStreamingDistributionRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteStreamingDistribution(deleteStreamingDistributionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.DeleteStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStreamingDistribution.</param>
        public DeleteStreamingDistributionResponse EndDeleteStreamingDistribution(IAsyncResult asyncResult)
        {
            return endOperation<DeleteStreamingDistributionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteStreamingDistribution(DeleteStreamingDistributionRequest deleteStreamingDistributionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteStreamingDistributionRequestMarshaller().Marshall(deleteStreamingDistributionRequest);
            var unmarshaller = DeleteStreamingDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Delete a streaming distribution. </para>
        /// </summary>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="NoSuchStreamingDistributionException"/>
        /// <exception cref="StreamingDistributionNotDisabledException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="AccessDeniedException"/>
        public DeleteStreamingDistributionResponse DeleteStreamingDistribution()
        {
            return DeleteStreamingDistribution(new DeleteStreamingDistributionRequest());
        }
        

        #endregion
    
        #region CreateCloudFrontOriginAccessIdentity

        /// <summary>
        /// <para> Create a new origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="createCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          CreateCloudFrontOriginAccessIdentity service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the CreateCloudFrontOriginAccessIdentity service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="TooManyCloudFrontOriginAccessIdentitiesException"/>
        /// <exception cref="MissingBodyException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="InconsistentQuantitiesException"/>
        /// <exception cref="CloudFrontOriginAccessIdentityAlreadyExistsException"/>
        public CreateCloudFrontOriginAccessIdentityResponse CreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest createCloudFrontOriginAccessIdentityRequest)
        {
            IAsyncResult asyncResult = invokeCreateCloudFrontOriginAccessIdentity(createCloudFrontOriginAccessIdentityRequest, null, null, true);
            return EndCreateCloudFrontOriginAccessIdentity(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="createCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          CreateCloudFrontOriginAccessIdentity operation on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateCloudFrontOriginAccessIdentity operation.</returns>
        public IAsyncResult BeginCreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest createCloudFrontOriginAccessIdentityRequest, AsyncCallback callback, object state)
        {
            return invokeCreateCloudFrontOriginAccessIdentity(createCloudFrontOriginAccessIdentityRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a CreateCloudFrontOriginAccessIdentityResult from AmazonCloudFront.</returns>
        public CreateCloudFrontOriginAccessIdentityResponse EndCreateCloudFrontOriginAccessIdentity(IAsyncResult asyncResult)
        {
            return endOperation<CreateCloudFrontOriginAccessIdentityResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateCloudFrontOriginAccessIdentity(CreateCloudFrontOriginAccessIdentityRequest createCloudFrontOriginAccessIdentityRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateCloudFrontOriginAccessIdentityRequestMarshaller().Marshall(createCloudFrontOriginAccessIdentityRequest);
            var unmarshaller = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListStreamingDistributions

        /// <summary>
        /// <para> List streaming distributions. </para>
        /// </summary>
        /// 
        /// <param name="listStreamingDistributionsRequest">Container for the necessary parameters to execute the ListStreamingDistributions service
        ///          method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidArgumentException"/>
        public ListStreamingDistributionsResponse ListStreamingDistributions(ListStreamingDistributionsRequest listStreamingDistributionsRequest)
        {
            IAsyncResult asyncResult = invokeListStreamingDistributions(listStreamingDistributionsRequest, null, null, true);
            return EndListStreamingDistributions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamingDistributions operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListStreamingDistributions"/>
        /// </summary>
        /// 
        /// <param name="listStreamingDistributionsRequest">Container for the necessary parameters to execute the ListStreamingDistributions operation
        ///          on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListStreamingDistributions operation.</returns>
        public IAsyncResult BeginListStreamingDistributions(ListStreamingDistributionsRequest listStreamingDistributionsRequest, AsyncCallback callback, object state)
        {
            return invokeListStreamingDistributions(listStreamingDistributionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListStreamingDistributions operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.ListStreamingDistributions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreamingDistributions.</param>
        /// 
        /// <returns>Returns a ListStreamingDistributionsResult from AmazonCloudFront.</returns>
        public ListStreamingDistributionsResponse EndListStreamingDistributions(IAsyncResult asyncResult)
        {
            return endOperation<ListStreamingDistributionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListStreamingDistributions(ListStreamingDistributionsRequest listStreamingDistributionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListStreamingDistributionsRequestMarshaller().Marshall(listStreamingDistributionsRequest);
            var unmarshaller = ListStreamingDistributionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> List streaming distributions. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidArgumentException"/>
        public ListStreamingDistributionsResponse ListStreamingDistributions()
        {
            return ListStreamingDistributions(new ListStreamingDistributionsRequest());
        }
        

        #endregion
    
        #region DeleteCloudFrontOriginAccessIdentity

        /// <summary>
        /// <para> Delete an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="deleteCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          DeleteCloudFrontOriginAccessIdentity service method on AmazonCloudFront.</param>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="CloudFrontOriginAccessIdentityInUseException"/>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="AccessDeniedException"/>
        public DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest deleteCloudFrontOriginAccessIdentityRequest)
        {
            IAsyncResult asyncResult = invokeDeleteCloudFrontOriginAccessIdentity(deleteCloudFrontOriginAccessIdentityRequest, null, null, true);
            return EndDeleteCloudFrontOriginAccessIdentity(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.DeleteCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="deleteCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          DeleteCloudFrontOriginAccessIdentity operation on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest deleteCloudFrontOriginAccessIdentityRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteCloudFrontOriginAccessIdentity(deleteCloudFrontOriginAccessIdentityRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.DeleteCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudFrontOriginAccessIdentity.</param>
        public DeleteCloudFrontOriginAccessIdentityResponse EndDeleteCloudFrontOriginAccessIdentity(IAsyncResult asyncResult)
        {
            return endOperation<DeleteCloudFrontOriginAccessIdentityResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteCloudFrontOriginAccessIdentity(DeleteCloudFrontOriginAccessIdentityRequest deleteCloudFrontOriginAccessIdentityRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteCloudFrontOriginAccessIdentityRequestMarshaller().Marshall(deleteCloudFrontOriginAccessIdentityRequest);
            var unmarshaller = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Delete an origin access identity. </para>
        /// </summary>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="CloudFrontOriginAccessIdentityInUseException"/>
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="AccessDeniedException"/>
        public DeleteCloudFrontOriginAccessIdentityResponse DeleteCloudFrontOriginAccessIdentity()
        {
            return DeleteCloudFrontOriginAccessIdentity(new DeleteCloudFrontOriginAccessIdentityRequest());
        }
        

        #endregion
    
        #region UpdateStreamingDistribution

        /// <summary>
        /// <para> Update a streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="updateStreamingDistributionRequest">Container for the necessary parameters to execute the UpdateStreamingDistribution service
        ///          method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the UpdateStreamingDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="InvalidIfMatchVersionException"/>
        /// <exception cref="IllegalUpdateException"/>
        /// <exception cref="MissingBodyException"/>
        /// <exception cref="PreconditionFailedException"/>
        /// <exception cref="CNAMEAlreadyExistsException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="InconsistentQuantitiesException"/>
        /// <exception cref="InvalidOriginAccessIdentityException"/>
        /// <exception cref="TrustedSignerDoesNotExistException"/>
        /// <exception cref="TooManyTrustedSignersException"/>
        /// <exception cref="NoSuchStreamingDistributionException"/>
        /// <exception cref="TooManyStreamingDistributionCNAMEsException"/>
        /// <exception cref="AccessDeniedException"/>
        public UpdateStreamingDistributionResponse UpdateStreamingDistribution(UpdateStreamingDistributionRequest updateStreamingDistributionRequest)
        {
            IAsyncResult asyncResult = invokeUpdateStreamingDistribution(updateStreamingDistributionRequest, null, null, true);
            return EndUpdateStreamingDistribution(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.UpdateStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="updateStreamingDistributionRequest">Container for the necessary parameters to execute the UpdateStreamingDistribution operation
        ///          on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateStreamingDistribution operation.</returns>
        public IAsyncResult BeginUpdateStreamingDistribution(UpdateStreamingDistributionRequest updateStreamingDistributionRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateStreamingDistribution(updateStreamingDistributionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.UpdateStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStreamingDistribution.</param>
        /// 
        /// <returns>Returns a UpdateStreamingDistributionResult from AmazonCloudFront.</returns>
        public UpdateStreamingDistributionResponse EndUpdateStreamingDistribution(IAsyncResult asyncResult)
        {
            return endOperation<UpdateStreamingDistributionResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateStreamingDistribution(UpdateStreamingDistributionRequest updateStreamingDistributionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateStreamingDistributionRequestMarshaller().Marshall(updateStreamingDistributionRequest);
            var unmarshaller = UpdateStreamingDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetInvalidation

        /// <summary>
        /// <para> Get the information about an invalidation. </para>
        /// </summary>
        /// 
        /// <param name="getInvalidationRequest">Container for the necessary parameters to execute the GetInvalidation service method on
        ///          AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetInvalidation service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchInvalidationException"/>
        /// <exception cref="NoSuchDistributionException"/>
        /// <exception cref="AccessDeniedException"/>
        public GetInvalidationResponse GetInvalidation(GetInvalidationRequest getInvalidationRequest)
        {
            IAsyncResult asyncResult = invokeGetInvalidation(getInvalidationRequest, null, null, true);
            return EndGetInvalidation(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetInvalidation"/>
        /// </summary>
        /// 
        /// <param name="getInvalidationRequest">Container for the necessary parameters to execute the GetInvalidation operation on
        ///          AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvalidation
        ///         operation.</returns>
        public IAsyncResult BeginGetInvalidation(GetInvalidationRequest getInvalidationRequest, AsyncCallback callback, object state)
        {
            return invokeGetInvalidation(getInvalidationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetInvalidation operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetInvalidation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvalidation.</param>
        /// 
        /// <returns>Returns a GetInvalidationResult from AmazonCloudFront.</returns>
        public GetInvalidationResponse EndGetInvalidation(IAsyncResult asyncResult)
        {
            return endOperation<GetInvalidationResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetInvalidation(GetInvalidationRequest getInvalidationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetInvalidationRequestMarshaller().Marshall(getInvalidationRequest);
            var unmarshaller = GetInvalidationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateStreamingDistribution

        /// <summary>
        /// <para> Create a new streaming distribution. </para>
        /// </summary>
        /// 
        /// <param name="createStreamingDistributionRequest">Container for the necessary parameters to execute the CreateStreamingDistribution service
        ///          method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the CreateStreamingDistribution service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="TooManyTrustedSignersException"/>
        /// <exception cref="MissingBodyException"/>
        /// <exception cref="TooManyStreamingDistributionCNAMEsException"/>
        /// <exception cref="StreamingDistributionAlreadyExistsException"/>
        /// <exception cref="CNAMEAlreadyExistsException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="TooManyStreamingDistributionsException"/>
        /// <exception cref="InvalidArgumentException"/>
        /// <exception cref="InconsistentQuantitiesException"/>
        /// <exception cref="InvalidOriginAccessIdentityException"/>
        /// <exception cref="TrustedSignerDoesNotExistException"/>
        /// <exception cref="InvalidOriginException"/>
        public CreateStreamingDistributionResponse CreateStreamingDistribution(CreateStreamingDistributionRequest createStreamingDistributionRequest)
        {
            IAsyncResult asyncResult = invokeCreateStreamingDistribution(createStreamingDistributionRequest, null, null, true);
            return EndCreateStreamingDistribution(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="createStreamingDistributionRequest">Container for the necessary parameters to execute the CreateStreamingDistribution operation
        ///          on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateStreamingDistribution operation.</returns>
        public IAsyncResult BeginCreateStreamingDistribution(CreateStreamingDistributionRequest createStreamingDistributionRequest, AsyncCallback callback, object state)
        {
            return invokeCreateStreamingDistribution(createStreamingDistributionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateStreamingDistribution operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateStreamingDistribution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamingDistribution.</param>
        /// 
        /// <returns>Returns a CreateStreamingDistributionResult from AmazonCloudFront.</returns>
        public CreateStreamingDistributionResponse EndCreateStreamingDistribution(IAsyncResult asyncResult)
        {
            return endOperation<CreateStreamingDistributionResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateStreamingDistribution(CreateStreamingDistributionRequest createStreamingDistributionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateStreamingDistributionRequestMarshaller().Marshall(createStreamingDistributionRequest);
            var unmarshaller = CreateStreamingDistributionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetCloudFrontOriginAccessIdentity

        /// <summary>
        /// <para> Get the information about an origin access identity. </para>
        /// </summary>
        /// 
        /// <param name="getCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          GetCloudFrontOriginAccessIdentity service method on AmazonCloudFront.</param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException"/>
        /// <exception cref="AccessDeniedException"/>
        public GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest getCloudFrontOriginAccessIdentityRequest)
        {
            IAsyncResult asyncResult = invokeGetCloudFrontOriginAccessIdentity(getCloudFrontOriginAccessIdentityRequest, null, null, true);
            return EndGetCloudFrontOriginAccessIdentity(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="getCloudFrontOriginAccessIdentityRequest">Container for the necessary parameters to execute the
        ///          GetCloudFrontOriginAccessIdentity operation on AmazonCloudFront.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetCloudFrontOriginAccessIdentity operation.</returns>
        public IAsyncResult BeginGetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest getCloudFrontOriginAccessIdentityRequest, AsyncCallback callback, object state)
        {
            return invokeGetCloudFrontOriginAccessIdentity(getCloudFrontOriginAccessIdentityRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetCloudFrontOriginAccessIdentity operation.
        /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetCloudFrontOriginAccessIdentity"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudFrontOriginAccessIdentity.</param>
        /// 
        /// <returns>Returns a GetCloudFrontOriginAccessIdentityResult from AmazonCloudFront.</returns>
        public GetCloudFrontOriginAccessIdentityResponse EndGetCloudFrontOriginAccessIdentity(IAsyncResult asyncResult)
        {
            return endOperation<GetCloudFrontOriginAccessIdentityResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetCloudFrontOriginAccessIdentity(GetCloudFrontOriginAccessIdentityRequest getCloudFrontOriginAccessIdentityRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetCloudFrontOriginAccessIdentityRequestMarshaller().Marshall(getCloudFrontOriginAccessIdentityRequest);
            var unmarshaller = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Get the information about an origin access identity. </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by AmazonCloudFront.</returns>
        /// 
        /// <exception cref="NoSuchCloudFrontOriginAccessIdentityException"/>
        /// <exception cref="AccessDeniedException"/>
        public GetCloudFrontOriginAccessIdentityResponse GetCloudFrontOriginAccessIdentity()
        {
            return GetCloudFrontOriginAccessIdentity(new GetCloudFrontOriginAccessIdentityRequest());
        }
        

        #endregion
    
    }
}
    
