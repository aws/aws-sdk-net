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


using System;
using System.Runtime.ExceptionServices;
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
    /// Implementation for accessing OpsWorks
    ///
    /// AWS OpsWorks 
    /// <para>
    /// Welcome to the <i>AWS OpsWorks API Reference</i>. This guide provides descriptions,
    /// syntax, and usage examples about AWS OpsWorks actions and data types, including common
    /// parameters and error codes. 
    /// </para>
    ///  
    /// <para>
    /// AWS OpsWorks is an application management service that provides an integrated experience
    /// for overseeing the complete application lifecycle. For information about this product,
    /// go to the <a href="http://aws.amazon.com/opsworks/">AWS OpsWorks</a> details page.
    /// 
    /// </para>
    ///  
    /// <para>
    /// <b>SDKs and CLI</b> 
    /// </para>
    ///  
    /// <para>
    /// The most common way to use the AWS OpsWorks API is by using the AWS Command Line Interface
    /// (CLI) or by using one of the AWS SDKs to implement applications in your preferred
    /// language. For more information, see:
    /// </para>
    ///  <ul> <li><a href="http://docs.aws.amazon.com/cli/latest/userguide/cli-chap-welcome.html">AWS
    /// CLI</a></li> <li><a href="http://docs.aws.amazon.com/AWSJavaSDK/latest/javadoc/com/amazonaws/services/opsworks/AWSOpsWorksClient.html">AWS
    /// SDK for Java</a></li> <li><a href="http://docs.aws.amazon.com/sdkfornet/latest/apidocs/html/N_Amazon_OpsWorks.htm">AWS
    /// SDK for .NET</a></li> <li><a href="http://docs.aws.amazon.com/aws-sdk-php-2/latest/class-Aws.OpsWorks.OpsWorksClient.html">AWS
    /// SDK for PHP 2</a></li> <li><a href="http://docs.aws.amazon.com/AWSRubySDK/latest/AWS/OpsWorks/Client.html">AWS
    /// SDK for Ruby</a></li> <li><a href="http://aws.amazon.com/documentation/sdkforjavascript/">AWS
    /// SDK for Node.js</a></li> <li><a href="http://docs.pythonboto.org/en/latest/ref/opsworks.html">AWS
    /// SDK for Python(Boto)</a></li> </ul> 
    /// <para>
    /// <b>Endpoints</b>
    /// </para>
    ///  
    /// <para>
    /// AWS OpsWorks supports only one endpoint, opsworks.us-east-1.amazonaws.com (HTTPS),
    /// so you must connect to that endpoint. You can then use the API to direct AWS OpsWorks
    /// to create stacks in any AWS Region.
    /// </para>
    ///  
    /// <para>
    /// <b>Chef Versions</b>
    /// </para>
    ///  
    /// <para>
    /// When you call <a>CreateStack</a>, <a>CloneStack</a>, or <a>UpdateStack</a> we recommend
    /// you use the <code>ConfigurationManager</code> parameter to specify the Chef version,
    /// 0.9, 11.4, or 11.10. The default value is currently 11.10. For more information, see
    /// <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook-chef11.html">Chef
    /// Versions</a>.
    /// </para>
    /// </summary>
    public partial class AmazonOpsWorksClient : AmazonWebServiceClient, IAmazonOpsWorks
    {
        AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

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
            : this(credentials, new AmazonOpsWorksConfig{RegionEndpoint = region})
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
        /// AmazonOpsWorksClient Configuration object. 
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOpsWorksConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOpsWorksClient Configuration object. 
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

        
        #region  AssignVolume

        internal AssignVolumeResponse AssignVolume(AssignVolumeRequest request)
        {
            var task = AssignVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssignVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AssignVolumeResponse> AssignVolumeAsync(AssignVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssignVolumeRequestMarshaller();
            var unmarshaller = AssignVolumeResponseUnmarshaller.Instance;
            return Invoke<IRequest, AssignVolumeRequest, AssignVolumeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  AssociateElasticIp

        internal AssociateElasticIpResponse AssociateElasticIp(AssociateElasticIpRequest request)
        {
            var task = AssociateElasticIpAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AssociateElasticIpResponse> AssociateElasticIpAsync(AssociateElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateElasticIpRequestMarshaller();
            var unmarshaller = AssociateElasticIpResponseUnmarshaller.Instance;
            return Invoke<IRequest, AssociateElasticIpRequest, AssociateElasticIpResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  AttachElasticLoadBalancer

        internal AttachElasticLoadBalancerResponse AttachElasticLoadBalancer(AttachElasticLoadBalancerRequest request)
        {
            var task = AttachElasticLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachElasticLoadBalancer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachElasticLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AttachElasticLoadBalancerResponse> AttachElasticLoadBalancerAsync(AttachElasticLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachElasticLoadBalancerRequestMarshaller();
            var unmarshaller = AttachElasticLoadBalancerResponseUnmarshaller.Instance;
            return Invoke<IRequest, AttachElasticLoadBalancerRequest, AttachElasticLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CloneStack

        internal CloneStackResponse CloneStack(CloneStackRequest request)
        {
            var task = CloneStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CloneStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloneStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CloneStackResponse> CloneStackAsync(CloneStackRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CloneStackRequestMarshaller();
            var unmarshaller = CloneStackResponseUnmarshaller.Instance;
            return Invoke<IRequest, CloneStackRequest, CloneStackResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateApp

        internal CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var task = CreateAppAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAppRequestMarshaller();
            var unmarshaller = CreateAppResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateAppRequest, CreateAppResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateDeployment

        internal CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var task = CreateDeploymentAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDeploymentRequestMarshaller();
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateDeploymentRequest, CreateDeploymentResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateInstance

        internal CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            var task = CreateInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInstanceRequestMarshaller();
            var unmarshaller = CreateInstanceResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateInstanceRequest, CreateInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateLayer

        internal CreateLayerResponse CreateLayer(CreateLayerRequest request)
        {
            var task = CreateLayerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLayer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLayer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateLayerResponse> CreateLayerAsync(CreateLayerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLayerRequestMarshaller();
            var unmarshaller = CreateLayerResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateLayerRequest, CreateLayerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateStack

        internal CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var task = CreateStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStackRequestMarshaller();
            var unmarshaller = CreateStackResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateStackRequest, CreateStackResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateUserProfile

        internal CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request)
        {
            var task = CreateUserProfileAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateUserProfileRequestMarshaller();
            var unmarshaller = CreateUserProfileResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateUserProfileRequest, CreateUserProfileResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteApp

        internal DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var task = DeleteAppAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAppRequestMarshaller();
            var unmarshaller = DeleteAppResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteAppRequest, DeleteAppResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteInstance

        internal DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            var task = DeleteInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteInstanceRequestMarshaller();
            var unmarshaller = DeleteInstanceResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteInstanceRequest, DeleteInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteLayer

        internal DeleteLayerResponse DeleteLayer(DeleteLayerRequest request)
        {
            var task = DeleteLayerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLayer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteLayerResponse> DeleteLayerAsync(DeleteLayerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLayerRequestMarshaller();
            var unmarshaller = DeleteLayerResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteLayerRequest, DeleteLayerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteStack

        internal DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var task = DeleteStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStackRequestMarshaller();
            var unmarshaller = DeleteStackResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteStackRequest, DeleteStackResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteUserProfile

        internal DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest request)
        {
            var task = DeleteUserProfileAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteUserProfileResponse> DeleteUserProfileAsync(DeleteUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteUserProfileRequestMarshaller();
            var unmarshaller = DeleteUserProfileResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteUserProfileRequest, DeleteUserProfileResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeregisterElasticIp

        internal DeregisterElasticIpResponse DeregisterElasticIp(DeregisterElasticIpRequest request)
        {
            var task = DeregisterElasticIpAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeregisterElasticIpResponse> DeregisterElasticIpAsync(DeregisterElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterElasticIpRequestMarshaller();
            var unmarshaller = DeregisterElasticIpResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeregisterElasticIpRequest, DeregisterElasticIpResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeregisterRdsDbInstance

        internal DeregisterRdsDbInstanceResponse DeregisterRdsDbInstance(DeregisterRdsDbInstanceRequest request)
        {
            var task = DeregisterRdsDbInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterRdsDbInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterRdsDbInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeregisterRdsDbInstanceResponse> DeregisterRdsDbInstanceAsync(DeregisterRdsDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterRdsDbInstanceRequestMarshaller();
            var unmarshaller = DeregisterRdsDbInstanceResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeregisterRdsDbInstanceRequest, DeregisterRdsDbInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeregisterVolume

        internal DeregisterVolumeResponse DeregisterVolume(DeregisterVolumeRequest request)
        {
            var task = DeregisterVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeregisterVolumeResponse> DeregisterVolumeAsync(DeregisterVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterVolumeRequestMarshaller();
            var unmarshaller = DeregisterVolumeResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeregisterVolumeRequest, DeregisterVolumeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeApps

        internal DescribeAppsResponse DescribeApps(DescribeAppsRequest request)
        {
            var task = DescribeAppsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApps operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAppsRequestMarshaller();
            var unmarshaller = DescribeAppsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeAppsRequest, DescribeAppsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeCommands

        internal DescribeCommandsResponse DescribeCommands(DescribeCommandsRequest request)
        {
            var task = DescribeCommandsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCommands operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommands operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeCommandsResponse> DescribeCommandsAsync(DescribeCommandsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCommandsRequestMarshaller();
            var unmarshaller = DescribeCommandsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeCommandsRequest, DescribeCommandsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeDeployments

        internal DescribeDeploymentsResponse DescribeDeployments(DescribeDeploymentsRequest request)
        {
            var task = DescribeDeploymentsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeployments operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeployments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDeploymentsResponse> DescribeDeploymentsAsync(DescribeDeploymentsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDeploymentsRequestMarshaller();
            var unmarshaller = DescribeDeploymentsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeDeploymentsRequest, DescribeDeploymentsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeElasticIps

        internal DescribeElasticIpsResponse DescribeElasticIps(DescribeElasticIpsRequest request)
        {
            var task = DescribeElasticIpsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticIps operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticIps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeElasticIpsResponse> DescribeElasticIpsAsync(DescribeElasticIpsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeElasticIpsRequestMarshaller();
            var unmarshaller = DescribeElasticIpsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeElasticIpsRequest, DescribeElasticIpsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeElasticLoadBalancers

        internal DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers()
        {
            return DescribeElasticLoadBalancers(new DescribeElasticLoadBalancersRequest());
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
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticLoadBalancers operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeElasticLoadBalancersResponse> DescribeElasticLoadBalancersAsync(DescribeElasticLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeElasticLoadBalancersRequestMarshaller();
            var unmarshaller = DescribeElasticLoadBalancersResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeElasticLoadBalancersRequest, DescribeElasticLoadBalancersResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeInstances

        internal DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var task = DescribeInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstancesRequestMarshaller();
            var unmarshaller = DescribeInstancesResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeInstancesRequest, DescribeInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeLayers

        internal DescribeLayersResponse DescribeLayers(DescribeLayersRequest request)
        {
            var task = DescribeLayersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLayers operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLayers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeLayersResponse> DescribeLayersAsync(DescribeLayersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLayersRequestMarshaller();
            var unmarshaller = DescribeLayersResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeLayersRequest, DescribeLayersResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeLoadBasedAutoScaling

        internal DescribeLoadBasedAutoScalingResponse DescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest request)
        {
            var task = DescribeLoadBasedAutoScalingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeLoadBasedAutoScalingResponse> DescribeLoadBasedAutoScalingAsync(DescribeLoadBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBasedAutoScalingRequestMarshaller();
            var unmarshaller = DescribeLoadBasedAutoScalingResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeLoadBasedAutoScalingRequest, DescribeLoadBasedAutoScalingResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeMyUserProfile

        internal DescribeMyUserProfileResponse DescribeMyUserProfile()
        {
            return DescribeMyUserProfile(new DescribeMyUserProfileRequest());
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
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMyUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMyUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeMyUserProfileResponse> DescribeMyUserProfileAsync(DescribeMyUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMyUserProfileRequestMarshaller();
            var unmarshaller = DescribeMyUserProfileResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeMyUserProfileRequest, DescribeMyUserProfileResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribePermissions

        internal DescribePermissionsResponse DescribePermissions(DescribePermissionsRequest request)
        {
            var task = DescribePermissionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePermissions operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribePermissionsResponse> DescribePermissionsAsync(DescribePermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePermissionsRequestMarshaller();
            var unmarshaller = DescribePermissionsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribePermissionsRequest, DescribePermissionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeRaidArrays

        internal DescribeRaidArraysResponse DescribeRaidArrays(DescribeRaidArraysRequest request)
        {
            var task = DescribeRaidArraysAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRaidArrays operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRaidArrays operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeRaidArraysResponse> DescribeRaidArraysAsync(DescribeRaidArraysRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRaidArraysRequestMarshaller();
            var unmarshaller = DescribeRaidArraysResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeRaidArraysRequest, DescribeRaidArraysResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeRdsDbInstances

        internal DescribeRdsDbInstancesResponse DescribeRdsDbInstances(DescribeRdsDbInstancesRequest request)
        {
            var task = DescribeRdsDbInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRdsDbInstances operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRdsDbInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeRdsDbInstancesResponse> DescribeRdsDbInstancesAsync(DescribeRdsDbInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRdsDbInstancesRequestMarshaller();
            var unmarshaller = DescribeRdsDbInstancesResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeRdsDbInstancesRequest, DescribeRdsDbInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeServiceErrors

        internal DescribeServiceErrorsResponse DescribeServiceErrors()
        {
            return DescribeServiceErrors(new DescribeServiceErrorsRequest());
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
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceErrors operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceErrors operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeServiceErrorsResponse> DescribeServiceErrorsAsync(DescribeServiceErrorsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeServiceErrorsRequestMarshaller();
            var unmarshaller = DescribeServiceErrorsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeServiceErrorsRequest, DescribeServiceErrorsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeStacks

        internal DescribeStacksResponse DescribeStacks()
        {
            return DescribeStacks(new DescribeStacksRequest());
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
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStacksRequestMarshaller();
            var unmarshaller = DescribeStacksResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeStacksRequest, DescribeStacksResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeStackSummary

        internal DescribeStackSummaryResponse DescribeStackSummary(DescribeStackSummaryRequest request)
        {
            var task = DescribeStackSummaryAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackSummary operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSummary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeStackSummaryResponse> DescribeStackSummaryAsync(DescribeStackSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackSummaryRequestMarshaller();
            var unmarshaller = DescribeStackSummaryResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeStackSummaryRequest, DescribeStackSummaryResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeTimeBasedAutoScaling

        internal DescribeTimeBasedAutoScalingResponse DescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest request)
        {
            var task = DescribeTimeBasedAutoScalingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTimeBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTimeBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTimeBasedAutoScalingResponse> DescribeTimeBasedAutoScalingAsync(DescribeTimeBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTimeBasedAutoScalingRequestMarshaller();
            var unmarshaller = DescribeTimeBasedAutoScalingResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeTimeBasedAutoScalingRequest, DescribeTimeBasedAutoScalingResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeUserProfiles

        internal DescribeUserProfilesResponse DescribeUserProfiles()
        {
            return DescribeUserProfiles(new DescribeUserProfilesRequest());
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
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserProfiles operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeUserProfilesResponse> DescribeUserProfilesAsync(DescribeUserProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeUserProfilesRequestMarshaller();
            var unmarshaller = DescribeUserProfilesResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeUserProfilesRequest, DescribeUserProfilesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeVolumes

        internal DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            var task = DescribeVolumesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVolumesRequestMarshaller();
            var unmarshaller = DescribeVolumesResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeVolumesRequest, DescribeVolumesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DetachElasticLoadBalancer

        internal DetachElasticLoadBalancerResponse DetachElasticLoadBalancer(DetachElasticLoadBalancerRequest request)
        {
            var task = DetachElasticLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachElasticLoadBalancer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachElasticLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DetachElasticLoadBalancerResponse> DetachElasticLoadBalancerAsync(DetachElasticLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachElasticLoadBalancerRequestMarshaller();
            var unmarshaller = DetachElasticLoadBalancerResponseUnmarshaller.Instance;
            return Invoke<IRequest, DetachElasticLoadBalancerRequest, DetachElasticLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DisassociateElasticIp

        internal DisassociateElasticIpResponse DisassociateElasticIp(DisassociateElasticIpRequest request)
        {
            var task = DisassociateElasticIpAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisassociateElasticIpResponse> DisassociateElasticIpAsync(DisassociateElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateElasticIpRequestMarshaller();
            var unmarshaller = DisassociateElasticIpResponseUnmarshaller.Instance;
            return Invoke<IRequest, DisassociateElasticIpRequest, DisassociateElasticIpResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  GetHostnameSuggestion

        internal GetHostnameSuggestionResponse GetHostnameSuggestion(GetHostnameSuggestionRequest request)
        {
            var task = GetHostnameSuggestionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostnameSuggestion operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostnameSuggestion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetHostnameSuggestionResponse> GetHostnameSuggestionAsync(GetHostnameSuggestionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHostnameSuggestionRequestMarshaller();
            var unmarshaller = GetHostnameSuggestionResponseUnmarshaller.Instance;
            return Invoke<IRequest, GetHostnameSuggestionRequest, GetHostnameSuggestionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  RebootInstance

        internal RebootInstanceResponse RebootInstance(RebootInstanceRequest request)
        {
            var task = RebootInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootInstanceRequestMarshaller();
            var unmarshaller = RebootInstanceResponseUnmarshaller.Instance;
            return Invoke<IRequest, RebootInstanceRequest, RebootInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  RegisterElasticIp

        internal RegisterElasticIpResponse RegisterElasticIp(RegisterElasticIpRequest request)
        {
            var task = RegisterElasticIpAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RegisterElasticIpResponse> RegisterElasticIpAsync(RegisterElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterElasticIpRequestMarshaller();
            var unmarshaller = RegisterElasticIpResponseUnmarshaller.Instance;
            return Invoke<IRequest, RegisterElasticIpRequest, RegisterElasticIpResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  RegisterRdsDbInstance

        internal RegisterRdsDbInstanceResponse RegisterRdsDbInstance(RegisterRdsDbInstanceRequest request)
        {
            var task = RegisterRdsDbInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterRdsDbInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterRdsDbInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RegisterRdsDbInstanceResponse> RegisterRdsDbInstanceAsync(RegisterRdsDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterRdsDbInstanceRequestMarshaller();
            var unmarshaller = RegisterRdsDbInstanceResponseUnmarshaller.Instance;
            return Invoke<IRequest, RegisterRdsDbInstanceRequest, RegisterRdsDbInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  RegisterVolume

        internal RegisterVolumeResponse RegisterVolume(RegisterVolumeRequest request)
        {
            var task = RegisterVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RegisterVolumeResponse> RegisterVolumeAsync(RegisterVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterVolumeRequestMarshaller();
            var unmarshaller = RegisterVolumeResponseUnmarshaller.Instance;
            return Invoke<IRequest, RegisterVolumeRequest, RegisterVolumeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  SetLoadBasedAutoScaling

        internal SetLoadBasedAutoScalingResponse SetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest request)
        {
            var task = SetLoadBasedAutoScalingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetLoadBasedAutoScalingResponse> SetLoadBasedAutoScalingAsync(SetLoadBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetLoadBasedAutoScalingRequestMarshaller();
            var unmarshaller = SetLoadBasedAutoScalingResponseUnmarshaller.Instance;
            return Invoke<IRequest, SetLoadBasedAutoScalingRequest, SetLoadBasedAutoScalingResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  SetPermission

        internal SetPermissionResponse SetPermission(SetPermissionRequest request)
        {
            var task = SetPermissionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetPermission operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetPermissionResponse> SetPermissionAsync(SetPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetPermissionRequestMarshaller();
            var unmarshaller = SetPermissionResponseUnmarshaller.Instance;
            return Invoke<IRequest, SetPermissionRequest, SetPermissionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  SetTimeBasedAutoScaling

        internal SetTimeBasedAutoScalingResponse SetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest request)
        {
            var task = SetTimeBasedAutoScalingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetTimeBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTimeBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetTimeBasedAutoScalingResponse> SetTimeBasedAutoScalingAsync(SetTimeBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetTimeBasedAutoScalingRequestMarshaller();
            var unmarshaller = SetTimeBasedAutoScalingResponseUnmarshaller.Instance;
            return Invoke<IRequest, SetTimeBasedAutoScalingRequest, SetTimeBasedAutoScalingResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  StartInstance

        internal StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            var task = StartInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartInstanceRequestMarshaller();
            var unmarshaller = StartInstanceResponseUnmarshaller.Instance;
            return Invoke<IRequest, StartInstanceRequest, StartInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  StartStack

        internal StartStackResponse StartStack(StartStackRequest request)
        {
            var task = StartStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StartStackResponse> StartStackAsync(StartStackRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartStackRequestMarshaller();
            var unmarshaller = StartStackResponseUnmarshaller.Instance;
            return Invoke<IRequest, StartStackRequest, StartStackResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  StopInstance

        internal StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            var task = StopInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopInstanceRequestMarshaller();
            var unmarshaller = StopInstanceResponseUnmarshaller.Instance;
            return Invoke<IRequest, StopInstanceRequest, StopInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  StopStack

        internal StopStackResponse StopStack(StopStackRequest request)
        {
            var task = StopStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StopStackResponse> StopStackAsync(StopStackRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopStackRequestMarshaller();
            var unmarshaller = StopStackResponseUnmarshaller.Instance;
            return Invoke<IRequest, StopStackRequest, StopStackResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UnassignVolume

        internal UnassignVolumeResponse UnassignVolume(UnassignVolumeRequest request)
        {
            var task = UnassignVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnassignVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UnassignVolumeResponse> UnassignVolumeAsync(UnassignVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnassignVolumeRequestMarshaller();
            var unmarshaller = UnassignVolumeResponseUnmarshaller.Instance;
            return Invoke<IRequest, UnassignVolumeRequest, UnassignVolumeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UpdateApp

        internal UpdateAppResponse UpdateApp(UpdateAppRequest request)
        {
            var task = UpdateAppAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAppRequestMarshaller();
            var unmarshaller = UpdateAppResponseUnmarshaller.Instance;
            return Invoke<IRequest, UpdateAppRequest, UpdateAppResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UpdateElasticIp

        internal UpdateElasticIpResponse UpdateElasticIp(UpdateElasticIpRequest request)
        {
            var task = UpdateElasticIpAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateElasticIpResponse> UpdateElasticIpAsync(UpdateElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateElasticIpRequestMarshaller();
            var unmarshaller = UpdateElasticIpResponseUnmarshaller.Instance;
            return Invoke<IRequest, UpdateElasticIpRequest, UpdateElasticIpResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UpdateInstance

        internal UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            var task = UpdateInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateInstanceRequestMarshaller();
            var unmarshaller = UpdateInstanceResponseUnmarshaller.Instance;
            return Invoke<IRequest, UpdateInstanceRequest, UpdateInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UpdateLayer

        internal UpdateLayerResponse UpdateLayer(UpdateLayerRequest request)
        {
            var task = UpdateLayerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLayer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLayer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateLayerResponse> UpdateLayerAsync(UpdateLayerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateLayerRequestMarshaller();
            var unmarshaller = UpdateLayerResponseUnmarshaller.Instance;
            return Invoke<IRequest, UpdateLayerRequest, UpdateLayerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UpdateMyUserProfile

        internal UpdateMyUserProfileResponse UpdateMyUserProfile()
        {
            return UpdateMyUserProfile(new UpdateMyUserProfileRequest());
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
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMyUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMyUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateMyUserProfileResponse> UpdateMyUserProfileAsync(UpdateMyUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateMyUserProfileRequestMarshaller();
            var unmarshaller = UpdateMyUserProfileResponseUnmarshaller.Instance;
            return Invoke<IRequest, UpdateMyUserProfileRequest, UpdateMyUserProfileResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UpdateRdsDbInstance

        internal UpdateRdsDbInstanceResponse UpdateRdsDbInstance(UpdateRdsDbInstanceRequest request)
        {
            var task = UpdateRdsDbInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRdsDbInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRdsDbInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateRdsDbInstanceResponse> UpdateRdsDbInstanceAsync(UpdateRdsDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateRdsDbInstanceRequestMarshaller();
            var unmarshaller = UpdateRdsDbInstanceResponseUnmarshaller.Instance;
            return Invoke<IRequest, UpdateRdsDbInstanceRequest, UpdateRdsDbInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UpdateStack

        internal UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var task = UpdateStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStackRequestMarshaller();
            var unmarshaller = UpdateStackResponseUnmarshaller.Instance;
            return Invoke<IRequest, UpdateStackRequest, UpdateStackResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UpdateUserProfile

        internal UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request)
        {
            var task = UpdateUserProfileAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateUserProfileRequestMarshaller();
            var unmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;
            return Invoke<IRequest, UpdateUserProfileRequest, UpdateUserProfileResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UpdateVolume

        internal UpdateVolumeResponse UpdateVolume(UpdateVolumeRequest request)
        {
            var task = UpdateVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateVolumeResponse> UpdateVolumeAsync(UpdateVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateVolumeRequestMarshaller();
            var unmarshaller = UpdateVolumeResponseUnmarshaller.Instance;
            return Invoke<IRequest, UpdateVolumeRequest, UpdateVolumeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
    }
}