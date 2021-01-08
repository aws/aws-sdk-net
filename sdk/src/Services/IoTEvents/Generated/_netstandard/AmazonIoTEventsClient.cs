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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTEvents.Model;
using Amazon.IoTEvents.Model.Internal.MarshallTransformations;
using Amazon.IoTEvents.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoTEvents
{
    /// <summary>
    /// Implementation for accessing IoTEvents
    ///
    /// AWS IoT Events monitors your equipment or device fleets for failures or changes in
    /// operation, and triggers actions when such events occur. You can use AWS IoT Events
    /// API operations to create, read, update, and delete inputs and detector models, and
    /// to list their versions.
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonIoTEventsClient : AmazonServiceClient, IAmazonIoTEvents
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTEventsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTEventsClient with the credentials loaded from the application's
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
        public AmazonIoTEventsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTEventsConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with the credentials loaded from the application's
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
        public AmazonIoTEventsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTEventsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTEventsClient Configuration Object</param>
        public AmazonIoTEventsClient(AmazonIoTEventsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTEventsClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTEventsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTEventsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Credentials and an
        /// AmazonIoTEventsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTEventsClient Configuration Object</param>
        public AmazonIoTEventsClient(AWSCredentials credentials, AmazonIoTEventsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTEventsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTEventsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTEventsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTEventsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTEventsClient Configuration Object</param>
        public AmazonIoTEventsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTEventsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTEventsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTEventsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTEventsClient Configuration Object</param>
        public AmazonIoTEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTEventsConfig clientConfig)
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


        #region  CreateDetectorModel

        internal virtual CreateDetectorModelResponse CreateDetectorModel(CreateDetectorModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDetectorModelResponseUnmarshaller.Instance;

            return Invoke<CreateDetectorModelResponse>(request, options);
        }



        /// <summary>
        /// Creates a detector model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDetectorModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDetectorModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/CreateDetectorModel">REST API Reference for CreateDetectorModel Operation</seealso>
        public virtual Task<CreateDetectorModelResponse> CreateDetectorModelAsync(CreateDetectorModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDetectorModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDetectorModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInput

        internal virtual CreateInputResponse CreateInput(CreateInputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInputResponseUnmarshaller.Instance;

            return Invoke<CreateInputResponse>(request, options);
        }



        /// <summary>
        /// Creates an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInput service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/CreateInput">REST API Reference for CreateInput Operation</seealso>
        public virtual Task<CreateInputResponse> CreateInputAsync(CreateInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInputResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDetectorModel

        internal virtual DeleteDetectorModelResponse DeleteDetectorModel(DeleteDetectorModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDetectorModelResponseUnmarshaller.Instance;

            return Invoke<DeleteDetectorModelResponse>(request, options);
        }



        /// <summary>
        /// Deletes a detector model. Any active instances of the detector model are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetectorModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDetectorModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DeleteDetectorModel">REST API Reference for DeleteDetectorModel Operation</seealso>
        public virtual Task<DeleteDetectorModelResponse> DeleteDetectorModelAsync(DeleteDetectorModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDetectorModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDetectorModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInput

        internal virtual DeleteInputResponse DeleteInput(DeleteInputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInputResponseUnmarshaller.Instance;

            return Invoke<DeleteInputResponse>(request, options);
        }



        /// <summary>
        /// Deletes an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInput service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        public virtual Task<DeleteInputResponse> DeleteInputAsync(DeleteInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInputResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDetectorModel

        internal virtual DescribeDetectorModelResponse DescribeDetectorModel(DescribeDetectorModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectorModelResponseUnmarshaller.Instance;

            return Invoke<DescribeDetectorModelResponse>(request, options);
        }



        /// <summary>
        /// Describes a detector model. If the <code>version</code> parameter is not specified,
        /// information about the latest version is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetectorModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDetectorModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeDetectorModel">REST API Reference for DescribeDetectorModel Operation</seealso>
        public virtual Task<DescribeDetectorModelResponse> DescribeDetectorModelAsync(DescribeDetectorModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectorModelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDetectorModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInput

        internal virtual DescribeInputResponse DescribeInput(DescribeInputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInputResponseUnmarshaller.Instance;

            return Invoke<DescribeInputResponse>(request, options);
        }



        /// <summary>
        /// Describes an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInput service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        public virtual Task<DescribeInputResponse> DescribeInputAsync(DescribeInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInputResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoggingOptions

        internal virtual DescribeLoggingOptionsResponse DescribeLoggingOptions(DescribeLoggingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingOptionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current settings of the AWS IoT Events logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoggingOptions service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.UnsupportedOperationException">
        /// The requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        public virtual Task<DescribeLoggingOptionsResponse> DescribeLoggingOptionsAsync(DescribeLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoggingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDetectorModels

        internal virtual ListDetectorModelsResponse ListDetectorModels(ListDetectorModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDetectorModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectorModelsResponseUnmarshaller.Instance;

            return Invoke<ListDetectorModelsResponse>(request, options);
        }



        /// <summary>
        /// Lists the detector models you have created. Only the metadata associated with each
        /// detector model is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectorModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDetectorModels service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListDetectorModels">REST API Reference for ListDetectorModels Operation</seealso>
        public virtual Task<ListDetectorModelsResponse> ListDetectorModelsAsync(ListDetectorModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDetectorModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectorModelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDetectorModelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDetectorModelVersions

        internal virtual ListDetectorModelVersionsResponse ListDetectorModelVersions(ListDetectorModelVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDetectorModelVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectorModelVersionsResponseUnmarshaller.Instance;

            return Invoke<ListDetectorModelVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the versions of a detector model. Only the metadata associated with each
        /// detector model version is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectorModelVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDetectorModelVersions service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListDetectorModelVersions">REST API Reference for ListDetectorModelVersions Operation</seealso>
        public virtual Task<ListDetectorModelVersionsResponse> ListDetectorModelVersionsAsync(ListDetectorModelVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDetectorModelVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectorModelVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDetectorModelVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInputs

        internal virtual ListInputsResponse ListInputs(ListInputsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputsResponseUnmarshaller.Instance;

            return Invoke<ListInputsResponse>(request, options);
        }



        /// <summary>
        /// Lists the inputs you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInputs service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListInputs">REST API Reference for ListInputs Operation</seealso>
        public virtual Task<ListInputsResponse> ListInputsAsync(ListInputsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInputsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags (metadata) you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutLoggingOptions

        internal virtual PutLoggingOptionsResponse PutLoggingOptions(PutLoggingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutLoggingOptionsResponse>(request, options);
        }



        /// <summary>
        /// Sets or updates the AWS IoT Events logging options.
        /// 
        ///  
        /// <para>
        /// If you update the value of any <code>loggingOptions</code> field, it takes up to one
        /// minute for the change to take effect. If you change the policy attached to the role
        /// you specified in the <code>roleArn</code> field (for example, to correct an invalid
        /// policy), it takes up to five minutes for that change to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLoggingOptions service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.UnsupportedOperationException">
        /// The requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        public virtual Task<PutLoggingOptionsResponse> PutLoggingOptionsAsync(PutLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutLoggingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata that can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the given tags (metadata) from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDetectorModel

        internal virtual UpdateDetectorModelResponse UpdateDetectorModel(UpdateDetectorModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorModelResponseUnmarshaller.Instance;

            return Invoke<UpdateDetectorModelResponse>(request, options);
        }



        /// <summary>
        /// Updates a detector model. Detectors (instances) spawned by the previous version are
        /// deleted and then re-created as new inputs arrive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDetectorModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UpdateDetectorModel">REST API Reference for UpdateDetectorModel Operation</seealso>
        public virtual Task<UpdateDetectorModelResponse> UpdateDetectorModelAsync(UpdateDetectorModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorModelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDetectorModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateInput

        internal virtual UpdateInputResponse UpdateInput(UpdateInputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInputResponseUnmarshaller.Instance;

            return Invoke<UpdateInputResponse>(request, options);
        }



        /// <summary>
        /// Updates an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInput service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UpdateInput">REST API Reference for UpdateInput Operation</seealso>
        public virtual Task<UpdateInputResponse> UpdateInputAsync(UpdateInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInputResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateInputResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}