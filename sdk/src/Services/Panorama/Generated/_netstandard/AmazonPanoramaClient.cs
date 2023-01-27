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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Panorama.Model;
using Amazon.Panorama.Model.Internal.MarshallTransformations;
using Amazon.Panorama.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Panorama
{
    /// <summary>
    /// Implementation for accessing Panorama
    ///
    /// AWS Panorama 
    /// <para>
    ///  <b>Overview</b> 
    /// 
    ///  
    /// <para>
    /// This is the <i>AWS Panorama API Reference</i>. For an introduction to the service,
    /// see <a href="https://docs.aws.amazon.com/panorama/latest/dev/panorama-welcome.html">What
    /// is AWS Panorama?</a> in the <i>AWS Panorama Developer Guide</i>.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonPanoramaClient : AmazonServiceClient, IAmazonPanorama
    {
        private static IServiceMetadata serviceMetadata = new AmazonPanoramaMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonPanoramaClient with the credentials loaded from the application's
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
        public AmazonPanoramaClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPanoramaConfig()) { }

        /// <summary>
        /// Constructs AmazonPanoramaClient with the credentials loaded from the application's
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
        public AmazonPanoramaClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPanoramaConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPanoramaClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPanoramaClient Configuration Object</param>
        public AmazonPanoramaClient(AmazonPanoramaConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonPanoramaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPanoramaClient(AWSCredentials credentials)
            : this(credentials, new AmazonPanoramaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPanoramaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPanoramaClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPanoramaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPanoramaClient with AWS Credentials and an
        /// AmazonPanoramaClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPanoramaClient Configuration Object</param>
        public AmazonPanoramaClient(AWSCredentials credentials, AmazonPanoramaConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPanoramaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPanoramaClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPanoramaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPanoramaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPanoramaClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPanoramaConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPanoramaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPanoramaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPanoramaClient Configuration Object</param>
        public AmazonPanoramaClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPanoramaConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPanoramaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPanoramaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPanoramaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPanoramaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPanoramaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPanoramaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPanoramaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPanoramaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPanoramaClient Configuration Object</param>
        public AmazonPanoramaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPanoramaConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IPanoramaPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPanoramaPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PanoramaPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPanoramaEndpointResolver());
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


        #region  CreateApplicationInstance

        internal virtual CreateApplicationInstanceResponse CreateApplicationInstance(CreateApplicationInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationInstanceResponse>(request, options);
        }



        /// <summary>
        /// Creates an application instance and deploys it to a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplicationInstance service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ServiceQuotaExceededException">
        /// The request would cause a limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateApplicationInstance">REST API Reference for CreateApplicationInstance Operation</seealso>
        public virtual Task<CreateApplicationInstanceResponse> CreateApplicationInstanceAsync(CreateApplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateJobForDevices

        internal virtual CreateJobForDevicesResponse CreateJobForDevices(CreateJobForDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobForDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobForDevicesResponseUnmarshaller.Instance;

            return Invoke<CreateJobForDevicesResponse>(request, options);
        }



        /// <summary>
        /// Creates a job to run on a device. A job can update a device's software or reboot it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJobForDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJobForDevices service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateJobForDevices">REST API Reference for CreateJobForDevices Operation</seealso>
        public virtual Task<CreateJobForDevicesResponse> CreateJobForDevicesAsync(CreateJobForDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobForDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobForDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<CreateJobForDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNodeFromTemplateJob

        internal virtual CreateNodeFromTemplateJobResponse CreateNodeFromTemplateJob(CreateNodeFromTemplateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNodeFromTemplateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNodeFromTemplateJobResponseUnmarshaller.Instance;

            return Invoke<CreateNodeFromTemplateJobResponse>(request, options);
        }



        /// <summary>
        /// Creates a camera stream node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNodeFromTemplateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNodeFromTemplateJob service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateNodeFromTemplateJob">REST API Reference for CreateNodeFromTemplateJob Operation</seealso>
        public virtual Task<CreateNodeFromTemplateJobResponse> CreateNodeFromTemplateJobAsync(CreateNodeFromTemplateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNodeFromTemplateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNodeFromTemplateJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNodeFromTemplateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePackage

        internal virtual CreatePackageResponse CreatePackage(CreatePackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackageResponseUnmarshaller.Instance;

            return Invoke<CreatePackageResponse>(request, options);
        }



        /// <summary>
        /// Creates a package and storage location in an Amazon S3 access point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePackage service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        public virtual Task<CreatePackageResponse> CreatePackageAsync(CreatePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackageResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePackageImportJob

        internal virtual CreatePackageImportJobResponse CreatePackageImportJob(CreatePackageImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePackageImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackageImportJobResponseUnmarshaller.Instance;

            return Invoke<CreatePackageImportJobResponse>(request, options);
        }



        /// <summary>
        /// Imports a node package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackageImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePackageImportJob service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreatePackageImportJob">REST API Reference for CreatePackageImportJob Operation</seealso>
        public virtual Task<CreatePackageImportJobResponse> CreatePackageImportJobAsync(CreatePackageImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePackageImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackageImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePackageImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDevice

        internal virtual DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteDeviceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDevice service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        public virtual Task<DeleteDeviceResponse> DeleteDeviceAsync(DeleteDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePackage

        internal virtual DeletePackageResponse DeletePackage(DeletePackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackageResponseUnmarshaller.Instance;

            return Invoke<DeletePackageResponse>(request, options);
        }



        /// <summary>
        /// Deletes a package.
        /// 
        ///  <note> 
        /// <para>
        /// To delete a package, you need permission to call <code>s3:DeleteObject</code> in addition
        /// to permissions for the AWS Panorama API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePackage service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        public virtual Task<DeletePackageResponse> DeletePackageAsync(DeletePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackageResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterPackageVersion

        internal virtual DeregisterPackageVersionResponse DeregisterPackageVersion(DeregisterPackageVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterPackageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterPackageVersionResponseUnmarshaller.Instance;

            return Invoke<DeregisterPackageVersionResponse>(request, options);
        }



        /// <summary>
        /// Deregisters a package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterPackageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterPackageVersion service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeregisterPackageVersion">REST API Reference for DeregisterPackageVersion Operation</seealso>
        public virtual Task<DeregisterPackageVersionResponse> DeregisterPackageVersionAsync(DeregisterPackageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterPackageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterPackageVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterPackageVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplicationInstance

        internal virtual DescribeApplicationInstanceResponse DescribeApplicationInstance(DescribeApplicationInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationInstanceResponse>(request, options);
        }



        /// <summary>
        /// Returns information about an application instance on a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplicationInstance service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeApplicationInstance">REST API Reference for DescribeApplicationInstance Operation</seealso>
        public virtual Task<DescribeApplicationInstanceResponse> DescribeApplicationInstanceAsync(DescribeApplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplicationInstanceDetails

        internal virtual DescribeApplicationInstanceDetailsResponse DescribeApplicationInstanceDetails(DescribeApplicationInstanceDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationInstanceDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationInstanceDetailsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationInstanceDetailsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about an application instance's configuration manifest.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationInstanceDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplicationInstanceDetails service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeApplicationInstanceDetails">REST API Reference for DescribeApplicationInstanceDetails Operation</seealso>
        public virtual Task<DescribeApplicationInstanceDetailsResponse> DescribeApplicationInstanceDetailsAsync(DescribeApplicationInstanceDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationInstanceDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationInstanceDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationInstanceDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDevice

        internal virtual DescribeDeviceResponse DescribeDevice(DescribeDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return Invoke<DescribeDeviceResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDevice service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        public virtual Task<DescribeDeviceResponse> DescribeDeviceAsync(DescribeDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDeviceJob

        internal virtual DescribeDeviceJobResponse DescribeDeviceJob(DescribeDeviceJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDeviceJobResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a device job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeviceJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeviceJob service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeDeviceJob">REST API Reference for DescribeDeviceJob Operation</seealso>
        public virtual Task<DescribeDeviceJobResponse> DescribeDeviceJobAsync(DescribeDeviceJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDeviceJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNode

        internal virtual DescribeNodeResponse DescribeNode(DescribeNodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodeResponseUnmarshaller.Instance;

            return Invoke<DescribeNodeResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNode service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeNode">REST API Reference for DescribeNode Operation</seealso>
        public virtual Task<DescribeNodeResponse> DescribeNodeAsync(DescribeNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNodeFromTemplateJob

        internal virtual DescribeNodeFromTemplateJobResponse DescribeNodeFromTemplateJob(DescribeNodeFromTemplateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodeFromTemplateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodeFromTemplateJobResponseUnmarshaller.Instance;

            return Invoke<DescribeNodeFromTemplateJobResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a job to create a camera stream node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeFromTemplateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNodeFromTemplateJob service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeNodeFromTemplateJob">REST API Reference for DescribeNodeFromTemplateJob Operation</seealso>
        public virtual Task<DescribeNodeFromTemplateJobResponse> DescribeNodeFromTemplateJobAsync(DescribeNodeFromTemplateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodeFromTemplateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodeFromTemplateJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNodeFromTemplateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePackage

        internal virtual DescribePackageResponse DescribePackage(DescribePackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageResponseUnmarshaller.Instance;

            return Invoke<DescribePackageResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePackage service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackage">REST API Reference for DescribePackage Operation</seealso>
        public virtual Task<DescribePackageResponse> DescribePackageAsync(DescribePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePackageImportJob

        internal virtual DescribePackageImportJobResponse DescribePackageImportJob(DescribePackageImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribePackageImportJobResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a package import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePackageImportJob service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackageImportJob">REST API Reference for DescribePackageImportJob Operation</seealso>
        public virtual Task<DescribePackageImportJobResponse> DescribePackageImportJobAsync(DescribePackageImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePackageImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePackageVersion

        internal virtual DescribePackageVersionResponse DescribePackageVersion(DescribePackageVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageVersionResponseUnmarshaller.Instance;

            return Invoke<DescribePackageVersionResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePackageVersion service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackageVersion">REST API Reference for DescribePackageVersion Operation</seealso>
        public virtual Task<DescribePackageVersionResponse> DescribePackageVersionAsync(DescribePackageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePackageVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplicationInstanceDependencies

        internal virtual ListApplicationInstanceDependenciesResponse ListApplicationInstanceDependencies(ListApplicationInstanceDependenciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationInstanceDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationInstanceDependenciesResponseUnmarshaller.Instance;

            return Invoke<ListApplicationInstanceDependenciesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of application instance dependencies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstanceDependencies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationInstanceDependencies service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceDependencies">REST API Reference for ListApplicationInstanceDependencies Operation</seealso>
        public virtual Task<ListApplicationInstanceDependenciesResponse> ListApplicationInstanceDependenciesAsync(ListApplicationInstanceDependenciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationInstanceDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationInstanceDependenciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationInstanceDependenciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplicationInstanceNodeInstances

        internal virtual ListApplicationInstanceNodeInstancesResponse ListApplicationInstanceNodeInstances(ListApplicationInstanceNodeInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationInstanceNodeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationInstanceNodeInstancesResponseUnmarshaller.Instance;

            return Invoke<ListApplicationInstanceNodeInstancesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of application node instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstanceNodeInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationInstanceNodeInstances service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceNodeInstances">REST API Reference for ListApplicationInstanceNodeInstances Operation</seealso>
        public virtual Task<ListApplicationInstanceNodeInstancesResponse> ListApplicationInstanceNodeInstancesAsync(ListApplicationInstanceNodeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationInstanceNodeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationInstanceNodeInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationInstanceNodeInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplicationInstances

        internal virtual ListApplicationInstancesResponse ListApplicationInstances(ListApplicationInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationInstancesResponseUnmarshaller.Instance;

            return Invoke<ListApplicationInstancesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of application instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationInstances service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstances">REST API Reference for ListApplicationInstances Operation</seealso>
        public virtual Task<ListApplicationInstancesResponse> ListApplicationInstancesAsync(ListApplicationInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDevices

        internal virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDevicesJobs

        internal virtual ListDevicesJobsResponse ListDevicesJobs(ListDevicesJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesJobsResponseUnmarshaller.Instance;

            return Invoke<ListDevicesJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicesJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDevicesJobs service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListDevicesJobs">REST API Reference for ListDevicesJobs Operation</seealso>
        public virtual Task<ListDevicesJobsResponse> ListDevicesJobsAsync(ListDevicesJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevicesJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNodeFromTemplateJobs

        internal virtual ListNodeFromTemplateJobsResponse ListNodeFromTemplateJobs(ListNodeFromTemplateJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNodeFromTemplateJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodeFromTemplateJobsResponseUnmarshaller.Instance;

            return Invoke<ListNodeFromTemplateJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of camera stream node jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodeFromTemplateJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNodeFromTemplateJobs service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListNodeFromTemplateJobs">REST API Reference for ListNodeFromTemplateJobs Operation</seealso>
        public virtual Task<ListNodeFromTemplateJobsResponse> ListNodeFromTemplateJobsAsync(ListNodeFromTemplateJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNodeFromTemplateJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodeFromTemplateJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListNodeFromTemplateJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNodes

        internal virtual ListNodesResponse ListNodes(ListNodesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodesResponseUnmarshaller.Instance;

            return Invoke<ListNodesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNodes service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListNodes">REST API Reference for ListNodes Operation</seealso>
        public virtual Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodesResponseUnmarshaller.Instance;

            return InvokeAsync<ListNodesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPackageImportJobs

        internal virtual ListPackageImportJobsResponse ListPackageImportJobs(ListPackageImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackageImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackageImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListPackageImportJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of package import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackageImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPackageImportJobs service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListPackageImportJobs">REST API Reference for ListPackageImportJobs Operation</seealso>
        public virtual Task<ListPackageImportJobsResponse> ListPackageImportJobsAsync(ListPackageImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackageImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackageImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPackageImportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPackages

        internal virtual ListPackagesResponse ListPackages(ListPackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagesResponseUnmarshaller.Instance;

            return Invoke<ListPackagesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPackages service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListPackages">REST API Reference for ListPackages Operation</seealso>
        public virtual Task<ListPackagesResponse> ListPackagesAsync(ListPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPackagesResponse>(request, options, cancellationToken);
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
        /// Returns a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ProvisionDevice

        internal virtual ProvisionDeviceResponse ProvisionDevice(ProvisionDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionDeviceResponseUnmarshaller.Instance;

            return Invoke<ProvisionDeviceResponse>(request, options);
        }



        /// <summary>
        /// Creates a device and returns a configuration archive. The configuration archive is
        /// a ZIP file that contains a provisioning certificate that is valid for 5 minutes. Name
        /// the configuration archive <code>certificates-omni_<i>device-name</i>.zip</code> and
        /// transfer it to the device within 5 minutes. Use the included USB storage device and
        /// connect it to the USB 3.0 port next to the HDMI output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ProvisionDevice service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ServiceQuotaExceededException">
        /// The request would cause a limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ProvisionDevice">REST API Reference for ProvisionDevice Operation</seealso>
        public virtual Task<ProvisionDeviceResponse> ProvisionDeviceAsync(ProvisionDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<ProvisionDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterPackageVersion

        internal virtual RegisterPackageVersionResponse RegisterPackageVersion(RegisterPackageVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterPackageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterPackageVersionResponseUnmarshaller.Instance;

            return Invoke<RegisterPackageVersionResponse>(request, options);
        }



        /// <summary>
        /// Registers a package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterPackageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterPackageVersion service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/RegisterPackageVersion">REST API Reference for RegisterPackageVersion Operation</seealso>
        public virtual Task<RegisterPackageVersionResponse> RegisterPackageVersionAsync(RegisterPackageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterPackageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterPackageVersionResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterPackageVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveApplicationInstance

        internal virtual RemoveApplicationInstanceResponse RemoveApplicationInstance(RemoveApplicationInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveApplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveApplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<RemoveApplicationInstanceResponse>(request, options);
        }



        /// <summary>
        /// Removes an application instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveApplicationInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveApplicationInstance service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/RemoveApplicationInstance">REST API Reference for RemoveApplicationInstance Operation</seealso>
        public virtual Task<RemoveApplicationInstanceResponse> RemoveApplicationInstanceAsync(RemoveApplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveApplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveApplicationInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveApplicationInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SignalApplicationInstanceNodeInstances

        internal virtual SignalApplicationInstanceNodeInstancesResponse SignalApplicationInstanceNodeInstances(SignalApplicationInstanceNodeInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignalApplicationInstanceNodeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignalApplicationInstanceNodeInstancesResponseUnmarshaller.Instance;

            return Invoke<SignalApplicationInstanceNodeInstancesResponse>(request, options);
        }



        /// <summary>
        /// Signal camera nodes to stop or resume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignalApplicationInstanceNodeInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SignalApplicationInstanceNodeInstances service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ServiceQuotaExceededException">
        /// The request would cause a limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/SignalApplicationInstanceNodeInstances">REST API Reference for SignalApplicationInstanceNodeInstances Operation</seealso>
        public virtual Task<SignalApplicationInstanceNodeInstancesResponse> SignalApplicationInstanceNodeInstancesAsync(SignalApplicationInstanceNodeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignalApplicationInstanceNodeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignalApplicationInstanceNodeInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<SignalApplicationInstanceNodeInstancesResponse>(request, options, cancellationToken);
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
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDeviceMetadata

        internal virtual UpdateDeviceMetadataResponse UpdateDeviceMetadata(UpdateDeviceMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceMetadataResponse>(request, options);
        }



        /// <summary>
        /// Updates a device's metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDeviceMetadata service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/UpdateDeviceMetadata">REST API Reference for UpdateDeviceMetadata Operation</seealso>
        public virtual Task<UpdateDeviceMetadataResponse> UpdateDeviceMetadataAsync(UpdateDeviceMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeviceMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}