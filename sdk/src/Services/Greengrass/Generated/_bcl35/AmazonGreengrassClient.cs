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
        /// <param name="request">Container for the necessary parameters to execute the AssociateRoleToGroup operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateRoleToGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateRoleToGroup">REST API Reference for AssociateRoleToGroup Operation</seealso>
        public virtual IAsyncResult BeginAssociateRoleToGroup(AssociateRoleToGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AssociateRoleToGroupRequestMarshaller.Instance;
            var unmarshaller = AssociateRoleToGroupResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateRoleToGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateRoleToGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateRoleToGroup.</param>
        /// 
        /// <returns>Returns a  AssociateRoleToGroupResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateRoleToGroup">REST API Reference for AssociateRoleToGroup Operation</seealso>
        public virtual AssociateRoleToGroupResponse EndAssociateRoleToGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateRoleToGroupResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceRoleToAccount operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateServiceRoleToAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateServiceRoleToAccount">REST API Reference for AssociateServiceRoleToAccount Operation</seealso>
        public virtual IAsyncResult BeginAssociateServiceRoleToAccount(AssociateServiceRoleToAccountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AssociateServiceRoleToAccountRequestMarshaller.Instance;
            var unmarshaller = AssociateServiceRoleToAccountResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateServiceRoleToAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateServiceRoleToAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateServiceRoleToAccount.</param>
        /// 
        /// <returns>Returns a  AssociateServiceRoleToAccountResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateServiceRoleToAccount">REST API Reference for AssociateServiceRoleToAccount Operation</seealso>
        public virtual AssociateServiceRoleToAccountResponse EndAssociateServiceRoleToAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateServiceRoleToAccountResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCoreDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinition">REST API Reference for CreateCoreDefinition Operation</seealso>
        public virtual IAsyncResult BeginCreateCoreDefinition(CreateCoreDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateCoreDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateCoreDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateCoreDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCoreDefinition.</param>
        /// 
        /// <returns>Returns a  CreateCoreDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinition">REST API Reference for CreateCoreDefinition Operation</seealso>
        public virtual CreateCoreDefinitionResponse EndCreateCoreDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCoreDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCoreDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinitionVersion">REST API Reference for CreateCoreDefinitionVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateCoreDefinitionVersion(CreateCoreDefinitionVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateCoreDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateCoreDefinitionVersionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateCoreDefinitionVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCoreDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCoreDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  CreateCoreDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinitionVersion">REST API Reference for CreateCoreDefinitionVersion Operation</seealso>
        public virtual CreateCoreDefinitionVersionResponse EndCreateCoreDefinitionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCoreDefinitionVersionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDeploymentRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDeploymentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeploymentResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeviceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinition">REST API Reference for CreateDeviceDefinition Operation</seealso>
        public virtual IAsyncResult BeginCreateDeviceDefinition(CreateDeviceDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDeviceDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateDeviceDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDeviceDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeviceDefinition.</param>
        /// 
        /// <returns>Returns a  CreateDeviceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinition">REST API Reference for CreateDeviceDefinition Operation</seealso>
        public virtual CreateDeviceDefinitionResponse EndCreateDeviceDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeviceDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeviceDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinitionVersion">REST API Reference for CreateDeviceDefinitionVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateDeviceDefinitionVersion(CreateDeviceDefinitionVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDeviceDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateDeviceDefinitionVersionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDeviceDefinitionVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeviceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeviceDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  CreateDeviceDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinitionVersion">REST API Reference for CreateDeviceDefinitionVersion Operation</seealso>
        public virtual CreateDeviceDefinitionVersionResponse EndCreateDeviceDefinitionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeviceDefinitionVersionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFunctionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinition">REST API Reference for CreateFunctionDefinition Operation</seealso>
        public virtual IAsyncResult BeginCreateFunctionDefinition(CreateFunctionDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateFunctionDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateFunctionDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateFunctionDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFunctionDefinition.</param>
        /// 
        /// <returns>Returns a  CreateFunctionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinition">REST API Reference for CreateFunctionDefinition Operation</seealso>
        public virtual CreateFunctionDefinitionResponse EndCreateFunctionDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFunctionDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFunctionDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinitionVersion">REST API Reference for CreateFunctionDefinitionVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateFunctionDefinitionVersion(CreateFunctionDefinitionVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateFunctionDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateFunctionDefinitionVersionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateFunctionDefinitionVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFunctionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFunctionDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  CreateFunctionDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinitionVersion">REST API Reference for CreateFunctionDefinitionVersion Operation</seealso>
        public virtual CreateFunctionDefinitionVersionResponse EndCreateFunctionDefinitionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFunctionDefinitionVersionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateGroupRequestMarshaller.Instance;
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return BeginInvoke<CreateGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupCertificateAuthority operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroupCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupCertificateAuthority">REST API Reference for CreateGroupCertificateAuthority Operation</seealso>
        public virtual IAsyncResult BeginCreateGroupCertificateAuthority(CreateGroupCertificateAuthorityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateGroupCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = CreateGroupCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke<CreateGroupCertificateAuthorityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroupCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroupCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  CreateGroupCertificateAuthorityResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupCertificateAuthority">REST API Reference for CreateGroupCertificateAuthority Operation</seealso>
        public virtual CreateGroupCertificateAuthorityResponse EndCreateGroupCertificateAuthority(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupCertificateAuthorityResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroupVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupVersion">REST API Reference for CreateGroupVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateGroupVersion(CreateGroupVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateGroupVersionRequestMarshaller.Instance;
            var unmarshaller = CreateGroupVersionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateGroupVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroupVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroupVersion.</param>
        /// 
        /// <returns>Returns a  CreateGroupVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupVersion">REST API Reference for CreateGroupVersion Operation</seealso>
        public virtual CreateGroupVersionResponse EndCreateGroupVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupVersionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggerDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoggerDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinition">REST API Reference for CreateLoggerDefinition Operation</seealso>
        public virtual IAsyncResult BeginCreateLoggerDefinition(CreateLoggerDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateLoggerDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateLoggerDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateLoggerDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoggerDefinition.</param>
        /// 
        /// <returns>Returns a  CreateLoggerDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinition">REST API Reference for CreateLoggerDefinition Operation</seealso>
        public virtual CreateLoggerDefinitionResponse EndCreateLoggerDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLoggerDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggerDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoggerDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinitionVersion">REST API Reference for CreateLoggerDefinitionVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateLoggerDefinitionVersion(CreateLoggerDefinitionVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateLoggerDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateLoggerDefinitionVersionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateLoggerDefinitionVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoggerDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoggerDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  CreateLoggerDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinitionVersion">REST API Reference for CreateLoggerDefinitionVersion Operation</seealso>
        public virtual CreateLoggerDefinitionVersionResponse EndCreateLoggerDefinitionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLoggerDefinitionVersionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResourceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinition">REST API Reference for CreateResourceDefinition Operation</seealso>
        public virtual IAsyncResult BeginCreateResourceDefinition(CreateResourceDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateResourceDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateResourceDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateResourceDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceDefinition.</param>
        /// 
        /// <returns>Returns a  CreateResourceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinition">REST API Reference for CreateResourceDefinition Operation</seealso>
        public virtual CreateResourceDefinitionResponse EndCreateResourceDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateResourceDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResourceDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinitionVersion">REST API Reference for CreateResourceDefinitionVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateResourceDefinitionVersion(CreateResourceDefinitionVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateResourceDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateResourceDefinitionVersionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateResourceDefinitionVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  CreateResourceDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinitionVersion">REST API Reference for CreateResourceDefinitionVersion Operation</seealso>
        public virtual CreateResourceDefinitionVersionResponse EndCreateResourceDefinitionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateResourceDefinitionVersionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateSoftwareUpdateJob operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSoftwareUpdateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSoftwareUpdateJob">REST API Reference for CreateSoftwareUpdateJob Operation</seealso>
        public virtual IAsyncResult BeginCreateSoftwareUpdateJob(CreateSoftwareUpdateJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateSoftwareUpdateJobRequestMarshaller.Instance;
            var unmarshaller = CreateSoftwareUpdateJobResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSoftwareUpdateJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSoftwareUpdateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSoftwareUpdateJob.</param>
        /// 
        /// <returns>Returns a  CreateSoftwareUpdateJobResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSoftwareUpdateJob">REST API Reference for CreateSoftwareUpdateJob Operation</seealso>
        public virtual CreateSoftwareUpdateJobResponse EndCreateSoftwareUpdateJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSoftwareUpdateJobResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscriptionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinition">REST API Reference for CreateSubscriptionDefinition Operation</seealso>
        public virtual IAsyncResult BeginCreateSubscriptionDefinition(CreateSubscriptionDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateSubscriptionDefinitionRequestMarshaller.Instance;
            var unmarshaller = CreateSubscriptionDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSubscriptionDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscriptionDefinition.</param>
        /// 
        /// <returns>Returns a  CreateSubscriptionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinition">REST API Reference for CreateSubscriptionDefinition Operation</seealso>
        public virtual CreateSubscriptionDefinitionResponse EndCreateSubscriptionDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSubscriptionDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscriptionDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinitionVersion">REST API Reference for CreateSubscriptionDefinitionVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateSubscriptionDefinitionVersion(CreateSubscriptionDefinitionVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateSubscriptionDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = CreateSubscriptionDefinitionVersionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSubscriptionDefinitionVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscriptionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscriptionDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  CreateSubscriptionDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinitionVersion">REST API Reference for CreateSubscriptionDefinitionVersion Operation</seealso>
        public virtual CreateSubscriptionDefinitionVersionResponse EndCreateSubscriptionDefinitionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSubscriptionDefinitionVersionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCoreDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteCoreDefinition">REST API Reference for DeleteCoreDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeleteCoreDefinition(DeleteCoreDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteCoreDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteCoreDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteCoreDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCoreDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteCoreDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteCoreDefinition">REST API Reference for DeleteCoreDefinition Operation</seealso>
        public virtual DeleteCoreDefinitionResponse EndDeleteCoreDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCoreDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeviceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteDeviceDefinition">REST API Reference for DeleteDeviceDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeleteDeviceDefinition(DeleteDeviceDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDeviceDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteDeviceDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDeviceDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeviceDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteDeviceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteDeviceDefinition">REST API Reference for DeleteDeviceDefinition Operation</seealso>
        public virtual DeleteDeviceDefinitionResponse EndDeleteDeviceDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeviceDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFunctionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteFunctionDefinition">REST API Reference for DeleteFunctionDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeleteFunctionDefinition(DeleteFunctionDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteFunctionDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteFunctionDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteFunctionDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFunctionDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteFunctionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteFunctionDefinition">REST API Reference for DeleteFunctionDefinition Operation</seealso>
        public virtual DeleteFunctionDefinitionResponse EndDeleteFunctionDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFunctionDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggerDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoggerDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteLoggerDefinition">REST API Reference for DeleteLoggerDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeleteLoggerDefinition(DeleteLoggerDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteLoggerDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteLoggerDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteLoggerDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoggerDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteLoggerDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteLoggerDefinition">REST API Reference for DeleteLoggerDefinition Operation</seealso>
        public virtual DeleteLoggerDefinitionResponse EndDeleteLoggerDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLoggerDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteResourceDefinition">REST API Reference for DeleteResourceDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourceDefinition(DeleteResourceDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteResourceDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteResourceDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteResourceDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourceDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteResourceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteResourceDefinition">REST API Reference for DeleteResourceDefinition Operation</seealso>
        public virtual DeleteResourceDefinitionResponse EndDeleteResourceDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourceDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubscriptionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteSubscriptionDefinition">REST API Reference for DeleteSubscriptionDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeleteSubscriptionDefinition(DeleteSubscriptionDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteSubscriptionDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteSubscriptionDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSubscriptionDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscriptionDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriptionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteSubscriptionDefinition">REST API Reference for DeleteSubscriptionDefinition Operation</seealso>
        public virtual DeleteSubscriptionDefinitionResponse EndDeleteSubscriptionDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSubscriptionDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRoleFromGroup operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateRoleFromGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateRoleFromGroup">REST API Reference for DisassociateRoleFromGroup Operation</seealso>
        public virtual IAsyncResult BeginDisassociateRoleFromGroup(DisassociateRoleFromGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateRoleFromGroupRequestMarshaller.Instance;
            var unmarshaller = DisassociateRoleFromGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateRoleFromGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateRoleFromGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateRoleFromGroup.</param>
        /// 
        /// <returns>Returns a  DisassociateRoleFromGroupResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateRoleFromGroup">REST API Reference for DisassociateRoleFromGroup Operation</seealso>
        public virtual DisassociateRoleFromGroupResponse EndDisassociateRoleFromGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateRoleFromGroupResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceRoleFromAccount operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateServiceRoleFromAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateServiceRoleFromAccount">REST API Reference for DisassociateServiceRoleFromAccount Operation</seealso>
        public virtual IAsyncResult BeginDisassociateServiceRoleFromAccount(DisassociateServiceRoleFromAccountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisassociateServiceRoleFromAccountRequestMarshaller.Instance;
            var unmarshaller = DisassociateServiceRoleFromAccountResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateServiceRoleFromAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateServiceRoleFromAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateServiceRoleFromAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateServiceRoleFromAccountResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateServiceRoleFromAccount">REST API Reference for DisassociateServiceRoleFromAccount Operation</seealso>
        public virtual DisassociateServiceRoleFromAccountResponse EndDisassociateServiceRoleFromAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateServiceRoleFromAccountResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetAssociatedRole operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssociatedRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetAssociatedRole">REST API Reference for GetAssociatedRole Operation</seealso>
        public virtual IAsyncResult BeginGetAssociatedRole(GetAssociatedRoleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetAssociatedRoleRequestMarshaller.Instance;
            var unmarshaller = GetAssociatedRoleResponseUnmarshaller.Instance;

            return BeginInvoke<GetAssociatedRoleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssociatedRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssociatedRole.</param>
        /// 
        /// <returns>Returns a  GetAssociatedRoleResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetAssociatedRole">REST API Reference for GetAssociatedRole Operation</seealso>
        public virtual GetAssociatedRoleResponse EndGetAssociatedRole(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssociatedRoleResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetConnectivityInfo operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectivityInfo
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetConnectivityInfo">REST API Reference for GetConnectivityInfo Operation</seealso>
        public virtual IAsyncResult BeginGetConnectivityInfo(GetConnectivityInfoRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetConnectivityInfoRequestMarshaller.Instance;
            var unmarshaller = GetConnectivityInfoResponseUnmarshaller.Instance;

            return BeginInvoke<GetConnectivityInfoRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectivityInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectivityInfo.</param>
        /// 
        /// <returns>Returns a  GetConnectivityInfoResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetConnectivityInfo">REST API Reference for GetConnectivityInfo Operation</seealso>
        public virtual GetConnectivityInfoResponse EndGetConnectivityInfo(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectivityInfoResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCoreDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinition">REST API Reference for GetCoreDefinition Operation</seealso>
        public virtual IAsyncResult BeginGetCoreDefinition(GetCoreDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetCoreDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetCoreDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<GetCoreDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCoreDefinition.</param>
        /// 
        /// <returns>Returns a  GetCoreDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinition">REST API Reference for GetCoreDefinition Operation</seealso>
        public virtual GetCoreDefinitionResponse EndGetCoreDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCoreDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCoreDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinitionVersion">REST API Reference for GetCoreDefinitionVersion Operation</seealso>
        public virtual IAsyncResult BeginGetCoreDefinitionVersion(GetCoreDefinitionVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetCoreDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetCoreDefinitionVersionResponseUnmarshaller.Instance;

            return BeginInvoke<GetCoreDefinitionVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCoreDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCoreDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  GetCoreDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinitionVersion">REST API Reference for GetCoreDefinitionVersion Operation</seealso>
        public virtual GetCoreDefinitionVersionResponse EndGetCoreDefinitionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCoreDefinitionVersionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentStatus operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeploymentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeploymentStatus">REST API Reference for GetDeploymentStatus Operation</seealso>
        public virtual IAsyncResult BeginGetDeploymentStatus(GetDeploymentStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDeploymentStatusRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentStatusResponseUnmarshaller.Instance;

            return BeginInvoke<GetDeploymentStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeploymentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeploymentStatus.</param>
        /// 
        /// <returns>Returns a  GetDeploymentStatusResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeploymentStatus">REST API Reference for GetDeploymentStatus Operation</seealso>
        public virtual GetDeploymentStatusResponse EndGetDeploymentStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeploymentStatusResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeviceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinition">REST API Reference for GetDeviceDefinition Operation</seealso>
        public virtual IAsyncResult BeginGetDeviceDefinition(GetDeviceDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDeviceDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetDeviceDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<GetDeviceDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeviceDefinition.</param>
        /// 
        /// <returns>Returns a  GetDeviceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinition">REST API Reference for GetDeviceDefinition Operation</seealso>
        public virtual GetDeviceDefinitionResponse EndGetDeviceDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeviceDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeviceDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinitionVersion">REST API Reference for GetDeviceDefinitionVersion Operation</seealso>
        public virtual IAsyncResult BeginGetDeviceDefinitionVersion(GetDeviceDefinitionVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDeviceDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetDeviceDefinitionVersionResponseUnmarshaller.Instance;

            return BeginInvoke<GetDeviceDefinitionVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeviceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeviceDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  GetDeviceDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinitionVersion">REST API Reference for GetDeviceDefinitionVersion Operation</seealso>
        public virtual GetDeviceDefinitionVersionResponse EndGetDeviceDefinitionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeviceDefinitionVersionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFunctionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinition">REST API Reference for GetFunctionDefinition Operation</seealso>
        public virtual IAsyncResult BeginGetFunctionDefinition(GetFunctionDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetFunctionDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetFunctionDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<GetFunctionDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunctionDefinition.</param>
        /// 
        /// <returns>Returns a  GetFunctionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinition">REST API Reference for GetFunctionDefinition Operation</seealso>
        public virtual GetFunctionDefinitionResponse EndGetFunctionDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFunctionDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFunctionDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinitionVersion">REST API Reference for GetFunctionDefinitionVersion Operation</seealso>
        public virtual IAsyncResult BeginGetFunctionDefinitionVersion(GetFunctionDefinitionVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetFunctionDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetFunctionDefinitionVersionResponseUnmarshaller.Instance;

            return BeginInvoke<GetFunctionDefinitionVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunctionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunctionDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  GetFunctionDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinitionVersion">REST API Reference for GetFunctionDefinitionVersion Operation</seealso>
        public virtual GetFunctionDefinitionVersionResponse EndGetFunctionDefinitionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFunctionDefinitionVersionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual IAsyncResult BeginGetGroup(GetGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetGroupRequestMarshaller.Instance;
            var unmarshaller = GetGroupResponseUnmarshaller.Instance;

            return BeginInvoke<GetGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a  GetGroupResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual GetGroupResponse EndGetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetGroupCertificateAuthority operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateAuthority">REST API Reference for GetGroupCertificateAuthority Operation</seealso>
        public virtual IAsyncResult BeginGetGroupCertificateAuthority(GetGroupCertificateAuthorityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetGroupCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = GetGroupCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke<GetGroupCertificateAuthorityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  GetGroupCertificateAuthorityResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateAuthority">REST API Reference for GetGroupCertificateAuthority Operation</seealso>
        public virtual GetGroupCertificateAuthorityResponse EndGetGroupCertificateAuthority(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupCertificateAuthorityResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetGroupCertificateConfiguration operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupCertificateConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateConfiguration">REST API Reference for GetGroupCertificateConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetGroupCertificateConfiguration(GetGroupCertificateConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetGroupCertificateConfigurationRequestMarshaller.Instance;
            var unmarshaller = GetGroupCertificateConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<GetGroupCertificateConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupCertificateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupCertificateConfiguration.</param>
        /// 
        /// <returns>Returns a  GetGroupCertificateConfigurationResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateConfiguration">REST API Reference for GetGroupCertificateConfiguration Operation</seealso>
        public virtual GetGroupCertificateConfigurationResponse EndGetGroupCertificateConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupCertificateConfigurationResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetGroupVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupVersion">REST API Reference for GetGroupVersion Operation</seealso>
        public virtual IAsyncResult BeginGetGroupVersion(GetGroupVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetGroupVersionRequestMarshaller.Instance;
            var unmarshaller = GetGroupVersionResponseUnmarshaller.Instance;

            return BeginInvoke<GetGroupVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupVersion.</param>
        /// 
        /// <returns>Returns a  GetGroupVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupVersion">REST API Reference for GetGroupVersion Operation</seealso>
        public virtual GetGroupVersionResponse EndGetGroupVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupVersionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetLoggerDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoggerDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinition">REST API Reference for GetLoggerDefinition Operation</seealso>
        public virtual IAsyncResult BeginGetLoggerDefinition(GetLoggerDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetLoggerDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetLoggerDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<GetLoggerDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoggerDefinition.</param>
        /// 
        /// <returns>Returns a  GetLoggerDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinition">REST API Reference for GetLoggerDefinition Operation</seealso>
        public virtual GetLoggerDefinitionResponse EndGetLoggerDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLoggerDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetLoggerDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoggerDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinitionVersion">REST API Reference for GetLoggerDefinitionVersion Operation</seealso>
        public virtual IAsyncResult BeginGetLoggerDefinitionVersion(GetLoggerDefinitionVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetLoggerDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetLoggerDefinitionVersionResponseUnmarshaller.Instance;

            return BeginInvoke<GetLoggerDefinitionVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoggerDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoggerDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  GetLoggerDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinitionVersion">REST API Reference for GetLoggerDefinitionVersion Operation</seealso>
        public virtual GetLoggerDefinitionVersionResponse EndGetLoggerDefinitionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLoggerDefinitionVersionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetResourceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinition">REST API Reference for GetResourceDefinition Operation</seealso>
        public virtual IAsyncResult BeginGetResourceDefinition(GetResourceDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetResourceDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetResourceDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<GetResourceDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceDefinition.</param>
        /// 
        /// <returns>Returns a  GetResourceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinition">REST API Reference for GetResourceDefinition Operation</seealso>
        public virtual GetResourceDefinitionResponse EndGetResourceDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetResourceDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinitionVersion">REST API Reference for GetResourceDefinitionVersion Operation</seealso>
        public virtual IAsyncResult BeginGetResourceDefinitionVersion(GetResourceDefinitionVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetResourceDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetResourceDefinitionVersionResponseUnmarshaller.Instance;

            return BeginInvoke<GetResourceDefinitionVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  GetResourceDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinitionVersion">REST API Reference for GetResourceDefinitionVersion Operation</seealso>
        public virtual GetResourceDefinitionVersionResponse EndGetResourceDefinitionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceDefinitionVersionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetServiceRoleForAccount operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceRoleForAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetServiceRoleForAccount">REST API Reference for GetServiceRoleForAccount Operation</seealso>
        public virtual IAsyncResult BeginGetServiceRoleForAccount(GetServiceRoleForAccountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetServiceRoleForAccountRequestMarshaller.Instance;
            var unmarshaller = GetServiceRoleForAccountResponseUnmarshaller.Instance;

            return BeginInvoke<GetServiceRoleForAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceRoleForAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceRoleForAccount.</param>
        /// 
        /// <returns>Returns a  GetServiceRoleForAccountResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetServiceRoleForAccount">REST API Reference for GetServiceRoleForAccount Operation</seealso>
        public virtual GetServiceRoleForAccountResponse EndGetServiceRoleForAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceRoleForAccountResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubscriptionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinition">REST API Reference for GetSubscriptionDefinition Operation</seealso>
        public virtual IAsyncResult BeginGetSubscriptionDefinition(GetSubscriptionDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetSubscriptionDefinitionRequestMarshaller.Instance;
            var unmarshaller = GetSubscriptionDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<GetSubscriptionDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscriptionDefinition.</param>
        /// 
        /// <returns>Returns a  GetSubscriptionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinition">REST API Reference for GetSubscriptionDefinition Operation</seealso>
        public virtual GetSubscriptionDefinitionResponse EndGetSubscriptionDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSubscriptionDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubscriptionDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinitionVersion">REST API Reference for GetSubscriptionDefinitionVersion Operation</seealso>
        public virtual IAsyncResult BeginGetSubscriptionDefinitionVersion(GetSubscriptionDefinitionVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetSubscriptionDefinitionVersionRequestMarshaller.Instance;
            var unmarshaller = GetSubscriptionDefinitionVersionResponseUnmarshaller.Instance;

            return BeginInvoke<GetSubscriptionDefinitionVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscriptionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscriptionDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  GetSubscriptionDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinitionVersion">REST API Reference for GetSubscriptionDefinitionVersion Operation</seealso>
        public virtual GetSubscriptionDefinitionVersionResponse EndGetSubscriptionDefinitionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSubscriptionDefinitionVersionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDefinitions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCoreDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitions">REST API Reference for ListCoreDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListCoreDefinitions(ListCoreDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListCoreDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListCoreDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListCoreDefinitionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCoreDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCoreDefinitions.</param>
        /// 
        /// <returns>Returns a  ListCoreDefinitionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitions">REST API Reference for ListCoreDefinitions Operation</seealso>
        public virtual ListCoreDefinitionsResponse EndListCoreDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCoreDefinitionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDefinitionVersions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCoreDefinitionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitionVersions">REST API Reference for ListCoreDefinitionVersions Operation</seealso>
        public virtual IAsyncResult BeginListCoreDefinitionVersions(ListCoreDefinitionVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListCoreDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListCoreDefinitionVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListCoreDefinitionVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCoreDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCoreDefinitionVersions.</param>
        /// 
        /// <returns>Returns a  ListCoreDefinitionVersionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitionVersions">REST API Reference for ListCoreDefinitionVersions Operation</seealso>
        public virtual ListCoreDefinitionVersionsResponse EndListCoreDefinitionVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCoreDefinitionVersionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual IAsyncResult BeginListDeployments(ListDeploymentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListDeploymentsRequestMarshaller.Instance;
            var unmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDeploymentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeployments.</param>
        /// 
        /// <returns>Returns a  ListDeploymentsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual ListDeploymentsResponse EndListDeployments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeploymentsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceDefinitions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeviceDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitions">REST API Reference for ListDeviceDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListDeviceDefinitions(ListDeviceDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListDeviceDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListDeviceDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDeviceDefinitionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeviceDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeviceDefinitions.</param>
        /// 
        /// <returns>Returns a  ListDeviceDefinitionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitions">REST API Reference for ListDeviceDefinitions Operation</seealso>
        public virtual ListDeviceDefinitionsResponse EndListDeviceDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeviceDefinitionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceDefinitionVersions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeviceDefinitionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitionVersions">REST API Reference for ListDeviceDefinitionVersions Operation</seealso>
        public virtual IAsyncResult BeginListDeviceDefinitionVersions(ListDeviceDefinitionVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListDeviceDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListDeviceDefinitionVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDeviceDefinitionVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeviceDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeviceDefinitionVersions.</param>
        /// 
        /// <returns>Returns a  ListDeviceDefinitionVersionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitionVersions">REST API Reference for ListDeviceDefinitionVersions Operation</seealso>
        public virtual ListDeviceDefinitionVersionsResponse EndListDeviceDefinitionVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeviceDefinitionVersionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionDefinitions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFunctionDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitions">REST API Reference for ListFunctionDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListFunctionDefinitions(ListFunctionDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListFunctionDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListFunctionDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListFunctionDefinitionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFunctionDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFunctionDefinitions.</param>
        /// 
        /// <returns>Returns a  ListFunctionDefinitionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitions">REST API Reference for ListFunctionDefinitions Operation</seealso>
        public virtual ListFunctionDefinitionsResponse EndListFunctionDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFunctionDefinitionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionDefinitionVersions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFunctionDefinitionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitionVersions">REST API Reference for ListFunctionDefinitionVersions Operation</seealso>
        public virtual IAsyncResult BeginListFunctionDefinitionVersions(ListFunctionDefinitionVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListFunctionDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListFunctionDefinitionVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListFunctionDefinitionVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFunctionDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFunctionDefinitionVersions.</param>
        /// 
        /// <returns>Returns a  ListFunctionDefinitionVersionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitionVersions">REST API Reference for ListFunctionDefinitionVersions Operation</seealso>
        public virtual ListFunctionDefinitionVersionsResponse EndListFunctionDefinitionVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFunctionDefinitionVersionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListGroupCertificateAuthorities operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupCertificateAuthorities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupCertificateAuthorities">REST API Reference for ListGroupCertificateAuthorities Operation</seealso>
        public virtual IAsyncResult BeginListGroupCertificateAuthorities(ListGroupCertificateAuthoritiesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListGroupCertificateAuthoritiesRequestMarshaller.Instance;
            var unmarshaller = ListGroupCertificateAuthoritiesResponseUnmarshaller.Instance;

            return BeginInvoke<ListGroupCertificateAuthoritiesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupCertificateAuthorities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupCertificateAuthorities.</param>
        /// 
        /// <returns>Returns a  ListGroupCertificateAuthoritiesResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupCertificateAuthorities">REST API Reference for ListGroupCertificateAuthorities Operation</seealso>
        public virtual ListGroupCertificateAuthoritiesResponse EndListGroupCertificateAuthorities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupCertificateAuthoritiesResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListGroupsRequestMarshaller.Instance;
            var unmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<ListGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse EndListGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListGroupVersions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupVersions">REST API Reference for ListGroupVersions Operation</seealso>
        public virtual IAsyncResult BeginListGroupVersions(ListGroupVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListGroupVersionsRequestMarshaller.Instance;
            var unmarshaller = ListGroupVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListGroupVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupVersions.</param>
        /// 
        /// <returns>Returns a  ListGroupVersionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupVersions">REST API Reference for ListGroupVersions Operation</seealso>
        public virtual ListGroupVersionsResponse EndListGroupVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupVersionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListLoggerDefinitions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLoggerDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitions">REST API Reference for ListLoggerDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListLoggerDefinitions(ListLoggerDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListLoggerDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListLoggerDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListLoggerDefinitionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLoggerDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLoggerDefinitions.</param>
        /// 
        /// <returns>Returns a  ListLoggerDefinitionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitions">REST API Reference for ListLoggerDefinitions Operation</seealso>
        public virtual ListLoggerDefinitionsResponse EndListLoggerDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLoggerDefinitionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListLoggerDefinitionVersions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLoggerDefinitionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitionVersions">REST API Reference for ListLoggerDefinitionVersions Operation</seealso>
        public virtual IAsyncResult BeginListLoggerDefinitionVersions(ListLoggerDefinitionVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListLoggerDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListLoggerDefinitionVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListLoggerDefinitionVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLoggerDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLoggerDefinitionVersions.</param>
        /// 
        /// <returns>Returns a  ListLoggerDefinitionVersionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitionVersions">REST API Reference for ListLoggerDefinitionVersions Operation</seealso>
        public virtual ListLoggerDefinitionVersionsResponse EndListLoggerDefinitionVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLoggerDefinitionVersionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDefinitions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitions">REST API Reference for ListResourceDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListResourceDefinitions(ListResourceDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListResourceDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListResourceDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListResourceDefinitionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceDefinitions.</param>
        /// 
        /// <returns>Returns a  ListResourceDefinitionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitions">REST API Reference for ListResourceDefinitions Operation</seealso>
        public virtual ListResourceDefinitionsResponse EndListResourceDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceDefinitionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDefinitionVersions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceDefinitionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitionVersions">REST API Reference for ListResourceDefinitionVersions Operation</seealso>
        public virtual IAsyncResult BeginListResourceDefinitionVersions(ListResourceDefinitionVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListResourceDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListResourceDefinitionVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListResourceDefinitionVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceDefinitionVersions.</param>
        /// 
        /// <returns>Returns a  ListResourceDefinitionVersionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitionVersions">REST API Reference for ListResourceDefinitionVersions Operation</seealso>
        public virtual ListResourceDefinitionVersionsResponse EndListResourceDefinitionVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceDefinitionVersionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionDefinitions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptionDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitions">REST API Reference for ListSubscriptionDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListSubscriptionDefinitions(ListSubscriptionDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListSubscriptionDefinitionsRequestMarshaller.Instance;
            var unmarshaller = ListSubscriptionDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListSubscriptionDefinitionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptionDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptionDefinitions.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionDefinitionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitions">REST API Reference for ListSubscriptionDefinitions Operation</seealso>
        public virtual ListSubscriptionDefinitionsResponse EndListSubscriptionDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSubscriptionDefinitionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionDefinitionVersions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptionDefinitionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitionVersions">REST API Reference for ListSubscriptionDefinitionVersions Operation</seealso>
        public virtual IAsyncResult BeginListSubscriptionDefinitionVersions(ListSubscriptionDefinitionVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListSubscriptionDefinitionVersionsRequestMarshaller.Instance;
            var unmarshaller = ListSubscriptionDefinitionVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListSubscriptionDefinitionVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptionDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptionDefinitionVersions.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionDefinitionVersionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitionVersions">REST API Reference for ListSubscriptionDefinitionVersions Operation</seealso>
        public virtual ListSubscriptionDefinitionVersionsResponse EndListSubscriptionDefinitionVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSubscriptionDefinitionVersionsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ResetDeployments operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ResetDeployments">REST API Reference for ResetDeployments Operation</seealso>
        public virtual IAsyncResult BeginResetDeployments(ResetDeploymentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ResetDeploymentsRequestMarshaller.Instance;
            var unmarshaller = ResetDeploymentsResponseUnmarshaller.Instance;

            return BeginInvoke<ResetDeploymentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetDeployments.</param>
        /// 
        /// <returns>Returns a  ResetDeploymentsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ResetDeployments">REST API Reference for ResetDeployments Operation</seealso>
        public virtual ResetDeploymentsResponse EndResetDeployments(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetDeploymentsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectivityInfo operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnectivityInfo
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateConnectivityInfo">REST API Reference for UpdateConnectivityInfo Operation</seealso>
        public virtual IAsyncResult BeginUpdateConnectivityInfo(UpdateConnectivityInfoRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateConnectivityInfoRequestMarshaller.Instance;
            var unmarshaller = UpdateConnectivityInfoResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateConnectivityInfoRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnectivityInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnectivityInfo.</param>
        /// 
        /// <returns>Returns a  UpdateConnectivityInfoResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateConnectivityInfo">REST API Reference for UpdateConnectivityInfo Operation</seealso>
        public virtual UpdateConnectivityInfoResponse EndUpdateConnectivityInfo(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConnectivityInfoResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateCoreDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCoreDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateCoreDefinition">REST API Reference for UpdateCoreDefinition Operation</seealso>
        public virtual IAsyncResult BeginUpdateCoreDefinition(UpdateCoreDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateCoreDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateCoreDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateCoreDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCoreDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateCoreDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateCoreDefinition">REST API Reference for UpdateCoreDefinition Operation</seealso>
        public virtual UpdateCoreDefinitionResponse EndUpdateCoreDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCoreDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDeviceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateDeviceDefinition">REST API Reference for UpdateDeviceDefinition Operation</seealso>
        public virtual IAsyncResult BeginUpdateDeviceDefinition(UpdateDeviceDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateDeviceDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateDeviceDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDeviceDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeviceDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateDeviceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateDeviceDefinition">REST API Reference for UpdateDeviceDefinition Operation</seealso>
        public virtual UpdateDeviceDefinitionResponse EndUpdateDeviceDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDeviceDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFunctionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateFunctionDefinition">REST API Reference for UpdateFunctionDefinition Operation</seealso>
        public virtual IAsyncResult BeginUpdateFunctionDefinition(UpdateFunctionDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateFunctionDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateFunctionDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateFunctionDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFunctionDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateFunctionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateFunctionDefinition">REST API Reference for UpdateFunctionDefinition Operation</seealso>
        public virtual UpdateFunctionDefinitionResponse EndUpdateFunctionDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFunctionDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateGroupRequestMarshaller.Instance;
            var unmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGroupResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupCertificateConfiguration operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroupCertificateConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroupCertificateConfiguration">REST API Reference for UpdateGroupCertificateConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateGroupCertificateConfiguration(UpdateGroupCertificateConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateGroupCertificateConfigurationRequestMarshaller.Instance;
            var unmarshaller = UpdateGroupCertificateConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateGroupCertificateConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroupCertificateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroupCertificateConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateGroupCertificateConfigurationResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroupCertificateConfiguration">REST API Reference for UpdateGroupCertificateConfiguration Operation</seealso>
        public virtual UpdateGroupCertificateConfigurationResponse EndUpdateGroupCertificateConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGroupCertificateConfigurationResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggerDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLoggerDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateLoggerDefinition">REST API Reference for UpdateLoggerDefinition Operation</seealso>
        public virtual IAsyncResult BeginUpdateLoggerDefinition(UpdateLoggerDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateLoggerDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateLoggerDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateLoggerDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLoggerDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateLoggerDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateLoggerDefinition">REST API Reference for UpdateLoggerDefinition Operation</seealso>
        public virtual UpdateLoggerDefinitionResponse EndUpdateLoggerDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLoggerDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateResourceDefinition">REST API Reference for UpdateResourceDefinition Operation</seealso>
        public virtual IAsyncResult BeginUpdateResourceDefinition(UpdateResourceDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateResourceDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateResourceDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateResourceDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourceDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateResourceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateResourceDefinition">REST API Reference for UpdateResourceDefinition Operation</seealso>
        public virtual UpdateResourceDefinitionResponse EndUpdateResourceDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateResourceDefinitionResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubscriptionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateSubscriptionDefinition">REST API Reference for UpdateSubscriptionDefinition Operation</seealso>
        public virtual IAsyncResult BeginUpdateSubscriptionDefinition(UpdateSubscriptionDefinitionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateSubscriptionDefinitionRequestMarshaller.Instance;
            var unmarshaller = UpdateSubscriptionDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateSubscriptionDefinitionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscriptionDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriptionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateSubscriptionDefinition">REST API Reference for UpdateSubscriptionDefinition Operation</seealso>
        public virtual UpdateSubscriptionDefinitionResponse EndUpdateSubscriptionDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSubscriptionDefinitionResponse>(asyncResult);
        }

        #endregion
        
    }
}