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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MediaConnect.Model;
using Amazon.MediaConnect.Model.Internal.MarshallTransformations;
using Amazon.MediaConnect.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MediaConnect
{
    /// <summary>
    /// Implementation for accessing MediaConnect
    ///
    /// API for AWS Elemental MediaConnect
    /// </summary>
    public partial class AmazonMediaConnectClient : AmazonServiceClient, IAmazonMediaConnect
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaConnectMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonMediaConnectClient with the credentials loaded from the application's
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
        public AmazonMediaConnectClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaConnectConfig()) { }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with the credentials loaded from the application's
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
        public AmazonMediaConnectClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaConnectConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMediaConnectClient Configuration Object</param>
        public AmazonMediaConnectClient(AmazonMediaConnectConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMediaConnectClient(AWSCredentials credentials)
            : this(credentials, new AmazonMediaConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaConnectClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMediaConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Credentials and an
        /// AmazonMediaConnectClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMediaConnectClient Configuration Object</param>
        public AmazonMediaConnectClient(AWSCredentials credentials, AmazonMediaConnectConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMediaConnectClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaConnectClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaConnectConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMediaConnectClient Configuration Object</param>
        public AmazonMediaConnectClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMediaConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMediaConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMediaConnectClient Configuration Object</param>
        public AmazonMediaConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMediaConnectConfig clientConfig)
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


        #region  AddFlowOutputs


        /// <summary>
        /// Adds outputs to an existing flow. You can create up to 20 outputs per flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFlowOutputs service method.</param>
        /// 
        /// <returns>The response from the AddFlowOutputs service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.AddFlowOutputs420Exception">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowOutputs">REST API Reference for AddFlowOutputs Operation</seealso>
        public virtual AddFlowOutputsResponse AddFlowOutputs(AddFlowOutputsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddFlowOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowOutputsResponseUnmarshaller.Instance;

            return Invoke<AddFlowOutputsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddFlowOutputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddFlowOutputs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowOutputs">REST API Reference for AddFlowOutputs Operation</seealso>
        public virtual Task<AddFlowOutputsResponse> AddFlowOutputsAsync(AddFlowOutputsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddFlowOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowOutputsResponseUnmarshaller.Instance;
            
            return InvokeAsync<AddFlowOutputsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFlow


        /// <summary>
        /// Creates a new flow. The request must include one source. The request optionally can
        /// include outputs (up to 20) and entitlements (up to 50).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlow service method.</param>
        /// 
        /// <returns>The response from the CreateFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.CreateFlow420Exception">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateFlow">REST API Reference for CreateFlow Operation</seealso>
        public virtual CreateFlowResponse CreateFlow(CreateFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowResponseUnmarshaller.Instance;

            return Invoke<CreateFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFlow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateFlow">REST API Reference for CreateFlow Operation</seealso>
        public virtual Task<CreateFlowResponse> CreateFlowAsync(CreateFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFlow


        /// <summary>
        /// Deletes a flow. Before you can delete a flow, you must stop the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlow service method.</param>
        /// 
        /// <returns>The response from the DeleteFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteFlow">REST API Reference for DeleteFlow Operation</seealso>
        public virtual DeleteFlowResponse DeleteFlow(DeleteFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteFlow">REST API Reference for DeleteFlow Operation</seealso>
        public virtual Task<DeleteFlowResponse> DeleteFlowAsync(DeleteFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFlow


        /// <summary>
        /// Displays the details of a flow. The response includes the flow ARN, name, and Availability
        /// Zone, as well as details about the source, outputs, and entitlements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlow service method.</param>
        /// 
        /// <returns>The response from the DescribeFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeFlow">REST API Reference for DescribeFlow Operation</seealso>
        public virtual DescribeFlowResponse DescribeFlow(DescribeFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeFlow">REST API Reference for DescribeFlow Operation</seealso>
        public virtual Task<DescribeFlowResponse> DescribeFlowAsync(DescribeFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GrantFlowEntitlements


        /// <summary>
        /// Grants entitlements to an existing flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GrantFlowEntitlements service method.</param>
        /// 
        /// <returns>The response from the GrantFlowEntitlements service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.GrantFlowEntitlements420Exception">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GrantFlowEntitlements">REST API Reference for GrantFlowEntitlements Operation</seealso>
        public virtual GrantFlowEntitlementsResponse GrantFlowEntitlements(GrantFlowEntitlementsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GrantFlowEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GrantFlowEntitlementsResponseUnmarshaller.Instance;

            return Invoke<GrantFlowEntitlementsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GrantFlowEntitlements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GrantFlowEntitlements operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GrantFlowEntitlements">REST API Reference for GrantFlowEntitlements Operation</seealso>
        public virtual Task<GrantFlowEntitlementsResponse> GrantFlowEntitlementsAsync(GrantFlowEntitlementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GrantFlowEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GrantFlowEntitlementsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GrantFlowEntitlementsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEntitlements


        /// <summary>
        /// Displays a list of all entitlements that have been granted to this account. This request
        /// returns 20 results per page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitlements service method.</param>
        /// 
        /// <returns>The response from the ListEntitlements service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListEntitlements">REST API Reference for ListEntitlements Operation</seealso>
        public virtual ListEntitlementsResponse ListEntitlements(ListEntitlementsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitlementsResponseUnmarshaller.Instance;

            return Invoke<ListEntitlementsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEntitlements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntitlements operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListEntitlements">REST API Reference for ListEntitlements Operation</seealso>
        public virtual Task<ListEntitlementsResponse> ListEntitlementsAsync(ListEntitlementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitlementsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEntitlementsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFlows


        /// <summary>
        /// Displays a list of flows that are associated with this account. This request returns
        /// a paginated result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlows service method.</param>
        /// 
        /// <returns>The response from the ListFlows service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListFlows">REST API Reference for ListFlows Operation</seealso>
        public virtual ListFlowsResponse ListFlows(ListFlowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowsResponseUnmarshaller.Instance;

            return Invoke<ListFlowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFlows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFlows operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListFlows">REST API Reference for ListFlows Operation</seealso>
        public virtual Task<ListFlowsResponse> ListFlowsAsync(ListFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFlowsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveFlowOutput


        /// <summary>
        /// Removes an output from an existing flow. This request can be made only on an output
        /// that does not have an entitlement associated with it. If the output has an entitlement,
        /// you must revoke the entitlement instead. When an entitlement is revoked from a flow,
        /// the service automatically removes the associated output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowOutput service method.</param>
        /// 
        /// <returns>The response from the RemoveFlowOutput service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowOutput">REST API Reference for RemoveFlowOutput Operation</seealso>
        public virtual RemoveFlowOutputResponse RemoveFlowOutput(RemoveFlowOutputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveFlowOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowOutputResponseUnmarshaller.Instance;

            return Invoke<RemoveFlowOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveFlowOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowOutput">REST API Reference for RemoveFlowOutput Operation</seealso>
        public virtual Task<RemoveFlowOutputResponse> RemoveFlowOutputAsync(RemoveFlowOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveFlowOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowOutputResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveFlowOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeFlowEntitlement


        /// <summary>
        /// Revokes an entitlement from a flow. Once an entitlement is revoked, the content becomes
        /// unavailable to the subscriber and the associated output is removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeFlowEntitlement service method.</param>
        /// 
        /// <returns>The response from the RevokeFlowEntitlement service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RevokeFlowEntitlement">REST API Reference for RevokeFlowEntitlement Operation</seealso>
        public virtual RevokeFlowEntitlementResponse RevokeFlowEntitlement(RevokeFlowEntitlementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeFlowEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeFlowEntitlementResponseUnmarshaller.Instance;

            return Invoke<RevokeFlowEntitlementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeFlowEntitlement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeFlowEntitlement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RevokeFlowEntitlement">REST API Reference for RevokeFlowEntitlement Operation</seealso>
        public virtual Task<RevokeFlowEntitlementResponse> RevokeFlowEntitlementAsync(RevokeFlowEntitlementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeFlowEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeFlowEntitlementResponseUnmarshaller.Instance;
            
            return InvokeAsync<RevokeFlowEntitlementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartFlow


        /// <summary>
        /// Starts a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFlow service method.</param>
        /// 
        /// <returns>The response from the StartFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StartFlow">REST API Reference for StartFlow Operation</seealso>
        public virtual StartFlowResponse StartFlow(StartFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowResponseUnmarshaller.Instance;

            return Invoke<StartFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFlow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StartFlow">REST API Reference for StartFlow Operation</seealso>
        public virtual Task<StartFlowResponse> StartFlowAsync(StartFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopFlow


        /// <summary>
        /// Stops a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFlow service method.</param>
        /// 
        /// <returns>The response from the StopFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StopFlow">REST API Reference for StopFlow Operation</seealso>
        public virtual StopFlowResponse StopFlow(StopFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFlowResponseUnmarshaller.Instance;

            return Invoke<StopFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopFlow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StopFlow">REST API Reference for StopFlow Operation</seealso>
        public virtual Task<StopFlowResponse> StopFlowAsync(StopFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFlowResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFlowEntitlement


        /// <summary>
        /// You can change an entitlement's description, subscribers, and encryption. If you change
        /// the subscribers, the service will remove the outputs that are are used by the subscribers
        /// that are removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowEntitlement service method.</param>
        /// 
        /// <returns>The response from the UpdateFlowEntitlement service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowEntitlement">REST API Reference for UpdateFlowEntitlement Operation</seealso>
        public virtual UpdateFlowEntitlementResponse UpdateFlowEntitlement(UpdateFlowEntitlementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFlowEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowEntitlementResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowEntitlementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFlowEntitlement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowEntitlement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowEntitlement">REST API Reference for UpdateFlowEntitlement Operation</seealso>
        public virtual Task<UpdateFlowEntitlementResponse> UpdateFlowEntitlementAsync(UpdateFlowEntitlementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFlowEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowEntitlementResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFlowEntitlementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFlowOutput


        /// <summary>
        /// Updates an existing flow output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowOutput service method.</param>
        /// 
        /// <returns>The response from the UpdateFlowOutput service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowOutput">REST API Reference for UpdateFlowOutput Operation</seealso>
        public virtual UpdateFlowOutputResponse UpdateFlowOutput(UpdateFlowOutputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFlowOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowOutputResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFlowOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowOutput">REST API Reference for UpdateFlowOutput Operation</seealso>
        public virtual Task<UpdateFlowOutputResponse> UpdateFlowOutputAsync(UpdateFlowOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFlowOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowOutputResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFlowOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFlowSource


        /// <summary>
        /// Updates the source of a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowSource service method.</param>
        /// 
        /// <returns>The response from the UpdateFlowSource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowSource">REST API Reference for UpdateFlowSource Operation</seealso>
        public virtual UpdateFlowSourceResponse UpdateFlowSource(UpdateFlowSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFlowSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFlowSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowSource">REST API Reference for UpdateFlowSource Operation</seealso>
        public virtual Task<UpdateFlowSourceResponse> UpdateFlowSourceAsync(UpdateFlowSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFlowSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFlowSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}