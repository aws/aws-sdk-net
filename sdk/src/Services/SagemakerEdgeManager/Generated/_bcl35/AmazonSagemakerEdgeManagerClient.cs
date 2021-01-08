/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sagemaker-edge-2020-09-23.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.SagemakerEdgeManager.Model;
using Amazon.SagemakerEdgeManager.Model.Internal.MarshallTransformations;
using Amazon.SagemakerEdgeManager.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SagemakerEdgeManager
{
    /// <summary>
    /// Implementation for accessing SagemakerEdgeManager
    ///
    /// SageMaker Edge Manager dataplane service for communicating with active agents.
    /// </summary>
    public partial class AmazonSagemakerEdgeManagerClient : AmazonServiceClient, IAmazonSagemakerEdgeManager
    {
        private static IServiceMetadata serviceMetadata = new AmazonSagemakerEdgeManagerMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonSagemakerEdgeManagerClient with the credentials loaded from the application's
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
        public AmazonSagemakerEdgeManagerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSagemakerEdgeManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonSagemakerEdgeManagerClient with the credentials loaded from the application's
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
        public AmazonSagemakerEdgeManagerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSagemakerEdgeManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSagemakerEdgeManagerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSagemakerEdgeManagerClient Configuration Object</param>
        public AmazonSagemakerEdgeManagerClient(AmazonSagemakerEdgeManagerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonSagemakerEdgeManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSagemakerEdgeManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonSagemakerEdgeManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerEdgeManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSagemakerEdgeManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSagemakerEdgeManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerEdgeManagerClient with AWS Credentials and an
        /// AmazonSagemakerEdgeManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSagemakerEdgeManagerClient Configuration Object</param>
        public AmazonSagemakerEdgeManagerClient(AWSCredentials credentials, AmazonSagemakerEdgeManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerEdgeManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSagemakerEdgeManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSagemakerEdgeManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerEdgeManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSagemakerEdgeManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSagemakerEdgeManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerEdgeManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSagemakerEdgeManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSagemakerEdgeManagerClient Configuration Object</param>
        public AmazonSagemakerEdgeManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSagemakerEdgeManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerEdgeManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSagemakerEdgeManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSagemakerEdgeManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerEdgeManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSagemakerEdgeManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSagemakerEdgeManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSagemakerEdgeManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSagemakerEdgeManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSagemakerEdgeManagerClient Configuration Object</param>
        public AmazonSagemakerEdgeManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSagemakerEdgeManagerConfig clientConfig)
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

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
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


        #region  GetDeviceRegistration

        /// <summary>
        /// Use to check if a device is registered with SageMaker Edge Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceRegistration service method.</param>
        /// 
        /// <returns>The response from the GetDeviceRegistration service method, as returned by SagemakerEdgeManager.</returns>
        /// <exception cref="Amazon.SagemakerEdgeManager.Model.InternalServiceException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// AWS customer support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/GetDeviceRegistration">REST API Reference for GetDeviceRegistration Operation</seealso>
        public virtual GetDeviceRegistrationResponse GetDeviceRegistration(GetDeviceRegistrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceRegistrationResponseUnmarshaller.Instance;

            return Invoke<GetDeviceRegistrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceRegistration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceRegistration operation on AmazonSagemakerEdgeManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeviceRegistration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/GetDeviceRegistration">REST API Reference for GetDeviceRegistration Operation</seealso>
        public virtual IAsyncResult BeginGetDeviceRegistration(GetDeviceRegistrationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceRegistrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeviceRegistration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeviceRegistration.</param>
        /// 
        /// <returns>Returns a  GetDeviceRegistrationResult from SagemakerEdgeManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/GetDeviceRegistration">REST API Reference for GetDeviceRegistration Operation</seealso>
        public virtual GetDeviceRegistrationResponse EndGetDeviceRegistration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeviceRegistrationResponse>(asyncResult);
        }

        #endregion
        
        #region  SendHeartbeat

        /// <summary>
        /// Use to get the current status of devices registered on SageMaker Edge Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendHeartbeat service method.</param>
        /// 
        /// <returns>The response from the SendHeartbeat service method, as returned by SagemakerEdgeManager.</returns>
        /// <exception cref="Amazon.SagemakerEdgeManager.Model.InternalServiceException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// AWS customer support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/SendHeartbeat">REST API Reference for SendHeartbeat Operation</seealso>
        public virtual SendHeartbeatResponse SendHeartbeat(SendHeartbeatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendHeartbeatResponseUnmarshaller.Instance;

            return Invoke<SendHeartbeatResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendHeartbeat operation on AmazonSagemakerEdgeManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendHeartbeat
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/SendHeartbeat">REST API Reference for SendHeartbeat Operation</seealso>
        public virtual IAsyncResult BeginSendHeartbeat(SendHeartbeatRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendHeartbeatResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendHeartbeat.</param>
        /// 
        /// <returns>Returns a  SendHeartbeatResult from SagemakerEdgeManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-edge-2020-09-23/SendHeartbeat">REST API Reference for SendHeartbeat Operation</seealso>
        public virtual SendHeartbeatResponse EndSendHeartbeat(IAsyncResult asyncResult)
        {
            return EndInvoke<SendHeartbeatResponse>(asyncResult);
        }

        #endregion
        
    }
}