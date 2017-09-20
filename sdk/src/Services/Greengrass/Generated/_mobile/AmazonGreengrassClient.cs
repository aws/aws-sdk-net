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

#if CORECLR
    
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

#endif

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

        internal AssociateRoleToGroupResponse AssociateRoleToGroup(AssociateRoleToGroupRequest request)
        {
            var marshaller = new AssociateRoleToGroupRequestMarshaller();
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
        public Task<AssociateRoleToGroupResponse> AssociateRoleToGroupAsync(AssociateRoleToGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateRoleToGroupRequestMarshaller();
            var unmarshaller = AssociateRoleToGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateRoleToGroupRequest,AssociateRoleToGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateServiceRoleToAccount

        internal AssociateServiceRoleToAccountResponse AssociateServiceRoleToAccount(AssociateServiceRoleToAccountRequest request)
        {
            var marshaller = new AssociateServiceRoleToAccountRequestMarshaller();
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
        public Task<AssociateServiceRoleToAccountResponse> AssociateServiceRoleToAccountAsync(AssociateServiceRoleToAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateServiceRoleToAccountRequestMarshaller();
            var unmarshaller = AssociateServiceRoleToAccountResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateServiceRoleToAccountRequest,AssociateServiceRoleToAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCoreDefinition

        internal CreateCoreDefinitionResponse CreateCoreDefinition(CreateCoreDefinitionRequest request)
        {
            var marshaller = new CreateCoreDefinitionRequestMarshaller();
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
        public Task<CreateCoreDefinitionResponse> CreateCoreDefinitionAsync(CreateCoreDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCoreDefinitionRequestMarshaller();
            var unmarshaller = CreateCoreDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCoreDefinitionRequest,CreateCoreDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCoreDefinitionVersion

        internal CreateCoreDefinitionVersionResponse CreateCoreDefinitionVersion(CreateCoreDefinitionVersionRequest request)
        {
            var marshaller = new CreateCoreDefinitionVersionRequestMarshaller();
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
        public Task<CreateCoreDefinitionVersionResponse> CreateCoreDefinitionVersionAsync(CreateCoreDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCoreDefinitionVersionRequestMarshaller();
            var unmarshaller = CreateCoreDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCoreDefinitionVersionRequest,CreateCoreDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeployment

        internal CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var marshaller = new CreateDeploymentRequestMarshaller();
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
        public Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDeploymentRequestMarshaller();
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentRequest,CreateDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeviceDefinition

        internal CreateDeviceDefinitionResponse CreateDeviceDefinition(CreateDeviceDefinitionRequest request)
        {
            var marshaller = new CreateDeviceDefinitionRequestMarshaller();
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
        public Task<CreateDeviceDefinitionResponse> CreateDeviceDefinitionAsync(CreateDeviceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDeviceDefinitionRequestMarshaller();
            var unmarshaller = CreateDeviceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeviceDefinitionRequest,CreateDeviceDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeviceDefinitionVersion

        internal CreateDeviceDefinitionVersionResponse CreateDeviceDefinitionVersion(CreateDeviceDefinitionVersionRequest request)
        {
            var marshaller = new CreateDeviceDefinitionVersionRequestMarshaller();
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
        public Task<CreateDeviceDefinitionVersionResponse> CreateDeviceDefinitionVersionAsync(CreateDeviceDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDeviceDefinitionVersionRequestMarshaller();
            var unmarshaller = CreateDeviceDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeviceDefinitionVersionRequest,CreateDeviceDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFunctionDefinition

        internal CreateFunctionDefinitionResponse CreateFunctionDefinition(CreateFunctionDefinitionRequest request)
        {
            var marshaller = new CreateFunctionDefinitionRequestMarshaller();
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
        public Task<CreateFunctionDefinitionResponse> CreateFunctionDefinitionAsync(CreateFunctionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateFunctionDefinitionRequestMarshaller();
            var unmarshaller = CreateFunctionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFunctionDefinitionRequest,CreateFunctionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFunctionDefinitionVersion

        internal CreateFunctionDefinitionVersionResponse CreateFunctionDefinitionVersion(CreateFunctionDefinitionVersionRequest request)
        {
            var marshaller = new CreateFunctionDefinitionVersionRequestMarshaller();
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
        public Task<CreateFunctionDefinitionVersionResponse> CreateFunctionDefinitionVersionAsync(CreateFunctionDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateFunctionDefinitionVersionRequestMarshaller();
            var unmarshaller = CreateFunctionDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFunctionDefinitionVersionRequest,CreateFunctionDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGroup

        internal CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var marshaller = new CreateGroupRequestMarshaller();
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
        public Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateGroupRequestMarshaller();
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupRequest,CreateGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGroupCertificateAuthority

        internal CreateGroupCertificateAuthorityResponse CreateGroupCertificateAuthority(CreateGroupCertificateAuthorityRequest request)
        {
            var marshaller = new CreateGroupCertificateAuthorityRequestMarshaller();
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
        public Task<CreateGroupCertificateAuthorityResponse> CreateGroupCertificateAuthorityAsync(CreateGroupCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateGroupCertificateAuthorityRequestMarshaller();
            var unmarshaller = CreateGroupCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupCertificateAuthorityRequest,CreateGroupCertificateAuthorityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGroupVersion

        internal CreateGroupVersionResponse CreateGroupVersion(CreateGroupVersionRequest request)
        {
            var marshaller = new CreateGroupVersionRequestMarshaller();
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
        public Task<CreateGroupVersionResponse> CreateGroupVersionAsync(CreateGroupVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateGroupVersionRequestMarshaller();
            var unmarshaller = CreateGroupVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupVersionRequest,CreateGroupVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLoggerDefinition

        internal CreateLoggerDefinitionResponse CreateLoggerDefinition(CreateLoggerDefinitionRequest request)
        {
            var marshaller = new CreateLoggerDefinitionRequestMarshaller();
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
        public Task<CreateLoggerDefinitionResponse> CreateLoggerDefinitionAsync(CreateLoggerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLoggerDefinitionRequestMarshaller();
            var unmarshaller = CreateLoggerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoggerDefinitionRequest,CreateLoggerDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLoggerDefinitionVersion

        internal CreateLoggerDefinitionVersionResponse CreateLoggerDefinitionVersion(CreateLoggerDefinitionVersionRequest request)
        {
            var marshaller = new CreateLoggerDefinitionVersionRequestMarshaller();
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
        public Task<CreateLoggerDefinitionVersionResponse> CreateLoggerDefinitionVersionAsync(CreateLoggerDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLoggerDefinitionVersionRequestMarshaller();
            var unmarshaller = CreateLoggerDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoggerDefinitionVersionRequest,CreateLoggerDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSubscriptionDefinition

        internal CreateSubscriptionDefinitionResponse CreateSubscriptionDefinition(CreateSubscriptionDefinitionRequest request)
        {
            var marshaller = new CreateSubscriptionDefinitionRequestMarshaller();
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
        public Task<CreateSubscriptionDefinitionResponse> CreateSubscriptionDefinitionAsync(CreateSubscriptionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSubscriptionDefinitionRequestMarshaller();
            var unmarshaller = CreateSubscriptionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubscriptionDefinitionRequest,CreateSubscriptionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSubscriptionDefinitionVersion

        internal CreateSubscriptionDefinitionVersionResponse CreateSubscriptionDefinitionVersion(CreateSubscriptionDefinitionVersionRequest request)
        {
            var marshaller = new CreateSubscriptionDefinitionVersionRequestMarshaller();
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
        public Task<CreateSubscriptionDefinitionVersionResponse> CreateSubscriptionDefinitionVersionAsync(CreateSubscriptionDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSubscriptionDefinitionVersionRequestMarshaller();
            var unmarshaller = CreateSubscriptionDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubscriptionDefinitionVersionRequest,CreateSubscriptionDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCoreDefinition

        internal DeleteCoreDefinitionResponse DeleteCoreDefinition(DeleteCoreDefinitionRequest request)
        {
            var marshaller = new DeleteCoreDefinitionRequestMarshaller();
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
        public Task<DeleteCoreDefinitionResponse> DeleteCoreDefinitionAsync(DeleteCoreDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCoreDefinitionRequestMarshaller();
            var unmarshaller = DeleteCoreDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCoreDefinitionRequest,DeleteCoreDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDeviceDefinition

        internal DeleteDeviceDefinitionResponse DeleteDeviceDefinition(DeleteDeviceDefinitionRequest request)
        {
            var marshaller = new DeleteDeviceDefinitionRequestMarshaller();
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
        public Task<DeleteDeviceDefinitionResponse> DeleteDeviceDefinitionAsync(DeleteDeviceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDeviceDefinitionRequestMarshaller();
            var unmarshaller = DeleteDeviceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeviceDefinitionRequest,DeleteDeviceDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFunctionDefinition

        internal DeleteFunctionDefinitionResponse DeleteFunctionDefinition(DeleteFunctionDefinitionRequest request)
        {
            var marshaller = new DeleteFunctionDefinitionRequestMarshaller();
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
        public Task<DeleteFunctionDefinitionResponse> DeleteFunctionDefinitionAsync(DeleteFunctionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteFunctionDefinitionRequestMarshaller();
            var unmarshaller = DeleteFunctionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFunctionDefinitionRequest,DeleteFunctionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteGroup

        internal DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var marshaller = new DeleteGroupRequestMarshaller();
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
        public Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteGroupRequestMarshaller();
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupRequest,DeleteGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoggerDefinition

        internal DeleteLoggerDefinitionResponse DeleteLoggerDefinition(DeleteLoggerDefinitionRequest request)
        {
            var marshaller = new DeleteLoggerDefinitionRequestMarshaller();
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
        public Task<DeleteLoggerDefinitionResponse> DeleteLoggerDefinitionAsync(DeleteLoggerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLoggerDefinitionRequestMarshaller();
            var unmarshaller = DeleteLoggerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoggerDefinitionRequest,DeleteLoggerDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubscriptionDefinition

        internal DeleteSubscriptionDefinitionResponse DeleteSubscriptionDefinition(DeleteSubscriptionDefinitionRequest request)
        {
            var marshaller = new DeleteSubscriptionDefinitionRequestMarshaller();
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
        public Task<DeleteSubscriptionDefinitionResponse> DeleteSubscriptionDefinitionAsync(DeleteSubscriptionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSubscriptionDefinitionRequestMarshaller();
            var unmarshaller = DeleteSubscriptionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubscriptionDefinitionRequest,DeleteSubscriptionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateRoleFromGroup

        internal DisassociateRoleFromGroupResponse DisassociateRoleFromGroup(DisassociateRoleFromGroupRequest request)
        {
            var marshaller = new DisassociateRoleFromGroupRequestMarshaller();
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
        public Task<DisassociateRoleFromGroupResponse> DisassociateRoleFromGroupAsync(DisassociateRoleFromGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateRoleFromGroupRequestMarshaller();
            var unmarshaller = DisassociateRoleFromGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateRoleFromGroupRequest,DisassociateRoleFromGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateServiceRoleFromAccount

        internal DisassociateServiceRoleFromAccountResponse DisassociateServiceRoleFromAccount(DisassociateServiceRoleFromAccountRequest request)
        {
            var marshaller = new DisassociateServiceRoleFromAccountRequestMarshaller();
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
        public Task<DisassociateServiceRoleFromAccountResponse> DisassociateServiceRoleFromAccountAsync(DisassociateServiceRoleFromAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateServiceRoleFromAccountRequestMarshaller();
            var unmarshaller = DisassociateServiceRoleFromAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateServiceRoleFromAccountRequest,DisassociateServiceRoleFromAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAssociatedRole

        internal GetAssociatedRoleResponse GetAssociatedRole(GetAssociatedRoleRequest request)
        {
            var marshaller = new GetAssociatedRoleRequestMarshaller();
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
        public Task<GetAssociatedRoleResponse> GetAssociatedRoleAsync(GetAssociatedRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetAssociatedRoleRequestMarshaller();
            var unmarshaller = GetAssociatedRoleResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssociatedRoleRequest,GetAssociatedRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConnectivityInfo

        internal GetConnectivityInfoResponse GetConnectivityInfo(GetConnectivityInfoRequest request)
        {
            var marshaller = new GetConnectivityInfoRequestMarshaller();
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
        public Task<GetConnectivityInfoResponse> GetConnectivityInfoAsync(GetConnectivityInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetConnectivityInfoRequestMarshaller();
            var unmarshaller = GetConnectivityInfoResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectivityInfoRequest,GetConnectivityInfoResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCoreDefinition

        internal GetCoreDefinitionResponse GetCoreDefinition(GetCoreDefinitionRequest request)
        {
            var marshaller = new GetCoreDefinitionRequestMarshaller();
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
        public Task<GetCoreDefinitionResponse> GetCoreDefinitionAsync(GetCoreDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCoreDefinitionRequestMarshaller();
            var unmarshaller = GetCoreDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetCoreDefinitionRequest,GetCoreDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCoreDefinitionVersion

        internal GetCoreDefinitionVersionResponse GetCoreDefinitionVersion(GetCoreDefinitionVersionRequest request)
        {
            var marshaller = new GetCoreDefinitionVersionRequestMarshaller();
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
        public Task<GetCoreDefinitionVersionResponse> GetCoreDefinitionVersionAsync(GetCoreDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCoreDefinitionVersionRequestMarshaller();
            var unmarshaller = GetCoreDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetCoreDefinitionVersionRequest,GetCoreDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeploymentStatus

        internal GetDeploymentStatusResponse GetDeploymentStatus(GetDeploymentStatusRequest request)
        {
            var marshaller = new GetDeploymentStatusRequestMarshaller();
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
        public Task<GetDeploymentStatusResponse> GetDeploymentStatusAsync(GetDeploymentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDeploymentStatusRequestMarshaller();
            var unmarshaller = GetDeploymentStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentStatusRequest,GetDeploymentStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeviceDefinition

        internal GetDeviceDefinitionResponse GetDeviceDefinition(GetDeviceDefinitionRequest request)
        {
            var marshaller = new GetDeviceDefinitionRequestMarshaller();
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
        public Task<GetDeviceDefinitionResponse> GetDeviceDefinitionAsync(GetDeviceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDeviceDefinitionRequestMarshaller();
            var unmarshaller = GetDeviceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceDefinitionRequest,GetDeviceDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeviceDefinitionVersion

        internal GetDeviceDefinitionVersionResponse GetDeviceDefinitionVersion(GetDeviceDefinitionVersionRequest request)
        {
            var marshaller = new GetDeviceDefinitionVersionRequestMarshaller();
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
        public Task<GetDeviceDefinitionVersionResponse> GetDeviceDefinitionVersionAsync(GetDeviceDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDeviceDefinitionVersionRequestMarshaller();
            var unmarshaller = GetDeviceDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceDefinitionVersionRequest,GetDeviceDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFunctionDefinition

        internal GetFunctionDefinitionResponse GetFunctionDefinition(GetFunctionDefinitionRequest request)
        {
            var marshaller = new GetFunctionDefinitionRequestMarshaller();
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
        public Task<GetFunctionDefinitionResponse> GetFunctionDefinitionAsync(GetFunctionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetFunctionDefinitionRequestMarshaller();
            var unmarshaller = GetFunctionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFunctionDefinitionRequest,GetFunctionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFunctionDefinitionVersion

        internal GetFunctionDefinitionVersionResponse GetFunctionDefinitionVersion(GetFunctionDefinitionVersionRequest request)
        {
            var marshaller = new GetFunctionDefinitionVersionRequestMarshaller();
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
        public Task<GetFunctionDefinitionVersionResponse> GetFunctionDefinitionVersionAsync(GetFunctionDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetFunctionDefinitionVersionRequestMarshaller();
            var unmarshaller = GetFunctionDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFunctionDefinitionVersionRequest,GetFunctionDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGroup

        internal GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var marshaller = new GetGroupRequestMarshaller();
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
        public Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetGroupRequestMarshaller();
            var unmarshaller = GetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupRequest,GetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGroupCertificateAuthority

        internal GetGroupCertificateAuthorityResponse GetGroupCertificateAuthority(GetGroupCertificateAuthorityRequest request)
        {
            var marshaller = new GetGroupCertificateAuthorityRequestMarshaller();
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
        public Task<GetGroupCertificateAuthorityResponse> GetGroupCertificateAuthorityAsync(GetGroupCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetGroupCertificateAuthorityRequestMarshaller();
            var unmarshaller = GetGroupCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupCertificateAuthorityRequest,GetGroupCertificateAuthorityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGroupCertificateConfiguration

        internal GetGroupCertificateConfigurationResponse GetGroupCertificateConfiguration(GetGroupCertificateConfigurationRequest request)
        {
            var marshaller = new GetGroupCertificateConfigurationRequestMarshaller();
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
        public Task<GetGroupCertificateConfigurationResponse> GetGroupCertificateConfigurationAsync(GetGroupCertificateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetGroupCertificateConfigurationRequestMarshaller();
            var unmarshaller = GetGroupCertificateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupCertificateConfigurationRequest,GetGroupCertificateConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGroupVersion

        internal GetGroupVersionResponse GetGroupVersion(GetGroupVersionRequest request)
        {
            var marshaller = new GetGroupVersionRequestMarshaller();
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
        public Task<GetGroupVersionResponse> GetGroupVersionAsync(GetGroupVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetGroupVersionRequestMarshaller();
            var unmarshaller = GetGroupVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupVersionRequest,GetGroupVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetLoggerDefinition

        internal GetLoggerDefinitionResponse GetLoggerDefinition(GetLoggerDefinitionRequest request)
        {
            var marshaller = new GetLoggerDefinitionRequestMarshaller();
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
        public Task<GetLoggerDefinitionResponse> GetLoggerDefinitionAsync(GetLoggerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetLoggerDefinitionRequestMarshaller();
            var unmarshaller = GetLoggerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoggerDefinitionRequest,GetLoggerDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetLoggerDefinitionVersion

        internal GetLoggerDefinitionVersionResponse GetLoggerDefinitionVersion(GetLoggerDefinitionVersionRequest request)
        {
            var marshaller = new GetLoggerDefinitionVersionRequestMarshaller();
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
        public Task<GetLoggerDefinitionVersionResponse> GetLoggerDefinitionVersionAsync(GetLoggerDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetLoggerDefinitionVersionRequestMarshaller();
            var unmarshaller = GetLoggerDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoggerDefinitionVersionRequest,GetLoggerDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetServiceRoleForAccount

        internal GetServiceRoleForAccountResponse GetServiceRoleForAccount(GetServiceRoleForAccountRequest request)
        {
            var marshaller = new GetServiceRoleForAccountRequestMarshaller();
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
        public Task<GetServiceRoleForAccountResponse> GetServiceRoleForAccountAsync(GetServiceRoleForAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetServiceRoleForAccountRequestMarshaller();
            var unmarshaller = GetServiceRoleForAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceRoleForAccountRequest,GetServiceRoleForAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSubscriptionDefinition

        internal GetSubscriptionDefinitionResponse GetSubscriptionDefinition(GetSubscriptionDefinitionRequest request)
        {
            var marshaller = new GetSubscriptionDefinitionRequestMarshaller();
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
        public Task<GetSubscriptionDefinitionResponse> GetSubscriptionDefinitionAsync(GetSubscriptionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSubscriptionDefinitionRequestMarshaller();
            var unmarshaller = GetSubscriptionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSubscriptionDefinitionRequest,GetSubscriptionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSubscriptionDefinitionVersion

        internal GetSubscriptionDefinitionVersionResponse GetSubscriptionDefinitionVersion(GetSubscriptionDefinitionVersionRequest request)
        {
            var marshaller = new GetSubscriptionDefinitionVersionRequestMarshaller();
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
        public Task<GetSubscriptionDefinitionVersionResponse> GetSubscriptionDefinitionVersionAsync(GetSubscriptionDefinitionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSubscriptionDefinitionVersionRequestMarshaller();
            var unmarshaller = GetSubscriptionDefinitionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSubscriptionDefinitionVersionRequest,GetSubscriptionDefinitionVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCoreDefinitions

        internal ListCoreDefinitionsResponse ListCoreDefinitions(ListCoreDefinitionsRequest request)
        {
            var marshaller = new ListCoreDefinitionsRequestMarshaller();
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
        public Task<ListCoreDefinitionsResponse> ListCoreDefinitionsAsync(ListCoreDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListCoreDefinitionsRequestMarshaller();
            var unmarshaller = ListCoreDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCoreDefinitionsRequest,ListCoreDefinitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCoreDefinitionVersions

        internal ListCoreDefinitionVersionsResponse ListCoreDefinitionVersions(ListCoreDefinitionVersionsRequest request)
        {
            var marshaller = new ListCoreDefinitionVersionsRequestMarshaller();
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
        public Task<ListCoreDefinitionVersionsResponse> ListCoreDefinitionVersionsAsync(ListCoreDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListCoreDefinitionVersionsRequestMarshaller();
            var unmarshaller = ListCoreDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCoreDefinitionVersionsRequest,ListCoreDefinitionVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeployments

        internal ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request)
        {
            var marshaller = new ListDeploymentsRequestMarshaller();
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
        public Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDeploymentsRequestMarshaller();
            var unmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentsRequest,ListDeploymentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeviceDefinitions

        internal ListDeviceDefinitionsResponse ListDeviceDefinitions(ListDeviceDefinitionsRequest request)
        {
            var marshaller = new ListDeviceDefinitionsRequestMarshaller();
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
        public Task<ListDeviceDefinitionsResponse> ListDeviceDefinitionsAsync(ListDeviceDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDeviceDefinitionsRequestMarshaller();
            var unmarshaller = ListDeviceDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeviceDefinitionsRequest,ListDeviceDefinitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeviceDefinitionVersions

        internal ListDeviceDefinitionVersionsResponse ListDeviceDefinitionVersions(ListDeviceDefinitionVersionsRequest request)
        {
            var marshaller = new ListDeviceDefinitionVersionsRequestMarshaller();
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
        public Task<ListDeviceDefinitionVersionsResponse> ListDeviceDefinitionVersionsAsync(ListDeviceDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDeviceDefinitionVersionsRequestMarshaller();
            var unmarshaller = ListDeviceDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeviceDefinitionVersionsRequest,ListDeviceDefinitionVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFunctionDefinitions

        internal ListFunctionDefinitionsResponse ListFunctionDefinitions(ListFunctionDefinitionsRequest request)
        {
            var marshaller = new ListFunctionDefinitionsRequestMarshaller();
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
        public Task<ListFunctionDefinitionsResponse> ListFunctionDefinitionsAsync(ListFunctionDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListFunctionDefinitionsRequestMarshaller();
            var unmarshaller = ListFunctionDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFunctionDefinitionsRequest,ListFunctionDefinitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFunctionDefinitionVersions

        internal ListFunctionDefinitionVersionsResponse ListFunctionDefinitionVersions(ListFunctionDefinitionVersionsRequest request)
        {
            var marshaller = new ListFunctionDefinitionVersionsRequestMarshaller();
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
        public Task<ListFunctionDefinitionVersionsResponse> ListFunctionDefinitionVersionsAsync(ListFunctionDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListFunctionDefinitionVersionsRequestMarshaller();
            var unmarshaller = ListFunctionDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFunctionDefinitionVersionsRequest,ListFunctionDefinitionVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGroupCertificateAuthorities

        internal ListGroupCertificateAuthoritiesResponse ListGroupCertificateAuthorities(ListGroupCertificateAuthoritiesRequest request)
        {
            var marshaller = new ListGroupCertificateAuthoritiesRequestMarshaller();
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
        public Task<ListGroupCertificateAuthoritiesResponse> ListGroupCertificateAuthoritiesAsync(ListGroupCertificateAuthoritiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListGroupCertificateAuthoritiesRequestMarshaller();
            var unmarshaller = ListGroupCertificateAuthoritiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupCertificateAuthoritiesRequest,ListGroupCertificateAuthoritiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGroups

        internal ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var marshaller = new ListGroupsRequestMarshaller();
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
        public Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListGroupsRequestMarshaller();
            var unmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupsRequest,ListGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGroupVersions

        internal ListGroupVersionsResponse ListGroupVersions(ListGroupVersionsRequest request)
        {
            var marshaller = new ListGroupVersionsRequestMarshaller();
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
        public Task<ListGroupVersionsResponse> ListGroupVersionsAsync(ListGroupVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListGroupVersionsRequestMarshaller();
            var unmarshaller = ListGroupVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupVersionsRequest,ListGroupVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListLoggerDefinitions

        internal ListLoggerDefinitionsResponse ListLoggerDefinitions(ListLoggerDefinitionsRequest request)
        {
            var marshaller = new ListLoggerDefinitionsRequestMarshaller();
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
        public Task<ListLoggerDefinitionsResponse> ListLoggerDefinitionsAsync(ListLoggerDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListLoggerDefinitionsRequestMarshaller();
            var unmarshaller = ListLoggerDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLoggerDefinitionsRequest,ListLoggerDefinitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListLoggerDefinitionVersions

        internal ListLoggerDefinitionVersionsResponse ListLoggerDefinitionVersions(ListLoggerDefinitionVersionsRequest request)
        {
            var marshaller = new ListLoggerDefinitionVersionsRequestMarshaller();
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
        public Task<ListLoggerDefinitionVersionsResponse> ListLoggerDefinitionVersionsAsync(ListLoggerDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListLoggerDefinitionVersionsRequestMarshaller();
            var unmarshaller = ListLoggerDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLoggerDefinitionVersionsRequest,ListLoggerDefinitionVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSubscriptionDefinitions

        internal ListSubscriptionDefinitionsResponse ListSubscriptionDefinitions(ListSubscriptionDefinitionsRequest request)
        {
            var marshaller = new ListSubscriptionDefinitionsRequestMarshaller();
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
        public Task<ListSubscriptionDefinitionsResponse> ListSubscriptionDefinitionsAsync(ListSubscriptionDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListSubscriptionDefinitionsRequestMarshaller();
            var unmarshaller = ListSubscriptionDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscriptionDefinitionsRequest,ListSubscriptionDefinitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSubscriptionDefinitionVersions

        internal ListSubscriptionDefinitionVersionsResponse ListSubscriptionDefinitionVersions(ListSubscriptionDefinitionVersionsRequest request)
        {
            var marshaller = new ListSubscriptionDefinitionVersionsRequestMarshaller();
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
        public Task<ListSubscriptionDefinitionVersionsResponse> ListSubscriptionDefinitionVersionsAsync(ListSubscriptionDefinitionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListSubscriptionDefinitionVersionsRequestMarshaller();
            var unmarshaller = ListSubscriptionDefinitionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscriptionDefinitionVersionsRequest,ListSubscriptionDefinitionVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetDeployments

        internal ResetDeploymentsResponse ResetDeployments(ResetDeploymentsRequest request)
        {
            var marshaller = new ResetDeploymentsRequestMarshaller();
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
        public Task<ResetDeploymentsResponse> ResetDeploymentsAsync(ResetDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetDeploymentsRequestMarshaller();
            var unmarshaller = ResetDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ResetDeploymentsRequest,ResetDeploymentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateConnectivityInfo

        internal UpdateConnectivityInfoResponse UpdateConnectivityInfo(UpdateConnectivityInfoRequest request)
        {
            var marshaller = new UpdateConnectivityInfoRequestMarshaller();
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
        public Task<UpdateConnectivityInfoResponse> UpdateConnectivityInfoAsync(UpdateConnectivityInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateConnectivityInfoRequestMarshaller();
            var unmarshaller = UpdateConnectivityInfoResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConnectivityInfoRequest,UpdateConnectivityInfoResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateCoreDefinition

        internal UpdateCoreDefinitionResponse UpdateCoreDefinition(UpdateCoreDefinitionRequest request)
        {
            var marshaller = new UpdateCoreDefinitionRequestMarshaller();
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
        public Task<UpdateCoreDefinitionResponse> UpdateCoreDefinitionAsync(UpdateCoreDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateCoreDefinitionRequestMarshaller();
            var unmarshaller = UpdateCoreDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCoreDefinitionRequest,UpdateCoreDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDeviceDefinition

        internal UpdateDeviceDefinitionResponse UpdateDeviceDefinition(UpdateDeviceDefinitionRequest request)
        {
            var marshaller = new UpdateDeviceDefinitionRequestMarshaller();
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
        public Task<UpdateDeviceDefinitionResponse> UpdateDeviceDefinitionAsync(UpdateDeviceDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDeviceDefinitionRequestMarshaller();
            var unmarshaller = UpdateDeviceDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeviceDefinitionRequest,UpdateDeviceDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateFunctionDefinition

        internal UpdateFunctionDefinitionResponse UpdateFunctionDefinition(UpdateFunctionDefinitionRequest request)
        {
            var marshaller = new UpdateFunctionDefinitionRequestMarshaller();
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
        public Task<UpdateFunctionDefinitionResponse> UpdateFunctionDefinitionAsync(UpdateFunctionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateFunctionDefinitionRequestMarshaller();
            var unmarshaller = UpdateFunctionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFunctionDefinitionRequest,UpdateFunctionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateGroup

        internal UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var marshaller = new UpdateGroupRequestMarshaller();
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
        public Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateGroupRequestMarshaller();
            var unmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGroupRequest,UpdateGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateGroupCertificateConfiguration

        internal UpdateGroupCertificateConfigurationResponse UpdateGroupCertificateConfiguration(UpdateGroupCertificateConfigurationRequest request)
        {
            var marshaller = new UpdateGroupCertificateConfigurationRequestMarshaller();
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
        public Task<UpdateGroupCertificateConfigurationResponse> UpdateGroupCertificateConfigurationAsync(UpdateGroupCertificateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateGroupCertificateConfigurationRequestMarshaller();
            var unmarshaller = UpdateGroupCertificateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGroupCertificateConfigurationRequest,UpdateGroupCertificateConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateLoggerDefinition

        internal UpdateLoggerDefinitionResponse UpdateLoggerDefinition(UpdateLoggerDefinitionRequest request)
        {
            var marshaller = new UpdateLoggerDefinitionRequestMarshaller();
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
        public Task<UpdateLoggerDefinitionResponse> UpdateLoggerDefinitionAsync(UpdateLoggerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateLoggerDefinitionRequestMarshaller();
            var unmarshaller = UpdateLoggerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLoggerDefinitionRequest,UpdateLoggerDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSubscriptionDefinition

        internal UpdateSubscriptionDefinitionResponse UpdateSubscriptionDefinition(UpdateSubscriptionDefinitionRequest request)
        {
            var marshaller = new UpdateSubscriptionDefinitionRequestMarshaller();
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
        public Task<UpdateSubscriptionDefinitionResponse> UpdateSubscriptionDefinitionAsync(UpdateSubscriptionDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateSubscriptionDefinitionRequestMarshaller();
            var unmarshaller = UpdateSubscriptionDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSubscriptionDefinitionRequest,UpdateSubscriptionDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}