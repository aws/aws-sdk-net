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
        /// <param name="request">Container for the necessary parameters to execute the AssignInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssignInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssignInstance">REST API Reference for AssignInstance Operation</seealso>
        IAsyncResult BeginAssignInstance(AssignInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssignInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssignInstance.</param>
        /// 
        /// <returns>Returns a  AssignInstanceResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssignInstance">REST API Reference for AssignInstance Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the AssignVolume operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssignVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssignVolume">REST API Reference for AssignVolume Operation</seealso>
        IAsyncResult BeginAssignVolume(AssignVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssignVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssignVolume.</param>
        /// 
        /// <returns>Returns a  AssignVolumeResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssignVolume">REST API Reference for AssignVolume Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the AssociateElasticIp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateElasticIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssociateElasticIp">REST API Reference for AssociateElasticIp Operation</seealso>
        IAsyncResult BeginAssociateElasticIp(AssociateElasticIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateElasticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateElasticIp.</param>
        /// 
        /// <returns>Returns a  AssociateElasticIpResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssociateElasticIp">REST API Reference for AssociateElasticIp Operation</seealso>
        AssociateElasticIpResponse EndAssociateElasticIp(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the AttachElasticLoadBalancer operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachElasticLoadBalancer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AttachElasticLoadBalancer">REST API Reference for AttachElasticLoadBalancer Operation</seealso>
        IAsyncResult BeginAttachElasticLoadBalancer(AttachElasticLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachElasticLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachElasticLoadBalancer.</param>
        /// 
        /// <returns>Returns a  AttachElasticLoadBalancerResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AttachElasticLoadBalancer">REST API Reference for AttachElasticLoadBalancer Operation</seealso>
        AttachElasticLoadBalancerResponse EndAttachElasticLoadBalancer(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the CloneStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCloneStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CloneStack">REST API Reference for CloneStack Operation</seealso>
        IAsyncResult BeginCloneStack(CloneStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CloneStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCloneStack.</param>
        /// 
        /// <returns>Returns a  CloneStackResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CloneStack">REST API Reference for CloneStack Operation</seealso>
        CloneStackResponse EndCloneStack(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateApp">REST API Reference for CreateApp Operation</seealso>
        IAsyncResult BeginCreateApp(CreateAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApp.</param>
        /// 
        /// <returns>Returns a  CreateAppResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateApp">REST API Reference for CreateApp Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        IAsyncResult BeginCreateInstance(CreateInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstance.</param>
        /// 
        /// <returns>Returns a  CreateInstanceResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateLayer operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLayer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateLayer">REST API Reference for CreateLayer Operation</seealso>
        IAsyncResult BeginCreateLayer(CreateLayerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLayer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLayer.</param>
        /// 
        /// <returns>Returns a  CreateLayerResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateLayer">REST API Reference for CreateLayer Operation</seealso>
        CreateLayerResponse EndCreateLayer(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateStack">REST API Reference for CreateStack Operation</seealso>
        IAsyncResult BeginCreateStack(CreateStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStack.</param>
        /// 
        /// <returns>Returns a  CreateStackResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateStack">REST API Reference for CreateStack Operation</seealso>
        CreateStackResponse EndCreateStack(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        IAsyncResult BeginCreateUserProfile(CreateUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserProfile.</param>
        /// 
        /// <returns>Returns a  CreateUserProfileResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        CreateUserProfileResponse EndCreateUserProfile(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        IAsyncResult BeginDeleteApp(DeleteAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        /// 
        /// <returns>Returns a  DeleteAppResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        IAsyncResult BeginDeleteInstance(DeleteInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstance.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayer operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLayer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteLayer">REST API Reference for DeleteLayer Operation</seealso>
        IAsyncResult BeginDeleteLayer(DeleteLayerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLayer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLayer.</param>
        /// 
        /// <returns>Returns a  DeleteLayerResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteLayer">REST API Reference for DeleteLayer Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        IAsyncResult BeginDeleteStack(DeleteStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStack.</param>
        /// 
        /// <returns>Returns a  DeleteStackResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        DeleteStackResponse EndDeleteStack(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        IAsyncResult BeginDeleteUserProfile(DeleteUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserProfile.</param>
        /// 
        /// <returns>Returns a  DeleteUserProfileResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        DeleteUserProfileResponse EndDeleteUserProfile(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterEcsCluster operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterEcsCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterEcsCluster">REST API Reference for DeregisterEcsCluster Operation</seealso>
        IAsyncResult BeginDeregisterEcsCluster(DeregisterEcsClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterEcsCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterEcsCluster.</param>
        /// 
        /// <returns>Returns a  DeregisterEcsClusterResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterEcsCluster">REST API Reference for DeregisterEcsCluster Operation</seealso>
        DeregisterEcsClusterResponse EndDeregisterEcsCluster(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterElasticIp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterElasticIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterElasticIp">REST API Reference for DeregisterElasticIp Operation</seealso>
        IAsyncResult BeginDeregisterElasticIp(DeregisterElasticIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterElasticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterElasticIp.</param>
        /// 
        /// <returns>Returns a  DeregisterElasticIpResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterElasticIp">REST API Reference for DeregisterElasticIp Operation</seealso>
        DeregisterElasticIpResponse EndDeregisterElasticIp(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterInstance">REST API Reference for DeregisterInstance Operation</seealso>
        IAsyncResult BeginDeregisterInstance(DeregisterInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterInstance.</param>
        /// 
        /// <returns>Returns a  DeregisterInstanceResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterInstance">REST API Reference for DeregisterInstance Operation</seealso>
        DeregisterInstanceResponse EndDeregisterInstance(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterRdsDbInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterRdsDbInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterRdsDbInstance">REST API Reference for DeregisterRdsDbInstance Operation</seealso>
        IAsyncResult BeginDeregisterRdsDbInstance(DeregisterRdsDbInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterRdsDbInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterRdsDbInstance.</param>
        /// 
        /// <returns>Returns a  DeregisterRdsDbInstanceResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterRdsDbInstance">REST API Reference for DeregisterRdsDbInstance Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterVolume operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterVolume">REST API Reference for DeregisterVolume Operation</seealso>
        IAsyncResult BeginDeregisterVolume(DeregisterVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterVolume.</param>
        /// 
        /// <returns>Returns a  DeregisterVolumeResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterVolume">REST API Reference for DeregisterVolume Operation</seealso>
        DeregisterVolumeResponse EndDeregisterVolume(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgentVersions operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAgentVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeAgentVersions">REST API Reference for DescribeAgentVersions Operation</seealso>
        IAsyncResult BeginDescribeAgentVersions(DescribeAgentVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAgentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAgentVersions.</param>
        /// 
        /// <returns>Returns a  DescribeAgentVersionsResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeAgentVersions">REST API Reference for DescribeAgentVersions Operation</seealso>
        DescribeAgentVersionsResponse EndDescribeAgentVersions(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeApps operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeApps">REST API Reference for DescribeApps Operation</seealso>
        IAsyncResult BeginDescribeApps(DescribeAppsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApps.</param>
        /// 
        /// <returns>Returns a  DescribeAppsResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeApps">REST API Reference for DescribeApps Operation</seealso>
        DescribeAppsResponse EndDescribeApps(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommands operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCommands
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeCommands">REST API Reference for DescribeCommands Operation</seealso>
        IAsyncResult BeginDescribeCommands(DescribeCommandsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCommands operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCommands.</param>
        /// 
        /// <returns>Returns a  DescribeCommandsResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeCommands">REST API Reference for DescribeCommands Operation</seealso>
        DescribeCommandsResponse EndDescribeCommands(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeployments operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeDeployments">REST API Reference for DescribeDeployments Operation</seealso>
        IAsyncResult BeginDescribeDeployments(DescribeDeploymentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeployments.</param>
        /// 
        /// <returns>Returns a  DescribeDeploymentsResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeDeployments">REST API Reference for DescribeDeployments Operation</seealso>
        DescribeDeploymentsResponse EndDescribeDeployments(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeEcsClusters operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEcsClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeEcsClusters">REST API Reference for DescribeEcsClusters Operation</seealso>
        IAsyncResult BeginDescribeEcsClusters(DescribeEcsClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEcsClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEcsClusters.</param>
        /// 
        /// <returns>Returns a  DescribeEcsClustersResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeEcsClusters">REST API Reference for DescribeEcsClusters Operation</seealso>
        DescribeEcsClustersResponse EndDescribeEcsClusters(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticIps operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticIps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeElasticIps">REST API Reference for DescribeElasticIps Operation</seealso>
        IAsyncResult BeginDescribeElasticIps(DescribeElasticIpsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticIps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticIps.</param>
        /// 
        /// <returns>Returns a  DescribeElasticIpsResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeElasticIps">REST API Reference for DescribeElasticIps Operation</seealso>
        DescribeElasticIpsResponse EndDescribeElasticIps(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeElasticLoadBalancers">REST API Reference for DescribeElasticLoadBalancers Operation</seealso>
        IAsyncResult BeginDescribeElasticLoadBalancers(DescribeElasticLoadBalancersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticLoadBalancers.</param>
        /// 
        /// <returns>Returns a  DescribeElasticLoadBalancersResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeElasticLoadBalancers">REST API Reference for DescribeElasticLoadBalancers Operation</seealso>
        DescribeElasticLoadBalancersResponse EndDescribeElasticLoadBalancers(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        IAsyncResult BeginDescribeInstances(DescribeInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstances.</param>
        /// 
        /// <returns>Returns a  DescribeInstancesResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        DescribeInstancesResponse EndDescribeInstances(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeLayers operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLayers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeLayers">REST API Reference for DescribeLayers Operation</seealso>
        IAsyncResult BeginDescribeLayers(DescribeLayersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLayers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLayers.</param>
        /// 
        /// <returns>Returns a  DescribeLayersResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeLayers">REST API Reference for DescribeLayers Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBasedAutoScaling operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoadBasedAutoScaling
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeLoadBasedAutoScaling">REST API Reference for DescribeLoadBasedAutoScaling Operation</seealso>
        IAsyncResult BeginDescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBasedAutoScalingResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeLoadBasedAutoScaling">REST API Reference for DescribeLoadBasedAutoScaling Operation</seealso>
        DescribeLoadBasedAutoScalingResponse EndDescribeLoadBasedAutoScaling(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeMyUserProfile">REST API Reference for DescribeMyUserProfile Operation</seealso>
        IAsyncResult BeginDescribeMyUserProfile(DescribeMyUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMyUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMyUserProfile.</param>
        /// 
        /// <returns>Returns a  DescribeMyUserProfileResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeMyUserProfile">REST API Reference for DescribeMyUserProfile Operation</seealso>
        DescribeMyUserProfileResponse EndDescribeMyUserProfile(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeOperatingSystems operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOperatingSystems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeOperatingSystems">REST API Reference for DescribeOperatingSystems Operation</seealso>
        IAsyncResult BeginDescribeOperatingSystems(DescribeOperatingSystemsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOperatingSystems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOperatingSystems.</param>
        /// 
        /// <returns>Returns a  DescribeOperatingSystemsResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeOperatingSystems">REST API Reference for DescribeOperatingSystems Operation</seealso>
        DescribeOperatingSystemsResponse EndDescribeOperatingSystems(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissions operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribePermissions">REST API Reference for DescribePermissions Operation</seealso>
        IAsyncResult BeginDescribePermissions(DescribePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePermissions.</param>
        /// 
        /// <returns>Returns a  DescribePermissionsResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribePermissions">REST API Reference for DescribePermissions Operation</seealso>
        DescribePermissionsResponse EndDescribePermissions(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeRaidArrays operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRaidArrays
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeRaidArrays">REST API Reference for DescribeRaidArrays Operation</seealso>
        IAsyncResult BeginDescribeRaidArrays(DescribeRaidArraysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRaidArrays operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRaidArrays.</param>
        /// 
        /// <returns>Returns a  DescribeRaidArraysResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeRaidArrays">REST API Reference for DescribeRaidArrays Operation</seealso>
        DescribeRaidArraysResponse EndDescribeRaidArrays(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeRdsDbInstances operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRdsDbInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeRdsDbInstances">REST API Reference for DescribeRdsDbInstances Operation</seealso>
        IAsyncResult BeginDescribeRdsDbInstances(DescribeRdsDbInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRdsDbInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRdsDbInstances.</param>
        /// 
        /// <returns>Returns a  DescribeRdsDbInstancesResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeRdsDbInstances">REST API Reference for DescribeRdsDbInstances Operation</seealso>
        DescribeRdsDbInstancesResponse EndDescribeRdsDbInstances(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeServiceErrors">REST API Reference for DescribeServiceErrors Operation</seealso>
        IAsyncResult BeginDescribeServiceErrors(DescribeServiceErrorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServiceErrors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceErrors.</param>
        /// 
        /// <returns>Returns a  DescribeServiceErrorsResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeServiceErrors">REST API Reference for DescribeServiceErrors Operation</seealso>
        DescribeServiceErrorsResponse EndDescribeServiceErrors(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackProvisioningParameters operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackProvisioningParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStackProvisioningParameters">REST API Reference for DescribeStackProvisioningParameters Operation</seealso>
        IAsyncResult BeginDescribeStackProvisioningParameters(DescribeStackProvisioningParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackProvisioningParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackProvisioningParameters.</param>
        /// 
        /// <returns>Returns a  DescribeStackProvisioningParametersResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStackProvisioningParameters">REST API Reference for DescribeStackProvisioningParameters Operation</seealso>
        DescribeStackProvisioningParametersResponse EndDescribeStackProvisioningParameters(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        IAsyncResult BeginDescribeStacks(DescribeStacksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStacks.</param>
        /// 
        /// <returns>Returns a  DescribeStacksResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        DescribeStacksResponse EndDescribeStacks(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSummary operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStackSummary">REST API Reference for DescribeStackSummary Operation</seealso>
        IAsyncResult BeginDescribeStackSummary(DescribeStackSummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackSummary.</param>
        /// 
        /// <returns>Returns a  DescribeStackSummaryResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStackSummary">REST API Reference for DescribeStackSummary Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeTimeBasedAutoScaling operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTimeBasedAutoScaling
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeTimeBasedAutoScaling">REST API Reference for DescribeTimeBasedAutoScaling Operation</seealso>
        IAsyncResult BeginDescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTimeBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTimeBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a  DescribeTimeBasedAutoScalingResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeTimeBasedAutoScaling">REST API Reference for DescribeTimeBasedAutoScaling Operation</seealso>
        DescribeTimeBasedAutoScalingResponse EndDescribeTimeBasedAutoScaling(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeUserProfiles">REST API Reference for DescribeUserProfiles Operation</seealso>
        IAsyncResult BeginDescribeUserProfiles(DescribeUserProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserProfiles.</param>
        /// 
        /// <returns>Returns a  DescribeUserProfilesResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeUserProfiles">REST API Reference for DescribeUserProfiles Operation</seealso>
        DescribeUserProfilesResponse EndDescribeUserProfiles(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVolumes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        IAsyncResult BeginDescribeVolumes(DescribeVolumesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVolumes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumes.</param>
        /// 
        /// <returns>Returns a  DescribeVolumesResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        DescribeVolumesResponse EndDescribeVolumes(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DetachElasticLoadBalancer operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachElasticLoadBalancer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DetachElasticLoadBalancer">REST API Reference for DetachElasticLoadBalancer Operation</seealso>
        IAsyncResult BeginDetachElasticLoadBalancer(DetachElasticLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachElasticLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachElasticLoadBalancer.</param>
        /// 
        /// <returns>Returns a  DetachElasticLoadBalancerResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DetachElasticLoadBalancer">REST API Reference for DetachElasticLoadBalancer Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DisassociateElasticIp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateElasticIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DisassociateElasticIp">REST API Reference for DisassociateElasticIp Operation</seealso>
        IAsyncResult BeginDisassociateElasticIp(DisassociateElasticIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateElasticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateElasticIp.</param>
        /// 
        /// <returns>Returns a  DisassociateElasticIpResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DisassociateElasticIp">REST API Reference for DisassociateElasticIp Operation</seealso>
        DisassociateElasticIpResponse EndDisassociateElasticIp(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the GetHostnameSuggestion operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHostnameSuggestion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/GetHostnameSuggestion">REST API Reference for GetHostnameSuggestion Operation</seealso>
        IAsyncResult BeginGetHostnameSuggestion(GetHostnameSuggestionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHostnameSuggestion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHostnameSuggestion.</param>
        /// 
        /// <returns>Returns a  GetHostnameSuggestionResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/GetHostnameSuggestion">REST API Reference for GetHostnameSuggestion Operation</seealso>
        GetHostnameSuggestionResponse EndGetHostnameSuggestion(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the GrantAccess operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGrantAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/GrantAccess">REST API Reference for GrantAccess Operation</seealso>
        IAsyncResult BeginGrantAccess(GrantAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GrantAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGrantAccess.</param>
        /// 
        /// <returns>Returns a  GrantAccessResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/GrantAccess">REST API Reference for GrantAccess Operation</seealso>
        GrantAccessResponse EndGrantAccess(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/ListTags">REST API Reference for ListTags Operation</seealso>
        IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse EndListTags(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        IAsyncResult BeginRebootInstance(RebootInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootInstance.</param>
        /// 
        /// <returns>Returns a  RebootInstanceResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        RebootInstanceResponse EndRebootInstance(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the RegisterEcsCluster operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterEcsCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterEcsCluster">REST API Reference for RegisterEcsCluster Operation</seealso>
        IAsyncResult BeginRegisterEcsCluster(RegisterEcsClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterEcsCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterEcsCluster.</param>
        /// 
        /// <returns>Returns a  RegisterEcsClusterResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterEcsCluster">REST API Reference for RegisterEcsCluster Operation</seealso>
        RegisterEcsClusterResponse EndRegisterEcsCluster(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the RegisterElasticIp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterElasticIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterElasticIp">REST API Reference for RegisterElasticIp Operation</seealso>
        IAsyncResult BeginRegisterElasticIp(RegisterElasticIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterElasticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterElasticIp.</param>
        /// 
        /// <returns>Returns a  RegisterElasticIpResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterElasticIp">REST API Reference for RegisterElasticIp Operation</seealso>
        RegisterElasticIpResponse EndRegisterElasticIp(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterInstance">REST API Reference for RegisterInstance Operation</seealso>
        IAsyncResult BeginRegisterInstance(RegisterInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterInstance.</param>
        /// 
        /// <returns>Returns a  RegisterInstanceResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterInstance">REST API Reference for RegisterInstance Operation</seealso>
        RegisterInstanceResponse EndRegisterInstance(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the RegisterRdsDbInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterRdsDbInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterRdsDbInstance">REST API Reference for RegisterRdsDbInstance Operation</seealso>
        IAsyncResult BeginRegisterRdsDbInstance(RegisterRdsDbInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterRdsDbInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterRdsDbInstance.</param>
        /// 
        /// <returns>Returns a  RegisterRdsDbInstanceResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterRdsDbInstance">REST API Reference for RegisterRdsDbInstance Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterVolume operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterVolume">REST API Reference for RegisterVolume Operation</seealso>
        IAsyncResult BeginRegisterVolume(RegisterVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterVolume.</param>
        /// 
        /// <returns>Returns a  RegisterVolumeResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterVolume">REST API Reference for RegisterVolume Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBasedAutoScaling operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetLoadBasedAutoScaling
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetLoadBasedAutoScaling">REST API Reference for SetLoadBasedAutoScaling Operation</seealso>
        IAsyncResult BeginSetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetLoadBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a  SetLoadBasedAutoScalingResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetLoadBasedAutoScaling">REST API Reference for SetLoadBasedAutoScaling Operation</seealso>
        SetLoadBasedAutoScalingResponse EndSetLoadBasedAutoScaling(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the SetPermission operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetPermission">REST API Reference for SetPermission Operation</seealso>
        IAsyncResult BeginSetPermission(SetPermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetPermission.</param>
        /// 
        /// <returns>Returns a  SetPermissionResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetPermission">REST API Reference for SetPermission Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the SetTimeBasedAutoScaling operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTimeBasedAutoScaling
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetTimeBasedAutoScaling">REST API Reference for SetTimeBasedAutoScaling Operation</seealso>
        IAsyncResult BeginSetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetTimeBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTimeBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a  SetTimeBasedAutoScalingResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetTimeBasedAutoScaling">REST API Reference for SetTimeBasedAutoScaling Operation</seealso>
        SetTimeBasedAutoScalingResponse EndSetTimeBasedAutoScaling(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the StartInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StartInstance">REST API Reference for StartInstance Operation</seealso>
        IAsyncResult BeginStartInstance(StartInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstance.</param>
        /// 
        /// <returns>Returns a  StartInstanceResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StartInstance">REST API Reference for StartInstance Operation</seealso>
        StartInstanceResponse EndStartInstance(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the StartStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StartStack">REST API Reference for StartStack Operation</seealso>
        IAsyncResult BeginStartStack(StartStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartStack.</param>
        /// 
        /// <returns>Returns a  StartStackResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StartStack">REST API Reference for StartStack Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the StopInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StopInstance">REST API Reference for StopInstance Operation</seealso>
        IAsyncResult BeginStopInstance(StopInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInstance.</param>
        /// 
        /// <returns>Returns a  StopInstanceResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StopInstance">REST API Reference for StopInstance Operation</seealso>
        StopInstanceResponse EndStopInstance(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the StopStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StopStack">REST API Reference for StopStack Operation</seealso>
        IAsyncResult BeginStopStack(StopStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopStack.</param>
        /// 
        /// <returns>Returns a  StopStackResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StopStack">REST API Reference for StopStack Operation</seealso>
        StopStackResponse EndStopStack(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UnassignInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnassignInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UnassignInstance">REST API Reference for UnassignInstance Operation</seealso>
        IAsyncResult BeginUnassignInstance(UnassignInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnassignInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnassignInstance.</param>
        /// 
        /// <returns>Returns a  UnassignInstanceResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UnassignInstance">REST API Reference for UnassignInstance Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UnassignVolume operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnassignVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UnassignVolume">REST API Reference for UnassignVolume Operation</seealso>
        IAsyncResult BeginUnassignVolume(UnassignVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnassignVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnassignVolume.</param>
        /// 
        /// <returns>Returns a  UnassignVolumeResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UnassignVolume">REST API Reference for UnassignVolume Operation</seealso>
        UnassignVolumeResponse EndUnassignVolume(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        IAsyncResult BeginUpdateApp(UpdateAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApp.</param>
        /// 
        /// <returns>Returns a  UpdateAppResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        UpdateAppResponse EndUpdateApp(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticIp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateElasticIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateElasticIp">REST API Reference for UpdateElasticIp Operation</seealso>
        IAsyncResult BeginUpdateElasticIp(UpdateElasticIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateElasticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateElasticIp.</param>
        /// 
        /// <returns>Returns a  UpdateElasticIpResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateElasticIp">REST API Reference for UpdateElasticIp Operation</seealso>
        UpdateElasticIpResponse EndUpdateElasticIp(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        IAsyncResult BeginUpdateInstance(UpdateInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstance.</param>
        /// 
        /// <returns>Returns a  UpdateInstanceResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        UpdateInstanceResponse EndUpdateInstance(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateLayer operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLayer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateLayer">REST API Reference for UpdateLayer Operation</seealso>
        IAsyncResult BeginUpdateLayer(UpdateLayerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLayer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLayer.</param>
        /// 
        /// <returns>Returns a  UpdateLayerResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateLayer">REST API Reference for UpdateLayer Operation</seealso>
        UpdateLayerResponse EndUpdateLayer(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateMyUserProfile">REST API Reference for UpdateMyUserProfile Operation</seealso>
        IAsyncResult BeginUpdateMyUserProfile(UpdateMyUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMyUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMyUserProfile.</param>
        /// 
        /// <returns>Returns a  UpdateMyUserProfileResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateMyUserProfile">REST API Reference for UpdateMyUserProfile Operation</seealso>
        UpdateMyUserProfileResponse EndUpdateMyUserProfile(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateRdsDbInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRdsDbInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateRdsDbInstance">REST API Reference for UpdateRdsDbInstance Operation</seealso>
        IAsyncResult BeginUpdateRdsDbInstance(UpdateRdsDbInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRdsDbInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRdsDbInstance.</param>
        /// 
        /// <returns>Returns a  UpdateRdsDbInstanceResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateRdsDbInstance">REST API Reference for UpdateRdsDbInstance Operation</seealso>
        UpdateRdsDbInstanceResponse EndUpdateRdsDbInstance(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        IAsyncResult BeginUpdateStack(UpdateStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStack.</param>
        /// 
        /// <returns>Returns a  UpdateStackResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        UpdateStackResponse EndUpdateStack(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        IAsyncResult BeginUpdateUserProfile(UpdateUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserProfile.</param>
        /// 
        /// <returns>Returns a  UpdateUserProfileResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        UpdateUserProfileResponse EndUpdateUserProfile(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateVolume operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateVolume">REST API Reference for UpdateVolume Operation</seealso>
        IAsyncResult BeginUpdateVolume(UpdateVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVolume.</param>
        /// 
        /// <returns>Returns a  UpdateVolumeResult from OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateVolume">REST API Reference for UpdateVolume Operation</seealso>
        UpdateVolumeResponse EndUpdateVolume(IAsyncResult asyncResult);

        #endregion
        
    }
}