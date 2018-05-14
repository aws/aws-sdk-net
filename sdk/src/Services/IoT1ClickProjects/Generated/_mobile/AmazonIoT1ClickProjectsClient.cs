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
 * Do not modify this file. This file is generated from the iot1click-projects-2018-05-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.IoT1ClickProjects.Model;
using Amazon.IoT1ClickProjects.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoT1ClickProjects
{
    /// <summary>
    /// Implementation for accessing IoT1ClickProjects
    ///
    /// The AWS IoT 1-Click Project API Reference
    /// </summary>
    public partial class AmazonIoT1ClickProjectsClient : AmazonServiceClient, IAmazonIoT1ClickProjects
    {
        
        #region Constructors

#if CORECLR
    
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

#endif

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
            var marshaller = AssociateDeviceWithPlacementRequestMarshaller.Instance;
            var unmarshaller = AssociateDeviceWithPlacementResponseUnmarshaller.Instance;

            return Invoke<AssociateDeviceWithPlacementRequest,AssociateDeviceWithPlacementResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDeviceWithPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDeviceWithPlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/AssociateDeviceWithPlacement">REST API Reference for AssociateDeviceWithPlacement Operation</seealso>
        public virtual Task<AssociateDeviceWithPlacementResponse> AssociateDeviceWithPlacementAsync(AssociateDeviceWithPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateDeviceWithPlacementRequestMarshaller.Instance;
            var unmarshaller = AssociateDeviceWithPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDeviceWithPlacementRequest,AssociateDeviceWithPlacementResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePlacement

        internal virtual CreatePlacementResponse CreatePlacement(CreatePlacementRequest request)
        {
            var marshaller = CreatePlacementRequestMarshaller.Instance;
            var unmarshaller = CreatePlacementResponseUnmarshaller.Instance;

            return Invoke<CreatePlacementRequest,CreatePlacementResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/CreatePlacement">REST API Reference for CreatePlacement Operation</seealso>
        public virtual Task<CreatePlacementResponse> CreatePlacementAsync(CreatePlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreatePlacementRequestMarshaller.Instance;
            var unmarshaller = CreatePlacementResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlacementRequest,CreatePlacementResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateProject

        internal virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var marshaller = CreateProjectRequestMarshaller.Instance;
            var unmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectRequest,CreateProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateProjectRequestMarshaller.Instance;
            var unmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectRequest,CreateProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePlacement

        internal virtual DeletePlacementResponse DeletePlacement(DeletePlacementRequest request)
        {
            var marshaller = DeletePlacementRequestMarshaller.Instance;
            var unmarshaller = DeletePlacementResponseUnmarshaller.Instance;

            return Invoke<DeletePlacementRequest,DeletePlacementResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DeletePlacement">REST API Reference for DeletePlacement Operation</seealso>
        public virtual Task<DeletePlacementResponse> DeletePlacementAsync(DeletePlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeletePlacementRequestMarshaller.Instance;
            var unmarshaller = DeletePlacementResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePlacementRequest,DeletePlacementResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteProject

        internal virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var marshaller = DeleteProjectRequestMarshaller.Instance;
            var unmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectRequest,DeleteProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteProjectRequestMarshaller.Instance;
            var unmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectRequest,DeleteProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePlacement

        internal virtual DescribePlacementResponse DescribePlacement(DescribePlacementRequest request)
        {
            var marshaller = DescribePlacementRequestMarshaller.Instance;
            var unmarshaller = DescribePlacementResponseUnmarshaller.Instance;

            return Invoke<DescribePlacementRequest,DescribePlacementResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DescribePlacement">REST API Reference for DescribePlacement Operation</seealso>
        public virtual Task<DescribePlacementResponse> DescribePlacementAsync(DescribePlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribePlacementRequestMarshaller.Instance;
            var unmarshaller = DescribePlacementResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePlacementRequest,DescribePlacementResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeProject

        internal virtual DescribeProjectResponse DescribeProject(DescribeProjectRequest request)
        {
            var marshaller = DescribeProjectRequestMarshaller.Instance;
            var unmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return Invoke<DescribeProjectRequest,DescribeProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        public virtual Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeProjectRequestMarshaller.Instance;
            var unmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProjectRequest,DescribeProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateDeviceFromPlacement

        internal virtual DisassociateDeviceFromPlacementResponse DisassociateDeviceFromPlacement(DisassociateDeviceFromPlacementRequest request)
        {
            var marshaller = DisassociateDeviceFromPlacementRequestMarshaller.Instance;
            var unmarshaller = DisassociateDeviceFromPlacementResponseUnmarshaller.Instance;

            return Invoke<DisassociateDeviceFromPlacementRequest,DisassociateDeviceFromPlacementResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDeviceFromPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDeviceFromPlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/DisassociateDeviceFromPlacement">REST API Reference for DisassociateDeviceFromPlacement Operation</seealso>
        public virtual Task<DisassociateDeviceFromPlacementResponse> DisassociateDeviceFromPlacementAsync(DisassociateDeviceFromPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateDeviceFromPlacementRequestMarshaller.Instance;
            var unmarshaller = DisassociateDeviceFromPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateDeviceFromPlacementRequest,DisassociateDeviceFromPlacementResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDevicesInPlacement

        internal virtual GetDevicesInPlacementResponse GetDevicesInPlacement(GetDevicesInPlacementRequest request)
        {
            var marshaller = GetDevicesInPlacementRequestMarshaller.Instance;
            var unmarshaller = GetDevicesInPlacementResponseUnmarshaller.Instance;

            return Invoke<GetDevicesInPlacementRequest,GetDevicesInPlacementResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicesInPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicesInPlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/GetDevicesInPlacement">REST API Reference for GetDevicesInPlacement Operation</seealso>
        public virtual Task<GetDevicesInPlacementResponse> GetDevicesInPlacementAsync(GetDevicesInPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDevicesInPlacementRequestMarshaller.Instance;
            var unmarshaller = GetDevicesInPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<GetDevicesInPlacementRequest,GetDevicesInPlacementResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPlacements

        internal virtual ListPlacementsResponse ListPlacements(ListPlacementsRequest request)
        {
            var marshaller = ListPlacementsRequestMarshaller.Instance;
            var unmarshaller = ListPlacementsResponseUnmarshaller.Instance;

            return Invoke<ListPlacementsRequest,ListPlacementsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPlacements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlacements operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/ListPlacements">REST API Reference for ListPlacements Operation</seealso>
        public virtual Task<ListPlacementsResponse> ListPlacementsAsync(ListPlacementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListPlacementsRequestMarshaller.Instance;
            var unmarshaller = ListPlacementsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPlacementsRequest,ListPlacementsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListProjects

        internal virtual ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var marshaller = ListProjectsRequestMarshaller.Instance;
            var unmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsRequest,ListProjectsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListProjectsRequestMarshaller.Instance;
            var unmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectsRequest,ListProjectsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdatePlacement

        internal virtual UpdatePlacementResponse UpdatePlacement(UpdatePlacementRequest request)
        {
            var marshaller = UpdatePlacementRequestMarshaller.Instance;
            var unmarshaller = UpdatePlacementResponseUnmarshaller.Instance;

            return Invoke<UpdatePlacementRequest,UpdatePlacementResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/UpdatePlacement">REST API Reference for UpdatePlacement Operation</seealso>
        public virtual Task<UpdatePlacementResponse> UpdatePlacementAsync(UpdatePlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdatePlacementRequestMarshaller.Instance;
            var unmarshaller = UpdatePlacementResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePlacementRequest,UpdatePlacementResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateProject

        internal virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var marshaller = UpdateProjectRequestMarshaller.Instance;
            var unmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectRequest,UpdateProjectResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot1click-projects-2018-05-14/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateProjectRequestMarshaller.Instance;
            var unmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProjectRequest,UpdateProjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}