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

        internal virtual AssignInstanceResponse AssignInstance(AssignInstanceRequest request)
        {
            var marshaller = AssignInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssignInstance">REST API Reference for AssignInstance Operation</seealso>
        public virtual Task<AssignInstanceResponse> AssignInstanceAsync(AssignInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssignInstanceRequestMarshaller.Instance;
            var unmarshaller = AssignInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<AssignInstanceRequest,AssignInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssignVolume

        internal virtual AssignVolumeResponse AssignVolume(AssignVolumeRequest request)
        {
            var marshaller = AssignVolumeRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssignVolume">REST API Reference for AssignVolume Operation</seealso>
        public virtual Task<AssignVolumeResponse> AssignVolumeAsync(AssignVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssignVolumeRequestMarshaller.Instance;
            var unmarshaller = AssignVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<AssignVolumeRequest,AssignVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateElasticIp

        internal virtual AssociateElasticIpResponse AssociateElasticIp(AssociateElasticIpRequest request)
        {
            var marshaller = AssociateElasticIpRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssociateElasticIp">REST API Reference for AssociateElasticIp Operation</seealso>
        public virtual Task<AssociateElasticIpResponse> AssociateElasticIpAsync(AssociateElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateElasticIpRequestMarshaller.Instance;
            var unmarshaller = AssociateElasticIpResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateElasticIpRequest,AssociateElasticIpResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachElasticLoadBalancer

        internal virtual AttachElasticLoadBalancerResponse AttachElasticLoadBalancer(AttachElasticLoadBalancerRequest request)
        {
            var marshaller = AttachElasticLoadBalancerRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AttachElasticLoadBalancer">REST API Reference for AttachElasticLoadBalancer Operation</seealso>
        public virtual Task<AttachElasticLoadBalancerResponse> AttachElasticLoadBalancerAsync(AttachElasticLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AttachElasticLoadBalancerRequestMarshaller.Instance;
            var unmarshaller = AttachElasticLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<AttachElasticLoadBalancerRequest,AttachElasticLoadBalancerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CloneStack

        internal virtual CloneStackResponse CloneStack(CloneStackRequest request)
        {
            var marshaller = CloneStackRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CloneStack">REST API Reference for CloneStack Operation</seealso>
        public virtual Task<CloneStackResponse> CloneStackAsync(CloneStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CloneStackRequestMarshaller.Instance;
            var unmarshaller = CloneStackResponseUnmarshaller.Instance;

            return InvokeAsync<CloneStackRequest,CloneStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateApp

        internal virtual CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var marshaller = CreateAppRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateAppRequestMarshaller.Instance;
            var unmarshaller = CreateAppResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAppRequest,CreateAppResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeployment

        internal virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDeploymentRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentRequest,CreateDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateInstance

        internal virtual CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            var marshaller = CreateInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        public virtual Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateInstanceRequestMarshaller.Instance;
            var unmarshaller = CreateInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstanceRequest,CreateInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLayer

        internal virtual CreateLayerResponse CreateLayer(CreateLayerRequest request)
        {
            var marshaller = CreateLayerRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateLayer">REST API Reference for CreateLayer Operation</seealso>
        public virtual Task<CreateLayerResponse> CreateLayerAsync(CreateLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateLayerRequestMarshaller.Instance;
            var unmarshaller = CreateLayerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLayerRequest,CreateLayerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStack

        internal virtual CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var marshaller = CreateStackRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateStack">REST API Reference for CreateStack Operation</seealso>
        public virtual Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateStackRequestMarshaller.Instance;
            var unmarshaller = CreateStackResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackRequest,CreateStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateUserProfile

        internal virtual CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request)
        {
            var marshaller = CreateUserProfileRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        public virtual Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateUserProfileRequestMarshaller.Instance;
            var unmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserProfileRequest,CreateUserProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApp

        internal virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var marshaller = DeleteAppRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAppRequestMarshaller.Instance;
            var unmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppRequest,DeleteAppResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteInstance

        internal virtual DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            var marshaller = DeleteInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        public virtual Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteInstanceRequestMarshaller.Instance;
            var unmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInstanceRequest,DeleteInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLayer

        internal virtual DeleteLayerResponse DeleteLayer(DeleteLayerRequest request)
        {
            var marshaller = DeleteLayerRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteLayer">REST API Reference for DeleteLayer Operation</seealso>
        public virtual Task<DeleteLayerResponse> DeleteLayerAsync(DeleteLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteLayerRequestMarshaller.Instance;
            var unmarshaller = DeleteLayerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLayerRequest,DeleteLayerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteStack

        internal virtual DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var marshaller = DeleteStackRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        public virtual Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteStackRequestMarshaller.Instance;
            var unmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackRequest,DeleteStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserProfile

        internal virtual DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest request)
        {
            var marshaller = DeleteUserProfileRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        public virtual Task<DeleteUserProfileResponse> DeleteUserProfileAsync(DeleteUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteUserProfileRequestMarshaller.Instance;
            var unmarshaller = DeleteUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserProfileRequest,DeleteUserProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterEcsCluster

        internal virtual DeregisterEcsClusterResponse DeregisterEcsCluster(DeregisterEcsClusterRequest request)
        {
            var marshaller = DeregisterEcsClusterRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterEcsCluster">REST API Reference for DeregisterEcsCluster Operation</seealso>
        public virtual Task<DeregisterEcsClusterResponse> DeregisterEcsClusterAsync(DeregisterEcsClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeregisterEcsClusterRequestMarshaller.Instance;
            var unmarshaller = DeregisterEcsClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterEcsClusterRequest,DeregisterEcsClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterElasticIp

        internal virtual DeregisterElasticIpResponse DeregisterElasticIp(DeregisterElasticIpRequest request)
        {
            var marshaller = DeregisterElasticIpRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterElasticIp">REST API Reference for DeregisterElasticIp Operation</seealso>
        public virtual Task<DeregisterElasticIpResponse> DeregisterElasticIpAsync(DeregisterElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeregisterElasticIpRequestMarshaller.Instance;
            var unmarshaller = DeregisterElasticIpResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterElasticIpRequest,DeregisterElasticIpResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterInstance

        internal virtual DeregisterInstanceResponse DeregisterInstance(DeregisterInstanceRequest request)
        {
            var marshaller = DeregisterInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterInstance">REST API Reference for DeregisterInstance Operation</seealso>
        public virtual Task<DeregisterInstanceResponse> DeregisterInstanceAsync(DeregisterInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeregisterInstanceRequestMarshaller.Instance;
            var unmarshaller = DeregisterInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterInstanceRequest,DeregisterInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterRdsDbInstance

        internal virtual DeregisterRdsDbInstanceResponse DeregisterRdsDbInstance(DeregisterRdsDbInstanceRequest request)
        {
            var marshaller = DeregisterRdsDbInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterRdsDbInstance">REST API Reference for DeregisterRdsDbInstance Operation</seealso>
        public virtual Task<DeregisterRdsDbInstanceResponse> DeregisterRdsDbInstanceAsync(DeregisterRdsDbInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeregisterRdsDbInstanceRequestMarshaller.Instance;
            var unmarshaller = DeregisterRdsDbInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterRdsDbInstanceRequest,DeregisterRdsDbInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterVolume

        internal virtual DeregisterVolumeResponse DeregisterVolume(DeregisterVolumeRequest request)
        {
            var marshaller = DeregisterVolumeRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterVolume">REST API Reference for DeregisterVolume Operation</seealso>
        public virtual Task<DeregisterVolumeResponse> DeregisterVolumeAsync(DeregisterVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeregisterVolumeRequestMarshaller.Instance;
            var unmarshaller = DeregisterVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterVolumeRequest,DeregisterVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAgentVersions

        internal virtual DescribeAgentVersionsResponse DescribeAgentVersions(DescribeAgentVersionsRequest request)
        {
            var marshaller = DescribeAgentVersionsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeAgentVersions">REST API Reference for DescribeAgentVersions Operation</seealso>
        public virtual Task<DescribeAgentVersionsResponse> DescribeAgentVersionsAsync(DescribeAgentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAgentVersionsRequestMarshaller.Instance;
            var unmarshaller = DescribeAgentVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAgentVersionsRequest,DescribeAgentVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeApps

        internal virtual DescribeAppsResponse DescribeApps(DescribeAppsRequest request)
        {
            var marshaller = DescribeAppsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeApps">REST API Reference for DescribeApps Operation</seealso>
        public virtual Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAppsRequestMarshaller.Instance;
            var unmarshaller = DescribeAppsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAppsRequest,DescribeAppsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCommands

        internal virtual DescribeCommandsResponse DescribeCommands(DescribeCommandsRequest request)
        {
            var marshaller = DescribeCommandsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeCommands">REST API Reference for DescribeCommands Operation</seealso>
        public virtual Task<DescribeCommandsResponse> DescribeCommandsAsync(DescribeCommandsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeCommandsRequestMarshaller.Instance;
            var unmarshaller = DescribeCommandsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCommandsRequest,DescribeCommandsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDeployments

        internal virtual DescribeDeploymentsResponse DescribeDeployments(DescribeDeploymentsRequest request)
        {
            var marshaller = DescribeDeploymentsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeDeployments">REST API Reference for DescribeDeployments Operation</seealso>
        public virtual Task<DescribeDeploymentsResponse> DescribeDeploymentsAsync(DescribeDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDeploymentsRequestMarshaller.Instance;
            var unmarshaller = DescribeDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDeploymentsRequest,DescribeDeploymentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEcsClusters

        internal virtual DescribeEcsClustersResponse DescribeEcsClusters(DescribeEcsClustersRequest request)
        {
            var marshaller = DescribeEcsClustersRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeEcsClusters">REST API Reference for DescribeEcsClusters Operation</seealso>
        public virtual Task<DescribeEcsClustersResponse> DescribeEcsClustersAsync(DescribeEcsClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEcsClustersRequestMarshaller.Instance;
            var unmarshaller = DescribeEcsClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEcsClustersRequest,DescribeEcsClustersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticIps

        internal virtual DescribeElasticIpsResponse DescribeElasticIps(DescribeElasticIpsRequest request)
        {
            var marshaller = DescribeElasticIpsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeElasticIps">REST API Reference for DescribeElasticIps Operation</seealso>
        public virtual Task<DescribeElasticIpsResponse> DescribeElasticIpsAsync(DescribeElasticIpsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeElasticIpsRequestMarshaller.Instance;
            var unmarshaller = DescribeElasticIpsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticIpsRequest,DescribeElasticIpsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticLoadBalancers

        internal virtual DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers()
        {
            return DescribeElasticLoadBalancers(new DescribeElasticLoadBalancersRequest());
        }
        internal virtual DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers(DescribeElasticLoadBalancersRequest request)
        {
            var marshaller = DescribeElasticLoadBalancersRequestMarshaller.Instance;
            var unmarshaller = DescribeElasticLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticLoadBalancersRequest,DescribeElasticLoadBalancersResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeElasticLoadBalancersRequestMarshaller.Instance;
            var unmarshaller = DescribeElasticLoadBalancersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticLoadBalancersRequest,DescribeElasticLoadBalancersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstances

        internal virtual DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var marshaller = DescribeInstancesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        public virtual Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancesRequest,DescribeInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLayers

        internal virtual DescribeLayersResponse DescribeLayers(DescribeLayersRequest request)
        {
            var marshaller = DescribeLayersRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeLayers">REST API Reference for DescribeLayers Operation</seealso>
        public virtual Task<DescribeLayersResponse> DescribeLayersAsync(DescribeLayersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeLayersRequestMarshaller.Instance;
            var unmarshaller = DescribeLayersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLayersRequest,DescribeLayersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBasedAutoScaling

        internal virtual DescribeLoadBasedAutoScalingResponse DescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest request)
        {
            var marshaller = DescribeLoadBasedAutoScalingRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeLoadBasedAutoScaling">REST API Reference for DescribeLoadBasedAutoScaling Operation</seealso>
        public virtual Task<DescribeLoadBasedAutoScalingResponse> DescribeLoadBasedAutoScalingAsync(DescribeLoadBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeLoadBasedAutoScalingRequestMarshaller.Instance;
            var unmarshaller = DescribeLoadBasedAutoScalingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBasedAutoScalingRequest,DescribeLoadBasedAutoScalingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMyUserProfile

        internal virtual DescribeMyUserProfileResponse DescribeMyUserProfile()
        {
            return DescribeMyUserProfile(new DescribeMyUserProfileRequest());
        }
        internal virtual DescribeMyUserProfileResponse DescribeMyUserProfile(DescribeMyUserProfileRequest request)
        {
            var marshaller = DescribeMyUserProfileRequestMarshaller.Instance;
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
            var marshaller = DescribeMyUserProfileRequestMarshaller.Instance;
            var unmarshaller = DescribeMyUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMyUserProfileRequest,DescribeMyUserProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeOperatingSystems

        internal virtual DescribeOperatingSystemsResponse DescribeOperatingSystems(DescribeOperatingSystemsRequest request)
        {
            var marshaller = DescribeOperatingSystemsRequestMarshaller.Instance;
            var unmarshaller = DescribeOperatingSystemsResponseUnmarshaller.Instance;

            return Invoke<DescribeOperatingSystemsRequest,DescribeOperatingSystemsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeOperatingSystemsRequestMarshaller.Instance;
            var unmarshaller = DescribeOperatingSystemsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOperatingSystemsRequest,DescribeOperatingSystemsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePermissions

        internal virtual DescribePermissionsResponse DescribePermissions(DescribePermissionsRequest request)
        {
            var marshaller = DescribePermissionsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribePermissions">REST API Reference for DescribePermissions Operation</seealso>
        public virtual Task<DescribePermissionsResponse> DescribePermissionsAsync(DescribePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribePermissionsRequestMarshaller.Instance;
            var unmarshaller = DescribePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePermissionsRequest,DescribePermissionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRaidArrays

        internal virtual DescribeRaidArraysResponse DescribeRaidArrays(DescribeRaidArraysRequest request)
        {
            var marshaller = DescribeRaidArraysRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeRaidArrays">REST API Reference for DescribeRaidArrays Operation</seealso>
        public virtual Task<DescribeRaidArraysResponse> DescribeRaidArraysAsync(DescribeRaidArraysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeRaidArraysRequestMarshaller.Instance;
            var unmarshaller = DescribeRaidArraysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRaidArraysRequest,DescribeRaidArraysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRdsDbInstances

        internal virtual DescribeRdsDbInstancesResponse DescribeRdsDbInstances(DescribeRdsDbInstancesRequest request)
        {
            var marshaller = DescribeRdsDbInstancesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeRdsDbInstances">REST API Reference for DescribeRdsDbInstances Operation</seealso>
        public virtual Task<DescribeRdsDbInstancesResponse> DescribeRdsDbInstancesAsync(DescribeRdsDbInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeRdsDbInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeRdsDbInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRdsDbInstancesRequest,DescribeRdsDbInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeServiceErrors

        internal virtual DescribeServiceErrorsResponse DescribeServiceErrors()
        {
            return DescribeServiceErrors(new DescribeServiceErrorsRequest());
        }
        internal virtual DescribeServiceErrorsResponse DescribeServiceErrors(DescribeServiceErrorsRequest request)
        {
            var marshaller = DescribeServiceErrorsRequestMarshaller.Instance;
            var unmarshaller = DescribeServiceErrorsResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceErrorsRequest,DescribeServiceErrorsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes AWS OpsWorks Stacks service errors.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
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
            var marshaller = DescribeServiceErrorsRequestMarshaller.Instance;
            var unmarshaller = DescribeServiceErrorsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServiceErrorsRequest,DescribeServiceErrorsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackProvisioningParameters

        internal virtual DescribeStackProvisioningParametersResponse DescribeStackProvisioningParameters(DescribeStackProvisioningParametersRequest request)
        {
            var marshaller = DescribeStackProvisioningParametersRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStackProvisioningParameters">REST API Reference for DescribeStackProvisioningParameters Operation</seealso>
        public virtual Task<DescribeStackProvisioningParametersResponse> DescribeStackProvisioningParametersAsync(DescribeStackProvisioningParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeStackProvisioningParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeStackProvisioningParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackProvisioningParametersRequest,DescribeStackProvisioningParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStacks

        internal virtual DescribeStacksResponse DescribeStacks()
        {
            return DescribeStacks(new DescribeStacksRequest());
        }
        internal virtual DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            var marshaller = DescribeStacksRequestMarshaller.Instance;
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
            var marshaller = DescribeStacksRequestMarshaller.Instance;
            var unmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStacksRequest,DescribeStacksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackSummary

        internal virtual DescribeStackSummaryResponse DescribeStackSummary(DescribeStackSummaryRequest request)
        {
            var marshaller = DescribeStackSummaryRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStackSummary">REST API Reference for DescribeStackSummary Operation</seealso>
        public virtual Task<DescribeStackSummaryResponse> DescribeStackSummaryAsync(DescribeStackSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeStackSummaryRequestMarshaller.Instance;
            var unmarshaller = DescribeStackSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackSummaryRequest,DescribeStackSummaryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTimeBasedAutoScaling

        internal virtual DescribeTimeBasedAutoScalingResponse DescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest request)
        {
            var marshaller = DescribeTimeBasedAutoScalingRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeTimeBasedAutoScaling">REST API Reference for DescribeTimeBasedAutoScaling Operation</seealso>
        public virtual Task<DescribeTimeBasedAutoScalingResponse> DescribeTimeBasedAutoScalingAsync(DescribeTimeBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeTimeBasedAutoScalingRequestMarshaller.Instance;
            var unmarshaller = DescribeTimeBasedAutoScalingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTimeBasedAutoScalingRequest,DescribeTimeBasedAutoScalingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeUserProfiles

        internal virtual DescribeUserProfilesResponse DescribeUserProfiles()
        {
            return DescribeUserProfiles(new DescribeUserProfilesRequest());
        }
        internal virtual DescribeUserProfilesResponse DescribeUserProfiles(DescribeUserProfilesRequest request)
        {
            var marshaller = DescribeUserProfilesRequestMarshaller.Instance;
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
            var marshaller = DescribeUserProfilesRequestMarshaller.Instance;
            var unmarshaller = DescribeUserProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserProfilesRequest,DescribeUserProfilesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumes

        internal virtual DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            var marshaller = DescribeVolumesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        public virtual Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVolumesRequestMarshaller.Instance;
            var unmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumesRequest,DescribeVolumesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachElasticLoadBalancer

        internal virtual DetachElasticLoadBalancerResponse DetachElasticLoadBalancer(DetachElasticLoadBalancerRequest request)
        {
            var marshaller = DetachElasticLoadBalancerRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DetachElasticLoadBalancer">REST API Reference for DetachElasticLoadBalancer Operation</seealso>
        public virtual Task<DetachElasticLoadBalancerResponse> DetachElasticLoadBalancerAsync(DetachElasticLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetachElasticLoadBalancerRequestMarshaller.Instance;
            var unmarshaller = DetachElasticLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<DetachElasticLoadBalancerRequest,DetachElasticLoadBalancerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateElasticIp

        internal virtual DisassociateElasticIpResponse DisassociateElasticIp(DisassociateElasticIpRequest request)
        {
            var marshaller = DisassociateElasticIpRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DisassociateElasticIp">REST API Reference for DisassociateElasticIp Operation</seealso>
        public virtual Task<DisassociateElasticIpResponse> DisassociateElasticIpAsync(DisassociateElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateElasticIpRequestMarshaller.Instance;
            var unmarshaller = DisassociateElasticIpResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateElasticIpRequest,DisassociateElasticIpResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHostnameSuggestion

        internal virtual GetHostnameSuggestionResponse GetHostnameSuggestion(GetHostnameSuggestionRequest request)
        {
            var marshaller = GetHostnameSuggestionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/GetHostnameSuggestion">REST API Reference for GetHostnameSuggestion Operation</seealso>
        public virtual Task<GetHostnameSuggestionResponse> GetHostnameSuggestionAsync(GetHostnameSuggestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetHostnameSuggestionRequestMarshaller.Instance;
            var unmarshaller = GetHostnameSuggestionResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostnameSuggestionRequest,GetHostnameSuggestionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GrantAccess

        internal virtual GrantAccessResponse GrantAccess(GrantAccessRequest request)
        {
            var marshaller = GrantAccessRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/GrantAccess">REST API Reference for GrantAccess Operation</seealso>
        public virtual Task<GrantAccessResponse> GrantAccessAsync(GrantAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GrantAccessRequestMarshaller.Instance;
            var unmarshaller = GrantAccessResponseUnmarshaller.Instance;

            return InvokeAsync<GrantAccessRequest,GrantAccessResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var marshaller = ListTagsRequestMarshaller.Instance;
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsRequest,ListTagsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListTagsRequestMarshaller.Instance;
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsRequest,ListTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RebootInstance

        internal virtual RebootInstanceResponse RebootInstance(RebootInstanceRequest request)
        {
            var marshaller = RebootInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        public virtual Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RebootInstanceRequestMarshaller.Instance;
            var unmarshaller = RebootInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RebootInstanceRequest,RebootInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterEcsCluster

        internal virtual RegisterEcsClusterResponse RegisterEcsCluster(RegisterEcsClusterRequest request)
        {
            var marshaller = RegisterEcsClusterRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterEcsCluster">REST API Reference for RegisterEcsCluster Operation</seealso>
        public virtual Task<RegisterEcsClusterResponse> RegisterEcsClusterAsync(RegisterEcsClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterEcsClusterRequestMarshaller.Instance;
            var unmarshaller = RegisterEcsClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterEcsClusterRequest,RegisterEcsClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterElasticIp

        internal virtual RegisterElasticIpResponse RegisterElasticIp(RegisterElasticIpRequest request)
        {
            var marshaller = RegisterElasticIpRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterElasticIp">REST API Reference for RegisterElasticIp Operation</seealso>
        public virtual Task<RegisterElasticIpResponse> RegisterElasticIpAsync(RegisterElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterElasticIpRequestMarshaller.Instance;
            var unmarshaller = RegisterElasticIpResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterElasticIpRequest,RegisterElasticIpResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterInstance

        internal virtual RegisterInstanceResponse RegisterInstance(RegisterInstanceRequest request)
        {
            var marshaller = RegisterInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterInstance">REST API Reference for RegisterInstance Operation</seealso>
        public virtual Task<RegisterInstanceResponse> RegisterInstanceAsync(RegisterInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterInstanceRequestMarshaller.Instance;
            var unmarshaller = RegisterInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterInstanceRequest,RegisterInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterRdsDbInstance

        internal virtual RegisterRdsDbInstanceResponse RegisterRdsDbInstance(RegisterRdsDbInstanceRequest request)
        {
            var marshaller = RegisterRdsDbInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterRdsDbInstance">REST API Reference for RegisterRdsDbInstance Operation</seealso>
        public virtual Task<RegisterRdsDbInstanceResponse> RegisterRdsDbInstanceAsync(RegisterRdsDbInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterRdsDbInstanceRequestMarshaller.Instance;
            var unmarshaller = RegisterRdsDbInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterRdsDbInstanceRequest,RegisterRdsDbInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterVolume

        internal virtual RegisterVolumeResponse RegisterVolume(RegisterVolumeRequest request)
        {
            var marshaller = RegisterVolumeRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterVolume">REST API Reference for RegisterVolume Operation</seealso>
        public virtual Task<RegisterVolumeResponse> RegisterVolumeAsync(RegisterVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterVolumeRequestMarshaller.Instance;
            var unmarshaller = RegisterVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterVolumeRequest,RegisterVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetLoadBasedAutoScaling

        internal virtual SetLoadBasedAutoScalingResponse SetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest request)
        {
            var marshaller = SetLoadBasedAutoScalingRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetLoadBasedAutoScaling">REST API Reference for SetLoadBasedAutoScaling Operation</seealso>
        public virtual Task<SetLoadBasedAutoScalingResponse> SetLoadBasedAutoScalingAsync(SetLoadBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetLoadBasedAutoScalingRequestMarshaller.Instance;
            var unmarshaller = SetLoadBasedAutoScalingResponseUnmarshaller.Instance;

            return InvokeAsync<SetLoadBasedAutoScalingRequest,SetLoadBasedAutoScalingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetPermission

        internal virtual SetPermissionResponse SetPermission(SetPermissionRequest request)
        {
            var marshaller = SetPermissionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetPermission">REST API Reference for SetPermission Operation</seealso>
        public virtual Task<SetPermissionResponse> SetPermissionAsync(SetPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetPermissionRequestMarshaller.Instance;
            var unmarshaller = SetPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<SetPermissionRequest,SetPermissionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetTimeBasedAutoScaling

        internal virtual SetTimeBasedAutoScalingResponse SetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest request)
        {
            var marshaller = SetTimeBasedAutoScalingRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetTimeBasedAutoScaling">REST API Reference for SetTimeBasedAutoScaling Operation</seealso>
        public virtual Task<SetTimeBasedAutoScalingResponse> SetTimeBasedAutoScalingAsync(SetTimeBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetTimeBasedAutoScalingRequestMarshaller.Instance;
            var unmarshaller = SetTimeBasedAutoScalingResponseUnmarshaller.Instance;

            return InvokeAsync<SetTimeBasedAutoScalingRequest,SetTimeBasedAutoScalingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartInstance

        internal virtual StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            var marshaller = StartInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StartInstance">REST API Reference for StartInstance Operation</seealso>
        public virtual Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartInstanceRequestMarshaller.Instance;
            var unmarshaller = StartInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StartInstanceRequest,StartInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartStack

        internal virtual StartStackResponse StartStack(StartStackRequest request)
        {
            var marshaller = StartStackRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StartStack">REST API Reference for StartStack Operation</seealso>
        public virtual Task<StartStackResponse> StartStackAsync(StartStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartStackRequestMarshaller.Instance;
            var unmarshaller = StartStackResponseUnmarshaller.Instance;

            return InvokeAsync<StartStackRequest,StartStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopInstance

        internal virtual StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            var marshaller = StopInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StopInstance">REST API Reference for StopInstance Operation</seealso>
        public virtual Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopInstanceRequestMarshaller.Instance;
            var unmarshaller = StopInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StopInstanceRequest,StopInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopStack

        internal virtual StopStackResponse StopStack(StopStackRequest request)
        {
            var marshaller = StopStackRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StopStack">REST API Reference for StopStack Operation</seealso>
        public virtual Task<StopStackResponse> StopStackAsync(StopStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopStackRequestMarshaller.Instance;
            var unmarshaller = StopStackResponseUnmarshaller.Instance;

            return InvokeAsync<StopStackRequest,StopStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceRequest,TagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnassignInstance

        internal virtual UnassignInstanceResponse UnassignInstance(UnassignInstanceRequest request)
        {
            var marshaller = UnassignInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UnassignInstance">REST API Reference for UnassignInstance Operation</seealso>
        public virtual Task<UnassignInstanceResponse> UnassignInstanceAsync(UnassignInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UnassignInstanceRequestMarshaller.Instance;
            var unmarshaller = UnassignInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UnassignInstanceRequest,UnassignInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnassignVolume

        internal virtual UnassignVolumeResponse UnassignVolume(UnassignVolumeRequest request)
        {
            var marshaller = UnassignVolumeRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UnassignVolume">REST API Reference for UnassignVolume Operation</seealso>
        public virtual Task<UnassignVolumeResponse> UnassignVolumeAsync(UnassignVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UnassignVolumeRequestMarshaller.Instance;
            var unmarshaller = UnassignVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<UnassignVolumeRequest,UnassignVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceRequest,UntagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApp

        internal virtual UpdateAppResponse UpdateApp(UpdateAppRequest request)
        {
            var marshaller = UpdateAppRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        public virtual Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateAppRequestMarshaller.Instance;
            var unmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAppRequest,UpdateAppResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateElasticIp

        internal virtual UpdateElasticIpResponse UpdateElasticIp(UpdateElasticIpRequest request)
        {
            var marshaller = UpdateElasticIpRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateElasticIp">REST API Reference for UpdateElasticIp Operation</seealso>
        public virtual Task<UpdateElasticIpResponse> UpdateElasticIpAsync(UpdateElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateElasticIpRequestMarshaller.Instance;
            var unmarshaller = UpdateElasticIpResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateElasticIpRequest,UpdateElasticIpResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateInstance

        internal virtual UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            var marshaller = UpdateInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        public virtual Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateInstanceRequestMarshaller.Instance;
            var unmarshaller = UpdateInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateInstanceRequest,UpdateInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateLayer

        internal virtual UpdateLayerResponse UpdateLayer(UpdateLayerRequest request)
        {
            var marshaller = UpdateLayerRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateLayer">REST API Reference for UpdateLayer Operation</seealso>
        public virtual Task<UpdateLayerResponse> UpdateLayerAsync(UpdateLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateLayerRequestMarshaller.Instance;
            var unmarshaller = UpdateLayerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLayerRequest,UpdateLayerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateMyUserProfile

        internal virtual UpdateMyUserProfileResponse UpdateMyUserProfile()
        {
            return UpdateMyUserProfile(new UpdateMyUserProfileRequest());
        }
        internal virtual UpdateMyUserProfileResponse UpdateMyUserProfile(UpdateMyUserProfileRequest request)
        {
            var marshaller = UpdateMyUserProfileRequestMarshaller.Instance;
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
            var marshaller = UpdateMyUserProfileRequestMarshaller.Instance;
            var unmarshaller = UpdateMyUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMyUserProfileRequest,UpdateMyUserProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRdsDbInstance

        internal virtual UpdateRdsDbInstanceResponse UpdateRdsDbInstance(UpdateRdsDbInstanceRequest request)
        {
            var marshaller = UpdateRdsDbInstanceRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateRdsDbInstance">REST API Reference for UpdateRdsDbInstance Operation</seealso>
        public virtual Task<UpdateRdsDbInstanceResponse> UpdateRdsDbInstanceAsync(UpdateRdsDbInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateRdsDbInstanceRequestMarshaller.Instance;
            var unmarshaller = UpdateRdsDbInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRdsDbInstanceRequest,UpdateRdsDbInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateStack

        internal virtual UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var marshaller = UpdateStackRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        public virtual Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateStackRequestMarshaller.Instance;
            var unmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStackRequest,UpdateStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateUserProfile

        internal virtual UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request)
        {
            var marshaller = UpdateUserProfileRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        public virtual Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateUserProfileRequestMarshaller.Instance;
            var unmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserProfileRequest,UpdateUserProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateVolume

        internal virtual UpdateVolumeResponse UpdateVolume(UpdateVolumeRequest request)
        {
            var marshaller = UpdateVolumeRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateVolume">REST API Reference for UpdateVolume Operation</seealso>
        public virtual Task<UpdateVolumeResponse> UpdateVolumeAsync(UpdateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateVolumeRequestMarshaller.Instance;
            var unmarshaller = UpdateVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVolumeRequest,UpdateVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}