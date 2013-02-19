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

using Amazon.OpsWorks;
using Amazon.OpsWorks.Model;

namespace Amazon.OpsWorks
{
    /// <summary>
    /// Interface for accessing AmazonOpsWorks.
    ///  
    ///  AWS OpsWorks
    /// </summary>
    public interface AmazonOpsWorks : IDisposable
    {
        

        #region UpdateUserProfile

        /// <summary>
        /// <para>Updates a specified user's SSH name and public key.</para>
        /// </summary>
        /// 
        /// <param name="updateUserProfileRequest">Container for the necessary parameters to execute the UpdateUserProfile service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest updateUserProfileRequest);

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
        IAsyncResult BeginUpdateUserProfile(UpdateUserProfileRequest updateUserProfileRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateUserProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserProfile.</param>
        UpdateUserProfileResponse EndUpdateUserProfile(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateStack

        /// <summary>
        /// <para>Creates a new stack.</para>
        /// </summary>
        /// 
        /// <param name="createStackRequest">Container for the necessary parameters to execute the CreateStack service method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ValidationException"/>
        CreateStackResponse CreateStack(CreateStackRequest createStackRequest);

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
        IAsyncResult BeginCreateStack(CreateStackRequest createStackRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStack.</param>
        /// 
        /// <returns>Returns a CreateStackResult from AmazonOpsWorks.</returns>
        CreateStackResponse EndCreateStack(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RebootInstance

        /// <summary>
        /// <para>Reboots a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="rebootInstanceRequest">Container for the necessary parameters to execute the RebootInstance service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        RebootInstanceResponse RebootInstance(RebootInstanceRequest rebootInstanceRequest);

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
        IAsyncResult BeginRebootInstance(RebootInstanceRequest rebootInstanceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RebootInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.RebootInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootInstance.</param>
        RebootInstanceResponse EndRebootInstance(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region SetPermission

        /// <summary>
        /// <para>Specifies a stack's permissions.</para>
        /// </summary>
        /// 
        /// <param name="setPermissionRequest">Container for the necessary parameters to execute the SetPermission service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ValidationException"/>
        SetPermissionResponse SetPermission(SetPermissionRequest setPermissionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the SetPermission operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.SetPermission"/>
        /// </summary>
        /// 
        /// <param name="setPermissionRequest">Container for the necessary parameters to execute the SetPermission operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginSetPermission(SetPermissionRequest setPermissionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetPermission operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.SetPermission"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetPermission.</param>
        SetPermissionResponse EndSetPermission(IAsyncResult asyncResult);
        
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
        DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest describeInstancesRequest);

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
        IAsyncResult BeginDescribeInstances(DescribeInstancesRequest describeInstancesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeInstances operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstances.</param>
        /// 
        /// <returns>Returns a DescribeInstancesResult from AmazonOpsWorks.</returns>
        DescribeInstancesResponse EndDescribeInstances(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribePermissions

        /// <summary>
        /// <para>Describes the permissions for a specified stack. You must specify at least one of the two request values.</para>
        /// </summary>
        /// 
        /// <param name="describePermissionsRequest">Container for the necessary parameters to execute the DescribePermissions service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribePermissions service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        DescribePermissionsResponse DescribePermissions(DescribePermissionsRequest describePermissionsRequest);

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
        IAsyncResult BeginDescribePermissions(DescribePermissionsRequest describePermissionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribePermissions operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribePermissions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePermissions.</param>
        /// 
        /// <returns>Returns a DescribePermissionsResult from AmazonOpsWorks.</returns>
        DescribePermissionsResponse EndDescribePermissions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteInstance

        /// <summary>
        /// <para>Deletes a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="deleteInstanceRequest">Container for the necessary parameters to execute the DeleteInstance service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest deleteInstanceRequest);

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
        IAsyncResult BeginDeleteInstance(DeleteInstanceRequest deleteInstanceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstance.</param>
        DeleteInstanceResponse EndDeleteInstance(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CloneStack

        /// <summary>
        /// <para>Creates a clone of a specified stack.</para>
        /// </summary>
        /// 
        /// <param name="cloneStackRequest">Container for the necessary parameters to execute the CloneStack service method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CloneStack service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        CloneStackResponse CloneStack(CloneStackRequest cloneStackRequest);

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
        IAsyncResult BeginCloneStack(CloneStackRequest cloneStackRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CloneStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CloneStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCloneStack.</param>
        /// 
        /// <returns>Returns a CloneStackResult from AmazonOpsWorks.</returns>
        CloneStackResponse EndCloneStack(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateInstance

        /// <summary>
        /// <para>Creates an instance in a specified stack.</para>
        /// </summary>
        /// 
        /// <param name="createInstanceRequest">Container for the necessary parameters to execute the CreateInstance service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateInstance service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ValidationException"/>
        CreateInstanceResponse CreateInstance(CreateInstanceRequest createInstanceRequest);

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
        IAsyncResult BeginCreateInstance(CreateInstanceRequest createInstanceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstance.</param>
        /// 
        /// <returns>Returns a CreateInstanceResult from AmazonOpsWorks.</returns>
        CreateInstanceResponse EndCreateInstance(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region StopInstance

        /// <summary>
        /// <para>Stops a specified instance. When you stop a standard instance, the data disappears and must be reinstalled when you restart the
        /// instance. You can stop an Amazon EBS-backed instance without losing data.</para>
        /// </summary>
        /// 
        /// <param name="stopInstanceRequest">Container for the necessary parameters to execute the StopInstance service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        StopInstanceResponse StopInstance(StopInstanceRequest stopInstanceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the StopInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StopInstance"/>
        /// </summary>
        /// 
        /// <param name="stopInstanceRequest">Container for the necessary parameters to execute the StopInstance operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginStopInstance(StopInstanceRequest stopInstanceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the StopInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StopInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInstance.</param>
        StopInstanceResponse EndStopInstance(IAsyncResult asyncResult);
        
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
        UpdateAppResponse UpdateApp(UpdateAppRequest updateAppRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateApp"/>
        /// </summary>
        /// 
        /// <param name="updateAppRequest">Container for the necessary parameters to execute the UpdateApp operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginUpdateApp(UpdateAppRequest updateAppRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateApp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateApp"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApp.</param>
        UpdateAppResponse EndUpdateApp(IAsyncResult asyncResult);
        
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
        DeleteAppResponse DeleteApp(DeleteAppRequest deleteAppRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteApp"/>
        /// </summary>
        /// 
        /// <param name="deleteAppRequest">Container for the necessary parameters to execute the DeleteApp operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteApp(DeleteAppRequest deleteAppRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteApp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteApp"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        DeleteAppResponse EndDeleteApp(IAsyncResult asyncResult);
        
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
        DescribeCommandsResponse DescribeCommands(DescribeCommandsRequest describeCommandsRequest);

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
        IAsyncResult BeginDescribeCommands(DescribeCommandsRequest describeCommandsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCommands operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeCommands"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCommands.</param>
        /// 
        /// <returns>Returns a DescribeCommandsResult from AmazonOpsWorks.</returns>
        DescribeCommandsResponse EndDescribeCommands(IAsyncResult asyncResult);
        
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
        UpdateStackResponse UpdateStack(UpdateStackRequest updateStackRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateStack"/>
        /// </summary>
        /// 
        /// <param name="updateStackRequest">Container for the necessary parameters to execute the UpdateStack operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginUpdateStack(UpdateStackRequest updateStackRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStack.</param>
        UpdateStackResponse EndUpdateStack(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateUserProfile

        /// <summary>
        /// <para>Creates a new user.</para>
        /// </summary>
        /// 
        /// <param name="createUserProfileRequest">Container for the necessary parameters to execute the CreateUserProfile service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ValidationException"/>
        CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest createUserProfileRequest);

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
        IAsyncResult BeginCreateUserProfile(CreateUserProfileRequest createUserProfileRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateUserProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserProfile.</param>
        /// 
        /// <returns>Returns a CreateUserProfileResult from AmazonOpsWorks.</returns>
        CreateUserProfileResponse EndCreateUserProfile(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetHostnameSuggestion

        /// <summary>
        /// <para>Gets a generated hostname for the specified layer, based on the current hostname theme.</para>
        /// </summary>
        /// 
        /// <param name="getHostnameSuggestionRequest">Container for the necessary parameters to execute the GetHostnameSuggestion service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the GetHostnameSuggestion service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ValidationException"/>
        GetHostnameSuggestionResponse GetHostnameSuggestion(GetHostnameSuggestionRequest getHostnameSuggestionRequest);

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
        IAsyncResult BeginGetHostnameSuggestion(GetHostnameSuggestionRequest getHostnameSuggestionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetHostnameSuggestion operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.GetHostnameSuggestion"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHostnameSuggestion.</param>
        /// 
        /// <returns>Returns a GetHostnameSuggestionResult from AmazonOpsWorks.</returns>
        GetHostnameSuggestionResponse EndGetHostnameSuggestion(IAsyncResult asyncResult);
        
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
        DescribeRaidArraysResponse DescribeRaidArrays(DescribeRaidArraysRequest describeRaidArraysRequest);

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
        IAsyncResult BeginDescribeRaidArrays(DescribeRaidArraysRequest describeRaidArraysRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeRaidArrays operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeRaidArrays"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRaidArrays.</param>
        /// 
        /// <returns>Returns a DescribeRaidArraysResult from AmazonOpsWorks.</returns>
        DescribeRaidArraysResponse EndDescribeRaidArrays(IAsyncResult asyncResult);
        
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
        DescribeLayersResponse DescribeLayers(DescribeLayersRequest describeLayersRequest);

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
        IAsyncResult BeginDescribeLayers(DescribeLayersRequest describeLayersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLayers operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeLayers"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLayers.</param>
        /// 
        /// <returns>Returns a DescribeLayersResult from AmazonOpsWorks.</returns>
        DescribeLayersResponse EndDescribeLayers(IAsyncResult asyncResult);
        
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
        DescribeLoadBasedAutoScalingResponse DescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest describeLoadBasedAutoScalingRequest);

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
        IAsyncResult BeginDescribeLoadBasedAutoScaling(DescribeLoadBasedAutoScalingRequest describeLoadBasedAutoScalingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLoadBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeLoadBasedAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a DescribeLoadBasedAutoScalingResult from AmazonOpsWorks.</returns>
        DescribeLoadBasedAutoScalingResponse EndDescribeLoadBasedAutoScaling(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region SetLoadBasedAutoScaling

        /// <summary>
        /// <para>Specify the load-based auto scaling configuration for a specified layer.</para> <para><b>NOTE:</b>To use load-based auto scaling, you
        /// must create a set of load-based auto scaling instances. Load-based auto scaling operates only on the instances from that set, so you must
        /// ensure that you have created enough instances to handle the maximum anticipated load.</para>
        /// </summary>
        /// 
        /// <param name="setLoadBasedAutoScalingRequest">Container for the necessary parameters to execute the SetLoadBasedAutoScaling service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        SetLoadBasedAutoScalingResponse SetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest setLoadBasedAutoScalingRequest);

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
        IAsyncResult BeginSetLoadBasedAutoScaling(SetLoadBasedAutoScalingRequest setLoadBasedAutoScalingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetLoadBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.SetLoadBasedAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBasedAutoScaling.</param>
        SetLoadBasedAutoScalingResponse EndSetLoadBasedAutoScaling(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteLayer

        /// <summary>
        /// <para>Deletes a specified layer. You must first remove all associated instances.</para>
        /// </summary>
        /// 
        /// <param name="deleteLayerRequest">Container for the necessary parameters to execute the DeleteLayer service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        DeleteLayerResponse DeleteLayer(DeleteLayerRequest deleteLayerRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLayer operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteLayer"/>
        /// </summary>
        /// 
        /// <param name="deleteLayerRequest">Container for the necessary parameters to execute the DeleteLayer operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteLayer(DeleteLayerRequest deleteLayerRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLayer operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteLayer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLayer.</param>
        DeleteLayerResponse EndDeleteLayer(IAsyncResult asyncResult);
        
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
        DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest describeVolumesRequest);

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
        IAsyncResult BeginDescribeVolumes(DescribeVolumesRequest describeVolumesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVolumes operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeVolumes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumes.</param>
        /// 
        /// <returns>Returns a DescribeVolumesResult from AmazonOpsWorks.</returns>
        DescribeVolumesResponse EndDescribeVolumes(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region SetTimeBasedAutoScaling

        /// <summary>
        /// <para>Specify the time-based auto scaling configuration for a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="setTimeBasedAutoScalingRequest">Container for the necessary parameters to execute the SetTimeBasedAutoScaling service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        SetTimeBasedAutoScalingResponse SetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest setTimeBasedAutoScalingRequest);

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
        IAsyncResult BeginSetTimeBasedAutoScaling(SetTimeBasedAutoScalingRequest setTimeBasedAutoScalingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetTimeBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.SetTimeBasedAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTimeBasedAutoScaling.</param>
        SetTimeBasedAutoScalingResponse EndSetTimeBasedAutoScaling(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateApp

        /// <summary>
        /// <para>Creates an app for a specified stack.</para>
        /// </summary>
        /// 
        /// <param name="createAppRequest">Container for the necessary parameters to execute the CreateApp service method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        CreateAppResponse CreateApp(CreateAppRequest createAppRequest);

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
        IAsyncResult BeginCreateApp(CreateAppRequest createAppRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateApp operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateApp"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApp.</param>
        /// 
        /// <returns>Returns a CreateAppResult from AmazonOpsWorks.</returns>
        CreateAppResponse EndCreateApp(IAsyncResult asyncResult);
        
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
        DescribeTimeBasedAutoScalingResponse DescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest describeTimeBasedAutoScalingRequest);

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
        IAsyncResult BeginDescribeTimeBasedAutoScaling(DescribeTimeBasedAutoScalingRequest describeTimeBasedAutoScalingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeTimeBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeTimeBasedAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTimeBasedAutoScaling.</param>
        /// 
        /// <returns>Returns a DescribeTimeBasedAutoScalingResult from AmazonOpsWorks.</returns>
        DescribeTimeBasedAutoScalingResponse EndDescribeTimeBasedAutoScaling(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteUserProfile

        /// <summary>
        /// <para>Deletes a user.</para>
        /// </summary>
        /// 
        /// <param name="deleteUserProfileRequest">Container for the necessary parameters to execute the DeleteUserProfile service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest deleteUserProfileRequest);

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
        IAsyncResult BeginDeleteUserProfile(DeleteUserProfileRequest deleteUserProfileRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteUserProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserProfile.</param>
        DeleteUserProfileResponse EndDeleteUserProfile(IAsyncResult asyncResult);
        
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
        DescribeUserProfilesResponse DescribeUserProfiles(DescribeUserProfilesRequest describeUserProfilesRequest);

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
        IAsyncResult BeginDescribeUserProfiles(DescribeUserProfilesRequest describeUserProfilesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeUserProfiles operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeUserProfiles"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserProfiles.</param>
        /// 
        /// <returns>Returns a DescribeUserProfilesResult from AmazonOpsWorks.</returns>
        DescribeUserProfilesResponse EndDescribeUserProfiles(IAsyncResult asyncResult);
        
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
        UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest updateInstanceRequest);

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
        IAsyncResult BeginUpdateInstance(UpdateInstanceRequest updateInstanceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstance.</param>
        UpdateInstanceResponse EndUpdateInstance(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeServiceErrors

        /// <summary>
        /// <para>Describes OpsWorks service errors.</para>
        /// </summary>
        /// 
        /// <param name="describeServiceErrorsRequest">Container for the necessary parameters to execute the DescribeServiceErrors service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the DescribeServiceErrors service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        DescribeServiceErrorsResponse DescribeServiceErrors(DescribeServiceErrorsRequest describeServiceErrorsRequest);

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
        IAsyncResult BeginDescribeServiceErrors(DescribeServiceErrorsRequest describeServiceErrorsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeServiceErrors operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeServiceErrors"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceErrors.</param>
        /// 
        /// <returns>Returns a DescribeServiceErrorsResult from AmazonOpsWorks.</returns>
        DescribeServiceErrorsResponse EndDescribeServiceErrors(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes OpsWorks service errors.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeServiceErrors service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        DescribeServiceErrorsResponse DescribeServiceErrors();
        
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
        DescribeDeploymentsResponse DescribeDeployments(DescribeDeploymentsRequest describeDeploymentsRequest);

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
        IAsyncResult BeginDescribeDeployments(DescribeDeploymentsRequest describeDeploymentsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDeployments operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeDeployments"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeployments.</param>
        /// 
        /// <returns>Returns a DescribeDeploymentsResult from AmazonOpsWorks.</returns>
        DescribeDeploymentsResponse EndDescribeDeployments(IAsyncResult asyncResult);
        
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
        UpdateLayerResponse UpdateLayer(UpdateLayerRequest updateLayerRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLayer operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateLayer"/>
        /// </summary>
        /// 
        /// <param name="updateLayerRequest">Container for the necessary parameters to execute the UpdateLayer operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginUpdateLayer(UpdateLayerRequest updateLayerRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateLayer operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateLayer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLayer.</param>
        UpdateLayerResponse EndUpdateLayer(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region StartInstance

        /// <summary>
        /// <para>Starts a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="startInstanceRequest">Container for the necessary parameters to execute the StartInstance service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        StartInstanceResponse StartInstance(StartInstanceRequest startInstanceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StartInstance"/>
        /// </summary>
        /// 
        /// <param name="startInstanceRequest">Container for the necessary parameters to execute the StartInstance operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginStartInstance(StartInstanceRequest startInstanceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the StartInstance operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StartInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstance.</param>
        StartInstanceResponse EndStartInstance(IAsyncResult asyncResult);
        
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
        DescribeElasticIpsResponse DescribeElasticIps(DescribeElasticIpsRequest describeElasticIpsRequest);

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
        IAsyncResult BeginDescribeElasticIps(DescribeElasticIpsRequest describeElasticIpsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeElasticIps operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeElasticIps"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticIps.</param>
        /// 
        /// <returns>Returns a DescribeElasticIpsResult from AmazonOpsWorks.</returns>
        DescribeElasticIpsResponse EndDescribeElasticIps(IAsyncResult asyncResult);
        
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
        DescribeStacksResponse DescribeStacks(DescribeStacksRequest describeStacksRequest);

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
        IAsyncResult BeginDescribeStacks(DescribeStacksRequest describeStacksRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStacks operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeStacks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStacks.</param>
        /// 
        /// <returns>Returns a DescribeStacksResult from AmazonOpsWorks.</returns>
        DescribeStacksResponse EndDescribeStacks(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Requests a description of one or more stacks.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        DescribeStacksResponse DescribeStacks();
        
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
        DescribeAppsResponse DescribeApps(DescribeAppsRequest describeAppsRequest);

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
        IAsyncResult BeginDescribeApps(DescribeAppsRequest describeAppsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeApps operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeApps"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApps.</param>
        /// 
        /// <returns>Returns a DescribeAppsResult from AmazonOpsWorks.</returns>
        DescribeAppsResponse EndDescribeApps(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateLayer

        /// <summary>
        /// <para>Creates a layer.</para>
        /// </summary>
        /// 
        /// <param name="createLayerRequest">Container for the necessary parameters to execute the CreateLayer service method on AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateLayer service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        CreateLayerResponse CreateLayer(CreateLayerRequest createLayerRequest);

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
        IAsyncResult BeginCreateLayer(CreateLayerRequest createLayerRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateLayer operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateLayer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLayer.</param>
        /// 
        /// <returns>Returns a CreateLayerResult from AmazonOpsWorks.</returns>
        CreateLayerResponse EndCreateLayer(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteStack

        /// <summary>
        /// <para>Deletes a specified stack. You must first delete all instances and layers.</para>
        /// </summary>
        /// 
        /// <param name="deleteStackRequest">Container for the necessary parameters to execute the DeleteStack service method on AmazonOpsWorks.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        DeleteStackResponse DeleteStack(DeleteStackRequest deleteStackRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteStack"/>
        /// </summary>
        /// 
        /// <param name="deleteStackRequest">Container for the necessary parameters to execute the DeleteStack operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteStack(DeleteStackRequest deleteStackRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStack.</param>
        DeleteStackResponse EndDeleteStack(IAsyncResult asyncResult);
        
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
        StartStackResponse StartStack(StartStackRequest startStackRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the StartStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StartStack"/>
        /// </summary>
        /// 
        /// <param name="startStackRequest">Container for the necessary parameters to execute the StartStack operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginStartStack(StartStackRequest startStackRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the StartStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StartStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartStack.</param>
        StartStackResponse EndStartStack(IAsyncResult asyncResult);
        
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
        StopStackResponse StopStack(StopStackRequest stopStackRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the StopStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StopStack"/>
        /// </summary>
        /// 
        /// <param name="stopStackRequest">Container for the necessary parameters to execute the StopStack operation on AmazonOpsWorks.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginStopStack(StopStackRequest stopStackRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the StopStack operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.StopStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopStack.</param>
        StopStackResponse EndStopStack(IAsyncResult asyncResult);
        
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
        /// </summary>
        /// 
        /// <param name="createDeploymentRequest">Container for the necessary parameters to execute the CreateDeployment service method on
        ///          AmazonOpsWorks.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by AmazonOpsWorks.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ValidationException"/>
        CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest createDeploymentRequest);

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
        IAsyncResult BeginCreateDeployment(CreateDeploymentRequest createDeploymentRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDeployment operation.
        /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateDeployment"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a CreateDeploymentResult from AmazonOpsWorks.</returns>
        CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    
