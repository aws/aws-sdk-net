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

namespace Amazon.OpsWorks
{
    /// <summary>
    /// Implementation for accessing OpsWorks
    ///
    /// AWS OpsWorks   
    /// <para>
    /// Welcome to the  <i>AWS OpsWorks API Reference</i>. This guide provides descriptions,
    /// syntax, and usage examples about AWS OpsWorks         actions and data types, including
    /// common parameters and error codes. 
    /// </para>
    ///   
    /// <para>
    /// AWS OpsWorks is an application management service that provides an integrated experience
    /// for overseeing the         complete application lifecycle. For information about this
    /// product, go to the  <a href="http://aws.amazon.com/opsworks/">AWS OpsWorks</a> details
    /// page. 
    /// </para>
    ///   
    /// <para>
    /// <b>SDKs and CLI</b> 
    /// </para>
    ///   
    /// <para>
    /// The most common way to use the AWS OpsWorks API is by using the AWS Command Line Interface
    /// (CLI) or   by using one of the AWS SDKs to implement applications in your preferred
    /// language. For more information, see:
    /// </para>
    ///   <ul>    <li><a href="http://docs.aws.amazon.com/cli/latest/userguide/cli-chap-welcome.html">AWS
    /// CLI</a></li>    <li><a href="http://docs.aws.amazon.com/AWSJavaSDK/latest/javadoc/com/amazonaws/services/opsworks/AWSOpsWorksClient.html">AWS
    /// SDK for Java</a></li>    <li><a href="http://docs.aws.amazon.com/sdkfornet/latest/apidocs/html/N_Amazon_OpsWorks.htm">AWS
    /// SDK for .NET</a></li>    <li><a href="http://docs.aws.amazon.com/aws-sdk-php-2/latest/class-Aws.OpsWorks.OpsWorksClient.html">AWS
    /// SDK for PHP 2</a></li>    <li><a href="http://docs.aws.amazon.com/AWSRubySDK/latest/AWS/OpsWorks/Client.html">AWS
    /// SDK for Ruby</a></li>    <li><a href="http://aws.amazon.com/documentation/sdkforjavascript/">AWS
    /// SDK for Node.js</a></li>    <li><a href="http://docs.pythonboto.org/en/latest/ref/opsworks.html">AWS
    /// SDK for Python(Boto)</a></li>  </ul>      
    /// <para>
    /// <b>Endpoints</b>
    /// </para>
    ///   
    /// <para>
    /// AWS OpsWorks supports only one endpoint, opsworks.us-east-1.amazonaws.com (HTTPS),
    /// so you must connect to that endpoint. You can then use the API         to direct AWS
    /// OpsWorks to create stacks in any AWS Region.
    /// </para>
    ///   
    /// <para>
    /// <b>Chef Version</b>
    /// </para>
    ///   
    /// <para>
    /// When you call <a>CreateStack</a>, <a>CloneStack</a>, or <a>UpdateStack</a> we recommend
    /// you use         the <code>ConfigurationManager</code> parameter to specify the Chef
    /// version, 0.9, 11.4, or 11.10.         The default value is currently 11.4.       
    ///  For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook-chef11.html">Chef
    /// Versions</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonOpsWorks : IDisposable
    {

        
        #region  AssignVolume


        /// <summary>
        /// Assigns one of the stack's registered Amazon EBS volumes to a specified instance.
        /// The volume must first be registered      with the stack by calling <a>RegisterVolume</a>.
        /// For more information, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///      
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignVolume service method.</param>
        /// 
        /// <returns>The response from the AssignVolume service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        AssignVolumeResponse AssignVolume(AssignVolumeRequest request);

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
        Task<AssignVolumeResponse> AssignVolumeAsync(AssignVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateElasticIp


        /// <summary>
        /// Associates one of the stack's registered Elastic IP addresses with a specified instance.
        /// The address    must first be registered with the stack by calling <a>RegisterElasticIp</a>.
        /// For more information, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateElasticIp service method.</param>
        /// 
        /// <returns>The response from the AssociateElasticIp service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        AssociateElasticIpResponse AssociateElasticIp(AssociateElasticIpRequest request);

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
        Task<AssociateElasticIpResponse> AssociateElasticIpAsync(AssociateElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachElasticLoadBalancer


        /// <summary>
        /// Attaches an Elastic Load Balancing load balancer to a specified layer. For more information,
        /// see     <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/load-balancer-elb.html">Elastic
        /// Load Balancing</a>.
        /// 
        ///   <note>      
        /// <para>
        /// You must create the Elastic Load Balancing instance separately, by using the Elastic
        /// Load Balancing console, API, or CLI. For        more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/Welcome.html">
        ///          Elastic Load Balancing Developer Guide</a>.
        /// </para>
        ///     </note>    
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachElasticLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the AttachElasticLoadBalancer service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        AttachElasticLoadBalancerResponse AttachElasticLoadBalancer(AttachElasticLoadBalancerRequest request);

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
        Task<AttachElasticLoadBalancerResponse> AttachElasticLoadBalancerAsync(AttachElasticLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CloneStack


        /// <summary>
        /// Creates a clone of a specified stack. For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-cloning.html">Clone
        /// a Stack</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        ///       policy that explicitly grants permissions. For more information on user permissions,
        /// see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloneStack service method.</param>
        /// 
        /// <returns>The response from the CloneStack service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        CloneStackResponse CloneStack(CloneStackRequest request);

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
        Task<CloneStackResponse> CloneStackAsync(CloneStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateApp


        /// <summary>
        /// Creates an app for a specified stack. For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-creating.html">Creating
        /// Apps</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        CreateAppResponse CreateApp(CreateAppRequest request);

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
        Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDeployment


        /// <summary>
        /// Deploys a stack or app.
        /// 
        ///   <ul>  <li>App deployment generates a <code>deploy</code> event, which runs the associated
        /// recipes and passes them a JSON stack configuration object            that includes
        /// information about the app. </li>  <li>Stack deployment runs the <code>deploy</code>
        /// recipes but does not raise an event.</li>  </ul>  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-deploying.html">Deploying
        /// Apps</a>         and <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-commands.html">Run
        /// Stack Commands</a>.
        /// </para>
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Deploy or
        /// Manage permissions level for the stack, or an attached       policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request);

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
        Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateInstance


        /// <summary>
        /// Creates an instance in a specified stack. For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-add.html">Adding
        /// an Instance to a Layer</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance service method.</param>
        /// 
        /// <returns>The response from the CreateInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        CreateInstanceResponse CreateInstance(CreateInstanceRequest request);

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
        Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLayer


        /// <summary>
        /// Creates a layer. For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-create.html">How
        /// to Create a Layer</a>.
        /// 
        ///   <note>      
        /// <para>
        /// You should use <b>CreateLayer</b> for noncustom layer types such as PHP App Server
        /// only if the stack        does not have an existing layer of that type. A stack can
        /// have at most one instance of each        noncustom layer; if you attempt to create
        /// a second instance, <b>CreateLayer</b> fails. A        stack can have an arbitrary
        /// number of custom layers, so you can call <b>CreateLayer</b> as        many times as
        /// you like for that layer type.
        /// </para>
        ///     </note>    
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLayer service method.</param>
        /// 
        /// <returns>The response from the CreateLayer service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        CreateLayerResponse CreateLayer(CreateLayerRequest request);

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
        Task<CreateLayerResponse> CreateLayerAsync(CreateLayerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStack


        /// <summary>
        /// Creates a new stack. For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-edit.html">Create
        /// a New Stack</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        ///       policy that explicitly grants permissions. For more information on user permissions,
        /// see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStack service method.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by OpsWorks.</returns>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        CreateStackResponse CreateStack(CreateStackRequest request);

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
        Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUserProfile


        /// <summary>
        /// Creates a new user profile.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        ///       policy that explicitly grants permissions. For more information on user permissions,
        /// see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile service method.</param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by OpsWorks.</returns>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request);

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
        Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApp


        /// <summary>
        /// Deletes a specified app.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DeleteAppResponse DeleteApp(DeleteAppRequest request);

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
        Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteInstance


        /// <summary>
        /// Deletes a specified instance. You must stop an instance before you can delete it.
        /// For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-delete.html">Deleting
        /// Instances</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request);

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
        Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLayer


        /// <summary>
        /// Deletes a specified layer. You must first stop and then delete all associated instances.
        ///  For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-delete.html">How
        /// to Delete a Layer</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayer service method.</param>
        /// 
        /// <returns>The response from the DeleteLayer service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DeleteLayerResponse DeleteLayer(DeleteLayerRequest request);

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
        Task<DeleteLayerResponse> DeleteLayerAsync(DeleteLayerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStack


        /// <summary>
        /// Deletes a specified stack. You must first delete all instances, layers, and apps.
        ///         For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-shutting.html">Shut
        /// Down a Stack</a>.
        /// 
        ///      
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack service method.</param>
        /// 
        /// <returns>The response from the DeleteStack service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DeleteStackResponse DeleteStack(DeleteStackRequest request);

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
        Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUserProfile


        /// <summary>
        /// Deletes a user profile.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        ///       policy that explicitly grants permissions. For more information on user permissions,
        /// see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteUserProfile service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest request);

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
        Task<DeleteUserProfileResponse> DeleteUserProfileAsync(DeleteUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterElasticIp


        /// <summary>
        /// Deregisters a specified Elastic IP address. The address can then be registered by
        /// another stack.  For more information, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterElasticIp service method.</param>
        /// 
        /// <returns>The response from the DeregisterElasticIp service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DeregisterElasticIpResponse DeregisterElasticIp(DeregisterElasticIpRequest request);

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
        Task<DeregisterElasticIpResponse> DeregisterElasticIpAsync(DeregisterElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterRdsDbInstance


        /// <summary>
        /// Deregisters an Amazon RDS instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterRdsDbInstance service method.</param>
        /// 
        /// <returns>The response from the DeregisterRdsDbInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DeregisterRdsDbInstanceResponse DeregisterRdsDbInstance(DeregisterRdsDbInstanceRequest request);

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
        Task<DeregisterRdsDbInstanceResponse> DeregisterRdsDbInstanceAsync(DeregisterRdsDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterVolume


        /// <summary>
        /// Deregisters an Amazon EBS volume.      The volume can then be registered by another
        /// stack. For more information, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterVolume service method.</param>
        /// 
        /// <returns>The response from the DeregisterVolume service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DeregisterVolumeResponse DeregisterVolume(DeregisterVolumeRequest request);

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
        Task<DeregisterVolumeResponse> DeregisterVolumeAsync(DeregisterVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeApps


        /// <summary>
        /// Requests a description of a specified set of apps.
        /// 
        ///   <note>      
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///     </note>    
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached       policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApps service method.</param>
        /// 
        /// <returns>The response from the DescribeApps service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeAppsResponse DescribeApps(DescribeAppsRequest request);

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
        Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCommands


        /// <summary>
        /// Describes the results of specified commands.
        /// 
        ///   <note>      
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///     </note>    
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached       policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommands service method.</param>
        /// 
        /// <returns>The response from the DescribeCommands service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeCommandsResponse DescribeCommands(DescribeCommandsRequest request);

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
        Task<DescribeCommandsResponse> DescribeCommandsAsync(DescribeCommandsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDeployments


        /// <summary>
        /// Requests a description of a specified set of deployments.
        /// 
        ///   <note>      
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///     </note>    
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached       policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeployments service method.</param>
        /// 
        /// <returns>The response from the DescribeDeployments service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeDeploymentsResponse DescribeDeployments(DescribeDeploymentsRequest request);

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
        Task<DescribeDeploymentsResponse> DescribeDeploymentsAsync(DescribeDeploymentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeElasticIps


        /// <summary>
        /// Describes <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP addresses</a>.
        /// 
        ///   <note>      
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///     </note>    
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached       policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticIps service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticIps service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeElasticIpsResponse DescribeElasticIps(DescribeElasticIpsRequest request);

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
        Task<DescribeElasticIpsResponse> DescribeElasticIpsAsync(DescribeElasticIpsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeElasticLoadBalancers

        /// <summary>
        /// Describes a stack's Elastic Load Balancing instances.
        /// 
        ///   <note>      
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///     </note>    
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached       policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeElasticLoadBalancers service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers();

        /// <summary>
        /// Describes a stack's Elastic Load Balancing instances.
        /// 
        ///   <note>      
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///     </note>    
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached       policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticLoadBalancers service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers(DescribeElasticLoadBalancersRequest request);

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
        Task<DescribeElasticLoadBalancersResponse> DescribeElasticLoadBalancersAsync(DescribeElasticLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInstances


        /// <summary>
        /// Requests a description of a set of instances.
        /// 
        ///         <note>      
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///     </note>    
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached       policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request);

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
        Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLayers


        /// <summary>
        /// Requests a description of one or more layers in a specified stack.
        /// 
        ///   <note>      
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///     </note>    
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached       policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLayers service method.</param>
        /// 
        /// <returns>The response from the DescribeLayers service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeLayersResponse DescribeLayers(DescribeLayersRequest request);

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
        Task<DescribeLayersResponse> DescribeLayersAsync(DescribeLayersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLoadBasedAutoScaling


        /// <summary>
        /// Describes load-based auto scaling configurations for specified layers.
        /// 
        ///   <note>      
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///     </note>    
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached       policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBasedAutoScaling service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBasedAutoScaling service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeLoadBasedAutoScalingResponse DescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest request);

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
        Task<DescribeLoadBasedAutoScalingResponse> DescribeLoadBasedAutoScalingAsync(DescribeLoadBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMyUserProfile

        /// <summary>
        /// Describes a user's SSH information.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have self-management
        /// enabled      or an attached policy that explicitly grants permissions. For more information
        /// on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeMyUserProfile service method, as returned by OpsWorks.</returns>
        DescribeMyUserProfileResponse DescribeMyUserProfile();

        /// <summary>
        /// Describes a user's SSH information.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have self-management
        /// enabled      or an attached policy that explicitly grants permissions. For more information
        /// on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMyUserProfile service method.</param>
        /// 
        /// <returns>The response from the DescribeMyUserProfile service method, as returned by OpsWorks.</returns>
        DescribeMyUserProfileResponse DescribeMyUserProfile(DescribeMyUserProfileRequest request);

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
        Task<DescribeMyUserProfileResponse> DescribeMyUserProfileAsync(DescribeMyUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePermissions


        /// <summary>
        /// Describes the permissions for a specified stack.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribePermissions service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribePermissionsResponse DescribePermissions(DescribePermissionsRequest request);

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
        Task<DescribePermissionsResponse> DescribePermissionsAsync(DescribePermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRaidArrays


        /// <summary>
        /// Describe an instance's RAID arrays.
        /// 
        ///   <note>      
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///     </note>    
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage       permissions level for the stack, or an attached policy that explicitly
        /// grants permissions.       For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRaidArrays service method.</param>
        /// 
        /// <returns>The response from the DescribeRaidArrays service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeRaidArraysResponse DescribeRaidArrays(DescribeRaidArraysRequest request);

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
        Task<DescribeRaidArraysResponse> DescribeRaidArraysAsync(DescribeRaidArraysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRdsDbInstances


        /// <summary>
        /// Describes Amazon RDS instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRdsDbInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeRdsDbInstances service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeRdsDbInstancesResponse DescribeRdsDbInstances(DescribeRdsDbInstancesRequest request);

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
        Task<DescribeRdsDbInstancesResponse> DescribeRdsDbInstancesAsync(DescribeRdsDbInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeServiceErrors

        /// <summary>
        /// Describes AWS OpsWorks service errors.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage       permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeServiceErrors service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeServiceErrorsResponse DescribeServiceErrors();

        /// <summary>
        /// Describes AWS OpsWorks service errors.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage       permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceErrors service method.</param>
        /// 
        /// <returns>The response from the DescribeServiceErrors service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeServiceErrorsResponse DescribeServiceErrors(DescribeServiceErrorsRequest request);

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
        Task<DescribeServiceErrorsResponse> DescribeServiceErrorsAsync(DescribeServiceErrorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStacks

        /// <summary>
        /// Requests a description of one or more stacks.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage       permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeStacksResponse DescribeStacks();

        /// <summary>
        /// Requests a description of one or more stacks.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage       permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks service method.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeStacksResponse DescribeStacks(DescribeStacksRequest request);

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
        Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStackSummary


        /// <summary>
        /// Describes the number of layers and apps in a specified stack, and the number of instances
        /// in      each state, such as <code>running_setup</code> or <code>online</code>.
        /// 
        ///      
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage       permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSummary service method.</param>
        /// 
        /// <returns>The response from the DescribeStackSummary service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeStackSummaryResponse DescribeStackSummary(DescribeStackSummaryRequest request);

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
        Task<DescribeStackSummaryResponse> DescribeStackSummaryAsync(DescribeStackSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTimeBasedAutoScaling


        /// <summary>
        /// Describes time-based auto scaling configurations for specified instances.
        /// 
        ///   <note>      
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///     </note>    
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage       permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTimeBasedAutoScaling service method.</param>
        /// 
        /// <returns>The response from the DescribeTimeBasedAutoScaling service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeTimeBasedAutoScalingResponse DescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest request);

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
        Task<DescribeTimeBasedAutoScalingResponse> DescribeTimeBasedAutoScalingAsync(DescribeTimeBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUserProfiles

        /// <summary>
        /// Describe specified users.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        /// policy that explicitly grants permissions.      For more information on user permissions,
        /// see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeUserProfiles service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeUserProfilesResponse DescribeUserProfiles();

        /// <summary>
        /// Describe specified users.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        /// policy that explicitly grants permissions.      For more information on user permissions,
        /// see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfiles service method.</param>
        /// 
        /// <returns>The response from the DescribeUserProfiles service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeUserProfilesResponse DescribeUserProfiles(DescribeUserProfilesRequest request);

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
        Task<DescribeUserProfilesResponse> DescribeUserProfilesAsync(DescribeUserProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeVolumes


        /// <summary>
        /// Describes an instance's Amazon EBS volumes.
        /// 
        ///   <note>      
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///     </note>    
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions       level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request);

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
        Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachElasticLoadBalancer


        /// <summary>
        /// Detaches a specified Elastic Load Balancing instance from its layer.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachElasticLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DetachElasticLoadBalancer service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        DetachElasticLoadBalancerResponse DetachElasticLoadBalancer(DetachElasticLoadBalancerRequest request);

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
        Task<DetachElasticLoadBalancerResponse> DetachElasticLoadBalancerAsync(DetachElasticLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateElasticIp


        /// <summary>
        /// Disassociates an Elastic IP address from its instance. The address remains registered
        /// with the stack. For more information, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateElasticIp service method.</param>
        /// 
        /// <returns>The response from the DisassociateElasticIp service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DisassociateElasticIpResponse DisassociateElasticIp(DisassociateElasticIpRequest request);

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
        Task<DisassociateElasticIpResponse> DisassociateElasticIpAsync(DisassociateElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetHostnameSuggestion


        /// <summary>
        /// Gets a generated host name for the specified layer, based on the current host name
        /// theme.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostnameSuggestion service method.</param>
        /// 
        /// <returns>The response from the GetHostnameSuggestion service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        GetHostnameSuggestionResponse GetHostnameSuggestion(GetHostnameSuggestionRequest request);

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
        Task<GetHostnameSuggestionResponse> GetHostnameSuggestionAsync(GetHostnameSuggestionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RebootInstance


        /// <summary>
        /// Reboots a specified instance.  For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-starting.html">Starting,
        /// Stopping, and Rebooting Instances</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance service method.</param>
        /// 
        /// <returns>The response from the RebootInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        RebootInstanceResponse RebootInstance(RebootInstanceRequest request);

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
        Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterElasticIp


        /// <summary>
        /// Registers an Elastic IP address with a specified stack. An address can be    registered
        /// with only one stack at a time. If the address is already registered, you must first
        /// deregister it      by calling <a>DeregisterElasticIp</a>. For more information, see
        ///      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterElasticIp service method.</param>
        /// 
        /// <returns>The response from the RegisterElasticIp service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        RegisterElasticIpResponse RegisterElasticIp(RegisterElasticIpRequest request);

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
        Task<RegisterElasticIpResponse> RegisterElasticIpAsync(RegisterElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterRdsDbInstance


        /// <summary>
        /// Registers an Amazon RDS instance with a stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterRdsDbInstance service method.</param>
        /// 
        /// <returns>The response from the RegisterRdsDbInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        RegisterRdsDbInstanceResponse RegisterRdsDbInstance(RegisterRdsDbInstanceRequest request);

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
        Task<RegisterRdsDbInstanceResponse> RegisterRdsDbInstanceAsync(RegisterRdsDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterVolume


        /// <summary>
        /// Registers an Amazon EBS volume with a specified stack. A volume can be    registered
        /// with only one stack at a time. If the volume is already registered, you must first
        /// deregister it      by calling <a>DeregisterVolume</a>. For more information, see 
        ///     <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterVolume service method.</param>
        /// 
        /// <returns>The response from the RegisterVolume service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        RegisterVolumeResponse RegisterVolume(RegisterVolumeRequest request);

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
        Task<RegisterVolumeResponse> RegisterVolumeAsync(RegisterVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetLoadBasedAutoScaling


        /// <summary>
        /// Specify the load-based auto scaling configuration for a specified layer. For more
        /// information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-autoscaling.html">Managing
        /// Load            with Time-based and Load-based Instances</a>.
        /// 
        ///   <note>      
        /// <para>
        /// To use load-based auto scaling, you must create a set of load-based auto scaling instances.
        ///        Load-based auto scaling operates only on the instances from that set, so you
        /// must ensure        that you have created enough instances to handle the maximum anticipated
        /// load.
        /// </para>
        ///     </note>    
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBasedAutoScaling service method.</param>
        /// 
        /// <returns>The response from the SetLoadBasedAutoScaling service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        SetLoadBasedAutoScalingResponse SetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest request);

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
        Task<SetLoadBasedAutoScalingResponse> SetLoadBasedAutoScalingAsync(SetLoadBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetPermission


        /// <summary>
        /// Specifies a user's permissions.  For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingsecurity.html">Security
        /// and Permissions</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetPermission service method.</param>
        /// 
        /// <returns>The response from the SetPermission service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        SetPermissionResponse SetPermission(SetPermissionRequest request);

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
        Task<SetPermissionResponse> SetPermissionAsync(SetPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetTimeBasedAutoScaling


        /// <summary>
        /// Specify the time-based auto scaling configuration for a specified instance. For more
        /// information,         see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-autoscaling.html">Managing
        /// Load            with Time-based and Load-based Instances</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTimeBasedAutoScaling service method.</param>
        /// 
        /// <returns>The response from the SetTimeBasedAutoScaling service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        SetTimeBasedAutoScalingResponse SetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest request);

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
        Task<SetTimeBasedAutoScalingResponse> SetTimeBasedAutoScalingAsync(SetTimeBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartInstance


        /// <summary>
        /// Starts a specified instance. For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-starting.html">Starting,
        /// Stopping,            and Rebooting Instances</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstance service method.</param>
        /// 
        /// <returns>The response from the StartInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        StartInstanceResponse StartInstance(StartInstanceRequest request);

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
        Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartStack


        /// <summary>
        /// Starts a stack's instances. 
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStack service method.</param>
        /// 
        /// <returns>The response from the StartStack service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        StartStackResponse StartStack(StartStackRequest request);

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
        Task<StartStackResponse> StartStackAsync(StartStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopInstance


        /// <summary>
        /// Stops a specified instance. When you stop a standard instance, the data disappears
        /// and must         be reinstalled when you restart the instance. You can stop an Amazon
        /// EBS-backed instance without losing data.         For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-starting.html">Starting,
        /// Stopping,            and Rebooting Instances</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInstance service method.</param>
        /// 
        /// <returns>The response from the StopInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        StopInstanceResponse StopInstance(StopInstanceRequest request);

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
        Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopStack


        /// <summary>
        /// Stops a specified stack.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStack service method.</param>
        /// 
        /// <returns>The response from the StopStack service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        StopStackResponse StopStack(StopStackRequest request);

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
        Task<StopStackResponse> StopStackAsync(StopStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UnassignVolume


        /// <summary>
        /// Unassigns an assigned Amazon EBS volume. The volume remains registered with the stack.
        /// For more information, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnassignVolume service method.</param>
        /// 
        /// <returns>The response from the UnassignVolume service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        UnassignVolumeResponse UnassignVolume(UnassignVolumeRequest request);

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
        Task<UnassignVolumeResponse> UnassignVolumeAsync(UnassignVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApp


        /// <summary>
        /// Updates a specified app.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Deploy or
        /// Manage permissions level for the stack,      or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp service method.</param>
        /// 
        /// <returns>The response from the UpdateApp service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateAppResponse UpdateApp(UpdateAppRequest request);

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
        Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateElasticIp


        /// <summary>
        /// Updates a registered Elastic IP address's name. For more information, see      <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticIp service method.</param>
        /// 
        /// <returns>The response from the UpdateElasticIp service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateElasticIpResponse UpdateElasticIp(UpdateElasticIpRequest request);

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
        Task<UpdateElasticIpResponse> UpdateElasticIpAsync(UpdateElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateInstance


        /// <summary>
        /// Updates a specified instance.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request);

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
        Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLayer


        /// <summary>
        /// Updates a specified layer.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLayer service method.</param>
        /// 
        /// <returns>The response from the UpdateLayer service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateLayerResponse UpdateLayer(UpdateLayerRequest request);

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
        Task<UpdateLayerResponse> UpdateLayerAsync(UpdateLayerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMyUserProfile

        /// <summary>
        /// Updates a user's SSH public key.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have self-management
        /// enabled or an attached       policy that explicitly grants permissions. For more information
        /// on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the UpdateMyUserProfile service method, as returned by OpsWorks.</returns>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateMyUserProfileResponse UpdateMyUserProfile();

        /// <summary>
        /// Updates a user's SSH public key.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have self-management
        /// enabled or an attached       policy that explicitly grants permissions. For more information
        /// on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMyUserProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateMyUserProfile service method, as returned by OpsWorks.</returns>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateMyUserProfileResponse UpdateMyUserProfile(UpdateMyUserProfileRequest request);

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
        Task<UpdateMyUserProfileResponse> UpdateMyUserProfileAsync(UpdateMyUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRdsDbInstance


        /// <summary>
        /// Updates an Amazon RDS instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRdsDbInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateRdsDbInstance service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateRdsDbInstanceResponse UpdateRdsDbInstance(UpdateRdsDbInstanceRequest request);

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
        Task<UpdateRdsDbInstanceResponse> UpdateRdsDbInstanceAsync(UpdateRdsDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateStack


        /// <summary>
        /// Updates a specified stack.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack service method.</param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateStackResponse UpdateStack(UpdateStackRequest request);

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
        Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserProfile


        /// <summary>
        /// Updates a specified user profile.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        ///       policy that explicitly grants permissions. For more information on user permissions,
        /// see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateUserProfile service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request);

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
        Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateVolume


        /// <summary>
        /// Updates an Amazon EBS volume's name or mount point. For more information, see    
        ///  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///     
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached       policy that explicitly grants permissions.
        /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVolume service method.</param>
        /// 
        /// <returns>The response from the UpdateVolume service method, as returned by OpsWorks.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateVolumeResponse UpdateVolume(UpdateVolumeRequest request);

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
        Task<UpdateVolumeResponse> UpdateVolumeAsync(UpdateVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}