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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.CloudHSM.Model;
using Amazon.CloudHSM.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudHSM
{
    /// <summary>
    /// Implementation for accessing CloudHSM
    ///
    /// AWS CloudHSM Service
    /// </summary>
    public partial class AmazonCloudHSMClient : AmazonServiceClient, IAmazonCloudHSM
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudHSMClient with the credentials loaded from the application's
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
        public AmazonCloudHSMClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudHSMConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with the credentials loaded from the application's
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
        public AmazonCloudHSMClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudHSMConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudHSMClient Configuration Object</param>
        public AmazonCloudHSMClient(AmazonCloudHSMConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudHSMClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudHSMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudHSMClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudHSMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Credentials and an
        /// AmazonCloudHSMClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudHSMClient Configuration Object</param>
        public AmazonCloudHSMClient(AWSCredentials credentials, AmazonCloudHSMConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudHSMClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudHSMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudHSMClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudHSMConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudHSMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudHSMClient Configuration Object</param>
        public AmazonCloudHSMClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudHSMConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudHSMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudHSMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudHSMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudHSMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudHSMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudHSMClient Configuration Object</param>
        public AmazonCloudHSMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudHSMConfig clientConfig)
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

        
        #region  CreateHapg

        /// <summary>
        /// Creates a high-availability partition group. A high-availability partition group is
        /// a group of partitions that spans multiple physical HSMs.
        /// </summary>
        /// <param name="label">The label of the new high-availability partition group.</param>
        /// 
        /// <returns>The response from the CreateHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public CreateHapgResponse CreateHapg(string label)
        {
            var request = new CreateHapgRequest();
            request.Label = label;
            return CreateHapg(request);
        }

        /// <summary>
        /// Creates a high-availability partition group. A high-availability partition group is
        /// a group of partitions that spans multiple physical HSMs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHapg service method.</param>
        /// 
        /// <returns>The response from the CreateHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public CreateHapgResponse CreateHapg(CreateHapgRequest request)
        {
            var marshaller = new CreateHapgRequestMarshaller();
            var unmarshaller = CreateHapgResponseUnmarshaller.Instance;

            return Invoke<CreateHapgRequest,CreateHapgResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHapg operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHapg
        ///         operation.</returns>
        public IAsyncResult BeginCreateHapg(CreateHapgRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateHapgRequestMarshaller();
            var unmarshaller = CreateHapgResponseUnmarshaller.Instance;

            return BeginInvoke<CreateHapgRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHapg operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHapg.</param>
        /// 
        /// <returns>Returns a  CreateHapgResult from CloudHSM.</returns>
        public  CreateHapgResponse EndCreateHapg(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateHapgResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateHsm

        /// <summary>
        /// Creates an uninitialized HSM instance. Running this command provisions an HSM appliance
        /// and will result in charges to your AWS account for the HSM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsm service method.</param>
        /// 
        /// <returns>The response from the CreateHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public CreateHsmResponse CreateHsm(CreateHsmRequest request)
        {
            var marshaller = new CreateHsmRequestMarshaller();
            var unmarshaller = CreateHsmResponseUnmarshaller.Instance;

            return Invoke<CreateHsmRequest,CreateHsmResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsm operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHsm
        ///         operation.</returns>
        public IAsyncResult BeginCreateHsm(CreateHsmRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateHsmRequestMarshaller();
            var unmarshaller = CreateHsmResponseUnmarshaller.Instance;

            return BeginInvoke<CreateHsmRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHsm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHsm.</param>
        /// 
        /// <returns>Returns a  CreateHsmResult from CloudHSM.</returns>
        public  CreateHsmResponse EndCreateHsm(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateHsmResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLunaClient

        /// <summary>
        /// Creates an HSM client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLunaClient service method.</param>
        /// 
        /// <returns>The response from the CreateLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public CreateLunaClientResponse CreateLunaClient(CreateLunaClientRequest request)
        {
            var marshaller = new CreateLunaClientRequestMarshaller();
            var unmarshaller = CreateLunaClientResponseUnmarshaller.Instance;

            return Invoke<CreateLunaClientRequest,CreateLunaClientResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLunaClient operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLunaClient
        ///         operation.</returns>
        public IAsyncResult BeginCreateLunaClient(CreateLunaClientRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateLunaClientRequestMarshaller();
            var unmarshaller = CreateLunaClientResponseUnmarshaller.Instance;

            return BeginInvoke<CreateLunaClientRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLunaClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLunaClient.</param>
        /// 
        /// <returns>Returns a  CreateLunaClientResult from CloudHSM.</returns>
        public  CreateLunaClientResponse EndCreateLunaClient(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLunaClientResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteHapg

        /// <summary>
        /// Deletes a high-availability partition group.
        /// </summary>
        /// <param name="hapgArn">The ARN of the high-availability partition group to delete.</param>
        /// 
        /// <returns>The response from the DeleteHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public DeleteHapgResponse DeleteHapg(string hapgArn)
        {
            var request = new DeleteHapgRequest();
            request.HapgArn = hapgArn;
            return DeleteHapg(request);
        }

        /// <summary>
        /// Deletes a high-availability partition group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHapg service method.</param>
        /// 
        /// <returns>The response from the DeleteHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public DeleteHapgResponse DeleteHapg(DeleteHapgRequest request)
        {
            var marshaller = new DeleteHapgRequestMarshaller();
            var unmarshaller = DeleteHapgResponseUnmarshaller.Instance;

            return Invoke<DeleteHapgRequest,DeleteHapgResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHapg operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHapg
        ///         operation.</returns>
        public IAsyncResult BeginDeleteHapg(DeleteHapgRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteHapgRequestMarshaller();
            var unmarshaller = DeleteHapgResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteHapgRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHapg operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHapg.</param>
        /// 
        /// <returns>Returns a  DeleteHapgResult from CloudHSM.</returns>
        public  DeleteHapgResponse EndDeleteHapg(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteHapgResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteHsm

        /// <summary>
        /// Deletes an HSM. Once complete, this operation cannot be undone and your key material
        /// cannot be recovered.
        /// </summary>
        /// <param name="hsmArn">The ARN of the HSM to delete.</param>
        /// 
        /// <returns>The response from the DeleteHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public DeleteHsmResponse DeleteHsm(string hsmArn)
        {
            var request = new DeleteHsmRequest();
            request.HsmArn = hsmArn;
            return DeleteHsm(request);
        }

        /// <summary>
        /// Deletes an HSM. Once complete, this operation cannot be undone and your key material
        /// cannot be recovered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsm service method.</param>
        /// 
        /// <returns>The response from the DeleteHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public DeleteHsmResponse DeleteHsm(DeleteHsmRequest request)
        {
            var marshaller = new DeleteHsmRequestMarshaller();
            var unmarshaller = DeleteHsmResponseUnmarshaller.Instance;

            return Invoke<DeleteHsmRequest,DeleteHsmResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsm operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHsm
        ///         operation.</returns>
        public IAsyncResult BeginDeleteHsm(DeleteHsmRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteHsmRequestMarshaller();
            var unmarshaller = DeleteHsmResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteHsmRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHsm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHsm.</param>
        /// 
        /// <returns>Returns a  DeleteHsmResult from CloudHSM.</returns>
        public  DeleteHsmResponse EndDeleteHsm(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteHsmResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLunaClient

        /// <summary>
        /// Deletes a client.
        /// </summary>
        /// <param name="clientArn">The ARN of the client to delete.</param>
        /// 
        /// <returns>The response from the DeleteLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public DeleteLunaClientResponse DeleteLunaClient(string clientArn)
        {
            var request = new DeleteLunaClientRequest();
            request.ClientArn = clientArn;
            return DeleteLunaClient(request);
        }

        /// <summary>
        /// Deletes a client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLunaClient service method.</param>
        /// 
        /// <returns>The response from the DeleteLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public DeleteLunaClientResponse DeleteLunaClient(DeleteLunaClientRequest request)
        {
            var marshaller = new DeleteLunaClientRequestMarshaller();
            var unmarshaller = DeleteLunaClientResponseUnmarshaller.Instance;

            return Invoke<DeleteLunaClientRequest,DeleteLunaClientResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLunaClient operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLunaClient
        ///         operation.</returns>
        public IAsyncResult BeginDeleteLunaClient(DeleteLunaClientRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteLunaClientRequestMarshaller();
            var unmarshaller = DeleteLunaClientResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteLunaClientRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLunaClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLunaClient.</param>
        /// 
        /// <returns>Returns a  DeleteLunaClientResult from CloudHSM.</returns>
        public  DeleteLunaClientResponse EndDeleteLunaClient(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLunaClientResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHapg

        /// <summary>
        /// Retrieves information about a high-availability partition group.
        /// </summary>
        /// <param name="hapgArn">The ARN of the high-availability partition group to describe.</param>
        /// 
        /// <returns>The response from the DescribeHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public DescribeHapgResponse DescribeHapg(string hapgArn)
        {
            var request = new DescribeHapgRequest();
            request.HapgArn = hapgArn;
            return DescribeHapg(request);
        }

        /// <summary>
        /// Retrieves information about a high-availability partition group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHapg service method.</param>
        /// 
        /// <returns>The response from the DescribeHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public DescribeHapgResponse DescribeHapg(DescribeHapgRequest request)
        {
            var marshaller = new DescribeHapgRequestMarshaller();
            var unmarshaller = DescribeHapgResponseUnmarshaller.Instance;

            return Invoke<DescribeHapgRequest,DescribeHapgResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHapg operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHapg
        ///         operation.</returns>
        public IAsyncResult BeginDescribeHapg(DescribeHapgRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeHapgRequestMarshaller();
            var unmarshaller = DescribeHapgResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeHapgRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHapg operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHapg.</param>
        /// 
        /// <returns>Returns a  DescribeHapgResult from CloudHSM.</returns>
        public  DescribeHapgResponse EndDescribeHapg(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHapgResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHsm

        /// <summary>
        /// Retrieves information about an HSM. You can identify the HSM by its ARN or its serial
        /// number.
        /// </summary>
        /// <param name="hsmArn">The ARN of the HSM. Either the <i>HsmArn</i> or the <i>SerialNumber</i> parameter must be specified.</param>
        /// 
        /// <returns>The response from the DescribeHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public DescribeHsmResponse DescribeHsm(string hsmArn)
        {
            var request = new DescribeHsmRequest();
            request.HsmArn = hsmArn;
            return DescribeHsm(request);
        }

        /// <summary>
        /// Retrieves information about an HSM. You can identify the HSM by its ARN or its serial
        /// number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsm service method.</param>
        /// 
        /// <returns>The response from the DescribeHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public DescribeHsmResponse DescribeHsm(DescribeHsmRequest request)
        {
            var marshaller = new DescribeHsmRequestMarshaller();
            var unmarshaller = DescribeHsmResponseUnmarshaller.Instance;

            return Invoke<DescribeHsmRequest,DescribeHsmResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsm operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHsm
        ///         operation.</returns>
        public IAsyncResult BeginDescribeHsm(DescribeHsmRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeHsmRequestMarshaller();
            var unmarshaller = DescribeHsmResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeHsmRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHsm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHsm.</param>
        /// 
        /// <returns>Returns a  DescribeHsmResult from CloudHSM.</returns>
        public  DescribeHsmResponse EndDescribeHsm(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHsmResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLunaClient

        /// <summary>
        /// Retrieves information about an HSM client.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLunaClient service method.</param>
        /// 
        /// <returns>The response from the DescribeLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public DescribeLunaClientResponse DescribeLunaClient(DescribeLunaClientRequest request)
        {
            var marshaller = new DescribeLunaClientRequestMarshaller();
            var unmarshaller = DescribeLunaClientResponseUnmarshaller.Instance;

            return Invoke<DescribeLunaClientRequest,DescribeLunaClientResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLunaClient operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLunaClient
        ///         operation.</returns>
        public IAsyncResult BeginDescribeLunaClient(DescribeLunaClientRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeLunaClientRequestMarshaller();
            var unmarshaller = DescribeLunaClientResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeLunaClientRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLunaClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLunaClient.</param>
        /// 
        /// <returns>Returns a  DescribeLunaClientResult from CloudHSM.</returns>
        public  DescribeLunaClientResponse EndDescribeLunaClient(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLunaClientResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfig

        /// <summary>
        /// Gets the configuration files necessary to connect to all high availability partition
        /// groups the client is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfig service method.</param>
        /// 
        /// <returns>The response from the GetConfig service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public GetConfigResponse GetConfig(GetConfigRequest request)
        {
            var marshaller = new GetConfigRequestMarshaller();
            var unmarshaller = GetConfigResponseUnmarshaller.Instance;

            return Invoke<GetConfigRequest,GetConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfig operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfig
        ///         operation.</returns>
        public IAsyncResult BeginGetConfig(GetConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetConfigRequestMarshaller();
            var unmarshaller = GetConfigResponseUnmarshaller.Instance;

            return BeginInvoke<GetConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfig.</param>
        /// 
        /// <returns>Returns a  GetConfigResult from CloudHSM.</returns>
        public  GetConfigResponse EndGetConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAvailableZones

        /// <summary>
        /// Lists the Availability Zones that have available AWS CloudHSM capacity.
        /// </summary>
        /// 
        /// <returns>The response from the ListAvailableZones service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public ListAvailableZonesResponse ListAvailableZones()
        {
            var request = new ListAvailableZonesRequest();
            return ListAvailableZones(request);
        }

        /// <summary>
        /// Lists the Availability Zones that have available AWS CloudHSM capacity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableZones service method.</param>
        /// 
        /// <returns>The response from the ListAvailableZones service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public ListAvailableZonesResponse ListAvailableZones(ListAvailableZonesRequest request)
        {
            var marshaller = new ListAvailableZonesRequestMarshaller();
            var unmarshaller = ListAvailableZonesResponseUnmarshaller.Instance;

            return Invoke<ListAvailableZonesRequest,ListAvailableZonesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableZones operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableZones
        ///         operation.</returns>
        public IAsyncResult BeginListAvailableZones(ListAvailableZonesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAvailableZonesRequestMarshaller();
            var unmarshaller = ListAvailableZonesResponseUnmarshaller.Instance;

            return BeginInvoke<ListAvailableZonesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableZones operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableZones.</param>
        /// 
        /// <returns>Returns a  ListAvailableZonesResult from CloudHSM.</returns>
        public  ListAvailableZonesResponse EndListAvailableZones(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAvailableZonesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListHapgs

        /// <summary>
        /// Lists the high-availability partition groups for the account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> member. If
        /// more results are available, the <i>NextToken</i> member of the response contains a
        /// token that you pass in the next call to <a>ListHapgs</a> to retrieve the next set
        /// of items.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListHapgs service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public ListHapgsResponse ListHapgs()
        {
            var request = new ListHapgsRequest();
            return ListHapgs(request);
        }

        /// <summary>
        /// Lists the high-availability partition groups for the account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> member. If
        /// more results are available, the <i>NextToken</i> member of the response contains a
        /// token that you pass in the next call to <a>ListHapgs</a> to retrieve the next set
        /// of items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHapgs service method.</param>
        /// 
        /// <returns>The response from the ListHapgs service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public ListHapgsResponse ListHapgs(ListHapgsRequest request)
        {
            var marshaller = new ListHapgsRequestMarshaller();
            var unmarshaller = ListHapgsResponseUnmarshaller.Instance;

            return Invoke<ListHapgsRequest,ListHapgsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHapgs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHapgs operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHapgs
        ///         operation.</returns>
        public IAsyncResult BeginListHapgs(ListHapgsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListHapgsRequestMarshaller();
            var unmarshaller = ListHapgsResponseUnmarshaller.Instance;

            return BeginInvoke<ListHapgsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListHapgs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHapgs.</param>
        /// 
        /// <returns>Returns a  ListHapgsResult from CloudHSM.</returns>
        public  ListHapgsResponse EndListHapgs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListHapgsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListHsms

        /// <summary>
        /// Retrieves the identifiers of all of the HSMs provisioned for the current customer.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> member. If
        /// more results are available, the <i>NextToken</i> member of the response contains a
        /// token that you pass in the next call to <a>ListHsms</a> to retrieve the next set of
        /// items.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListHsms service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public ListHsmsResponse ListHsms()
        {
            var request = new ListHsmsRequest();
            return ListHsms(request);
        }

        /// <summary>
        /// Retrieves the identifiers of all of the HSMs provisioned for the current customer.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> member. If
        /// more results are available, the <i>NextToken</i> member of the response contains a
        /// token that you pass in the next call to <a>ListHsms</a> to retrieve the next set of
        /// items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHsms service method.</param>
        /// 
        /// <returns>The response from the ListHsms service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public ListHsmsResponse ListHsms(ListHsmsRequest request)
        {
            var marshaller = new ListHsmsRequestMarshaller();
            var unmarshaller = ListHsmsResponseUnmarshaller.Instance;

            return Invoke<ListHsmsRequest,ListHsmsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHsms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHsms operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHsms
        ///         operation.</returns>
        public IAsyncResult BeginListHsms(ListHsmsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListHsmsRequestMarshaller();
            var unmarshaller = ListHsmsResponseUnmarshaller.Instance;

            return BeginInvoke<ListHsmsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListHsms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHsms.</param>
        /// 
        /// <returns>Returns a  ListHsmsResult from CloudHSM.</returns>
        public  ListHsmsResponse EndListHsms(IAsyncResult asyncResult)
        {
            return EndInvoke<ListHsmsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLunaClients

        /// <summary>
        /// Lists all of the clients.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> member. If
        /// more results are available, the <i>NextToken</i> member of the response contains a
        /// token that you pass in the next call to <a>ListLunaClients</a> to retrieve the next
        /// set of items.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListLunaClients service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public ListLunaClientsResponse ListLunaClients()
        {
            var request = new ListLunaClientsRequest();
            return ListLunaClients(request);
        }

        /// <summary>
        /// Lists all of the clients.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> member. If
        /// more results are available, the <i>NextToken</i> member of the response contains a
        /// token that you pass in the next call to <a>ListLunaClients</a> to retrieve the next
        /// set of items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLunaClients service method.</param>
        /// 
        /// <returns>The response from the ListLunaClients service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public ListLunaClientsResponse ListLunaClients(ListLunaClientsRequest request)
        {
            var marshaller = new ListLunaClientsRequestMarshaller();
            var unmarshaller = ListLunaClientsResponseUnmarshaller.Instance;

            return Invoke<ListLunaClientsRequest,ListLunaClientsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLunaClients operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLunaClients operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLunaClients
        ///         operation.</returns>
        public IAsyncResult BeginListLunaClients(ListLunaClientsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListLunaClientsRequestMarshaller();
            var unmarshaller = ListLunaClientsResponseUnmarshaller.Instance;

            return BeginInvoke<ListLunaClientsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLunaClients operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLunaClients.</param>
        /// 
        /// <returns>Returns a  ListLunaClientsResult from CloudHSM.</returns>
        public  ListLunaClientsResponse EndListLunaClients(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLunaClientsResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyHapg

        /// <summary>
        /// Modifies an existing high-availability partition group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyHapg service method.</param>
        /// 
        /// <returns>The response from the ModifyHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public ModifyHapgResponse ModifyHapg(ModifyHapgRequest request)
        {
            var marshaller = new ModifyHapgRequestMarshaller();
            var unmarshaller = ModifyHapgResponseUnmarshaller.Instance;

            return Invoke<ModifyHapgRequest,ModifyHapgResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyHapg operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyHapg
        ///         operation.</returns>
        public IAsyncResult BeginModifyHapg(ModifyHapgRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyHapgRequestMarshaller();
            var unmarshaller = ModifyHapgResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyHapgRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyHapg operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyHapg.</param>
        /// 
        /// <returns>Returns a  ModifyHapgResult from CloudHSM.</returns>
        public  ModifyHapgResponse EndModifyHapg(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyHapgResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyHsm

        /// <summary>
        /// Modifies an HSM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyHsm service method.</param>
        /// 
        /// <returns>The response from the ModifyHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        public ModifyHsmResponse ModifyHsm(ModifyHsmRequest request)
        {
            var marshaller = new ModifyHsmRequestMarshaller();
            var unmarshaller = ModifyHsmResponseUnmarshaller.Instance;

            return Invoke<ModifyHsmRequest,ModifyHsmResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyHsm operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyHsm
        ///         operation.</returns>
        public IAsyncResult BeginModifyHsm(ModifyHsmRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyHsmRequestMarshaller();
            var unmarshaller = ModifyHsmResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyHsmRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyHsm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyHsm.</param>
        /// 
        /// <returns>Returns a  ModifyHsmResult from CloudHSM.</returns>
        public  ModifyHsmResponse EndModifyHsm(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyHsmResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyLunaClient

        /// <summary>
        /// Modifies the certificate used by the client.
        /// 
        ///  
        /// <para>
        /// This action can potentially start a workflow to install the new certificate on the
        /// client's HSMs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLunaClient service method.</param>
        /// 
        /// <returns>The response from the ModifyLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        public ModifyLunaClientResponse ModifyLunaClient(ModifyLunaClientRequest request)
        {
            var marshaller = new ModifyLunaClientRequestMarshaller();
            var unmarshaller = ModifyLunaClientResponseUnmarshaller.Instance;

            return Invoke<ModifyLunaClientRequest,ModifyLunaClientResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLunaClient operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyLunaClient
        ///         operation.</returns>
        public IAsyncResult BeginModifyLunaClient(ModifyLunaClientRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyLunaClientRequestMarshaller();
            var unmarshaller = ModifyLunaClientResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyLunaClientRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyLunaClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyLunaClient.</param>
        /// 
        /// <returns>Returns a  ModifyLunaClientResult from CloudHSM.</returns>
        public  ModifyLunaClientResponse EndModifyLunaClient(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyLunaClientResponse>(asyncResult);
        }

        #endregion
        
    }
}