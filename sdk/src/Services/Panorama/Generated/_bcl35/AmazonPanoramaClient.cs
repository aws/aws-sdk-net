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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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

        /// <summary>
        /// Creates an application instance and deploys it to a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationInstance service method.</param>
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
        public virtual CreateApplicationInstanceResponse CreateApplicationInstance(CreateApplicationInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationInstance operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplicationInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateApplicationInstance">REST API Reference for CreateApplicationInstance Operation</seealso>
        public virtual IAsyncResult BeginCreateApplicationInstance(CreateApplicationInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplicationInstance.</param>
        /// 
        /// <returns>Returns a  CreateApplicationInstanceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateApplicationInstance">REST API Reference for CreateApplicationInstance Operation</seealso>
        public virtual CreateApplicationInstanceResponse EndCreateApplicationInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApplicationInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateJobForDevices

        /// <summary>
        /// Creates a job to run on a device. A job can update a device's software or reboot it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJobForDevices service method.</param>
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
        public virtual CreateJobForDevicesResponse CreateJobForDevices(CreateJobForDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobForDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobForDevicesResponseUnmarshaller.Instance;

            return Invoke<CreateJobForDevicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJobForDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJobForDevices operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJobForDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateJobForDevices">REST API Reference for CreateJobForDevices Operation</seealso>
        public virtual IAsyncResult BeginCreateJobForDevices(CreateJobForDevicesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobForDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobForDevicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJobForDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJobForDevices.</param>
        /// 
        /// <returns>Returns a  CreateJobForDevicesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateJobForDevices">REST API Reference for CreateJobForDevices Operation</seealso>
        public virtual CreateJobForDevicesResponse EndCreateJobForDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateJobForDevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNodeFromTemplateJob

        /// <summary>
        /// Creates a camera stream node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNodeFromTemplateJob service method.</param>
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
        public virtual CreateNodeFromTemplateJobResponse CreateNodeFromTemplateJob(CreateNodeFromTemplateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNodeFromTemplateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNodeFromTemplateJobResponseUnmarshaller.Instance;

            return Invoke<CreateNodeFromTemplateJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNodeFromTemplateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNodeFromTemplateJob operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNodeFromTemplateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateNodeFromTemplateJob">REST API Reference for CreateNodeFromTemplateJob Operation</seealso>
        public virtual IAsyncResult BeginCreateNodeFromTemplateJob(CreateNodeFromTemplateJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNodeFromTemplateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNodeFromTemplateJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNodeFromTemplateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNodeFromTemplateJob.</param>
        /// 
        /// <returns>Returns a  CreateNodeFromTemplateJobResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateNodeFromTemplateJob">REST API Reference for CreateNodeFromTemplateJob Operation</seealso>
        public virtual CreateNodeFromTemplateJobResponse EndCreateNodeFromTemplateJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNodeFromTemplateJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePackage

        /// <summary>
        /// Creates a package and storage location in an Amazon S3 access point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackage service method.</param>
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
        public virtual CreatePackageResponse CreatePackage(CreatePackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackageResponseUnmarshaller.Instance;

            return Invoke<CreatePackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePackage operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        public virtual IAsyncResult BeginCreatePackage(CreatePackageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePackage.</param>
        /// 
        /// <returns>Returns a  CreatePackageResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        public virtual CreatePackageResponse EndCreatePackage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePackageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePackageImportJob

        /// <summary>
        /// Imports a node package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackageImportJob service method.</param>
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
        public virtual CreatePackageImportJobResponse CreatePackageImportJob(CreatePackageImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePackageImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackageImportJobResponseUnmarshaller.Instance;

            return Invoke<CreatePackageImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePackageImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePackageImportJob operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePackageImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreatePackageImportJob">REST API Reference for CreatePackageImportJob Operation</seealso>
        public virtual IAsyncResult BeginCreatePackageImportJob(CreatePackageImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePackageImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackageImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePackageImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePackageImportJob.</param>
        /// 
        /// <returns>Returns a  CreatePackageImportJobResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreatePackageImportJob">REST API Reference for CreatePackageImportJob Operation</seealso>
        public virtual CreatePackageImportJobResponse EndCreatePackageImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePackageImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDevice

        /// <summary>
        /// Deletes a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice service method.</param>
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
        public virtual DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        public virtual IAsyncResult BeginDeleteDevice(DeleteDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDevice.</param>
        /// 
        /// <returns>Returns a  DeleteDeviceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        public virtual DeleteDeviceResponse EndDeleteDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePackage

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
        public virtual DeletePackageResponse DeletePackage(DeletePackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackageResponseUnmarshaller.Instance;

            return Invoke<DeletePackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePackage operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        public virtual IAsyncResult BeginDeletePackage(DeletePackageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePackage.</param>
        /// 
        /// <returns>Returns a  DeletePackageResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        public virtual DeletePackageResponse EndDeletePackage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePackageResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterPackageVersion

        /// <summary>
        /// Deregisters a package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterPackageVersion service method.</param>
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
        public virtual DeregisterPackageVersionResponse DeregisterPackageVersion(DeregisterPackageVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterPackageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterPackageVersionResponseUnmarshaller.Instance;

            return Invoke<DeregisterPackageVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterPackageVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterPackageVersion operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterPackageVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeregisterPackageVersion">REST API Reference for DeregisterPackageVersion Operation</seealso>
        public virtual IAsyncResult BeginDeregisterPackageVersion(DeregisterPackageVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterPackageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterPackageVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterPackageVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterPackageVersion.</param>
        /// 
        /// <returns>Returns a  DeregisterPackageVersionResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeregisterPackageVersion">REST API Reference for DeregisterPackageVersion Operation</seealso>
        public virtual DeregisterPackageVersionResponse EndDeregisterPackageVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterPackageVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApplicationInstance

        /// <summary>
        /// Returns information about an application instance on a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationInstance service method.</param>
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
        public virtual DescribeApplicationInstanceResponse DescribeApplicationInstance(DescribeApplicationInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationInstance operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicationInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeApplicationInstance">REST API Reference for DescribeApplicationInstance Operation</seealso>
        public virtual IAsyncResult BeginDescribeApplicationInstance(DescribeApplicationInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationInstance.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationInstanceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeApplicationInstance">REST API Reference for DescribeApplicationInstance Operation</seealso>
        public virtual DescribeApplicationInstanceResponse EndDescribeApplicationInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeApplicationInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApplicationInstanceDetails

        /// <summary>
        /// Returns information about an application instance's configuration manifest.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationInstanceDetails service method.</param>
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
        public virtual DescribeApplicationInstanceDetailsResponse DescribeApplicationInstanceDetails(DescribeApplicationInstanceDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationInstanceDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationInstanceDetailsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationInstanceDetailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationInstanceDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationInstanceDetails operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicationInstanceDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeApplicationInstanceDetails">REST API Reference for DescribeApplicationInstanceDetails Operation</seealso>
        public virtual IAsyncResult BeginDescribeApplicationInstanceDetails(DescribeApplicationInstanceDetailsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationInstanceDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationInstanceDetailsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationInstanceDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationInstanceDetails.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationInstanceDetailsResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeApplicationInstanceDetails">REST API Reference for DescribeApplicationInstanceDetails Operation</seealso>
        public virtual DescribeApplicationInstanceDetailsResponse EndDescribeApplicationInstanceDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeApplicationInstanceDetailsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDevice

        /// <summary>
        /// Returns information about a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice service method.</param>
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
        public virtual DescribeDeviceResponse DescribeDevice(DescribeDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return Invoke<DescribeDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        public virtual IAsyncResult BeginDescribeDevice(DescribeDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDevice.</param>
        /// 
        /// <returns>Returns a  DescribeDeviceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        public virtual DescribeDeviceResponse EndDescribeDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDeviceJob

        /// <summary>
        /// Returns information about a device job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeviceJob service method.</param>
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
        public virtual DescribeDeviceJobResponse DescribeDeviceJob(DescribeDeviceJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDeviceJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeviceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeviceJob operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeviceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeDeviceJob">REST API Reference for DescribeDeviceJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeDeviceJob(DescribeDeviceJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeviceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeviceJob.</param>
        /// 
        /// <returns>Returns a  DescribeDeviceJobResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeDeviceJob">REST API Reference for DescribeDeviceJob Operation</seealso>
        public virtual DescribeDeviceJobResponse EndDescribeDeviceJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDeviceJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNode

        /// <summary>
        /// Returns information about a node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNode service method.</param>
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
        public virtual DescribeNodeResponse DescribeNode(DescribeNodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodeResponseUnmarshaller.Instance;

            return Invoke<DescribeNodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNode operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeNode">REST API Reference for DescribeNode Operation</seealso>
        public virtual IAsyncResult BeginDescribeNode(DescribeNodeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNode.</param>
        /// 
        /// <returns>Returns a  DescribeNodeResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeNode">REST API Reference for DescribeNode Operation</seealso>
        public virtual DescribeNodeResponse EndDescribeNode(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNodeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNodeFromTemplateJob

        /// <summary>
        /// Returns information about a job to create a camera stream node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeFromTemplateJob service method.</param>
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
        public virtual DescribeNodeFromTemplateJobResponse DescribeNodeFromTemplateJob(DescribeNodeFromTemplateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodeFromTemplateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodeFromTemplateJobResponseUnmarshaller.Instance;

            return Invoke<DescribeNodeFromTemplateJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNodeFromTemplateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeFromTemplateJob operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNodeFromTemplateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeNodeFromTemplateJob">REST API Reference for DescribeNodeFromTemplateJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeNodeFromTemplateJob(DescribeNodeFromTemplateJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodeFromTemplateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodeFromTemplateJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNodeFromTemplateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNodeFromTemplateJob.</param>
        /// 
        /// <returns>Returns a  DescribeNodeFromTemplateJobResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeNodeFromTemplateJob">REST API Reference for DescribeNodeFromTemplateJob Operation</seealso>
        public virtual DescribeNodeFromTemplateJobResponse EndDescribeNodeFromTemplateJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNodeFromTemplateJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePackage

        /// <summary>
        /// Returns information about a package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackage service method.</param>
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
        public virtual DescribePackageResponse DescribePackage(DescribePackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageResponseUnmarshaller.Instance;

            return Invoke<DescribePackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackage operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackage">REST API Reference for DescribePackage Operation</seealso>
        public virtual IAsyncResult BeginDescribePackage(DescribePackageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePackage.</param>
        /// 
        /// <returns>Returns a  DescribePackageResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackage">REST API Reference for DescribePackage Operation</seealso>
        public virtual DescribePackageResponse EndDescribePackage(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePackageResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePackageImportJob

        /// <summary>
        /// Returns information about a package import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageImportJob service method.</param>
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
        public virtual DescribePackageImportJobResponse DescribePackageImportJob(DescribePackageImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribePackageImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackageImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageImportJob operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePackageImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackageImportJob">REST API Reference for DescribePackageImportJob Operation</seealso>
        public virtual IAsyncResult BeginDescribePackageImportJob(DescribePackageImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePackageImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePackageImportJob.</param>
        /// 
        /// <returns>Returns a  DescribePackageImportJobResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackageImportJob">REST API Reference for DescribePackageImportJob Operation</seealso>
        public virtual DescribePackageImportJobResponse EndDescribePackageImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePackageImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePackageVersion

        /// <summary>
        /// Returns information about a package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageVersion service method.</param>
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
        public virtual DescribePackageVersionResponse DescribePackageVersion(DescribePackageVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageVersionResponseUnmarshaller.Instance;

            return Invoke<DescribePackageVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackageVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageVersion operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePackageVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackageVersion">REST API Reference for DescribePackageVersion Operation</seealso>
        public virtual IAsyncResult BeginDescribePackageVersion(DescribePackageVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackageVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePackageVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePackageVersion.</param>
        /// 
        /// <returns>Returns a  DescribePackageVersionResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackageVersion">REST API Reference for DescribePackageVersion Operation</seealso>
        public virtual DescribePackageVersionResponse EndDescribePackageVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePackageVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplicationInstanceDependencies

        /// <summary>
        /// Returns a list of application instance dependencies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstanceDependencies service method.</param>
        /// 
        /// <returns>The response from the ListApplicationInstanceDependencies service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceDependencies">REST API Reference for ListApplicationInstanceDependencies Operation</seealso>
        public virtual ListApplicationInstanceDependenciesResponse ListApplicationInstanceDependencies(ListApplicationInstanceDependenciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationInstanceDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationInstanceDependenciesResponseUnmarshaller.Instance;

            return Invoke<ListApplicationInstanceDependenciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationInstanceDependencies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstanceDependencies operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationInstanceDependencies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceDependencies">REST API Reference for ListApplicationInstanceDependencies Operation</seealso>
        public virtual IAsyncResult BeginListApplicationInstanceDependencies(ListApplicationInstanceDependenciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationInstanceDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationInstanceDependenciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationInstanceDependencies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationInstanceDependencies.</param>
        /// 
        /// <returns>Returns a  ListApplicationInstanceDependenciesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceDependencies">REST API Reference for ListApplicationInstanceDependencies Operation</seealso>
        public virtual ListApplicationInstanceDependenciesResponse EndListApplicationInstanceDependencies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationInstanceDependenciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplicationInstanceNodeInstances

        /// <summary>
        /// Returns a list of application node instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstanceNodeInstances service method.</param>
        /// 
        /// <returns>The response from the ListApplicationInstanceNodeInstances service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceNodeInstances">REST API Reference for ListApplicationInstanceNodeInstances Operation</seealso>
        public virtual ListApplicationInstanceNodeInstancesResponse ListApplicationInstanceNodeInstances(ListApplicationInstanceNodeInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationInstanceNodeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationInstanceNodeInstancesResponseUnmarshaller.Instance;

            return Invoke<ListApplicationInstanceNodeInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationInstanceNodeInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstanceNodeInstances operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationInstanceNodeInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceNodeInstances">REST API Reference for ListApplicationInstanceNodeInstances Operation</seealso>
        public virtual IAsyncResult BeginListApplicationInstanceNodeInstances(ListApplicationInstanceNodeInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationInstanceNodeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationInstanceNodeInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationInstanceNodeInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationInstanceNodeInstances.</param>
        /// 
        /// <returns>Returns a  ListApplicationInstanceNodeInstancesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceNodeInstances">REST API Reference for ListApplicationInstanceNodeInstances Operation</seealso>
        public virtual ListApplicationInstanceNodeInstancesResponse EndListApplicationInstanceNodeInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationInstanceNodeInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplicationInstances

        /// <summary>
        /// Returns a list of application instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstances service method.</param>
        /// 
        /// <returns>The response from the ListApplicationInstances service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstances">REST API Reference for ListApplicationInstances Operation</seealso>
        public virtual ListApplicationInstancesResponse ListApplicationInstances(ListApplicationInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationInstancesResponseUnmarshaller.Instance;

            return Invoke<ListApplicationInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstances operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstances">REST API Reference for ListApplicationInstances Operation</seealso>
        public virtual IAsyncResult BeginListApplicationInstances(ListApplicationInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationInstances.</param>
        /// 
        /// <returns>Returns a  ListApplicationInstancesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstances">REST API Reference for ListApplicationInstances Operation</seealso>
        public virtual ListApplicationInstancesResponse EndListApplicationInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDevices

        /// <summary>
        /// Returns a list of devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
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
        public virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual IAsyncResult BeginListDevices(ListDevicesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevices.</param>
        /// 
        /// <returns>Returns a  ListDevicesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual ListDevicesResponse EndListDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDevicesJobs

        /// <summary>
        /// Returns a list of jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicesJobs service method.</param>
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
        public virtual ListDevicesJobsResponse ListDevicesJobs(ListDevicesJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesJobsResponseUnmarshaller.Instance;

            return Invoke<ListDevicesJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevicesJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevicesJobs operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevicesJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListDevicesJobs">REST API Reference for ListDevicesJobs Operation</seealso>
        public virtual IAsyncResult BeginListDevicesJobs(ListDevicesJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevicesJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevicesJobs.</param>
        /// 
        /// <returns>Returns a  ListDevicesJobsResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListDevicesJobs">REST API Reference for ListDevicesJobs Operation</seealso>
        public virtual ListDevicesJobsResponse EndListDevicesJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDevicesJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNodeFromTemplateJobs

        /// <summary>
        /// Returns a list of camera stream node jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodeFromTemplateJobs service method.</param>
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
        public virtual ListNodeFromTemplateJobsResponse ListNodeFromTemplateJobs(ListNodeFromTemplateJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNodeFromTemplateJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodeFromTemplateJobsResponseUnmarshaller.Instance;

            return Invoke<ListNodeFromTemplateJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNodeFromTemplateJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNodeFromTemplateJobs operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNodeFromTemplateJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListNodeFromTemplateJobs">REST API Reference for ListNodeFromTemplateJobs Operation</seealso>
        public virtual IAsyncResult BeginListNodeFromTemplateJobs(ListNodeFromTemplateJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNodeFromTemplateJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodeFromTemplateJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNodeFromTemplateJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNodeFromTemplateJobs.</param>
        /// 
        /// <returns>Returns a  ListNodeFromTemplateJobsResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListNodeFromTemplateJobs">REST API Reference for ListNodeFromTemplateJobs Operation</seealso>
        public virtual ListNodeFromTemplateJobsResponse EndListNodeFromTemplateJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNodeFromTemplateJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNodes

        /// <summary>
        /// Returns a list of nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodes service method.</param>
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
        public virtual ListNodesResponse ListNodes(ListNodesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodesResponseUnmarshaller.Instance;

            return Invoke<ListNodesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNodes operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListNodes">REST API Reference for ListNodes Operation</seealso>
        public virtual IAsyncResult BeginListNodes(ListNodesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNodesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNodes.</param>
        /// 
        /// <returns>Returns a  ListNodesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListNodes">REST API Reference for ListNodes Operation</seealso>
        public virtual ListNodesResponse EndListNodes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNodesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPackageImportJobs

        /// <summary>
        /// Returns a list of package import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackageImportJobs service method.</param>
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
        public virtual ListPackageImportJobsResponse ListPackageImportJobs(ListPackageImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackageImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackageImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListPackageImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPackageImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackageImportJobs operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPackageImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListPackageImportJobs">REST API Reference for ListPackageImportJobs Operation</seealso>
        public virtual IAsyncResult BeginListPackageImportJobs(ListPackageImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackageImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackageImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPackageImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPackageImportJobs.</param>
        /// 
        /// <returns>Returns a  ListPackageImportJobsResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListPackageImportJobs">REST API Reference for ListPackageImportJobs Operation</seealso>
        public virtual ListPackageImportJobsResponse EndListPackageImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPackageImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPackages

        /// <summary>
        /// Returns a list of packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackages service method.</param>
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
        public virtual ListPackagesResponse ListPackages(ListPackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagesResponseUnmarshaller.Instance;

            return Invoke<ListPackagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackages operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListPackages">REST API Reference for ListPackages Operation</seealso>
        public virtual IAsyncResult BeginListPackages(ListPackagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPackages.</param>
        /// 
        /// <returns>Returns a  ListPackagesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListPackages">REST API Reference for ListPackages Operation</seealso>
        public virtual ListPackagesResponse EndListPackages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPackagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ProvisionDevice

        /// <summary>
        /// Creates a device and returns a configuration archive. The configuration archive is
        /// a ZIP file that contains a provisioning certificate that is valid for 5 minutes. Name
        /// the configuration archive <code>certificates-omni_<i>device-name</i>.zip</code> and
        /// transfer it to the device within 5 minutes. Use the included USB storage device and
        /// connect it to the USB 3.0 port next to the HDMI output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionDevice service method.</param>
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
        public virtual ProvisionDeviceResponse ProvisionDevice(ProvisionDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionDeviceResponseUnmarshaller.Instance;

            return Invoke<ProvisionDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ProvisionDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ProvisionDevice operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndProvisionDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ProvisionDevice">REST API Reference for ProvisionDevice Operation</seealso>
        public virtual IAsyncResult BeginProvisionDevice(ProvisionDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ProvisionDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginProvisionDevice.</param>
        /// 
        /// <returns>Returns a  ProvisionDeviceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ProvisionDevice">REST API Reference for ProvisionDevice Operation</seealso>
        public virtual ProvisionDeviceResponse EndProvisionDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<ProvisionDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterPackageVersion

        /// <summary>
        /// Registers a package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterPackageVersion service method.</param>
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
        public virtual RegisterPackageVersionResponse RegisterPackageVersion(RegisterPackageVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterPackageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterPackageVersionResponseUnmarshaller.Instance;

            return Invoke<RegisterPackageVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterPackageVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterPackageVersion operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterPackageVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/RegisterPackageVersion">REST API Reference for RegisterPackageVersion Operation</seealso>
        public virtual IAsyncResult BeginRegisterPackageVersion(RegisterPackageVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterPackageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterPackageVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterPackageVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterPackageVersion.</param>
        /// 
        /// <returns>Returns a  RegisterPackageVersionResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/RegisterPackageVersion">REST API Reference for RegisterPackageVersion Operation</seealso>
        public virtual RegisterPackageVersionResponse EndRegisterPackageVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterPackageVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveApplicationInstance

        /// <summary>
        /// Removes an application instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveApplicationInstance service method.</param>
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
        public virtual RemoveApplicationInstanceResponse RemoveApplicationInstance(RemoveApplicationInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveApplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveApplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<RemoveApplicationInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveApplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveApplicationInstance operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveApplicationInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/RemoveApplicationInstance">REST API Reference for RemoveApplicationInstance Operation</seealso>
        public virtual IAsyncResult BeginRemoveApplicationInstance(RemoveApplicationInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveApplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveApplicationInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveApplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveApplicationInstance.</param>
        /// 
        /// <returns>Returns a  RemoveApplicationInstanceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/RemoveApplicationInstance">REST API Reference for RemoveApplicationInstance Operation</seealso>
        public virtual RemoveApplicationInstanceResponse EndRemoveApplicationInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveApplicationInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  SignalApplicationInstanceNodeInstances

        /// <summary>
        /// Signal camera nodes to stop or resume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignalApplicationInstanceNodeInstances service method.</param>
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
        public virtual SignalApplicationInstanceNodeInstancesResponse SignalApplicationInstanceNodeInstances(SignalApplicationInstanceNodeInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignalApplicationInstanceNodeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignalApplicationInstanceNodeInstancesResponseUnmarshaller.Instance;

            return Invoke<SignalApplicationInstanceNodeInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SignalApplicationInstanceNodeInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignalApplicationInstanceNodeInstances operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSignalApplicationInstanceNodeInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/SignalApplicationInstanceNodeInstances">REST API Reference for SignalApplicationInstanceNodeInstances Operation</seealso>
        public virtual IAsyncResult BeginSignalApplicationInstanceNodeInstances(SignalApplicationInstanceNodeInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignalApplicationInstanceNodeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignalApplicationInstanceNodeInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SignalApplicationInstanceNodeInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSignalApplicationInstanceNodeInstances.</param>
        /// 
        /// <returns>Returns a  SignalApplicationInstanceNodeInstancesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/SignalApplicationInstanceNodeInstances">REST API Reference for SignalApplicationInstanceNodeInstances Operation</seealso>
        public virtual SignalApplicationInstanceNodeInstancesResponse EndSignalApplicationInstanceNodeInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<SignalApplicationInstanceNodeInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDeviceMetadata

        /// <summary>
        /// Updates a device's metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceMetadata service method.</param>
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
        public virtual UpdateDeviceMetadataResponse UpdateDeviceMetadata(UpdateDeviceMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeviceMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceMetadata operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDeviceMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/UpdateDeviceMetadata">REST API Reference for UpdateDeviceMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateDeviceMetadata(UpdateDeviceMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeviceMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeviceMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateDeviceMetadataResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/UpdateDeviceMetadata">REST API Reference for UpdateDeviceMetadata Operation</seealso>
        public virtual UpdateDeviceMetadataResponse EndUpdateDeviceMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDeviceMetadataResponse>(asyncResult);
        }

        #endregion
        
    }
}