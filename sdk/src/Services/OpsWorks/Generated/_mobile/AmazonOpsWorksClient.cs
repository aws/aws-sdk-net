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
using System.Net;

using Amazon.OpsWorks.Model;
using Amazon.OpsWorks.Model.Internal.MarshallTransformations;
using Amazon.OpsWorks.Internal;
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
    /// Welcome to the <i>AWS OpsWorks Stacks API Reference</i>. This guide provides descriptions,
    /// syntax, and usage examples for AWS OpsWorks Stacks actions and data types, including
    /// common parameters and error codes. 
    /// </para>
    ///  
    /// <para>
    /// AWS OpsWorks Stacks is an application management service that provides an integrated
    /// experience for overseeing the complete application lifecycle. For information about
    /// this product, go to the <a href="http://aws.amazon.com/opsworks/">AWS OpsWorks</a>
    /// details page. 
    /// </para>
    ///  
    /// <para>
    ///  <b>SDKs and CLI</b> 
    /// </para>
    ///  
    /// <para>
    /// The most common way to use the AWS OpsWorks Stacks API is by using the AWS Command
    /// Line Interface (CLI) or by using one of the AWS SDKs to implement applications in
    /// your preferred language. For more information, see:
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
    /// AWS OpsWorks Stacks supports the following endpoints, all HTTPS. You must connect
    /// to one of the following endpoints. Stacks can only be accessed or managed within the
    /// endpoint in which they are created.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// opsworks.us-east-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.us-east-2.amazonaws.com
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
    /// opsworks.ca-central-1.amazonaws.com (API only; not available in the AWS console)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.eu-west-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.eu-west-2.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.eu-west-3.amazonaws.com
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
        private static IServiceMetadata serviceMetadata = new AmazonOpsWorksMetadata();
        
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


        #region  AssignInstance

        internal virtual AssignInstanceResponse AssignInstance(AssignInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssignInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignInstanceResponseUnmarshaller.Instance;

            return Invoke<AssignInstanceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssignInstance">REST API Reference for AssignInstance Operation</seealso>
        public virtual Task<AssignInstanceResponse> AssignInstanceAsync(AssignInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssignInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<AssignInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssignVolume

        internal virtual AssignVolumeResponse AssignVolume(AssignVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssignVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignVolumeResponseUnmarshaller.Instance;

            return Invoke<AssignVolumeResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssignVolume">REST API Reference for AssignVolume Operation</seealso>
        public virtual Task<AssignVolumeResponse> AssignVolumeAsync(AssignVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssignVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<AssignVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateElasticIp

        internal virtual AssociateElasticIpResponse AssociateElasticIp(AssociateElasticIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateElasticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateElasticIpResponseUnmarshaller.Instance;

            return Invoke<AssociateElasticIpResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssociateElasticIp">REST API Reference for AssociateElasticIp Operation</seealso>
        public virtual Task<AssociateElasticIpResponse> AssociateElasticIpAsync(AssociateElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateElasticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateElasticIpResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateElasticIpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachElasticLoadBalancer

        internal virtual AttachElasticLoadBalancerResponse AttachElasticLoadBalancer(AttachElasticLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachElasticLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachElasticLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<AttachElasticLoadBalancerResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AttachElasticLoadBalancer">REST API Reference for AttachElasticLoadBalancer Operation</seealso>
        public virtual Task<AttachElasticLoadBalancerResponse> AttachElasticLoadBalancerAsync(AttachElasticLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachElasticLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachElasticLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<AttachElasticLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CloneStack

        internal virtual CloneStackResponse CloneStack(CloneStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CloneStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloneStackResponseUnmarshaller.Instance;

            return Invoke<CloneStackResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CloneStack">REST API Reference for CloneStack Operation</seealso>
        public virtual Task<CloneStackResponse> CloneStackAsync(CloneStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CloneStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloneStackResponseUnmarshaller.Instance;

            return InvokeAsync<CloneStackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApp

        internal virtual CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return Invoke<CreateAppResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDeployment

        internal virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInstance

        internal virtual CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        public virtual Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLayer

        internal virtual CreateLayerResponse CreateLayer(CreateLayerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLayerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLayerResponseUnmarshaller.Instance;

            return Invoke<CreateLayerResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateLayer">REST API Reference for CreateLayer Operation</seealso>
        public virtual Task<CreateLayerResponse> CreateLayerAsync(CreateLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLayerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLayerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLayerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStack

        internal virtual CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackResponseUnmarshaller.Instance;

            return Invoke<CreateStackResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateStack">REST API Reference for CreateStack Operation</seealso>
        public virtual Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUserProfile

        internal virtual CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return Invoke<CreateUserProfileResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        public virtual Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApp

        internal virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInstance

        internal virtual DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        public virtual Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLayer

        internal virtual DeleteLayerResponse DeleteLayer(DeleteLayerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLayerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLayerResponseUnmarshaller.Instance;

            return Invoke<DeleteLayerResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteLayer">REST API Reference for DeleteLayer Operation</seealso>
        public virtual Task<DeleteLayerResponse> DeleteLayerAsync(DeleteLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLayerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLayerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLayerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStack

        internal virtual DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return Invoke<DeleteStackResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        public virtual Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserProfile

        internal virtual DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteUserProfileResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        public virtual Task<DeleteUserProfileResponse> DeleteUserProfileAsync(DeleteUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterEcsCluster

        internal virtual DeregisterEcsClusterResponse DeregisterEcsCluster(DeregisterEcsClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterEcsClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterEcsClusterResponseUnmarshaller.Instance;

            return Invoke<DeregisterEcsClusterResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterEcsCluster">REST API Reference for DeregisterEcsCluster Operation</seealso>
        public virtual Task<DeregisterEcsClusterResponse> DeregisterEcsClusterAsync(DeregisterEcsClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterEcsClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterEcsClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterEcsClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterElasticIp

        internal virtual DeregisterElasticIpResponse DeregisterElasticIp(DeregisterElasticIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterElasticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterElasticIpResponseUnmarshaller.Instance;

            return Invoke<DeregisterElasticIpResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterElasticIp">REST API Reference for DeregisterElasticIp Operation</seealso>
        public virtual Task<DeregisterElasticIpResponse> DeregisterElasticIpAsync(DeregisterElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterElasticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterElasticIpResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterElasticIpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterInstance

        internal virtual DeregisterInstanceResponse DeregisterInstance(DeregisterInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterInstanceResponseUnmarshaller.Instance;

            return Invoke<DeregisterInstanceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterInstance">REST API Reference for DeregisterInstance Operation</seealso>
        public virtual Task<DeregisterInstanceResponse> DeregisterInstanceAsync(DeregisterInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterRdsDbInstance

        internal virtual DeregisterRdsDbInstanceResponse DeregisterRdsDbInstance(DeregisterRdsDbInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterRdsDbInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterRdsDbInstanceResponseUnmarshaller.Instance;

            return Invoke<DeregisterRdsDbInstanceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterRdsDbInstance">REST API Reference for DeregisterRdsDbInstance Operation</seealso>
        public virtual Task<DeregisterRdsDbInstanceResponse> DeregisterRdsDbInstanceAsync(DeregisterRdsDbInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterRdsDbInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterRdsDbInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterRdsDbInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterVolume

        internal virtual DeregisterVolumeResponse DeregisterVolume(DeregisterVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterVolumeResponseUnmarshaller.Instance;

            return Invoke<DeregisterVolumeResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterVolume">REST API Reference for DeregisterVolume Operation</seealso>
        public virtual Task<DeregisterVolumeResponse> DeregisterVolumeAsync(DeregisterVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAgentVersions

        internal virtual DescribeAgentVersionsResponse DescribeAgentVersions(DescribeAgentVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAgentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgentVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAgentVersionsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeAgentVersions">REST API Reference for DescribeAgentVersions Operation</seealso>
        public virtual Task<DescribeAgentVersionsResponse> DescribeAgentVersionsAsync(DescribeAgentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAgentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgentVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAgentVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApps

        internal virtual DescribeAppsResponse DescribeApps(DescribeAppsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppsResponseUnmarshaller.Instance;

            return Invoke<DescribeAppsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeApps">REST API Reference for DescribeApps Operation</seealso>
        public virtual Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAppsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCommands

        internal virtual DescribeCommandsResponse DescribeCommands(DescribeCommandsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCommandsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCommandsResponseUnmarshaller.Instance;

            return Invoke<DescribeCommandsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeCommands">REST API Reference for DescribeCommands Operation</seealso>
        public virtual Task<DescribeCommandsResponse> DescribeCommandsAsync(DescribeCommandsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCommandsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCommandsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCommandsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDeployments

        internal virtual DescribeDeploymentsResponse DescribeDeployments(DescribeDeploymentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeploymentsResponseUnmarshaller.Instance;

            return Invoke<DescribeDeploymentsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeDeployments">REST API Reference for DescribeDeployments Operation</seealso>
        public virtual Task<DescribeDeploymentsResponse> DescribeDeploymentsAsync(DescribeDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDeploymentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEcsClusters

        internal virtual DescribeEcsClustersResponse DescribeEcsClusters(DescribeEcsClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEcsClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEcsClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeEcsClustersResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeEcsClusters">REST API Reference for DescribeEcsClusters Operation</seealso>
        public virtual Task<DescribeEcsClustersResponse> DescribeEcsClustersAsync(DescribeEcsClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEcsClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEcsClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEcsClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticIps

        internal virtual DescribeElasticIpsResponse DescribeElasticIps(DescribeElasticIpsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticIpsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticIpsResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticIpsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeElasticIps">REST API Reference for DescribeElasticIps Operation</seealso>
        public virtual Task<DescribeElasticIpsResponse> DescribeElasticIpsAsync(DescribeElasticIpsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticIpsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticIpsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticIpsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticLoadBalancers

        internal virtual DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers()
        {
            return DescribeElasticLoadBalancers(new DescribeElasticLoadBalancersRequest());
        }
        internal virtual DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers(DescribeElasticLoadBalancersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticLoadBalancersResponse>(request, options);
        }


        /// <summary>
        /// Describes a stack's Elastic Load Balancing instances.
        /// 
        ///  <note> 
        /// <para>
        /// This call accepts only one resource-identifying parameter.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information about user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeElasticLoadBalancers">REST API Reference for DescribeElasticLoadBalancers Operation</seealso>
        public virtual Task<DescribeElasticLoadBalancersResponse> DescribeElasticLoadBalancersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeElasticLoadBalancers">REST API Reference for DescribeElasticLoadBalancers Operation</seealso>
        public virtual Task<DescribeElasticLoadBalancersResponse> DescribeElasticLoadBalancersAsync(DescribeElasticLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticLoadBalancersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticLoadBalancersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstances

        internal virtual DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        public virtual Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLayers

        internal virtual DescribeLayersResponse DescribeLayers(DescribeLayersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLayersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLayersResponseUnmarshaller.Instance;

            return Invoke<DescribeLayersResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeLayers">REST API Reference for DescribeLayers Operation</seealso>
        public virtual Task<DescribeLayersResponse> DescribeLayersAsync(DescribeLayersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLayersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLayersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLayersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBasedAutoScaling

        internal virtual DescribeLoadBasedAutoScalingResponse DescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBasedAutoScalingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBasedAutoScalingResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBasedAutoScalingResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeLoadBasedAutoScaling">REST API Reference for DescribeLoadBasedAutoScaling Operation</seealso>
        public virtual Task<DescribeLoadBasedAutoScalingResponse> DescribeLoadBasedAutoScalingAsync(DescribeLoadBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBasedAutoScalingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBasedAutoScalingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBasedAutoScalingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMyUserProfile

        internal virtual DescribeMyUserProfileResponse DescribeMyUserProfile()
        {
            return DescribeMyUserProfile(new DescribeMyUserProfileRequest());
        }
        internal virtual DescribeMyUserProfileResponse DescribeMyUserProfile(DescribeMyUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMyUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMyUserProfileResponseUnmarshaller.Instance;

            return Invoke<DescribeMyUserProfileResponse>(request, options);
        }


        /// <summary>
        /// Describes a user's SSH information.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have self-management
        /// enabled or an attached policy that explicitly grants permissions. For more information
        /// about user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMyUserProfile service method, as returned by OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeMyUserProfile">REST API Reference for DescribeMyUserProfile Operation</seealso>
        public virtual Task<DescribeMyUserProfileResponse> DescribeMyUserProfileAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeMyUserProfile">REST API Reference for DescribeMyUserProfile Operation</seealso>
        public virtual Task<DescribeMyUserProfileResponse> DescribeMyUserProfileAsync(DescribeMyUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMyUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMyUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMyUserProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOperatingSystems

        internal virtual DescribeOperatingSystemsResponse DescribeOperatingSystems(DescribeOperatingSystemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOperatingSystemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOperatingSystemsResponseUnmarshaller.Instance;

            return Invoke<DescribeOperatingSystemsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOperatingSystems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOperatingSystems operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeOperatingSystems">REST API Reference for DescribeOperatingSystems Operation</seealso>
        public virtual Task<DescribeOperatingSystemsResponse> DescribeOperatingSystemsAsync(DescribeOperatingSystemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOperatingSystemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOperatingSystemsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOperatingSystemsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePermissions

        internal virtual DescribePermissionsResponse DescribePermissions(DescribePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribePermissionsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribePermissions">REST API Reference for DescribePermissions Operation</seealso>
        public virtual Task<DescribePermissionsResponse> DescribePermissionsAsync(DescribePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRaidArrays

        internal virtual DescribeRaidArraysResponse DescribeRaidArrays(DescribeRaidArraysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRaidArraysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRaidArraysResponseUnmarshaller.Instance;

            return Invoke<DescribeRaidArraysResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeRaidArrays">REST API Reference for DescribeRaidArrays Operation</seealso>
        public virtual Task<DescribeRaidArraysResponse> DescribeRaidArraysAsync(DescribeRaidArraysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRaidArraysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRaidArraysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRaidArraysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRdsDbInstances

        internal virtual DescribeRdsDbInstancesResponse DescribeRdsDbInstances(DescribeRdsDbInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRdsDbInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRdsDbInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeRdsDbInstancesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeRdsDbInstances">REST API Reference for DescribeRdsDbInstances Operation</seealso>
        public virtual Task<DescribeRdsDbInstancesResponse> DescribeRdsDbInstancesAsync(DescribeRdsDbInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRdsDbInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRdsDbInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRdsDbInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeServiceErrors

        internal virtual DescribeServiceErrorsResponse DescribeServiceErrors()
        {
            return DescribeServiceErrors(new DescribeServiceErrorsRequest());
        }
        internal virtual DescribeServiceErrorsResponse DescribeServiceErrors(DescribeServiceErrorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceErrorsResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceErrorsResponse>(request, options);
        }


        /// <summary>
        /// Describes AWS OpsWorks Stacks service errors.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information about user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// This call accepts only one resource-identifying parameter.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeServiceErrors">REST API Reference for DescribeServiceErrors Operation</seealso>
        public virtual Task<DescribeServiceErrorsResponse> DescribeServiceErrorsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeServiceErrors">REST API Reference for DescribeServiceErrors Operation</seealso>
        public virtual Task<DescribeServiceErrorsResponse> DescribeServiceErrorsAsync(DescribeServiceErrorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceErrorsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServiceErrorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackProvisioningParameters

        internal virtual DescribeStackProvisioningParametersResponse DescribeStackProvisioningParameters(DescribeStackProvisioningParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackProvisioningParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackProvisioningParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeStackProvisioningParametersResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStackProvisioningParameters">REST API Reference for DescribeStackProvisioningParameters Operation</seealso>
        public virtual Task<DescribeStackProvisioningParametersResponse> DescribeStackProvisioningParametersAsync(DescribeStackProvisioningParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackProvisioningParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackProvisioningParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackProvisioningParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStacks

        internal virtual DescribeStacksResponse DescribeStacks()
        {
            return DescribeStacks(new DescribeStacksRequest());
        }
        internal virtual DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return Invoke<DescribeStacksResponse>(request, options);
        }


        /// <summary>
        /// Requests a description of one or more stacks.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information about user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual Task<DescribeStacksResponse> DescribeStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStacksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackSummary

        internal virtual DescribeStackSummaryResponse DescribeStackSummary(DescribeStackSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackSummaryResponseUnmarshaller.Instance;

            return Invoke<DescribeStackSummaryResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStackSummary">REST API Reference for DescribeStackSummary Operation</seealso>
        public virtual Task<DescribeStackSummaryResponse> DescribeStackSummaryAsync(DescribeStackSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackSummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTimeBasedAutoScaling

        internal virtual DescribeTimeBasedAutoScalingResponse DescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTimeBasedAutoScalingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTimeBasedAutoScalingResponseUnmarshaller.Instance;

            return Invoke<DescribeTimeBasedAutoScalingResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeTimeBasedAutoScaling">REST API Reference for DescribeTimeBasedAutoScaling Operation</seealso>
        public virtual Task<DescribeTimeBasedAutoScalingResponse> DescribeTimeBasedAutoScalingAsync(DescribeTimeBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTimeBasedAutoScalingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTimeBasedAutoScalingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTimeBasedAutoScalingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeUserProfiles

        internal virtual DescribeUserProfilesResponse DescribeUserProfiles()
        {
            return DescribeUserProfiles(new DescribeUserProfilesRequest());
        }
        internal virtual DescribeUserProfilesResponse DescribeUserProfiles(DescribeUserProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserProfilesResponseUnmarshaller.Instance;

            return Invoke<DescribeUserProfilesResponse>(request, options);
        }


        /// <summary>
        /// Describe specified users.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        /// policy that explicitly grants permissions. For more information about user permissions,
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeUserProfiles">REST API Reference for DescribeUserProfiles Operation</seealso>
        public virtual Task<DescribeUserProfilesResponse> DescribeUserProfilesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeUserProfiles">REST API Reference for DescribeUserProfiles Operation</seealso>
        public virtual Task<DescribeUserProfilesResponse> DescribeUserProfilesAsync(DescribeUserProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumes

        internal virtual DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        public virtual Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachElasticLoadBalancer

        internal virtual DetachElasticLoadBalancerResponse DetachElasticLoadBalancer(DetachElasticLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachElasticLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachElasticLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<DetachElasticLoadBalancerResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DetachElasticLoadBalancer">REST API Reference for DetachElasticLoadBalancer Operation</seealso>
        public virtual Task<DetachElasticLoadBalancerResponse> DetachElasticLoadBalancerAsync(DetachElasticLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachElasticLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachElasticLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<DetachElasticLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateElasticIp

        internal virtual DisassociateElasticIpResponse DisassociateElasticIp(DisassociateElasticIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateElasticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateElasticIpResponseUnmarshaller.Instance;

            return Invoke<DisassociateElasticIpResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DisassociateElasticIp">REST API Reference for DisassociateElasticIp Operation</seealso>
        public virtual Task<DisassociateElasticIpResponse> DisassociateElasticIpAsync(DisassociateElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateElasticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateElasticIpResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateElasticIpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHostnameSuggestion

        internal virtual GetHostnameSuggestionResponse GetHostnameSuggestion(GetHostnameSuggestionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHostnameSuggestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostnameSuggestionResponseUnmarshaller.Instance;

            return Invoke<GetHostnameSuggestionResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/GetHostnameSuggestion">REST API Reference for GetHostnameSuggestion Operation</seealso>
        public virtual Task<GetHostnameSuggestionResponse> GetHostnameSuggestionAsync(GetHostnameSuggestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHostnameSuggestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostnameSuggestionResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostnameSuggestionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GrantAccess

        internal virtual GrantAccessResponse GrantAccess(GrantAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GrantAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GrantAccessResponseUnmarshaller.Instance;

            return Invoke<GrantAccessResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/GrantAccess">REST API Reference for GrantAccess Operation</seealso>
        public virtual Task<GrantAccessResponse> GrantAccessAsync(GrantAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GrantAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GrantAccessResponseUnmarshaller.Instance;

            return InvokeAsync<GrantAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootInstance

        internal virtual RebootInstanceResponse RebootInstance(RebootInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootInstanceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        public virtual Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RebootInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterEcsCluster

        internal virtual RegisterEcsClusterResponse RegisterEcsCluster(RegisterEcsClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterEcsClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterEcsClusterResponseUnmarshaller.Instance;

            return Invoke<RegisterEcsClusterResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterEcsCluster">REST API Reference for RegisterEcsCluster Operation</seealso>
        public virtual Task<RegisterEcsClusterResponse> RegisterEcsClusterAsync(RegisterEcsClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterEcsClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterEcsClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterEcsClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterElasticIp

        internal virtual RegisterElasticIpResponse RegisterElasticIp(RegisterElasticIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterElasticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterElasticIpResponseUnmarshaller.Instance;

            return Invoke<RegisterElasticIpResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterElasticIp">REST API Reference for RegisterElasticIp Operation</seealso>
        public virtual Task<RegisterElasticIpResponse> RegisterElasticIpAsync(RegisterElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterElasticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterElasticIpResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterElasticIpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterInstance

        internal virtual RegisterInstanceResponse RegisterInstance(RegisterInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterInstanceResponseUnmarshaller.Instance;

            return Invoke<RegisterInstanceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterInstance">REST API Reference for RegisterInstance Operation</seealso>
        public virtual Task<RegisterInstanceResponse> RegisterInstanceAsync(RegisterInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterRdsDbInstance

        internal virtual RegisterRdsDbInstanceResponse RegisterRdsDbInstance(RegisterRdsDbInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterRdsDbInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterRdsDbInstanceResponseUnmarshaller.Instance;

            return Invoke<RegisterRdsDbInstanceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterRdsDbInstance">REST API Reference for RegisterRdsDbInstance Operation</seealso>
        public virtual Task<RegisterRdsDbInstanceResponse> RegisterRdsDbInstanceAsync(RegisterRdsDbInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterRdsDbInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterRdsDbInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterRdsDbInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterVolume

        internal virtual RegisterVolumeResponse RegisterVolume(RegisterVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterVolumeResponseUnmarshaller.Instance;

            return Invoke<RegisterVolumeResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterVolume">REST API Reference for RegisterVolume Operation</seealso>
        public virtual Task<RegisterVolumeResponse> RegisterVolumeAsync(RegisterVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetLoadBasedAutoScaling

        internal virtual SetLoadBasedAutoScalingResponse SetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLoadBasedAutoScalingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLoadBasedAutoScalingResponseUnmarshaller.Instance;

            return Invoke<SetLoadBasedAutoScalingResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetLoadBasedAutoScaling">REST API Reference for SetLoadBasedAutoScaling Operation</seealso>
        public virtual Task<SetLoadBasedAutoScalingResponse> SetLoadBasedAutoScalingAsync(SetLoadBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLoadBasedAutoScalingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLoadBasedAutoScalingResponseUnmarshaller.Instance;

            return InvokeAsync<SetLoadBasedAutoScalingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetPermission

        internal virtual SetPermissionResponse SetPermission(SetPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetPermissionResponseUnmarshaller.Instance;

            return Invoke<SetPermissionResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetPermission">REST API Reference for SetPermission Operation</seealso>
        public virtual Task<SetPermissionResponse> SetPermissionAsync(SetPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<SetPermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetTimeBasedAutoScaling

        internal virtual SetTimeBasedAutoScalingResponse SetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTimeBasedAutoScalingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTimeBasedAutoScalingResponseUnmarshaller.Instance;

            return Invoke<SetTimeBasedAutoScalingResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetTimeBasedAutoScaling">REST API Reference for SetTimeBasedAutoScaling Operation</seealso>
        public virtual Task<SetTimeBasedAutoScalingResponse> SetTimeBasedAutoScalingAsync(SetTimeBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTimeBasedAutoScalingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTimeBasedAutoScalingResponseUnmarshaller.Instance;

            return InvokeAsync<SetTimeBasedAutoScalingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartInstance

        internal virtual StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstanceResponseUnmarshaller.Instance;

            return Invoke<StartInstanceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StartInstance">REST API Reference for StartInstance Operation</seealso>
        public virtual Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StartInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartStack

        internal virtual StartStackResponse StartStack(StartStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStackResponseUnmarshaller.Instance;

            return Invoke<StartStackResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StartStack">REST API Reference for StartStack Operation</seealso>
        public virtual Task<StartStackResponse> StartStackAsync(StartStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStackResponseUnmarshaller.Instance;

            return InvokeAsync<StartStackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopInstance

        internal virtual StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInstanceResponseUnmarshaller.Instance;

            return Invoke<StopInstanceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StopInstance">REST API Reference for StopInstance Operation</seealso>
        public virtual Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StopInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopStack

        internal virtual StopStackResponse StopStack(StopStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStackResponseUnmarshaller.Instance;

            return Invoke<StopStackResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StopStack">REST API Reference for StopStack Operation</seealso>
        public virtual Task<StopStackResponse> StopStackAsync(StopStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStackResponseUnmarshaller.Instance;

            return InvokeAsync<StopStackResponse>(request, options, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnassignInstance

        internal virtual UnassignInstanceResponse UnassignInstance(UnassignInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnassignInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnassignInstanceResponseUnmarshaller.Instance;

            return Invoke<UnassignInstanceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UnassignInstance">REST API Reference for UnassignInstance Operation</seealso>
        public virtual Task<UnassignInstanceResponse> UnassignInstanceAsync(UnassignInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnassignInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnassignInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UnassignInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnassignVolume

        internal virtual UnassignVolumeResponse UnassignVolume(UnassignVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnassignVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnassignVolumeResponseUnmarshaller.Instance;

            return Invoke<UnassignVolumeResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UnassignVolume">REST API Reference for UnassignVolume Operation</seealso>
        public virtual Task<UnassignVolumeResponse> UnassignVolumeAsync(UnassignVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnassignVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnassignVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<UnassignVolumeResponse>(request, options, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApp

        internal virtual UpdateAppResponse UpdateApp(UpdateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return Invoke<UpdateAppResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        public virtual Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateElasticIp

        internal virtual UpdateElasticIpResponse UpdateElasticIp(UpdateElasticIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateElasticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateElasticIpResponseUnmarshaller.Instance;

            return Invoke<UpdateElasticIpResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateElasticIp">REST API Reference for UpdateElasticIp Operation</seealso>
        public virtual Task<UpdateElasticIpResponse> UpdateElasticIpAsync(UpdateElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateElasticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateElasticIpResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateElasticIpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateInstance

        internal virtual UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        public virtual Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLayer

        internal virtual UpdateLayerResponse UpdateLayer(UpdateLayerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLayerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLayerResponseUnmarshaller.Instance;

            return Invoke<UpdateLayerResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateLayer">REST API Reference for UpdateLayer Operation</seealso>
        public virtual Task<UpdateLayerResponse> UpdateLayerAsync(UpdateLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLayerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLayerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLayerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMyUserProfile

        internal virtual UpdateMyUserProfileResponse UpdateMyUserProfile()
        {
            return UpdateMyUserProfile(new UpdateMyUserProfileRequest());
        }
        internal virtual UpdateMyUserProfileResponse UpdateMyUserProfile(UpdateMyUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMyUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMyUserProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateMyUserProfileResponse>(request, options);
        }


        /// <summary>
        /// Updates a user's SSH public key.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have self-management
        /// enabled or an attached policy that explicitly grants permissions. For more information
        /// about user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateMyUserProfile">REST API Reference for UpdateMyUserProfile Operation</seealso>
        public virtual Task<UpdateMyUserProfileResponse> UpdateMyUserProfileAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateMyUserProfile">REST API Reference for UpdateMyUserProfile Operation</seealso>
        public virtual Task<UpdateMyUserProfileResponse> UpdateMyUserProfileAsync(UpdateMyUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMyUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMyUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMyUserProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRdsDbInstance

        internal virtual UpdateRdsDbInstanceResponse UpdateRdsDbInstance(UpdateRdsDbInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRdsDbInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRdsDbInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateRdsDbInstanceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateRdsDbInstance">REST API Reference for UpdateRdsDbInstance Operation</seealso>
        public virtual Task<UpdateRdsDbInstanceResponse> UpdateRdsDbInstanceAsync(UpdateRdsDbInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRdsDbInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRdsDbInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRdsDbInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStack

        internal virtual UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return Invoke<UpdateStackResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        public virtual Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUserProfile

        internal virtual UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateUserProfileResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        public virtual Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVolume

        internal virtual UpdateVolumeResponse UpdateVolume(UpdateVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVolumeResponseUnmarshaller.Instance;

            return Invoke<UpdateVolumeResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateVolume">REST API Reference for UpdateVolume Operation</seealso>
        public virtual Task<UpdateVolumeResponse> UpdateVolumeAsync(UpdateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}