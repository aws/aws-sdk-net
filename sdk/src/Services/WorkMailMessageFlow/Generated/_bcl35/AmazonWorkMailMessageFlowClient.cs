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
 * Do not modify this file. This file is generated from the workmailmessageflow-2019-05-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.WorkMailMessageFlow.Model;
using Amazon.WorkMailMessageFlow.Model.Internal.MarshallTransformations;
using Amazon.WorkMailMessageFlow.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.WorkMailMessageFlow
{
    /// <summary>
    /// Implementation for accessing WorkMailMessageFlow
    ///
    /// The WorkMail Message Flow API provides access to email messages as they are being
    /// sent and received by a WorkMail organization.
    /// </summary>
    public partial class AmazonWorkMailMessageFlowClient : AmazonServiceClient, IAmazonWorkMailMessageFlow
    {
        private static IServiceMetadata serviceMetadata = new AmazonWorkMailMessageFlowMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with the credentials loaded from the application's
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
        public AmazonWorkMailMessageFlowClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkMailMessageFlowConfig()) { }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with the credentials loaded from the application's
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
        public AmazonWorkMailMessageFlowClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkMailMessageFlowConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWorkMailMessageFlowClient Configuration Object</param>
        public AmazonWorkMailMessageFlowClient(AmazonWorkMailMessageFlowConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWorkMailMessageFlowClient(AWSCredentials credentials)
            : this(credentials, new AmazonWorkMailMessageFlowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkMailMessageFlowClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWorkMailMessageFlowConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Credentials and an
        /// AmazonWorkMailMessageFlowClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWorkMailMessageFlowClient Configuration Object</param>
        public AmazonWorkMailMessageFlowClient(AWSCredentials credentials, AmazonWorkMailMessageFlowConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWorkMailMessageFlowClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkMailMessageFlowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkMailMessageFlowClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkMailMessageFlowConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkMailMessageFlowClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWorkMailMessageFlowClient Configuration Object</param>
        public AmazonWorkMailMessageFlowClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWorkMailMessageFlowConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWorkMailMessageFlowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkMailMessageFlowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkMailMessageFlowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkMailMessageFlowConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkMailMessageFlowClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkMailMessageFlowClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWorkMailMessageFlowClient Configuration Object</param>
        public AmazonWorkMailMessageFlowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWorkMailMessageFlowConfig clientConfig)
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


        #region  GetRawMessageContent

        /// <summary>
        /// Retrieves the raw content of an in-transit email message, in MIME format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRawMessageContent service method.</param>
        /// 
        /// <returns>The response from the GetRawMessageContent service method, as returned by WorkMailMessageFlow.</returns>
        /// <exception cref="Amazon.WorkMailMessageFlow.Model.ResourceNotFoundException">
        /// The requested email message is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmailmessageflow-2019-05-01/GetRawMessageContent">REST API Reference for GetRawMessageContent Operation</seealso>
        public virtual GetRawMessageContentResponse GetRawMessageContent(GetRawMessageContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRawMessageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRawMessageContentResponseUnmarshaller.Instance;

            return Invoke<GetRawMessageContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRawMessageContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRawMessageContent operation on AmazonWorkMailMessageFlowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRawMessageContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmailmessageflow-2019-05-01/GetRawMessageContent">REST API Reference for GetRawMessageContent Operation</seealso>
        public virtual IAsyncResult BeginGetRawMessageContent(GetRawMessageContentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRawMessageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRawMessageContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRawMessageContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRawMessageContent.</param>
        /// 
        /// <returns>Returns a  GetRawMessageContentResult from WorkMailMessageFlow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmailmessageflow-2019-05-01/GetRawMessageContent">REST API Reference for GetRawMessageContent Operation</seealso>
        public virtual GetRawMessageContentResponse EndGetRawMessageContent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRawMessageContentResponse>(asyncResult);
        }

        #endregion
        
    }
}