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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.OpsWorks.Model;

namespace Amazon.OpsWorks
{
    /// <summary>
    /// Interface for accessing OpsWorks
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
    public partial interface IAmazonOpsWorks : IAmazonService, IDisposable
    {

        
        #region  AssignInstance


        /// <summary>
        /// Assign a registered instance to a layer.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You can assign registered on-premises instances to any layer type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can assign registered Amazon EC2 instances only to custom layers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use this action with instances that were created with AWS OpsWorks Stacks.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an AWS Identity and Access Management
        /// (IAM) user must have a Manage permissions level for the stack or an attached policy
        /// that explicitly grants permissions. For more information on user permissions, see
        /// <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignInstance service method.</param>
        /// 
        /// <returns>The response from the AssignInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssignInstance">REST API Reference for AssignInstance Operation</seealso>
        AssignInstanceResponse AssignInstance(AssignInstanceRequest request);


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
        Task<AssignInstanceResponse> AssignInstanceAsync(AssignInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssignVolume


        /// <summary>
        /// Assigns one of the stack's registered Amazon EBS volumes to a specified instance.
        /// The volume must first be registered with the stack by calling <a>RegisterVolume</a>.
        /// After you register the volume, you must call <a>UpdateVolume</a> to specify a mount
        /// point before calling <code>AssignVolume</code>. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignVolume service method.</param>
        /// 
        /// <returns>The response from the AssignVolume service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssignVolume">REST API Reference for AssignVolume Operation</seealso>
        AssignVolumeResponse AssignVolume(AssignVolumeRequest request);


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
        Task<AssignVolumeResponse> AssignVolumeAsync(AssignVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateElasticIp


        /// <summary>
        /// Associates one of the stack's registered Elastic IP addresses with a specified instance.
        /// The address must first be registered with the stack by calling <a>RegisterElasticIp</a>.
        /// For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateElasticIp service method.</param>
        /// 
        /// <returns>The response from the AssociateElasticIp service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssociateElasticIp">REST API Reference for AssociateElasticIp Operation</seealso>
        AssociateElasticIpResponse AssociateElasticIp(AssociateElasticIpRequest request);


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
        Task<AssociateElasticIpResponse> AssociateElasticIpAsync(AssociateElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachElasticLoadBalancer


        /// <summary>
        /// Attaches an Elastic Load Balancing load balancer to a specified layer. AWS OpsWorks
        /// Stacks does not support Application Load Balancer. You can only use Classic Load Balancer
        /// with AWS OpsWorks Stacks. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/layers-elb.html">Elastic
        /// Load Balancing</a>.
        /// 
        ///  <note> 
        /// <para>
        /// You must create the Elastic Load Balancing instance separately, by using the Elastic
        /// Load Balancing console, API, or CLI. For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/Welcome.html">
        /// Elastic Load Balancing Developer Guide</a>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachElasticLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the AttachElasticLoadBalancer service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AttachElasticLoadBalancer">REST API Reference for AttachElasticLoadBalancer Operation</seealso>
        AttachElasticLoadBalancerResponse AttachElasticLoadBalancer(AttachElasticLoadBalancerRequest request);


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
        Task<AttachElasticLoadBalancerResponse> AttachElasticLoadBalancerAsync(AttachElasticLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CloneStack


        /// <summary>
        /// Creates a clone of a specified stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-cloning.html">Clone
        /// a Stack</a>. By default, all parameters are set to the values used by the parent stack.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        /// policy that explicitly grants permissions. For more information on user permissions,
        /// see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloneStack service method.</param>
        /// 
        /// <returns>The response from the CloneStack service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CloneStack">REST API Reference for CloneStack Operation</seealso>
        CloneStackResponse CloneStack(CloneStackRequest request);


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
        Task<CloneStackResponse> CloneStackAsync(CloneStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateApp


        /// <summary>
        /// Creates an app for a specified stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-creating.html">Creating
        /// Apps</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateApp">REST API Reference for CreateApp Operation</seealso>
        CreateAppResponse CreateApp(CreateAppRequest request);


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
        Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDeployment


        /// <summary>
        /// Runs deployment or stack commands. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-deploying.html">Deploying
        /// Apps</a> and <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-commands.html">Run
        /// Stack Commands</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Deploy or
        /// Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request);


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
        Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateInstance


        /// <summary>
        /// Creates an instance in a specified stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-add.html">Adding
        /// an Instance to a Layer</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance service method.</param>
        /// 
        /// <returns>The response from the CreateInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        CreateInstanceResponse CreateInstance(CreateInstanceRequest request);


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
        Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLayer


        /// <summary>
        /// Creates a layer. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-create.html">How
        /// to Create a Layer</a>.
        /// 
        ///  <note> 
        /// <para>
        /// You should use <b>CreateLayer</b> for noncustom layer types such as PHP App Server
        /// only if the stack does not have an existing layer of that type. A stack can have at
        /// most one instance of each noncustom layer; if you attempt to create a second instance,
        /// <b>CreateLayer</b> fails. A stack can have an arbitrary number of custom layers, so
        /// you can call <b>CreateLayer</b> as many times as you like for that layer type.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLayer service method.</param>
        /// 
        /// <returns>The response from the CreateLayer service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateLayer">REST API Reference for CreateLayer Operation</seealso>
        CreateLayerResponse CreateLayer(CreateLayerRequest request);


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
        Task<CreateLayerResponse> CreateLayerAsync(CreateLayerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStack


        /// <summary>
        /// Creates a new stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-edit.html">Create
        /// a New Stack</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        /// policy that explicitly grants permissions. For more information on user permissions,
        /// see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStack service method.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateStack">REST API Reference for CreateStack Operation</seealso>
        CreateStackResponse CreateStack(CreateStackRequest request);


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
        Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUserProfile


        /// <summary>
        /// Creates a new user profile.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        /// policy that explicitly grants permissions. For more information on user permissions,
        /// see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile service method.</param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request);


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
        Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApp


        /// <summary>
        /// Deletes a specified app.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        DeleteAppResponse DeleteApp(DeleteAppRequest request);


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
        Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteInstance


        /// <summary>
        /// Deletes a specified instance, which terminates the associated Amazon EC2 instance.
        /// You must stop an instance before you can delete it.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-delete.html">Deleting
        /// Instances</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request);


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
        Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLayer


        /// <summary>
        /// Deletes a specified layer. You must first stop and then delete all associated instances
        /// or unassign registered instances. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-delete.html">How
        /// to Delete a Layer</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayer service method.</param>
        /// 
        /// <returns>The response from the DeleteLayer service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteLayer">REST API Reference for DeleteLayer Operation</seealso>
        DeleteLayerResponse DeleteLayer(DeleteLayerRequest request);


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
        Task<DeleteLayerResponse> DeleteLayerAsync(DeleteLayerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStack


        /// <summary>
        /// Deletes a specified stack. You must first delete all instances, layers, and apps or
        /// deregister registered instances. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-shutting.html">Shut
        /// Down a Stack</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack service method.</param>
        /// 
        /// <returns>The response from the DeleteStack service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        DeleteStackResponse DeleteStack(DeleteStackRequest request);


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
        Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUserProfile


        /// <summary>
        /// Deletes a user profile.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        /// policy that explicitly grants permissions. For more information on user permissions,
        /// see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteUserProfile service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest request);


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
        Task<DeleteUserProfileResponse> DeleteUserProfileAsync(DeleteUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterEcsCluster


        /// <summary>
        /// Deregisters a specified Amazon ECS cluster from a stack. For more information, see
        /// <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-ecscluster.html#workinglayers-ecscluster-delete">
        /// Resource Management</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterEcsCluster service method.</param>
        /// 
        /// <returns>The response from the DeregisterEcsCluster service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterEcsCluster">REST API Reference for DeregisterEcsCluster Operation</seealso>
        DeregisterEcsClusterResponse DeregisterEcsCluster(DeregisterEcsClusterRequest request);


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
        Task<DeregisterEcsClusterResponse> DeregisterEcsClusterAsync(DeregisterEcsClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterElasticIp


        /// <summary>
        /// Deregisters a specified Elastic IP address. The address can then be registered by
        /// another stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterElasticIp service method.</param>
        /// 
        /// <returns>The response from the DeregisterElasticIp service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterElasticIp">REST API Reference for DeregisterElasticIp Operation</seealso>
        DeregisterElasticIpResponse DeregisterElasticIp(DeregisterElasticIpRequest request);


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
        Task<DeregisterElasticIpResponse> DeregisterElasticIpAsync(DeregisterElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterInstance


        /// <summary>
        /// Deregister a registered Amazon EC2 or on-premises instance. This action removes the
        /// instance from the stack and returns it to your control. This action can not be used
        /// with instances that were created with AWS OpsWorks Stacks.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstance service method.</param>
        /// 
        /// <returns>The response from the DeregisterInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterInstance">REST API Reference for DeregisterInstance Operation</seealso>
        DeregisterInstanceResponse DeregisterInstance(DeregisterInstanceRequest request);


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
        Task<DeregisterInstanceResponse> DeregisterInstanceAsync(DeregisterInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterRdsDbInstance


        /// <summary>
        /// Deregisters an Amazon RDS instance.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterRdsDbInstance service method.</param>
        /// 
        /// <returns>The response from the DeregisterRdsDbInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterRdsDbInstance">REST API Reference for DeregisterRdsDbInstance Operation</seealso>
        DeregisterRdsDbInstanceResponse DeregisterRdsDbInstance(DeregisterRdsDbInstanceRequest request);


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
        Task<DeregisterRdsDbInstanceResponse> DeregisterRdsDbInstanceAsync(DeregisterRdsDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterVolume


        /// <summary>
        /// Deregisters an Amazon EBS volume. The volume can then be registered by another stack.
        /// For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterVolume service method.</param>
        /// 
        /// <returns>The response from the DeregisterVolume service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterVolume">REST API Reference for DeregisterVolume Operation</seealso>
        DeregisterVolumeResponse DeregisterVolume(DeregisterVolumeRequest request);


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
        Task<DeregisterVolumeResponse> DeregisterVolumeAsync(DeregisterVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAgentVersions


        /// <summary>
        /// Describes the available AWS OpsWorks Stacks agent versions. You must specify a stack
        /// ID or a configuration manager. <code>DescribeAgentVersions</code> returns a list of
        /// available agent versions for the specified stack or configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgentVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeAgentVersions service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeAgentVersions">REST API Reference for DescribeAgentVersions Operation</seealso>
        DescribeAgentVersionsResponse DescribeAgentVersions(DescribeAgentVersionsRequest request);


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
        Task<DescribeAgentVersionsResponse> DescribeAgentVersionsAsync(DescribeAgentVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeApps


        /// <summary>
        /// Requests a description of a specified set of apps.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeApps service method.</param>
        /// 
        /// <returns>The response from the DescribeApps service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeApps">REST API Reference for DescribeApps Operation</seealso>
        DescribeAppsResponse DescribeApps(DescribeAppsRequest request);


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
        Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCommands


        /// <summary>
        /// Describes the results of specified commands.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommands service method.</param>
        /// 
        /// <returns>The response from the DescribeCommands service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeCommands">REST API Reference for DescribeCommands Operation</seealso>
        DescribeCommandsResponse DescribeCommands(DescribeCommandsRequest request);


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
        Task<DescribeCommandsResponse> DescribeCommandsAsync(DescribeCommandsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDeployments


        /// <summary>
        /// Requests a description of a specified set of deployments.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeployments service method.</param>
        /// 
        /// <returns>The response from the DescribeDeployments service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeDeployments">REST API Reference for DescribeDeployments Operation</seealso>
        DescribeDeploymentsResponse DescribeDeployments(DescribeDeploymentsRequest request);


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
        Task<DescribeDeploymentsResponse> DescribeDeploymentsAsync(DescribeDeploymentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEcsClusters


        /// <summary>
        /// Describes Amazon ECS clusters that are registered with a stack. If you specify only
        /// a stack ID, you can use the <code>MaxResults</code> and <code>NextToken</code> parameters
        /// to paginate the response. However, AWS OpsWorks Stacks currently supports only one
        /// cluster per layer, so the result set has a maximum of one element.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack or an attached policy that explicitly grants
        /// permission. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// This call accepts only one resource-identifying parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEcsClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeEcsClusters service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeEcsClusters">REST API Reference for DescribeEcsClusters Operation</seealso>
        DescribeEcsClustersResponse DescribeEcsClusters(DescribeEcsClustersRequest request);


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
        Task<DescribeEcsClustersResponse> DescribeEcsClustersAsync(DescribeEcsClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeElasticIps


        /// <summary>
        /// Describes <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP addresses</a>.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticIps service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticIps service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeElasticIps">REST API Reference for DescribeElasticIps Operation</seealso>
        DescribeElasticIpsResponse DescribeElasticIps(DescribeElasticIpsRequest request);


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
        Task<DescribeElasticIpsResponse> DescribeElasticIpsAsync(DescribeElasticIpsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeElasticLoadBalancers


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
        /// 
        /// <returns>The response from the DescribeElasticLoadBalancers service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeElasticLoadBalancers">REST API Reference for DescribeElasticLoadBalancers Operation</seealso>
        DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers();


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
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticLoadBalancers service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeElasticLoadBalancers">REST API Reference for DescribeElasticLoadBalancers Operation</seealso>
        DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers(DescribeElasticLoadBalancersRequest request);


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
        Task<DescribeElasticLoadBalancersResponse> DescribeElasticLoadBalancersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<DescribeElasticLoadBalancersResponse> DescribeElasticLoadBalancersAsync(DescribeElasticLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInstances


        /// <summary>
        /// Requests a description of a set of instances.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request);


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
        Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLayers


        /// <summary>
        /// Requests a description of one or more layers in a specified stack.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeLayers service method.</param>
        /// 
        /// <returns>The response from the DescribeLayers service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeLayers">REST API Reference for DescribeLayers Operation</seealso>
        DescribeLayersResponse DescribeLayers(DescribeLayersRequest request);


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
        Task<DescribeLayersResponse> DescribeLayersAsync(DescribeLayersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLoadBasedAutoScaling


        /// <summary>
        /// Describes load-based auto scaling configurations for specified layers.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBasedAutoScaling service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBasedAutoScaling service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeLoadBasedAutoScaling">REST API Reference for DescribeLoadBasedAutoScaling Operation</seealso>
        DescribeLoadBasedAutoScalingResponse DescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest request);


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
        Task<DescribeLoadBasedAutoScalingResponse> DescribeLoadBasedAutoScalingAsync(DescribeLoadBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMyUserProfile


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
        /// 
        /// <returns>The response from the DescribeMyUserProfile service method, as returned by OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeMyUserProfile">REST API Reference for DescribeMyUserProfile Operation</seealso>
        DescribeMyUserProfileResponse DescribeMyUserProfile();


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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMyUserProfile service method.</param>
        /// 
        /// <returns>The response from the DescribeMyUserProfile service method, as returned by OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeMyUserProfile">REST API Reference for DescribeMyUserProfile Operation</seealso>
        DescribeMyUserProfileResponse DescribeMyUserProfile(DescribeMyUserProfileRequest request);


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
        Task<DescribeMyUserProfileResponse> DescribeMyUserProfileAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<DescribeMyUserProfileResponse> DescribeMyUserProfileAsync(DescribeMyUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOperatingSystems


        /// <summary>
        /// Describes the operating systems that are supported by AWS OpsWorks Stacks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOperatingSystems service method.</param>
        /// 
        /// <returns>The response from the DescribeOperatingSystems service method, as returned by OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeOperatingSystems">REST API Reference for DescribeOperatingSystems Operation</seealso>
        DescribeOperatingSystemsResponse DescribeOperatingSystems(DescribeOperatingSystemsRequest request);


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
        Task<DescribeOperatingSystemsResponse> DescribeOperatingSystemsAsync(DescribeOperatingSystemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePermissions


        /// <summary>
        /// Describes the permissions for a specified stack.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribePermissions service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribePermissions">REST API Reference for DescribePermissions Operation</seealso>
        DescribePermissionsResponse DescribePermissions(DescribePermissionsRequest request);


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
        Task<DescribePermissionsResponse> DescribePermissionsAsync(DescribePermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRaidArrays


        /// <summary>
        /// Describe an instance's RAID arrays.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeRaidArrays service method.</param>
        /// 
        /// <returns>The response from the DescribeRaidArrays service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeRaidArrays">REST API Reference for DescribeRaidArrays Operation</seealso>
        DescribeRaidArraysResponse DescribeRaidArrays(DescribeRaidArraysRequest request);


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
        Task<DescribeRaidArraysResponse> DescribeRaidArraysAsync(DescribeRaidArraysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRdsDbInstances


        /// <summary>
        /// Describes Amazon RDS instances.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeRdsDbInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeRdsDbInstances service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeRdsDbInstances">REST API Reference for DescribeRdsDbInstances Operation</seealso>
        DescribeRdsDbInstancesResponse DescribeRdsDbInstances(DescribeRdsDbInstancesRequest request);


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
        Task<DescribeRdsDbInstancesResponse> DescribeRdsDbInstancesAsync(DescribeRdsDbInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeServiceErrors


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
        /// 
        /// <returns>The response from the DescribeServiceErrors service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeServiceErrors">REST API Reference for DescribeServiceErrors Operation</seealso>
        DescribeServiceErrorsResponse DescribeServiceErrors();


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
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceErrors service method.</param>
        /// 
        /// <returns>The response from the DescribeServiceErrors service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeServiceErrors">REST API Reference for DescribeServiceErrors Operation</seealso>
        DescribeServiceErrorsResponse DescribeServiceErrors(DescribeServiceErrorsRequest request);


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
        Task<DescribeServiceErrorsResponse> DescribeServiceErrorsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<DescribeServiceErrorsResponse> DescribeServiceErrorsAsync(DescribeServiceErrorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStackProvisioningParameters


        /// <summary>
        /// Requests a description of a stack's provisioning parameters.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackProvisioningParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeStackProvisioningParameters service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStackProvisioningParameters">REST API Reference for DescribeStackProvisioningParameters Operation</seealso>
        DescribeStackProvisioningParametersResponse DescribeStackProvisioningParameters(DescribeStackProvisioningParametersRequest request);


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
        Task<DescribeStackProvisioningParametersResponse> DescribeStackProvisioningParametersAsync(DescribeStackProvisioningParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStacks


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
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        DescribeStacksResponse DescribeStacks();


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
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks service method.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        DescribeStacksResponse DescribeStacks(DescribeStacksRequest request);


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
        Task<DescribeStacksResponse> DescribeStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStackSummary


        /// <summary>
        /// Describes the number of layers and apps in a specified stack, and the number of instances
        /// in each state, such as <code>running_setup</code> or <code>online</code>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSummary service method.</param>
        /// 
        /// <returns>The response from the DescribeStackSummary service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStackSummary">REST API Reference for DescribeStackSummary Operation</seealso>
        DescribeStackSummaryResponse DescribeStackSummary(DescribeStackSummaryRequest request);


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
        Task<DescribeStackSummaryResponse> DescribeStackSummaryAsync(DescribeStackSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTimeBasedAutoScaling


        /// <summary>
        /// Describes time-based auto scaling configurations for specified instances.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeTimeBasedAutoScaling service method.</param>
        /// 
        /// <returns>The response from the DescribeTimeBasedAutoScaling service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeTimeBasedAutoScaling">REST API Reference for DescribeTimeBasedAutoScaling Operation</seealso>
        DescribeTimeBasedAutoScalingResponse DescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest request);


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
        Task<DescribeTimeBasedAutoScalingResponse> DescribeTimeBasedAutoScalingAsync(DescribeTimeBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUserProfiles


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
        /// 
        /// <returns>The response from the DescribeUserProfiles service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeUserProfiles">REST API Reference for DescribeUserProfiles Operation</seealso>
        DescribeUserProfilesResponse DescribeUserProfiles();


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
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfiles service method.</param>
        /// 
        /// <returns>The response from the DescribeUserProfiles service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeUserProfiles">REST API Reference for DescribeUserProfiles Operation</seealso>
        DescribeUserProfilesResponse DescribeUserProfiles(DescribeUserProfilesRequest request);


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
        Task<DescribeUserProfilesResponse> DescribeUserProfilesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<DescribeUserProfilesResponse> DescribeUserProfilesAsync(DescribeUserProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeVolumes


        /// <summary>
        /// Describes an instance's Amazon EBS volumes.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request);


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
        Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachElasticLoadBalancer


        /// <summary>
        /// Detaches a specified Elastic Load Balancing instance from its layer.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachElasticLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DetachElasticLoadBalancer service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DetachElasticLoadBalancer">REST API Reference for DetachElasticLoadBalancer Operation</seealso>
        DetachElasticLoadBalancerResponse DetachElasticLoadBalancer(DetachElasticLoadBalancerRequest request);


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
        Task<DetachElasticLoadBalancerResponse> DetachElasticLoadBalancerAsync(DetachElasticLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateElasticIp


        /// <summary>
        /// Disassociates an Elastic IP address from its instance. The address remains registered
        /// with the stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateElasticIp service method.</param>
        /// 
        /// <returns>The response from the DisassociateElasticIp service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DisassociateElasticIp">REST API Reference for DisassociateElasticIp Operation</seealso>
        DisassociateElasticIpResponse DisassociateElasticIp(DisassociateElasticIpRequest request);


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
        Task<DisassociateElasticIpResponse> DisassociateElasticIpAsync(DisassociateElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetHostnameSuggestion


        /// <summary>
        /// Gets a generated host name for the specified layer, based on the current host name
        /// theme.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostnameSuggestion service method.</param>
        /// 
        /// <returns>The response from the GetHostnameSuggestion service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/GetHostnameSuggestion">REST API Reference for GetHostnameSuggestion Operation</seealso>
        GetHostnameSuggestionResponse GetHostnameSuggestion(GetHostnameSuggestionRequest request);


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
        Task<GetHostnameSuggestionResponse> GetHostnameSuggestionAsync(GetHostnameSuggestionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GrantAccess


        /// <summary>
        /// <note> 
        /// <para>
        /// This action can be used only with Windows stacks.
        /// </para>
        ///  </note> 
        /// <para>
        /// Grants RDP access to a Windows instance for a specified time period.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GrantAccess service method.</param>
        /// 
        /// <returns>The response from the GrantAccess service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/GrantAccess">REST API Reference for GrantAccess Operation</seealso>
        GrantAccessResponse GrantAccess(GrantAccessRequest request);


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
        Task<GrantAccessResponse> GrantAccessAsync(GrantAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Returns a list of tags that are applied to the specified stack or layer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse ListTags(ListTagsRequest request);


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
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RebootInstance


        /// <summary>
        /// Reboots a specified instance. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-starting.html">Starting,
        /// Stopping, and Rebooting Instances</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance service method.</param>
        /// 
        /// <returns>The response from the RebootInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        RebootInstanceResponse RebootInstance(RebootInstanceRequest request);


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
        Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterEcsCluster


        /// <summary>
        /// Registers a specified Amazon ECS cluster with a stack. You can register only one cluster
        /// with a stack. A cluster can be registered with only one stack. For more information,
        /// see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-ecscluster.html">
        /// Resource Management</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">
        /// Managing User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterEcsCluster service method.</param>
        /// 
        /// <returns>The response from the RegisterEcsCluster service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterEcsCluster">REST API Reference for RegisterEcsCluster Operation</seealso>
        RegisterEcsClusterResponse RegisterEcsCluster(RegisterEcsClusterRequest request);


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
        Task<RegisterEcsClusterResponse> RegisterEcsClusterAsync(RegisterEcsClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterElasticIp


        /// <summary>
        /// Registers an Elastic IP address with a specified stack. An address can be registered
        /// with only one stack at a time. If the address is already registered, you must first
        /// deregister it by calling <a>DeregisterElasticIp</a>. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterElasticIp service method.</param>
        /// 
        /// <returns>The response from the RegisterElasticIp service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterElasticIp">REST API Reference for RegisterElasticIp Operation</seealso>
        RegisterElasticIpResponse RegisterElasticIp(RegisterElasticIpRequest request);


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
        Task<RegisterElasticIpResponse> RegisterElasticIpAsync(RegisterElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterInstance


        /// <summary>
        /// Registers instances that were created outside of AWS OpsWorks Stacks with a specified
        /// stack.
        /// 
        ///  <note> 
        /// <para>
        /// We do not recommend using this action to register instances. The complete registration
        /// operation includes two tasks: installing the AWS OpsWorks Stacks agent on the instance,
        /// and registering the instance with the stack. <code>RegisterInstance</code> handles
        /// only the second step. You should instead use the AWS CLI <code>register</code> command,
        /// which performs the entire registration operation. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/registered-instances-register.html">
        /// Registering an Instance with an AWS OpsWorks Stacks Stack</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Registered instances have the same requirements as instances that are created by using
        /// the <a>CreateInstance</a> API. For example, registered instances must be running a
        /// supported Linux-based operating system, and they must have a supported instance type.
        /// For more information about requirements for instances that you want to register, see
        /// <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/registered-instances-register-registering-preparer.html">
        /// Preparing the Instance</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstance service method.</param>
        /// 
        /// <returns>The response from the RegisterInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterInstance">REST API Reference for RegisterInstance Operation</seealso>
        RegisterInstanceResponse RegisterInstance(RegisterInstanceRequest request);


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
        Task<RegisterInstanceResponse> RegisterInstanceAsync(RegisterInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterRdsDbInstance


        /// <summary>
        /// Registers an Amazon RDS instance with a stack.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterRdsDbInstance service method.</param>
        /// 
        /// <returns>The response from the RegisterRdsDbInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterRdsDbInstance">REST API Reference for RegisterRdsDbInstance Operation</seealso>
        RegisterRdsDbInstanceResponse RegisterRdsDbInstance(RegisterRdsDbInstanceRequest request);


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
        Task<RegisterRdsDbInstanceResponse> RegisterRdsDbInstanceAsync(RegisterRdsDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterVolume


        /// <summary>
        /// Registers an Amazon EBS volume with a specified stack. A volume can be registered
        /// with only one stack at a time. If the volume is already registered, you must first
        /// deregister it by calling <a>DeregisterVolume</a>. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterVolume service method.</param>
        /// 
        /// <returns>The response from the RegisterVolume service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterVolume">REST API Reference for RegisterVolume Operation</seealso>
        RegisterVolumeResponse RegisterVolume(RegisterVolumeRequest request);


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
        Task<RegisterVolumeResponse> RegisterVolumeAsync(RegisterVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetLoadBasedAutoScaling


        /// <summary>
        /// Specify the load-based auto scaling configuration for a specified layer. For more
        /// information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-autoscaling.html">Managing
        /// Load with Time-based and Load-based Instances</a>.
        /// 
        ///  <note> 
        /// <para>
        /// To use load-based auto scaling, you must create a set of load-based auto scaling instances.
        /// Load-based auto scaling operates only on the instances from that set, so you must
        /// ensure that you have created enough instances to handle the maximum anticipated load.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBasedAutoScaling service method.</param>
        /// 
        /// <returns>The response from the SetLoadBasedAutoScaling service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetLoadBasedAutoScaling">REST API Reference for SetLoadBasedAutoScaling Operation</seealso>
        SetLoadBasedAutoScalingResponse SetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest request);


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
        Task<SetLoadBasedAutoScalingResponse> SetLoadBasedAutoScalingAsync(SetLoadBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetPermission


        /// <summary>
        /// Specifies a user's permissions. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingsecurity.html">Security
        /// and Permissions</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetPermission service method.</param>
        /// 
        /// <returns>The response from the SetPermission service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetPermission">REST API Reference for SetPermission Operation</seealso>
        SetPermissionResponse SetPermission(SetPermissionRequest request);


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
        Task<SetPermissionResponse> SetPermissionAsync(SetPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetTimeBasedAutoScaling


        /// <summary>
        /// Specify the time-based auto scaling configuration for a specified instance. For more
        /// information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-autoscaling.html">Managing
        /// Load with Time-based and Load-based Instances</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTimeBasedAutoScaling service method.</param>
        /// 
        /// <returns>The response from the SetTimeBasedAutoScaling service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetTimeBasedAutoScaling">REST API Reference for SetTimeBasedAutoScaling Operation</seealso>
        SetTimeBasedAutoScalingResponse SetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest request);


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
        Task<SetTimeBasedAutoScalingResponse> SetTimeBasedAutoScalingAsync(SetTimeBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartInstance


        /// <summary>
        /// Starts a specified instance. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-starting.html">Starting,
        /// Stopping, and Rebooting Instances</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstance service method.</param>
        /// 
        /// <returns>The response from the StartInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StartInstance">REST API Reference for StartInstance Operation</seealso>
        StartInstanceResponse StartInstance(StartInstanceRequest request);


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
        Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartStack


        /// <summary>
        /// Starts a stack's instances.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStack service method.</param>
        /// 
        /// <returns>The response from the StartStack service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StartStack">REST API Reference for StartStack Operation</seealso>
        StartStackResponse StartStack(StartStackRequest request);


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
        Task<StartStackResponse> StartStackAsync(StartStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopInstance


        /// <summary>
        /// Stops a specified instance. When you stop a standard instance, the data disappears
        /// and must be reinstalled when you restart the instance. You can stop an Amazon EBS-backed
        /// instance without losing data. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-starting.html">Starting,
        /// Stopping, and Rebooting Instances</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInstance service method.</param>
        /// 
        /// <returns>The response from the StopInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StopInstance">REST API Reference for StopInstance Operation</seealso>
        StopInstanceResponse StopInstance(StopInstanceRequest request);


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
        Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopStack


        /// <summary>
        /// Stops a specified stack.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStack service method.</param>
        /// 
        /// <returns>The response from the StopStack service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StopStack">REST API Reference for StopStack Operation</seealso>
        StopStackResponse StopStack(StopStackRequest request);


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
        Task<StopStackResponse> StopStackAsync(StopStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Apply cost-allocation tags to a specified stack or layer in AWS OpsWorks Stacks. For
        /// more information about how tagging works, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/tagging.html">Tags</a>
        /// in the AWS OpsWorks User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);


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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UnassignInstance


        /// <summary>
        /// Unassigns a registered instance from all of it's layers. The instance remains in the
        /// stack as an unassigned instance and can be assigned to another layer, as needed. You
        /// cannot use this action with instances that were created with AWS OpsWorks Stacks.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnassignInstance service method.</param>
        /// 
        /// <returns>The response from the UnassignInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UnassignInstance">REST API Reference for UnassignInstance Operation</seealso>
        UnassignInstanceResponse UnassignInstance(UnassignInstanceRequest request);


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
        Task<UnassignInstanceResponse> UnassignInstanceAsync(UnassignInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UnassignVolume


        /// <summary>
        /// Unassigns an assigned Amazon EBS volume. The volume remains registered with the stack.
        /// For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnassignVolume service method.</param>
        /// 
        /// <returns>The response from the UnassignVolume service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UnassignVolume">REST API Reference for UnassignVolume Operation</seealso>
        UnassignVolumeResponse UnassignVolume(UnassignVolumeRequest request);


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
        Task<UnassignVolumeResponse> UnassignVolumeAsync(UnassignVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a specified stack or layer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);


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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApp


        /// <summary>
        /// Updates a specified app.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Deploy or
        /// Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp service method.</param>
        /// 
        /// <returns>The response from the UpdateApp service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        UpdateAppResponse UpdateApp(UpdateAppRequest request);


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
        Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateElasticIp


        /// <summary>
        /// Updates a registered Elastic IP address's name. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticIp service method.</param>
        /// 
        /// <returns>The response from the UpdateElasticIp service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateElasticIp">REST API Reference for UpdateElasticIp Operation</seealso>
        UpdateElasticIpResponse UpdateElasticIp(UpdateElasticIpRequest request);


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
        Task<UpdateElasticIpResponse> UpdateElasticIpAsync(UpdateElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateInstance


        /// <summary>
        /// Updates a specified instance.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request);


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
        Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLayer


        /// <summary>
        /// Updates a specified layer.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLayer service method.</param>
        /// 
        /// <returns>The response from the UpdateLayer service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateLayer">REST API Reference for UpdateLayer Operation</seealso>
        UpdateLayerResponse UpdateLayer(UpdateLayerRequest request);


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
        Task<UpdateLayerResponse> UpdateLayerAsync(UpdateLayerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMyUserProfile


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
        /// 
        /// <returns>The response from the UpdateMyUserProfile service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateMyUserProfile">REST API Reference for UpdateMyUserProfile Operation</seealso>
        UpdateMyUserProfileResponse UpdateMyUserProfile();


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
        /// <param name="request">Container for the necessary parameters to execute the UpdateMyUserProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateMyUserProfile service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateMyUserProfile">REST API Reference for UpdateMyUserProfile Operation</seealso>
        UpdateMyUserProfileResponse UpdateMyUserProfile(UpdateMyUserProfileRequest request);


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
        Task<UpdateMyUserProfileResponse> UpdateMyUserProfileAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<UpdateMyUserProfileResponse> UpdateMyUserProfileAsync(UpdateMyUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRdsDbInstance


        /// <summary>
        /// Updates an Amazon RDS instance.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRdsDbInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateRdsDbInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateRdsDbInstance">REST API Reference for UpdateRdsDbInstance Operation</seealso>
        UpdateRdsDbInstanceResponse UpdateRdsDbInstance(UpdateRdsDbInstanceRequest request);


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
        Task<UpdateRdsDbInstanceResponse> UpdateRdsDbInstanceAsync(UpdateRdsDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateStack


        /// <summary>
        /// Updates a specified stack.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack service method.</param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        UpdateStackResponse UpdateStack(UpdateStackRequest request);


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
        Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserProfile


        /// <summary>
        /// Updates a specified user profile.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        /// policy that explicitly grants permissions. For more information on user permissions,
        /// see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateUserProfile service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request);


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
        Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateVolume


        /// <summary>
        /// Updates an Amazon EBS volume's name or mount point. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVolume service method.</param>
        /// 
        /// <returns>The response from the UpdateVolume service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateVolume">REST API Reference for UpdateVolume Operation</seealso>
        UpdateVolumeResponse UpdateVolume(UpdateVolumeRequest request);


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
        Task<UpdateVolumeResponse> UpdateVolumeAsync(UpdateVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}