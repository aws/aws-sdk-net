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
 * Do not modify this file. This file is generated from the s3outposts-2017-07-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.S3Outposts.Model;
using Amazon.S3Outposts.Model.Internal.MarshallTransformations;
using Amazon.S3Outposts.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3Outposts
{
    /// <summary>
    /// Implementation for accessing S3Outposts
    ///
    /// Amazon S3 on Outposts provides access to S3 on Outposts operations.
    /// </summary>
    public partial class AmazonS3OutpostsClient : AmazonServiceClient, IAmazonS3Outposts
    {
        private static IServiceMetadata serviceMetadata = new AmazonS3OutpostsMetadata();
        private IS3OutpostsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IS3OutpostsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new S3OutpostsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonS3OutpostsClient with the credentials loaded from the application's
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
        public AmazonS3OutpostsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3OutpostsConfig()) { }

        /// <summary>
        /// Constructs AmazonS3OutpostsClient with the credentials loaded from the application's
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
        public AmazonS3OutpostsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3OutpostsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonS3OutpostsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonS3OutpostsClient Configuration Object</param>
        public AmazonS3OutpostsClient(AmazonS3OutpostsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonS3OutpostsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonS3OutpostsClient(AWSCredentials credentials)
            : this(credentials, new AmazonS3OutpostsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonS3OutpostsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3OutpostsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonS3OutpostsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3OutpostsClient with AWS Credentials and an
        /// AmazonS3OutpostsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonS3OutpostsClient Configuration Object</param>
        public AmazonS3OutpostsClient(AWSCredentials credentials, AmazonS3OutpostsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3OutpostsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonS3OutpostsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3OutpostsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonS3OutpostsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3OutpostsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3OutpostsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3OutpostsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3OutpostsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonS3OutpostsClient Configuration Object</param>
        public AmazonS3OutpostsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonS3OutpostsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3OutpostsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonS3OutpostsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3OutpostsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonS3OutpostsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3OutpostsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3OutpostsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3OutpostsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3OutpostsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonS3OutpostsClient Configuration Object</param>
        public AmazonS3OutpostsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonS3OutpostsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonS3OutpostsEndpointResolver());
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


        #region  CreateEndpoint


        /// <summary>
        /// Creates an endpoint and associates it with the specified Outpost.
        /// 
        ///  <note> 
        /// <para>
        /// It can take up to 5 minutes for this action to finish.
        /// </para>
        ///  </note>  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_DeleteEndpoint.html">DeleteEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_ListEndpoints.html">ListEndpoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointResponse>(request, options);
        }


        /// <summary>
        /// Creates an endpoint and associates it with the specified Outpost.
        /// 
        ///  <note> 
        /// <para>
        /// It can take up to 5 minutes for this action to finish.
        /// </para>
        ///  </note>  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_DeleteEndpoint.html">DeleteEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_ListEndpoints.html">ListEndpoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ConflictException">
        /// There was a conflict with this action, and it could not be completed.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEndpoint


        /// <summary>
        /// Deletes an endpoint.
        /// 
        ///  <note> 
        /// <para>
        /// It can take up to 5 minutes for this action to finish.
        /// </para>
        ///  </note>  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_CreateEndpoint.html">CreateEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_ListEndpoints.html">ListEndpoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointResponse>(request, options);
        }


        /// <summary>
        /// Deletes an endpoint.
        /// 
        ///  <note> 
        /// <para>
        /// It can take up to 5 minutes for this action to finish.
        /// </para>
        ///  </note>  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_CreateEndpoint.html">CreateEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_ListEndpoints.html">ListEndpoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEndpoints


        /// <summary>
        /// Lists endpoints associated with the specified Outpost. 
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_CreateEndpoint.html">CreateEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_DeleteEndpoint.html">DeleteEndpoint</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListEndpoints service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        public virtual ListEndpointsResponse ListEndpoints(ListEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Lists endpoints associated with the specified Outpost. 
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_CreateEndpoint.html">CreateEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_DeleteEndpoint.html">DeleteEndpoint</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEndpoints service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        public virtual Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOutpostsWithS3


        /// <summary>
        /// Lists the Outposts with S3 on Outposts capacity for your Amazon Web Services account.
        /// Includes S3 on Outposts that you have access to as the Outposts owner, or as a shared
        /// user from Resource Access Manager (RAM).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOutpostsWithS3 service method.</param>
        /// 
        /// <returns>The response from the ListOutpostsWithS3 service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/ListOutpostsWithS3">REST API Reference for ListOutpostsWithS3 Operation</seealso>
        public virtual ListOutpostsWithS3Response ListOutpostsWithS3(ListOutpostsWithS3Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOutpostsWithS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutpostsWithS3ResponseUnmarshaller.Instance;

            return Invoke<ListOutpostsWithS3Response>(request, options);
        }


        /// <summary>
        /// Lists the Outposts with S3 on Outposts capacity for your Amazon Web Services account.
        /// Includes S3 on Outposts that you have access to as the Outposts owner, or as a shared
        /// user from Resource Access Manager (RAM).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOutpostsWithS3 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOutpostsWithS3 service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/ListOutpostsWithS3">REST API Reference for ListOutpostsWithS3 Operation</seealso>
        public virtual Task<ListOutpostsWithS3Response> ListOutpostsWithS3Async(ListOutpostsWithS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOutpostsWithS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutpostsWithS3ResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOutpostsWithS3Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSharedEndpoints


        /// <summary>
        /// Lists all endpoints associated with an Outpost that has been shared by Amazon Web
        /// Services Resource Access Manager (RAM).
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_CreateEndpoint.html">CreateEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_DeleteEndpoint.html">DeleteEndpoint</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSharedEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListSharedEndpoints service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/ListSharedEndpoints">REST API Reference for ListSharedEndpoints Operation</seealso>
        public virtual ListSharedEndpointsResponse ListSharedEndpoints(ListSharedEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSharedEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSharedEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListSharedEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Lists all endpoints associated with an Outpost that has been shared by Amazon Web
        /// Services Resource Access Manager (RAM).
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_CreateEndpoint.html">CreateEndpoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_s3outposts_DeleteEndpoint.html">DeleteEndpoint</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSharedEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSharedEndpoints service method, as returned by S3Outposts.</returns>
        /// <exception cref="Amazon.S3Outposts.Model.AccessDeniedException">
        /// Access was denied for this action.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.InternalServerException">
        /// There was an exception with the internal server.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Outposts.Model.ValidationException">
        /// There was an exception validating this data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3outposts-2017-07-25/ListSharedEndpoints">REST API Reference for ListSharedEndpoints Operation</seealso>
        public virtual Task<ListSharedEndpointsResponse> ListSharedEndpointsAsync(ListSharedEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSharedEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSharedEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSharedEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}