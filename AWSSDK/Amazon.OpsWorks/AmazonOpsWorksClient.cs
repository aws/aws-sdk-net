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
    /// the AWS OpsWorks details page. </para> <para> <b>Endpoints</b> </para> <para>AWS OpsWorks supports only one endpoint,
    /// opsworks.us-east-1.amazonaws.com (HTTPS), so you must connect to that endpoint. You can then use the API to direct AWS OpsWorks to create
    /// stacks in any AWS Region.</para> <para>When you call CreateStack CloneStack or UpdateStack you can optionally use the
    /// <c>ConfigurationManager</c> parameter to specify the Chef version, 0.9 or 11.4. The default value is currently 0.9. However, we expect to
    /// change the default value to 11.4 in late August.</para>
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
   
        #region UpdateUserProfile

        /// <summary>
        /// <para>Updates a specified user profile.</para>
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
    
        #region CreateStack

        /// <summary>
        /// <para>Creates a new stack. For more information, see Create a New Stack.</para>
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
    
        #region RebootInstance

        /// <summary>
        /// <para>Reboots a specified instance. For more information, see Starting, Stopping, and Rebooting Instances.</para>
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
    
        #region SetPermission

        /// <summary>
        /// <para>Specifies a stack's permissions. For more information, see Security and Permissions.</para>
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
        /// <para>Requests a description of a set of instances associated with a specified ID or IDs.</para>
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
        /// <para>Describes the permissions for a specified stack.</para>
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
        /// <para>Deletes a specified instance. You must stop an instance before you can delete it. For more information, see Deleting Instances.</para>
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
        /// <para>Creates a clone of a specified stack. For more information, see Clone a Stack.</para>
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
    
        #region CreateInstance

        /// <summary>
        /// <para>Creates an instance in a specified stack. For more information, see Adding an Instance to a Layer.</para>
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
    
        #region StopInstance

        /// <summary>
        /// <para>Stops a specified instance. When you stop a standard instance, the data disappears and must be reinstalled when you restart the
        /// instance. You can stop an Amazon EBS-backed instance without losing data. For more information, see Starting, Stopping, and Rebooting
        /// Instances.</para>
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
    
        #region DetachElasticLoadBalancer

        /// <summary>
        /// <para>Detaches a specified Elastic Load Balancing instance from it's layer.</para>
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
    
        #region UpdateApp

        /// <summary>
        /// <para>Updates a specified app.</para>
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
    
        #region DeleteApp

        /// <summary>
        /// <para>Deletes a specified app.</para>
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
    
        #region AttachElasticLoadBalancer

        /// <summary>
        /// <para>Attaches an Elastic Load Balancing instance to a specified layer.</para> <para><b>NOTE:</b>You must create the Elastic Load Balancing
        /// instance separately, by using the Elastic Load Balancing console, API, or CLI. For more information, see Elastic Load Balancing Developer
        /// Guide.</para>
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
    
        #region DescribeCommands

        /// <summary>
        /// <para>Describes the results of specified commands.</para>
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
    
        #region UpdateStack

        /// <summary>
        /// <para>Updates a specified stack.</para>
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
        /// <para>Creates a new user profile.</para>
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
    
        #region GetHostnameSuggestion

        /// <summary>
        /// <para>Gets a generated host name for the specified layer, based on the current host name theme.</para>
        /// </summary>
        /// 
        /// <param name="getHostnameSuggestionRequest">Container for the necessary parameters to execute the GetHostnameSuggestion service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the GetHostnameSuggestion service method, as returned by AmazonOpsWorks.</returns>
        /// 
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
    
        #region DescribeRaidArrays

        /// <summary>
        /// <para>Describe an instance's RAID arrays.</para>
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
    
        #region DescribeLayers

        /// <summary>
        /// <para>Requests a description of one or more layers in a specified stack.</para>
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
        /// <para>Describes load-based auto scaling configurations for specified layers.</para>
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
    
        #region SetLoadBasedAutoScaling

        /// <summary>
        /// <para>Specify the load-based auto scaling configuration for a specified layer. For more information, see Managing Load with Time-based and
        /// Load-based Instances.</para> <para><b>NOTE:</b>To use load-based auto scaling, you must create a set of load-based auto scaling instances.
        /// Load-based auto scaling operates only on the instances from that set, so you must ensure that you have created enough instances to handle
        /// the maximum anticipated load.</para>
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
    
        #region DescribeElasticLoadBalancers

        /// <summary>
        /// <para>Describes a stack's Elastic Load Balancing instances.</para>
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
        /// <para>Describes a stack's Elastic Load Balancing instances.</para>
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
        /// <para>Deletes a specified layer. You must first stop and then delete all associated instances. For more information, see How to Delete a
        /// Layer.</para>
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
    
        #region SetTimeBasedAutoScaling

        /// <summary>
        /// <para>Specify the time-based auto scaling configuration for a specified instance. For more information, see Managing Load with Time-based
        /// and Load-based Instances.</para>
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
    
        #region DescribeVolumes

        /// <summary>
        /// <para>Describes an instance's Amazon EBS volumes.</para>
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
    
        #region CreateApp

        /// <summary>
        /// <para>Creates an app for a specified stack. For more information, see Creating Apps.</para>
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
    
        #region DescribeTimeBasedAutoScaling

        /// <summary>
        /// <para>Describes time-based auto scaling configurations for specified instances.</para>
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
    
        #region DeleteUserProfile

        /// <summary>
        /// <para>Deletes a user profile.</para>
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
    
        #region DescribeUserProfiles

        /// <summary>
        /// <para>Describe specified users.</para>
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
        
        

        #endregion
    
        #region UpdateInstance

        /// <summary>
        /// <para>Updates a specified instance.</para>
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
    
        #region DescribeServiceErrors

        /// <summary>
        /// <para>Describes AWS OpsWorks service errors.</para>
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
        /// <para>Describes AWS OpsWorks service errors.</para>
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
    
        #region DescribeDeployments

        /// <summary>
        /// <para>Requests a description of a specified set of deployments.</para>
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
    
        #region UpdateLayer

        /// <summary>
        /// <para>Updates a specified layer.</para>
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
    
        #region StartInstance

        /// <summary>
        /// <para>Starts a specified instance. For more information, see Starting, Stopping, and Rebooting Instances.</para>
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
    
        #region DescribeElasticIps

        /// <summary>
        /// <para>Describes an instance's Elastic IP addresses.</para>
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
        /// <para>Requests a description of one or more stacks.</para>
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
        /// <para>Requests a description of one or more stacks.</para>
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
        /// <para>Requests a description of a specified set of apps.</para>
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
    
        #region CreateLayer

        /// <summary>
        /// <para>Creates a layer. For more information, see How to Create a Layer.</para> <para><b>NOTE:</b>You should use CreateLayer for non-custom
        /// layer types such as PHP App Server only if the stack does not have an existing layer of that type. A stack can have at most one instance of
        /// each non-custom layer; if you attempt to create a second instance, CreateLayer fails. A stack can have an arbitrary number of custom layers,
        /// so you can call CreateLayer as many times as you like for that layer type.</para>
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
    
        #region DeleteStack

        /// <summary>
        /// <para>Deletes a specified stack. You must first delete all instances, layers, and apps. For more information, see Shut Down a Stack.</para>
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
        /// <para>Starts stack's instances. </para>
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
    
        #region StopStack

        /// <summary>
        /// <para>Stops a specified stack.</para>
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
        /// <para>For more information, see Deploying Apps and Run Stack Commands.</para>
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
    
