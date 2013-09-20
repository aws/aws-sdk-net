/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.OpsWorks.Model;
using Amazon.OpsWorks.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.OpsWorks
{
    /// <summary>
    /// Implementation for accessing AmazonOpsWorks.
    /// 
    /// AWS OpsWorks <para>Welcome to the <i>AWS OpsWorks API Reference</i> . This guide provides descriptions, syntax, and usage examples about AWS
    /// OpsWorks actions and data types, including common parameters and error codes. </para> <para>AWS OpsWorks is an application management
    /// service that provides an integrated experience for overseeing the complete application lifecycle. For information about this product, go to
    /// the AWS OpsWorks details page. </para> <para> <b>Endpoints</b> </para> <para>AWS OpsWorks supports only one endpoint,
    /// opsworks.us-east-1.amazonaws.com (HTTPS), so you must connect to that endpoint. You can then use the API to direct AWS OpsWorks to create
    /// stacks in any AWS Region.</para> <para> <b>Chef Version</b> </para> <para>When you call CreateStack, CloneStack, or UpdateStack we recommend
    /// you use the <c>ConfigurationManager</c> parameter to specify the Chef version, 0.9 or 11.4. The default value is currently 0.9. However, we
    /// expect to change the default value to 11.4 in late August 2013.</para>
    /// </summary>
	public partial class AmazonOpsWorksClient : AmazonWebServiceClient, Amazon.OpsWorks.IAmazonOpsWorks
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonOpsWorksClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonOpsWorksClient(AWSCredentials credentials)
            : this(credentials, new AmazonOpsWorksConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpsWorksClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonOpsWorksConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksClient with AWS Credentials and an
        /// AmazonOpsWorksClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonOpsWorksClient Configuration Object</param>
        public AmazonOpsWorksClient(AWSCredentials credentials, AmazonOpsWorksConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonOpsWorksClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOpsWorksConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpsWorksClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOpsWorksConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOpsWorksClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonOpsWorksClient Configuration Object</param>
        public AmazonOpsWorksClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonOpsWorksConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonOpsWorksClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOpsWorksConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpsWorksClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOpsWorksConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOpsWorksClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonOpsWorksClient Configuration Object</param>
        public AmazonOpsWorksClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonOpsWorksConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
        /// <summary>
        /// <para>Attaches an Elastic Load Balancing instance to a specified layer.</para> <para><b>NOTE:</b>You must create the Elastic Load Balancing
        /// instance separately, by using the Elastic Load Balancing console, API, or CLI. For more information, see Elastic Load Balancing Developer
        /// Guide.</para>
        /// </summary>
        /// 
        /// <param name="attachElasticLoadBalancerRequest">Container for the necessary parameters to execute the AttachElasticLoadBalancer service
        /// method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<AttachElasticLoadBalancerResponse> AttachElasticLoadBalancerAsync(AttachElasticLoadBalancerRequest attachElasticLoadBalancerRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachElasticLoadBalancerRequestMarshaller();
            var unmarshaller = AttachElasticLoadBalancerResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AttachElasticLoadBalancerRequest, AttachElasticLoadBalancerResponse>(attachElasticLoadBalancerRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Creates a clone of a specified stack. For more information, see Clone a Stack.</para>
        /// </summary>
        /// 
        /// <param name="cloneStackRequest">Container for the necessary parameters to execute the CloneStack service method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CloneStack service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CloneStackResponse> CloneStackAsync(CloneStackRequest cloneStackRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CloneStackRequestMarshaller();
            var unmarshaller = CloneStackResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CloneStackRequest, CloneStackResponse>(cloneStackRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Creates an app for a specified stack. For more information, see Creating Apps.</para>
        /// </summary>
        /// 
        /// <param name="createAppRequest">Container for the necessary parameters to execute the CreateApp service method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest createAppRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAppRequestMarshaller();
            var unmarshaller = CreateAppResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateAppRequest, CreateAppResponse>(createAppRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Deploys a stack or app.</para>
        /// <ul>
        /// <li>App deployment generates a <c>deploy</c> event, which runs the associated recipes and passes them a JSON stack configuration object
        /// that includes information about the app. </li>
        /// <li>Stack deployment runs the <c>deploy</c> recipes but does not raise an event.</li>
        /// 
        /// </ul>
        /// <para>For more information, see Deploying Apps and Run Stack Commands.</para>
        /// </summary>
        /// 
        /// <param name="createDeploymentRequest">Container for the necessary parameters to execute the CreateDeployment service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest createDeploymentRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDeploymentRequestMarshaller();
            var unmarshaller = CreateDeploymentResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateDeploymentRequest, CreateDeploymentResponse>(createDeploymentRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Creates an instance in a specified stack. For more information, see Adding an Instance to a Layer.</para>
        /// </summary>
        /// 
        /// <param name="createInstanceRequest">Container for the necessary parameters to execute the CreateInstance service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateInstance service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest createInstanceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInstanceRequestMarshaller();
            var unmarshaller = CreateInstanceResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateInstanceRequest, CreateInstanceResponse>(createInstanceRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Creates a layer. For more information, see How to Create a Layer.</para> <para><b>NOTE:</b>You should use CreateLayer for non-custom
        /// layer types such as PHP App Server only if the stack does not have an existing layer of that type. A stack can have at most one instance of
        /// each non-custom layer; if you attempt to create a second instance, CreateLayer fails. A stack can have an arbitrary number of custom layers,
        /// so you can call CreateLayer as many times as you like for that layer type.</para>
        /// </summary>
        /// 
        /// <param name="createLayerRequest">Container for the necessary parameters to execute the CreateLayer service method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateLayer service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateLayerResponse> CreateLayerAsync(CreateLayerRequest createLayerRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLayerRequestMarshaller();
            var unmarshaller = CreateLayerResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateLayerRequest, CreateLayerResponse>(createLayerRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Creates a new stack. For more information, see Create a New Stack.</para>
        /// </summary>
        /// 
        /// <param name="createStackRequest">Container for the necessary parameters to execute the CreateStack service method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateStackResponse> CreateStackAsync(CreateStackRequest createStackRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStackRequestMarshaller();
            var unmarshaller = CreateStackResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateStackRequest, CreateStackResponse>(createStackRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Creates a new user profile.</para>
        /// </summary>
        /// 
        /// <param name="createUserProfileRequest">Container for the necessary parameters to execute the CreateUserProfile service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest createUserProfileRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateUserProfileRequestMarshaller();
            var unmarshaller = CreateUserProfileResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateUserProfileRequest, CreateUserProfileResponse>(createUserProfileRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Deletes a specified app.</para>
        /// </summary>
        /// 
        /// <param name="deleteAppRequest">Container for the necessary parameters to execute the DeleteApp service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest deleteAppRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAppRequestMarshaller();
            var unmarshaller = DeleteAppResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteAppRequest, DeleteAppResponse>(deleteAppRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Deletes a specified instance. You must stop an instance before you can delete it. For more information, see Deleting Instances.</para>
        /// </summary>
        /// 
        /// <param name="deleteInstanceRequest">Container for the necessary parameters to execute the DeleteInstance service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest deleteInstanceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteInstanceRequestMarshaller();
            var unmarshaller = DeleteInstanceResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteInstanceRequest, DeleteInstanceResponse>(deleteInstanceRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Deletes a specified layer. You must first stop and then delete all associated instances. For more information, see How to Delete a
        /// Layer.</para>
        /// </summary>
        /// 
        /// <param name="deleteLayerRequest">Container for the necessary parameters to execute the DeleteLayer service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteLayerResponse> DeleteLayerAsync(DeleteLayerRequest deleteLayerRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLayerRequestMarshaller();
            var unmarshaller = DeleteLayerResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteLayerRequest, DeleteLayerResponse>(deleteLayerRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Deletes a specified stack. You must first delete all instances, layers, and apps. For more information, see Shut Down a Stack.</para>
        /// </summary>
        /// 
        /// <param name="deleteStackRequest">Container for the necessary parameters to execute the DeleteStack service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest deleteStackRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStackRequestMarshaller();
            var unmarshaller = DeleteStackResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteStackRequest, DeleteStackResponse>(deleteStackRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Deletes a user profile.</para>
        /// </summary>
        /// 
        /// <param name="deleteUserProfileRequest">Container for the necessary parameters to execute the DeleteUserProfile service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteUserProfileResponse> DeleteUserProfileAsync(DeleteUserProfileRequest deleteUserProfileRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteUserProfileRequestMarshaller();
            var unmarshaller = DeleteUserProfileResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteUserProfileRequest, DeleteUserProfileResponse>(deleteUserProfileRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Requests a description of a specified set of apps.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
        /// </summary>
        /// 
        /// <param name="describeAppsRequest">Container for the necessary parameters to execute the DescribeApps service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeApps service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest describeAppsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAppsRequestMarshaller();
            var unmarshaller = DescribeAppsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeAppsRequest, DescribeAppsResponse>(describeAppsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Describes the results of specified commands.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
        /// </summary>
        /// 
        /// <param name="describeCommandsRequest">Container for the necessary parameters to execute the DescribeCommands service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeCommands service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeCommandsResponse> DescribeCommandsAsync(DescribeCommandsRequest describeCommandsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCommandsRequestMarshaller();
            var unmarshaller = DescribeCommandsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeCommandsRequest, DescribeCommandsResponse>(describeCommandsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Requests a description of a specified set of deployments.</para> <para><b>NOTE:</b>You must specify at least one of the
        /// parameters.</para>
        /// </summary>
        /// 
        /// <param name="describeDeploymentsRequest">Container for the necessary parameters to execute the DescribeDeployments service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeDeployments service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeDeploymentsResponse> DescribeDeploymentsAsync(DescribeDeploymentsRequest describeDeploymentsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDeploymentsRequestMarshaller();
            var unmarshaller = DescribeDeploymentsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeDeploymentsRequest, DescribeDeploymentsResponse>(describeDeploymentsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Describes Elastic IP addresses.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
        /// </summary>
        /// 
        /// <param name="describeElasticIpsRequest">Container for the necessary parameters to execute the DescribeElasticIps service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeElasticIps service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeElasticIpsResponse> DescribeElasticIpsAsync(DescribeElasticIpsRequest describeElasticIpsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeElasticIpsRequestMarshaller();
            var unmarshaller = DescribeElasticIpsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeElasticIpsRequest, DescribeElasticIpsResponse>(describeElasticIpsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Describes a stack's Elastic Load Balancing instances.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
        /// </summary>
        /// 
        /// <param name="describeElasticLoadBalancersRequest">Container for the necessary parameters to execute the DescribeElasticLoadBalancers service
        /// method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeElasticLoadBalancers service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeElasticLoadBalancersResponse> DescribeElasticLoadBalancersAsync(DescribeElasticLoadBalancersRequest describeElasticLoadBalancersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeElasticLoadBalancersRequestMarshaller();
            var unmarshaller = DescribeElasticLoadBalancersResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeElasticLoadBalancersRequest, DescribeElasticLoadBalancersResponse>(describeElasticLoadBalancersRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Requests a description of a set of instances.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
        /// </summary>
        /// 
        /// <param name="describeInstancesRequest">Container for the necessary parameters to execute the DescribeInstances service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest describeInstancesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstancesRequestMarshaller();
            var unmarshaller = DescribeInstancesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeInstancesRequest, DescribeInstancesResponse>(describeInstancesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Requests a description of one or more layers in a specified stack.</para> <para><b>NOTE:</b>You must specify at least one of the
        /// parameters.</para>
        /// </summary>
        /// 
        /// <param name="describeLayersRequest">Container for the necessary parameters to execute the DescribeLayers service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeLayers service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeLayersResponse> DescribeLayersAsync(DescribeLayersRequest describeLayersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLayersRequestMarshaller();
            var unmarshaller = DescribeLayersResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeLayersRequest, DescribeLayersResponse>(describeLayersRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Describes load-based auto scaling configurations for specified layers.</para> <para><b>NOTE:</b>You must specify at least one of the
        /// parameters.</para>
        /// </summary>
        /// 
        /// <param name="describeLoadBasedAutoScalingRequest">Container for the necessary parameters to execute the DescribeLoadBasedAutoScaling service
        /// method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeLoadBasedAutoScaling service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeLoadBasedAutoScalingResponse> DescribeLoadBasedAutoScalingAsync(DescribeLoadBasedAutoScalingRequest describeLoadBasedAutoScalingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBasedAutoScalingRequestMarshaller();
            var unmarshaller = DescribeLoadBasedAutoScalingResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeLoadBasedAutoScalingRequest, DescribeLoadBasedAutoScalingResponse>(describeLoadBasedAutoScalingRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Describes the permissions for a specified stack.</para>
        /// </summary>
        /// 
        /// <param name="describePermissionsRequest">Container for the necessary parameters to execute the DescribePermissions service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribePermissions service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribePermissionsResponse> DescribePermissionsAsync(DescribePermissionsRequest describePermissionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePermissionsRequestMarshaller();
            var unmarshaller = DescribePermissionsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribePermissionsRequest, DescribePermissionsResponse>(describePermissionsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Describe an instance's RAID arrays.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
        /// </summary>
        /// 
        /// <param name="describeRaidArraysRequest">Container for the necessary parameters to execute the DescribeRaidArrays service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeRaidArrays service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeRaidArraysResponse> DescribeRaidArraysAsync(DescribeRaidArraysRequest describeRaidArraysRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRaidArraysRequestMarshaller();
            var unmarshaller = DescribeRaidArraysResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeRaidArraysRequest, DescribeRaidArraysResponse>(describeRaidArraysRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Describes AWS OpsWorks service errors.</para>
        /// </summary>
        /// 
        /// <param name="describeServiceErrorsRequest">Container for the necessary parameters to execute the DescribeServiceErrors service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeServiceErrors service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeServiceErrorsResponse> DescribeServiceErrorsAsync(DescribeServiceErrorsRequest describeServiceErrorsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeServiceErrorsRequestMarshaller();
            var unmarshaller = DescribeServiceErrorsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeServiceErrorsRequest, DescribeServiceErrorsResponse>(describeServiceErrorsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Requests a description of one or more stacks.</para>
        /// </summary>
        /// 
        /// <param name="describeStacksRequest">Container for the necessary parameters to execute the DescribeStacks service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest describeStacksRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStacksRequestMarshaller();
            var unmarshaller = DescribeStacksResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeStacksRequest, DescribeStacksResponse>(describeStacksRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Describes time-based auto scaling configurations for specified instances.</para> <para><b>NOTE:</b>You must specify at least one of
        /// the parameters.</para>
        /// </summary>
        /// 
        /// <param name="describeTimeBasedAutoScalingRequest">Container for the necessary parameters to execute the DescribeTimeBasedAutoScaling service
        /// method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeTimeBasedAutoScaling service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeTimeBasedAutoScalingResponse> DescribeTimeBasedAutoScalingAsync(DescribeTimeBasedAutoScalingRequest describeTimeBasedAutoScalingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTimeBasedAutoScalingRequestMarshaller();
            var unmarshaller = DescribeTimeBasedAutoScalingResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeTimeBasedAutoScalingRequest, DescribeTimeBasedAutoScalingResponse>(describeTimeBasedAutoScalingRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Describe specified users.</para>
        /// </summary>
        /// 
        /// <param name="describeUserProfilesRequest">Container for the necessary parameters to execute the DescribeUserProfiles service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeUserProfiles service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeUserProfilesResponse> DescribeUserProfilesAsync(DescribeUserProfilesRequest describeUserProfilesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeUserProfilesRequestMarshaller();
            var unmarshaller = DescribeUserProfilesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeUserProfilesRequest, DescribeUserProfilesResponse>(describeUserProfilesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Describes an instance's Amazon EBS volumes.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
        /// </summary>
        /// 
        /// <param name="describeVolumesRequest">Container for the necessary parameters to execute the DescribeVolumes service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest describeVolumesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVolumesRequestMarshaller();
            var unmarshaller = DescribeVolumesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeVolumesRequest, DescribeVolumesResponse>(describeVolumesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Detaches a specified Elastic Load Balancing instance from it's layer.</para>
        /// </summary>
        /// 
        /// <param name="detachElasticLoadBalancerRequest">Container for the necessary parameters to execute the DetachElasticLoadBalancer service
        /// method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DetachElasticLoadBalancerResponse> DetachElasticLoadBalancerAsync(DetachElasticLoadBalancerRequest detachElasticLoadBalancerRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachElasticLoadBalancerRequestMarshaller();
            var unmarshaller = DetachElasticLoadBalancerResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DetachElasticLoadBalancerRequest, DetachElasticLoadBalancerResponse>(detachElasticLoadBalancerRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Gets a generated host name for the specified layer, based on the current host name theme.</para>
        /// </summary>
        /// 
        /// <param name="getHostnameSuggestionRequest">Container for the necessary parameters to execute the GetHostnameSuggestion service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the GetHostnameSuggestion service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<GetHostnameSuggestionResponse> GetHostnameSuggestionAsync(GetHostnameSuggestionRequest getHostnameSuggestionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHostnameSuggestionRequestMarshaller();
            var unmarshaller = GetHostnameSuggestionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetHostnameSuggestionRequest, GetHostnameSuggestionResponse>(getHostnameSuggestionRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Reboots a specified instance. For more information, see Starting, Stopping, and Rebooting Instances.</para>
        /// </summary>
        /// 
        /// <param name="rebootInstanceRequest">Container for the necessary parameters to execute the RebootInstance service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest rebootInstanceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootInstanceRequestMarshaller();
            var unmarshaller = RebootInstanceResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RebootInstanceRequest, RebootInstanceResponse>(rebootInstanceRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Specify the load-based auto scaling configuration for a specified layer. For more information, see Managing Load with Time-based and
        /// Load-based Instances.</para> <para><b>NOTE:</b>To use load-based auto scaling, you must create a set of load-based auto scaling instances.
        /// Load-based auto scaling operates only on the instances from that set, so you must ensure that you have created enough instances to handle
        /// the maximum anticipated load.</para>
        /// </summary>
        /// 
        /// <param name="setLoadBasedAutoScalingRequest">Container for the necessary parameters to execute the SetLoadBasedAutoScaling service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<SetLoadBasedAutoScalingResponse> SetLoadBasedAutoScalingAsync(SetLoadBasedAutoScalingRequest setLoadBasedAutoScalingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetLoadBasedAutoScalingRequestMarshaller();
            var unmarshaller = SetLoadBasedAutoScalingResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SetLoadBasedAutoScalingRequest, SetLoadBasedAutoScalingResponse>(setLoadBasedAutoScalingRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Specifies a stack's permissions. For more information, see Security and Permissions.</para>
        /// </summary>
        /// 
        /// <param name="setPermissionRequest">Container for the necessary parameters to execute the SetPermission service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<SetPermissionResponse> SetPermissionAsync(SetPermissionRequest setPermissionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetPermissionRequestMarshaller();
            var unmarshaller = SetPermissionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SetPermissionRequest, SetPermissionResponse>(setPermissionRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Specify the time-based auto scaling configuration for a specified instance. For more information, see Managing Load with Time-based
        /// and Load-based Instances.</para>
        /// </summary>
        /// 
        /// <param name="setTimeBasedAutoScalingRequest">Container for the necessary parameters to execute the SetTimeBasedAutoScaling service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<SetTimeBasedAutoScalingResponse> SetTimeBasedAutoScalingAsync(SetTimeBasedAutoScalingRequest setTimeBasedAutoScalingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetTimeBasedAutoScalingRequestMarshaller();
            var unmarshaller = SetTimeBasedAutoScalingResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SetTimeBasedAutoScalingRequest, SetTimeBasedAutoScalingResponse>(setTimeBasedAutoScalingRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Starts a specified instance. For more information, see Starting, Stopping, and Rebooting Instances.</para>
        /// </summary>
        /// 
        /// <param name="startInstanceRequest">Container for the necessary parameters to execute the StartInstance service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest startInstanceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartInstanceRequestMarshaller();
            var unmarshaller = StartInstanceResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, StartInstanceRequest, StartInstanceResponse>(startInstanceRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Starts stack's instances. </para>
        /// </summary>
        /// 
        /// <param name="startStackRequest">Container for the necessary parameters to execute the StartStack service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<StartStackResponse> StartStackAsync(StartStackRequest startStackRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartStackRequestMarshaller();
            var unmarshaller = StartStackResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, StartStackRequest, StartStackResponse>(startStackRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Stops a specified instance. When you stop a standard instance, the data disappears and must be reinstalled when you restart the
        /// instance. You can stop an Amazon EBS-backed instance without losing data. For more information, see Starting, Stopping, and Rebooting
        /// Instances.</para>
        /// </summary>
        /// 
        /// <param name="stopInstanceRequest">Container for the necessary parameters to execute the StopInstance service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest stopInstanceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopInstanceRequestMarshaller();
            var unmarshaller = StopInstanceResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, StopInstanceRequest, StopInstanceResponse>(stopInstanceRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Stops a specified stack.</para>
        /// </summary>
        /// 
        /// <param name="stopStackRequest">Container for the necessary parameters to execute the StopStack service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<StopStackResponse> StopStackAsync(StopStackRequest stopStackRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopStackRequestMarshaller();
            var unmarshaller = StopStackResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, StopStackRequest, StopStackResponse>(stopStackRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Updates a specified app.</para>
        /// </summary>
        /// 
        /// <param name="updateAppRequest">Container for the necessary parameters to execute the UpdateApp service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest updateAppRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAppRequestMarshaller();
            var unmarshaller = UpdateAppResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateAppRequest, UpdateAppResponse>(updateAppRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Updates a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="updateInstanceRequest">Container for the necessary parameters to execute the UpdateInstance service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest updateInstanceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateInstanceRequestMarshaller();
            var unmarshaller = UpdateInstanceResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateInstanceRequest, UpdateInstanceResponse>(updateInstanceRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Updates a specified layer.</para>
        /// </summary>
        /// 
        /// <param name="updateLayerRequest">Container for the necessary parameters to execute the UpdateLayer service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdateLayerResponse> UpdateLayerAsync(UpdateLayerRequest updateLayerRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateLayerRequestMarshaller();
            var unmarshaller = UpdateLayerResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateLayerRequest, UpdateLayerResponse>(updateLayerRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Updates a specified stack.</para>
        /// </summary>
        /// 
        /// <param name="updateStackRequest">Container for the necessary parameters to execute the UpdateStack service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest updateStackRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStackRequestMarshaller();
            var unmarshaller = UpdateStackResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateStackRequest, UpdateStackResponse>(updateStackRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Updates a specified user profile.</para>
        /// </summary>
        /// 
        /// <param name="updateUserProfileRequest">Container for the necessary parameters to execute the UpdateUserProfile service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest updateUserProfileRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateUserProfileRequestMarshaller();
            var unmarshaller = UpdateUserProfileResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateUserProfileRequest, UpdateUserProfileResponse>(updateUserProfileRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
