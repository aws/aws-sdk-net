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
using System.Collections.Generic;

using Amazon.OpsWorks.Model;

namespace Amazon.OpsWorks
{
    /// <summary>
    /// Interface for accessing OpsWorks
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
    ///  <b>SDKs and CLI</b> 
    /// </para>
    ///  
    /// <para>
    /// The most common way to use the AWS OpsWorks API is by using the AWS Command Line Interface
    /// (CLI) or by using one of the AWS SDKs to implement applications in your preferred
    /// language. For more information, see:
    /// </para>
    ///  <ul> <li> <a href="http://docs.aws.amazon.com/cli/latest/userguide/cli-chap-welcome.html">AWS
    /// CLI</a> </li> <li> <a href="http://docs.aws.amazon.com/AWSJavaSDK/latest/javadoc/com/amazonaws/services/opsworks/AWSOpsWorksClient.html">AWS
    /// SDK for Java</a> </li> <li> <a href="http://docs.aws.amazon.com/sdkfornet/latest/apidocs/html/N_Amazon_OpsWorks.htm">AWS
    /// SDK for .NET</a> </li> <li> <a href="http://docs.aws.amazon.com/aws-sdk-php-2/latest/class-Aws.OpsWorks.OpsWorksClient.html">AWS
    /// SDK for PHP 2</a> </li> <li> <a href="http://docs.aws.amazon.com/AWSRubySDK/latest/AWS/OpsWorks/Client.html">AWS
    /// SDK for Ruby</a> </li> <li> <a href="http://aws.amazon.com/documentation/sdkforjavascript/">AWS
    /// SDK for Node.js</a> </li> <li> <a href="http://docs.pythonboto.org/en/latest/ref/opsworks.html">AWS
    /// SDK for Python(Boto)</a> </li> </ul> 
    /// <para>
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// AWS OpsWorks supports only one endpoint, opsworks.us-east-1.amazonaws.com (HTTPS),
    /// so you must connect to that endpoint. You can then use the API to direct AWS OpsWorks
    /// to create stacks in any AWS Region.
    /// </para>
    ///  
    /// <para>
    ///  <b>Chef Versions</b> 
    /// </para>
    ///  
    /// <para>
    /// When you call <a>CreateStack</a>, <a>CloneStack</a>, or <a>UpdateStack</a> we recommend
    /// you use the <code>ConfigurationManager</code> parameter to specify the Chef version,
    /// 0.9, 11.4, or 11.10. The default value is currently 11.10. For more information, see
    /// <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook-chef11.html">Chef
    /// Versions</a>.
    /// </para>
    ///  <note>You can still specify Chef 0.9 for your stack, but new features are not available
    /// for Chef 0.9 stacks, and support is scheduled to end on July 24, 2014. We do not recommend
    /// using Chef 0.9 for new stacks, and we recommend migrating your existing Chef 0.9 stacks
    /// to Chef 11.10 as soon as possible.</note>
    /// </summary>
    public partial interface IAmazonOpsWorks : IDisposable
    {

        
        #region  AssignInstance

