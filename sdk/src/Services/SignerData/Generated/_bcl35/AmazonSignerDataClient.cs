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
 * Do not modify this file. This file is generated from the signer-data-2017-08-25.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.SignerData.Model;
using Amazon.SignerData.Model.Internal.MarshallTransformations;
using Amazon.SignerData.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.SignerData
{
    /// <summary>
    /// <para>Implementation for accessing SignerData</para>
    ///
    /// AWS Signer Data Plane service provides APIs for checking revocation status of signed
    /// artifacts.
    /// </summary>
    public partial class AmazonSignerDataClient : AmazonServiceClient, IAmazonSignerData
    {
        private static IServiceMetadata serviceMetadata = new AmazonSignerDataMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonSignerDataClient with the credentials loaded from the application's
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
        public AmazonSignerDataClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSignerDataConfig()) { }

        /// <summary>
        /// Constructs AmazonSignerDataClient with the credentials loaded from the application's
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
        public AmazonSignerDataClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSignerDataConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSignerDataClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSignerDataClient Configuration Object</param>
        public AmazonSignerDataClient(AmazonSignerDataConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonSignerDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSignerDataClient(AWSCredentials credentials)
            : this(credentials, new AmazonSignerDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSignerDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSignerDataClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSignerDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSignerDataClient with AWS Credentials and an
        /// AmazonSignerDataClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSignerDataClient Configuration Object</param>
        public AmazonSignerDataClient(AWSCredentials credentials, AmazonSignerDataConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSignerDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSignerDataClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSignerDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSignerDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSignerDataClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSignerDataConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSignerDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSignerDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSignerDataClient Configuration Object</param>
        public AmazonSignerDataClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSignerDataConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSignerDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSignerDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSignerDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSignerDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSignerDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSignerDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSignerDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSignerDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSignerDataClient Configuration Object</param>
        public AmazonSignerDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSignerDataConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSignerDataEndpointResolver());
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


        #region  GetRevocationStatus

        /// <summary>
        /// Retrieves the revocation status for a signed artifact by checking if the signing profile,
        /// job, or certificate has been revoked.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevocationStatus service method.</param>
        /// 
        /// <returns>The response from the GetRevocationStatus service method, as returned by SignerData.</returns>
        /// <exception cref="Amazon.SignerData.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SignerData.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.SignerData.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SignerData.Model.ValidationException">
        /// The request contains invalid parameters or is malformed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-data-2017-08-25/GetRevocationStatus">REST API Reference for GetRevocationStatus Operation</seealso>
        public virtual GetRevocationStatusResponse GetRevocationStatus(GetRevocationStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRevocationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevocationStatusResponseUnmarshaller.Instance;

            return Invoke<GetRevocationStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRevocationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRevocationStatus operation on AmazonSignerDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRevocationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-data-2017-08-25/GetRevocationStatus">REST API Reference for GetRevocationStatus Operation</seealso>
        public virtual IAsyncResult BeginGetRevocationStatus(GetRevocationStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRevocationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevocationStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRevocationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRevocationStatus.</param>
        /// 
        /// <returns>Returns a  GetRevocationStatusResult from SignerData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-data-2017-08-25/GetRevocationStatus">REST API Reference for GetRevocationStatus Operation</seealso>
        public virtual GetRevocationStatusResponse EndGetRevocationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRevocationStatusResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonSignerDataEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}