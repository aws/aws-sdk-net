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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Greengrass.Model;
using Amazon.Greengrass.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Greengrass
{
    /// <summary>
    /// Implementation for accessing Greengrass
    ///
    /// AWS Greengrass seamlessly extends AWS onto physical devices so they can act locally
    /// on the data they generate, while still using the cloud for management, analytics,
    /// and durable storage. AWS Greengrass ensures your devices can respond quickly to local
    /// events and operate with intermittent connectivity. AWS Greengrass minimizes the cost
    /// of transmitting data to the cloud by allowing you to author AWS Lambda functions that
    /// execute locally.
    /// </summary>
    public partial class AmazonGreengrassClient : AmazonServiceClient, IAmazonGreengrass
    {
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGreengrassConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGreengrassConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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

        
        #region  AssociateRoleToGroup


        /// <summary>
        /// Associates a role with a group. Your AWS Greengrass core will use the role to access
        /// AWS cloud services. The role's permissions should allow Greengrass core Lambda functions
        /// to perform actions against the cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateRoleToGroup service method.</param>
        /// 
        /// <returns>The response from the AssociateRoleToGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateRoleToGroup">REST API Reference for AssociateRoleToGroup Operation</seealso>
        public virtual AssociateRoleToGroupResponse AssociateRoleToGroup(AssociateRoleToGroupRequest request)
        {
            var marshaller = AssociateRoleToGroupRequestMarshaller.Instance;
            var unmarshaller = AssociateRoleToGroupResponseUnmarshaller.Instance;

            return Invoke<AssociateRoleToGroupRequest,AssociateRoleToGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateRoleToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateRoleToGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateRoleToGroup">REST API Reference for AssociateRoleToGroup Operation</seealso>
        public virtual Task<AssociateRoleToGroupResponse> AssociateRoleToGroupAsync(AssociateRoleToGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateRoleToGroupRequestMarshaller.Instance;
            var unmarshaller = AssociateRoleToGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateRoleToGroupRequest,AssociateRoleToGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateServiceRoleToAccount


        /// <summary>
        /// Associates a role with your account. AWS Greengrass will use the role to access your
        /// Lambda functions and AWS IoT resources. This is necessary for deployments to succeed.
        /// The role must have at least minimum permissions in the policy ''AWSGreengrassResourceAccessRolePolicy''.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceRoleToAccount service method.</param>
        /// 
        /// <returns>The response from the AssociateServiceRoleToAccount service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateServiceRoleToAccount">REST API Reference for AssociateServiceRoleToAccount Operation</seealso>
        public virtual AssociateServiceRoleToAccountResponse AssociateServiceRoleToAccount(AssociateServiceRoleToAccountRequest request)
        {
            var marshaller = AssociateServiceRoleToAccountRequestMarshaller.Instance;
            var unmarshaller = AssociateServiceRoleToAccountResponseUnmarshaller.Instance;

            return Invoke<AssociateServiceRoleToAccountRequest,AssociateServiceRoleToAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateServiceRoleToAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceRoleToAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateServiceRoleToAccount">REST API Reference for AssociateServiceRoleToAccount Operation</seealso>
        public virtual Task<AssociateServiceRoleToAccountResponse> AssociateServiceRoleToAccountAsync(AssociateServiceRoleToAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateServiceRoleToAccountRequestMarshaller.Instance;
            var unmarshaller = AssociateServiceRoleToAccountResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateServiceRoleToAccountRequest,AssociateServiceRoleToAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCoreDefinition


        /// <summary>
        /// Creates a core definition. You may provide the initial version of the core definition
        /// now or use ''CreateCoreDefinitionVersion'' at a later time. AWS Greengrass groups
        /// must each contain exactly one AWS Greengrass core.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateCoreDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinition">REST API Reference for CreateCoreDefinition Operation</seealso>
        public virtual CreateCoreDefinitionResponse CreateCoreDefinition(CreateCoreDefinitionRequest request)
        {
            var marshaller = CreateCoreDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateCoreDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateCoreDefinitionRequest,CreateCoreDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinition">REST API Reference for CreateCoreDefinition Operation</seealso>
        public virtual Task<CreateCoreDefinitionResponse> CreateCoreDefinitionAsync(CreateCoreDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateCoreDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateCoreDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCoreDefinitionRequest,CreateCoreDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCoreDefinitionVersion


        /// <summary>
        /// Creates a version of a core definition that has already been defined. AWS Greengrass
        /// groups must each contain exactly one AWS Greengrass core.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the CreateCoreDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinitionVersion">REST API Reference for CreateCoreDefinitionVersion Operation</seealso>
        public virtual CreateCoreDefinitionVersionResponse CreateCoreDefinitionVersion(CreateCoreDefinitionVersionRequest request)
        {
            var marshaller = CreateCoreDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateCoreDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<CreateCoreDefinitionVersionRequest,CreateCoreDefinitionVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCoreDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreDefinitionVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinitionVersion">REST API Reference for CreateCoreDefinitionVersion Operation</seealso>
        public virtual Task<CreateCoreDefinitionVersionResponse> CreateCoreDefinitionVersionAsync(CreateCoreDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateCoreDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateCoreDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCoreDefinitionVersionRequest,CreateCoreDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeployment


        /// <summary>
        /// Creates a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var marshaller = CreateDeploymentRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentRequest,CreateDeploymentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDeploymentRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentRequest,CreateDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeviceDefinition


        /// <summary>
        /// Creates a device definition. You may provide the initial version of the device definition
        /// now or use ''CreateDeviceDefinitionVersion'' at a later time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateDeviceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinition">REST API Reference for CreateDeviceDefinition Operation</seealso>
        public virtual CreateDeviceDefinitionResponse CreateDeviceDefinition(CreateDeviceDefinitionRequest request)
        {
            var marshaller = CreateDeviceDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateDeviceDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateDeviceDefinitionRequest,CreateDeviceDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinition">REST API Reference for CreateDeviceDefinition Operation</seealso>
        public virtual Task<CreateDeviceDefinitionResponse> CreateDeviceDefinitionAsync(CreateDeviceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDeviceDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateDeviceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeviceDefinitionRequest,CreateDeviceDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeviceDefinitionVersion


        /// <summary>
        /// Creates a version of a device definition that has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the CreateDeviceDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinitionVersion">REST API Reference for CreateDeviceDefinitionVersion Operation</seealso>
        public virtual CreateDeviceDefinitionVersionResponse CreateDeviceDefinitionVersion(CreateDeviceDefinitionVersionRequest request)
        {
            var marshaller = CreateDeviceDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateDeviceDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<CreateDeviceDefinitionVersionRequest,CreateDeviceDefinitionVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeviceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceDefinitionVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinitionVersion">REST API Reference for CreateDeviceDefinitionVersion Operation</seealso>
        public virtual Task<CreateDeviceDefinitionVersionResponse> CreateDeviceDefinitionVersionAsync(CreateDeviceDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDeviceDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateDeviceDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeviceDefinitionVersionRequest,CreateDeviceDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFunctionDefinition


        /// <summary>
        /// Creates a Lambda function definition which contains a list of Lambda functions and
        /// their configurations to be used in a group. You can create an initial version of the
        /// definition by providing a list of Lambda functions and their configurations now, or
        /// use ''CreateFunctionDefinitionVersion'' later.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateFunctionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinition">REST API Reference for CreateFunctionDefinition Operation</seealso>
        public virtual CreateFunctionDefinitionResponse CreateFunctionDefinition(CreateFunctionDefinitionRequest request)
        {
            var marshaller = CreateFunctionDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateFunctionDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateFunctionDefinitionRequest,CreateFunctionDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinition">REST API Reference for CreateFunctionDefinition Operation</seealso>
        public virtual Task<CreateFunctionDefinitionResponse> CreateFunctionDefinitionAsync(CreateFunctionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateFunctionDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateFunctionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFunctionDefinitionRequest,CreateFunctionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFunctionDefinitionVersion


        /// <summary>
        /// Creates a version of a Lambda function definition that has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the CreateFunctionDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinitionVersion">REST API Reference for CreateFunctionDefinitionVersion Operation</seealso>
        public virtual CreateFunctionDefinitionVersionResponse CreateFunctionDefinitionVersion(CreateFunctionDefinitionVersionRequest request)
        {
            var marshaller = CreateFunctionDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateFunctionDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<CreateFunctionDefinitionVersionRequest,CreateFunctionDefinitionVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFunctionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionDefinitionVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinitionVersion">REST API Reference for CreateFunctionDefinitionVersion Operation</seealso>
        public virtual Task<CreateFunctionDefinitionVersionResponse> CreateFunctionDefinitionVersionAsync(CreateFunctionDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateFunctionDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateFunctionDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFunctionDefinitionVersionRequest,CreateFunctionDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGroup


        /// <summary>
        /// Creates a group. You may provide the initial version of the group or use ''CreateGroupVersion''
        /// at a later time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var marshaller = CreateGroupRequestMarshaller.Instance;
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupRequest,CreateGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateGroupRequestMarshaller.Instance;
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupRequest,CreateGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGroupCertificateAuthority


        /// <summary>
        /// Creates a CA for the group. If a CA already exists, it will rotate the existing CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the CreateGroupCertificateAuthority service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupCertificateAuthority">REST API Reference for CreateGroupCertificateAuthority Operation</seealso>
        public virtual CreateGroupCertificateAuthorityResponse CreateGroupCertificateAuthority(CreateGroupCertificateAuthorityRequest request)
        {
            var marshaller = CreateGroupCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = CreateGroupCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<CreateGroupCertificateAuthorityRequest,CreateGroupCertificateAuthorityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroupCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupCertificateAuthority">REST API Reference for CreateGroupCertificateAuthority Operation</seealso>
        public virtual Task<CreateGroupCertificateAuthorityResponse> CreateGroupCertificateAuthorityAsync(CreateGroupCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateGroupCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = CreateGroupCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupCertificateAuthorityRequest,CreateGroupCertificateAuthorityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGroupVersion


        /// <summary>
        /// Creates a version of a group which has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupVersion service method.</param>
        /// 
        /// <returns>The response from the CreateGroupVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupVersion">REST API Reference for CreateGroupVersion Operation</seealso>
        public virtual CreateGroupVersionResponse CreateGroupVersion(CreateGroupVersionRequest request)
        {
            var marshaller = CreateGroupVersionRequestMarshaller.Instance;
            var unmarshaller = CreateGroupVersionResponseUnmarshaller.Instance;

            return Invoke<CreateGroupVersionRequest,CreateGroupVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroupVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupVersion">REST API Reference for CreateGroupVersion Operation</seealso>
        public virtual Task<CreateGroupVersionResponse> CreateGroupVersionAsync(CreateGroupVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateGroupVersionRequestMarshaller.Instance;
            var unmarshaller = CreateGroupVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupVersionRequest,CreateGroupVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLoggerDefinition


        /// <summary>
        /// Creates a logger definition. You may provide the initial version of the logger definition
        /// now or use ''CreateLoggerDefinitionVersion'' at a later time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggerDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateLoggerDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinition">REST API Reference for CreateLoggerDefinition Operation</seealso>
        public virtual CreateLoggerDefinitionResponse CreateLoggerDefinition(CreateLoggerDefinitionRequest request)
        {
            var marshaller = CreateLoggerDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateLoggerDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateLoggerDefinitionRequest,CreateLoggerDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggerDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinition">REST API Reference for CreateLoggerDefinition Operation</seealso>
        public virtual Task<CreateLoggerDefinitionResponse> CreateLoggerDefinitionAsync(CreateLoggerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateLoggerDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateLoggerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoggerDefinitionRequest,CreateLoggerDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLoggerDefinitionVersion


        /// <summary>
        /// Creates a version of a logger definition that has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggerDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the CreateLoggerDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinitionVersion">REST API Reference for CreateLoggerDefinitionVersion Operation</seealso>
        public virtual CreateLoggerDefinitionVersionResponse CreateLoggerDefinitionVersion(CreateLoggerDefinitionVersionRequest request)
        {
            var marshaller = CreateLoggerDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateLoggerDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<CreateLoggerDefinitionVersionRequest,CreateLoggerDefinitionVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoggerDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggerDefinitionVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinitionVersion">REST API Reference for CreateLoggerDefinitionVersion Operation</seealso>
        public virtual Task<CreateLoggerDefinitionVersionResponse> CreateLoggerDefinitionVersionAsync(CreateLoggerDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateLoggerDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateLoggerDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoggerDefinitionVersionRequest,CreateLoggerDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateResourceDefinition


        /// <summary>
        /// Creates a resource definition which contains a list of resources to be used in a group.
        /// You can create an initial version of the definition by providing a list of resources
        /// now, or use ''CreateResourceDefinitionVersion'' later.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateResourceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinition">REST API Reference for CreateResourceDefinition Operation</seealso>
        public virtual CreateResourceDefinitionResponse CreateResourceDefinition(CreateResourceDefinitionRequest request)
        {
            var marshaller = CreateResourceDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateResourceDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateResourceDefinitionRequest,CreateResourceDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinition">REST API Reference for CreateResourceDefinition Operation</seealso>
        public virtual Task<CreateResourceDefinitionResponse> CreateResourceDefinitionAsync(CreateResourceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateResourceDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateResourceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceDefinitionRequest,CreateResourceDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateResourceDefinitionVersion


        /// <summary>
        /// Creates a version of a resource definition that has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the CreateResourceDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinitionVersion">REST API Reference for CreateResourceDefinitionVersion Operation</seealso>
        public virtual CreateResourceDefinitionVersionResponse CreateResourceDefinitionVersion(CreateResourceDefinitionVersionRequest request)
        {
            var marshaller = CreateResourceDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateResourceDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<CreateResourceDefinitionVersionRequest,CreateResourceDefinitionVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDefinitionVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinitionVersion">REST API Reference for CreateResourceDefinitionVersion Operation</seealso>
        public virtual Task<CreateResourceDefinitionVersionResponse> CreateResourceDefinitionVersionAsync(CreateResourceDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateResourceDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateResourceDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceDefinitionVersionRequest,CreateResourceDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSoftwareUpdateJob


        /// <summary>
        /// Creates a software update for a core or group of cores (specified as an IoT thing
        /// group.) Use this to update the OTA Agent as well as the Greengrass core software.
        /// It makes use of the IoT Jobs feature which provides additional commands to manage
        /// a Greengrass core software update job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSoftwareUpdateJob service method.</param>
        /// 
        /// <returns>The response from the CreateSoftwareUpdateJob service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSoftwareUpdateJob">REST API Reference for CreateSoftwareUpdateJob Operation</seealso>
        public virtual CreateSoftwareUpdateJobResponse CreateSoftwareUpdateJob(CreateSoftwareUpdateJobRequest request)
        {
            var marshaller = CreateSoftwareUpdateJobRequestMarshaller.Instance;
            var unmarshaller = CreateSoftwareUpdateJobResponseUnmarshaller.Instance;

            return Invoke<CreateSoftwareUpdateJobRequest,CreateSoftwareUpdateJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSoftwareUpdateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSoftwareUpdateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSoftwareUpdateJob">REST API Reference for CreateSoftwareUpdateJob Operation</seealso>
        public virtual Task<CreateSoftwareUpdateJobResponse> CreateSoftwareUpdateJobAsync(CreateSoftwareUpdateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSoftwareUpdateJobRequestMarshaller.Instance;
            var unmarshaller = CreateSoftwareUpdateJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSoftwareUpdateJobRequest,CreateSoftwareUpdateJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSubscriptionDefinition


        /// <summary>
        /// Creates a subscription definition. You may provide the initial version of the subscription
        /// definition now or use ''CreateSubscriptionDefinitionVersion'' at a later time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriptionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinition">REST API Reference for CreateSubscriptionDefinition Operation</seealso>
        public virtual CreateSubscriptionDefinitionResponse CreateSubscriptionDefinition(CreateSubscriptionDefinitionRequest request)
        {
            var marshaller = CreateSubscriptionDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateSubscriptionDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionDefinitionRequest,CreateSubscriptionDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinition">REST API Reference for CreateSubscriptionDefinition Operation</seealso>
        public virtual Task<CreateSubscriptionDefinitionResponse> CreateSubscriptionDefinitionAsync(CreateSubscriptionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSubscriptionDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateSubscriptionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubscriptionDefinitionRequest,CreateSubscriptionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSubscriptionDefinitionVersion


        /// <summary>
        /// Creates a version of a subscription definition which has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriptionDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinitionVersion">REST API Reference for CreateSubscriptionDefinitionVersion Operation</seealso>
        public virtual CreateSubscriptionDefinitionVersionResponse CreateSubscriptionDefinitionVersion(CreateSubscriptionDefinitionVersionRequest request)
        {
            var marshaller = CreateSubscriptionDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateSubscriptionDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionDefinitionVersionRequest,CreateSubscriptionDefinitionVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscriptionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionDefinitionVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinitionVersion">REST API Reference for CreateSubscriptionDefinitionVersion Operation</seealso>
        public virtual Task<CreateSubscriptionDefinitionVersionResponse> CreateSubscriptionDefinitionVersionAsync(CreateSubscriptionDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSubscriptionDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateSubscriptionDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubscriptionDefinitionVersionRequest,CreateSubscriptionDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCoreDefinition


        /// <summary>
        /// Deletes a core definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteCoreDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteCoreDefinition">REST API Reference for DeleteCoreDefinition Operation</seealso>
        public virtual DeleteCoreDefinitionResponse DeleteCoreDefinition(DeleteCoreDefinitionRequest request)
        {
            var marshaller = DeleteCoreDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteCoreDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteCoreDefinitionRequest,DeleteCoreDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteCoreDefinition">REST API Reference for DeleteCoreDefinition Operation</seealso>
        public virtual Task<DeleteCoreDefinitionResponse> DeleteCoreDefinitionAsync(DeleteCoreDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteCoreDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteCoreDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCoreDefinitionRequest,DeleteCoreDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDeviceDefinition


        /// <summary>
        /// Deletes a device definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteDeviceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteDeviceDefinition">REST API Reference for DeleteDeviceDefinition Operation</seealso>
        public virtual DeleteDeviceDefinitionResponse DeleteDeviceDefinition(DeleteDeviceDefinitionRequest request)
        {
            var marshaller = DeleteDeviceDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteDeviceDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteDeviceDefinitionRequest,DeleteDeviceDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteDeviceDefinition">REST API Reference for DeleteDeviceDefinition Operation</seealso>
        public virtual Task<DeleteDeviceDefinitionResponse> DeleteDeviceDefinitionAsync(DeleteDeviceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDeviceDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteDeviceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeviceDefinitionRequest,DeleteDeviceDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFunctionDefinition


        /// <summary>
        /// Deletes a Lambda function definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteFunctionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteFunctionDefinition">REST API Reference for DeleteFunctionDefinition Operation</seealso>
        public virtual DeleteFunctionDefinitionResponse DeleteFunctionDefinition(DeleteFunctionDefinitionRequest request)
        {
            var marshaller = DeleteFunctionDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteFunctionDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionDefinitionRequest,DeleteFunctionDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteFunctionDefinition">REST API Reference for DeleteFunctionDefinition Operation</seealso>
        public virtual Task<DeleteFunctionDefinitionResponse> DeleteFunctionDefinitionAsync(DeleteFunctionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteFunctionDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteFunctionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFunctionDefinitionRequest,DeleteFunctionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var marshaller = DeleteGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupRequest,DeleteGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupRequest,DeleteGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoggerDefinition


        /// <summary>
        /// Deletes a logger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggerDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteLoggerDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteLoggerDefinition">REST API Reference for DeleteLoggerDefinition Operation</seealso>
        public virtual DeleteLoggerDefinitionResponse DeleteLoggerDefinition(DeleteLoggerDefinitionRequest request)
        {
            var marshaller = DeleteLoggerDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteLoggerDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteLoggerDefinitionRequest,DeleteLoggerDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggerDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteLoggerDefinition">REST API Reference for DeleteLoggerDefinition Operation</seealso>
        public virtual Task<DeleteLoggerDefinitionResponse> DeleteLoggerDefinitionAsync(DeleteLoggerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteLoggerDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteLoggerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoggerDefinitionRequest,DeleteLoggerDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourceDefinition


        /// <summary>
        /// Deletes a resource definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteResourceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteResourceDefinition">REST API Reference for DeleteResourceDefinition Operation</seealso>
        public virtual DeleteResourceDefinitionResponse DeleteResourceDefinition(DeleteResourceDefinitionRequest request)
        {
            var marshaller = DeleteResourceDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteResourceDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceDefinitionRequest,DeleteResourceDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteResourceDefinition">REST API Reference for DeleteResourceDefinition Operation</seealso>
        public virtual Task<DeleteResourceDefinitionResponse> DeleteResourceDefinitionAsync(DeleteResourceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteResourceDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteResourceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourceDefinitionRequest,DeleteResourceDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubscriptionDefinition


        /// <summary>
        /// Deletes a subscription definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriptionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteSubscriptionDefinition">REST API Reference for DeleteSubscriptionDefinition Operation</seealso>
        public virtual DeleteSubscriptionDefinitionResponse DeleteSubscriptionDefinition(DeleteSubscriptionDefinitionRequest request)
        {
            var marshaller = DeleteSubscriptionDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteSubscriptionDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionDefinitionRequest,DeleteSubscriptionDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteSubscriptionDefinition">REST API Reference for DeleteSubscriptionDefinition Operation</seealso>
        public virtual Task<DeleteSubscriptionDefinitionResponse> DeleteSubscriptionDefinitionAsync(DeleteSubscriptionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSubscriptionDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteSubscriptionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubscriptionDefinitionRequest,DeleteSubscriptionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateRoleFromGroup


        /// <summary>
        /// Disassociates the role from a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRoleFromGroup service method.</param>
        /// 
        /// <returns>The response from the DisassociateRoleFromGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateRoleFromGroup">REST API Reference for DisassociateRoleFromGroup Operation</seealso>
        public virtual DisassociateRoleFromGroupResponse DisassociateRoleFromGroup(DisassociateRoleFromGroupRequest request)
        {
            var marshaller = DisassociateRoleFromGroupRequestMarshaller.Instance;
            var unmarshaller = DisassociateRoleFromGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociateRoleFromGroupRequest,DisassociateRoleFromGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRoleFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRoleFromGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateRoleFromGroup">REST API Reference for DisassociateRoleFromGroup Operation</seealso>
        public virtual Task<DisassociateRoleFromGroupResponse> DisassociateRoleFromGroupAsync(DisassociateRoleFromGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateRoleFromGroupRequestMarshaller.Instance;
            var unmarshaller = DisassociateRoleFromGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateRoleFromGroupRequest,DisassociateRoleFromGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateServiceRoleFromAccount


        /// <summary>
        /// Disassociates the service role from your account. Without a service role, deployments
        /// will not work.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceRoleFromAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateServiceRoleFromAccount service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateServiceRoleFromAccount">REST API Reference for DisassociateServiceRoleFromAccount Operation</seealso>
        public virtual DisassociateServiceRoleFromAccountResponse DisassociateServiceRoleFromAccount(DisassociateServiceRoleFromAccountRequest request)
        {
            var marshaller = DisassociateServiceRoleFromAccountRequestMarshaller.Instance;
            var unmarshaller = DisassociateServiceRoleFromAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateServiceRoleFromAccountRequest,DisassociateServiceRoleFromAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateServiceRoleFromAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceRoleFromAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateServiceRoleFromAccount">REST API Reference for DisassociateServiceRoleFromAccount Operation</seealso>
        public virtual Task<DisassociateServiceRoleFromAccountResponse> DisassociateServiceRoleFromAccountAsync(DisassociateServiceRoleFromAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateServiceRoleFromAccountRequestMarshaller.Instance;
            var unmarshaller = DisassociateServiceRoleFromAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateServiceRoleFromAccountRequest,DisassociateServiceRoleFromAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAssociatedRole


        /// <summary>
        /// Retrieves the role associated with a particular group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociatedRole service method.</param>
        /// 
        /// <returns>The response from the GetAssociatedRole service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetAssociatedRole">REST API Reference for GetAssociatedRole Operation</seealso>
        public virtual GetAssociatedRoleResponse GetAssociatedRole(GetAssociatedRoleRequest request)
        {
            var marshaller = GetAssociatedRoleRequestMarshaller.Instance;
            var unmarshaller = GetAssociatedRoleResponseUnmarshaller.Instance;

            return Invoke<GetAssociatedRoleRequest,GetAssociatedRoleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssociatedRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssociatedRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetAssociatedRole">REST API Reference for GetAssociatedRole Operation</seealso>
        public virtual Task<GetAssociatedRoleResponse> GetAssociatedRoleAsync(GetAssociatedRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAssociatedRoleRequestMarshaller.Instance;
            var unmarshaller = GetAssociatedRoleResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssociatedRoleRequest,GetAssociatedRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConnectivityInfo


        /// <summary>
        /// Retrieves the connectivity information for a core.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectivityInfo service method.</param>
        /// 
        /// <returns>The response from the GetConnectivityInfo service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetConnectivityInfo">REST API Reference for GetConnectivityInfo Operation</seealso>
        public virtual GetConnectivityInfoResponse GetConnectivityInfo(GetConnectivityInfoRequest request)
        {
            var marshaller = GetConnectivityInfoRequestMarshaller.Instance;
            var unmarshaller = GetConnectivityInfoResponseUnmarshaller.Instance;

            return Invoke<GetConnectivityInfoRequest,GetConnectivityInfoResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectivityInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectivityInfo operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetConnectivityInfo">REST API Reference for GetConnectivityInfo Operation</seealso>
        public virtual Task<GetConnectivityInfoResponse> GetConnectivityInfoAsync(GetConnectivityInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetConnectivityInfoRequestMarshaller.Instance;
            var unmarshaller = GetConnectivityInfoResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectivityInfoRequest,GetConnectivityInfoResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCoreDefinition


        /// <summary>
        /// Retrieves information about a core definition version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDefinition service method.</param>
        /// 
        /// <returns>The response from the GetCoreDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinition">REST API Reference for GetCoreDefinition Operation</seealso>
        public virtual GetCoreDefinitionResponse GetCoreDefinition(GetCoreDefinitionRequest request)
        {
            var marshaller = GetCoreDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetCoreDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetCoreDefinitionRequest,GetCoreDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinition">REST API Reference for GetCoreDefinition Operation</seealso>
        public virtual Task<GetCoreDefinitionResponse> GetCoreDefinitionAsync(GetCoreDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCoreDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetCoreDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetCoreDefinitionRequest,GetCoreDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCoreDefinitionVersion


        /// <summary>
        /// Retrieves information about a core definition version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the GetCoreDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinitionVersion">REST API Reference for GetCoreDefinitionVersion Operation</seealso>
        public virtual GetCoreDefinitionVersionResponse GetCoreDefinitionVersion(GetCoreDefinitionVersionRequest request)
        {
            var marshaller = GetCoreDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetCoreDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<GetCoreDefinitionVersionRequest,GetCoreDefinitionVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCoreDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDefinitionVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinitionVersion">REST API Reference for GetCoreDefinitionVersion Operation</seealso>
        public virtual Task<GetCoreDefinitionVersionResponse> GetCoreDefinitionVersionAsync(GetCoreDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCoreDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetCoreDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetCoreDefinitionVersionRequest,GetCoreDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeploymentStatus


        /// <summary>
        /// Returns the status of a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentStatus service method.</param>
        /// 
        /// <returns>The response from the GetDeploymentStatus service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeploymentStatus">REST API Reference for GetDeploymentStatus Operation</seealso>
        public virtual GetDeploymentStatusResponse GetDeploymentStatus(GetDeploymentStatusRequest request)
        {
            var marshaller = GetDeploymentStatusRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentStatusResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentStatusRequest,GetDeploymentStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeploymentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeploymentStatus">REST API Reference for GetDeploymentStatus Operation</seealso>
        public virtual Task<GetDeploymentStatusResponse> GetDeploymentStatusAsync(GetDeploymentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDeploymentStatusRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentStatusRequest,GetDeploymentStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeviceDefinition


        /// <summary>
        /// Retrieves information about a device definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceDefinition service method.</param>
        /// 
        /// <returns>The response from the GetDeviceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinition">REST API Reference for GetDeviceDefinition Operation</seealso>
        public virtual GetDeviceDefinitionResponse GetDeviceDefinition(GetDeviceDefinitionRequest request)
        {
            var marshaller = GetDeviceDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetDeviceDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetDeviceDefinitionRequest,GetDeviceDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinition">REST API Reference for GetDeviceDefinition Operation</seealso>
        public virtual Task<GetDeviceDefinitionResponse> GetDeviceDefinitionAsync(GetDeviceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDeviceDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetDeviceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceDefinitionRequest,GetDeviceDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeviceDefinitionVersion


        /// <summary>
        /// Retrieves information about a device definition version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the GetDeviceDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinitionVersion">REST API Reference for GetDeviceDefinitionVersion Operation</seealso>
        public virtual GetDeviceDefinitionVersionResponse GetDeviceDefinitionVersion(GetDeviceDefinitionVersionRequest request)
        {
            var marshaller = GetDeviceDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetDeviceDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<GetDeviceDefinitionVersionRequest,GetDeviceDefinitionVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceDefinitionVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinitionVersion">REST API Reference for GetDeviceDefinitionVersion Operation</seealso>
        public virtual Task<GetDeviceDefinitionVersionResponse> GetDeviceDefinitionVersionAsync(GetDeviceDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDeviceDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetDeviceDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceDefinitionVersionRequest,GetDeviceDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFunctionDefinition


        /// <summary>
        /// Retrieves information about a Lambda function definition, including its creation time
        /// and latest version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionDefinition service method.</param>
        /// 
        /// <returns>The response from the GetFunctionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinition">REST API Reference for GetFunctionDefinition Operation</seealso>
        public virtual GetFunctionDefinitionResponse GetFunctionDefinition(GetFunctionDefinitionRequest request)
        {
            var marshaller = GetFunctionDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetFunctionDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetFunctionDefinitionRequest,GetFunctionDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinition">REST API Reference for GetFunctionDefinition Operation</seealso>
        public virtual Task<GetFunctionDefinitionResponse> GetFunctionDefinitionAsync(GetFunctionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetFunctionDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetFunctionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFunctionDefinitionRequest,GetFunctionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFunctionDefinitionVersion


        /// <summary>
        /// Retrieves information about a Lambda function definition version, including which
        /// Lambda functions are included in the version and their configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the GetFunctionDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinitionVersion">REST API Reference for GetFunctionDefinitionVersion Operation</seealso>
        public virtual GetFunctionDefinitionVersionResponse GetFunctionDefinitionVersion(GetFunctionDefinitionVersionRequest request)
        {
            var marshaller = GetFunctionDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetFunctionDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<GetFunctionDefinitionVersionRequest,GetFunctionDefinitionVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunctionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionDefinitionVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinitionVersion">REST API Reference for GetFunctionDefinitionVersion Operation</seealso>
        public virtual Task<GetFunctionDefinitionVersionResponse> GetFunctionDefinitionVersionAsync(GetFunctionDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetFunctionDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetFunctionDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFunctionDefinitionVersionRequest,GetFunctionDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGroup


        /// <summary>
        /// Retrieves information about a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var marshaller = GetGroupRequestMarshaller.Instance;
            var unmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupRequest,GetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetGroupRequestMarshaller.Instance;
            var unmarshaller = GetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupRequest,GetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGroupCertificateAuthority


        /// <summary>
        /// Retreives the CA associated with a group. Returns the public key of the CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the GetGroupCertificateAuthority service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateAuthority">REST API Reference for GetGroupCertificateAuthority Operation</seealso>
        public virtual GetGroupCertificateAuthorityResponse GetGroupCertificateAuthority(GetGroupCertificateAuthorityRequest request)
        {
            var marshaller = GetGroupCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = GetGroupCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<GetGroupCertificateAuthorityRequest,GetGroupCertificateAuthorityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateAuthority">REST API Reference for GetGroupCertificateAuthority Operation</seealso>
        public virtual Task<GetGroupCertificateAuthorityResponse> GetGroupCertificateAuthorityAsync(GetGroupCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetGroupCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = GetGroupCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupCertificateAuthorityRequest,GetGroupCertificateAuthorityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGroupCertificateConfiguration


        /// <summary>
        /// Retrieves the current configuration for the CA used by the group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupCertificateConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetGroupCertificateConfiguration service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateConfiguration">REST API Reference for GetGroupCertificateConfiguration Operation</seealso>
        public virtual GetGroupCertificateConfigurationResponse GetGroupCertificateConfiguration(GetGroupCertificateConfigurationRequest request)
        {
            var marshaller = GetGroupCertificateConfigurationRequestMarshaller.Instance;
            var unmarshaller = GetGroupCertificateConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetGroupCertificateConfigurationRequest,GetGroupCertificateConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupCertificateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupCertificateConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateConfiguration">REST API Reference for GetGroupCertificateConfiguration Operation</seealso>
        public virtual Task<GetGroupCertificateConfigurationResponse> GetGroupCertificateConfigurationAsync(GetGroupCertificateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetGroupCertificateConfigurationRequestMarshaller.Instance;
            var unmarshaller = GetGroupCertificateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupCertificateConfigurationRequest,GetGroupCertificateConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGroupVersion


        /// <summary>
        /// Retrieves information about a group version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupVersion service method.</param>
        /// 
        /// <returns>The response from the GetGroupVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupVersion">REST API Reference for GetGroupVersion Operation</seealso>
        public virtual GetGroupVersionResponse GetGroupVersion(GetGroupVersionRequest request)
        {
            var marshaller = GetGroupVersionRequestMarshaller.Instance;
            var unmarshaller = GetGroupVersionResponseUnmarshaller.Instance;

            return Invoke<GetGroupVersionRequest,GetGroupVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupVersion">REST API Reference for GetGroupVersion Operation</seealso>
        public virtual Task<GetGroupVersionResponse> GetGroupVersionAsync(GetGroupVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetGroupVersionRequestMarshaller.Instance;
            var unmarshaller = GetGroupVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupVersionRequest,GetGroupVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetLoggerDefinition


        /// <summary>
        /// Retrieves information about a logger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggerDefinition service method.</param>
        /// 
        /// <returns>The response from the GetLoggerDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinition">REST API Reference for GetLoggerDefinition Operation</seealso>
        public virtual GetLoggerDefinitionResponse GetLoggerDefinition(GetLoggerDefinitionRequest request)
        {
            var marshaller = GetLoggerDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetLoggerDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetLoggerDefinitionRequest,GetLoggerDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoggerDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinition">REST API Reference for GetLoggerDefinition Operation</seealso>
        public virtual Task<GetLoggerDefinitionResponse> GetLoggerDefinitionAsync(GetLoggerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetLoggerDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetLoggerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoggerDefinitionRequest,GetLoggerDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetLoggerDefinitionVersion


        /// <summary>
        /// Retrieves information about a logger definition version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggerDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the GetLoggerDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinitionVersion">REST API Reference for GetLoggerDefinitionVersion Operation</seealso>
        public virtual GetLoggerDefinitionVersionResponse GetLoggerDefinitionVersion(GetLoggerDefinitionVersionRequest request)
        {
            var marshaller = GetLoggerDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetLoggerDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<GetLoggerDefinitionVersionRequest,GetLoggerDefinitionVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoggerDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoggerDefinitionVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinitionVersion">REST API Reference for GetLoggerDefinitionVersion Operation</seealso>
        public virtual Task<GetLoggerDefinitionVersionResponse> GetLoggerDefinitionVersionAsync(GetLoggerDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetLoggerDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetLoggerDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoggerDefinitionVersionRequest,GetLoggerDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetResourceDefinition


        /// <summary>
        /// Retrieves information about a resource definition, including its creation time and
        /// latest version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceDefinition service method.</param>
        /// 
        /// <returns>The response from the GetResourceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinition">REST API Reference for GetResourceDefinition Operation</seealso>
        public virtual GetResourceDefinitionResponse GetResourceDefinition(GetResourceDefinitionRequest request)
        {
            var marshaller = GetResourceDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetResourceDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetResourceDefinitionRequest,GetResourceDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinition">REST API Reference for GetResourceDefinition Operation</seealso>
        public virtual Task<GetResourceDefinitionResponse> GetResourceDefinitionAsync(GetResourceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetResourceDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetResourceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceDefinitionRequest,GetResourceDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetResourceDefinitionVersion


        /// <summary>
        /// Retrieves information about a resource definition version, including which resources
        /// are included in the version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the GetResourceDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinitionVersion">REST API Reference for GetResourceDefinitionVersion Operation</seealso>
        public virtual GetResourceDefinitionVersionResponse GetResourceDefinitionVersion(GetResourceDefinitionVersionRequest request)
        {
            var marshaller = GetResourceDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetResourceDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<GetResourceDefinitionVersionRequest,GetResourceDefinitionVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceDefinitionVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinitionVersion">REST API Reference for GetResourceDefinitionVersion Operation</seealso>
        public virtual Task<GetResourceDefinitionVersionResponse> GetResourceDefinitionVersionAsync(GetResourceDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetResourceDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetResourceDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceDefinitionVersionRequest,GetResourceDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetServiceRoleForAccount


        /// <summary>
        /// Retrieves the service role that is attached to your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceRoleForAccount service method.</param>
        /// 
        /// <returns>The response from the GetServiceRoleForAccount service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetServiceRoleForAccount">REST API Reference for GetServiceRoleForAccount Operation</seealso>
        public virtual GetServiceRoleForAccountResponse GetServiceRoleForAccount(GetServiceRoleForAccountRequest request)
        {
            var marshaller = GetServiceRoleForAccountRequestMarshaller.Instance;
            var unmarshaller = GetServiceRoleForAccountResponseUnmarshaller.Instance;

            return Invoke<GetServiceRoleForAccountRequest,GetServiceRoleForAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceRoleForAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceRoleForAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetServiceRoleForAccount">REST API Reference for GetServiceRoleForAccount Operation</seealso>
        public virtual Task<GetServiceRoleForAccountResponse> GetServiceRoleForAccountAsync(GetServiceRoleForAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetServiceRoleForAccountRequestMarshaller.Instance;
            var unmarshaller = GetServiceRoleForAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceRoleForAccountRequest,GetServiceRoleForAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSubscriptionDefinition


        /// <summary>
        /// Retrieves information about a subscription definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionDefinition service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinition">REST API Reference for GetSubscriptionDefinition Operation</seealso>
        public virtual GetSubscriptionDefinitionResponse GetSubscriptionDefinition(GetSubscriptionDefinitionRequest request)
        {
            var marshaller = GetSubscriptionDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetSubscriptionDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionDefinitionRequest,GetSubscriptionDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinition">REST API Reference for GetSubscriptionDefinition Operation</seealso>
        public virtual Task<GetSubscriptionDefinitionResponse> GetSubscriptionDefinitionAsync(GetSubscriptionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSubscriptionDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetSubscriptionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSubscriptionDefinitionRequest,GetSubscriptionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSubscriptionDefinitionVersion


        /// <summary>
        /// Retrieves information about a subscription definition version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinitionVersion">REST API Reference for GetSubscriptionDefinitionVersion Operation</seealso>
        public virtual GetSubscriptionDefinitionVersionResponse GetSubscriptionDefinitionVersion(GetSubscriptionDefinitionVersionRequest request)
        {
            var marshaller = GetSubscriptionDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetSubscriptionDefinitionVersionResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionDefinitionVersionRequest,GetSubscriptionDefinitionVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriptionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionDefinitionVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinitionVersion">REST API Reference for GetSubscriptionDefinitionVersion Operation</seealso>
        public virtual Task<GetSubscriptionDefinitionVersionResponse> GetSubscriptionDefinitionVersionAsync(GetSubscriptionDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSubscriptionDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetSubscriptionDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSubscriptionDefinitionVersionRequest,GetSubscriptionDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCoreDefinitions


        /// <summary>
        /// Retrieves a list of core definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListCoreDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitions">REST API Reference for ListCoreDefinitions Operation</seealso>
        public virtual ListCoreDefinitionsResponse ListCoreDefinitions(ListCoreDefinitionsRequest request)
        {
            var marshaller = ListCoreDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListCoreDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListCoreDefinitionsRequest,ListCoreDefinitionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCoreDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDefinitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitions">REST API Reference for ListCoreDefinitions Operation</seealso>
        public virtual Task<ListCoreDefinitionsResponse> ListCoreDefinitionsAsync(ListCoreDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListCoreDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListCoreDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCoreDefinitionsRequest,ListCoreDefinitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCoreDefinitionVersions


        /// <summary>
        /// Lists the versions of a core definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDefinitionVersions service method.</param>
        /// 
        /// <returns>The response from the ListCoreDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitionVersions">REST API Reference for ListCoreDefinitionVersions Operation</seealso>
        public virtual ListCoreDefinitionVersionsResponse ListCoreDefinitionVersions(ListCoreDefinitionVersionsRequest request)
        {
            var marshaller = ListCoreDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListCoreDefinitionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListCoreDefinitionVersionsRequest,ListCoreDefinitionVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCoreDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDefinitionVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitionVersions">REST API Reference for ListCoreDefinitionVersions Operation</seealso>
        public virtual Task<ListCoreDefinitionVersionsResponse> ListCoreDefinitionVersionsAsync(ListCoreDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListCoreDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListCoreDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCoreDefinitionVersionsRequest,ListCoreDefinitionVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeployments


        /// <summary>
        /// Returns a history of deployments for the group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request)
        {
            var marshaller = ListDeploymentsRequestMarshaller.Instance;
            var unmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentsRequest,ListDeploymentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDeploymentsRequestMarshaller.Instance;
            var unmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentsRequest,ListDeploymentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeviceDefinitions


        /// <summary>
        /// Retrieves a list of device definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListDeviceDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitions">REST API Reference for ListDeviceDefinitions Operation</seealso>
        public virtual ListDeviceDefinitionsResponse ListDeviceDefinitions(ListDeviceDefinitionsRequest request)
        {
            var marshaller = ListDeviceDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListDeviceDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListDeviceDefinitionsRequest,ListDeviceDefinitionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceDefinitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitions">REST API Reference for ListDeviceDefinitions Operation</seealso>
        public virtual Task<ListDeviceDefinitionsResponse> ListDeviceDefinitionsAsync(ListDeviceDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDeviceDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListDeviceDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeviceDefinitionsRequest,ListDeviceDefinitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeviceDefinitionVersions


        /// <summary>
        /// Lists the versions of a device definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceDefinitionVersions service method.</param>
        /// 
        /// <returns>The response from the ListDeviceDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitionVersions">REST API Reference for ListDeviceDefinitionVersions Operation</seealso>
        public virtual ListDeviceDefinitionVersionsResponse ListDeviceDefinitionVersions(ListDeviceDefinitionVersionsRequest request)
        {
            var marshaller = ListDeviceDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListDeviceDefinitionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListDeviceDefinitionVersionsRequest,ListDeviceDefinitionVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceDefinitionVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitionVersions">REST API Reference for ListDeviceDefinitionVersions Operation</seealso>
        public virtual Task<ListDeviceDefinitionVersionsResponse> ListDeviceDefinitionVersionsAsync(ListDeviceDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDeviceDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListDeviceDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeviceDefinitionVersionsRequest,ListDeviceDefinitionVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFunctionDefinitions


        /// <summary>
        /// Retrieves a list of Lambda function definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListFunctionDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitions">REST API Reference for ListFunctionDefinitions Operation</seealso>
        public virtual ListFunctionDefinitionsResponse ListFunctionDefinitions(ListFunctionDefinitionsRequest request)
        {
            var marshaller = ListFunctionDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListFunctionDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListFunctionDefinitionsRequest,ListFunctionDefinitionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctionDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionDefinitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitions">REST API Reference for ListFunctionDefinitions Operation</seealso>
        public virtual Task<ListFunctionDefinitionsResponse> ListFunctionDefinitionsAsync(ListFunctionDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListFunctionDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListFunctionDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFunctionDefinitionsRequest,ListFunctionDefinitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFunctionDefinitionVersions


        /// <summary>
        /// Lists the versions of a Lambda function definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionDefinitionVersions service method.</param>
        /// 
        /// <returns>The response from the ListFunctionDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitionVersions">REST API Reference for ListFunctionDefinitionVersions Operation</seealso>
        public virtual ListFunctionDefinitionVersionsResponse ListFunctionDefinitionVersions(ListFunctionDefinitionVersionsRequest request)
        {
            var marshaller = ListFunctionDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListFunctionDefinitionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListFunctionDefinitionVersionsRequest,ListFunctionDefinitionVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctionDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionDefinitionVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitionVersions">REST API Reference for ListFunctionDefinitionVersions Operation</seealso>
        public virtual Task<ListFunctionDefinitionVersionsResponse> ListFunctionDefinitionVersionsAsync(ListFunctionDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListFunctionDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListFunctionDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFunctionDefinitionVersionsRequest,ListFunctionDefinitionVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGroupCertificateAuthorities


        /// <summary>
        /// Retrieves the current CAs for a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupCertificateAuthorities service method.</param>
        /// 
        /// <returns>The response from the ListGroupCertificateAuthorities service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupCertificateAuthorities">REST API Reference for ListGroupCertificateAuthorities Operation</seealso>
        public virtual ListGroupCertificateAuthoritiesResponse ListGroupCertificateAuthorities(ListGroupCertificateAuthoritiesRequest request)
        {
            var marshaller = ListGroupCertificateAuthoritiesRequestMarshaller.Instance;
            var unmarshaller = ListGroupCertificateAuthoritiesResponseUnmarshaller.Instance;

            return Invoke<ListGroupCertificateAuthoritiesRequest,ListGroupCertificateAuthoritiesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupCertificateAuthorities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupCertificateAuthorities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupCertificateAuthorities">REST API Reference for ListGroupCertificateAuthorities Operation</seealso>
        public virtual Task<ListGroupCertificateAuthoritiesResponse> ListGroupCertificateAuthoritiesAsync(ListGroupCertificateAuthoritiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListGroupCertificateAuthoritiesRequestMarshaller.Instance;
            var unmarshaller = ListGroupCertificateAuthoritiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupCertificateAuthoritiesRequest,ListGroupCertificateAuthoritiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Retrieves a list of groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var marshaller = ListGroupsRequestMarshaller.Instance;
            var unmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsRequest,ListGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListGroupsRequestMarshaller.Instance;
            var unmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupsRequest,ListGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGroupVersions


        /// <summary>
        /// Lists the versions of a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupVersions service method.</param>
        /// 
        /// <returns>The response from the ListGroupVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupVersions">REST API Reference for ListGroupVersions Operation</seealso>
        public virtual ListGroupVersionsResponse ListGroupVersions(ListGroupVersionsRequest request)
        {
            var marshaller = ListGroupVersionsRequestMarshaller.Instance;
            var unmarshaller = ListGroupVersionsResponseUnmarshaller.Instance;

            return Invoke<ListGroupVersionsRequest,ListGroupVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupVersions">REST API Reference for ListGroupVersions Operation</seealso>
        public virtual Task<ListGroupVersionsResponse> ListGroupVersionsAsync(ListGroupVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListGroupVersionsRequestMarshaller.Instance;
            var unmarshaller = ListGroupVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupVersionsRequest,ListGroupVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListLoggerDefinitions


        /// <summary>
        /// Retrieves a list of logger definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggerDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListLoggerDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitions">REST API Reference for ListLoggerDefinitions Operation</seealso>
        public virtual ListLoggerDefinitionsResponse ListLoggerDefinitions(ListLoggerDefinitionsRequest request)
        {
            var marshaller = ListLoggerDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListLoggerDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListLoggerDefinitionsRequest,ListLoggerDefinitionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLoggerDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLoggerDefinitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitions">REST API Reference for ListLoggerDefinitions Operation</seealso>
        public virtual Task<ListLoggerDefinitionsResponse> ListLoggerDefinitionsAsync(ListLoggerDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListLoggerDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListLoggerDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLoggerDefinitionsRequest,ListLoggerDefinitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListLoggerDefinitionVersions


        /// <summary>
        /// Lists the versions of a logger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggerDefinitionVersions service method.</param>
        /// 
        /// <returns>The response from the ListLoggerDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitionVersions">REST API Reference for ListLoggerDefinitionVersions Operation</seealso>
        public virtual ListLoggerDefinitionVersionsResponse ListLoggerDefinitionVersions(ListLoggerDefinitionVersionsRequest request)
        {
            var marshaller = ListLoggerDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListLoggerDefinitionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListLoggerDefinitionVersionsRequest,ListLoggerDefinitionVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLoggerDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLoggerDefinitionVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitionVersions">REST API Reference for ListLoggerDefinitionVersions Operation</seealso>
        public virtual Task<ListLoggerDefinitionVersionsResponse> ListLoggerDefinitionVersionsAsync(ListLoggerDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListLoggerDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListLoggerDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLoggerDefinitionVersionsRequest,ListLoggerDefinitionVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListResourceDefinitions


        /// <summary>
        /// Retrieves a list of resource definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListResourceDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitions">REST API Reference for ListResourceDefinitions Operation</seealso>
        public virtual ListResourceDefinitionsResponse ListResourceDefinitions(ListResourceDefinitionsRequest request)
        {
            var marshaller = ListResourceDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListResourceDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListResourceDefinitionsRequest,ListResourceDefinitionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDefinitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitions">REST API Reference for ListResourceDefinitions Operation</seealso>
        public virtual Task<ListResourceDefinitionsResponse> ListResourceDefinitionsAsync(ListResourceDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListResourceDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListResourceDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceDefinitionsRequest,ListResourceDefinitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListResourceDefinitionVersions


        /// <summary>
        /// Lists the versions of a resource definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDefinitionVersions service method.</param>
        /// 
        /// <returns>The response from the ListResourceDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitionVersions">REST API Reference for ListResourceDefinitionVersions Operation</seealso>
        public virtual ListResourceDefinitionVersionsResponse ListResourceDefinitionVersions(ListResourceDefinitionVersionsRequest request)
        {
            var marshaller = ListResourceDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListResourceDefinitionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListResourceDefinitionVersionsRequest,ListResourceDefinitionVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDefinitionVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitionVersions">REST API Reference for ListResourceDefinitionVersions Operation</seealso>
        public virtual Task<ListResourceDefinitionVersionsResponse> ListResourceDefinitionVersionsAsync(ListResourceDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListResourceDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListResourceDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceDefinitionVersionsRequest,ListResourceDefinitionVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSubscriptionDefinitions


        /// <summary>
        /// Retrieves a list of subscription definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptionDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitions">REST API Reference for ListSubscriptionDefinitions Operation</seealso>
        public virtual ListSubscriptionDefinitionsResponse ListSubscriptionDefinitions(ListSubscriptionDefinitionsRequest request)
        {
            var marshaller = ListSubscriptionDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListSubscriptionDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionDefinitionsRequest,ListSubscriptionDefinitionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptionDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionDefinitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitions">REST API Reference for ListSubscriptionDefinitions Operation</seealso>
        public virtual Task<ListSubscriptionDefinitionsResponse> ListSubscriptionDefinitionsAsync(ListSubscriptionDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListSubscriptionDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListSubscriptionDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscriptionDefinitionsRequest,ListSubscriptionDefinitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSubscriptionDefinitionVersions


        /// <summary>
        /// Lists the versions of a subscription definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionDefinitionVersions service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptionDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitionVersions">REST API Reference for ListSubscriptionDefinitionVersions Operation</seealso>
        public virtual ListSubscriptionDefinitionVersionsResponse ListSubscriptionDefinitionVersions(ListSubscriptionDefinitionVersionsRequest request)
        {
            var marshaller = ListSubscriptionDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListSubscriptionDefinitionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionDefinitionVersionsRequest,ListSubscriptionDefinitionVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptionDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionDefinitionVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitionVersions">REST API Reference for ListSubscriptionDefinitionVersions Operation</seealso>
        public virtual Task<ListSubscriptionDefinitionVersionsResponse> ListSubscriptionDefinitionVersionsAsync(ListSubscriptionDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListSubscriptionDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListSubscriptionDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscriptionDefinitionVersionsRequest,ListSubscriptionDefinitionVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetDeployments


        /// <summary>
        /// Resets a group's deployments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDeployments service method.</param>
        /// 
        /// <returns>The response from the ResetDeployments service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ResetDeployments">REST API Reference for ResetDeployments Operation</seealso>
        public virtual ResetDeploymentsResponse ResetDeployments(ResetDeploymentsRequest request)
        {
            var marshaller = ResetDeploymentsRequestMarshaller.Instance;
            var unmarshaller = ResetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ResetDeploymentsRequest,ResetDeploymentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDeployments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ResetDeployments">REST API Reference for ResetDeployments Operation</seealso>
        public virtual Task<ResetDeploymentsResponse> ResetDeploymentsAsync(ResetDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ResetDeploymentsRequestMarshaller.Instance;
            var unmarshaller = ResetDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ResetDeploymentsRequest,ResetDeploymentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateConnectivityInfo


        /// <summary>
        /// Updates the connectivity information for the core. Any devices that belong to the
        /// group which has this core will receive this information in order to find the location
        /// of the core and connect to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectivityInfo service method.</param>
        /// 
        /// <returns>The response from the UpdateConnectivityInfo service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateConnectivityInfo">REST API Reference for UpdateConnectivityInfo Operation</seealso>
        public virtual UpdateConnectivityInfoResponse UpdateConnectivityInfo(UpdateConnectivityInfoRequest request)
        {
            var marshaller = UpdateConnectivityInfoRequestMarshaller.Instance;
            var unmarshaller = UpdateConnectivityInfoResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectivityInfoRequest,UpdateConnectivityInfoResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnectivityInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectivityInfo operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateConnectivityInfo">REST API Reference for UpdateConnectivityInfo Operation</seealso>
        public virtual Task<UpdateConnectivityInfoResponse> UpdateConnectivityInfoAsync(UpdateConnectivityInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateConnectivityInfoRequestMarshaller.Instance;
            var unmarshaller = UpdateConnectivityInfoResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConnectivityInfoRequest,UpdateConnectivityInfoResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateCoreDefinition


        /// <summary>
        /// Updates a core definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCoreDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateCoreDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateCoreDefinition">REST API Reference for UpdateCoreDefinition Operation</seealso>
        public virtual UpdateCoreDefinitionResponse UpdateCoreDefinition(UpdateCoreDefinitionRequest request)
        {
            var marshaller = UpdateCoreDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateCoreDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateCoreDefinitionRequest,UpdateCoreDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCoreDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateCoreDefinition">REST API Reference for UpdateCoreDefinition Operation</seealso>
        public virtual Task<UpdateCoreDefinitionResponse> UpdateCoreDefinitionAsync(UpdateCoreDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateCoreDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateCoreDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCoreDefinitionRequest,UpdateCoreDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDeviceDefinition


        /// <summary>
        /// Updates a device definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateDeviceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateDeviceDefinition">REST API Reference for UpdateDeviceDefinition Operation</seealso>
        public virtual UpdateDeviceDefinitionResponse UpdateDeviceDefinition(UpdateDeviceDefinitionRequest request)
        {
            var marshaller = UpdateDeviceDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateDeviceDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceDefinitionRequest,UpdateDeviceDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateDeviceDefinition">REST API Reference for UpdateDeviceDefinition Operation</seealso>
        public virtual Task<UpdateDeviceDefinitionResponse> UpdateDeviceDefinitionAsync(UpdateDeviceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDeviceDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateDeviceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeviceDefinitionRequest,UpdateDeviceDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateFunctionDefinition


        /// <summary>
        /// Updates a Lambda function definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateFunctionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateFunctionDefinition">REST API Reference for UpdateFunctionDefinition Operation</seealso>
        public virtual UpdateFunctionDefinitionResponse UpdateFunctionDefinition(UpdateFunctionDefinitionRequest request)
        {
            var marshaller = UpdateFunctionDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateFunctionDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateFunctionDefinitionRequest,UpdateFunctionDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateFunctionDefinition">REST API Reference for UpdateFunctionDefinition Operation</seealso>
        public virtual Task<UpdateFunctionDefinitionResponse> UpdateFunctionDefinitionAsync(UpdateFunctionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateFunctionDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateFunctionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFunctionDefinitionRequest,UpdateFunctionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Updates a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var marshaller = UpdateGroupRequestMarshaller.Instance;
            var unmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupRequest,UpdateGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateGroupRequestMarshaller.Instance;
            var unmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGroupRequest,UpdateGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateGroupCertificateConfiguration


        /// <summary>
        /// Updates the Certificate expiry time for a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupCertificateConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateGroupCertificateConfiguration service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroupCertificateConfiguration">REST API Reference for UpdateGroupCertificateConfiguration Operation</seealso>
        public virtual UpdateGroupCertificateConfigurationResponse UpdateGroupCertificateConfiguration(UpdateGroupCertificateConfigurationRequest request)
        {
            var marshaller = UpdateGroupCertificateConfigurationRequestMarshaller.Instance;
            var unmarshaller = UpdateGroupCertificateConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupCertificateConfigurationRequest,UpdateGroupCertificateConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroupCertificateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupCertificateConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroupCertificateConfiguration">REST API Reference for UpdateGroupCertificateConfiguration Operation</seealso>
        public virtual Task<UpdateGroupCertificateConfigurationResponse> UpdateGroupCertificateConfigurationAsync(UpdateGroupCertificateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateGroupCertificateConfigurationRequestMarshaller.Instance;
            var unmarshaller = UpdateGroupCertificateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGroupCertificateConfigurationRequest,UpdateGroupCertificateConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateLoggerDefinition


        /// <summary>
        /// Updates a logger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggerDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateLoggerDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateLoggerDefinition">REST API Reference for UpdateLoggerDefinition Operation</seealso>
        public virtual UpdateLoggerDefinitionResponse UpdateLoggerDefinition(UpdateLoggerDefinitionRequest request)
        {
            var marshaller = UpdateLoggerDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateLoggerDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateLoggerDefinitionRequest,UpdateLoggerDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggerDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateLoggerDefinition">REST API Reference for UpdateLoggerDefinition Operation</seealso>
        public virtual Task<UpdateLoggerDefinitionResponse> UpdateLoggerDefinitionAsync(UpdateLoggerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateLoggerDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateLoggerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLoggerDefinitionRequest,UpdateLoggerDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateResourceDefinition


        /// <summary>
        /// Updates a resource definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateResourceDefinition">REST API Reference for UpdateResourceDefinition Operation</seealso>
        public virtual UpdateResourceDefinitionResponse UpdateResourceDefinition(UpdateResourceDefinitionRequest request)
        {
            var marshaller = UpdateResourceDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateResourceDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceDefinitionRequest,UpdateResourceDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateResourceDefinition">REST API Reference for UpdateResourceDefinition Operation</seealso>
        public virtual Task<UpdateResourceDefinitionResponse> UpdateResourceDefinitionAsync(UpdateResourceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateResourceDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateResourceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResourceDefinitionRequest,UpdateResourceDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSubscriptionDefinition


        /// <summary>
        /// Updates a subscription definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriptionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateSubscriptionDefinition">REST API Reference for UpdateSubscriptionDefinition Operation</seealso>
        public virtual UpdateSubscriptionDefinitionResponse UpdateSubscriptionDefinition(UpdateSubscriptionDefinitionRequest request)
        {
            var marshaller = UpdateSubscriptionDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateSubscriptionDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionDefinitionRequest,UpdateSubscriptionDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateSubscriptionDefinition">REST API Reference for UpdateSubscriptionDefinition Operation</seealso>
        public virtual Task<UpdateSubscriptionDefinitionResponse> UpdateSubscriptionDefinitionAsync(UpdateSubscriptionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateSubscriptionDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateSubscriptionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSubscriptionDefinitionRequest,UpdateSubscriptionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}