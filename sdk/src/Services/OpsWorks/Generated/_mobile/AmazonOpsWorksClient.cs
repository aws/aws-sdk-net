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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

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
    /// syntax, and usage examples for AWS OpsWorks actions and data types, including common
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
    ///  <b>SDKs and CLI</b> 
    /// </para>
    ///  
    /// <para>
    /// The most common way to use the AWS OpsWorks API is by using the AWS Command Line Interface
    /// (CLI) or by using one of the AWS SDKs to implement applications in your preferred
    /// language. For more information, see:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/cli/latest/userguide/cli-chap-welcome.html">AWS
    /// CLI</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/AWSJavaSDK/latest/javadoc/com/amazonaws/services/opsworks/AWSOpsWorksClient.html">AWS
    /// SDK for Java</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/sdkfornet/latest/apidocs/html/N_Amazon_OpsWorks.htm">AWS
    /// SDK for .NET</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/aws-sdk-php-2/latest/class-Aws.OpsWorks.OpsWorksClient.html">AWS
    /// SDK for PHP 2</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/sdkforruby/api/">AWS SDK for Ruby</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/documentation/sdkforjavascript/">AWS SDK for Node.js</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.pythonboto.org/en/latest/ref/opsworks.html">AWS SDK for Python(Boto)</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// AWS OpsWorks supports the following endpoints, all HTTPS. You must connect to one
    /// of the following endpoints. Stacks can only be accessed or managed within the endpoint
    /// in which they are created.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// opsworks.us-east-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.us-west-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.us-west-2.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.eu-west-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.eu-central-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.ap-northeast-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.ap-northeast-2.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.ap-south-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.ap-southeast-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.ap-southeast-2.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.sa-east-1.amazonaws.com
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Chef Versions</b> 
    /// </para>
    ///  
    /// <para>
    /// When you call <a>CreateStack</a>, <a>CloneStack</a>, or <a>UpdateStack</a> we recommend
    /// you use the <code>ConfigurationManager</code> parameter to specify the Chef version.
    /// The recommended and default value for Linux stacks is currently 12. Windows stacks
    /// use Chef 12.2. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook-chef11.html">Chef
    /// Versions</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can specify Chef 12, 11.10, or 11.4 for your Linux stack. We recommend migrating
    /// your existing Linux stacks to Chef 12 as soon as possible.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonOpsWorksClient : AmazonServiceClient, IAmazonOpsWorks
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonOpsWorksClient with the credentials loaded from the application's
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
        public AmazonOpsWorksClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpsWorksConfig()) { }

        /// <summary>
        /// Constructs AmazonOpsWorksClient with the credentials loaded from the application's
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
        public AmazonOpsWorksClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpsWorksConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonOpsWorksClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonOpsWorksClient Configuration Object</param>
        public AmazonOpsWorksClient(AmazonOpsWorksConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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
            : base(credentials, clientConfig)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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

        
        #region  AssignInstance

        internal AssignInstanceResponse AssignInstance(AssignInstanceRequest request)
        {
            var marshaller = new AssignInstanceRequestMarshaller();
            var unmarshaller = AssignInstanceResponseUnmarshaller.Instance;

            return Invoke<AssignInstanceRequest,AssignInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssignInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AssignInstanceResponse> AssignInstanceAsync(AssignInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssignInstanceRequestMarshaller();
            var unmarshaller = AssignInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<AssignInstanceRequest,AssignInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssignVolume

        internal AssignVolumeResponse AssignVolume(AssignVolumeRequest request)
        {
            var marshaller = new AssignVolumeRequestMarshaller();
            var unmarshaller = AssignVolumeResponseUnmarshaller.Instance;

            return Invoke<AssignVolumeRequest,AssignVolumeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssignVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AssignVolumeResponse> AssignVolumeAsync(AssignVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssignVolumeRequestMarshaller();
            var unmarshaller = AssignVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<AssignVolumeRequest,AssignVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateElasticIp

        internal AssociateElasticIpResponse AssociateElasticIp(AssociateElasticIpRequest request)
        {
            var marshaller = new AssociateElasticIpRequestMarshaller();
            var unmarshaller = AssociateElasticIpResponseUnmarshaller.Instance;

            return Invoke<AssociateElasticIpRequest,AssociateElasticIpResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateElasticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AssociateElasticIpResponse> AssociateElasticIpAsync(AssociateElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateElasticIpRequestMarshaller();
            var unmarshaller = AssociateElasticIpResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateElasticIpRequest,AssociateElasticIpResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachElasticLoadBalancer

        internal AttachElasticLoadBalancerResponse AttachElasticLoadBalancer(AttachElasticLoadBalancerRequest request)
        {
            var marshaller = new AttachElasticLoadBalancerRequestMarshaller();
            var unmarshaller = AttachElasticLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<AttachElasticLoadBalancerRequest,AttachElasticLoadBalancerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachElasticLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachElasticLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AttachElasticLoadBalancerResponse> AttachElasticLoadBalancerAsync(AttachElasticLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachElasticLoadBalancerRequestMarshaller();
            var unmarshaller = AttachElasticLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<AttachElasticLoadBalancerRequest,AttachElasticLoadBalancerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CloneStack

        internal CloneStackResponse CloneStack(CloneStackRequest request)
        {
            var marshaller = new CloneStackRequestMarshaller();
            var unmarshaller = CloneStackResponseUnmarshaller.Instance;

            return Invoke<CloneStackRequest,CloneStackResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CloneStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloneStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CloneStackResponse> CloneStackAsync(CloneStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CloneStackRequestMarshaller();
            var unmarshaller = CloneStackResponseUnmarshaller.Instance;

            return InvokeAsync<CloneStackRequest,CloneStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateApp

        internal CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var marshaller = new CreateAppRequestMarshaller();
            var unmarshaller = CreateAppResponseUnmarshaller.Instance;

            return Invoke<CreateAppRequest,CreateAppResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAppRequestMarshaller();
            var unmarshaller = CreateAppResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAppRequest,CreateAppResponse>(request, marshaller, 
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
        public Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDeploymentRequestMarshaller();
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentRequest,CreateDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateInstance

        internal CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            var marshaller = new CreateInstanceRequestMarshaller();
            var unmarshaller = CreateInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceRequest,CreateInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInstanceRequestMarshaller();
            var unmarshaller = CreateInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstanceRequest,CreateInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLayer

        internal CreateLayerResponse CreateLayer(CreateLayerRequest request)
        {
            var marshaller = new CreateLayerRequestMarshaller();
            var unmarshaller = CreateLayerResponseUnmarshaller.Instance;

            return Invoke<CreateLayerRequest,CreateLayerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLayer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLayer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateLayerResponse> CreateLayerAsync(CreateLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLayerRequestMarshaller();
            var unmarshaller = CreateLayerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLayerRequest,CreateLayerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStack

        internal CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var marshaller = new CreateStackRequestMarshaller();
            var unmarshaller = CreateStackResponseUnmarshaller.Instance;

            return Invoke<CreateStackRequest,CreateStackResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStackRequestMarshaller();
            var unmarshaller = CreateStackResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackRequest,CreateStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateUserProfile

        internal CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request)
        {
            var marshaller = new CreateUserProfileRequestMarshaller();
            var unmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return Invoke<CreateUserProfileRequest,CreateUserProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateUserProfileRequestMarshaller();
            var unmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserProfileRequest,CreateUserProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApp

        internal DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var marshaller = new DeleteAppRequestMarshaller();
            var unmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppRequest,DeleteAppResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAppRequestMarshaller();
            var unmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppRequest,DeleteAppResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteInstance

        internal DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            var marshaller = new DeleteInstanceRequestMarshaller();
            var unmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceRequest,DeleteInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteInstanceRequestMarshaller();
            var unmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInstanceRequest,DeleteInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLayer

        internal DeleteLayerResponse DeleteLayer(DeleteLayerRequest request)
        {
            var marshaller = new DeleteLayerRequestMarshaller();
            var unmarshaller = DeleteLayerResponseUnmarshaller.Instance;

            return Invoke<DeleteLayerRequest,DeleteLayerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLayer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteLayerResponse> DeleteLayerAsync(DeleteLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLayerRequestMarshaller();
            var unmarshaller = DeleteLayerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLayerRequest,DeleteLayerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteStack

        internal DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var marshaller = new DeleteStackRequestMarshaller();
            var unmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return Invoke<DeleteStackRequest,DeleteStackResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStackRequestMarshaller();
            var unmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackRequest,DeleteStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserProfile

        internal DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest request)
        {
            var marshaller = new DeleteUserProfileRequestMarshaller();
            var unmarshaller = DeleteUserProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteUserProfileRequest,DeleteUserProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteUserProfileResponse> DeleteUserProfileAsync(DeleteUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteUserProfileRequestMarshaller();
            var unmarshaller = DeleteUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserProfileRequest,DeleteUserProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterEcsCluster

        internal DeregisterEcsClusterResponse DeregisterEcsCluster(DeregisterEcsClusterRequest request)
        {
            var marshaller = new DeregisterEcsClusterRequestMarshaller();
            var unmarshaller = DeregisterEcsClusterResponseUnmarshaller.Instance;

            return Invoke<DeregisterEcsClusterRequest,DeregisterEcsClusterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterEcsCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterEcsCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeregisterEcsClusterResponse> DeregisterEcsClusterAsync(DeregisterEcsClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterEcsClusterRequestMarshaller();
            var unmarshaller = DeregisterEcsClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterEcsClusterRequest,DeregisterEcsClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterElasticIp

        internal DeregisterElasticIpResponse DeregisterElasticIp(DeregisterElasticIpRequest request)
        {
            var marshaller = new DeregisterElasticIpRequestMarshaller();
            var unmarshaller = DeregisterElasticIpResponseUnmarshaller.Instance;

            return Invoke<DeregisterElasticIpRequest,DeregisterElasticIpResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterElasticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeregisterElasticIpResponse> DeregisterElasticIpAsync(DeregisterElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterElasticIpRequestMarshaller();
            var unmarshaller = DeregisterElasticIpResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterElasticIpRequest,DeregisterElasticIpResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterInstance

        internal DeregisterInstanceResponse DeregisterInstance(DeregisterInstanceRequest request)
        {
            var marshaller = new DeregisterInstanceRequestMarshaller();
            var unmarshaller = DeregisterInstanceResponseUnmarshaller.Instance;

            return Invoke<DeregisterInstanceRequest,DeregisterInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeregisterInstanceResponse> DeregisterInstanceAsync(DeregisterInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterInstanceRequestMarshaller();
            var unmarshaller = DeregisterInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterInstanceRequest,DeregisterInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterRdsDbInstance

        internal DeregisterRdsDbInstanceResponse DeregisterRdsDbInstance(DeregisterRdsDbInstanceRequest request)
        {
            var marshaller = new DeregisterRdsDbInstanceRequestMarshaller();
            var unmarshaller = DeregisterRdsDbInstanceResponseUnmarshaller.Instance;

            return Invoke<DeregisterRdsDbInstanceRequest,DeregisterRdsDbInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterRdsDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterRdsDbInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeregisterRdsDbInstanceResponse> DeregisterRdsDbInstanceAsync(DeregisterRdsDbInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterRdsDbInstanceRequestMarshaller();
            var unmarshaller = DeregisterRdsDbInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterRdsDbInstanceRequest,DeregisterRdsDbInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterVolume

        internal DeregisterVolumeResponse DeregisterVolume(DeregisterVolumeRequest request)
        {
            var marshaller = new DeregisterVolumeRequestMarshaller();
            var unmarshaller = DeregisterVolumeResponseUnmarshaller.Instance;

            return Invoke<DeregisterVolumeRequest,DeregisterVolumeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeregisterVolumeResponse> DeregisterVolumeAsync(DeregisterVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterVolumeRequestMarshaller();
            var unmarshaller = DeregisterVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterVolumeRequest,DeregisterVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAgentVersions

        internal DescribeAgentVersionsResponse DescribeAgentVersions(DescribeAgentVersionsRequest request)
        {
            var marshaller = new DescribeAgentVersionsRequestMarshaller();
            var unmarshaller = DescribeAgentVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAgentVersionsRequest,DescribeAgentVersionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAgentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgentVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAgentVersionsResponse> DescribeAgentVersionsAsync(DescribeAgentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAgentVersionsRequestMarshaller();
            var unmarshaller = DescribeAgentVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAgentVersionsRequest,DescribeAgentVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeApps

        internal DescribeAppsResponse DescribeApps(DescribeAppsRequest request)
        {
            var marshaller = new DescribeAppsRequestMarshaller();
            var unmarshaller = DescribeAppsResponseUnmarshaller.Instance;

            return Invoke<DescribeAppsRequest,DescribeAppsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAppsRequestMarshaller();
            var unmarshaller = DescribeAppsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAppsRequest,DescribeAppsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCommands

        internal DescribeCommandsResponse DescribeCommands(DescribeCommandsRequest request)
        {
            var marshaller = new DescribeCommandsRequestMarshaller();
            var unmarshaller = DescribeCommandsResponseUnmarshaller.Instance;

            return Invoke<DescribeCommandsRequest,DescribeCommandsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCommands operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommands operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeCommandsResponse> DescribeCommandsAsync(DescribeCommandsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCommandsRequestMarshaller();
            var unmarshaller = DescribeCommandsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCommandsRequest,DescribeCommandsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDeployments

        internal DescribeDeploymentsResponse DescribeDeployments(DescribeDeploymentsRequest request)
        {
            var marshaller = new DescribeDeploymentsRequestMarshaller();
            var unmarshaller = DescribeDeploymentsResponseUnmarshaller.Instance;

            return Invoke<DescribeDeploymentsRequest,DescribeDeploymentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeployments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDeploymentsResponse> DescribeDeploymentsAsync(DescribeDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDeploymentsRequestMarshaller();
            var unmarshaller = DescribeDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDeploymentsRequest,DescribeDeploymentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEcsClusters

        internal DescribeEcsClustersResponse DescribeEcsClusters(DescribeEcsClustersRequest request)
        {
            var marshaller = new DescribeEcsClustersRequestMarshaller();
            var unmarshaller = DescribeEcsClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeEcsClustersRequest,DescribeEcsClustersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEcsClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEcsClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEcsClustersResponse> DescribeEcsClustersAsync(DescribeEcsClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEcsClustersRequestMarshaller();
            var unmarshaller = DescribeEcsClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEcsClustersRequest,DescribeEcsClustersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticIps

        internal DescribeElasticIpsResponse DescribeElasticIps(DescribeElasticIpsRequest request)
        {
            var marshaller = new DescribeElasticIpsRequestMarshaller();
            var unmarshaller = DescribeElasticIpsResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticIpsRequest,DescribeElasticIpsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticIps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticIps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeElasticIpsResponse> DescribeElasticIpsAsync(DescribeElasticIpsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeElasticIpsRequestMarshaller();
            var unmarshaller = DescribeElasticIpsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticIpsRequest,DescribeElasticIpsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticLoadBalancers

        internal DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers()
        {
            return DescribeElasticLoadBalancers(new DescribeElasticLoadBalancersRequest());
        }
        internal DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers(DescribeElasticLoadBalancersRequest request)
        {
            var marshaller = new DescribeElasticLoadBalancersRequestMarshaller();
            var unmarshaller = DescribeElasticLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticLoadBalancersRequest,DescribeElasticLoadBalancersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes a stack's Elastic Load Balancing instances.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeElasticLoadBalancers service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        public Task<DescribeElasticLoadBalancersResponse> DescribeElasticLoadBalancersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeElasticLoadBalancersAsync(new DescribeElasticLoadBalancersRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeElasticLoadBalancersResponse> DescribeElasticLoadBalancersAsync(DescribeElasticLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeElasticLoadBalancersRequestMarshaller();
            var unmarshaller = DescribeElasticLoadBalancersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticLoadBalancersRequest,DescribeElasticLoadBalancersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstances

        internal DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var marshaller = new DescribeInstancesRequestMarshaller();
            var unmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesRequest,DescribeInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstancesRequestMarshaller();
            var unmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancesRequest,DescribeInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLayers

        internal DescribeLayersResponse DescribeLayers(DescribeLayersRequest request)
        {
            var marshaller = new DescribeLayersRequestMarshaller();
            var unmarshaller = DescribeLayersResponseUnmarshaller.Instance;

            return Invoke<DescribeLayersRequest,DescribeLayersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLayers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLayers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeLayersResponse> DescribeLayersAsync(DescribeLayersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLayersRequestMarshaller();
            var unmarshaller = DescribeLayersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLayersRequest,DescribeLayersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBasedAutoScaling

        internal DescribeLoadBasedAutoScalingResponse DescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest request)
        {
            var marshaller = new DescribeLoadBasedAutoScalingRequestMarshaller();
            var unmarshaller = DescribeLoadBasedAutoScalingResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBasedAutoScalingRequest,DescribeLoadBasedAutoScalingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeLoadBasedAutoScalingResponse> DescribeLoadBasedAutoScalingAsync(DescribeLoadBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBasedAutoScalingRequestMarshaller();
            var unmarshaller = DescribeLoadBasedAutoScalingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBasedAutoScalingRequest,DescribeLoadBasedAutoScalingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMyUserProfile

        internal DescribeMyUserProfileResponse DescribeMyUserProfile()
        {
            return DescribeMyUserProfile(new DescribeMyUserProfileRequest());
        }
        internal DescribeMyUserProfileResponse DescribeMyUserProfile(DescribeMyUserProfileRequest request)
        {
            var marshaller = new DescribeMyUserProfileRequestMarshaller();
            var unmarshaller = DescribeMyUserProfileResponseUnmarshaller.Instance;

            return Invoke<DescribeMyUserProfileRequest,DescribeMyUserProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes a user's SSH information.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have self-management
        /// enabled or an attached policy that explicitly grants permissions. For more information
        /// on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMyUserProfile service method, as returned by OpsWorks.</returns>
        public Task<DescribeMyUserProfileResponse> DescribeMyUserProfileAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeMyUserProfileAsync(new DescribeMyUserProfileRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMyUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMyUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeMyUserProfileResponse> DescribeMyUserProfileAsync(DescribeMyUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMyUserProfileRequestMarshaller();
            var unmarshaller = DescribeMyUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMyUserProfileRequest,DescribeMyUserProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePermissions

        internal DescribePermissionsResponse DescribePermissions(DescribePermissionsRequest request)
        {
            var marshaller = new DescribePermissionsRequestMarshaller();
            var unmarshaller = DescribePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribePermissionsRequest,DescribePermissionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribePermissionsResponse> DescribePermissionsAsync(DescribePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePermissionsRequestMarshaller();
            var unmarshaller = DescribePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePermissionsRequest,DescribePermissionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRaidArrays

        internal DescribeRaidArraysResponse DescribeRaidArrays(DescribeRaidArraysRequest request)
        {
            var marshaller = new DescribeRaidArraysRequestMarshaller();
            var unmarshaller = DescribeRaidArraysResponseUnmarshaller.Instance;

            return Invoke<DescribeRaidArraysRequest,DescribeRaidArraysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRaidArrays operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRaidArrays operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeRaidArraysResponse> DescribeRaidArraysAsync(DescribeRaidArraysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRaidArraysRequestMarshaller();
            var unmarshaller = DescribeRaidArraysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRaidArraysRequest,DescribeRaidArraysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRdsDbInstances

        internal DescribeRdsDbInstancesResponse DescribeRdsDbInstances(DescribeRdsDbInstancesRequest request)
        {
            var marshaller = new DescribeRdsDbInstancesRequestMarshaller();
            var unmarshaller = DescribeRdsDbInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeRdsDbInstancesRequest,DescribeRdsDbInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRdsDbInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRdsDbInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeRdsDbInstancesResponse> DescribeRdsDbInstancesAsync(DescribeRdsDbInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRdsDbInstancesRequestMarshaller();
            var unmarshaller = DescribeRdsDbInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRdsDbInstancesRequest,DescribeRdsDbInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeServiceErrors

        internal DescribeServiceErrorsResponse DescribeServiceErrors()
        {
            return DescribeServiceErrors(new DescribeServiceErrorsRequest());
        }
        internal DescribeServiceErrorsResponse DescribeServiceErrors(DescribeServiceErrorsRequest request)
        {
            var marshaller = new DescribeServiceErrorsRequestMarshaller();
            var unmarshaller = DescribeServiceErrorsResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceErrorsRequest,DescribeServiceErrorsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes AWS OpsWorks service errors.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServiceErrors service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        public Task<DescribeServiceErrorsResponse> DescribeServiceErrorsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeServiceErrorsAsync(new DescribeServiceErrorsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceErrors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceErrors operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeServiceErrorsResponse> DescribeServiceErrorsAsync(DescribeServiceErrorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeServiceErrorsRequestMarshaller();
            var unmarshaller = DescribeServiceErrorsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServiceErrorsRequest,DescribeServiceErrorsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackProvisioningParameters

        internal DescribeStackProvisioningParametersResponse DescribeStackProvisioningParameters(DescribeStackProvisioningParametersRequest request)
        {
            var marshaller = new DescribeStackProvisioningParametersRequestMarshaller();
            var unmarshaller = DescribeStackProvisioningParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeStackProvisioningParametersRequest,DescribeStackProvisioningParametersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackProvisioningParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackProvisioningParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeStackProvisioningParametersResponse> DescribeStackProvisioningParametersAsync(DescribeStackProvisioningParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackProvisioningParametersRequestMarshaller();
            var unmarshaller = DescribeStackProvisioningParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackProvisioningParametersRequest,DescribeStackProvisioningParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStacks

        internal DescribeStacksResponse DescribeStacks()
        {
            return DescribeStacks(new DescribeStacksRequest());
        }
        internal DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            var marshaller = new DescribeStacksRequestMarshaller();
            var unmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return Invoke<DescribeStacksRequest,DescribeStacksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Requests a description of one or more stacks.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        public Task<DescribeStacksResponse> DescribeStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeStacksAsync(new DescribeStacksRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStacksRequestMarshaller();
            var unmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStacksRequest,DescribeStacksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackSummary

        internal DescribeStackSummaryResponse DescribeStackSummary(DescribeStackSummaryRequest request)
        {
            var marshaller = new DescribeStackSummaryRequestMarshaller();
            var unmarshaller = DescribeStackSummaryResponseUnmarshaller.Instance;

            return Invoke<DescribeStackSummaryRequest,DescribeStackSummaryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSummary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeStackSummaryResponse> DescribeStackSummaryAsync(DescribeStackSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackSummaryRequestMarshaller();
            var unmarshaller = DescribeStackSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackSummaryRequest,DescribeStackSummaryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTimeBasedAutoScaling

        internal DescribeTimeBasedAutoScalingResponse DescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest request)
        {
            var marshaller = new DescribeTimeBasedAutoScalingRequestMarshaller();
            var unmarshaller = DescribeTimeBasedAutoScalingResponseUnmarshaller.Instance;

            return Invoke<DescribeTimeBasedAutoScalingRequest,DescribeTimeBasedAutoScalingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTimeBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTimeBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTimeBasedAutoScalingResponse> DescribeTimeBasedAutoScalingAsync(DescribeTimeBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTimeBasedAutoScalingRequestMarshaller();
            var unmarshaller = DescribeTimeBasedAutoScalingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTimeBasedAutoScalingRequest,DescribeTimeBasedAutoScalingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeUserProfiles

        internal DescribeUserProfilesResponse DescribeUserProfiles()
        {
            return DescribeUserProfiles(new DescribeUserProfilesRequest());
        }
        internal DescribeUserProfilesResponse DescribeUserProfiles(DescribeUserProfilesRequest request)
        {
            var marshaller = new DescribeUserProfilesRequestMarshaller();
            var unmarshaller = DescribeUserProfilesResponseUnmarshaller.Instance;

            return Invoke<DescribeUserProfilesRequest,DescribeUserProfilesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describe specified users.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        /// policy that explicitly grants permissions. For more information on user permissions,
        /// see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUserProfiles service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        public Task<DescribeUserProfilesResponse> DescribeUserProfilesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeUserProfilesAsync(new DescribeUserProfilesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeUserProfilesResponse> DescribeUserProfilesAsync(DescribeUserProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeUserProfilesRequestMarshaller();
            var unmarshaller = DescribeUserProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserProfilesRequest,DescribeUserProfilesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumes

        internal DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            var marshaller = new DescribeVolumesRequestMarshaller();
            var unmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumesRequest,DescribeVolumesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVolumesRequestMarshaller();
            var unmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumesRequest,DescribeVolumesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachElasticLoadBalancer

        internal DetachElasticLoadBalancerResponse DetachElasticLoadBalancer(DetachElasticLoadBalancerRequest request)
        {
            var marshaller = new DetachElasticLoadBalancerRequestMarshaller();
            var unmarshaller = DetachElasticLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<DetachElasticLoadBalancerRequest,DetachElasticLoadBalancerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachElasticLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachElasticLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DetachElasticLoadBalancerResponse> DetachElasticLoadBalancerAsync(DetachElasticLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachElasticLoadBalancerRequestMarshaller();
            var unmarshaller = DetachElasticLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<DetachElasticLoadBalancerRequest,DetachElasticLoadBalancerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateElasticIp

        internal DisassociateElasticIpResponse DisassociateElasticIp(DisassociateElasticIpRequest request)
        {
            var marshaller = new DisassociateElasticIpRequestMarshaller();
            var unmarshaller = DisassociateElasticIpResponseUnmarshaller.Instance;

            return Invoke<DisassociateElasticIpRequest,DisassociateElasticIpResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateElasticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisassociateElasticIpResponse> DisassociateElasticIpAsync(DisassociateElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateElasticIpRequestMarshaller();
            var unmarshaller = DisassociateElasticIpResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateElasticIpRequest,DisassociateElasticIpResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHostnameSuggestion

        internal GetHostnameSuggestionResponse GetHostnameSuggestion(GetHostnameSuggestionRequest request)
        {
            var marshaller = new GetHostnameSuggestionRequestMarshaller();
            var unmarshaller = GetHostnameSuggestionResponseUnmarshaller.Instance;

            return Invoke<GetHostnameSuggestionRequest,GetHostnameSuggestionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetHostnameSuggestion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostnameSuggestion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetHostnameSuggestionResponse> GetHostnameSuggestionAsync(GetHostnameSuggestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHostnameSuggestionRequestMarshaller();
            var unmarshaller = GetHostnameSuggestionResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostnameSuggestionRequest,GetHostnameSuggestionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GrantAccess

        internal GrantAccessResponse GrantAccess(GrantAccessRequest request)
        {
            var marshaller = new GrantAccessRequestMarshaller();
            var unmarshaller = GrantAccessResponseUnmarshaller.Instance;

            return Invoke<GrantAccessRequest,GrantAccessResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GrantAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GrantAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GrantAccessResponse> GrantAccessAsync(GrantAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GrantAccessRequestMarshaller();
            var unmarshaller = GrantAccessResponseUnmarshaller.Instance;

            return InvokeAsync<GrantAccessRequest,GrantAccessResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RebootInstance

        internal RebootInstanceResponse RebootInstance(RebootInstanceRequest request)
        {
            var marshaller = new RebootInstanceRequestMarshaller();
            var unmarshaller = RebootInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootInstanceRequest,RebootInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootInstanceRequestMarshaller();
            var unmarshaller = RebootInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RebootInstanceRequest,RebootInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterEcsCluster

        internal RegisterEcsClusterResponse RegisterEcsCluster(RegisterEcsClusterRequest request)
        {
            var marshaller = new RegisterEcsClusterRequestMarshaller();
            var unmarshaller = RegisterEcsClusterResponseUnmarshaller.Instance;

            return Invoke<RegisterEcsClusterRequest,RegisterEcsClusterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterEcsCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterEcsCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RegisterEcsClusterResponse> RegisterEcsClusterAsync(RegisterEcsClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterEcsClusterRequestMarshaller();
            var unmarshaller = RegisterEcsClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterEcsClusterRequest,RegisterEcsClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterElasticIp

        internal RegisterElasticIpResponse RegisterElasticIp(RegisterElasticIpRequest request)
        {
            var marshaller = new RegisterElasticIpRequestMarshaller();
            var unmarshaller = RegisterElasticIpResponseUnmarshaller.Instance;

            return Invoke<RegisterElasticIpRequest,RegisterElasticIpResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterElasticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RegisterElasticIpResponse> RegisterElasticIpAsync(RegisterElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterElasticIpRequestMarshaller();
            var unmarshaller = RegisterElasticIpResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterElasticIpRequest,RegisterElasticIpResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterInstance

        internal RegisterInstanceResponse RegisterInstance(RegisterInstanceRequest request)
        {
            var marshaller = new RegisterInstanceRequestMarshaller();
            var unmarshaller = RegisterInstanceResponseUnmarshaller.Instance;

            return Invoke<RegisterInstanceRequest,RegisterInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RegisterInstanceResponse> RegisterInstanceAsync(RegisterInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterInstanceRequestMarshaller();
            var unmarshaller = RegisterInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterInstanceRequest,RegisterInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterRdsDbInstance

        internal RegisterRdsDbInstanceResponse RegisterRdsDbInstance(RegisterRdsDbInstanceRequest request)
        {
            var marshaller = new RegisterRdsDbInstanceRequestMarshaller();
            var unmarshaller = RegisterRdsDbInstanceResponseUnmarshaller.Instance;

            return Invoke<RegisterRdsDbInstanceRequest,RegisterRdsDbInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterRdsDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterRdsDbInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RegisterRdsDbInstanceResponse> RegisterRdsDbInstanceAsync(RegisterRdsDbInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterRdsDbInstanceRequestMarshaller();
            var unmarshaller = RegisterRdsDbInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterRdsDbInstanceRequest,RegisterRdsDbInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterVolume

        internal RegisterVolumeResponse RegisterVolume(RegisterVolumeRequest request)
        {
            var marshaller = new RegisterVolumeRequestMarshaller();
            var unmarshaller = RegisterVolumeResponseUnmarshaller.Instance;

            return Invoke<RegisterVolumeRequest,RegisterVolumeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RegisterVolumeResponse> RegisterVolumeAsync(RegisterVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterVolumeRequestMarshaller();
            var unmarshaller = RegisterVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterVolumeRequest,RegisterVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetLoadBasedAutoScaling

        internal SetLoadBasedAutoScalingResponse SetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest request)
        {
            var marshaller = new SetLoadBasedAutoScalingRequestMarshaller();
            var unmarshaller = SetLoadBasedAutoScalingResponseUnmarshaller.Instance;

            return Invoke<SetLoadBasedAutoScalingRequest,SetLoadBasedAutoScalingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetLoadBasedAutoScalingResponse> SetLoadBasedAutoScalingAsync(SetLoadBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetLoadBasedAutoScalingRequestMarshaller();
            var unmarshaller = SetLoadBasedAutoScalingResponseUnmarshaller.Instance;

            return InvokeAsync<SetLoadBasedAutoScalingRequest,SetLoadBasedAutoScalingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetPermission

        internal SetPermissionResponse SetPermission(SetPermissionRequest request)
        {
            var marshaller = new SetPermissionRequestMarshaller();
            var unmarshaller = SetPermissionResponseUnmarshaller.Instance;

            return Invoke<SetPermissionRequest,SetPermissionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetPermissionResponse> SetPermissionAsync(SetPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetPermissionRequestMarshaller();
            var unmarshaller = SetPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<SetPermissionRequest,SetPermissionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetTimeBasedAutoScaling

        internal SetTimeBasedAutoScalingResponse SetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest request)
        {
            var marshaller = new SetTimeBasedAutoScalingRequestMarshaller();
            var unmarshaller = SetTimeBasedAutoScalingResponseUnmarshaller.Instance;

            return Invoke<SetTimeBasedAutoScalingRequest,SetTimeBasedAutoScalingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetTimeBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTimeBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetTimeBasedAutoScalingResponse> SetTimeBasedAutoScalingAsync(SetTimeBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetTimeBasedAutoScalingRequestMarshaller();
            var unmarshaller = SetTimeBasedAutoScalingResponseUnmarshaller.Instance;

            return InvokeAsync<SetTimeBasedAutoScalingRequest,SetTimeBasedAutoScalingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartInstance

        internal StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            var marshaller = new StartInstanceRequestMarshaller();
            var unmarshaller = StartInstanceResponseUnmarshaller.Instance;

            return Invoke<StartInstanceRequest,StartInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartInstanceRequestMarshaller();
            var unmarshaller = StartInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StartInstanceRequest,StartInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartStack

        internal StartStackResponse StartStack(StartStackRequest request)
        {
            var marshaller = new StartStackRequestMarshaller();
            var unmarshaller = StartStackResponseUnmarshaller.Instance;

            return Invoke<StartStackRequest,StartStackResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StartStackResponse> StartStackAsync(StartStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartStackRequestMarshaller();
            var unmarshaller = StartStackResponseUnmarshaller.Instance;

            return InvokeAsync<StartStackRequest,StartStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopInstance

        internal StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            var marshaller = new StopInstanceRequestMarshaller();
            var unmarshaller = StopInstanceResponseUnmarshaller.Instance;

            return Invoke<StopInstanceRequest,StopInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopInstanceRequestMarshaller();
            var unmarshaller = StopInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StopInstanceRequest,StopInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopStack

        internal StopStackResponse StopStack(StopStackRequest request)
        {
            var marshaller = new StopStackRequestMarshaller();
            var unmarshaller = StopStackResponseUnmarshaller.Instance;

            return Invoke<StopStackRequest,StopStackResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StopStackResponse> StopStackAsync(StopStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopStackRequestMarshaller();
            var unmarshaller = StopStackResponseUnmarshaller.Instance;

            return InvokeAsync<StopStackRequest,StopStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnassignInstance

        internal UnassignInstanceResponse UnassignInstance(UnassignInstanceRequest request)
        {
            var marshaller = new UnassignInstanceRequestMarshaller();
            var unmarshaller = UnassignInstanceResponseUnmarshaller.Instance;

            return Invoke<UnassignInstanceRequest,UnassignInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UnassignInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UnassignInstanceResponse> UnassignInstanceAsync(UnassignInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnassignInstanceRequestMarshaller();
            var unmarshaller = UnassignInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UnassignInstanceRequest,UnassignInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnassignVolume

        internal UnassignVolumeResponse UnassignVolume(UnassignVolumeRequest request)
        {
            var marshaller = new UnassignVolumeRequestMarshaller();
            var unmarshaller = UnassignVolumeResponseUnmarshaller.Instance;

            return Invoke<UnassignVolumeRequest,UnassignVolumeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UnassignVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UnassignVolumeResponse> UnassignVolumeAsync(UnassignVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnassignVolumeRequestMarshaller();
            var unmarshaller = UnassignVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<UnassignVolumeRequest,UnassignVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApp

        internal UpdateAppResponse UpdateApp(UpdateAppRequest request)
        {
            var marshaller = new UpdateAppRequestMarshaller();
            var unmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return Invoke<UpdateAppRequest,UpdateAppResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAppRequestMarshaller();
            var unmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAppRequest,UpdateAppResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateElasticIp

        internal UpdateElasticIpResponse UpdateElasticIp(UpdateElasticIpRequest request)
        {
            var marshaller = new UpdateElasticIpRequestMarshaller();
            var unmarshaller = UpdateElasticIpResponseUnmarshaller.Instance;

            return Invoke<UpdateElasticIpRequest,UpdateElasticIpResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateElasticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateElasticIpResponse> UpdateElasticIpAsync(UpdateElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateElasticIpRequestMarshaller();
            var unmarshaller = UpdateElasticIpResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateElasticIpRequest,UpdateElasticIpResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateInstance

        internal UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            var marshaller = new UpdateInstanceRequestMarshaller();
            var unmarshaller = UpdateInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceRequest,UpdateInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateInstanceRequestMarshaller();
            var unmarshaller = UpdateInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateInstanceRequest,UpdateInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateLayer

        internal UpdateLayerResponse UpdateLayer(UpdateLayerRequest request)
        {
            var marshaller = new UpdateLayerRequestMarshaller();
            var unmarshaller = UpdateLayerResponseUnmarshaller.Instance;

            return Invoke<UpdateLayerRequest,UpdateLayerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLayer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLayer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateLayerResponse> UpdateLayerAsync(UpdateLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateLayerRequestMarshaller();
            var unmarshaller = UpdateLayerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLayerRequest,UpdateLayerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateMyUserProfile

        internal UpdateMyUserProfileResponse UpdateMyUserProfile()
        {
            return UpdateMyUserProfile(new UpdateMyUserProfileRequest());
        }
        internal UpdateMyUserProfileResponse UpdateMyUserProfile(UpdateMyUserProfileRequest request)
        {
            var marshaller = new UpdateMyUserProfileRequestMarshaller();
            var unmarshaller = UpdateMyUserProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateMyUserProfileRequest,UpdateMyUserProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Updates a user's SSH public key.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have self-management
        /// enabled or an attached policy that explicitly grants permissions. For more information
        /// on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMyUserProfile service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        public Task<UpdateMyUserProfileResponse> UpdateMyUserProfileAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return UpdateMyUserProfileAsync(new UpdateMyUserProfileRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMyUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMyUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateMyUserProfileResponse> UpdateMyUserProfileAsync(UpdateMyUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateMyUserProfileRequestMarshaller();
            var unmarshaller = UpdateMyUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMyUserProfileRequest,UpdateMyUserProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRdsDbInstance

        internal UpdateRdsDbInstanceResponse UpdateRdsDbInstance(UpdateRdsDbInstanceRequest request)
        {
            var marshaller = new UpdateRdsDbInstanceRequestMarshaller();
            var unmarshaller = UpdateRdsDbInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateRdsDbInstanceRequest,UpdateRdsDbInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRdsDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRdsDbInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateRdsDbInstanceResponse> UpdateRdsDbInstanceAsync(UpdateRdsDbInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateRdsDbInstanceRequestMarshaller();
            var unmarshaller = UpdateRdsDbInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRdsDbInstanceRequest,UpdateRdsDbInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateStack

        internal UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var marshaller = new UpdateStackRequestMarshaller();
            var unmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return Invoke<UpdateStackRequest,UpdateStackResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStackRequestMarshaller();
            var unmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStackRequest,UpdateStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateUserProfile

        internal UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request)
        {
            var marshaller = new UpdateUserProfileRequestMarshaller();
            var unmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateUserProfileRequest,UpdateUserProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateUserProfileRequestMarshaller();
            var unmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserProfileRequest,UpdateUserProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateVolume

        internal UpdateVolumeResponse UpdateVolume(UpdateVolumeRequest request)
        {
            var marshaller = new UpdateVolumeRequestMarshaller();
            var unmarshaller = UpdateVolumeResponseUnmarshaller.Instance;

            return Invoke<UpdateVolumeRequest,UpdateVolumeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateVolumeResponse> UpdateVolumeAsync(UpdateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateVolumeRequestMarshaller();
            var unmarshaller = UpdateVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVolumeRequest,UpdateVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}