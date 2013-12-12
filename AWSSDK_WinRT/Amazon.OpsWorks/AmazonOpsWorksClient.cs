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
    /// the <a href="http://aws.amazon.com/opsworks/">AWS OpsWorks</a> details page. </para> <para> <b>SDKs and CLI</b> </para> <para>The most
    /// common way to use the AWS OpsWorks API is by using the AWS Command Line Interface (CLI) or by using one of the AWS SDKs to implement
    /// applications in your preferred language. For more information, see:</para>
    /// <ul>
    /// <li> <a href="http://docs.aws.amazon.com/cli/latest/userguide/cli-chap-welcome.html">AWS CLI</a> </li>
    /// <li> <a href="http://docs.aws.amazon.com/AWSJavaSDK/latest/javadoc/com/amazonaws/services/opsworks/AWSOpsWorksClient.html">AWS SDK for
    /// Java</a> </li>
    /// <li> <a href="http://docs.aws.amazon.com/sdkfornet/latest/apidocs/html/N_Amazon_OpsWorks.htm">AWS SDK for .NET</a> </li>
    /// <li> <a href="http://docs.aws.amazon.com/aws-sdk-php-2/latest/class-Aws.OpsWorks.OpsWorksClient.html">AWS SDK for PHP 2</a> </li>
    /// <li> <a href="http://docs.aws.amazon.com/AWSRubySDK/latest/AWS/OpsWorks/Client.html">AWS SDK for Ruby</a> </li>
    /// <li> <a href="http://aws.amazon.com/documentation/sdkforjavascript/">AWS SDK for Node.js</a> </li>
    /// <li> <a href="http://docs.pythonboto.org/en/latest/ref/opsworks.html">AWS SDK for Python(Boto)</a> </li>
    /// 
    /// </ul>
    /// <para> <b>Endpoints</b> </para> <para>AWS OpsWorks supports only one endpoint, opsworks.us-east-1.amazonaws.com (HTTPS), so you must
    /// connect to that endpoint. You can then use the API to direct AWS OpsWorks to create stacks in any AWS Region.</para> <para> <b>Chef
    /// Version</b> </para> <para>When you call CreateStack, CloneStack, or UpdateStack we recommend you use the <c>ConfigurationManager</c>
    /// parameter to specify the Chef version, 0.9 or 11.4. The default value is currently 0.9. However, we expect to change the default value to
    /// 11.4 in October 2013. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook-chef11.html">Using AWS OpsWorks with Chef 11</a> .</para>
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
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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

 
		internal AssignVolumeResponse AssignVolume(AssignVolumeRequest request)
        {
            var task = AssignVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Assigns one of the stack's registered Amazon EBS volumes to a specified instance. The volume must first be registered with the stack
        /// by calling RegisterVolume. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a> .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the
        /// stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="assignVolumeRequest">Container for the necessary parameters to execute the AssignVolume service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<AssignVolumeResponse> AssignVolumeAsync(AssignVolumeRequest assignVolumeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssignVolumeRequestMarshaller();
            var unmarshaller = AssignVolumeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AssignVolumeRequest, AssignVolumeResponse>(assignVolumeRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal AssociateElasticIpResponse AssociateElasticIp(AssociateElasticIpRequest request)
        {
            var task = AssociateElasticIpAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Associates one of the stack's registered Elastic IP addresses with a specified instance. The address must first be registered with the
        /// stack by calling RegisterElasticIp. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource Management</a> .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level
        /// for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="associateElasticIpRequest">Container for the necessary parameters to execute the AssociateElasticIp service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<AssociateElasticIpResponse> AssociateElasticIpAsync(AssociateElasticIpRequest associateElasticIpRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateElasticIpRequestMarshaller();
            var unmarshaller = AssociateElasticIpResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AssociateElasticIpRequest, AssociateElasticIpResponse>(associateElasticIpRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal AttachElasticLoadBalancerResponse AttachElasticLoadBalancer(AttachElasticLoadBalancerRequest request)
        {
            var task = AttachElasticLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Attaches an Elastic Load Balancing load balancer to a specified layer.</para> <para><b>NOTE:</b>You must create the Elastic Load
        /// Balancing instance separately, by using the Elastic Load Balancing console, API, or CLI. For more information, see Elastic Load Balancing
        /// Developer Guide.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the
        /// stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal CloneStackResponse CloneStack(CloneStackRequest request)
        {
            var task = CloneStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a clone of a specified stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-cloning.html">Clone a Stack</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have an attached policy that explicitly grants permissions. For more information on
        /// user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User
        /// Permissions</a> .</para>
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
 
		internal CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var task = CreateAppAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates an app for a specified stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-creating.html">Creating Apps</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var task = CreateDeploymentAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deploys a stack or app.</para>
        /// <ul>
        /// <li>App deployment generates a <c>deploy</c> event, which runs the associated recipes and passes them a JSON stack configuration object
        /// that includes information about the app. </li>
        /// <li>Stack deployment runs the <c>deploy</c> recipes but does not raise an event.</li>
        /// 
        /// </ul>
        /// <para>For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-deploying.html">Deploying
        /// Apps</a> and <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-commands.html">Run Stack Commands</a> .</para>
        /// <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Deploy or Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            var task = CreateInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates an instance in a specified stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-add.html">Adding an Instance to a Layer</a> .</para> <para>
        /// <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that
        /// explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal CreateLayerResponse CreateLayer(CreateLayerRequest request)
        {
            var task = CreateLayerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a layer. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-create.html">How to Create a Layer</a> .</para>
        /// <para><b>NOTE:</b>You should use CreateLayer for noncustom layer types such as PHP App Server only if the stack does not have an existing
        /// layer of that type. A stack can have at most one instance of each noncustom layer; if you attempt to create a second instance, CreateLayer
        /// fails. A stack can have an arbitrary number of custom layers, so you can call CreateLayer as many times as you like for that layer
        /// type.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var task = CreateStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a new stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-edit.html">Create a New Stack</a> .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have an attached policy that
        /// explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request)
        {
            var task = CreateUserProfileAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a new user profile.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have an attached policy
        /// that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var task = DeleteAppAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes a specified app.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            var task = DeleteInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes a specified instance. You must stop an instance before you can delete it. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-delete.html">Deleting Instances</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DeleteLayerResponse DeleteLayer(DeleteLayerRequest request)
        {
            var task = DeleteLayerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes a specified layer. You must first stop and then delete all associated instances. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-delete.html">How to Delete a Layer</a> .</para> <para>
        /// <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that
        /// explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var task = DeleteStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes a specified stack. You must first delete all instances, layers, and apps. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-shutting.html">Shut Down a Stack</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest request)
        {
            var task = DeleteUserProfileAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes a user profile.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have an attached policy that
        /// explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DeregisterElasticIpResponse DeregisterElasticIp(DeregisterElasticIpRequest request)
        {
            var task = DeregisterElasticIpAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deregisters a specified Elastic IP address. The address can then be registered by another stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="deregisterElasticIpRequest">Container for the necessary parameters to execute the DeregisterElasticIp service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeregisterElasticIpResponse> DeregisterElasticIpAsync(DeregisterElasticIpRequest deregisterElasticIpRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterElasticIpRequestMarshaller();
            var unmarshaller = DeregisterElasticIpResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeregisterElasticIpRequest, DeregisterElasticIpResponse>(deregisterElasticIpRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DeregisterVolumeResponse DeregisterVolume(DeregisterVolumeRequest request)
        {
            var task = DeregisterVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deregisters an Amazon EBS volume. The volume can then be registered by another stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="deregisterVolumeRequest">Container for the necessary parameters to execute the DeregisterVolume service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeregisterVolumeResponse> DeregisterVolumeAsync(DeregisterVolumeRequest deregisterVolumeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterVolumeRequestMarshaller();
            var unmarshaller = DeregisterVolumeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeregisterVolumeRequest, DeregisterVolumeResponse>(deregisterVolumeRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DescribeAppsResponse DescribeApps(DescribeAppsRequest request)
        {
            var task = DescribeAppsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Requests a description of a specified set of apps.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
        /// <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or
        /// an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DescribeCommandsResponse DescribeCommands(DescribeCommandsRequest request)
        {
            var task = DescribeCommandsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes the results of specified commands.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para> <para>
        /// <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DescribeDeploymentsResponse DescribeDeployments(DescribeDeploymentsRequest request)
        {
            var task = DescribeDeploymentsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Requests a description of a specified set of deployments.</para> <para><b>NOTE:</b>You must specify at least one of the
        /// parameters.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DescribeElasticIpsResponse DescribeElasticIps(DescribeElasticIpsRequest request)
        {
            var task = DescribeElasticIpsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic IP addresses</a>
        /// .</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para> <para> <b>Required Permissions</b> : To use this action,
        /// an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or an attached policy that explicitly grants permissions.
        /// For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers(DescribeElasticLoadBalancersRequest request)
        {
            var task = DescribeElasticLoadBalancersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes a stack's Elastic Load Balancing instances.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
        /// <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or
        /// an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var task = DescribeInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Requests a description of a set of instances.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para> <para>
        /// <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DescribeLayersResponse DescribeLayers(DescribeLayersRequest request)
        {
            var task = DescribeLayersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Requests a description of one or more layers in a specified stack.</para> <para><b>NOTE:</b>You must specify at least one of the
        /// parameters.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DescribeLoadBasedAutoScalingResponse DescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest request)
        {
            var task = DescribeLoadBasedAutoScalingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes load-based auto scaling configurations for specified layers.</para> <para><b>NOTE:</b>You must specify at least one of the
        /// parameters.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DescribeMyUserProfileResponse DescribeMyUserProfile(DescribeMyUserProfileRequest request)
        {
            var task = DescribeMyUserProfileAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes a user's SSH information.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have
        /// self-management enabled or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeMyUserProfileRequest">Container for the necessary parameters to execute the DescribeMyUserProfile service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeMyUserProfile service method, as returned by AmazonOpsWorks.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeMyUserProfileResponse> DescribeMyUserProfileAsync(DescribeMyUserProfileRequest describeMyUserProfileRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMyUserProfileRequestMarshaller();
            var unmarshaller = DescribeMyUserProfileResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeMyUserProfileRequest, DescribeMyUserProfileResponse>(describeMyUserProfileRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DescribePermissionsResponse DescribePermissions(DescribePermissionsRequest request)
        {
            var task = DescribePermissionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes the permissions for a specified stack.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have
        /// a Manage permissions level for the stack, or an attached policy that explicitly grants permissions. For more information on user
        /// permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a>
        /// .</para>
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
 
		internal DescribeRaidArraysResponse DescribeRaidArrays(DescribeRaidArraysRequest request)
        {
            var task = DescribeRaidArraysAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describe an instance's RAID arrays.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para> <para>
        /// <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DescribeServiceErrorsResponse DescribeServiceErrors(DescribeServiceErrorsRequest request)
        {
            var task = DescribeServiceErrorsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes AWS OpsWorks service errors.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show,
        /// Deploy, or Manage permissions level for the stack, or an attached policy that explicitly grants permissions. For more information on user
        /// permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a>
        /// .</para>
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
 
		internal DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            var task = DescribeStacksAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Requests a description of one or more stacks.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a
        /// Show, Deploy, or Manage permissions level for the stack, or an attached policy that explicitly grants permissions. For more information on
        /// user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User
        /// Permissions</a> .</para>
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
 
		internal DescribeStackSummaryResponse DescribeStackSummary(DescribeStackSummaryRequest request)
        {
            var task = DescribeStackSummaryAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes the number of layers and apps in a specified stack, and the number of instances in each state, such as <c>running_setup</c>
        /// or <c>online</c> .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage
        /// permissions level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeStackSummaryRequest">Container for the necessary parameters to execute the DescribeStackSummary service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeStackSummary service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeStackSummaryResponse> DescribeStackSummaryAsync(DescribeStackSummaryRequest describeStackSummaryRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackSummaryRequestMarshaller();
            var unmarshaller = DescribeStackSummaryResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeStackSummaryRequest, DescribeStackSummaryResponse>(describeStackSummaryRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DescribeTimeBasedAutoScalingResponse DescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest request)
        {
            var task = DescribeTimeBasedAutoScalingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes time-based auto scaling configurations for specified instances.</para> <para><b>NOTE:</b>You must specify at least one of
        /// the parameters.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DescribeUserProfilesResponse DescribeUserProfiles(DescribeUserProfilesRequest request)
        {
            var task = DescribeUserProfilesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describe specified users.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have an attached policy
        /// that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            var task = DescribeVolumesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes an instance's Amazon EBS volumes.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para> <para>
        /// <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal DetachElasticLoadBalancerResponse DetachElasticLoadBalancer(DetachElasticLoadBalancerRequest request)
        {
            var task = DetachElasticLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Detaches a specified Elastic Load Balancing instance from its layer.</para> <para> <b>Required Permissions</b> : To use this action,
        /// an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly grants permissions. For more
        /// information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a> .</para>
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
 
		internal DisassociateElasticIpResponse DisassociateElasticIp(DisassociateElasticIpRequest request)
        {
            var task = DisassociateElasticIpAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Disassociates an Elastic IP address from its instance. The address remains registered with the stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="disassociateElasticIpRequest">Container for the necessary parameters to execute the DisassociateElasticIp service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DisassociateElasticIpResponse> DisassociateElasticIpAsync(DisassociateElasticIpRequest disassociateElasticIpRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateElasticIpRequestMarshaller();
            var unmarshaller = DisassociateElasticIpResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DisassociateElasticIpRequest, DisassociateElasticIpResponse>(disassociateElasticIpRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal GetHostnameSuggestionResponse GetHostnameSuggestion(GetHostnameSuggestionRequest request)
        {
            var task = GetHostnameSuggestionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Gets a generated host name for the specified layer, based on the current host name theme.</para> <para> <b>Required Permissions</b> :
        /// To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="getHostnameSuggestionRequest">Container for the necessary parameters to execute the GetHostnameSuggestion service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the GetHostnameSuggestion service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
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
 
		internal RebootInstanceResponse RebootInstance(RebootInstanceRequest request)
        {
            var task = RebootInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Reboots a specified instance. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-starting.html">Starting, Stopping, and Rebooting Instances</a>
        /// .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal RegisterElasticIpResponse RegisterElasticIp(RegisterElasticIpRequest request)
        {
            var task = RegisterElasticIpAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Registers an Elastic IP address with a specified stack. An address can be registered with only one stack at a time. If the address is
        /// already registered, you must first deregister it by calling DeregisterElasticIp. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="registerElasticIpRequest">Container for the necessary parameters to execute the RegisterElasticIp service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the RegisterElasticIp service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<RegisterElasticIpResponse> RegisterElasticIpAsync(RegisterElasticIpRequest registerElasticIpRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterElasticIpRequestMarshaller();
            var unmarshaller = RegisterElasticIpResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RegisterElasticIpRequest, RegisterElasticIpResponse>(registerElasticIpRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal RegisterVolumeResponse RegisterVolume(RegisterVolumeRequest request)
        {
            var task = RegisterVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Registers an Amazon EBS volume with a specified stack. A volume can be registered with only one stack at a time. If the volume is
        /// already registered, you must first deregister it by calling DeregisterVolume. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="registerVolumeRequest">Container for the necessary parameters to execute the RegisterVolume service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the RegisterVolume service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<RegisterVolumeResponse> RegisterVolumeAsync(RegisterVolumeRequest registerVolumeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterVolumeRequestMarshaller();
            var unmarshaller = RegisterVolumeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RegisterVolumeRequest, RegisterVolumeResponse>(registerVolumeRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal SetLoadBasedAutoScalingResponse SetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest request)
        {
            var task = SetLoadBasedAutoScalingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Specify the load-based auto scaling configuration for a specified layer. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-autoscaling.html">Managing Load with Time-based and Load-based
        /// Instances</a> .</para> <para><b>NOTE:</b>To use load-based auto scaling, you must create a set of load-based auto scaling instances.
        /// Load-based auto scaling operates only on the instances from that set, so you must ensure that you have created enough instances to handle
        /// the maximum anticipated load.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal SetPermissionResponse SetPermission(SetPermissionRequest request)
        {
            var task = SetPermissionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Specifies a stack's permissions. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingsecurity.html">Security and Permissions</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal SetTimeBasedAutoScalingResponse SetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest request)
        {
            var task = SetTimeBasedAutoScalingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Specify the time-based auto scaling configuration for a specified instance. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-autoscaling.html">Managing Load with Time-based and Load-based
        /// Instances</a> .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the
        /// stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            var task = StartInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Starts a specified instance. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-starting.html">Starting, Stopping, and Rebooting Instances</a>
        /// .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal StartStackResponse StartStack(StartStackRequest request)
        {
            var task = StartStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Starts stack's instances. </para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            var task = StopInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Stops a specified instance. When you stop a standard instance, the data disappears and must be reinstalled when you restart the
        /// instance. You can stop an Amazon EBS-backed instance without losing data. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-starting.html">Starting, Stopping, and Rebooting Instances</a>
        /// .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal StopStackResponse StopStack(StopStackRequest request)
        {
            var task = StopStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Stops a specified stack.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal UnassignVolumeResponse UnassignVolume(UnassignVolumeRequest request)
        {
            var task = UnassignVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Unassigns an assigned Amazon EBS volume. The volume remains registered with the stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="unassignVolumeRequest">Container for the necessary parameters to execute the UnassignVolume service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UnassignVolumeResponse> UnassignVolumeAsync(UnassignVolumeRequest unassignVolumeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnassignVolumeRequestMarshaller();
            var unmarshaller = UnassignVolumeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UnassignVolumeRequest, UnassignVolumeResponse>(unassignVolumeRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal UpdateAppResponse UpdateApp(UpdateAppRequest request)
        {
            var task = UpdateAppAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Updates a specified app.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Deploy or Manage
        /// permissions level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal UpdateElasticIpResponse UpdateElasticIp(UpdateElasticIpRequest request)
        {
            var task = UpdateElasticIpAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Updates a registered Elastic IP address's name. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateElasticIpRequest">Container for the necessary parameters to execute the UpdateElasticIp service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdateElasticIpResponse> UpdateElasticIpAsync(UpdateElasticIpRequest updateElasticIpRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateElasticIpRequestMarshaller();
            var unmarshaller = UpdateElasticIpResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateElasticIpRequest, UpdateElasticIpResponse>(updateElasticIpRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            var task = UpdateInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Updates a specified instance.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage
        /// permissions level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal UpdateLayerResponse UpdateLayer(UpdateLayerRequest request)
        {
            var task = UpdateLayerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Updates a specified layer.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal UpdateMyUserProfileResponse UpdateMyUserProfile(UpdateMyUserProfileRequest request)
        {
            var task = UpdateMyUserProfileAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Updates a user's SSH public key.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have self-management
        /// enabled or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateMyUserProfileRequest">Container for the necessary parameters to execute the UpdateMyUserProfile service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdateMyUserProfileResponse> UpdateMyUserProfileAsync(UpdateMyUserProfileRequest updateMyUserProfileRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateMyUserProfileRequestMarshaller();
            var unmarshaller = UpdateMyUserProfileResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateMyUserProfileRequest, UpdateMyUserProfileResponse>(updateMyUserProfileRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var task = UpdateStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Updates a specified stack.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request)
        {
            var task = UpdateUserProfileAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Updates a specified user profile.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have an attached
        /// policy that explicitly grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
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
 
		internal UpdateVolumeResponse UpdateVolume(UpdateVolumeRequest request)
        {
            var task = UpdateVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Updates an Amazon EBS volume's name or mount point. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateVolumeRequest">Container for the necessary parameters to execute the UpdateVolume service method on
        /// AmazonOpsWorks.</param>
        /// 
        /// <exception cref="T:Amazon.OpsWorks.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.OpsWorks.Model.ValidationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdateVolumeResponse> UpdateVolumeAsync(UpdateVolumeRequest updateVolumeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateVolumeRequestMarshaller();
            var unmarshaller = UpdateVolumeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateVolumeRequest, UpdateVolumeResponse>(updateVolumeRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
