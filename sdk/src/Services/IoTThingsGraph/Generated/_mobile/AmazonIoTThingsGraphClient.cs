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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTThingsGraph.Model;
using Amazon.IoTThingsGraph.Model.Internal.MarshallTransformations;
using Amazon.IoTThingsGraph.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoTThingsGraph
{
    /// <summary>
    /// Implementation for accessing IoTThingsGraph
    ///
    /// AWS IoT Things Graph 
    /// <para>
    /// AWS IoT Things Graph provides an integrated set of tools that enable developers to
    /// connect devices and services that use different standards, such as units of measure
    /// and communication protocols. AWS IoT Things Graph makes it possible to build IoT applications
    /// with little to no code by connecting devices and services and defining how they interact
    /// at an abstract level.
    /// </para>
    ///  
    /// <para>
    /// For more information about how AWS IoT Things Graph works, see the <a href="https://docs.aws.amazon.com/thingsgraph/latest/ug/iot-tg-whatis.html">User
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonIoTThingsGraphClient : AmazonServiceClient, IAmazonIoTThingsGraph
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTThingsGraphMetadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with the credentials loaded from the application's
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
        public AmazonIoTThingsGraphClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTThingsGraphConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with the credentials loaded from the application's
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
        public AmazonIoTThingsGraphClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTThingsGraphConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTThingsGraphClient Configuration Object</param>
        public AmazonIoTThingsGraphClient(AmazonIoTThingsGraphConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTThingsGraphClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTThingsGraphConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTThingsGraphClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTThingsGraphConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Credentials and an
        /// AmazonIoTThingsGraphClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTThingsGraphClient Configuration Object</param>
        public AmazonIoTThingsGraphClient(AWSCredentials credentials, AmazonIoTThingsGraphConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTThingsGraphClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTThingsGraphConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTThingsGraphClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTThingsGraphConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTThingsGraphClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTThingsGraphClient Configuration Object</param>
        public AmazonIoTThingsGraphClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTThingsGraphConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTThingsGraphClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTThingsGraphConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTThingsGraphClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTThingsGraphConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTThingsGraphClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTThingsGraphClient Configuration Object</param>
        public AmazonIoTThingsGraphClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTThingsGraphConfig clientConfig)
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


        #region  AssociateEntityToThing

        internal virtual AssociateEntityToThingResponse AssociateEntityToThing(AssociateEntityToThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateEntityToThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEntityToThingResponseUnmarshaller.Instance;

            return Invoke<AssociateEntityToThingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateEntityToThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateEntityToThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/AssociateEntityToThing">REST API Reference for AssociateEntityToThing Operation</seealso>
        public virtual Task<AssociateEntityToThingResponse> AssociateEntityToThingAsync(AssociateEntityToThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateEntityToThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEntityToThingResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateEntityToThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFlowTemplate

        internal virtual CreateFlowTemplateResponse CreateFlowTemplate(CreateFlowTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateFlowTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateFlowTemplate">REST API Reference for CreateFlowTemplate Operation</seealso>
        public virtual Task<CreateFlowTemplateResponse> CreateFlowTemplateAsync(CreateFlowTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFlowTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSystemInstance

        internal virtual CreateSystemInstanceResponse CreateSystemInstance(CreateSystemInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSystemInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateSystemInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSystemInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSystemInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateSystemInstance">REST API Reference for CreateSystemInstance Operation</seealso>
        public virtual Task<CreateSystemInstanceResponse> CreateSystemInstanceAsync(CreateSystemInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSystemInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSystemInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSystemTemplate

        internal virtual CreateSystemTemplateResponse CreateSystemTemplate(CreateSystemTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSystemTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateSystemTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSystemTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateSystemTemplate">REST API Reference for CreateSystemTemplate Operation</seealso>
        public virtual Task<CreateSystemTemplateResponse> CreateSystemTemplateAsync(CreateSystemTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSystemTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSystemTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFlowTemplate

        internal virtual DeleteFlowTemplateResponse DeleteFlowTemplate(DeleteFlowTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteFlowTemplate">REST API Reference for DeleteFlowTemplate Operation</seealso>
        public virtual Task<DeleteFlowTemplateResponse> DeleteFlowTemplateAsync(DeleteFlowTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFlowTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNamespace

        internal virtual DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNamespaceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        public virtual Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSystemInstance

        internal virtual DeleteSystemInstanceResponse DeleteSystemInstance(DeleteSystemInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSystemInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteSystemInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSystemInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystemInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteSystemInstance">REST API Reference for DeleteSystemInstance Operation</seealso>
        public virtual Task<DeleteSystemInstanceResponse> DeleteSystemInstanceAsync(DeleteSystemInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSystemInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSystemInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSystemTemplate

        internal virtual DeleteSystemTemplateResponse DeleteSystemTemplate(DeleteSystemTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSystemTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteSystemTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystemTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteSystemTemplate">REST API Reference for DeleteSystemTemplate Operation</seealso>
        public virtual Task<DeleteSystemTemplateResponse> DeleteSystemTemplateAsync(DeleteSystemTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSystemTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSystemTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeploySystemInstance

        internal virtual DeploySystemInstanceResponse DeploySystemInstance(DeploySystemInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeploySystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeploySystemInstanceResponseUnmarshaller.Instance;

            return Invoke<DeploySystemInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeploySystemInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeploySystemInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeploySystemInstance">REST API Reference for DeploySystemInstance Operation</seealso>
        public virtual Task<DeploySystemInstanceResponse> DeploySystemInstanceAsync(DeploySystemInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeploySystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeploySystemInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeploySystemInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeprecateFlowTemplate

        internal virtual DeprecateFlowTemplateResponse DeprecateFlowTemplate(DeprecateFlowTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateFlowTemplateResponseUnmarshaller.Instance;

            return Invoke<DeprecateFlowTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateFlowTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeprecateFlowTemplate">REST API Reference for DeprecateFlowTemplate Operation</seealso>
        public virtual Task<DeprecateFlowTemplateResponse> DeprecateFlowTemplateAsync(DeprecateFlowTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateFlowTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeprecateFlowTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeprecateSystemTemplate

        internal virtual DeprecateSystemTemplateResponse DeprecateSystemTemplate(DeprecateSystemTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateSystemTemplateResponseUnmarshaller.Instance;

            return Invoke<DeprecateSystemTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateSystemTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeprecateSystemTemplate">REST API Reference for DeprecateSystemTemplate Operation</seealso>
        public virtual Task<DeprecateSystemTemplateResponse> DeprecateSystemTemplateAsync(DeprecateSystemTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateSystemTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeprecateSystemTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNamespace

        internal virtual DescribeNamespaceResponse DescribeNamespace(DescribeNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNamespaceResponseUnmarshaller.Instance;

            return Invoke<DescribeNamespaceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNamespace operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DescribeNamespace">REST API Reference for DescribeNamespace Operation</seealso>
        public virtual Task<DescribeNamespaceResponse> DescribeNamespaceAsync(DescribeNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DissociateEntityFromThing

        internal virtual DissociateEntityFromThingResponse DissociateEntityFromThing(DissociateEntityFromThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DissociateEntityFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DissociateEntityFromThingResponseUnmarshaller.Instance;

            return Invoke<DissociateEntityFromThingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DissociateEntityFromThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DissociateEntityFromThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DissociateEntityFromThing">REST API Reference for DissociateEntityFromThing Operation</seealso>
        public virtual Task<DissociateEntityFromThingResponse> DissociateEntityFromThingAsync(DissociateEntityFromThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DissociateEntityFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DissociateEntityFromThingResponseUnmarshaller.Instance;

            return InvokeAsync<DissociateEntityFromThingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEntities

        internal virtual GetEntitiesResponse GetEntities(GetEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEntitiesResponseUnmarshaller.Instance;

            return Invoke<GetEntitiesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEntities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetEntities">REST API Reference for GetEntities Operation</seealso>
        public virtual Task<GetEntitiesResponse> GetEntitiesAsync(GetEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEntitiesResponseUnmarshaller.Instance;

            return InvokeAsync<GetEntitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFlowTemplate

        internal virtual GetFlowTemplateResponse GetFlowTemplate(GetFlowTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowTemplateResponseUnmarshaller.Instance;

            return Invoke<GetFlowTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFlowTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetFlowTemplate">REST API Reference for GetFlowTemplate Operation</seealso>
        public virtual Task<GetFlowTemplateResponse> GetFlowTemplateAsync(GetFlowTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetFlowTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFlowTemplateRevisions

        internal virtual GetFlowTemplateRevisionsResponse GetFlowTemplateRevisions(GetFlowTemplateRevisionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFlowTemplateRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowTemplateRevisionsResponseUnmarshaller.Instance;

            return Invoke<GetFlowTemplateRevisionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFlowTemplateRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFlowTemplateRevisions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetFlowTemplateRevisions">REST API Reference for GetFlowTemplateRevisions Operation</seealso>
        public virtual Task<GetFlowTemplateRevisionsResponse> GetFlowTemplateRevisionsAsync(GetFlowTemplateRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFlowTemplateRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowTemplateRevisionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetFlowTemplateRevisionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNamespaceDeletionStatus

        internal virtual GetNamespaceDeletionStatusResponse GetNamespaceDeletionStatus(GetNamespaceDeletionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNamespaceDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceDeletionStatusResponseUnmarshaller.Instance;

            return Invoke<GetNamespaceDeletionStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetNamespaceDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNamespaceDeletionStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetNamespaceDeletionStatus">REST API Reference for GetNamespaceDeletionStatus Operation</seealso>
        public virtual Task<GetNamespaceDeletionStatusResponse> GetNamespaceDeletionStatusAsync(GetNamespaceDeletionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNamespaceDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceDeletionStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetNamespaceDeletionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSystemInstance

        internal virtual GetSystemInstanceResponse GetSystemInstance(GetSystemInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemInstanceResponseUnmarshaller.Instance;

            return Invoke<GetSystemInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSystemInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSystemInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemInstance">REST API Reference for GetSystemInstance Operation</seealso>
        public virtual Task<GetSystemInstanceResponse> GetSystemInstanceAsync(GetSystemInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetSystemInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSystemTemplate

        internal virtual GetSystemTemplateResponse GetSystemTemplate(GetSystemTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemTemplateResponseUnmarshaller.Instance;

            return Invoke<GetSystemTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSystemTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemTemplate">REST API Reference for GetSystemTemplate Operation</seealso>
        public virtual Task<GetSystemTemplateResponse> GetSystemTemplateAsync(GetSystemTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetSystemTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSystemTemplateRevisions

        internal virtual GetSystemTemplateRevisionsResponse GetSystemTemplateRevisions(GetSystemTemplateRevisionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSystemTemplateRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemTemplateRevisionsResponseUnmarshaller.Instance;

            return Invoke<GetSystemTemplateRevisionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSystemTemplateRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSystemTemplateRevisions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemTemplateRevisions">REST API Reference for GetSystemTemplateRevisions Operation</seealso>
        public virtual Task<GetSystemTemplateRevisionsResponse> GetSystemTemplateRevisionsAsync(GetSystemTemplateRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSystemTemplateRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemTemplateRevisionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSystemTemplateRevisionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUploadStatus

        internal virtual GetUploadStatusResponse GetUploadStatus(GetUploadStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUploadStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUploadStatusResponseUnmarshaller.Instance;

            return Invoke<GetUploadStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUploadStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUploadStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetUploadStatus">REST API Reference for GetUploadStatus Operation</seealso>
        public virtual Task<GetUploadStatusResponse> GetUploadStatusAsync(GetUploadStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUploadStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUploadStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetUploadStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFlowExecutionMessages

        internal virtual ListFlowExecutionMessagesResponse ListFlowExecutionMessages(ListFlowExecutionMessagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFlowExecutionMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowExecutionMessagesResponseUnmarshaller.Instance;

            return Invoke<ListFlowExecutionMessagesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFlowExecutionMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFlowExecutionMessages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/ListFlowExecutionMessages">REST API Reference for ListFlowExecutionMessages Operation</seealso>
        public virtual Task<ListFlowExecutionMessagesResponse> ListFlowExecutionMessagesAsync(ListFlowExecutionMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFlowExecutionMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowExecutionMessagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFlowExecutionMessagesResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchEntities

        internal virtual SearchEntitiesResponse SearchEntities(SearchEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchEntitiesResponseUnmarshaller.Instance;

            return Invoke<SearchEntitiesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SearchEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchEntities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchEntities">REST API Reference for SearchEntities Operation</seealso>
        public virtual Task<SearchEntitiesResponse> SearchEntitiesAsync(SearchEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchEntitiesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchEntitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchFlowExecutions

        internal virtual SearchFlowExecutionsResponse SearchFlowExecutions(SearchFlowExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchFlowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFlowExecutionsResponseUnmarshaller.Instance;

            return Invoke<SearchFlowExecutionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SearchFlowExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFlowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchFlowExecutions">REST API Reference for SearchFlowExecutions Operation</seealso>
        public virtual Task<SearchFlowExecutionsResponse> SearchFlowExecutionsAsync(SearchFlowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchFlowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFlowExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchFlowExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchFlowTemplates

        internal virtual SearchFlowTemplatesResponse SearchFlowTemplates(SearchFlowTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchFlowTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFlowTemplatesResponseUnmarshaller.Instance;

            return Invoke<SearchFlowTemplatesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SearchFlowTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFlowTemplates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchFlowTemplates">REST API Reference for SearchFlowTemplates Operation</seealso>
        public virtual Task<SearchFlowTemplatesResponse> SearchFlowTemplatesAsync(SearchFlowTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchFlowTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFlowTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchFlowTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchSystemInstances

        internal virtual SearchSystemInstancesResponse SearchSystemInstances(SearchSystemInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchSystemInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSystemInstancesResponseUnmarshaller.Instance;

            return Invoke<SearchSystemInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SearchSystemInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSystemInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchSystemInstances">REST API Reference for SearchSystemInstances Operation</seealso>
        public virtual Task<SearchSystemInstancesResponse> SearchSystemInstancesAsync(SearchSystemInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchSystemInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSystemInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchSystemInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchSystemTemplates

        internal virtual SearchSystemTemplatesResponse SearchSystemTemplates(SearchSystemTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchSystemTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSystemTemplatesResponseUnmarshaller.Instance;

            return Invoke<SearchSystemTemplatesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SearchSystemTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSystemTemplates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchSystemTemplates">REST API Reference for SearchSystemTemplates Operation</seealso>
        public virtual Task<SearchSystemTemplatesResponse> SearchSystemTemplatesAsync(SearchSystemTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchSystemTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSystemTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchSystemTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchThings

        internal virtual SearchThingsResponse SearchThings(SearchThingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchThingsResponseUnmarshaller.Instance;

            return Invoke<SearchThingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SearchThings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchThings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchThings">REST API Reference for SearchThings Operation</seealso>
        public virtual Task<SearchThingsResponse> SearchThingsAsync(SearchThingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchThingsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchThingsResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UndeploySystemInstance

        internal virtual UndeploySystemInstanceResponse UndeploySystemInstance(UndeploySystemInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UndeploySystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UndeploySystemInstanceResponseUnmarshaller.Instance;

            return Invoke<UndeploySystemInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UndeploySystemInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UndeploySystemInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UndeploySystemInstance">REST API Reference for UndeploySystemInstance Operation</seealso>
        public virtual Task<UndeploySystemInstanceResponse> UndeploySystemInstanceAsync(UndeploySystemInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UndeploySystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UndeploySystemInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UndeploySystemInstanceResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFlowTemplate

        internal virtual UpdateFlowTemplateResponse UpdateFlowTemplate(UpdateFlowTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UpdateFlowTemplate">REST API Reference for UpdateFlowTemplate Operation</seealso>
        public virtual Task<UpdateFlowTemplateResponse> UpdateFlowTemplateAsync(UpdateFlowTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFlowTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSystemTemplate

        internal virtual UpdateSystemTemplateResponse UpdateSystemTemplate(UpdateSystemTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSystemTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateSystemTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSystemTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UpdateSystemTemplate">REST API Reference for UpdateSystemTemplate Operation</seealso>
        public virtual Task<UpdateSystemTemplateResponse> UpdateSystemTemplateAsync(UpdateSystemTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSystemTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSystemTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UploadEntityDefinitions

        internal virtual UploadEntityDefinitionsResponse UploadEntityDefinitions(UploadEntityDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadEntityDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadEntityDefinitionsResponseUnmarshaller.Instance;

            return Invoke<UploadEntityDefinitionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UploadEntityDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadEntityDefinitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UploadEntityDefinitions">REST API Reference for UploadEntityDefinitions Operation</seealso>
        public virtual Task<UploadEntityDefinitionsResponse> UploadEntityDefinitionsAsync(UploadEntityDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadEntityDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadEntityDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<UploadEntityDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}