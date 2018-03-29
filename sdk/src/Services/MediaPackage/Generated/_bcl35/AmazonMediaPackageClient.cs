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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.MediaPackage.Model;
using Amazon.MediaPackage.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MediaPackage
{
    /// <summary>
    /// Implementation for accessing MediaPackage
    ///
    /// AWS Elemental MediaPackage
    /// </summary>
    public partial class AmazonMediaPackageClient : AmazonServiceClient, IAmazonMediaPackage
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonMediaPackageClient with the credentials loaded from the application's
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
        public AmazonMediaPackageClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaPackageConfig()) { }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with the credentials loaded from the application's
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
        public AmazonMediaPackageClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaPackageConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMediaPackageClient Configuration Object</param>
        public AmazonMediaPackageClient(AmazonMediaPackageConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMediaPackageClient(AWSCredentials credentials)
            : this(credentials, new AmazonMediaPackageConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaPackageClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMediaPackageConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Credentials and an
        /// AmazonMediaPackageClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMediaPackageClient Configuration Object</param>
        public AmazonMediaPackageClient(AWSCredentials credentials, AmazonMediaPackageConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMediaPackageClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaPackageConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaPackageClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaPackageConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaPackageClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMediaPackageClient Configuration Object</param>
        public AmazonMediaPackageClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMediaPackageConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMediaPackageClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaPackageConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaPackageClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaPackageConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaPackageClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMediaPackageClient Configuration Object</param>
        public AmazonMediaPackageClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMediaPackageConfig clientConfig)
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

        
        #region  CreateChannel

        /// <summary>
        /// Creates a new Channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var marshaller = CreateChannelRequestMarshaller.Instance;
            var unmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelRequest,CreateChannelResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual IAsyncResult BeginCreateChannel(CreateChannelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateChannelRequestMarshaller.Instance;
            var unmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return BeginInvoke<CreateChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannel.</param>
        /// 
        /// <returns>Returns a  CreateChannelResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse EndCreateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateOriginEndpoint

        /// <summary>
        /// Creates a new OriginEndpoint record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateOriginEndpoint service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateOriginEndpoint">REST API Reference for CreateOriginEndpoint Operation</seealso>
        public virtual CreateOriginEndpointResponse CreateOriginEndpoint(CreateOriginEndpointRequest request)
        {
            var marshaller = CreateOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = CreateOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateOriginEndpointRequest,CreateOriginEndpointResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginEndpoint operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOriginEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateOriginEndpoint">REST API Reference for CreateOriginEndpoint Operation</seealso>
        public virtual IAsyncResult BeginCreateOriginEndpoint(CreateOriginEndpointRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = CreateOriginEndpointResponseUnmarshaller.Instance;

            return BeginInvoke<CreateOriginEndpointRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOriginEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateOriginEndpointResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/CreateOriginEndpoint">REST API Reference for CreateOriginEndpoint Operation</seealso>
        public virtual CreateOriginEndpointResponse EndCreateOriginEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOriginEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannel

        /// <summary>
        /// Deletes an existing Channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var marshaller = DeleteChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelRequest,DeleteChannelResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannel(DeleteChannelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannel.</param>
        /// 
        /// <returns>Returns a  DeleteChannelResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual DeleteChannelResponse EndDeleteChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteOriginEndpoint

        /// <summary>
        /// Deletes an existing OriginEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteOriginEndpoint service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteOriginEndpoint">REST API Reference for DeleteOriginEndpoint Operation</seealso>
        public virtual DeleteOriginEndpointResponse DeleteOriginEndpoint(DeleteOriginEndpointRequest request)
        {
            var marshaller = DeleteOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = DeleteOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteOriginEndpointRequest,DeleteOriginEndpointResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginEndpoint operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOriginEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteOriginEndpoint">REST API Reference for DeleteOriginEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteOriginEndpoint(DeleteOriginEndpointRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = DeleteOriginEndpointResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteOriginEndpointRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOriginEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteOriginEndpointResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DeleteOriginEndpoint">REST API Reference for DeleteOriginEndpoint Operation</seealso>
        public virtual DeleteOriginEndpointResponse EndDeleteOriginEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOriginEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannel

        /// <summary>
        /// Gets details about a Channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual DescribeChannelResponse DescribeChannel(DescribeChannelRequest request)
        {
            var marshaller = DescribeChannelRequestMarshaller.Instance;
            var unmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelRequest,DescribeChannelResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannel(DescribeChannelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeChannelRequestMarshaller.Instance;
            var unmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannel.</param>
        /// 
        /// <returns>Returns a  DescribeChannelResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual DescribeChannelResponse EndDescribeChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOriginEndpoint

        /// <summary>
        /// Gets details about an existing OriginEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the DescribeOriginEndpoint service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeOriginEndpoint">REST API Reference for DescribeOriginEndpoint Operation</seealso>
        public virtual DescribeOriginEndpointResponse DescribeOriginEndpoint(DescribeOriginEndpointRequest request)
        {
            var marshaller = DescribeOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = DescribeOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<DescribeOriginEndpointRequest,DescribeOriginEndpointResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOriginEndpoint operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOriginEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeOriginEndpoint">REST API Reference for DescribeOriginEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDescribeOriginEndpoint(DescribeOriginEndpointRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = DescribeOriginEndpointResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeOriginEndpointRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOriginEndpoint.</param>
        /// 
        /// <returns>Returns a  DescribeOriginEndpointResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/DescribeOriginEndpoint">REST API Reference for DescribeOriginEndpoint Operation</seealso>
        public virtual DescribeOriginEndpointResponse EndDescribeOriginEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOriginEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannels

        /// <summary>
        /// Returns a collection of Channels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var marshaller = ListChannelsRequestMarshaller.Instance;
            var unmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsRequest,ListChannelsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListChannelsRequestMarshaller.Instance;
            var unmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return BeginInvoke<ListChannelsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse EndListChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOriginEndpoints

        /// <summary>
        /// Returns a collection of OriginEndpoint records.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOriginEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListOriginEndpoints service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListOriginEndpoints">REST API Reference for ListOriginEndpoints Operation</seealso>
        public virtual ListOriginEndpointsResponse ListOriginEndpoints(ListOriginEndpointsRequest request)
        {
            var marshaller = ListOriginEndpointsRequestMarshaller.Instance;
            var unmarshaller = ListOriginEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListOriginEndpointsRequest,ListOriginEndpointsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOriginEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOriginEndpoints operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOriginEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListOriginEndpoints">REST API Reference for ListOriginEndpoints Operation</seealso>
        public virtual IAsyncResult BeginListOriginEndpoints(ListOriginEndpointsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListOriginEndpointsRequestMarshaller.Instance;
            var unmarshaller = ListOriginEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke<ListOriginEndpointsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOriginEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOriginEndpoints.</param>
        /// 
        /// <returns>Returns a  ListOriginEndpointsResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/ListOriginEndpoints">REST API Reference for ListOriginEndpoints Operation</seealso>
        public virtual ListOriginEndpointsResponse EndListOriginEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOriginEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  RotateChannelCredentials

        /// <summary>
        /// Changes the Channel ingest username and password.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateChannelCredentials service method.</param>
        /// 
        /// <returns>The response from the RotateChannelCredentials service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/RotateChannelCredentials">REST API Reference for RotateChannelCredentials Operation</seealso>
        public virtual RotateChannelCredentialsResponse RotateChannelCredentials(RotateChannelCredentialsRequest request)
        {
            var marshaller = RotateChannelCredentialsRequestMarshaller.Instance;
            var unmarshaller = RotateChannelCredentialsResponseUnmarshaller.Instance;

            return Invoke<RotateChannelCredentialsRequest,RotateChannelCredentialsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RotateChannelCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateChannelCredentials operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRotateChannelCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/RotateChannelCredentials">REST API Reference for RotateChannelCredentials Operation</seealso>
        public virtual IAsyncResult BeginRotateChannelCredentials(RotateChannelCredentialsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RotateChannelCredentialsRequestMarshaller.Instance;
            var unmarshaller = RotateChannelCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke<RotateChannelCredentialsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RotateChannelCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRotateChannelCredentials.</param>
        /// 
        /// <returns>Returns a  RotateChannelCredentialsResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/RotateChannelCredentials">REST API Reference for RotateChannelCredentials Operation</seealso>
        public virtual RotateChannelCredentialsResponse EndRotateChannelCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<RotateChannelCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChannel

        /// <summary>
        /// Updates an existing Channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var marshaller = UpdateChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelRequest,UpdateChannelResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateChannel(UpdateChannelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannel.</param>
        /// 
        /// <returns>Returns a  UpdateChannelResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse EndUpdateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateOriginEndpoint

        /// <summary>
        /// Updates an existing OriginEndpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateOriginEndpoint service method, as returned by MediaPackage.</returns>
        /// <exception cref="Amazon.MediaPackage.Model.ForbiddenException">
        /// The client is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.InternalServerErrorException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.NotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.ServiceUnavailableException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.TooManyRequestsException">
        /// The client has exceeded their resource or throttling limits.
        /// </exception>
        /// <exception cref="Amazon.MediaPackage.Model.UnprocessableEntityException">
        /// The parameters sent in the request are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateOriginEndpoint">REST API Reference for UpdateOriginEndpoint Operation</seealso>
        public virtual UpdateOriginEndpointResponse UpdateOriginEndpoint(UpdateOriginEndpointRequest request)
        {
            var marshaller = UpdateOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = UpdateOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateOriginEndpointRequest,UpdateOriginEndpointResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginEndpoint operation on AmazonMediaPackageClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOriginEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateOriginEndpoint">REST API Reference for UpdateOriginEndpoint Operation</seealso>
        public virtual IAsyncResult BeginUpdateOriginEndpoint(UpdateOriginEndpointRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateOriginEndpointRequestMarshaller.Instance;
            var unmarshaller = UpdateOriginEndpointResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateOriginEndpointRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOriginEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOriginEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateOriginEndpointResult from MediaPackage.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackage-2017-10-12/UpdateOriginEndpoint">REST API Reference for UpdateOriginEndpoint Operation</seealso>
        public virtual UpdateOriginEndpointResponse EndUpdateOriginEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateOriginEndpointResponse>(asyncResult);
        }

        #endregion
        
    }
}