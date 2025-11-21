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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Greengrass.Model;
using Amazon.Greengrass.Model.Internal.MarshallTransformations;
using Amazon.Greengrass.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Greengrass
{
    /// <summary>
    /// <para>Implementation for accessing Greengrass</para>
    ///
    /// AWS IoT Greengrass seamlessly extends AWS onto physical devices so they can act locally
    /// on the data they generate, while still using the cloud for management, analytics,
    /// and durable storage. AWS IoT Greengrass ensures your devices can respond quickly to
    /// local events and operate with intermittent connectivity. AWS IoT Greengrass minimizes
    /// the cost of transmitting data to the cloud by allowing you to author AWS Lambda functions
    /// that execute locally.
    /// </summary>
    public partial class AmazonGreengrassClient : AmazonServiceClient, IAmazonGreengrass
    {
        private static IServiceMetadata serviceMetadata = new AmazonGreengrassMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonGreengrassClient with the credentials loaded from the application's
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
        public AmazonGreengrassClient()
            : base(new AmazonGreengrassConfig()) { }

        /// <summary>
        /// Constructs AmazonGreengrassClient with the credentials loaded from the application's
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
        public AmazonGreengrassClient(RegionEndpoint region)
            : base(new AmazonGreengrassConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGreengrassClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGreengrassClient Configuration Object</param>
        public AmazonGreengrassClient(AmazonGreengrassConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonGreengrassClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGreengrassClient(AWSCredentials credentials)
            : this(credentials, new AmazonGreengrassConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGreengrassClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGreengrassConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassClient with AWS Credentials and an
        /// AmazonGreengrassClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGreengrassClient Configuration Object</param>
        public AmazonGreengrassClient(AWSCredentials credentials, AmazonGreengrassConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGreengrassClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGreengrassConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGreengrassClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGreengrassConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGreengrassClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGreengrassClient Configuration Object</param>
        public AmazonGreengrassClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGreengrassConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGreengrassClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGreengrassConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGreengrassClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGreengrassConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGreengrassClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGreengrassClient Configuration Object</param>
        public AmazonGreengrassClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGreengrassConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGreengrassEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGreengrassAuthSchemeHandler());
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


        #region  AssociateRoleToGroup

        internal virtual AssociateRoleToGroupResponse AssociateRoleToGroup(AssociateRoleToGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateRoleToGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateRoleToGroupResponseUnmarshaller.Instance;

            return Invoke<AssociateRoleToGroupResponse>(request, options);
        }



        /// <summary>
        /// Associates a role with a group. Your Greengrass core will use the role to access AWS
        /// cloud services. The role's permissions should allow Greengrass core Lambda functions
        /// to perform actions against the cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateRoleToGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateRoleToGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateRoleToGroup">REST API Reference for AssociateRoleToGroup Operation</seealso>
        public virtual Task<AssociateRoleToGroupResponse> AssociateRoleToGroupAsync(AssociateRoleToGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateRoleToGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateRoleToGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateRoleToGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateServiceRoleToAccount

        internal virtual AssociateServiceRoleToAccountResponse AssociateServiceRoleToAccount(AssociateServiceRoleToAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateServiceRoleToAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceRoleToAccountResponseUnmarshaller.Instance;

            return Invoke<AssociateServiceRoleToAccountResponse>(request, options);
        }



        /// <summary>
        /// Associates a role with your account. AWS IoT Greengrass will use the role to access
        /// your Lambda functions and AWS IoT resources. This is necessary for deployments to
        /// succeed. The role must have at least minimum permissions in the policy ''AWSGreengrassResourceAccessRolePolicy''.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceRoleToAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateServiceRoleToAccount service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateServiceRoleToAccount">REST API Reference for AssociateServiceRoleToAccount Operation</seealso>
        public virtual Task<AssociateServiceRoleToAccountResponse> AssociateServiceRoleToAccountAsync(AssociateServiceRoleToAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateServiceRoleToAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceRoleToAccountResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateServiceRoleToAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConnectorDefinition

        internal virtual CreateConnectorDefinitionResponse CreateConnectorDefinition(CreateConnectorDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateConnectorDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a connector definition. You may provide the initial version of the connector
        /// definition now or use ''CreateConnectorDefinitionVersion'' at a later time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectorDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnectorDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateConnectorDefinition">REST API Reference for CreateConnectorDefinition Operation</seealso>
        public virtual Task<CreateConnectorDefinitionResponse> CreateConnectorDefinitionAsync(CreateConnectorDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectorDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConnectorDefinitionVersion

        internal virtual CreateConnectorDefinitionVersionResponse CreateConnectorDefinitionVersion(CreateConnectorDefinitionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<CreateConnectorDefinitionVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a version of a connector definition which has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectorDefinitionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnectorDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateConnectorDefinitionVersion">REST API Reference for CreateConnectorDefinitionVersion Operation</seealso>
        public virtual Task<CreateConnectorDefinitionVersionResponse> CreateConnectorDefinitionVersionAsync(CreateConnectorDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectorDefinitionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCoreDefinition

        internal virtual CreateCoreDefinitionResponse CreateCoreDefinition(CreateCoreDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCoreDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCoreDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateCoreDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a core definition. You may provide the initial version of the core definition
        /// now or use ''CreateCoreDefinitionVersion'' at a later time. Greengrass groups must
        /// each contain exactly one Greengrass core.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCoreDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinition">REST API Reference for CreateCoreDefinition Operation</seealso>
        public virtual Task<CreateCoreDefinitionResponse> CreateCoreDefinitionAsync(CreateCoreDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCoreDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCoreDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCoreDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCoreDefinitionVersion

        internal virtual CreateCoreDefinitionVersionResponse CreateCoreDefinitionVersion(CreateCoreDefinitionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCoreDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCoreDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<CreateCoreDefinitionVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a version of a core definition that has already been defined. Greengrass groups
        /// must each contain exactly one Greengrass core.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreDefinitionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCoreDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinitionVersion">REST API Reference for CreateCoreDefinitionVersion Operation</seealso>
        public virtual Task<CreateCoreDefinitionVersionResponse> CreateCoreDefinitionVersionAsync(CreateCoreDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCoreDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCoreDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCoreDefinitionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDeployment

        internal virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Creates a deployment. ''CreateDeployment'' requests are idempotent with respect to
        /// the ''X-Amzn-Client-Token'' token and the request parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDeviceDefinition

        internal virtual CreateDeviceDefinitionResponse CreateDeviceDefinition(CreateDeviceDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeviceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateDeviceDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a device definition. You may provide the initial version of the device definition
        /// now or use ''CreateDeviceDefinitionVersion'' at a later time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeviceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinition">REST API Reference for CreateDeviceDefinition Operation</seealso>
        public virtual Task<CreateDeviceDefinitionResponse> CreateDeviceDefinitionAsync(CreateDeviceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeviceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeviceDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDeviceDefinitionVersion

        internal virtual CreateDeviceDefinitionVersionResponse CreateDeviceDefinitionVersion(CreateDeviceDefinitionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeviceDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<CreateDeviceDefinitionVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a version of a device definition that has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceDefinitionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeviceDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinitionVersion">REST API Reference for CreateDeviceDefinitionVersion Operation</seealso>
        public virtual Task<CreateDeviceDefinitionVersionResponse> CreateDeviceDefinitionVersionAsync(CreateDeviceDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeviceDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeviceDefinitionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFunctionDefinition

        internal virtual CreateFunctionDefinitionResponse CreateFunctionDefinition(CreateFunctionDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFunctionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateFunctionDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a Lambda function definition which contains a list of Lambda functions and
        /// their configurations to be used in a group. You can create an initial version of the
        /// definition by providing a list of Lambda functions and their configurations now, or
        /// use ''CreateFunctionDefinitionVersion'' later.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFunctionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinition">REST API Reference for CreateFunctionDefinition Operation</seealso>
        public virtual Task<CreateFunctionDefinitionResponse> CreateFunctionDefinitionAsync(CreateFunctionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFunctionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFunctionDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFunctionDefinitionVersion

        internal virtual CreateFunctionDefinitionVersionResponse CreateFunctionDefinitionVersion(CreateFunctionDefinitionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFunctionDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<CreateFunctionDefinitionVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a version of a Lambda function definition that has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionDefinitionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFunctionDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinitionVersion">REST API Reference for CreateFunctionDefinitionVersion Operation</seealso>
        public virtual Task<CreateFunctionDefinitionVersionResponse> CreateFunctionDefinitionVersionAsync(CreateFunctionDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFunctionDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFunctionDefinitionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGroup

        internal virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a group. You may provide the initial version of the group or use ''CreateGroupVersion''
        /// at a later time. Tip: You can use the ''gg_group_setup'' package (https://github.com/awslabs/aws-greengrass-group-setup)
        /// as a library or command-line application to create and deploy Greengrass groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGroupCertificateAuthority

        internal virtual CreateGroupCertificateAuthorityResponse CreateGroupCertificateAuthority(CreateGroupCertificateAuthorityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGroupCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<CreateGroupCertificateAuthorityResponse>(request, options);
        }



        /// <summary>
        /// Creates a CA for the group. If a CA already exists, it will rotate the existing CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupCertificateAuthority service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroupCertificateAuthority service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupCertificateAuthority">REST API Reference for CreateGroupCertificateAuthority Operation</seealso>
        public virtual Task<CreateGroupCertificateAuthorityResponse> CreateGroupCertificateAuthorityAsync(CreateGroupCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGroupCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupCertificateAuthorityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGroupVersion

        internal virtual CreateGroupVersionResponse CreateGroupVersion(CreateGroupVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGroupVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupVersionResponseUnmarshaller.Instance;

            return Invoke<CreateGroupVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a version of a group which has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroupVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupVersion">REST API Reference for CreateGroupVersion Operation</seealso>
        public virtual Task<CreateGroupVersionResponse> CreateGroupVersionAsync(CreateGroupVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGroupVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateLoggerDefinition

        internal virtual CreateLoggerDefinitionResponse CreateLoggerDefinition(CreateLoggerDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLoggerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoggerDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateLoggerDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a logger definition. You may provide the initial version of the logger definition
        /// now or use ''CreateLoggerDefinitionVersion'' at a later time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggerDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLoggerDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinition">REST API Reference for CreateLoggerDefinition Operation</seealso>
        public virtual Task<CreateLoggerDefinitionResponse> CreateLoggerDefinitionAsync(CreateLoggerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLoggerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoggerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoggerDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateLoggerDefinitionVersion

        internal virtual CreateLoggerDefinitionVersionResponse CreateLoggerDefinitionVersion(CreateLoggerDefinitionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLoggerDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoggerDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<CreateLoggerDefinitionVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a version of a logger definition that has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggerDefinitionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLoggerDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinitionVersion">REST API Reference for CreateLoggerDefinitionVersion Operation</seealso>
        public virtual Task<CreateLoggerDefinitionVersionResponse> CreateLoggerDefinitionVersionAsync(CreateLoggerDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLoggerDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoggerDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoggerDefinitionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateResourceDefinition

        internal virtual CreateResourceDefinitionResponse CreateResourceDefinition(CreateResourceDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateResourceDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a resource definition which contains a list of resources to be used in a group.
        /// You can create an initial version of the definition by providing a list of resources
        /// now, or use ''CreateResourceDefinitionVersion'' later.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResourceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinition">REST API Reference for CreateResourceDefinition Operation</seealso>
        public virtual Task<CreateResourceDefinitionResponse> CreateResourceDefinitionAsync(CreateResourceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateResourceDefinitionVersion

        internal virtual CreateResourceDefinitionVersionResponse CreateResourceDefinitionVersion(CreateResourceDefinitionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<CreateResourceDefinitionVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a version of a resource definition that has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDefinitionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResourceDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinitionVersion">REST API Reference for CreateResourceDefinitionVersion Operation</seealso>
        public virtual Task<CreateResourceDefinitionVersionResponse> CreateResourceDefinitionVersionAsync(CreateResourceDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceDefinitionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSoftwareUpdateJob

        internal virtual CreateSoftwareUpdateJobResponse CreateSoftwareUpdateJob(CreateSoftwareUpdateJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSoftwareUpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSoftwareUpdateJobResponseUnmarshaller.Instance;

            return Invoke<CreateSoftwareUpdateJobResponse>(request, options);
        }



        /// <summary>
        /// Creates a software update for a core or group of cores (specified as an IoT thing
        /// group.) Use this to update the OTA Agent as well as the Greengrass core software.
        /// It makes use of the IoT Jobs feature which provides additional commands to manage
        /// a Greengrass core software update job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSoftwareUpdateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSoftwareUpdateJob service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSoftwareUpdateJob">REST API Reference for CreateSoftwareUpdateJob Operation</seealso>
        public virtual Task<CreateSoftwareUpdateJobResponse> CreateSoftwareUpdateJobAsync(CreateSoftwareUpdateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSoftwareUpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSoftwareUpdateJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSoftwareUpdateJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSubscriptionDefinition

        internal virtual CreateSubscriptionDefinitionResponse CreateSubscriptionDefinition(CreateSubscriptionDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a subscription definition. You may provide the initial version of the subscription
        /// definition now or use ''CreateSubscriptionDefinitionVersion'' at a later time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriptionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinition">REST API Reference for CreateSubscriptionDefinition Operation</seealso>
        public virtual Task<CreateSubscriptionDefinitionResponse> CreateSubscriptionDefinitionAsync(CreateSubscriptionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubscriptionDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSubscriptionDefinitionVersion

        internal virtual CreateSubscriptionDefinitionVersionResponse CreateSubscriptionDefinitionVersion(CreateSubscriptionDefinitionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionDefinitionVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a version of a subscription definition which has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionDefinitionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriptionDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinitionVersion">REST API Reference for CreateSubscriptionDefinitionVersion Operation</seealso>
        public virtual Task<CreateSubscriptionDefinitionVersionResponse> CreateSubscriptionDefinitionVersionAsync(CreateSubscriptionDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubscriptionDefinitionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConnectorDefinition

        internal virtual DeleteConnectorDefinitionResponse DeleteConnectorDefinition(DeleteConnectorDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectorDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectorDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a connector definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectorDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnectorDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteConnectorDefinition">REST API Reference for DeleteConnectorDefinition Operation</seealso>
        public virtual Task<DeleteConnectorDefinitionResponse> DeleteConnectorDefinitionAsync(DeleteConnectorDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectorDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConnectorDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCoreDefinition

        internal virtual DeleteCoreDefinitionResponse DeleteCoreDefinition(DeleteCoreDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCoreDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteCoreDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a core definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCoreDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteCoreDefinition">REST API Reference for DeleteCoreDefinition Operation</seealso>
        public virtual Task<DeleteCoreDefinitionResponse> DeleteCoreDefinitionAsync(DeleteCoreDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCoreDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCoreDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDeviceDefinition

        internal virtual DeleteDeviceDefinitionResponse DeleteDeviceDefinition(DeleteDeviceDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeviceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteDeviceDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a device definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeviceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteDeviceDefinition">REST API Reference for DeleteDeviceDefinition Operation</seealso>
        public virtual Task<DeleteDeviceDefinitionResponse> DeleteDeviceDefinitionAsync(DeleteDeviceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeviceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeviceDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFunctionDefinition

        internal virtual DeleteFunctionDefinitionResponse DeleteFunctionDefinition(DeleteFunctionDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFunctionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Lambda function definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFunctionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteFunctionDefinition">REST API Reference for DeleteFunctionDefinition Operation</seealso>
        public virtual Task<DeleteFunctionDefinitionResponse> DeleteFunctionDefinitionAsync(DeleteFunctionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFunctionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFunctionDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGroup

        internal virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteLoggerDefinition

        internal virtual DeleteLoggerDefinitionResponse DeleteLoggerDefinition(DeleteLoggerDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLoggerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoggerDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteLoggerDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a logger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggerDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLoggerDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteLoggerDefinition">REST API Reference for DeleteLoggerDefinition Operation</seealso>
        public virtual Task<DeleteLoggerDefinitionResponse> DeleteLoggerDefinitionAsync(DeleteLoggerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLoggerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoggerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoggerDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteResourceDefinition

        internal virtual DeleteResourceDefinitionResponse DeleteResourceDefinition(DeleteResourceDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a resource definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteResourceDefinition">REST API Reference for DeleteResourceDefinition Operation</seealso>
        public virtual Task<DeleteResourceDefinitionResponse> DeleteResourceDefinitionAsync(DeleteResourceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourceDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSubscriptionDefinition

        internal virtual DeleteSubscriptionDefinitionResponse DeleteSubscriptionDefinition(DeleteSubscriptionDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a subscription definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriptionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteSubscriptionDefinition">REST API Reference for DeleteSubscriptionDefinition Operation</seealso>
        public virtual Task<DeleteSubscriptionDefinitionResponse> DeleteSubscriptionDefinitionAsync(DeleteSubscriptionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubscriptionDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateRoleFromGroup

        internal virtual DisassociateRoleFromGroupResponse DisassociateRoleFromGroup(DisassociateRoleFromGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateRoleFromGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRoleFromGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociateRoleFromGroupResponse>(request, options);
        }



        /// <summary>
        /// Disassociates the role from a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRoleFromGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateRoleFromGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateRoleFromGroup">REST API Reference for DisassociateRoleFromGroup Operation</seealso>
        public virtual Task<DisassociateRoleFromGroupResponse> DisassociateRoleFromGroupAsync(DisassociateRoleFromGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateRoleFromGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRoleFromGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateRoleFromGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateServiceRoleFromAccount

        internal virtual DisassociateServiceRoleFromAccountResponse DisassociateServiceRoleFromAccount(DisassociateServiceRoleFromAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateServiceRoleFromAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceRoleFromAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateServiceRoleFromAccountResponse>(request, options);
        }



        /// <summary>
        /// Disassociates the service role from your account. Without a service role, deployments
        /// will not work.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceRoleFromAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateServiceRoleFromAccount service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateServiceRoleFromAccount">REST API Reference for DisassociateServiceRoleFromAccount Operation</seealso>
        public virtual Task<DisassociateServiceRoleFromAccountResponse> DisassociateServiceRoleFromAccountAsync(DisassociateServiceRoleFromAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateServiceRoleFromAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceRoleFromAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateServiceRoleFromAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAssociatedRole

        internal virtual GetAssociatedRoleResponse GetAssociatedRole(GetAssociatedRoleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssociatedRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssociatedRoleResponseUnmarshaller.Instance;

            return Invoke<GetAssociatedRoleResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the role associated with a particular group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociatedRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssociatedRole service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetAssociatedRole">REST API Reference for GetAssociatedRole Operation</seealso>
        public virtual Task<GetAssociatedRoleResponse> GetAssociatedRoleAsync(GetAssociatedRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssociatedRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssociatedRoleResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssociatedRoleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetBulkDeploymentStatus

        internal virtual GetBulkDeploymentStatusResponse GetBulkDeploymentStatus(GetBulkDeploymentStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBulkDeploymentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBulkDeploymentStatusResponseUnmarshaller.Instance;

            return Invoke<GetBulkDeploymentStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns the status of a bulk deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBulkDeploymentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBulkDeploymentStatus service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetBulkDeploymentStatus">REST API Reference for GetBulkDeploymentStatus Operation</seealso>
        public virtual Task<GetBulkDeploymentStatusResponse> GetBulkDeploymentStatusAsync(GetBulkDeploymentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBulkDeploymentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBulkDeploymentStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetBulkDeploymentStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConnectivityInfo

        internal virtual GetConnectivityInfoResponse GetConnectivityInfo(GetConnectivityInfoRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectivityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectivityInfoResponseUnmarshaller.Instance;

            return Invoke<GetConnectivityInfoResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the connectivity information for a core.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectivityInfo service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectivityInfo service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetConnectivityInfo">REST API Reference for GetConnectivityInfo Operation</seealso>
        public virtual Task<GetConnectivityInfoResponse> GetConnectivityInfoAsync(GetConnectivityInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectivityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectivityInfoResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectivityInfoResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConnectorDefinition

        internal virtual GetConnectorDefinitionResponse GetConnectorDefinition(GetConnectorDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectorDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetConnectorDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a connector definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectorDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectorDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetConnectorDefinition">REST API Reference for GetConnectorDefinition Operation</seealso>
        public virtual Task<GetConnectorDefinitionResponse> GetConnectorDefinitionAsync(GetConnectorDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectorDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectorDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConnectorDefinitionVersion

        internal virtual GetConnectorDefinitionVersionResponse GetConnectorDefinitionVersion(GetConnectorDefinitionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectorDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<GetConnectorDefinitionVersionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a connector definition version, including the connectors
        /// that the version contains. Connectors are prebuilt modules that interact with local
        /// infrastructure, device protocols, AWS, and other cloud services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectorDefinitionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectorDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetConnectorDefinitionVersion">REST API Reference for GetConnectorDefinitionVersion Operation</seealso>
        public virtual Task<GetConnectorDefinitionVersionResponse> GetConnectorDefinitionVersionAsync(GetConnectorDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectorDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectorDefinitionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCoreDefinition

        internal virtual GetCoreDefinitionResponse GetCoreDefinition(GetCoreDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCoreDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetCoreDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a core definition version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCoreDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinition">REST API Reference for GetCoreDefinition Operation</seealso>
        public virtual Task<GetCoreDefinitionResponse> GetCoreDefinitionAsync(GetCoreDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCoreDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetCoreDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCoreDefinitionVersion

        internal virtual GetCoreDefinitionVersionResponse GetCoreDefinitionVersion(GetCoreDefinitionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCoreDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<GetCoreDefinitionVersionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a core definition version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDefinitionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCoreDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinitionVersion">REST API Reference for GetCoreDefinitionVersion Operation</seealso>
        public virtual Task<GetCoreDefinitionVersionResponse> GetCoreDefinitionVersionAsync(GetCoreDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCoreDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetCoreDefinitionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDeploymentStatus

        internal virtual GetDeploymentStatusResponse GetDeploymentStatus(GetDeploymentStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentStatusResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns the status of a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeploymentStatus service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeploymentStatus">REST API Reference for GetDeploymentStatus Operation</seealso>
        public virtual Task<GetDeploymentStatusResponse> GetDeploymentStatusAsync(GetDeploymentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDeviceDefinition

        internal virtual GetDeviceDefinitionResponse GetDeviceDefinition(GetDeviceDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeviceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetDeviceDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a device definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeviceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinition">REST API Reference for GetDeviceDefinition Operation</seealso>
        public virtual Task<GetDeviceDefinitionResponse> GetDeviceDefinitionAsync(GetDeviceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeviceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDeviceDefinitionVersion

        internal virtual GetDeviceDefinitionVersionResponse GetDeviceDefinitionVersion(GetDeviceDefinitionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeviceDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<GetDeviceDefinitionVersionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a device definition version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceDefinitionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeviceDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinitionVersion">REST API Reference for GetDeviceDefinitionVersion Operation</seealso>
        public virtual Task<GetDeviceDefinitionVersionResponse> GetDeviceDefinitionVersionAsync(GetDeviceDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeviceDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceDefinitionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFunctionDefinition

        internal virtual GetFunctionDefinitionResponse GetFunctionDefinition(GetFunctionDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFunctionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetFunctionDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a Lambda function definition, including its creation time
        /// and latest version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFunctionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinition">REST API Reference for GetFunctionDefinition Operation</seealso>
        public virtual Task<GetFunctionDefinitionResponse> GetFunctionDefinitionAsync(GetFunctionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFunctionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFunctionDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFunctionDefinitionVersion

        internal virtual GetFunctionDefinitionVersionResponse GetFunctionDefinitionVersion(GetFunctionDefinitionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFunctionDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<GetFunctionDefinitionVersionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a Lambda function definition version, including which
        /// Lambda functions are included in the version and their configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionDefinitionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFunctionDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinitionVersion">REST API Reference for GetFunctionDefinitionVersion Operation</seealso>
        public virtual Task<GetFunctionDefinitionVersionResponse> GetFunctionDefinitionVersionAsync(GetFunctionDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFunctionDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFunctionDefinitionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetGroup

        internal virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetGroupCertificateAuthority

        internal virtual GetGroupCertificateAuthorityResponse GetGroupCertificateAuthority(GetGroupCertificateAuthorityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<GetGroupCertificateAuthorityResponse>(request, options);
        }



        /// <summary>
        /// Retreives the CA associated with a group. Returns the public key of the CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupCertificateAuthority service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroupCertificateAuthority service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateAuthority">REST API Reference for GetGroupCertificateAuthority Operation</seealso>
        public virtual Task<GetGroupCertificateAuthorityResponse> GetGroupCertificateAuthorityAsync(GetGroupCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupCertificateAuthorityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetGroupCertificateConfiguration

        internal virtual GetGroupCertificateConfigurationResponse GetGroupCertificateConfiguration(GetGroupCertificateConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupCertificateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupCertificateConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetGroupCertificateConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current configuration for the CA used by the group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupCertificateConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroupCertificateConfiguration service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateConfiguration">REST API Reference for GetGroupCertificateConfiguration Operation</seealso>
        public virtual Task<GetGroupCertificateConfigurationResponse> GetGroupCertificateConfigurationAsync(GetGroupCertificateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupCertificateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupCertificateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupCertificateConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetGroupVersion

        internal virtual GetGroupVersionResponse GetGroupVersion(GetGroupVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupVersionResponseUnmarshaller.Instance;

            return Invoke<GetGroupVersionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a group version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroupVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupVersion">REST API Reference for GetGroupVersion Operation</seealso>
        public virtual Task<GetGroupVersionResponse> GetGroupVersionAsync(GetGroupVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLoggerDefinition

        internal virtual GetLoggerDefinitionResponse GetLoggerDefinition(GetLoggerDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLoggerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggerDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetLoggerDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a logger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggerDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLoggerDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinition">REST API Reference for GetLoggerDefinition Operation</seealso>
        public virtual Task<GetLoggerDefinitionResponse> GetLoggerDefinitionAsync(GetLoggerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLoggerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoggerDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLoggerDefinitionVersion

        internal virtual GetLoggerDefinitionVersionResponse GetLoggerDefinitionVersion(GetLoggerDefinitionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLoggerDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggerDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<GetLoggerDefinitionVersionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a logger definition version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggerDefinitionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLoggerDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinitionVersion">REST API Reference for GetLoggerDefinitionVersion Operation</seealso>
        public virtual Task<GetLoggerDefinitionVersionResponse> GetLoggerDefinitionVersionAsync(GetLoggerDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLoggerDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggerDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoggerDefinitionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourceDefinition

        internal virtual GetResourceDefinitionResponse GetResourceDefinition(GetResourceDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetResourceDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a resource definition, including its creation time and
        /// latest version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinition">REST API Reference for GetResourceDefinition Operation</seealso>
        public virtual Task<GetResourceDefinitionResponse> GetResourceDefinitionAsync(GetResourceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourceDefinitionVersion

        internal virtual GetResourceDefinitionVersionResponse GetResourceDefinitionVersion(GetResourceDefinitionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<GetResourceDefinitionVersionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a resource definition version, including which resources
        /// are included in the version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceDefinitionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinitionVersion">REST API Reference for GetResourceDefinitionVersion Operation</seealso>
        public virtual Task<GetResourceDefinitionVersionResponse> GetResourceDefinitionVersionAsync(GetResourceDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceDefinitionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetServiceRoleForAccount

        internal virtual GetServiceRoleForAccountResponse GetServiceRoleForAccount(GetServiceRoleForAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceRoleForAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceRoleForAccountResponseUnmarshaller.Instance;

            return Invoke<GetServiceRoleForAccountResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the service role that is attached to your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceRoleForAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceRoleForAccount service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetServiceRoleForAccount">REST API Reference for GetServiceRoleForAccount Operation</seealso>
        public virtual Task<GetServiceRoleForAccountResponse> GetServiceRoleForAccountAsync(GetServiceRoleForAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceRoleForAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceRoleForAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceRoleForAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSubscriptionDefinition

        internal virtual GetSubscriptionDefinitionResponse GetSubscriptionDefinition(GetSubscriptionDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a subscription definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriptionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinition">REST API Reference for GetSubscriptionDefinition Operation</seealso>
        public virtual Task<GetSubscriptionDefinitionResponse> GetSubscriptionDefinitionAsync(GetSubscriptionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSubscriptionDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSubscriptionDefinitionVersion

        internal virtual GetSubscriptionDefinitionVersionResponse GetSubscriptionDefinitionVersion(GetSubscriptionDefinitionVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionDefinitionVersionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a subscription definition version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionDefinitionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriptionDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinitionVersion">REST API Reference for GetSubscriptionDefinitionVersion Operation</seealso>
        public virtual Task<GetSubscriptionDefinitionVersionResponse> GetSubscriptionDefinitionVersionAsync(GetSubscriptionDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionDefinitionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSubscriptionDefinitionVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetThingRuntimeConfiguration

        internal virtual GetThingRuntimeConfigurationResponse GetThingRuntimeConfiguration(GetThingRuntimeConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetThingRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThingRuntimeConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetThingRuntimeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Get the runtime configuration of a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThingRuntimeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetThingRuntimeConfiguration service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetThingRuntimeConfiguration">REST API Reference for GetThingRuntimeConfiguration Operation</seealso>
        public virtual Task<GetThingRuntimeConfigurationResponse> GetThingRuntimeConfigurationAsync(GetThingRuntimeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetThingRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThingRuntimeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetThingRuntimeConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBulkDeploymentDetailedReports

        internal virtual ListBulkDeploymentDetailedReportsResponse ListBulkDeploymentDetailedReports(ListBulkDeploymentDetailedReportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBulkDeploymentDetailedReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBulkDeploymentDetailedReportsResponseUnmarshaller.Instance;

            return Invoke<ListBulkDeploymentDetailedReportsResponse>(request, options);
        }



        /// <summary>
        /// Gets a paginated list of the deployments that have been started in a bulk deployment
        /// operation, and their current deployment status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBulkDeploymentDetailedReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBulkDeploymentDetailedReports service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListBulkDeploymentDetailedReports">REST API Reference for ListBulkDeploymentDetailedReports Operation</seealso>
        public virtual Task<ListBulkDeploymentDetailedReportsResponse> ListBulkDeploymentDetailedReportsAsync(ListBulkDeploymentDetailedReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBulkDeploymentDetailedReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBulkDeploymentDetailedReportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBulkDeploymentDetailedReportsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBulkDeployments

        internal virtual ListBulkDeploymentsResponse ListBulkDeployments(ListBulkDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBulkDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBulkDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListBulkDeploymentsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of bulk deployments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBulkDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBulkDeployments service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListBulkDeployments">REST API Reference for ListBulkDeployments Operation</seealso>
        public virtual Task<ListBulkDeploymentsResponse> ListBulkDeploymentsAsync(ListBulkDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBulkDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBulkDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBulkDeploymentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConnectorDefinitions

        internal virtual ListConnectorDefinitionsResponse ListConnectorDefinitions(ListConnectorDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListConnectorDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of connector definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectorDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnectorDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListConnectorDefinitions">REST API Reference for ListConnectorDefinitions Operation</seealso>
        public virtual Task<ListConnectorDefinitionsResponse> ListConnectorDefinitionsAsync(ListConnectorDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConnectorDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConnectorDefinitionVersions

        internal virtual ListConnectorDefinitionVersionsResponse ListConnectorDefinitionVersions(ListConnectorDefinitionVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorDefinitionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListConnectorDefinitionVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the versions of a connector definition, which are containers for connectors.
        /// Connectors run on the Greengrass core and contain built-in integration with local
        /// infrastructure, device protocols, AWS, and other cloud services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectorDefinitionVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnectorDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListConnectorDefinitionVersions">REST API Reference for ListConnectorDefinitionVersions Operation</seealso>
        public virtual Task<ListConnectorDefinitionVersionsResponse> ListConnectorDefinitionVersionsAsync(ListConnectorDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConnectorDefinitionVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCoreDefinitions

        internal virtual ListCoreDefinitionsResponse ListCoreDefinitions(ListCoreDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCoreDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListCoreDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of core definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCoreDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitions">REST API Reference for ListCoreDefinitions Operation</seealso>
        public virtual Task<ListCoreDefinitionsResponse> ListCoreDefinitionsAsync(ListCoreDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCoreDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCoreDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCoreDefinitionVersions

        internal virtual ListCoreDefinitionVersionsResponse ListCoreDefinitionVersions(ListCoreDefinitionVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCoreDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreDefinitionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListCoreDefinitionVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the versions of a core definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDefinitionVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCoreDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitionVersions">REST API Reference for ListCoreDefinitionVersions Operation</seealso>
        public virtual Task<ListCoreDefinitionVersionsResponse> ListCoreDefinitionVersionsAsync(ListCoreDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCoreDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCoreDefinitionVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDeployments

        internal virtual ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentsResponse>(request, options);
        }



        /// <summary>
        /// Returns a history of deployments for the group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDeviceDefinitions

        internal virtual ListDeviceDefinitionsResponse ListDeviceDefinitions(ListDeviceDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeviceDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListDeviceDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of device definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeviceDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitions">REST API Reference for ListDeviceDefinitions Operation</seealso>
        public virtual Task<ListDeviceDefinitionsResponse> ListDeviceDefinitionsAsync(ListDeviceDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeviceDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeviceDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDeviceDefinitionVersions

        internal virtual ListDeviceDefinitionVersionsResponse ListDeviceDefinitionVersions(ListDeviceDefinitionVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeviceDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceDefinitionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListDeviceDefinitionVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the versions of a device definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceDefinitionVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeviceDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitionVersions">REST API Reference for ListDeviceDefinitionVersions Operation</seealso>
        public virtual Task<ListDeviceDefinitionVersionsResponse> ListDeviceDefinitionVersionsAsync(ListDeviceDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeviceDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeviceDefinitionVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFunctionDefinitions

        internal virtual ListFunctionDefinitionsResponse ListFunctionDefinitions(ListFunctionDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFunctionDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListFunctionDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of Lambda function definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFunctionDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitions">REST API Reference for ListFunctionDefinitions Operation</seealso>
        public virtual Task<ListFunctionDefinitionsResponse> ListFunctionDefinitionsAsync(ListFunctionDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFunctionDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFunctionDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFunctionDefinitionVersions

        internal virtual ListFunctionDefinitionVersionsResponse ListFunctionDefinitionVersions(ListFunctionDefinitionVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFunctionDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionDefinitionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListFunctionDefinitionVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the versions of a Lambda function definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionDefinitionVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFunctionDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitionVersions">REST API Reference for ListFunctionDefinitionVersions Operation</seealso>
        public virtual Task<ListFunctionDefinitionVersionsResponse> ListFunctionDefinitionVersionsAsync(ListFunctionDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFunctionDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFunctionDefinitionVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGroupCertificateAuthorities

        internal virtual ListGroupCertificateAuthoritiesResponse ListGroupCertificateAuthorities(ListGroupCertificateAuthoritiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGroupCertificateAuthoritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupCertificateAuthoritiesResponseUnmarshaller.Instance;

            return Invoke<ListGroupCertificateAuthoritiesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current CAs for a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupCertificateAuthorities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroupCertificateAuthorities service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupCertificateAuthorities">REST API Reference for ListGroupCertificateAuthorities Operation</seealso>
        public virtual Task<ListGroupCertificateAuthoritiesResponse> ListGroupCertificateAuthoritiesAsync(ListGroupCertificateAuthoritiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGroupCertificateAuthoritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupCertificateAuthoritiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupCertificateAuthoritiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGroups

        internal virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGroupVersions

        internal virtual ListGroupVersionsResponse ListGroupVersions(ListGroupVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGroupVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupVersionsResponseUnmarshaller.Instance;

            return Invoke<ListGroupVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the versions of a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroupVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupVersions">REST API Reference for ListGroupVersions Operation</seealso>
        public virtual Task<ListGroupVersionsResponse> ListGroupVersionsAsync(ListGroupVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGroupVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLoggerDefinitions

        internal virtual ListLoggerDefinitionsResponse ListLoggerDefinitions(ListLoggerDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLoggerDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLoggerDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListLoggerDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of logger definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggerDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLoggerDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitions">REST API Reference for ListLoggerDefinitions Operation</seealso>
        public virtual Task<ListLoggerDefinitionsResponse> ListLoggerDefinitionsAsync(ListLoggerDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLoggerDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLoggerDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLoggerDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLoggerDefinitionVersions

        internal virtual ListLoggerDefinitionVersionsResponse ListLoggerDefinitionVersions(ListLoggerDefinitionVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLoggerDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLoggerDefinitionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListLoggerDefinitionVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the versions of a logger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggerDefinitionVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLoggerDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitionVersions">REST API Reference for ListLoggerDefinitionVersions Operation</seealso>
        public virtual Task<ListLoggerDefinitionVersionsResponse> ListLoggerDefinitionVersionsAsync(ListLoggerDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLoggerDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLoggerDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLoggerDefinitionVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResourceDefinitions

        internal virtual ListResourceDefinitionsResponse ListResourceDefinitions(ListResourceDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListResourceDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of resource definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitions">REST API Reference for ListResourceDefinitions Operation</seealso>
        public virtual Task<ListResourceDefinitionsResponse> ListResourceDefinitionsAsync(ListResourceDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResourceDefinitionVersions

        internal virtual ListResourceDefinitionVersionsResponse ListResourceDefinitionVersions(ListResourceDefinitionVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceDefinitionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListResourceDefinitionVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the versions of a resource definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDefinitionVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitionVersions">REST API Reference for ListResourceDefinitionVersions Operation</seealso>
        public virtual Task<ListResourceDefinitionVersionsResponse> ListResourceDefinitionVersionsAsync(ListResourceDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceDefinitionVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSubscriptionDefinitions

        internal virtual ListSubscriptionDefinitionsResponse ListSubscriptionDefinitions(ListSubscriptionDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of subscription definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptionDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitions">REST API Reference for ListSubscriptionDefinitions Operation</seealso>
        public virtual Task<ListSubscriptionDefinitionsResponse> ListSubscriptionDefinitionsAsync(ListSubscriptionDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscriptionDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSubscriptionDefinitionVersions

        internal virtual ListSubscriptionDefinitionVersionsResponse ListSubscriptionDefinitionVersions(ListSubscriptionDefinitionVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionDefinitionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionDefinitionVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the versions of a subscription definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionDefinitionVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptionDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitionVersions">REST API Reference for ListSubscriptionDefinitionVersions Operation</seealso>
        public virtual Task<ListSubscriptionDefinitionVersionsResponse> ListSubscriptionDefinitionVersionsAsync(ListSubscriptionDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionDefinitionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscriptionDefinitionVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of resource tags for a resource arn.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ResetDeployments

        internal virtual ResetDeploymentsResponse ResetDeployments(ResetDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ResetDeploymentsResponse>(request, options);
        }



        /// <summary>
        /// Resets a group's deployments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetDeployments service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ResetDeployments">REST API Reference for ResetDeployments Operation</seealso>
        public virtual Task<ResetDeploymentsResponse> ResetDeploymentsAsync(ResetDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ResetDeploymentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartBulkDeployment

        internal virtual StartBulkDeploymentResponse StartBulkDeployment(StartBulkDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartBulkDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBulkDeploymentResponseUnmarshaller.Instance;

            return Invoke<StartBulkDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Deploys multiple groups in one operation. This action starts the bulk deployment of
        /// a specified set of group versions. Each group version deployment will be triggered
        /// with an adaptive rate that has a fixed upper limit. We recommend that you include
        /// an ''X-Amzn-Client-Token'' token in every ''StartBulkDeployment'' request. These requests
        /// are idempotent with respect to the token and the request parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBulkDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartBulkDeployment service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/StartBulkDeployment">REST API Reference for StartBulkDeployment Operation</seealso>
        public virtual Task<StartBulkDeploymentResponse> StartBulkDeploymentAsync(StartBulkDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartBulkDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBulkDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<StartBulkDeploymentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopBulkDeployment

        internal virtual StopBulkDeploymentResponse StopBulkDeployment(StopBulkDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopBulkDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBulkDeploymentResponseUnmarshaller.Instance;

            return Invoke<StopBulkDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Stops the execution of a bulk deployment. This action returns a status of ''Stopping''
        /// until the deployment is stopped. You cannot start a new bulk deployment while a previous
        /// deployment is in the ''Stopping'' state. This action doesn't rollback completed deployments
        /// or cancel pending deployments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBulkDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopBulkDeployment service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/StopBulkDeployment">REST API Reference for StopBulkDeployment Operation</seealso>
        public virtual Task<StopBulkDeploymentResponse> StopBulkDeploymentAsync(StopBulkDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopBulkDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBulkDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<StopBulkDeploymentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds tags to a Greengrass resource. Valid resources are 'Group', 'ConnectorDefinition',
        /// 'CoreDefinition', 'DeviceDefinition', 'FunctionDefinition', 'LoggerDefinition', 'SubscriptionDefinition',
        /// 'ResourceDefinition', and 'BulkDeployment'.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Remove resource tags from a Greengrass Resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConnectivityInfo

        internal virtual UpdateConnectivityInfoResponse UpdateConnectivityInfo(UpdateConnectivityInfoRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectivityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectivityInfoResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectivityInfoResponse>(request, options);
        }



        /// <summary>
        /// Updates the connectivity information for the core. Any devices that belong to the
        /// group which has this core will receive this information in order to find the location
        /// of the core and connect to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectivityInfo service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnectivityInfo service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateConnectivityInfo">REST API Reference for UpdateConnectivityInfo Operation</seealso>
        public virtual Task<UpdateConnectivityInfoResponse> UpdateConnectivityInfoAsync(UpdateConnectivityInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectivityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectivityInfoResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConnectivityInfoResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConnectorDefinition

        internal virtual UpdateConnectorDefinitionResponse UpdateConnectorDefinition(UpdateConnectorDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectorDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectorDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Updates a connector definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectorDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnectorDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateConnectorDefinition">REST API Reference for UpdateConnectorDefinition Operation</seealso>
        public virtual Task<UpdateConnectorDefinitionResponse> UpdateConnectorDefinitionAsync(UpdateConnectorDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectorDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConnectorDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCoreDefinition

        internal virtual UpdateCoreDefinitionResponse UpdateCoreDefinition(UpdateCoreDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCoreDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCoreDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateCoreDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Updates a core definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCoreDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCoreDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateCoreDefinition">REST API Reference for UpdateCoreDefinition Operation</seealso>
        public virtual Task<UpdateCoreDefinitionResponse> UpdateCoreDefinitionAsync(UpdateCoreDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCoreDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCoreDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCoreDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDeviceDefinition

        internal virtual UpdateDeviceDefinitionResponse UpdateDeviceDefinition(UpdateDeviceDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeviceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Updates a device definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDeviceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateDeviceDefinition">REST API Reference for UpdateDeviceDefinition Operation</seealso>
        public virtual Task<UpdateDeviceDefinitionResponse> UpdateDeviceDefinitionAsync(UpdateDeviceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeviceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeviceDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFunctionDefinition

        internal virtual UpdateFunctionDefinitionResponse UpdateFunctionDefinition(UpdateFunctionDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFunctionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateFunctionDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Updates a Lambda function definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFunctionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateFunctionDefinition">REST API Reference for UpdateFunctionDefinition Operation</seealso>
        public virtual Task<UpdateFunctionDefinitionResponse> UpdateFunctionDefinitionAsync(UpdateFunctionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFunctionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFunctionDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGroup

        internal virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGroupCertificateConfiguration

        internal virtual UpdateGroupCertificateConfigurationResponse UpdateGroupCertificateConfiguration(UpdateGroupCertificateConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGroupCertificateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupCertificateConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupCertificateConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the Certificate expiry time for a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupCertificateConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroupCertificateConfiguration service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroupCertificateConfiguration">REST API Reference for UpdateGroupCertificateConfiguration Operation</seealso>
        public virtual Task<UpdateGroupCertificateConfigurationResponse> UpdateGroupCertificateConfigurationAsync(UpdateGroupCertificateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGroupCertificateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupCertificateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGroupCertificateConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateLoggerDefinition

        internal virtual UpdateLoggerDefinitionResponse UpdateLoggerDefinition(UpdateLoggerDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLoggerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoggerDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateLoggerDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Updates a logger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggerDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLoggerDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateLoggerDefinition">REST API Reference for UpdateLoggerDefinition Operation</seealso>
        public virtual Task<UpdateLoggerDefinitionResponse> UpdateLoggerDefinitionAsync(UpdateLoggerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLoggerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoggerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLoggerDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateResourceDefinition

        internal virtual UpdateResourceDefinitionResponse UpdateResourceDefinition(UpdateResourceDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResourceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Updates a resource definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResourceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateResourceDefinition">REST API Reference for UpdateResourceDefinition Operation</seealso>
        public virtual Task<UpdateResourceDefinitionResponse> UpdateResourceDefinitionAsync(UpdateResourceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResourceDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResourceDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSubscriptionDefinition

        internal virtual UpdateSubscriptionDefinitionResponse UpdateSubscriptionDefinition(UpdateSubscriptionDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Updates a subscription definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriptionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateSubscriptionDefinition">REST API Reference for UpdateSubscriptionDefinition Operation</seealso>
        public virtual Task<UpdateSubscriptionDefinitionResponse> UpdateSubscriptionDefinitionAsync(UpdateSubscriptionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSubscriptionDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateThingRuntimeConfiguration

        internal virtual UpdateThingRuntimeConfigurationResponse UpdateThingRuntimeConfiguration(UpdateThingRuntimeConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateThingRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingRuntimeConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateThingRuntimeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the runtime configuration of a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingRuntimeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateThingRuntimeConfiguration service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateThingRuntimeConfiguration">REST API Reference for UpdateThingRuntimeConfiguration Operation</seealso>
        public virtual Task<UpdateThingRuntimeConfigurationResponse> UpdateThingRuntimeConfigurationAsync(UpdateThingRuntimeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateThingRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThingRuntimeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateThingRuntimeConfigurationResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}