        /// <summary>
        /// Assign a registered instance to a layer.
        /// 
        ///  <ul> <li>You can assign registered on-premises instances to any layer type.</li>
        /// <li>You can assign registered Amazon EC2 instances only to custom layers.</li> <li>You
        /// cannot use this action with instances that were created with AWS OpsWorks.</li> </ul>
        /// 
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
        /// level for the stack or an attached policy that explicitly grants permissions. For
        /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
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
        /// Indicates that a request was invalid.
        /// </exception>
        AssignInstanceResponse AssignInstance(AssignInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssignInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssignInstance
        ///         operation.</returns>
        IAsyncResult BeginAssignInstance(AssignInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssignInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssignInstance.</param>
        /// 
        /// <returns>Returns a  AssignInstanceResult from OpsWorks.</returns>
        AssignInstanceResponse EndAssignInstance(IAsyncResult asyncResult);

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
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        AssignVolumeResponse AssignVolume(AssignVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssignVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignVolume operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssignVolume
        ///         operation.</returns>
        IAsyncResult BeginAssignVolume(AssignVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssignVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssignVolume.</param>
        /// 
        /// <returns>Returns a  AssignVolumeResult from OpsWorks.</returns>
        AssignVolumeResponse EndAssignVolume(IAsyncResult asyncResult);

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
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        AssociateElasticIpResponse AssociateElasticIp(AssociateElasticIpRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateElasticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateElasticIp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateElasticIp
        ///         operation.</returns>
        IAsyncResult BeginAssociateElasticIp(AssociateElasticIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateElasticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateElasticIp.</param>
        /// 
        /// <returns>Returns a  AssociateElasticIpResult from OpsWorks.</returns>
        AssociateElasticIpResponse EndAssociateElasticIp(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachElasticLoadBalancer

        /// <summary>
        /// Attaches an Elastic Load Balancing load balancer to a specified layer. For more information,
        /// see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/load-balancer-elb.html">Elastic
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
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        AttachElasticLoadBalancerResponse AttachElasticLoadBalancer(AttachElasticLoadBalancerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachElasticLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachElasticLoadBalancer operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachElasticLoadBalancer
        ///         operation.</returns>
        IAsyncResult BeginAttachElasticLoadBalancer(AttachElasticLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachElasticLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachElasticLoadBalancer.</param>
        /// 
        /// <returns>Returns a  AttachElasticLoadBalancerResult from OpsWorks.</returns>
        AttachElasticLoadBalancerResponse EndAttachElasticLoadBalancer(IAsyncResult asyncResult);

        #endregion
        
        #region  CloneStack

        /// <summary>
        /// Creates a clone of a specified stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-cloning.html">Clone
        /// a Stack</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have an attached
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
        /// Indicates that a request was invalid.
        /// </exception>
        CloneStackResponse CloneStack(CloneStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CloneStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloneStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCloneStack
        ///         operation.</returns>
        IAsyncResult BeginCloneStack(CloneStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CloneStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCloneStack.</param>
        /// 
        /// <returns>Returns a  CloneStackResult from OpsWorks.</returns>
        CloneStackResponse EndCloneStack(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApp

        /// <summary>
        /// Creates an app for a specified stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-creating.html">Creating
        /// Apps</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        CreateAppResponse CreateApp(CreateAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApp
        ///         operation.</returns>
        IAsyncResult BeginCreateApp(CreateAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApp.</param>
        /// 
        /// <returns>Returns a  CreateAppResult from OpsWorks.</returns>
        CreateAppResponse EndCreateApp(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDeployment

        /// <summary>
        /// Runs deployment or stack commands. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-deploying.html">Deploying
        /// Apps</a> and <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-commands.html">Run
        /// Stack Commands</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Deploy or
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
        /// Indicates that a request was invalid.
        /// </exception>
        CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeployment
        ///         operation.</returns>
        IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from OpsWorks.</returns>
        CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInstance

        /// <summary>
        /// Creates an instance in a specified stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-add.html">Adding
        /// an Instance to a Layer</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        CreateInstanceResponse CreateInstance(CreateInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstance
        ///         operation.</returns>
        IAsyncResult BeginCreateInstance(CreateInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstance.</param>
        /// 
        /// <returns>Returns a  CreateInstanceResult from OpsWorks.</returns>
        CreateInstanceResponse EndCreateInstance(IAsyncResult asyncResult);

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
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        CreateLayerResponse CreateLayer(CreateLayerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLayer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLayer operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLayer
        ///         operation.</returns>
        IAsyncResult BeginCreateLayer(CreateLayerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLayer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLayer.</param>
        /// 
        /// <returns>Returns a  CreateLayerResult from OpsWorks.</returns>
        CreateLayerResponse EndCreateLayer(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStack

        /// <summary>
        /// Creates a new stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-edit.html">Create
        /// a New Stack</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        /// policy that explicitly grants permissions. For more information on user permissions,
        /// see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStack service method.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        CreateStackResponse CreateStack(CreateStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStack
        ///         operation.</returns>
        IAsyncResult BeginCreateStack(CreateStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStack.</param>
        /// 
        /// <returns>Returns a  CreateStackResult from OpsWorks.</returns>
        CreateStackResponse EndCreateStack(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUserProfile

        /// <summary>
        /// Creates a new user profile.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        /// policy that explicitly grants permissions. For more information on user permissions,
        /// see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile service method.</param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserProfile
        ///         operation.</returns>
        IAsyncResult BeginCreateUserProfile(CreateUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserProfile.</param>
        /// 
        /// <returns>Returns a  CreateUserProfileResult from OpsWorks.</returns>
        CreateUserProfileResponse EndCreateUserProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApp

        /// <summary>
        /// Deletes a specified app.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        DeleteAppResponse DeleteApp(DeleteAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApp
        ///         operation.</returns>
        IAsyncResult BeginDeleteApp(DeleteAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        /// 
        /// <returns>Returns a  DeleteAppResult from OpsWorks.</returns>
        DeleteAppResponse EndDeleteApp(IAsyncResult asyncResult);

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
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstance
        ///         operation.</returns>
        IAsyncResult BeginDeleteInstance(DeleteInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstance.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceResult from OpsWorks.</returns>
        DeleteInstanceResponse EndDeleteInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLayer

        /// <summary>
        /// Deletes a specified layer. You must first stop and then delete all associated instances
        /// or unassign registered instances. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-delete.html">How
        /// to Delete a Layer</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        DeleteLayerResponse DeleteLayer(DeleteLayerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLayer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayer operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLayer
        ///         operation.</returns>
        IAsyncResult BeginDeleteLayer(DeleteLayerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLayer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLayer.</param>
        /// 
        /// <returns>Returns a  DeleteLayerResult from OpsWorks.</returns>
        DeleteLayerResponse EndDeleteLayer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStack

        /// <summary>
        /// Deletes a specified stack. You must first delete all instances, layers, and apps or
        /// deregister registered instances. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-shutting.html">Shut
        /// Down a Stack</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        DeleteStackResponse DeleteStack(DeleteStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStack
        ///         operation.</returns>
        IAsyncResult BeginDeleteStack(DeleteStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStack.</param>
        /// 
        /// <returns>Returns a  DeleteStackResult from OpsWorks.</returns>
        DeleteStackResponse EndDeleteStack(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUserProfile

        /// <summary>
        /// Deletes a user profile.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have an attached
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
        /// Indicates that a request was invalid.
        /// </exception>
        DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserProfile
        ///         operation.</returns>
        IAsyncResult BeginDeleteUserProfile(DeleteUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserProfile.</param>
        /// 
        /// <returns>Returns a  DeleteUserProfileResult from OpsWorks.</returns>
        DeleteUserProfileResponse EndDeleteUserProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterElasticIp

        /// <summary>
        /// Deregisters a specified Elastic IP address. The address can then be registered by
        /// another stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        DeregisterElasticIpResponse DeregisterElasticIp(DeregisterElasticIpRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterElasticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterElasticIp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterElasticIp
        ///         operation.</returns>
        IAsyncResult BeginDeregisterElasticIp(DeregisterElasticIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterElasticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterElasticIp.</param>
        /// 
        /// <returns>Returns a  DeregisterElasticIpResult from OpsWorks.</returns>
        DeregisterElasticIpResponse EndDeregisterElasticIp(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterInstance

        /// <summary>
        /// Deregister a registered Amazon EC2 or on-premises instance. This action removes the
        /// instance from the stack and returns it to your control. This action can not be used
        /// with instances that were created with AWS OpsWorks.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        DeregisterInstanceResponse DeregisterInstance(DeregisterInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterInstance
        ///         operation.</returns>
        IAsyncResult BeginDeregisterInstance(DeregisterInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterInstance.</param>
        /// 
        /// <returns>Returns a  DeregisterInstanceResult from OpsWorks.</returns>
        DeregisterInstanceResponse EndDeregisterInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterRdsDbInstance

        /// <summary>
        /// Deregisters an Amazon RDS instance.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        DeregisterRdsDbInstanceResponse DeregisterRdsDbInstance(DeregisterRdsDbInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterRdsDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterRdsDbInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterRdsDbInstance
        ///         operation.</returns>
        IAsyncResult BeginDeregisterRdsDbInstance(DeregisterRdsDbInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterRdsDbInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterRdsDbInstance.</param>
        /// 
        /// <returns>Returns a  DeregisterRdsDbInstanceResult from OpsWorks.</returns>
        DeregisterRdsDbInstanceResponse EndDeregisterRdsDbInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterVolume

        /// <summary>
        /// Deregisters an Amazon EBS volume. The volume can then be registered by another stack.
        /// For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        DeregisterVolumeResponse DeregisterVolume(DeregisterVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterVolume operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterVolume
        ///         operation.</returns>
        IAsyncResult BeginDeregisterVolume(DeregisterVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterVolume.</param>
        /// 
        /// <returns>Returns a  DeregisterVolumeResult from OpsWorks.</returns>
        DeregisterVolumeResponse EndDeregisterVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApps

        /// <summary>
        /// Requests a description of a specified set of apps.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///  </note> 
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeAppsResponse DescribeApps(DescribeAppsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApps operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApps
        ///         operation.</returns>
        IAsyncResult BeginDescribeApps(DescribeAppsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApps.</param>
        /// 
        /// <returns>Returns a  DescribeAppsResult from OpsWorks.</returns>
        DescribeAppsResponse EndDescribeApps(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCommands

        /// <summary>
        /// Describes the results of specified commands.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///  </note> 
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeCommandsResponse DescribeCommands(DescribeCommandsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCommands operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommands operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCommands
        ///         operation.</returns>
        IAsyncResult BeginDescribeCommands(DescribeCommandsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCommands operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCommands.</param>
        /// 
        /// <returns>Returns a  DescribeCommandsResult from OpsWorks.</returns>
        DescribeCommandsResponse EndDescribeCommands(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDeployments

        /// <summary>
        /// Requests a description of a specified set of deployments.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///  </note> 
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeDeploymentsResponse DescribeDeployments(DescribeDeploymentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeployments operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeployments
        ///         operation.</returns>
        IAsyncResult BeginDescribeDeployments(DescribeDeploymentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeployments.</param>
        /// 
        /// <returns>Returns a  DescribeDeploymentsResult from OpsWorks.</returns>
        DescribeDeploymentsResponse EndDescribeDeployments(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeElasticIps

        /// <summary>
        /// Describes <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP addresses</a>.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///  </note> 
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeElasticIpsResponse DescribeElasticIps(DescribeElasticIpsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticIps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticIps operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticIps
        ///         operation.</returns>
        IAsyncResult BeginDescribeElasticIps(DescribeElasticIpsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticIps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticIps.</param>
        /// 
        /// <returns>Returns a  DescribeElasticIpsResult from OpsWorks.</returns>
        DescribeElasticIpsResponse EndDescribeElasticIps(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeElasticLoadBalancers

        /// <summary>
        /// Describes a stack's Elastic Load Balancing instances.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///  </note> 
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers();

        /// <summary>
        /// Describes a stack's Elastic Load Balancing instances.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///  </note> 
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers(DescribeElasticLoadBalancersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticLoadBalancers operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticLoadBalancers
        ///         operation.</returns>
        IAsyncResult BeginDescribeElasticLoadBalancers(DescribeElasticLoadBalancersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticLoadBalancers.</param>
        /// 
        /// <returns>Returns a  DescribeElasticLoadBalancersResult from OpsWorks.</returns>
        DescribeElasticLoadBalancersResponse EndDescribeElasticLoadBalancers(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInstances

        /// <summary>
        /// Requests a description of a set of instances.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///  </note> 
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstances
        ///         operation.</returns>
        IAsyncResult BeginDescribeInstances(DescribeInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstances.</param>
        /// 
        /// <returns>Returns a  DescribeInstancesResult from OpsWorks.</returns>
        DescribeInstancesResponse EndDescribeInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLayers

        /// <summary>
        /// Requests a description of one or more layers in a specified stack.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///  </note> 
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeLayersResponse DescribeLayers(DescribeLayersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLayers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLayers operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLayers
        ///         operation.</returns>
        IAsyncResult BeginDescribeLayers(DescribeLayersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLayers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLayers.</param>
        /// 
        /// <returns>Returns a  DescribeLayersResult from OpsWorks.</returns>
        DescribeLayersResponse EndDescribeLayers(IAsyncResult asyncResult);

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
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeLoadBasedAutoScalingResponse DescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBasedAutoScaling operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoadBasedAutoScaling
        ///         operation.</returns>
        IAsyncResult BeginDescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBasedAutoScalingResult from OpsWorks.</returns>
        DescribeLoadBasedAutoScalingResponse EndDescribeLoadBasedAutoScaling(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMyUserProfile

        /// <summary>
        /// Describes a user's SSH information.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have self-management
        /// enabled or an attached policy that explicitly grants permissions. For more information
        /// on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
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
        /// enabled or an attached policy that explicitly grants permissions. For more information
        /// on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMyUserProfile service method.</param>
        /// 
        /// <returns>The response from the DescribeMyUserProfile service method, as returned by OpsWorks.</returns>
        DescribeMyUserProfileResponse DescribeMyUserProfile(DescribeMyUserProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMyUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMyUserProfile operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMyUserProfile
        ///         operation.</returns>
        IAsyncResult BeginDescribeMyUserProfile(DescribeMyUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMyUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMyUserProfile.</param>
        /// 
        /// <returns>Returns a  DescribeMyUserProfileResult from OpsWorks.</returns>
        DescribeMyUserProfileResponse EndDescribeMyUserProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePermissions

        /// <summary>
        /// Describes the permissions for a specified stack.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribePermissionsResponse DescribePermissions(DescribePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissions operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePermissions
        ///         operation.</returns>
        IAsyncResult BeginDescribePermissions(DescribePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePermissions.</param>
        /// 
        /// <returns>Returns a  DescribePermissionsResult from OpsWorks.</returns>
        DescribePermissionsResponse EndDescribePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRaidArrays

        /// <summary>
        /// Describe an instance's RAID arrays.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///  </note> 
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeRaidArraysResponse DescribeRaidArrays(DescribeRaidArraysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRaidArrays operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRaidArrays operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRaidArrays
        ///         operation.</returns>
        IAsyncResult BeginDescribeRaidArrays(DescribeRaidArraysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRaidArrays operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRaidArrays.</param>
        /// 
        /// <returns>Returns a  DescribeRaidArraysResult from OpsWorks.</returns>
        DescribeRaidArraysResponse EndDescribeRaidArrays(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRdsDbInstances

        /// <summary>
        /// Describes Amazon RDS instances.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRdsDbInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeRdsDbInstances service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeRdsDbInstancesResponse DescribeRdsDbInstances(DescribeRdsDbInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRdsDbInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRdsDbInstances operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRdsDbInstances
        ///         operation.</returns>
        IAsyncResult BeginDescribeRdsDbInstances(DescribeRdsDbInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRdsDbInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRdsDbInstances.</param>
        /// 
        /// <returns>Returns a  DescribeRdsDbInstancesResult from OpsWorks.</returns>
        DescribeRdsDbInstancesResponse EndDescribeRdsDbInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeServiceErrors

        /// <summary>
        /// Describes AWS OpsWorks service errors.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeServiceErrors service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeServiceErrorsResponse DescribeServiceErrors();

        /// <summary>
        /// Describes AWS OpsWorks service errors.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceErrors service method.</param>
        /// 
        /// <returns>The response from the DescribeServiceErrors service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeServiceErrorsResponse DescribeServiceErrors(DescribeServiceErrorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceErrors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceErrors operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServiceErrors
        ///         operation.</returns>
        IAsyncResult BeginDescribeServiceErrors(DescribeServiceErrorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServiceErrors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceErrors.</param>
        /// 
        /// <returns>Returns a  DescribeServiceErrorsResult from OpsWorks.</returns>
        DescribeServiceErrorsResponse EndDescribeServiceErrors(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStackProvisioningParameters

        /// <summary>
        /// Requests a description of a stack's provisioning parameters.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeStackProvisioningParametersResponse DescribeStackProvisioningParameters(DescribeStackProvisioningParametersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackProvisioningParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackProvisioningParameters operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackProvisioningParameters
        ///         operation.</returns>
        IAsyncResult BeginDescribeStackProvisioningParameters(DescribeStackProvisioningParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackProvisioningParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackProvisioningParameters.</param>
        /// 
        /// <returns>Returns a  DescribeStackProvisioningParametersResult from OpsWorks.</returns>
        DescribeStackProvisioningParametersResponse EndDescribeStackProvisioningParameters(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStacks

        /// <summary>
        /// Requests a description of one or more stacks.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeStacksResponse DescribeStacks();

        /// <summary>
        /// Requests a description of one or more stacks.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeStacksResponse DescribeStacks(DescribeStacksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStacks
        ///         operation.</returns>
        IAsyncResult BeginDescribeStacks(DescribeStacksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStacks.</param>
        /// 
        /// <returns>Returns a  DescribeStacksResult from OpsWorks.</returns>
        DescribeStacksResponse EndDescribeStacks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStackSummary

        /// <summary>
        /// Describes the number of layers and apps in a specified stack, and the number of instances
        /// in each state, such as <code>running_setup</code> or <code>online</code>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeStackSummaryResponse DescribeStackSummary(DescribeStackSummaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSummary operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackSummary
        ///         operation.</returns>
        IAsyncResult BeginDescribeStackSummary(DescribeStackSummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackSummary.</param>
        /// 
        /// <returns>Returns a  DescribeStackSummaryResult from OpsWorks.</returns>
        DescribeStackSummaryResponse EndDescribeStackSummary(IAsyncResult asyncResult);

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
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeTimeBasedAutoScalingResponse DescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTimeBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTimeBasedAutoScaling operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTimeBasedAutoScaling
        ///         operation.</returns>
        IAsyncResult BeginDescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTimeBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTimeBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a  DescribeTimeBasedAutoScalingResult from OpsWorks.</returns>
        DescribeTimeBasedAutoScalingResponse EndDescribeTimeBasedAutoScaling(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeUserProfiles

        /// <summary>
        /// Describe specified users.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have an attached
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeUserProfilesResponse DescribeUserProfiles();

        /// <summary>
        /// Describe specified users.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have an attached
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeUserProfilesResponse DescribeUserProfiles(DescribeUserProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfiles operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUserProfiles
        ///         operation.</returns>
        IAsyncResult BeginDescribeUserProfiles(DescribeUserProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserProfiles.</param>
        /// 
        /// <returns>Returns a  DescribeUserProfilesResult from OpsWorks.</returns>
        DescribeUserProfilesResponse EndDescribeUserProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVolumes

        /// <summary>
        /// Describes an instance's Amazon EBS volumes.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify at least one of the parameters.
        /// </para>
        ///  </note> 
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
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
        /// Indicates that a request was invalid.
        /// </exception>
        DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVolumes
        ///         operation.</returns>
        IAsyncResult BeginDescribeVolumes(DescribeVolumesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVolumes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumes.</param>
        /// 
        /// <returns>Returns a  DescribeVolumesResult from OpsWorks.</returns>
        DescribeVolumesResponse EndDescribeVolumes(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachElasticLoadBalancer

        /// <summary>
        /// Detaches a specified Elastic Load Balancing instance from its layer.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        DetachElasticLoadBalancerResponse DetachElasticLoadBalancer(DetachElasticLoadBalancerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachElasticLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachElasticLoadBalancer operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachElasticLoadBalancer
        ///         operation.</returns>
        IAsyncResult BeginDetachElasticLoadBalancer(DetachElasticLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachElasticLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachElasticLoadBalancer.</param>
        /// 
        /// <returns>Returns a  DetachElasticLoadBalancerResult from OpsWorks.</returns>
        DetachElasticLoadBalancerResponse EndDetachElasticLoadBalancer(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateElasticIp

        /// <summary>
        /// Disassociates an Elastic IP address from its instance. The address remains registered
        /// with the stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        DisassociateElasticIpResponse DisassociateElasticIp(DisassociateElasticIpRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateElasticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateElasticIp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateElasticIp
        ///         operation.</returns>
        IAsyncResult BeginDisassociateElasticIp(DisassociateElasticIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateElasticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateElasticIp.</param>
        /// 
        /// <returns>Returns a  DisassociateElasticIpResult from OpsWorks.</returns>
        DisassociateElasticIpResponse EndDisassociateElasticIp(IAsyncResult asyncResult);

        #endregion
        
        #region  GetHostnameSuggestion

        /// <summary>
        /// Gets a generated host name for the specified layer, based on the current host name
        /// theme.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        GetHostnameSuggestionResponse GetHostnameSuggestion(GetHostnameSuggestionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostnameSuggestion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostnameSuggestion operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHostnameSuggestion
        ///         operation.</returns>
        IAsyncResult BeginGetHostnameSuggestion(GetHostnameSuggestionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHostnameSuggestion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHostnameSuggestion.</param>
        /// 
        /// <returns>Returns a  GetHostnameSuggestionResult from OpsWorks.</returns>
        GetHostnameSuggestionResponse EndGetHostnameSuggestion(IAsyncResult asyncResult);

        #endregion
        
        #region  GrantAccess

        /// <summary>
        /// <note>This API can be used only with Windows stacks.</note> 
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
        /// Indicates that a request was invalid.
        /// </exception>
        GrantAccessResponse GrantAccess(GrantAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GrantAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GrantAccess operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGrantAccess
        ///         operation.</returns>
        IAsyncResult BeginGrantAccess(GrantAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GrantAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGrantAccess.</param>
        /// 
        /// <returns>Returns a  GrantAccessResult from OpsWorks.</returns>
        GrantAccessResponse EndGrantAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  RebootInstance

        /// <summary>
        /// Reboots a specified instance. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-starting.html">Starting,
        /// Stopping, and Rebooting Instances</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        RebootInstanceResponse RebootInstance(RebootInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootInstance
        ///         operation.</returns>
        IAsyncResult BeginRebootInstance(RebootInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootInstance.</param>
        /// 
        /// <returns>Returns a  RebootInstanceResult from OpsWorks.</returns>
        RebootInstanceResponse EndRebootInstance(IAsyncResult asyncResult);

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
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        RegisterElasticIpResponse RegisterElasticIp(RegisterElasticIpRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterElasticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterElasticIp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterElasticIp
        ///         operation.</returns>
        IAsyncResult BeginRegisterElasticIp(RegisterElasticIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterElasticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterElasticIp.</param>
        /// 
        /// <returns>Returns a  RegisterElasticIpResult from OpsWorks.</returns>
        RegisterElasticIpResponse EndRegisterElasticIp(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterInstance

        /// <summary>
        /// Registers instances with a specified stack that were created outside of AWS OpsWorks.
        /// 
        ///  <note>We do not recommend using this action to register instances. The complete registration
        /// operation has two primary steps, installing the AWS OpsWorks agent on the instance
        /// and registering the instance with the stack. <code>RegisterInstance</code> handles
        /// only the second step. You should instead use the AWS CLI <code>register</code> command,
        /// which performs the entire registration operation.</note> 
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        RegisterInstanceResponse RegisterInstance(RegisterInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterInstance
        ///         operation.</returns>
        IAsyncResult BeginRegisterInstance(RegisterInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterInstance.</param>
        /// 
        /// <returns>Returns a  RegisterInstanceResult from OpsWorks.</returns>
        RegisterInstanceResponse EndRegisterInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterRdsDbInstance

        /// <summary>
        /// Registers an Amazon RDS instance with a stack.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        RegisterRdsDbInstanceResponse RegisterRdsDbInstance(RegisterRdsDbInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterRdsDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterRdsDbInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterRdsDbInstance
        ///         operation.</returns>
        IAsyncResult BeginRegisterRdsDbInstance(RegisterRdsDbInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterRdsDbInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterRdsDbInstance.</param>
        /// 
        /// <returns>Returns a  RegisterRdsDbInstanceResult from OpsWorks.</returns>
        RegisterRdsDbInstanceResponse EndRegisterRdsDbInstance(IAsyncResult asyncResult);

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
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        RegisterVolumeResponse RegisterVolume(RegisterVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterVolume operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterVolume
        ///         operation.</returns>
        IAsyncResult BeginRegisterVolume(RegisterVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterVolume.</param>
        /// 
        /// <returns>Returns a  RegisterVolumeResult from OpsWorks.</returns>
        RegisterVolumeResponse EndRegisterVolume(IAsyncResult asyncResult);

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
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        SetLoadBasedAutoScalingResponse SetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBasedAutoScaling operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetLoadBasedAutoScaling
        ///         operation.</returns>
        IAsyncResult BeginSetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetLoadBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a  SetLoadBasedAutoScalingResult from OpsWorks.</returns>
        SetLoadBasedAutoScalingResponse EndSetLoadBasedAutoScaling(IAsyncResult asyncResult);

        #endregion
        
        #region  SetPermission

        /// <summary>
        /// Specifies a user's permissions. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingsecurity.html">Security
        /// and Permissions</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        SetPermissionResponse SetPermission(SetPermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetPermission operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetPermission
        ///         operation.</returns>
        IAsyncResult BeginSetPermission(SetPermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetPermission.</param>
        /// 
        /// <returns>Returns a  SetPermissionResult from OpsWorks.</returns>
        SetPermissionResponse EndSetPermission(IAsyncResult asyncResult);

        #endregion
        
        #region  SetTimeBasedAutoScaling

        /// <summary>
        /// Specify the time-based auto scaling configuration for a specified instance. For more
        /// information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-autoscaling.html">Managing
        /// Load with Time-based and Load-based Instances</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        SetTimeBasedAutoScalingResponse SetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetTimeBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTimeBasedAutoScaling operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTimeBasedAutoScaling
        ///         operation.</returns>
        IAsyncResult BeginSetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetTimeBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTimeBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a  SetTimeBasedAutoScalingResult from OpsWorks.</returns>
        SetTimeBasedAutoScalingResponse EndSetTimeBasedAutoScaling(IAsyncResult asyncResult);

        #endregion
        
        #region  StartInstance

        /// <summary>
        /// Starts a specified instance. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-starting.html">Starting,
        /// Stopping, and Rebooting Instances</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        StartInstanceResponse StartInstance(StartInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInstance
        ///         operation.</returns>
        IAsyncResult BeginStartInstance(StartInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstance.</param>
        /// 
        /// <returns>Returns a  StartInstanceResult from OpsWorks.</returns>
        StartInstanceResponse EndStartInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  StartStack

        /// <summary>
        /// Starts a stack's instances. 
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        StartStackResponse StartStack(StartStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartStack
        ///         operation.</returns>
        IAsyncResult BeginStartStack(StartStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartStack.</param>
        /// 
        /// <returns>Returns a  StartStackResult from OpsWorks.</returns>
        StartStackResponse EndStartStack(IAsyncResult asyncResult);

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
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        StopInstanceResponse StopInstance(StopInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopInstance
        ///         operation.</returns>
        IAsyncResult BeginStopInstance(StopInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInstance.</param>
        /// 
        /// <returns>Returns a  StopInstanceResult from OpsWorks.</returns>
        StopInstanceResponse EndStopInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  StopStack

        /// <summary>
        /// Stops a specified stack.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        StopStackResponse StopStack(StopStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopStack
        ///         operation.</returns>
        IAsyncResult BeginStopStack(StopStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopStack.</param>
        /// 
        /// <returns>Returns a  StopStackResult from OpsWorks.</returns>
        StopStackResponse EndStopStack(IAsyncResult asyncResult);

        #endregion
        
        #region  UnassignInstance

        /// <summary>
        /// Unassigns a registered instance from all of it's layers. The instance remains in the
        /// stack as an unassigned instance and can be assigned to another layer, as needed. You
        /// cannot use this action with instances that were created with AWS OpsWorks.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        UnassignInstanceResponse UnassignInstance(UnassignInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UnassignInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnassignInstance
        ///         operation.</returns>
        IAsyncResult BeginUnassignInstance(UnassignInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnassignInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnassignInstance.</param>
        /// 
        /// <returns>Returns a  UnassignInstanceResult from OpsWorks.</returns>
        UnassignInstanceResponse EndUnassignInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  UnassignVolume

        /// <summary>
        /// Unassigns an assigned Amazon EBS volume. The volume remains registered with the stack.
        /// For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        UnassignVolumeResponse UnassignVolume(UnassignVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UnassignVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignVolume operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnassignVolume
        ///         operation.</returns>
        IAsyncResult BeginUnassignVolume(UnassignVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnassignVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnassignVolume.</param>
        /// 
        /// <returns>Returns a  UnassignVolumeResult from OpsWorks.</returns>
        UnassignVolumeResponse EndUnassignVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApp

        /// <summary>
        /// Updates a specified app.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Deploy or
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
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateAppResponse UpdateApp(UpdateAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApp
        ///         operation.</returns>
        IAsyncResult BeginUpdateApp(UpdateAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApp.</param>
        /// 
        /// <returns>Returns a  UpdateAppResult from OpsWorks.</returns>
        UpdateAppResponse EndUpdateApp(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateElasticIp

        /// <summary>
        /// Updates a registered Elastic IP address's name. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateElasticIpResponse UpdateElasticIp(UpdateElasticIpRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateElasticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticIp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateElasticIp
        ///         operation.</returns>
        IAsyncResult BeginUpdateElasticIp(UpdateElasticIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateElasticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateElasticIp.</param>
        /// 
        /// <returns>Returns a  UpdateElasticIpResult from OpsWorks.</returns>
        UpdateElasticIpResponse EndUpdateElasticIp(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateInstance

        /// <summary>
        /// Updates a specified instance.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInstance
        ///         operation.</returns>
        IAsyncResult BeginUpdateInstance(UpdateInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstance.</param>
        /// 
        /// <returns>Returns a  UpdateInstanceResult from OpsWorks.</returns>
        UpdateInstanceResponse EndUpdateInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLayer

        /// <summary>
        /// Updates a specified layer.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateLayerResponse UpdateLayer(UpdateLayerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLayer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLayer operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLayer
        ///         operation.</returns>
        IAsyncResult BeginUpdateLayer(UpdateLayerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLayer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLayer.</param>
        /// 
        /// <returns>Returns a  UpdateLayerResult from OpsWorks.</returns>
        UpdateLayerResponse EndUpdateLayer(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMyUserProfile

        /// <summary>
        /// Updates a user's SSH public key.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have self-management
        /// enabled or an attached policy that explicitly grants permissions. For more information
        /// on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the UpdateMyUserProfile service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateMyUserProfileResponse UpdateMyUserProfile();

        /// <summary>
        /// Updates a user's SSH public key.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have self-management
        /// enabled or an attached policy that explicitly grants permissions. For more information
        /// on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMyUserProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateMyUserProfile service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateMyUserProfileResponse UpdateMyUserProfile(UpdateMyUserProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMyUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMyUserProfile operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMyUserProfile
        ///         operation.</returns>
        IAsyncResult BeginUpdateMyUserProfile(UpdateMyUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMyUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMyUserProfile.</param>
        /// 
        /// <returns>Returns a  UpdateMyUserProfileResult from OpsWorks.</returns>
        UpdateMyUserProfileResponse EndUpdateMyUserProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRdsDbInstance

        /// <summary>
        /// Updates an Amazon RDS instance.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateRdsDbInstanceResponse UpdateRdsDbInstance(UpdateRdsDbInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRdsDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRdsDbInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRdsDbInstance
        ///         operation.</returns>
        IAsyncResult BeginUpdateRdsDbInstance(UpdateRdsDbInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRdsDbInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRdsDbInstance.</param>
        /// 
        /// <returns>Returns a  UpdateRdsDbInstanceResult from OpsWorks.</returns>
        UpdateRdsDbInstanceResponse EndUpdateRdsDbInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStack

        /// <summary>
        /// Updates a specified stack.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateStackResponse UpdateStack(UpdateStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStack
        ///         operation.</returns>
        IAsyncResult BeginUpdateStack(UpdateStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStack.</param>
        /// 
        /// <returns>Returns a  UpdateStackResult from OpsWorks.</returns>
        UpdateStackResponse EndUpdateStack(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUserProfile

        /// <summary>
        /// Updates a specified user profile.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have an attached
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
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserProfile
        ///         operation.</returns>
        IAsyncResult BeginUpdateUserProfile(UpdateUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserProfile.</param>
        /// 
        /// <returns>Returns a  UpdateUserProfileResult from OpsWorks.</returns>
        UpdateUserProfileResponse EndUpdateUserProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVolume

        /// <summary>
        /// Updates an Amazon EBS volume's name or mount point. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
        /// Management</a>.
        /// 
        ///  
        /// <para>
        /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
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
        /// Indicates that a request was invalid.
        /// </exception>
        UpdateVolumeResponse UpdateVolume(UpdateVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVolume operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVolume
        ///         operation.</returns>
        IAsyncResult BeginUpdateVolume(UpdateVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVolume.</param>
        /// 
        /// <returns>Returns a  UpdateVolumeResult from OpsWorks.</returns>
        UpdateVolumeResponse EndUpdateVolume(IAsyncResult asyncResult);

        #endregion
        
    }
}