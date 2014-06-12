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
using System.Threading;

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpsWorksConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpsWorksConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
        public AssignVolumeResponse AssignVolume(AssignVolumeRequest request)
        {
            IAsyncResult asyncResult = invokeAssignVolume(request, null, null, true);
            return EndAssignVolume(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssignVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignVolume operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssignVolume
        ///         operation.</returns>
        public IAsyncResult BeginAssignVolume(AssignVolumeRequest request, AsyncCallback callback, object state)
        {
            return invokeAssignVolume(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  AssignVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssignVolume.</param>
        /// 
        /// <returns>Returns a  AssignVolumeResult from OpsWorks.</returns>
        public  AssignVolumeResponse EndAssignVolume(IAsyncResult asyncResult)
        {
            return endOperation< AssignVolumeResponse>(asyncResult);
        }

        IAsyncResult invokeAssignVolume(AssignVolumeRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AssignVolumeRequestMarshaller().Marshall(request);
            var unmarshaller = AssignVolumeResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public AssociateElasticIpResponse AssociateElasticIp(AssociateElasticIpRequest request)
        {
            IAsyncResult asyncResult = invokeAssociateElasticIp(request, null, null, true);
            return EndAssociateElasticIp(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateElasticIp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateElasticIp
        ///         operation.</returns>
        public IAsyncResult BeginAssociateElasticIp(AssociateElasticIpRequest request, AsyncCallback callback, object state)
        {
            return invokeAssociateElasticIp(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateElasticIp.</param>
        /// 
        /// <returns>Returns a  AssociateElasticIpResult from OpsWorks.</returns>
        public  AssociateElasticIpResponse EndAssociateElasticIp(IAsyncResult asyncResult)
        {
            return endOperation< AssociateElasticIpResponse>(asyncResult);
        }

        IAsyncResult invokeAssociateElasticIp(AssociateElasticIpRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AssociateElasticIpRequestMarshaller().Marshall(request);
            var unmarshaller = AssociateElasticIpResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public AttachElasticLoadBalancerResponse AttachElasticLoadBalancer(AttachElasticLoadBalancerRequest request)
        {
            IAsyncResult asyncResult = invokeAttachElasticLoadBalancer(request, null, null, true);
            return EndAttachElasticLoadBalancer(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachElasticLoadBalancer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachElasticLoadBalancer operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachElasticLoadBalancer
        ///         operation.</returns>
        public IAsyncResult BeginAttachElasticLoadBalancer(AttachElasticLoadBalancerRequest request, AsyncCallback callback, object state)
        {
            return invokeAttachElasticLoadBalancer(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachElasticLoadBalancer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachElasticLoadBalancer.</param>
        /// 
        /// <returns>Returns a  AttachElasticLoadBalancerResult from OpsWorks.</returns>
        public  AttachElasticLoadBalancerResponse EndAttachElasticLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation< AttachElasticLoadBalancerResponse>(asyncResult);
        }

        IAsyncResult invokeAttachElasticLoadBalancer(AttachElasticLoadBalancerRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AttachElasticLoadBalancerRequestMarshaller().Marshall(request);
            var unmarshaller = AttachElasticLoadBalancerResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public CloneStackResponse CloneStack(CloneStackRequest request)
        {
            IAsyncResult asyncResult = invokeCloneStack(request, null, null, true);
            return EndCloneStack(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CloneStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloneStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCloneStack
        ///         operation.</returns>
        public IAsyncResult BeginCloneStack(CloneStackRequest request, AsyncCallback callback, object state)
        {
            return invokeCloneStack(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CloneStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCloneStack.</param>
        /// 
        /// <returns>Returns a  CloneStackResult from OpsWorks.</returns>
        public  CloneStackResponse EndCloneStack(IAsyncResult asyncResult)
        {
            return endOperation< CloneStackResponse>(asyncResult);
        }

        IAsyncResult invokeCloneStack(CloneStackRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CloneStackRequestMarshaller().Marshall(request);
            var unmarshaller = CloneStackResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public CreateAppResponse CreateApp(CreateAppRequest request)
        {
            IAsyncResult asyncResult = invokeCreateApp(request, null, null, true);
            return EndCreateApp(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApp
        ///         operation.</returns>
        public IAsyncResult BeginCreateApp(CreateAppRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateApp(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApp.</param>
        /// 
        /// <returns>Returns a  CreateAppResult from OpsWorks.</returns>
        public  CreateAppResponse EndCreateApp(IAsyncResult asyncResult)
        {
            return endOperation< CreateAppResponse>(asyncResult);
        }

        IAsyncResult invokeCreateApp(CreateAppRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateAppRequestMarshaller().Marshall(request);
            var unmarshaller = CreateAppResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            IAsyncResult asyncResult = invokeCreateDeployment(request, null, null, true);
            return EndCreateDeployment(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeployment
        ///         operation.</returns>
        public IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateDeployment(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from OpsWorks.</returns>
        public  CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult)
        {
            return endOperation< CreateDeploymentResponse>(asyncResult);
        }

        IAsyncResult invokeCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDeploymentRequestMarshaller().Marshall(request);
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            IAsyncResult asyncResult = invokeCreateInstance(request, null, null, true);
            return EndCreateInstance(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstance
        ///         operation.</returns>
        public IAsyncResult BeginCreateInstance(CreateInstanceRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateInstance(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstance.</param>
        /// 
        /// <returns>Returns a  CreateInstanceResult from OpsWorks.</returns>
        public  CreateInstanceResponse EndCreateInstance(IAsyncResult asyncResult)
        {
            return endOperation< CreateInstanceResponse>(asyncResult);
        }

        IAsyncResult invokeCreateInstance(CreateInstanceRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateInstanceRequestMarshaller().Marshall(request);
            var unmarshaller = CreateInstanceResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public CreateLayerResponse CreateLayer(CreateLayerRequest request)
        {
            IAsyncResult asyncResult = invokeCreateLayer(request, null, null, true);
            return EndCreateLayer(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLayer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLayer operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLayer
        ///         operation.</returns>
        public IAsyncResult BeginCreateLayer(CreateLayerRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateLayer(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLayer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLayer.</param>
        /// 
        /// <returns>Returns a  CreateLayerResult from OpsWorks.</returns>
        public  CreateLayerResponse EndCreateLayer(IAsyncResult asyncResult)
        {
            return endOperation< CreateLayerResponse>(asyncResult);
        }

        IAsyncResult invokeCreateLayer(CreateLayerRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateLayerRequestMarshaller().Marshall(request);
            var unmarshaller = CreateLayerResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public CreateStackResponse CreateStack(CreateStackRequest request)
        {
            IAsyncResult asyncResult = invokeCreateStack(request, null, null, true);
            return EndCreateStack(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStack
        ///         operation.</returns>
        public IAsyncResult BeginCreateStack(CreateStackRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateStack(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStack.</param>
        /// 
        /// <returns>Returns a  CreateStackResult from OpsWorks.</returns>
        public  CreateStackResponse EndCreateStack(IAsyncResult asyncResult)
        {
            return endOperation< CreateStackResponse>(asyncResult);
        }

        IAsyncResult invokeCreateStack(CreateStackRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateStackRequestMarshaller().Marshall(request);
            var unmarshaller = CreateStackResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request)
        {
            IAsyncResult asyncResult = invokeCreateUserProfile(request, null, null, true);
            return EndCreateUserProfile(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserProfile
        ///         operation.</returns>
        public IAsyncResult BeginCreateUserProfile(CreateUserProfileRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateUserProfile(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserProfile.</param>
        /// 
        /// <returns>Returns a  CreateUserProfileResult from OpsWorks.</returns>
        public  CreateUserProfileResponse EndCreateUserProfile(IAsyncResult asyncResult)
        {
            return endOperation< CreateUserProfileResponse>(asyncResult);
        }

        IAsyncResult invokeCreateUserProfile(CreateUserProfileRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateUserProfileRequestMarshaller().Marshall(request);
            var unmarshaller = CreateUserProfileResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteApp(request, null, null, true);
            return EndDeleteApp(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApp
        ///         operation.</returns>
        public IAsyncResult BeginDeleteApp(DeleteAppRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteApp(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        /// 
        /// <returns>Returns a  DeleteAppResult from OpsWorks.</returns>
        public  DeleteAppResponse EndDeleteApp(IAsyncResult asyncResult)
        {
            return endOperation< DeleteAppResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteApp(DeleteAppRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteAppRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteAppResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteInstance(request, null, null, true);
            return EndDeleteInstance(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstance
        ///         operation.</returns>
        public IAsyncResult BeginDeleteInstance(DeleteInstanceRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteInstance(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstance.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceResult from OpsWorks.</returns>
        public  DeleteInstanceResponse EndDeleteInstance(IAsyncResult asyncResult)
        {
            return endOperation< DeleteInstanceResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteInstance(DeleteInstanceRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteInstanceRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteInstanceResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DeleteLayerResponse DeleteLayer(DeleteLayerRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteLayer(request, null, null, true);
            return EndDeleteLayer(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLayer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayer operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLayer
        ///         operation.</returns>
        public IAsyncResult BeginDeleteLayer(DeleteLayerRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteLayer(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLayer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLayer.</param>
        /// 
        /// <returns>Returns a  DeleteLayerResult from OpsWorks.</returns>
        public  DeleteLayerResponse EndDeleteLayer(IAsyncResult asyncResult)
        {
            return endOperation< DeleteLayerResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteLayer(DeleteLayerRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteLayerRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteLayerResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteStack(request, null, null, true);
            return EndDeleteStack(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStack
        ///         operation.</returns>
        public IAsyncResult BeginDeleteStack(DeleteStackRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteStack(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStack.</param>
        /// 
        /// <returns>Returns a  DeleteStackResult from OpsWorks.</returns>
        public  DeleteStackResponse EndDeleteStack(IAsyncResult asyncResult)
        {
            return endOperation< DeleteStackResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteStack(DeleteStackRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteStackRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteStackResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteUserProfile(request, null, null, true);
            return EndDeleteUserProfile(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserProfile
        ///         operation.</returns>
        public IAsyncResult BeginDeleteUserProfile(DeleteUserProfileRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteUserProfile(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserProfile.</param>
        /// 
        /// <returns>Returns a  DeleteUserProfileResult from OpsWorks.</returns>
        public  DeleteUserProfileResponse EndDeleteUserProfile(IAsyncResult asyncResult)
        {
            return endOperation< DeleteUserProfileResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteUserProfile(DeleteUserProfileRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteUserProfileRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteUserProfileResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DeregisterElasticIpResponse DeregisterElasticIp(DeregisterElasticIpRequest request)
        {
            IAsyncResult asyncResult = invokeDeregisterElasticIp(request, null, null, true);
            return EndDeregisterElasticIp(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterElasticIp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterElasticIp
        ///         operation.</returns>
        public IAsyncResult BeginDeregisterElasticIp(DeregisterElasticIpRequest request, AsyncCallback callback, object state)
        {
            return invokeDeregisterElasticIp(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterElasticIp.</param>
        /// 
        /// <returns>Returns a  DeregisterElasticIpResult from OpsWorks.</returns>
        public  DeregisterElasticIpResponse EndDeregisterElasticIp(IAsyncResult asyncResult)
        {
            return endOperation< DeregisterElasticIpResponse>(asyncResult);
        }

        IAsyncResult invokeDeregisterElasticIp(DeregisterElasticIpRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeregisterElasticIpRequestMarshaller().Marshall(request);
            var unmarshaller = DeregisterElasticIpResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DeregisterRdsDbInstanceResponse DeregisterRdsDbInstance(DeregisterRdsDbInstanceRequest request)
        {
            IAsyncResult asyncResult = invokeDeregisterRdsDbInstance(request, null, null, true);
            return EndDeregisterRdsDbInstance(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterRdsDbInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterRdsDbInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterRdsDbInstance
        ///         operation.</returns>
        public IAsyncResult BeginDeregisterRdsDbInstance(DeregisterRdsDbInstanceRequest request, AsyncCallback callback, object state)
        {
            return invokeDeregisterRdsDbInstance(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterRdsDbInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterRdsDbInstance.</param>
        /// 
        /// <returns>Returns a  DeregisterRdsDbInstanceResult from OpsWorks.</returns>
        public  DeregisterRdsDbInstanceResponse EndDeregisterRdsDbInstance(IAsyncResult asyncResult)
        {
            return endOperation< DeregisterRdsDbInstanceResponse>(asyncResult);
        }

        IAsyncResult invokeDeregisterRdsDbInstance(DeregisterRdsDbInstanceRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeregisterRdsDbInstanceRequestMarshaller().Marshall(request);
            var unmarshaller = DeregisterRdsDbInstanceResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DeregisterVolumeResponse DeregisterVolume(DeregisterVolumeRequest request)
        {
            IAsyncResult asyncResult = invokeDeregisterVolume(request, null, null, true);
            return EndDeregisterVolume(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterVolume operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterVolume
        ///         operation.</returns>
        public IAsyncResult BeginDeregisterVolume(DeregisterVolumeRequest request, AsyncCallback callback, object state)
        {
            return invokeDeregisterVolume(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterVolume.</param>
        /// 
        /// <returns>Returns a  DeregisterVolumeResult from OpsWorks.</returns>
        public  DeregisterVolumeResponse EndDeregisterVolume(IAsyncResult asyncResult)
        {
            return endOperation< DeregisterVolumeResponse>(asyncResult);
        }

        IAsyncResult invokeDeregisterVolume(DeregisterVolumeRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeregisterVolumeRequestMarshaller().Marshall(request);
            var unmarshaller = DeregisterVolumeResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeAppsResponse DescribeApps(DescribeAppsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeApps(request, null, null, true);
            return EndDescribeApps(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApps operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApps operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApps
        ///         operation.</returns>
        public IAsyncResult BeginDescribeApps(DescribeAppsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeApps(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApps operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApps.</param>
        /// 
        /// <returns>Returns a  DescribeAppsResult from OpsWorks.</returns>
        public  DescribeAppsResponse EndDescribeApps(IAsyncResult asyncResult)
        {
            return endOperation< DescribeAppsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeApps(DescribeAppsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAppsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeAppsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeCommandsResponse DescribeCommands(DescribeCommandsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeCommands(request, null, null, true);
            return EndDescribeCommands(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCommands operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommands operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCommands
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCommands(DescribeCommandsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeCommands(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCommands operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCommands.</param>
        /// 
        /// <returns>Returns a  DescribeCommandsResult from OpsWorks.</returns>
        public  DescribeCommandsResponse EndDescribeCommands(IAsyncResult asyncResult)
        {
            return endOperation< DescribeCommandsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeCommands(DescribeCommandsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeCommandsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeCommandsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeDeploymentsResponse DescribeDeployments(DescribeDeploymentsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeDeployments(request, null, null, true);
            return EndDescribeDeployments(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeployments operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeployments operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeployments
        ///         operation.</returns>
        public IAsyncResult BeginDescribeDeployments(DescribeDeploymentsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeDeployments(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeployments operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeployments.</param>
        /// 
        /// <returns>Returns a  DescribeDeploymentsResult from OpsWorks.</returns>
        public  DescribeDeploymentsResponse EndDescribeDeployments(IAsyncResult asyncResult)
        {
            return endOperation< DescribeDeploymentsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeDeployments(DescribeDeploymentsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDeploymentsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeDeploymentsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeElasticIpsResponse DescribeElasticIps(DescribeElasticIpsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeElasticIps(request, null, null, true);
            return EndDescribeElasticIps(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticIps operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticIps operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticIps
        ///         operation.</returns>
        public IAsyncResult BeginDescribeElasticIps(DescribeElasticIpsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeElasticIps(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticIps operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticIps.</param>
        /// 
        /// <returns>Returns a  DescribeElasticIpsResult from OpsWorks.</returns>
        public  DescribeElasticIpsResponse EndDescribeElasticIps(IAsyncResult asyncResult)
        {
            return endOperation< DescribeElasticIpsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeElasticIps(DescribeElasticIpsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeElasticIpsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeElasticIpsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers()
        {
            return DescribeElasticLoadBalancers(new DescribeElasticLoadBalancersRequest());
        }

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
        public DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers(DescribeElasticLoadBalancersRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeElasticLoadBalancers(request, null, null, true);
            return EndDescribeElasticLoadBalancers(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticLoadBalancers operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticLoadBalancers operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticLoadBalancers
        ///         operation.</returns>
        public IAsyncResult BeginDescribeElasticLoadBalancers(DescribeElasticLoadBalancersRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeElasticLoadBalancers(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticLoadBalancers operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticLoadBalancers.</param>
        /// 
        /// <returns>Returns a  DescribeElasticLoadBalancersResult from OpsWorks.</returns>
        public  DescribeElasticLoadBalancersResponse EndDescribeElasticLoadBalancers(IAsyncResult asyncResult)
        {
            return endOperation< DescribeElasticLoadBalancersResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeElasticLoadBalancers(DescribeElasticLoadBalancersRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeElasticLoadBalancersRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeElasticLoadBalancersResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeInstances(request, null, null, true);
            return EndDescribeInstances(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstances
        ///         operation.</returns>
        public IAsyncResult BeginDescribeInstances(DescribeInstancesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeInstances(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstances operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstances.</param>
        /// 
        /// <returns>Returns a  DescribeInstancesResult from OpsWorks.</returns>
        public  DescribeInstancesResponse EndDescribeInstances(IAsyncResult asyncResult)
        {
            return endOperation< DescribeInstancesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeInstances(DescribeInstancesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeInstancesRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeInstancesResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeLayersResponse DescribeLayers(DescribeLayersRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeLayers(request, null, null, true);
            return EndDescribeLayers(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLayers operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLayers operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLayers
        ///         operation.</returns>
        public IAsyncResult BeginDescribeLayers(DescribeLayersRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeLayers(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLayers operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLayers.</param>
        /// 
        /// <returns>Returns a  DescribeLayersResult from OpsWorks.</returns>
        public  DescribeLayersResponse EndDescribeLayers(IAsyncResult asyncResult)
        {
            return endOperation< DescribeLayersResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeLayers(DescribeLayersRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeLayersRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeLayersResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeLoadBasedAutoScalingResponse DescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeLoadBasedAutoScaling(request, null, null, true);
            return EndDescribeLoadBasedAutoScaling(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBasedAutoScaling operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoadBasedAutoScaling
        ///         operation.</returns>
        public IAsyncResult BeginDescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeLoadBasedAutoScaling(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBasedAutoScalingResult from OpsWorks.</returns>
        public  DescribeLoadBasedAutoScalingResponse EndDescribeLoadBasedAutoScaling(IAsyncResult asyncResult)
        {
            return endOperation< DescribeLoadBasedAutoScalingResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeLoadBasedAutoScalingRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeLoadBasedAutoScalingResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeMyUserProfileResponse DescribeMyUserProfile()
        {
            return DescribeMyUserProfile(new DescribeMyUserProfileRequest());
        }

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
        public DescribeMyUserProfileResponse DescribeMyUserProfile(DescribeMyUserProfileRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeMyUserProfile(request, null, null, true);
            return EndDescribeMyUserProfile(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMyUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMyUserProfile operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMyUserProfile
        ///         operation.</returns>
        public IAsyncResult BeginDescribeMyUserProfile(DescribeMyUserProfileRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeMyUserProfile(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMyUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMyUserProfile.</param>
        /// 
        /// <returns>Returns a  DescribeMyUserProfileResult from OpsWorks.</returns>
        public  DescribeMyUserProfileResponse EndDescribeMyUserProfile(IAsyncResult asyncResult)
        {
            return endOperation< DescribeMyUserProfileResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeMyUserProfile(DescribeMyUserProfileRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeMyUserProfileRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeMyUserProfileResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribePermissionsResponse DescribePermissions(DescribePermissionsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribePermissions(request, null, null, true);
            return EndDescribePermissions(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePermissions operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissions operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePermissions
        ///         operation.</returns>
        public IAsyncResult BeginDescribePermissions(DescribePermissionsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribePermissions(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePermissions operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePermissions.</param>
        /// 
        /// <returns>Returns a  DescribePermissionsResult from OpsWorks.</returns>
        public  DescribePermissionsResponse EndDescribePermissions(IAsyncResult asyncResult)
        {
            return endOperation< DescribePermissionsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribePermissions(DescribePermissionsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribePermissionsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribePermissionsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeRaidArraysResponse DescribeRaidArrays(DescribeRaidArraysRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeRaidArrays(request, null, null, true);
            return EndDescribeRaidArrays(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRaidArrays operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRaidArrays operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRaidArrays
        ///         operation.</returns>
        public IAsyncResult BeginDescribeRaidArrays(DescribeRaidArraysRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeRaidArrays(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRaidArrays operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRaidArrays.</param>
        /// 
        /// <returns>Returns a  DescribeRaidArraysResult from OpsWorks.</returns>
        public  DescribeRaidArraysResponse EndDescribeRaidArrays(IAsyncResult asyncResult)
        {
            return endOperation< DescribeRaidArraysResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeRaidArrays(DescribeRaidArraysRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeRaidArraysRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeRaidArraysResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeRdsDbInstancesResponse DescribeRdsDbInstances(DescribeRdsDbInstancesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeRdsDbInstances(request, null, null, true);
            return EndDescribeRdsDbInstances(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRdsDbInstances operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRdsDbInstances operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRdsDbInstances
        ///         operation.</returns>
        public IAsyncResult BeginDescribeRdsDbInstances(DescribeRdsDbInstancesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeRdsDbInstances(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRdsDbInstances operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRdsDbInstances.</param>
        /// 
        /// <returns>Returns a  DescribeRdsDbInstancesResult from OpsWorks.</returns>
        public  DescribeRdsDbInstancesResponse EndDescribeRdsDbInstances(IAsyncResult asyncResult)
        {
            return endOperation< DescribeRdsDbInstancesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeRdsDbInstances(DescribeRdsDbInstancesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeRdsDbInstancesRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeRdsDbInstancesResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeServiceErrorsResponse DescribeServiceErrors()
        {
            return DescribeServiceErrors(new DescribeServiceErrorsRequest());
        }

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
        public DescribeServiceErrorsResponse DescribeServiceErrors(DescribeServiceErrorsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeServiceErrors(request, null, null, true);
            return EndDescribeServiceErrors(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceErrors operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceErrors operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServiceErrors
        ///         operation.</returns>
        public IAsyncResult BeginDescribeServiceErrors(DescribeServiceErrorsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeServiceErrors(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServiceErrors operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceErrors.</param>
        /// 
        /// <returns>Returns a  DescribeServiceErrorsResult from OpsWorks.</returns>
        public  DescribeServiceErrorsResponse EndDescribeServiceErrors(IAsyncResult asyncResult)
        {
            return endOperation< DescribeServiceErrorsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeServiceErrors(DescribeServiceErrorsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeServiceErrorsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeServiceErrorsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeStacksResponse DescribeStacks()
        {
            return DescribeStacks(new DescribeStacksRequest());
        }

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
        public DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeStacks(request, null, null, true);
            return EndDescribeStacks(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStacks
        ///         operation.</returns>
        public IAsyncResult BeginDescribeStacks(DescribeStacksRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeStacks(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStacks operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStacks.</param>
        /// 
        /// <returns>Returns a  DescribeStacksResult from OpsWorks.</returns>
        public  DescribeStacksResponse EndDescribeStacks(IAsyncResult asyncResult)
        {
            return endOperation< DescribeStacksResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeStacks(DescribeStacksRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeStacksRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeStacksResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeStackSummaryResponse DescribeStackSummary(DescribeStackSummaryRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeStackSummary(request, null, null, true);
            return EndDescribeStackSummary(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackSummary operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSummary operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackSummary
        ///         operation.</returns>
        public IAsyncResult BeginDescribeStackSummary(DescribeStackSummaryRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeStackSummary(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackSummary operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackSummary.</param>
        /// 
        /// <returns>Returns a  DescribeStackSummaryResult from OpsWorks.</returns>
        public  DescribeStackSummaryResponse EndDescribeStackSummary(IAsyncResult asyncResult)
        {
            return endOperation< DescribeStackSummaryResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeStackSummary(DescribeStackSummaryRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeStackSummaryRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeStackSummaryResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeTimeBasedAutoScalingResponse DescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeTimeBasedAutoScaling(request, null, null, true);
            return EndDescribeTimeBasedAutoScaling(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTimeBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTimeBasedAutoScaling operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTimeBasedAutoScaling
        ///         operation.</returns>
        public IAsyncResult BeginDescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeTimeBasedAutoScaling(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTimeBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTimeBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a  DescribeTimeBasedAutoScalingResult from OpsWorks.</returns>
        public  DescribeTimeBasedAutoScalingResponse EndDescribeTimeBasedAutoScaling(IAsyncResult asyncResult)
        {
            return endOperation< DescribeTimeBasedAutoScalingResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeTimeBasedAutoScalingRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeTimeBasedAutoScalingResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeUserProfilesResponse DescribeUserProfiles()
        {
            return DescribeUserProfiles(new DescribeUserProfilesRequest());
        }

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
        public DescribeUserProfilesResponse DescribeUserProfiles(DescribeUserProfilesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeUserProfiles(request, null, null, true);
            return EndDescribeUserProfiles(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserProfiles operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfiles operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUserProfiles
        ///         operation.</returns>
        public IAsyncResult BeginDescribeUserProfiles(DescribeUserProfilesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeUserProfiles(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserProfiles operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserProfiles.</param>
        /// 
        /// <returns>Returns a  DescribeUserProfilesResult from OpsWorks.</returns>
        public  DescribeUserProfilesResponse EndDescribeUserProfiles(IAsyncResult asyncResult)
        {
            return endOperation< DescribeUserProfilesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeUserProfiles(DescribeUserProfilesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeUserProfilesRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeUserProfilesResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeVolumes(request, null, null, true);
            return EndDescribeVolumes(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVolumes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVolumes(DescribeVolumesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeVolumes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVolumes operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumes.</param>
        /// 
        /// <returns>Returns a  DescribeVolumesResult from OpsWorks.</returns>
        public  DescribeVolumesResponse EndDescribeVolumes(IAsyncResult asyncResult)
        {
            return endOperation< DescribeVolumesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeVolumes(DescribeVolumesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeVolumesRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeVolumesResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DetachElasticLoadBalancerResponse DetachElasticLoadBalancer(DetachElasticLoadBalancerRequest request)
        {
            IAsyncResult asyncResult = invokeDetachElasticLoadBalancer(request, null, null, true);
            return EndDetachElasticLoadBalancer(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachElasticLoadBalancer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachElasticLoadBalancer operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachElasticLoadBalancer
        ///         operation.</returns>
        public IAsyncResult BeginDetachElasticLoadBalancer(DetachElasticLoadBalancerRequest request, AsyncCallback callback, object state)
        {
            return invokeDetachElasticLoadBalancer(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachElasticLoadBalancer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachElasticLoadBalancer.</param>
        /// 
        /// <returns>Returns a  DetachElasticLoadBalancerResult from OpsWorks.</returns>
        public  DetachElasticLoadBalancerResponse EndDetachElasticLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation< DetachElasticLoadBalancerResponse>(asyncResult);
        }

        IAsyncResult invokeDetachElasticLoadBalancer(DetachElasticLoadBalancerRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DetachElasticLoadBalancerRequestMarshaller().Marshall(request);
            var unmarshaller = DetachElasticLoadBalancerResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DisassociateElasticIpResponse DisassociateElasticIp(DisassociateElasticIpRequest request)
        {
            IAsyncResult asyncResult = invokeDisassociateElasticIp(request, null, null, true);
            return EndDisassociateElasticIp(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateElasticIp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateElasticIp
        ///         operation.</returns>
        public IAsyncResult BeginDisassociateElasticIp(DisassociateElasticIpRequest request, AsyncCallback callback, object state)
        {
            return invokeDisassociateElasticIp(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateElasticIp.</param>
        /// 
        /// <returns>Returns a  DisassociateElasticIpResult from OpsWorks.</returns>
        public  DisassociateElasticIpResponse EndDisassociateElasticIp(IAsyncResult asyncResult)
        {
            return endOperation< DisassociateElasticIpResponse>(asyncResult);
        }

        IAsyncResult invokeDisassociateElasticIp(DisassociateElasticIpRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DisassociateElasticIpRequestMarshaller().Marshall(request);
            var unmarshaller = DisassociateElasticIpResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public GetHostnameSuggestionResponse GetHostnameSuggestion(GetHostnameSuggestionRequest request)
        {
            IAsyncResult asyncResult = invokeGetHostnameSuggestion(request, null, null, true);
            return EndGetHostnameSuggestion(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostnameSuggestion operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostnameSuggestion operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHostnameSuggestion
        ///         operation.</returns>
        public IAsyncResult BeginGetHostnameSuggestion(GetHostnameSuggestionRequest request, AsyncCallback callback, object state)
        {
            return invokeGetHostnameSuggestion(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHostnameSuggestion operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHostnameSuggestion.</param>
        /// 
        /// <returns>Returns a  GetHostnameSuggestionResult from OpsWorks.</returns>
        public  GetHostnameSuggestionResponse EndGetHostnameSuggestion(IAsyncResult asyncResult)
        {
            return endOperation< GetHostnameSuggestionResponse>(asyncResult);
        }

        IAsyncResult invokeGetHostnameSuggestion(GetHostnameSuggestionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetHostnameSuggestionRequestMarshaller().Marshall(request);
            var unmarshaller = GetHostnameSuggestionResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public RebootInstanceResponse RebootInstance(RebootInstanceRequest request)
        {
            IAsyncResult asyncResult = invokeRebootInstance(request, null, null, true);
            return EndRebootInstance(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootInstance
        ///         operation.</returns>
        public IAsyncResult BeginRebootInstance(RebootInstanceRequest request, AsyncCallback callback, object state)
        {
            return invokeRebootInstance(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootInstance.</param>
        /// 
        /// <returns>Returns a  RebootInstanceResult from OpsWorks.</returns>
        public  RebootInstanceResponse EndRebootInstance(IAsyncResult asyncResult)
        {
            return endOperation< RebootInstanceResponse>(asyncResult);
        }

        IAsyncResult invokeRebootInstance(RebootInstanceRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RebootInstanceRequestMarshaller().Marshall(request);
            var unmarshaller = RebootInstanceResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public RegisterElasticIpResponse RegisterElasticIp(RegisterElasticIpRequest request)
        {
            IAsyncResult asyncResult = invokeRegisterElasticIp(request, null, null, true);
            return EndRegisterElasticIp(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterElasticIp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterElasticIp
        ///         operation.</returns>
        public IAsyncResult BeginRegisterElasticIp(RegisterElasticIpRequest request, AsyncCallback callback, object state)
        {
            return invokeRegisterElasticIp(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterElasticIp.</param>
        /// 
        /// <returns>Returns a  RegisterElasticIpResult from OpsWorks.</returns>
        public  RegisterElasticIpResponse EndRegisterElasticIp(IAsyncResult asyncResult)
        {
            return endOperation< RegisterElasticIpResponse>(asyncResult);
        }

        IAsyncResult invokeRegisterElasticIp(RegisterElasticIpRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RegisterElasticIpRequestMarshaller().Marshall(request);
            var unmarshaller = RegisterElasticIpResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public RegisterRdsDbInstanceResponse RegisterRdsDbInstance(RegisterRdsDbInstanceRequest request)
        {
            IAsyncResult asyncResult = invokeRegisterRdsDbInstance(request, null, null, true);
            return EndRegisterRdsDbInstance(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterRdsDbInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterRdsDbInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterRdsDbInstance
        ///         operation.</returns>
        public IAsyncResult BeginRegisterRdsDbInstance(RegisterRdsDbInstanceRequest request, AsyncCallback callback, object state)
        {
            return invokeRegisterRdsDbInstance(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterRdsDbInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterRdsDbInstance.</param>
        /// 
        /// <returns>Returns a  RegisterRdsDbInstanceResult from OpsWorks.</returns>
        public  RegisterRdsDbInstanceResponse EndRegisterRdsDbInstance(IAsyncResult asyncResult)
        {
            return endOperation< RegisterRdsDbInstanceResponse>(asyncResult);
        }

        IAsyncResult invokeRegisterRdsDbInstance(RegisterRdsDbInstanceRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RegisterRdsDbInstanceRequestMarshaller().Marshall(request);
            var unmarshaller = RegisterRdsDbInstanceResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public RegisterVolumeResponse RegisterVolume(RegisterVolumeRequest request)
        {
            IAsyncResult asyncResult = invokeRegisterVolume(request, null, null, true);
            return EndRegisterVolume(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterVolume operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterVolume
        ///         operation.</returns>
        public IAsyncResult BeginRegisterVolume(RegisterVolumeRequest request, AsyncCallback callback, object state)
        {
            return invokeRegisterVolume(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterVolume.</param>
        /// 
        /// <returns>Returns a  RegisterVolumeResult from OpsWorks.</returns>
        public  RegisterVolumeResponse EndRegisterVolume(IAsyncResult asyncResult)
        {
            return endOperation< RegisterVolumeResponse>(asyncResult);
        }

        IAsyncResult invokeRegisterVolume(RegisterVolumeRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RegisterVolumeRequestMarshaller().Marshall(request);
            var unmarshaller = RegisterVolumeResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public SetLoadBasedAutoScalingResponse SetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest request)
        {
            IAsyncResult asyncResult = invokeSetLoadBasedAutoScaling(request, null, null, true);
            return EndSetLoadBasedAutoScaling(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBasedAutoScaling operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetLoadBasedAutoScaling
        ///         operation.</returns>
        public IAsyncResult BeginSetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest request, AsyncCallback callback, object state)
        {
            return invokeSetLoadBasedAutoScaling(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SetLoadBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a  SetLoadBasedAutoScalingResult from OpsWorks.</returns>
        public  SetLoadBasedAutoScalingResponse EndSetLoadBasedAutoScaling(IAsyncResult asyncResult)
        {
            return endOperation< SetLoadBasedAutoScalingResponse>(asyncResult);
        }

        IAsyncResult invokeSetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetLoadBasedAutoScalingRequestMarshaller().Marshall(request);
            var unmarshaller = SetLoadBasedAutoScalingResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public SetPermissionResponse SetPermission(SetPermissionRequest request)
        {
            IAsyncResult asyncResult = invokeSetPermission(request, null, null, true);
            return EndSetPermission(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetPermission operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetPermission operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetPermission
        ///         operation.</returns>
        public IAsyncResult BeginSetPermission(SetPermissionRequest request, AsyncCallback callback, object state)
        {
            return invokeSetPermission(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SetPermission operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetPermission.</param>
        /// 
        /// <returns>Returns a  SetPermissionResult from OpsWorks.</returns>
        public  SetPermissionResponse EndSetPermission(IAsyncResult asyncResult)
        {
            return endOperation< SetPermissionResponse>(asyncResult);
        }

        IAsyncResult invokeSetPermission(SetPermissionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetPermissionRequestMarshaller().Marshall(request);
            var unmarshaller = SetPermissionResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public SetTimeBasedAutoScalingResponse SetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest request)
        {
            IAsyncResult asyncResult = invokeSetTimeBasedAutoScaling(request, null, null, true);
            return EndSetTimeBasedAutoScaling(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetTimeBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTimeBasedAutoScaling operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTimeBasedAutoScaling
        ///         operation.</returns>
        public IAsyncResult BeginSetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest request, AsyncCallback callback, object state)
        {
            return invokeSetTimeBasedAutoScaling(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SetTimeBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTimeBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a  SetTimeBasedAutoScalingResult from OpsWorks.</returns>
        public  SetTimeBasedAutoScalingResponse EndSetTimeBasedAutoScaling(IAsyncResult asyncResult)
        {
            return endOperation< SetTimeBasedAutoScalingResponse>(asyncResult);
        }

        IAsyncResult invokeSetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetTimeBasedAutoScalingRequestMarshaller().Marshall(request);
            var unmarshaller = SetTimeBasedAutoScalingResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            IAsyncResult asyncResult = invokeStartInstance(request, null, null, true);
            return EndStartInstance(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInstance
        ///         operation.</returns>
        public IAsyncResult BeginStartInstance(StartInstanceRequest request, AsyncCallback callback, object state)
        {
            return invokeStartInstance(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  StartInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstance.</param>
        /// 
        /// <returns>Returns a  StartInstanceResult from OpsWorks.</returns>
        public  StartInstanceResponse EndStartInstance(IAsyncResult asyncResult)
        {
            return endOperation< StartInstanceResponse>(asyncResult);
        }

        IAsyncResult invokeStartInstance(StartInstanceRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new StartInstanceRequestMarshaller().Marshall(request);
            var unmarshaller = StartInstanceResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public StartStackResponse StartStack(StartStackRequest request)
        {
            IAsyncResult asyncResult = invokeStartStack(request, null, null, true);
            return EndStartStack(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartStack
        ///         operation.</returns>
        public IAsyncResult BeginStartStack(StartStackRequest request, AsyncCallback callback, object state)
        {
            return invokeStartStack(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  StartStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartStack.</param>
        /// 
        /// <returns>Returns a  StartStackResult from OpsWorks.</returns>
        public  StartStackResponse EndStartStack(IAsyncResult asyncResult)
        {
            return endOperation< StartStackResponse>(asyncResult);
        }

        IAsyncResult invokeStartStack(StartStackRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new StartStackRequestMarshaller().Marshall(request);
            var unmarshaller = StartStackResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            IAsyncResult asyncResult = invokeStopInstance(request, null, null, true);
            return EndStopInstance(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopInstance
        ///         operation.</returns>
        public IAsyncResult BeginStopInstance(StopInstanceRequest request, AsyncCallback callback, object state)
        {
            return invokeStopInstance(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  StopInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInstance.</param>
        /// 
        /// <returns>Returns a  StopInstanceResult from OpsWorks.</returns>
        public  StopInstanceResponse EndStopInstance(IAsyncResult asyncResult)
        {
            return endOperation< StopInstanceResponse>(asyncResult);
        }

        IAsyncResult invokeStopInstance(StopInstanceRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new StopInstanceRequestMarshaller().Marshall(request);
            var unmarshaller = StopInstanceResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public StopStackResponse StopStack(StopStackRequest request)
        {
            IAsyncResult asyncResult = invokeStopStack(request, null, null, true);
            return EndStopStack(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopStack
        ///         operation.</returns>
        public IAsyncResult BeginStopStack(StopStackRequest request, AsyncCallback callback, object state)
        {
            return invokeStopStack(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  StopStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopStack.</param>
        /// 
        /// <returns>Returns a  StopStackResult from OpsWorks.</returns>
        public  StopStackResponse EndStopStack(IAsyncResult asyncResult)
        {
            return endOperation< StopStackResponse>(asyncResult);
        }

        IAsyncResult invokeStopStack(StopStackRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new StopStackRequestMarshaller().Marshall(request);
            var unmarshaller = StopStackResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public UnassignVolumeResponse UnassignVolume(UnassignVolumeRequest request)
        {
            IAsyncResult asyncResult = invokeUnassignVolume(request, null, null, true);
            return EndUnassignVolume(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnassignVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignVolume operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnassignVolume
        ///         operation.</returns>
        public IAsyncResult BeginUnassignVolume(UnassignVolumeRequest request, AsyncCallback callback, object state)
        {
            return invokeUnassignVolume(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UnassignVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnassignVolume.</param>
        /// 
        /// <returns>Returns a  UnassignVolumeResult from OpsWorks.</returns>
        public  UnassignVolumeResponse EndUnassignVolume(IAsyncResult asyncResult)
        {
            return endOperation< UnassignVolumeResponse>(asyncResult);
        }

        IAsyncResult invokeUnassignVolume(UnassignVolumeRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UnassignVolumeRequestMarshaller().Marshall(request);
            var unmarshaller = UnassignVolumeResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public UpdateAppResponse UpdateApp(UpdateAppRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateApp(request, null, null, true);
            return EndUpdateApp(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApp
        ///         operation.</returns>
        public IAsyncResult BeginUpdateApp(UpdateAppRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateApp(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApp.</param>
        /// 
        /// <returns>Returns a  UpdateAppResult from OpsWorks.</returns>
        public  UpdateAppResponse EndUpdateApp(IAsyncResult asyncResult)
        {
            return endOperation< UpdateAppResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateApp(UpdateAppRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateAppRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateAppResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public UpdateElasticIpResponse UpdateElasticIp(UpdateElasticIpRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateElasticIp(request, null, null, true);
            return EndUpdateElasticIp(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticIp operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateElasticIp
        ///         operation.</returns>
        public IAsyncResult BeginUpdateElasticIp(UpdateElasticIpRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateElasticIp(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateElasticIp.</param>
        /// 
        /// <returns>Returns a  UpdateElasticIpResult from OpsWorks.</returns>
        public  UpdateElasticIpResponse EndUpdateElasticIp(IAsyncResult asyncResult)
        {
            return endOperation< UpdateElasticIpResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateElasticIp(UpdateElasticIpRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateElasticIpRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateElasticIpResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateInstance(request, null, null, true);
            return EndUpdateInstance(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInstance
        ///         operation.</returns>
        public IAsyncResult BeginUpdateInstance(UpdateInstanceRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateInstance(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstance.</param>
        /// 
        /// <returns>Returns a  UpdateInstanceResult from OpsWorks.</returns>
        public  UpdateInstanceResponse EndUpdateInstance(IAsyncResult asyncResult)
        {
            return endOperation< UpdateInstanceResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateInstance(UpdateInstanceRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateInstanceRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateInstanceResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public UpdateLayerResponse UpdateLayer(UpdateLayerRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateLayer(request, null, null, true);
            return EndUpdateLayer(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLayer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLayer operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLayer
        ///         operation.</returns>
        public IAsyncResult BeginUpdateLayer(UpdateLayerRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateLayer(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLayer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLayer.</param>
        /// 
        /// <returns>Returns a  UpdateLayerResult from OpsWorks.</returns>
        public  UpdateLayerResponse EndUpdateLayer(IAsyncResult asyncResult)
        {
            return endOperation< UpdateLayerResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateLayer(UpdateLayerRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateLayerRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateLayerResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public UpdateMyUserProfileResponse UpdateMyUserProfile()
        {
            return UpdateMyUserProfile(new UpdateMyUserProfileRequest());
        }

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
        public UpdateMyUserProfileResponse UpdateMyUserProfile(UpdateMyUserProfileRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateMyUserProfile(request, null, null, true);
            return EndUpdateMyUserProfile(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMyUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMyUserProfile operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMyUserProfile
        ///         operation.</returns>
        public IAsyncResult BeginUpdateMyUserProfile(UpdateMyUserProfileRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateMyUserProfile(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMyUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMyUserProfile.</param>
        /// 
        /// <returns>Returns a  UpdateMyUserProfileResult from OpsWorks.</returns>
        public  UpdateMyUserProfileResponse EndUpdateMyUserProfile(IAsyncResult asyncResult)
        {
            return endOperation< UpdateMyUserProfileResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateMyUserProfile(UpdateMyUserProfileRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateMyUserProfileRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateMyUserProfileResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public UpdateRdsDbInstanceResponse UpdateRdsDbInstance(UpdateRdsDbInstanceRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateRdsDbInstance(request, null, null, true);
            return EndUpdateRdsDbInstance(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRdsDbInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRdsDbInstance operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRdsDbInstance
        ///         operation.</returns>
        public IAsyncResult BeginUpdateRdsDbInstance(UpdateRdsDbInstanceRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateRdsDbInstance(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRdsDbInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRdsDbInstance.</param>
        /// 
        /// <returns>Returns a  UpdateRdsDbInstanceResult from OpsWorks.</returns>
        public  UpdateRdsDbInstanceResponse EndUpdateRdsDbInstance(IAsyncResult asyncResult)
        {
            return endOperation< UpdateRdsDbInstanceResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateRdsDbInstance(UpdateRdsDbInstanceRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateRdsDbInstanceRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateRdsDbInstanceResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateStack(request, null, null, true);
            return EndUpdateStack(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStack
        ///         operation.</returns>
        public IAsyncResult BeginUpdateStack(UpdateStackRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateStack(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStack.</param>
        /// 
        /// <returns>Returns a  UpdateStackResult from OpsWorks.</returns>
        public  UpdateStackResponse EndUpdateStack(IAsyncResult asyncResult)
        {
            return endOperation< UpdateStackResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateStack(UpdateStackRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateStackRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateStackResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateUserProfile(request, null, null, true);
            return EndUpdateUserProfile(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserProfile
        ///         operation.</returns>
        public IAsyncResult BeginUpdateUserProfile(UpdateUserProfileRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateUserProfile(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserProfile.</param>
        /// 
        /// <returns>Returns a  UpdateUserProfileResult from OpsWorks.</returns>
        public  UpdateUserProfileResponse EndUpdateUserProfile(IAsyncResult asyncResult)
        {
            return endOperation< UpdateUserProfileResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateUserProfile(UpdateUserProfileRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateUserProfileRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public UpdateVolumeResponse UpdateVolume(UpdateVolumeRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateVolume(request, null, null, true);
            return EndUpdateVolume(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVolume operation on AmazonOpsWorksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVolume
        ///         operation.</returns>
        public IAsyncResult BeginUpdateVolume(UpdateVolumeRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateVolume(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVolume.</param>
        /// 
        /// <returns>Returns a  UpdateVolumeResult from OpsWorks.</returns>
        public  UpdateVolumeResponse EndUpdateVolume(IAsyncResult asyncResult)
        {
            return endOperation< UpdateVolumeResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateVolume(UpdateVolumeRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateVolumeRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateVolumeResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
    }
}