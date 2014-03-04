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
    /// the <a href="http://aws.amazon.com/opsworks/" >AWS OpsWorks</a> details page. </para> <para> <b>SDKs and CLI</b> </para> <para>The most
    /// common way to use the AWS OpsWorks API is by using the AWS Command Line Interface (CLI) or by using one of the AWS SDKs to implement
    /// applications in your preferred language. For more information, see:</para>
    /// <ul>
    /// <li> <a href="http://docs.aws.amazon.com/cli/latest/userguide/cli-chap-welcome.html" >AWS CLI</a> </li>
    /// <li> <a href="http://docs.aws.amazon.com/AWSJavaSDK/latest/javadoc/com/amazonaws/services/opsworks/AWSOpsWorksClient.html" >AWS SDK for
    /// Java</a> </li>
    /// <li> <a href="http://docs.aws.amazon.com/sdkfornet/latest/apidocs/html/N_Amazon_OpsWorks.htm" >AWS SDK for .NET</a> </li>
    /// <li> <a href="http://docs.aws.amazon.com/aws-sdk-php-2/latest/class-Aws.OpsWorks.OpsWorksClient.html" >AWS SDK for PHP 2</a> </li>
    /// <li> <a href="http://docs.aws.amazon.com/AWSRubySDK/latest/AWS/OpsWorks/Client.html" >AWS SDK for Ruby</a> </li>
    /// <li> <a href="http://aws.amazon.com/documentation/sdkforjavascript/" >AWS SDK for Node.js</a> </li>
    /// <li> <a href="http://docs.pythonboto.org/en/latest/ref/opsworks.html" >AWS SDK for Python(Boto)</a> </li>
    /// 
    /// </ul>
    /// <para> <b>Endpoints</b> </para> <para>AWS OpsWorks supports only one endpoint, opsworks.us-east-1.amazonaws.com (HTTPS), so you must
    /// connect to that endpoint. You can then use the API to direct AWS OpsWorks to create stacks in any AWS Region.</para> <para> <b>Chef
    /// Version</b> </para> <para>When you call CreateStack, CloneStack, or UpdateStack we recommend you use the <c>ConfigurationManager</c>
    /// parameter to specify the Chef version, 0.9 or 11.4. The default value is currently 0.9. However, we expect to change the default value to
    /// 11.4 in October 2013. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook-chef11.html"
    /// >Using AWS OpsWorks with Chef 11</a> .</para>
    /// </summary>
    public class AmazonOpsWorksClient : AmazonWebServiceClient, AmazonOpsWorks
    {
    
        AbstractAWSSigner signer = new AWS4Signer();

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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonOpsWorksClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpsWorksConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonOpsWorksClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonOpsWorksClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpsWorksConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonOpsWorksClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonOpsWorks Configuration Object</param>
        public AmazonOpsWorksClient(AmazonOpsWorksConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
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
   
        #region UpdateMyUserProfile

        /// <summary>
        /// <para>Updates a user's SSH public key.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have self-management
        /// enabled or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateMyUserProfileRequest">Container for the necessary parameters to execute the UpdateMyUserProfile service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ValidationException"/>
        public UpdateMyUserProfileResponse UpdateMyUserProfile(UpdateMyUserProfileRequest updateMyUserProfileRequest)
        {
            IAsyncResult asyncResult = invokeUpdateMyUserProfile(updateMyUserProfileRequest, null, null, true);
            return EndUpdateMyUserProfile(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMyUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateMyUserProfile"/>
        /// </summary>
        /// 
        /// <param name="updateMyUserProfileRequest">Container for the necessary parameters to execute the UpdateMyUserProfile operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateMyUserProfile(UpdateMyUserProfileRequest updateMyUserProfileRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateMyUserProfile(updateMyUserProfileRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateMyUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateMyUserProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMyUserProfile.</param>
        public UpdateMyUserProfileResponse EndUpdateMyUserProfile(IAsyncResult asyncResult)
        {
            return endOperation<UpdateMyUserProfileResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateMyUserProfile(UpdateMyUserProfileRequest updateMyUserProfileRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateMyUserProfileRequestMarshaller().Marshall(updateMyUserProfileRequest);
            var unmarshaller = UpdateMyUserProfileResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Updates a user's SSH public key.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have self-management
        /// enabled or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <exception cref="ValidationException"/>
        public UpdateMyUserProfileResponse UpdateMyUserProfile()
        {
            return UpdateMyUserProfile(new UpdateMyUserProfileRequest());
        }
        

        #endregion
    
        #region DeregisterVolume

        /// <summary>
        /// <para>Deregisters an Amazon EBS volume. The volume can then be registered by another stack. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html" >Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="deregisterVolumeRequest">Container for the necessary parameters to execute the DeregisterVolume service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DeregisterVolumeResponse DeregisterVolume(DeregisterVolumeRequest deregisterVolumeRequest)
        {
            IAsyncResult asyncResult = invokeDeregisterVolume(deregisterVolumeRequest, null, null, true);
            return EndDeregisterVolume(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterVolume operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeregisterVolume"/>
        /// </summary>
        /// 
        /// <param name="deregisterVolumeRequest">Container for the necessary parameters to execute the DeregisterVolume operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeregisterVolume(DeregisterVolumeRequest deregisterVolumeRequest, AsyncCallback callback, object state)
        {
            return invokeDeregisterVolume(deregisterVolumeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeregisterVolume operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeregisterVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterVolume.</param>
        public DeregisterVolumeResponse EndDeregisterVolume(IAsyncResult asyncResult)
        {
            return endOperation<DeregisterVolumeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeregisterVolume(DeregisterVolumeRequest deregisterVolumeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeregisterVolumeRequestMarshaller().Marshall(deregisterVolumeRequest);
            var unmarshaller = DeregisterVolumeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetPermission

        /// <summary>
        /// <para>Specifies a stack's permissions. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingsecurity.html" >Security and Permissions</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="setPermissionRequest">Container for the necessary parameters to execute the SetPermission service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public SetPermissionResponse SetPermission(SetPermissionRequest setPermissionRequest)
        {
            IAsyncResult asyncResult = invokeSetPermission(setPermissionRequest, null, null, true);
            return EndSetPermission(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetPermission operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.SetPermission"/>
        /// </summary>
        /// 
        /// <param name="setPermissionRequest">Container for the necessary parameters to execute the SetPermission operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSetPermission(SetPermissionRequest setPermissionRequest, AsyncCallback callback, object state)
        {
            return invokeSetPermission(setPermissionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetPermission operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.SetPermission"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetPermission.</param>
        public SetPermissionResponse EndSetPermission(IAsyncResult asyncResult)
        {
            return endOperation<SetPermissionResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetPermission(SetPermissionRequest setPermissionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetPermissionRequestMarshaller().Marshall(setPermissionRequest);
            var unmarshaller = SetPermissionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeInstances

        /// <summary>
        /// <para>Requests a description of a set of instances.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para> <para>
        /// <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeInstancesRequest">Container for the necessary parameters to execute the DescribeInstances service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest describeInstancesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeInstances(describeInstancesRequest, null, null, true);
            return EndDescribeInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeInstances"/>
        /// </summary>
        /// 
        /// <param name="describeInstancesRequest">Container for the necessary parameters to execute the DescribeInstances operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstances
        ///         operation.</returns>
        public IAsyncResult BeginDescribeInstances(DescribeInstancesRequest describeInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeInstances(describeInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeInstances operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstances.</param>
        /// 
        /// <returns>Returns a DescribeInstancesResult from AmazonOpsWorks.</returns>
        public DescribeInstancesResponse EndDescribeInstances(IAsyncResult asyncResult)
        {
            return endOperation<DescribeInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeInstances(DescribeInstancesRequest describeInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeInstancesRequestMarshaller().Marshall(describeInstancesRequest);
            var unmarshaller = DescribeInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribePermissions

        /// <summary>
        /// <para>Describes the permissions for a specified stack.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have
        /// a Manage permissions level for the stack, or an attached policy that explicitly grants permissions. For more information on user
        /// permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="describePermissionsRequest">Container for the necessary parameters to execute the DescribePermissions service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribePermissions service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribePermissionsResponse DescribePermissions(DescribePermissionsRequest describePermissionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribePermissions(describePermissionsRequest, null, null, true);
            return EndDescribePermissions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePermissions operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribePermissions"/>
        /// </summary>
        /// 
        /// <param name="describePermissionsRequest">Container for the necessary parameters to execute the DescribePermissions operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribePermissions operation.</returns>
        public IAsyncResult BeginDescribePermissions(DescribePermissionsRequest describePermissionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribePermissions(describePermissionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribePermissions operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribePermissions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePermissions.</param>
        /// 
        /// <returns>Returns a DescribePermissionsResult from AmazonOpsWorks.</returns>
        public DescribePermissionsResponse EndDescribePermissions(IAsyncResult asyncResult)
        {
            return endOperation<DescribePermissionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribePermissions(DescribePermissionsRequest describePermissionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribePermissionsRequestMarshaller().Marshall(describePermissionsRequest);
            var unmarshaller = DescribePermissionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteInstance

        /// <summary>
        /// <para>Deletes a specified instance. You must stop an instance before you can delete it. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-delete.html" >Deleting Instances</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="deleteInstanceRequest">Container for the necessary parameters to execute the DeleteInstance service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest deleteInstanceRequest)
        {
            IAsyncResult asyncResult = invokeDeleteInstance(deleteInstanceRequest, null, null, true);
            return EndDeleteInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteInstance"/>
        /// </summary>
        /// 
        /// <param name="deleteInstanceRequest">Container for the necessary parameters to execute the DeleteInstance operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteInstance(DeleteInstanceRequest deleteInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteInstance(deleteInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstance.</param>
        public DeleteInstanceResponse EndDeleteInstance(IAsyncResult asyncResult)
        {
            return endOperation<DeleteInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteInstance(DeleteInstanceRequest deleteInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteInstanceRequestMarshaller().Marshall(deleteInstanceRequest);
            var unmarshaller = DeleteInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CloneStack

        /// <summary>
        /// <para>Creates a clone of a specified stack. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-cloning.html" >Clone a Stack</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have an attached policy that explicitly grants permissions. For more information on
        /// user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User
        /// Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="cloneStackRequest">Container for the necessary parameters to execute the CloneStack service method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CloneStack service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public CloneStackResponse CloneStack(CloneStackRequest cloneStackRequest)
        {
            IAsyncResult asyncResult = invokeCloneStack(cloneStackRequest, null, null, true);
            return EndCloneStack(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CloneStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CloneStack"/>
        /// </summary>
        /// 
        /// <param name="cloneStackRequest">Container for the necessary parameters to execute the CloneStack operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCloneStack
        ///         operation.</returns>
        public IAsyncResult BeginCloneStack(CloneStackRequest cloneStackRequest, AsyncCallback callback, object state)
        {
            return invokeCloneStack(cloneStackRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CloneStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CloneStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCloneStack.</param>
        /// 
        /// <returns>Returns a CloneStackResult from AmazonOpsWorks.</returns>
        public CloneStackResponse EndCloneStack(IAsyncResult asyncResult)
        {
            return endOperation<CloneStackResponse>(asyncResult);
        }
        
        IAsyncResult invokeCloneStack(CloneStackRequest cloneStackRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CloneStackRequestMarshaller().Marshall(cloneStackRequest);
            var unmarshaller = CloneStackResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DetachElasticLoadBalancer

        /// <summary>
        /// <para>Detaches a specified Elastic Load Balancing instance from its layer.</para> <para> <b>Required Permissions</b> : To use this action,
        /// an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly grants permissions. For more
        /// information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing
        /// User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="detachElasticLoadBalancerRequest">Container for the necessary parameters to execute the DetachElasticLoadBalancer service
        ///          method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        public DetachElasticLoadBalancerResponse DetachElasticLoadBalancer(DetachElasticLoadBalancerRequest detachElasticLoadBalancerRequest)
        {
            IAsyncResult asyncResult = invokeDetachElasticLoadBalancer(detachElasticLoadBalancerRequest, null, null, true);
            return EndDetachElasticLoadBalancer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DetachElasticLoadBalancer operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DetachElasticLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="detachElasticLoadBalancerRequest">Container for the necessary parameters to execute the DetachElasticLoadBalancer operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDetachElasticLoadBalancer(DetachElasticLoadBalancerRequest detachElasticLoadBalancerRequest, AsyncCallback callback, object state)
        {
            return invokeDetachElasticLoadBalancer(detachElasticLoadBalancerRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DetachElasticLoadBalancer operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DetachElasticLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachElasticLoadBalancer.</param>
        public DetachElasticLoadBalancerResponse EndDetachElasticLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation<DetachElasticLoadBalancerResponse>(asyncResult);
        }
        
        IAsyncResult invokeDetachElasticLoadBalancer(DetachElasticLoadBalancerRequest detachElasticLoadBalancerRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DetachElasticLoadBalancerRequestMarshaller().Marshall(detachElasticLoadBalancerRequest);
            var unmarshaller = DetachElasticLoadBalancerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region StopInstance

        /// <summary>
        /// <para>Stops a specified instance. When you stop a standard instance, the data disappears and must be reinstalled when you restart the
        /// instance. You can stop an Amazon EBS-backed instance without losing data. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-starting.html" >Starting, Stopping, and Rebooting Instances</a>
        /// .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="stopInstanceRequest">Container for the necessary parameters to execute the StopInstance service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public StopInstanceResponse StopInstance(StopInstanceRequest stopInstanceRequest)
        {
            IAsyncResult asyncResult = invokeStopInstance(stopInstanceRequest, null, null, true);
            return EndStopInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the StopInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StopInstance"/>
        /// </summary>
        /// 
        /// <param name="stopInstanceRequest">Container for the necessary parameters to execute the StopInstance operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginStopInstance(StopInstanceRequest stopInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeStopInstance(stopInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the StopInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StopInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInstance.</param>
        public StopInstanceResponse EndStopInstance(IAsyncResult asyncResult)
        {
            return endOperation<StopInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeStopInstance(StopInstanceRequest stopInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new StopInstanceRequestMarshaller().Marshall(stopInstanceRequest);
            var unmarshaller = StopInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateApp

        /// <summary>
        /// <para>Updates a specified app.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Deploy or Manage
        /// permissions level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateAppRequest">Container for the necessary parameters to execute the UpdateApp service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public UpdateAppResponse UpdateApp(UpdateAppRequest updateAppRequest)
        {
            IAsyncResult asyncResult = invokeUpdateApp(updateAppRequest, null, null, true);
            return EndUpdateApp(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateApp"/>
        /// </summary>
        /// 
        /// <param name="updateAppRequest">Container for the necessary parameters to execute the UpdateApp operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateApp(UpdateAppRequest updateAppRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateApp(updateAppRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateApp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateApp"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApp.</param>
        public UpdateAppResponse EndUpdateApp(IAsyncResult asyncResult)
        {
            return endOperation<UpdateAppResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateApp(UpdateAppRequest updateAppRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateAppRequestMarshaller().Marshall(updateAppRequest);
            var unmarshaller = UpdateAppResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeCommands

        /// <summary>
        /// <para>Describes the results of specified commands.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para> <para>
        /// <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeCommandsRequest">Container for the necessary parameters to execute the DescribeCommands service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeCommands service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeCommandsResponse DescribeCommands(DescribeCommandsRequest describeCommandsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeCommands(describeCommandsRequest, null, null, true);
            return EndDescribeCommands(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCommands operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeCommands"/>
        /// </summary>
        /// 
        /// <param name="describeCommandsRequest">Container for the necessary parameters to execute the DescribeCommands operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCommands
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCommands(DescribeCommandsRequest describeCommandsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeCommands(describeCommandsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCommands operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeCommands"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCommands.</param>
        /// 
        /// <returns>Returns a DescribeCommandsResult from AmazonOpsWorks.</returns>
        public DescribeCommandsResponse EndDescribeCommands(IAsyncResult asyncResult)
        {
            return endOperation<DescribeCommandsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeCommands(DescribeCommandsRequest describeCommandsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeCommandsRequestMarshaller().Marshall(describeCommandsRequest);
            var unmarshaller = DescribeCommandsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AssociateElasticIp

        /// <summary>
        /// <para>Associates one of the stack's registered Elastic IP addresses with a specified instance. The address must first be registered with the
        /// stack by calling RegisterElasticIp. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html"
        /// >Resource Management</a> .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level
        /// for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="associateElasticIpRequest">Container for the necessary parameters to execute the AssociateElasticIp service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public AssociateElasticIpResponse AssociateElasticIp(AssociateElasticIpRequest associateElasticIpRequest)
        {
            IAsyncResult asyncResult = invokeAssociateElasticIp(associateElasticIpRequest, null, null, true);
            return EndAssociateElasticIp(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.AssociateElasticIp"/>
        /// </summary>
        /// 
        /// <param name="associateElasticIpRequest">Container for the necessary parameters to execute the AssociateElasticIp operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginAssociateElasticIp(AssociateElasticIpRequest associateElasticIpRequest, AsyncCallback callback, object state)
        {
            return invokeAssociateElasticIp(associateElasticIpRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AssociateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.AssociateElasticIp"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateElasticIp.</param>
        public AssociateElasticIpResponse EndAssociateElasticIp(IAsyncResult asyncResult)
        {
            return endOperation<AssociateElasticIpResponse>(asyncResult);
        }
        
        IAsyncResult invokeAssociateElasticIp(AssociateElasticIpRequest associateElasticIpRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AssociateElasticIpRequestMarshaller().Marshall(associateElasticIpRequest);
            var unmarshaller = AssociateElasticIpResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UnassignVolume

        /// <summary>
        /// <para>Unassigns an assigned Amazon EBS volume. The volume remains registered with the stack. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html" >Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="unassignVolumeRequest">Container for the necessary parameters to execute the UnassignVolume service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public UnassignVolumeResponse UnassignVolume(UnassignVolumeRequest unassignVolumeRequest)
        {
            IAsyncResult asyncResult = invokeUnassignVolume(unassignVolumeRequest, null, null, true);
            return EndUnassignVolume(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UnassignVolume operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UnassignVolume"/>
        /// </summary>
        /// 
        /// <param name="unassignVolumeRequest">Container for the necessary parameters to execute the UnassignVolume operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUnassignVolume(UnassignVolumeRequest unassignVolumeRequest, AsyncCallback callback, object state)
        {
            return invokeUnassignVolume(unassignVolumeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UnassignVolume operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UnassignVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnassignVolume.</param>
        public UnassignVolumeResponse EndUnassignVolume(IAsyncResult asyncResult)
        {
            return endOperation<UnassignVolumeResponse>(asyncResult);
        }
        
        IAsyncResult invokeUnassignVolume(UnassignVolumeRequest unassignVolumeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UnassignVolumeRequestMarshaller().Marshall(unassignVolumeRequest);
            var unmarshaller = UnassignVolumeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeRaidArrays

        /// <summary>
        /// <para>Describe an instance's RAID arrays.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para> <para>
        /// <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeRaidArraysRequest">Container for the necessary parameters to execute the DescribeRaidArrays service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeRaidArrays service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeRaidArraysResponse DescribeRaidArrays(DescribeRaidArraysRequest describeRaidArraysRequest)
        {
            IAsyncResult asyncResult = invokeDescribeRaidArrays(describeRaidArraysRequest, null, null, true);
            return EndDescribeRaidArrays(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRaidArrays operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeRaidArrays"/>
        /// </summary>
        /// 
        /// <param name="describeRaidArraysRequest">Container for the necessary parameters to execute the DescribeRaidArrays operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeRaidArrays operation.</returns>
        public IAsyncResult BeginDescribeRaidArrays(DescribeRaidArraysRequest describeRaidArraysRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeRaidArrays(describeRaidArraysRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeRaidArrays operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeRaidArrays"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRaidArrays.</param>
        /// 
        /// <returns>Returns a DescribeRaidArraysResult from AmazonOpsWorks.</returns>
        public DescribeRaidArraysResponse EndDescribeRaidArrays(IAsyncResult asyncResult)
        {
            return endOperation<DescribeRaidArraysResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeRaidArrays(DescribeRaidArraysRequest describeRaidArraysRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeRaidArraysRequestMarshaller().Marshall(describeRaidArraysRequest);
            var unmarshaller = DescribeRaidArraysResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetHostnameSuggestion

        /// <summary>
        /// <para>Gets a generated host name for the specified layer, based on the current host name theme.</para> <para> <b>Required Permissions</b> :
        /// To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="getHostnameSuggestionRequest">Container for the necessary parameters to execute the GetHostnameSuggestion service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the GetHostnameSuggestion service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public GetHostnameSuggestionResponse GetHostnameSuggestion(GetHostnameSuggestionRequest getHostnameSuggestionRequest)
        {
            IAsyncResult asyncResult = invokeGetHostnameSuggestion(getHostnameSuggestionRequest, null, null, true);
            return EndGetHostnameSuggestion(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostnameSuggestion operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.GetHostnameSuggestion"/>
        /// </summary>
        /// 
        /// <param name="getHostnameSuggestionRequest">Container for the necessary parameters to execute the GetHostnameSuggestion operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetHostnameSuggestion operation.</returns>
        public IAsyncResult BeginGetHostnameSuggestion(GetHostnameSuggestionRequest getHostnameSuggestionRequest, AsyncCallback callback, object state)
        {
            return invokeGetHostnameSuggestion(getHostnameSuggestionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetHostnameSuggestion operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.GetHostnameSuggestion"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHostnameSuggestion.</param>
        /// 
        /// <returns>Returns a GetHostnameSuggestionResult from AmazonOpsWorks.</returns>
        public GetHostnameSuggestionResponse EndGetHostnameSuggestion(IAsyncResult asyncResult)
        {
            return endOperation<GetHostnameSuggestionResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetHostnameSuggestion(GetHostnameSuggestionRequest getHostnameSuggestionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetHostnameSuggestionRequestMarshaller().Marshall(getHostnameSuggestionRequest);
            var unmarshaller = GetHostnameSuggestionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetLoadBasedAutoScaling

        /// <summary>
        /// <para>Specify the load-based auto scaling configuration for a specified layer. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-autoscaling.html" >Managing Load with Time-based and Load-based
        /// Instances</a> .</para> <para><b>NOTE:</b>To use load-based auto scaling, you must create a set of load-based auto scaling instances.
        /// Load-based auto scaling operates only on the instances from that set, so you must ensure that you have created enough instances to handle
        /// the maximum anticipated load.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="setLoadBasedAutoScalingRequest">Container for the necessary parameters to execute the SetLoadBasedAutoScaling service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public SetLoadBasedAutoScalingResponse SetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest setLoadBasedAutoScalingRequest)
        {
            IAsyncResult asyncResult = invokeSetLoadBasedAutoScaling(setLoadBasedAutoScalingRequest, null, null, true);
            return EndSetLoadBasedAutoScaling(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.SetLoadBasedAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="setLoadBasedAutoScalingRequest">Container for the necessary parameters to execute the SetLoadBasedAutoScaling operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest setLoadBasedAutoScalingRequest, AsyncCallback callback, object state)
        {
            return invokeSetLoadBasedAutoScaling(setLoadBasedAutoScalingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetLoadBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.SetLoadBasedAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBasedAutoScaling.</param>
        public SetLoadBasedAutoScalingResponse EndSetLoadBasedAutoScaling(IAsyncResult asyncResult)
        {
            return endOperation<SetLoadBasedAutoScalingResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest setLoadBasedAutoScalingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetLoadBasedAutoScalingRequestMarshaller().Marshall(setLoadBasedAutoScalingRequest);
            var unmarshaller = SetLoadBasedAutoScalingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeVolumes

        /// <summary>
        /// <para>Describes an instance's Amazon EBS volumes.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para> <para>
        /// <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeVolumesRequest">Container for the necessary parameters to execute the DescribeVolumes service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest describeVolumesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeVolumes(describeVolumesRequest, null, null, true);
            return EndDescribeVolumes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeVolumes"/>
        /// </summary>
        /// 
        /// <param name="describeVolumesRequest">Container for the necessary parameters to execute the DescribeVolumes operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVolumes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVolumes(DescribeVolumesRequest describeVolumesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeVolumes(describeVolumesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVolumes operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeVolumes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumes.</param>
        /// 
        /// <returns>Returns a DescribeVolumesResult from AmazonOpsWorks.</returns>
        public DescribeVolumesResponse EndDescribeVolumes(IAsyncResult asyncResult)
        {
            return endOperation<DescribeVolumesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeVolumes(DescribeVolumesRequest describeVolumesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeVolumesRequestMarshaller().Marshall(describeVolumesRequest);
            var unmarshaller = DescribeVolumesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AssignVolume

        /// <summary>
        /// <para>Assigns one of the stack's registered Amazon EBS volumes to a specified instance. The volume must first be registered with the stack
        /// by calling RegisterVolume. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html" >Resource
        /// Management</a> .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the
        /// stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="assignVolumeRequest">Container for the necessary parameters to execute the AssignVolume service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public AssignVolumeResponse AssignVolume(AssignVolumeRequest assignVolumeRequest)
        {
            IAsyncResult asyncResult = invokeAssignVolume(assignVolumeRequest, null, null, true);
            return EndAssignVolume(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AssignVolume operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.AssignVolume"/>
        /// </summary>
        /// 
        /// <param name="assignVolumeRequest">Container for the necessary parameters to execute the AssignVolume operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginAssignVolume(AssignVolumeRequest assignVolumeRequest, AsyncCallback callback, object state)
        {
            return invokeAssignVolume(assignVolumeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AssignVolume operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.AssignVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssignVolume.</param>
        public AssignVolumeResponse EndAssignVolume(IAsyncResult asyncResult)
        {
            return endOperation<AssignVolumeResponse>(asyncResult);
        }
        
        IAsyncResult invokeAssignVolume(AssignVolumeRequest assignVolumeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AssignVolumeRequestMarshaller().Marshall(assignVolumeRequest);
            var unmarshaller = AssignVolumeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeServiceErrors

        /// <summary>
        /// <para>Describes AWS OpsWorks service errors.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show,
        /// Deploy, or Manage permissions level for the stack, or an attached policy that explicitly grants permissions. For more information on user
        /// permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="describeServiceErrorsRequest">Container for the necessary parameters to execute the DescribeServiceErrors service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeServiceErrors service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeServiceErrorsResponse DescribeServiceErrors(DescribeServiceErrorsRequest describeServiceErrorsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeServiceErrors(describeServiceErrorsRequest, null, null, true);
            return EndDescribeServiceErrors(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceErrors operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeServiceErrors"/>
        /// </summary>
        /// 
        /// <param name="describeServiceErrorsRequest">Container for the necessary parameters to execute the DescribeServiceErrors operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeServiceErrors operation.</returns>
        public IAsyncResult BeginDescribeServiceErrors(DescribeServiceErrorsRequest describeServiceErrorsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeServiceErrors(describeServiceErrorsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeServiceErrors operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeServiceErrors"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceErrors.</param>
        /// 
        /// <returns>Returns a DescribeServiceErrorsResult from AmazonOpsWorks.</returns>
        public DescribeServiceErrorsResponse EndDescribeServiceErrors(IAsyncResult asyncResult)
        {
            return endOperation<DescribeServiceErrorsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeServiceErrors(DescribeServiceErrorsRequest describeServiceErrorsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeServiceErrorsRequestMarshaller().Marshall(describeServiceErrorsRequest);
            var unmarshaller = DescribeServiceErrorsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Describes AWS OpsWorks service errors.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show,
        /// Deploy, or Manage permissions level for the stack, or an attached policy that explicitly grants permissions. For more information on user
        /// permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a>
        /// .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeServiceErrors service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeServiceErrorsResponse DescribeServiceErrors()
        {
            return DescribeServiceErrors(new DescribeServiceErrorsRequest());
        }
        

        #endregion
    
        #region UpdateLayer

        /// <summary>
        /// <para>Updates a specified layer.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateLayerRequest">Container for the necessary parameters to execute the UpdateLayer service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public UpdateLayerResponse UpdateLayer(UpdateLayerRequest updateLayerRequest)
        {
            IAsyncResult asyncResult = invokeUpdateLayer(updateLayerRequest, null, null, true);
            return EndUpdateLayer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLayer operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateLayer"/>
        /// </summary>
        /// 
        /// <param name="updateLayerRequest">Container for the necessary parameters to execute the UpdateLayer operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateLayer(UpdateLayerRequest updateLayerRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateLayer(updateLayerRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateLayer operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateLayer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLayer.</param>
        public UpdateLayerResponse EndUpdateLayer(IAsyncResult asyncResult)
        {
            return endOperation<UpdateLayerResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateLayer(UpdateLayerRequest updateLayerRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateLayerRequestMarshaller().Marshall(updateLayerRequest);
            var unmarshaller = UpdateLayerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateElasticIp

        /// <summary>
        /// <para>Updates a registered Elastic IP address's name. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html" >Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateElasticIpRequest">Container for the necessary parameters to execute the UpdateElasticIp service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public UpdateElasticIpResponse UpdateElasticIp(UpdateElasticIpRequest updateElasticIpRequest)
        {
            IAsyncResult asyncResult = invokeUpdateElasticIp(updateElasticIpRequest, null, null, true);
            return EndUpdateElasticIp(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateElasticIp"/>
        /// </summary>
        /// 
        /// <param name="updateElasticIpRequest">Container for the necessary parameters to execute the UpdateElasticIp operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateElasticIp(UpdateElasticIpRequest updateElasticIpRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateElasticIp(updateElasticIpRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateElasticIp"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateElasticIp.</param>
        public UpdateElasticIpResponse EndUpdateElasticIp(IAsyncResult asyncResult)
        {
            return endOperation<UpdateElasticIpResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateElasticIp(UpdateElasticIpRequest updateElasticIpRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateElasticIpRequestMarshaller().Marshall(updateElasticIpRequest);
            var unmarshaller = UpdateElasticIpResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region StartInstance

        /// <summary>
        /// <para>Starts a specified instance. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-starting.html" >Starting, Stopping, and Rebooting Instances</a>
        /// .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="startInstanceRequest">Container for the necessary parameters to execute the StartInstance service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public StartInstanceResponse StartInstance(StartInstanceRequest startInstanceRequest)
        {
            IAsyncResult asyncResult = invokeStartInstance(startInstanceRequest, null, null, true);
            return EndStartInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StartInstance"/>
        /// </summary>
        /// 
        /// <param name="startInstanceRequest">Container for the necessary parameters to execute the StartInstance operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginStartInstance(StartInstanceRequest startInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeStartInstance(startInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the StartInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StartInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstance.</param>
        public StartInstanceResponse EndStartInstance(IAsyncResult asyncResult)
        {
            return endOperation<StartInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeStartInstance(StartInstanceRequest startInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new StartInstanceRequestMarshaller().Marshall(startInstanceRequest);
            var unmarshaller = StartInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateLayer

        /// <summary>
        /// <para>Creates a layer. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-create.html" >How to Create a Layer</a> .</para>
        /// <para><b>NOTE:</b>You should use CreateLayer for noncustom layer types such as PHP App Server only if the stack does not have an existing
        /// layer of that type. A stack can have at most one instance of each noncustom layer; if you attempt to create a second instance, CreateLayer
        /// fails. A stack can have an arbitrary number of custom layers, so you can call CreateLayer as many times as you like for that layer
        /// type.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="createLayerRequest">Container for the necessary parameters to execute the CreateLayer service method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateLayer service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public CreateLayerResponse CreateLayer(CreateLayerRequest createLayerRequest)
        {
            IAsyncResult asyncResult = invokeCreateLayer(createLayerRequest, null, null, true);
            return EndCreateLayer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLayer operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateLayer"/>
        /// </summary>
        /// 
        /// <param name="createLayerRequest">Container for the necessary parameters to execute the CreateLayer operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLayer
        ///         operation.</returns>
        public IAsyncResult BeginCreateLayer(CreateLayerRequest createLayerRequest, AsyncCallback callback, object state)
        {
            return invokeCreateLayer(createLayerRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateLayer operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateLayer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLayer.</param>
        /// 
        /// <returns>Returns a CreateLayerResult from AmazonOpsWorks.</returns>
        public CreateLayerResponse EndCreateLayer(IAsyncResult asyncResult)
        {
            return endOperation<CreateLayerResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateLayer(CreateLayerRequest createLayerRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateLayerRequestMarshaller().Marshall(createLayerRequest);
            var unmarshaller = CreateLayerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DisassociateElasticIp

        /// <summary>
        /// <para>Disassociates an Elastic IP address from its instance. The address remains registered with the stack. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html" >Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="disassociateElasticIpRequest">Container for the necessary parameters to execute the DisassociateElasticIp service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DisassociateElasticIpResponse DisassociateElasticIp(DisassociateElasticIpRequest disassociateElasticIpRequest)
        {
            IAsyncResult asyncResult = invokeDisassociateElasticIp(disassociateElasticIpRequest, null, null, true);
            return EndDisassociateElasticIp(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DisassociateElasticIp"/>
        /// </summary>
        /// 
        /// <param name="disassociateElasticIpRequest">Container for the necessary parameters to execute the DisassociateElasticIp operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDisassociateElasticIp(DisassociateElasticIpRequest disassociateElasticIpRequest, AsyncCallback callback, object state)
        {
            return invokeDisassociateElasticIp(disassociateElasticIpRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DisassociateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DisassociateElasticIp"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateElasticIp.</param>
        public DisassociateElasticIpResponse EndDisassociateElasticIp(IAsyncResult asyncResult)
        {
            return endOperation<DisassociateElasticIpResponse>(asyncResult);
        }
        
        IAsyncResult invokeDisassociateElasticIp(DisassociateElasticIpRequest disassociateElasticIpRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DisassociateElasticIpRequestMarshaller().Marshall(disassociateElasticIpRequest);
            var unmarshaller = DisassociateElasticIpResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteStack

        /// <summary>
        /// <para>Deletes a specified stack. You must first delete all instances, layers, and apps. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-shutting.html" >Shut Down a Stack</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="deleteStackRequest">Container for the necessary parameters to execute the DeleteStack service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DeleteStackResponse DeleteStack(DeleteStackRequest deleteStackRequest)
        {
            IAsyncResult asyncResult = invokeDeleteStack(deleteStackRequest, null, null, true);
            return EndDeleteStack(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteStack"/>
        /// </summary>
        /// 
        /// <param name="deleteStackRequest">Container for the necessary parameters to execute the DeleteStack operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteStack(DeleteStackRequest deleteStackRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteStack(deleteStackRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStack.</param>
        public DeleteStackResponse EndDeleteStack(IAsyncResult asyncResult)
        {
            return endOperation<DeleteStackResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteStack(DeleteStackRequest deleteStackRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteStackRequestMarshaller().Marshall(deleteStackRequest);
            var unmarshaller = DeleteStackResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region StartStack

        /// <summary>
        /// <para>Starts stack's instances. </para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="startStackRequest">Container for the necessary parameters to execute the StartStack service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public StartStackResponse StartStack(StartStackRequest startStackRequest)
        {
            IAsyncResult asyncResult = invokeStartStack(startStackRequest, null, null, true);
            return EndStartStack(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the StartStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StartStack"/>
        /// </summary>
        /// 
        /// <param name="startStackRequest">Container for the necessary parameters to execute the StartStack operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginStartStack(StartStackRequest startStackRequest, AsyncCallback callback, object state)
        {
            return invokeStartStack(startStackRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the StartStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StartStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartStack.</param>
        public StartStackResponse EndStartStack(IAsyncResult asyncResult)
        {
            return endOperation<StartStackResponse>(asyncResult);
        }
        
        IAsyncResult invokeStartStack(StartStackRequest startStackRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new StartStackRequestMarshaller().Marshall(startStackRequest);
            var unmarshaller = StartStackResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RegisterVolume

        /// <summary>
        /// <para>Registers an Amazon EBS volume with a specified stack. A volume can be registered with only one stack at a time. If the volume is
        /// already registered, you must first deregister it by calling DeregisterVolume. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html" >Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="registerVolumeRequest">Container for the necessary parameters to execute the RegisterVolume service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the RegisterVolume service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public RegisterVolumeResponse RegisterVolume(RegisterVolumeRequest registerVolumeRequest)
        {
            IAsyncResult asyncResult = invokeRegisterVolume(registerVolumeRequest, null, null, true);
            return EndRegisterVolume(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterVolume operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.RegisterVolume"/>
        /// </summary>
        /// 
        /// <param name="registerVolumeRequest">Container for the necessary parameters to execute the RegisterVolume operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterVolume
        ///         operation.</returns>
        public IAsyncResult BeginRegisterVolume(RegisterVolumeRequest registerVolumeRequest, AsyncCallback callback, object state)
        {
            return invokeRegisterVolume(registerVolumeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RegisterVolume operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.RegisterVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterVolume.</param>
        /// 
        /// <returns>Returns a RegisterVolumeResult from AmazonOpsWorks.</returns>
        public RegisterVolumeResponse EndRegisterVolume(IAsyncResult asyncResult)
        {
            return endOperation<RegisterVolumeResponse>(asyncResult);
        }
        
        IAsyncResult invokeRegisterVolume(RegisterVolumeRequest registerVolumeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RegisterVolumeRequestMarshaller().Marshall(registerVolumeRequest);
            var unmarshaller = RegisterVolumeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateUserProfile

        /// <summary>
        /// <para>Updates a specified user profile.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have an attached
        /// policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateUserProfileRequest">Container for the necessary parameters to execute the UpdateUserProfile service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest updateUserProfileRequest)
        {
            IAsyncResult asyncResult = invokeUpdateUserProfile(updateUserProfileRequest, null, null, true);
            return EndUpdateUserProfile(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateUserProfile"/>
        /// </summary>
        /// 
        /// <param name="updateUserProfileRequest">Container for the necessary parameters to execute the UpdateUserProfile operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateUserProfile(UpdateUserProfileRequest updateUserProfileRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateUserProfile(updateUserProfileRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateUserProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserProfile.</param>
        public UpdateUserProfileResponse EndUpdateUserProfile(IAsyncResult asyncResult)
        {
            return endOperation<UpdateUserProfileResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateUserProfile(UpdateUserProfileRequest updateUserProfileRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateUserProfileRequestMarshaller().Marshall(updateUserProfileRequest);
            var unmarshaller = UpdateUserProfileResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RebootInstance

        /// <summary>
        /// <para>Reboots a specified instance. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-starting.html" >Starting, Stopping, and Rebooting Instances</a>
        /// .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="rebootInstanceRequest">Container for the necessary parameters to execute the RebootInstance service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public RebootInstanceResponse RebootInstance(RebootInstanceRequest rebootInstanceRequest)
        {
            IAsyncResult asyncResult = invokeRebootInstance(rebootInstanceRequest, null, null, true);
            return EndRebootInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.RebootInstance"/>
        /// </summary>
        /// 
        /// <param name="rebootInstanceRequest">Container for the necessary parameters to execute the RebootInstance operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRebootInstance(RebootInstanceRequest rebootInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeRebootInstance(rebootInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RebootInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.RebootInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootInstance.</param>
        public RebootInstanceResponse EndRebootInstance(IAsyncResult asyncResult)
        {
            return endOperation<RebootInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeRebootInstance(RebootInstanceRequest rebootInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RebootInstanceRequestMarshaller().Marshall(rebootInstanceRequest);
            var unmarshaller = RebootInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateStack

        /// <summary>
        /// <para>Creates a new stack. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-edit.html"
        /// >Create a New Stack</a> .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have an attached policy that
        /// explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="createStackRequest">Container for the necessary parameters to execute the CreateStack service method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ValidationException"/>
        public CreateStackResponse CreateStack(CreateStackRequest createStackRequest)
        {
            IAsyncResult asyncResult = invokeCreateStack(createStackRequest, null, null, true);
            return EndCreateStack(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateStack"/>
        /// </summary>
        /// 
        /// <param name="createStackRequest">Container for the necessary parameters to execute the CreateStack operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStack
        ///         operation.</returns>
        public IAsyncResult BeginCreateStack(CreateStackRequest createStackRequest, AsyncCallback callback, object state)
        {
            return invokeCreateStack(createStackRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStack.</param>
        /// 
        /// <returns>Returns a CreateStackResult from AmazonOpsWorks.</returns>
        public CreateStackResponse EndCreateStack(IAsyncResult asyncResult)
        {
            return endOperation<CreateStackResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateStack(CreateStackRequest createStackRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateStackRequestMarshaller().Marshall(createStackRequest);
            var unmarshaller = CreateStackResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateInstance

        /// <summary>
        /// <para>Creates an instance in a specified stack. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-add.html" >Adding an Instance to a Layer</a> .</para> <para>
        /// <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that
        /// explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="createInstanceRequest">Container for the necessary parameters to execute the CreateInstance service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateInstance service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest createInstanceRequest)
        {
            IAsyncResult asyncResult = invokeCreateInstance(createInstanceRequest, null, null, true);
            return EndCreateInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateInstance"/>
        /// </summary>
        /// 
        /// <param name="createInstanceRequest">Container for the necessary parameters to execute the CreateInstance operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstance
        ///         operation.</returns>
        public IAsyncResult BeginCreateInstance(CreateInstanceRequest createInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeCreateInstance(createInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstance.</param>
        /// 
        /// <returns>Returns a CreateInstanceResult from AmazonOpsWorks.</returns>
        public CreateInstanceResponse EndCreateInstance(IAsyncResult asyncResult)
        {
            return endOperation<CreateInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateInstance(CreateInstanceRequest createInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateInstanceRequestMarshaller().Marshall(createInstanceRequest);
            var unmarshaller = CreateInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteApp

        /// <summary>
        /// <para>Deletes a specified app.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="deleteAppRequest">Container for the necessary parameters to execute the DeleteApp service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DeleteAppResponse DeleteApp(DeleteAppRequest deleteAppRequest)
        {
            IAsyncResult asyncResult = invokeDeleteApp(deleteAppRequest, null, null, true);
            return EndDeleteApp(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteApp"/>
        /// </summary>
        /// 
        /// <param name="deleteAppRequest">Container for the necessary parameters to execute the DeleteApp operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteApp(DeleteAppRequest deleteAppRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteApp(deleteAppRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteApp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteApp"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        public DeleteAppResponse EndDeleteApp(IAsyncResult asyncResult)
        {
            return endOperation<DeleteAppResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteApp(DeleteAppRequest deleteAppRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteAppRequestMarshaller().Marshall(deleteAppRequest);
            var unmarshaller = DeleteAppResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeregisterElasticIp

        /// <summary>
        /// <para>Deregisters a specified Elastic IP address. The address can then be registered by another stack. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html" >Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="deregisterElasticIpRequest">Container for the necessary parameters to execute the DeregisterElasticIp service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DeregisterElasticIpResponse DeregisterElasticIp(DeregisterElasticIpRequest deregisterElasticIpRequest)
        {
            IAsyncResult asyncResult = invokeDeregisterElasticIp(deregisterElasticIpRequest, null, null, true);
            return EndDeregisterElasticIp(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeregisterElasticIp"/>
        /// </summary>
        /// 
        /// <param name="deregisterElasticIpRequest">Container for the necessary parameters to execute the DeregisterElasticIp operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeregisterElasticIp(DeregisterElasticIpRequest deregisterElasticIpRequest, AsyncCallback callback, object state)
        {
            return invokeDeregisterElasticIp(deregisterElasticIpRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeregisterElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeregisterElasticIp"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterElasticIp.</param>
        public DeregisterElasticIpResponse EndDeregisterElasticIp(IAsyncResult asyncResult)
        {
            return endOperation<DeregisterElasticIpResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeregisterElasticIp(DeregisterElasticIpRequest deregisterElasticIpRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeregisterElasticIpRequestMarshaller().Marshall(deregisterElasticIpRequest);
            var unmarshaller = DeregisterElasticIpResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AttachElasticLoadBalancer

        /// <summary>
        /// <para>Attaches an Elastic Load Balancing load balancer to a specified layer.</para> <para><b>NOTE:</b>You must create the Elastic Load
        /// Balancing instance separately, by using the Elastic Load Balancing console, API, or CLI. For more information, see Elastic Load Balancing
        /// Developer Guide.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the
        /// stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="attachElasticLoadBalancerRequest">Container for the necessary parameters to execute the AttachElasticLoadBalancer service
        ///          method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public AttachElasticLoadBalancerResponse AttachElasticLoadBalancer(AttachElasticLoadBalancerRequest attachElasticLoadBalancerRequest)
        {
            IAsyncResult asyncResult = invokeAttachElasticLoadBalancer(attachElasticLoadBalancerRequest, null, null, true);
            return EndAttachElasticLoadBalancer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AttachElasticLoadBalancer operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.AttachElasticLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="attachElasticLoadBalancerRequest">Container for the necessary parameters to execute the AttachElasticLoadBalancer operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginAttachElasticLoadBalancer(AttachElasticLoadBalancerRequest attachElasticLoadBalancerRequest, AsyncCallback callback, object state)
        {
            return invokeAttachElasticLoadBalancer(attachElasticLoadBalancerRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AttachElasticLoadBalancer operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.AttachElasticLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachElasticLoadBalancer.</param>
        public AttachElasticLoadBalancerResponse EndAttachElasticLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation<AttachElasticLoadBalancerResponse>(asyncResult);
        }
        
        IAsyncResult invokeAttachElasticLoadBalancer(AttachElasticLoadBalancerRequest attachElasticLoadBalancerRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AttachElasticLoadBalancerRequestMarshaller().Marshall(attachElasticLoadBalancerRequest);
            var unmarshaller = AttachElasticLoadBalancerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateStack

        /// <summary>
        /// <para>Updates a specified stack.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateStackRequest">Container for the necessary parameters to execute the UpdateStack service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public UpdateStackResponse UpdateStack(UpdateStackRequest updateStackRequest)
        {
            IAsyncResult asyncResult = invokeUpdateStack(updateStackRequest, null, null, true);
            return EndUpdateStack(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateStack"/>
        /// </summary>
        /// 
        /// <param name="updateStackRequest">Container for the necessary parameters to execute the UpdateStack operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateStack(UpdateStackRequest updateStackRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateStack(updateStackRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStack.</param>
        public UpdateStackResponse EndUpdateStack(IAsyncResult asyncResult)
        {
            return endOperation<UpdateStackResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateStack(UpdateStackRequest updateStackRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateStackRequestMarshaller().Marshall(updateStackRequest);
            var unmarshaller = UpdateStackResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateUserProfile

        /// <summary>
        /// <para>Creates a new user profile.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have an attached policy
        /// that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="createUserProfileRequest">Container for the necessary parameters to execute the CreateUserProfile service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ValidationException"/>
        public CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest createUserProfileRequest)
        {
            IAsyncResult asyncResult = invokeCreateUserProfile(createUserProfileRequest, null, null, true);
            return EndCreateUserProfile(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateUserProfile"/>
        /// </summary>
        /// 
        /// <param name="createUserProfileRequest">Container for the necessary parameters to execute the CreateUserProfile operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserProfile
        ///         operation.</returns>
        public IAsyncResult BeginCreateUserProfile(CreateUserProfileRequest createUserProfileRequest, AsyncCallback callback, object state)
        {
            return invokeCreateUserProfile(createUserProfileRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateUserProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserProfile.</param>
        /// 
        /// <returns>Returns a CreateUserProfileResult from AmazonOpsWorks.</returns>
        public CreateUserProfileResponse EndCreateUserProfile(IAsyncResult asyncResult)
        {
            return endOperation<CreateUserProfileResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateUserProfile(CreateUserProfileRequest createUserProfileRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateUserProfileRequestMarshaller().Marshall(createUserProfileRequest);
            var unmarshaller = CreateUserProfileResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeLayers

        /// <summary>
        /// <para>Requests a description of one or more layers in a specified stack.</para> <para><b>NOTE:</b>You must specify at least one of the
        /// parameters.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeLayersRequest">Container for the necessary parameters to execute the DescribeLayers service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeLayers service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeLayersResponse DescribeLayers(DescribeLayersRequest describeLayersRequest)
        {
            IAsyncResult asyncResult = invokeDescribeLayers(describeLayersRequest, null, null, true);
            return EndDescribeLayers(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLayers operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeLayers"/>
        /// </summary>
        /// 
        /// <param name="describeLayersRequest">Container for the necessary parameters to execute the DescribeLayers operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLayers
        ///         operation.</returns>
        public IAsyncResult BeginDescribeLayers(DescribeLayersRequest describeLayersRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeLayers(describeLayersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLayers operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeLayers"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLayers.</param>
        /// 
        /// <returns>Returns a DescribeLayersResult from AmazonOpsWorks.</returns>
        public DescribeLayersResponse EndDescribeLayers(IAsyncResult asyncResult)
        {
            return endOperation<DescribeLayersResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeLayers(DescribeLayersRequest describeLayersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeLayersRequestMarshaller().Marshall(describeLayersRequest);
            var unmarshaller = DescribeLayersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeLoadBasedAutoScaling

        /// <summary>
        /// <para>Describes load-based auto scaling configurations for specified layers.</para> <para><b>NOTE:</b>You must specify at least one of the
        /// parameters.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeLoadBasedAutoScalingRequest">Container for the necessary parameters to execute the DescribeLoadBasedAutoScaling service
        ///          method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeLoadBasedAutoScaling service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeLoadBasedAutoScalingResponse DescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest describeLoadBasedAutoScalingRequest)
        {
            IAsyncResult asyncResult = invokeDescribeLoadBasedAutoScaling(describeLoadBasedAutoScalingRequest, null, null, true);
            return EndDescribeLoadBasedAutoScaling(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeLoadBasedAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="describeLoadBasedAutoScalingRequest">Container for the necessary parameters to execute the DescribeLoadBasedAutoScaling
        ///          operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeLoadBasedAutoScaling operation.</returns>
        public IAsyncResult BeginDescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest describeLoadBasedAutoScalingRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeLoadBasedAutoScaling(describeLoadBasedAutoScalingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLoadBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeLoadBasedAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a DescribeLoadBasedAutoScalingResult from AmazonOpsWorks.</returns>
        public DescribeLoadBasedAutoScalingResponse EndDescribeLoadBasedAutoScaling(IAsyncResult asyncResult)
        {
            return endOperation<DescribeLoadBasedAutoScalingResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest describeLoadBasedAutoScalingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeLoadBasedAutoScalingRequestMarshaller().Marshall(describeLoadBasedAutoScalingRequest);
            var unmarshaller = DescribeLoadBasedAutoScalingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeElasticLoadBalancers

        /// <summary>
        /// <para>Describes a stack's Elastic Load Balancing instances.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
        /// <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or
        /// an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeElasticLoadBalancersRequest">Container for the necessary parameters to execute the DescribeElasticLoadBalancers service
        ///          method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeElasticLoadBalancers service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers(DescribeElasticLoadBalancersRequest describeElasticLoadBalancersRequest)
        {
            IAsyncResult asyncResult = invokeDescribeElasticLoadBalancers(describeElasticLoadBalancersRequest, null, null, true);
            return EndDescribeElasticLoadBalancers(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticLoadBalancers operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeElasticLoadBalancers"/>
        /// </summary>
        /// 
        /// <param name="describeElasticLoadBalancersRequest">Container for the necessary parameters to execute the DescribeElasticLoadBalancers
        ///          operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeElasticLoadBalancers operation.</returns>
        public IAsyncResult BeginDescribeElasticLoadBalancers(DescribeElasticLoadBalancersRequest describeElasticLoadBalancersRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeElasticLoadBalancers(describeElasticLoadBalancersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeElasticLoadBalancers operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeElasticLoadBalancers"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticLoadBalancers.</param>
        /// 
        /// <returns>Returns a DescribeElasticLoadBalancersResult from AmazonOpsWorks.</returns>
        public DescribeElasticLoadBalancersResponse EndDescribeElasticLoadBalancers(IAsyncResult asyncResult)
        {
            return endOperation<DescribeElasticLoadBalancersResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeElasticLoadBalancers(DescribeElasticLoadBalancersRequest describeElasticLoadBalancersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeElasticLoadBalancersRequestMarshaller().Marshall(describeElasticLoadBalancersRequest);
            var unmarshaller = DescribeElasticLoadBalancersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Describes a stack's Elastic Load Balancing instances.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
        /// <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or
        /// an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeElasticLoadBalancers service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeElasticLoadBalancersResponse DescribeElasticLoadBalancers()
        {
            return DescribeElasticLoadBalancers(new DescribeElasticLoadBalancersRequest());
        }
        

        #endregion
    
        #region DeleteLayer

        /// <summary>
        /// <para>Deletes a specified layer. You must first stop and then delete all associated instances. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-delete.html" >How to Delete a Layer</a> .</para> <para>
        /// <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that
        /// explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="deleteLayerRequest">Container for the necessary parameters to execute the DeleteLayer service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DeleteLayerResponse DeleteLayer(DeleteLayerRequest deleteLayerRequest)
        {
            IAsyncResult asyncResult = invokeDeleteLayer(deleteLayerRequest, null, null, true);
            return EndDeleteLayer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLayer operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteLayer"/>
        /// </summary>
        /// 
        /// <param name="deleteLayerRequest">Container for the necessary parameters to execute the DeleteLayer operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteLayer(DeleteLayerRequest deleteLayerRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteLayer(deleteLayerRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLayer operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteLayer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLayer.</param>
        public DeleteLayerResponse EndDeleteLayer(IAsyncResult asyncResult)
        {
            return endOperation<DeleteLayerResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteLayer(DeleteLayerRequest deleteLayerRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteLayerRequestMarshaller().Marshall(deleteLayerRequest);
            var unmarshaller = DeleteLayerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeMyUserProfile

        /// <summary>
        /// <para>Describes a user's SSH information.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have
        /// self-management enabled or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeMyUserProfileRequest">Container for the necessary parameters to execute the DescribeMyUserProfile service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeMyUserProfile service method, as returned by AmazonOpsWorks.</returns>
        /// 
        public DescribeMyUserProfileResponse DescribeMyUserProfile(DescribeMyUserProfileRequest describeMyUserProfileRequest)
        {
            IAsyncResult asyncResult = invokeDescribeMyUserProfile(describeMyUserProfileRequest, null, null, true);
            return EndDescribeMyUserProfile(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMyUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeMyUserProfile"/>
        /// </summary>
        /// 
        /// <param name="describeMyUserProfileRequest">Container for the necessary parameters to execute the DescribeMyUserProfile operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeMyUserProfile operation.</returns>
        public IAsyncResult BeginDescribeMyUserProfile(DescribeMyUserProfileRequest describeMyUserProfileRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeMyUserProfile(describeMyUserProfileRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeMyUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeMyUserProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMyUserProfile.</param>
        /// 
        /// <returns>Returns a DescribeMyUserProfileResult from AmazonOpsWorks.</returns>
        public DescribeMyUserProfileResponse EndDescribeMyUserProfile(IAsyncResult asyncResult)
        {
            return endOperation<DescribeMyUserProfileResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeMyUserProfile(DescribeMyUserProfileRequest describeMyUserProfileRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeMyUserProfileRequestMarshaller().Marshall(describeMyUserProfileRequest);
            var unmarshaller = DescribeMyUserProfileResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Describes a user's SSH information.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have
        /// self-management enabled or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeMyUserProfile service method, as returned by AmazonOpsWorks.</returns>
        /// 
        public DescribeMyUserProfileResponse DescribeMyUserProfile()
        {
            return DescribeMyUserProfile(new DescribeMyUserProfileRequest());
        }
        

        #endregion
    
        #region SetTimeBasedAutoScaling

        /// <summary>
        /// <para>Specify the time-based auto scaling configuration for a specified instance. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-autoscaling.html" >Managing Load with Time-based and Load-based
        /// Instances</a> .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the
        /// stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="setTimeBasedAutoScalingRequest">Container for the necessary parameters to execute the SetTimeBasedAutoScaling service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public SetTimeBasedAutoScalingResponse SetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest setTimeBasedAutoScalingRequest)
        {
            IAsyncResult asyncResult = invokeSetTimeBasedAutoScaling(setTimeBasedAutoScalingRequest, null, null, true);
            return EndSetTimeBasedAutoScaling(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetTimeBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.SetTimeBasedAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="setTimeBasedAutoScalingRequest">Container for the necessary parameters to execute the SetTimeBasedAutoScaling operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest setTimeBasedAutoScalingRequest, AsyncCallback callback, object state)
        {
            return invokeSetTimeBasedAutoScaling(setTimeBasedAutoScalingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetTimeBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.SetTimeBasedAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTimeBasedAutoScaling.</param>
        public SetTimeBasedAutoScalingResponse EndSetTimeBasedAutoScaling(IAsyncResult asyncResult)
        {
            return endOperation<SetTimeBasedAutoScalingResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest setTimeBasedAutoScalingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetTimeBasedAutoScalingRequestMarshaller().Marshall(setTimeBasedAutoScalingRequest);
            var unmarshaller = SetTimeBasedAutoScalingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateApp

        /// <summary>
        /// <para>Creates an app for a specified stack. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-creating.html" >Creating Apps</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="createAppRequest">Container for the necessary parameters to execute the CreateApp service method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public CreateAppResponse CreateApp(CreateAppRequest createAppRequest)
        {
            IAsyncResult asyncResult = invokeCreateApp(createAppRequest, null, null, true);
            return EndCreateApp(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateApp"/>
        /// </summary>
        /// 
        /// <param name="createAppRequest">Container for the necessary parameters to execute the CreateApp operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApp
        ///         operation.</returns>
        public IAsyncResult BeginCreateApp(CreateAppRequest createAppRequest, AsyncCallback callback, object state)
        {
            return invokeCreateApp(createAppRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateApp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateApp"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApp.</param>
        /// 
        /// <returns>Returns a CreateAppResult from AmazonOpsWorks.</returns>
        public CreateAppResponse EndCreateApp(IAsyncResult asyncResult)
        {
            return endOperation<CreateAppResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateApp(CreateAppRequest createAppRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateAppRequestMarshaller().Marshall(createAppRequest);
            var unmarshaller = CreateAppResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteUserProfile

        /// <summary>
        /// <para>Deletes a user profile.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have an attached policy that
        /// explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="deleteUserProfileRequest">Container for the necessary parameters to execute the DeleteUserProfile service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest deleteUserProfileRequest)
        {
            IAsyncResult asyncResult = invokeDeleteUserProfile(deleteUserProfileRequest, null, null, true);
            return EndDeleteUserProfile(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteUserProfile"/>
        /// </summary>
        /// 
        /// <param name="deleteUserProfileRequest">Container for the necessary parameters to execute the DeleteUserProfile operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteUserProfile(DeleteUserProfileRequest deleteUserProfileRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteUserProfile(deleteUserProfileRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteUserProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserProfile.</param>
        public DeleteUserProfileResponse EndDeleteUserProfile(IAsyncResult asyncResult)
        {
            return endOperation<DeleteUserProfileResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteUserProfile(DeleteUserProfileRequest deleteUserProfileRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteUserProfileRequestMarshaller().Marshall(deleteUserProfileRequest);
            var unmarshaller = DeleteUserProfileResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeTimeBasedAutoScaling

        /// <summary>
        /// <para>Describes time-based auto scaling configurations for specified instances.</para> <para><b>NOTE:</b>You must specify at least one of
        /// the parameters.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeTimeBasedAutoScalingRequest">Container for the necessary parameters to execute the DescribeTimeBasedAutoScaling service
        ///          method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeTimeBasedAutoScaling service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeTimeBasedAutoScalingResponse DescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest describeTimeBasedAutoScalingRequest)
        {
            IAsyncResult asyncResult = invokeDescribeTimeBasedAutoScaling(describeTimeBasedAutoScalingRequest, null, null, true);
            return EndDescribeTimeBasedAutoScaling(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTimeBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeTimeBasedAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="describeTimeBasedAutoScalingRequest">Container for the necessary parameters to execute the DescribeTimeBasedAutoScaling
        ///          operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeTimeBasedAutoScaling operation.</returns>
        public IAsyncResult BeginDescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest describeTimeBasedAutoScalingRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeTimeBasedAutoScaling(describeTimeBasedAutoScalingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeTimeBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeTimeBasedAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTimeBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a DescribeTimeBasedAutoScalingResult from AmazonOpsWorks.</returns>
        public DescribeTimeBasedAutoScalingResponse EndDescribeTimeBasedAutoScaling(IAsyncResult asyncResult)
        {
            return endOperation<DescribeTimeBasedAutoScalingResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest describeTimeBasedAutoScalingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeTimeBasedAutoScalingRequestMarshaller().Marshall(describeTimeBasedAutoScalingRequest);
            var unmarshaller = DescribeTimeBasedAutoScalingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateVolume

        /// <summary>
        /// <para>Updates an Amazon EBS volume's name or mount point. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html" >Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateVolumeRequest">Container for the necessary parameters to execute the UpdateVolume service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public UpdateVolumeResponse UpdateVolume(UpdateVolumeRequest updateVolumeRequest)
        {
            IAsyncResult asyncResult = invokeUpdateVolume(updateVolumeRequest, null, null, true);
            return EndUpdateVolume(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVolume operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateVolume"/>
        /// </summary>
        /// 
        /// <param name="updateVolumeRequest">Container for the necessary parameters to execute the UpdateVolume operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateVolume(UpdateVolumeRequest updateVolumeRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateVolume(updateVolumeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateVolume operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVolume.</param>
        public UpdateVolumeResponse EndUpdateVolume(IAsyncResult asyncResult)
        {
            return endOperation<UpdateVolumeResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateVolume(UpdateVolumeRequest updateVolumeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateVolumeRequestMarshaller().Marshall(updateVolumeRequest);
            var unmarshaller = UpdateVolumeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeUserProfiles

        /// <summary>
        /// <para>Describe specified users.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have an attached policy
        /// that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeUserProfilesRequest">Container for the necessary parameters to execute the DescribeUserProfiles service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeUserProfiles service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeUserProfilesResponse DescribeUserProfiles(DescribeUserProfilesRequest describeUserProfilesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeUserProfiles(describeUserProfilesRequest, null, null, true);
            return EndDescribeUserProfiles(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserProfiles operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeUserProfiles"/>
        /// </summary>
        /// 
        /// <param name="describeUserProfilesRequest">Container for the necessary parameters to execute the DescribeUserProfiles operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeUserProfiles operation.</returns>
        public IAsyncResult BeginDescribeUserProfiles(DescribeUserProfilesRequest describeUserProfilesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeUserProfiles(describeUserProfilesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeUserProfiles operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeUserProfiles"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserProfiles.</param>
        /// 
        /// <returns>Returns a DescribeUserProfilesResult from AmazonOpsWorks.</returns>
        public DescribeUserProfilesResponse EndDescribeUserProfiles(IAsyncResult asyncResult)
        {
            return endOperation<DescribeUserProfilesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeUserProfiles(DescribeUserProfilesRequest describeUserProfilesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeUserProfilesRequestMarshaller().Marshall(describeUserProfilesRequest);
            var unmarshaller = DescribeUserProfilesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Describe specified users.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have an attached policy
        /// that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeUserProfiles service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeUserProfilesResponse DescribeUserProfiles()
        {
            return DescribeUserProfiles(new DescribeUserProfilesRequest());
        }
        

        #endregion
    
        #region UpdateInstance

        /// <summary>
        /// <para>Updates a specified instance.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage
        /// permissions level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateInstanceRequest">Container for the necessary parameters to execute the UpdateInstance service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest updateInstanceRequest)
        {
            IAsyncResult asyncResult = invokeUpdateInstance(updateInstanceRequest, null, null, true);
            return EndUpdateInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateInstance"/>
        /// </summary>
        /// 
        /// <param name="updateInstanceRequest">Container for the necessary parameters to execute the UpdateInstance operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateInstance(UpdateInstanceRequest updateInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateInstance(updateInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstance.</param>
        public UpdateInstanceResponse EndUpdateInstance(IAsyncResult asyncResult)
        {
            return endOperation<UpdateInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateInstance(UpdateInstanceRequest updateInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateInstanceRequestMarshaller().Marshall(updateInstanceRequest);
            var unmarshaller = UpdateInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeDeployments

        /// <summary>
        /// <para>Requests a description of a specified set of deployments.</para> <para><b>NOTE:</b>You must specify at least one of the
        /// parameters.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeDeploymentsRequest">Container for the necessary parameters to execute the DescribeDeployments service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeDeployments service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeDeploymentsResponse DescribeDeployments(DescribeDeploymentsRequest describeDeploymentsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDeployments(describeDeploymentsRequest, null, null, true);
            return EndDescribeDeployments(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeployments operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeDeployments"/>
        /// </summary>
        /// 
        /// <param name="describeDeploymentsRequest">Container for the necessary parameters to execute the DescribeDeployments operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDeployments operation.</returns>
        public IAsyncResult BeginDescribeDeployments(DescribeDeploymentsRequest describeDeploymentsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDeployments(describeDeploymentsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDeployments operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeDeployments"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeployments.</param>
        /// 
        /// <returns>Returns a DescribeDeploymentsResult from AmazonOpsWorks.</returns>
        public DescribeDeploymentsResponse EndDescribeDeployments(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDeploymentsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDeployments(DescribeDeploymentsRequest describeDeploymentsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDeploymentsRequestMarshaller().Marshall(describeDeploymentsRequest);
            var unmarshaller = DescribeDeploymentsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RegisterElasticIp

        /// <summary>
        /// <para>Registers an Elastic IP address with a specified stack. An address can be registered with only one stack at a time. If the address is
        /// already registered, you must first deregister it by calling DeregisterElasticIp. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html" >Resource Management</a> .</para> <para> <b>Required
        /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
        /// grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="registerElasticIpRequest">Container for the necessary parameters to execute the RegisterElasticIp service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the RegisterElasticIp service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public RegisterElasticIpResponse RegisterElasticIp(RegisterElasticIpRequest registerElasticIpRequest)
        {
            IAsyncResult asyncResult = invokeRegisterElasticIp(registerElasticIpRequest, null, null, true);
            return EndRegisterElasticIp(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.RegisterElasticIp"/>
        /// </summary>
        /// 
        /// <param name="registerElasticIpRequest">Container for the necessary parameters to execute the RegisterElasticIp operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterElasticIp
        ///         operation.</returns>
        public IAsyncResult BeginRegisterElasticIp(RegisterElasticIpRequest registerElasticIpRequest, AsyncCallback callback, object state)
        {
            return invokeRegisterElasticIp(registerElasticIpRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RegisterElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.RegisterElasticIp"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterElasticIp.</param>
        /// 
        /// <returns>Returns a RegisterElasticIpResult from AmazonOpsWorks.</returns>
        public RegisterElasticIpResponse EndRegisterElasticIp(IAsyncResult asyncResult)
        {
            return endOperation<RegisterElasticIpResponse>(asyncResult);
        }
        
        IAsyncResult invokeRegisterElasticIp(RegisterElasticIpRequest registerElasticIpRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RegisterElasticIpRequestMarshaller().Marshall(registerElasticIpRequest);
            var unmarshaller = RegisterElasticIpResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeElasticIps

        /// <summary>
        /// <para>Describes <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic IP addresses</a>
        /// .</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para> <para> <b>Required Permissions</b> : To use this action,
        /// an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or an attached policy that explicitly grants permissions.
        /// For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html"
        /// >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeElasticIpsRequest">Container for the necessary parameters to execute the DescribeElasticIps service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeElasticIps service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeElasticIpsResponse DescribeElasticIps(DescribeElasticIpsRequest describeElasticIpsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeElasticIps(describeElasticIpsRequest, null, null, true);
            return EndDescribeElasticIps(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticIps operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeElasticIps"/>
        /// </summary>
        /// 
        /// <param name="describeElasticIpsRequest">Container for the necessary parameters to execute the DescribeElasticIps operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeElasticIps operation.</returns>
        public IAsyncResult BeginDescribeElasticIps(DescribeElasticIpsRequest describeElasticIpsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeElasticIps(describeElasticIpsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeElasticIps operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeElasticIps"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticIps.</param>
        /// 
        /// <returns>Returns a DescribeElasticIpsResult from AmazonOpsWorks.</returns>
        public DescribeElasticIpsResponse EndDescribeElasticIps(IAsyncResult asyncResult)
        {
            return endOperation<DescribeElasticIpsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeElasticIps(DescribeElasticIpsRequest describeElasticIpsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeElasticIpsRequestMarshaller().Marshall(describeElasticIpsRequest);
            var unmarshaller = DescribeElasticIpsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeStacks

        /// <summary>
        /// <para>Requests a description of one or more stacks.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a
        /// Show, Deploy, or Manage permissions level for the stack, or an attached policy that explicitly grants permissions. For more information on
        /// user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User
        /// Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeStacksRequest">Container for the necessary parameters to execute the DescribeStacks service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeStacksResponse DescribeStacks(DescribeStacksRequest describeStacksRequest)
        {
            IAsyncResult asyncResult = invokeDescribeStacks(describeStacksRequest, null, null, true);
            return EndDescribeStacks(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeStacks"/>
        /// </summary>
        /// 
        /// <param name="describeStacksRequest">Container for the necessary parameters to execute the DescribeStacks operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStacks
        ///         operation.</returns>
        public IAsyncResult BeginDescribeStacks(DescribeStacksRequest describeStacksRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeStacks(describeStacksRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStacks operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeStacks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStacks.</param>
        /// 
        /// <returns>Returns a DescribeStacksResult from AmazonOpsWorks.</returns>
        public DescribeStacksResponse EndDescribeStacks(IAsyncResult asyncResult)
        {
            return endOperation<DescribeStacksResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeStacks(DescribeStacksRequest describeStacksRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeStacksRequestMarshaller().Marshall(describeStacksRequest);
            var unmarshaller = DescribeStacksResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Requests a description of one or more stacks.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a
        /// Show, Deploy, or Manage permissions level for the stack, or an attached policy that explicitly grants permissions. For more information on
        /// user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User
        /// Permissions</a> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeStacksResponse DescribeStacks()
        {
            return DescribeStacks(new DescribeStacksRequest());
        }
        

        #endregion
    
        #region DescribeApps

        /// <summary>
        /// <para>Requests a description of a specified set of apps.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
        /// <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or
        /// an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeAppsRequest">Container for the necessary parameters to execute the DescribeApps service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeApps service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeAppsResponse DescribeApps(DescribeAppsRequest describeAppsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeApps(describeAppsRequest, null, null, true);
            return EndDescribeApps(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApps operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeApps"/>
        /// </summary>
        /// 
        /// <param name="describeAppsRequest">Container for the necessary parameters to execute the DescribeApps operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApps
        ///         operation.</returns>
        public IAsyncResult BeginDescribeApps(DescribeAppsRequest describeAppsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeApps(describeAppsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeApps operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeApps"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApps.</param>
        /// 
        /// <returns>Returns a DescribeAppsResult from AmazonOpsWorks.</returns>
        public DescribeAppsResponse EndDescribeApps(IAsyncResult asyncResult)
        {
            return endOperation<DescribeAppsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeApps(DescribeAppsRequest describeAppsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAppsRequestMarshaller().Marshall(describeAppsRequest);
            var unmarshaller = DescribeAppsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeStackSummary

        /// <summary>
        /// <para>Describes the number of layers and apps in a specified stack, and the number of instances in each state, such as <c>running_setup</c>
        /// or <c>online</c> .</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage
        /// permissions level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeStackSummaryRequest">Container for the necessary parameters to execute the DescribeStackSummary service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeStackSummary service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public DescribeStackSummaryResponse DescribeStackSummary(DescribeStackSummaryRequest describeStackSummaryRequest)
        {
            IAsyncResult asyncResult = invokeDescribeStackSummary(describeStackSummaryRequest, null, null, true);
            return EndDescribeStackSummary(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackSummary operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeStackSummary"/>
        /// </summary>
        /// 
        /// <param name="describeStackSummaryRequest">Container for the necessary parameters to execute the DescribeStackSummary operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeStackSummary operation.</returns>
        public IAsyncResult BeginDescribeStackSummary(DescribeStackSummaryRequest describeStackSummaryRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeStackSummary(describeStackSummaryRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStackSummary operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeStackSummary"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackSummary.</param>
        /// 
        /// <returns>Returns a DescribeStackSummaryResult from AmazonOpsWorks.</returns>
        public DescribeStackSummaryResponse EndDescribeStackSummary(IAsyncResult asyncResult)
        {
            return endOperation<DescribeStackSummaryResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeStackSummary(DescribeStackSummaryRequest describeStackSummaryRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeStackSummaryRequestMarshaller().Marshall(describeStackSummaryRequest);
            var unmarshaller = DescribeStackSummaryResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region StopStack

        /// <summary>
        /// <para>Stops a specified stack.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions
        /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="stopStackRequest">Container for the necessary parameters to execute the StopStack service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public StopStackResponse StopStack(StopStackRequest stopStackRequest)
        {
            IAsyncResult asyncResult = invokeStopStack(stopStackRequest, null, null, true);
            return EndStopStack(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the StopStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StopStack"/>
        /// </summary>
        /// 
        /// <param name="stopStackRequest">Container for the necessary parameters to execute the StopStack operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginStopStack(StopStackRequest stopStackRequest, AsyncCallback callback, object state)
        {
            return invokeStopStack(stopStackRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the StopStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StopStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopStack.</param>
        public StopStackResponse EndStopStack(IAsyncResult asyncResult)
        {
            return endOperation<StopStackResponse>(asyncResult);
        }
        
        IAsyncResult invokeStopStack(StopStackRequest stopStackRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new StopStackRequestMarshaller().Marshall(stopStackRequest);
            var unmarshaller = StopStackResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDeployment

        /// <summary>
        /// <para>Deploys a stack or app.</para>
        /// <ul>
        /// <li>App deployment generates a <c>deploy</c> event, which runs the associated recipes and passes them a JSON stack configuration object
        /// that includes information about the app. </li>
        /// <li>Stack deployment runs the <c>deploy</c> recipes but does not raise an event.</li>
        /// 
        /// </ul>
        /// <para>For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-deploying.html" >Deploying
        /// Apps</a> and <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-commands.html" >Run Stack Commands</a> .</para>
        /// <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Deploy or Manage permissions level for the stack, or an
        /// attached policy that explicitly grants permissions. For more information on user permissions, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
        /// </summary>
        /// 
        /// <param name="createDeploymentRequest">Container for the necessary parameters to execute the CreateDeployment service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        public CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest createDeploymentRequest)
        {
            IAsyncResult asyncResult = invokeCreateDeployment(createDeploymentRequest, null, null, true);
            return EndCreateDeployment(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateDeployment"/>
        /// </summary>
        /// 
        /// <param name="createDeploymentRequest">Container for the necessary parameters to execute the CreateDeployment operation on
        ///          AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeployment
        ///         operation.</returns>
        public IAsyncResult BeginCreateDeployment(CreateDeploymentRequest createDeploymentRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDeployment(createDeploymentRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDeployment operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateDeployment"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a CreateDeploymentResult from AmazonOpsWorks.</returns>
        public CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult)
        {
            return endOperation<CreateDeploymentResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDeployment(CreateDeploymentRequest createDeploymentRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDeploymentRequestMarshaller().Marshall(createDeploymentRequest);
            var unmarshaller = CreateDeploymentResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
