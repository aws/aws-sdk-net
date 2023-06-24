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
 * Do not modify this file. This file is generated from the iot1click-projects-2018-05-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IoT1ClickProjects.Model;
using Amazon.IoT1ClickProjects.Model.Internal.MarshallTransformations;
using Amazon.IoT1ClickProjects.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoT1ClickProjects
{
    /// <summary>
    /// Implementation for accessing IoT1ClickProjects
    ///
    /// The AWS IoT 1-Click Projects API Reference
    /// </summary>
    public partial class AmazonIoT1ClickProjectsClient : AmazonServiceClient, IAmazonIoT1ClickProjects
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoT1ClickProjectsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoT1ClickProjectsClient with the credentials loaded from the application's
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
        public AmazonIoT1ClickProjectsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoT1ClickProjectsConfig()) { }

        /// <summary>
        /// Constructs AmazonIoT1ClickProjectsClient with the credentials loaded from the application's
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
        public AmazonIoT1ClickProjectsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoT1ClickProjectsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoT1ClickProjectsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoT1ClickProjectsClient Configuration Object</param>
        public AmazonIoT1ClickProjectsClient(AmazonIoT1ClickProjectsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonIoT1ClickProjectsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoT1ClickProjectsClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoT1ClickProjectsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickProjectsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoT1ClickProjectsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoT1ClickProjectsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickProjectsClient with AWS Credentials and an
        /// AmazonIoT1ClickProjectsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoT1ClickProjectsClient Configuration Object</param>
        public AmazonIoT1ClickProjectsClient(AWSCredentials credentials, AmazonIoT1ClickProjectsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickProjectsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoT1ClickProjectsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoT1ClickProjectsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickProjectsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoT1ClickProjectsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoT1ClickProjectsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickProjectsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoT1ClickProjectsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoT1ClickProjectsClient Configuration Object</param>
        public AmazonIoT1ClickProjectsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoT1ClickProjectsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickProjectsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoT1ClickProjectsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoT1ClickProjectsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickProjectsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoT1ClickProjectsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoT1ClickProjectsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickProjectsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoT1ClickProjectsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoT1ClickProjectsClient Configuration Object</param>
        public AmazonIoT1ClickProjectsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoT1ClickProjectsConfig clientConfig)
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoT1ClickProjectsEndpointResolver());
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


        #region  AssociateDeviceWithPlacement

        internal virtual AssociateDeviceWithPlacementResponse AssociateDeviceWithPlacement(AssociateDeviceWithPlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDeviceWithPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDeviceWithPlacementResponseUnmarshaller.Instance;

            return Invoke<AssociateDeviceWithPlacementResponse>(request, options);
        }



        /// <summary>
        /// Associates a physical device with a placement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDeviceWithPlacement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDeviceWithPlacement service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/AssociateDeviceWithPlacement">REST API Reference for AssociateDeviceWithPlacement Operation</seealso>
        public virtual Task<AssociateDeviceWithPlacementResponse> AssociateDeviceWithPlacementAsync(AssociateDeviceWithPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDeviceWithPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDeviceWithPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDeviceWithPlacementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePlacement

        internal virtual CreatePlacementResponse CreatePlacement(CreatePlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlacementResponseUnmarshaller.Instance;

            return Invoke<CreatePlacementResponse>(request, options);
        }



        /// <summary>
        /// Creates an empty placement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlacement service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/CreatePlacement">REST API Reference for CreatePlacement Operation</seealso>
        public virtual Task<CreatePlacementResponse> CreatePlacementAsync(CreatePlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlacementResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlacementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProject

        internal virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
        }



        /// <summary>
        /// Creates an empty project with a placement template. A project contains zero or more
        /// placements that adhere to the placement template defined in the project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceConflictException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePlacement

        internal virtual DeletePlacementResponse DeletePlacement(DeletePlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlacementResponseUnmarshaller.Instance;

            return Invoke<DeletePlacementResponse>(request, options);
        }



        /// <summary>
        /// Deletes a placement. To delete a placement, it must not have any devices associated
        /// with it.
        /// 
        ///  <note> 
        /// <para>
        /// When you delete a placement, all associated data becomes irretrievable.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePlacement service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DeletePlacement">REST API Reference for DeletePlacement Operation</seealso>
        public virtual Task<DeletePlacementResponse> DeletePlacementAsync(DeletePlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlacementResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePlacementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProject

        internal virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
        }



        /// <summary>
        /// Deletes a project. To delete a project, it must not have any placements associated
        /// with it.
        /// 
        ///  <note> 
        /// <para>
        /// When you delete a project, all associated data becomes irretrievable.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePlacement

        internal virtual DescribePlacementResponse DescribePlacement(DescribePlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlacementResponseUnmarshaller.Instance;

            return Invoke<DescribePlacementResponse>(request, options);
        }



        /// <summary>
        /// Describes a placement in a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePlacement service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DescribePlacement">REST API Reference for DescribePlacement Operation</seealso>
        public virtual Task<DescribePlacementResponse> DescribePlacementAsync(DescribePlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlacementResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePlacementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProject

        internal virtual DescribeProjectResponse DescribeProject(DescribeProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return Invoke<DescribeProjectResponse>(request, options);
        }



        /// <summary>
        /// Returns an object describing a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        public virtual Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateDeviceFromPlacement

        internal virtual DisassociateDeviceFromPlacementResponse DisassociateDeviceFromPlacement(DisassociateDeviceFromPlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDeviceFromPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDeviceFromPlacementResponseUnmarshaller.Instance;

            return Invoke<DisassociateDeviceFromPlacementResponse>(request, options);
        }



        /// <summary>
        /// Removes a physical device from a placement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDeviceFromPlacement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateDeviceFromPlacement service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DisassociateDeviceFromPlacement">REST API Reference for DisassociateDeviceFromPlacement Operation</seealso>
        public virtual Task<DisassociateDeviceFromPlacementResponse> DisassociateDeviceFromPlacementAsync(DisassociateDeviceFromPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDeviceFromPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDeviceFromPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateDeviceFromPlacementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDevicesInPlacement

        internal virtual GetDevicesInPlacementResponse GetDevicesInPlacement(GetDevicesInPlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicesInPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicesInPlacementResponseUnmarshaller.Instance;

            return Invoke<GetDevicesInPlacementResponse>(request, options);
        }



        /// <summary>
        /// Returns an object enumerating the devices in a placement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicesInPlacement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevicesInPlacement service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/GetDevicesInPlacement">REST API Reference for GetDevicesInPlacement Operation</seealso>
        public virtual Task<GetDevicesInPlacementResponse> GetDevicesInPlacementAsync(GetDevicesInPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicesInPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicesInPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<GetDevicesInPlacementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPlacements

        internal virtual ListPlacementsResponse ListPlacements(ListPlacementsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlacementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlacementsResponseUnmarshaller.Instance;

            return Invoke<ListPlacementsResponse>(request, options);
        }



        /// <summary>
        /// Lists the placement(s) of a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlacements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlacements service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/ListPlacements">REST API Reference for ListPlacements Operation</seealso>
        public virtual Task<ListPlacementsResponse> ListPlacementsAsync(ListPlacementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlacementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlacementsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPlacementsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProjects

        internal virtual ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsResponse>(request, options);
        }



        /// <summary>
        /// Lists the AWS IoT 1-Click project(s) associated with your AWS account and region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectsResponse>(request, options, cancellationToken);
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
        /// Lists the tags (metadata key/value pairs) which you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// Creates or modifies tags for a resource. Tags are key/value pairs (metadata) that
        /// can be used to manage a resource. For more information, see <a href="https://aws.amazon.com/answers/account-management/aws-tagging-strategies/">AWS
        /// Tagging Strategies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags (metadata key/value pairs) from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePlacement

        internal virtual UpdatePlacementResponse UpdatePlacement(UpdatePlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlacementResponseUnmarshaller.Instance;

            return Invoke<UpdatePlacementResponse>(request, options);
        }



        /// <summary>
        /// Updates a placement with the given attributes. To clear an attribute, pass an empty
        /// value (i.e., "").
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlacement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePlacement service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/UpdatePlacement">REST API Reference for UpdatePlacement Operation</seealso>
        public virtual Task<UpdatePlacementResponse> UpdatePlacementAsync(UpdatePlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlacementResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePlacementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProject

        internal virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectResponse>(request, options);
        }



        /// <summary>
        /// Updates a project associated with your AWS account and region. With the exception
        /// of device template names, you can pass just the values that need to be updated because
        /// the update request will change only the values that are provided. To clear a value,
        /// pass the empty string (i.e., <code>""</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by IoT1ClickProjects.</returns>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickProjects.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}