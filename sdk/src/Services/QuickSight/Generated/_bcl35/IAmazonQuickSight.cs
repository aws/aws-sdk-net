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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QuickSight.Model;

namespace Amazon.QuickSight
{
    /// <summary>
    /// Interface for accessing QuickSight
    ///
    /// Amazon QuickSight API Reference 
    /// <para>
    /// Amazon QuickSight is a fully managed, serverless, cloud business intelligence service
    /// that makes it easy to extend data and insights to every user in your organization.
    /// This API interface reference contains documentation for a programming interface that
    /// you can use to manage Amazon QuickSight. 
    /// </para>
    /// </summary>
    public partial interface IAmazonQuickSight : IAmazonService, IDisposable
    {

        
        #region  CancelIngestion


        /// <summary>
        /// Cancels an on-going ingestion of data into SPICE.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelIngestion service method.</param>
        /// 
        /// <returns>The response from the CancelIngestion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CancelIngestion">REST API Reference for CancelIngestion Operation</seealso>
        CancelIngestionResponse CancelIngestion(CancelIngestionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelIngestion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelIngestion operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelIngestion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CancelIngestion">REST API Reference for CancelIngestion Operation</seealso>
        IAsyncResult BeginCancelIngestion(CancelIngestionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelIngestion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelIngestion.</param>
        /// 
        /// <returns>Returns a  CancelIngestionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CancelIngestion">REST API Reference for CancelIngestion Operation</seealso>
        CancelIngestionResponse EndCancelIngestion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDashboard


        /// <summary>
        /// Creates a dashboard from a template. To first create a template, see the CreateTemplate
        /// API.
        /// 
        ///  
        /// <para>
        /// A dashboard is an entity in QuickSight which identifies Quicksight reports, created
        /// from analyses. QuickSight dashboards are sharable. With the right permissions, you
        /// can create scheduled email reports from them. The <code>CreateDashboard</code>, <code>DescribeDashboard</code>
        /// and <code>ListDashboardsByUser</code> APIs act on the dashboard entity. If you have
        /// the correct permissions, you can create a dashboard from a template that exists in
        /// a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-dashboard --cli-input-json file://create-dashboard.json</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// 
        /// <returns>The response from the CreateDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        CreateDashboardResponse CreateDashboard(CreateDashboardRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        IAsyncResult BeginCreateDashboard(CreateDashboardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDashboard.</param>
        /// 
        /// <returns>Returns a  CreateDashboardResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        CreateDashboardResponse EndCreateDashboard(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataSet


        /// <summary>
        /// Creates a dataset.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-data-set \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-set-id=unique-data-set-id \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--name='My dataset' \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--import-mode=SPICE \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--physical-table-map='{</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "physical-table-id": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "RelationalTable": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "DataSourceArn": "arn:aws:quicksight:us-west-2:111111111111:datasource/data-source-id",</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Name": "table1",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "InputColumns": [</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Name": "column1",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Type": "STRING"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> }</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> ]</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> }</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> }'</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSet service method.</param>
        /// 
        /// <returns>The response from the CreateDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        CreateDataSetResponse CreateDataSet(CreateDataSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSet operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        IAsyncResult BeginCreateDataSet(CreateDataSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSet.</param>
        /// 
        /// <returns>Returns a  CreateDataSetResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        CreateDataSetResponse EndCreateDataSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataSource


        /// <summary>
        /// Creates a data source.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:datasource/data-source-id</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-data-source \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-source-id=unique-data-source-id \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--name='My Data Source' \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--type=POSTGRESQL \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-source-parameters='{ "PostgreSqlParameters": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Host": "my-db-host.example.com",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Port": 1234,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Database": "my-db" } }' \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--credentials='{ "CredentialPair": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Username": "username",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Password": "password" } }'</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        IAsyncResult BeginCreateDataSource(CreateDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSource.</param>
        /// 
        /// <returns>Returns a  CreateDataSourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        CreateDataSourceResponse EndCreateDataSource(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGroup


        /// <summary>
        /// Creates an Amazon QuickSight group.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;relevant-aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a group object.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-group --aws-account-id=111122223333 --namespace=default
        /// --group-name="Sales-Management" --description="Sales Management - Forecasting" </code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGroupMembership


        /// <summary>
        /// Adds an Amazon QuickSight user to an Amazon QuickSight group. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The condition resource is the user name.
        /// </para>
        ///  
        /// <para>
        /// The condition key is <code>quicksight:UserName</code>.
        /// </para>
        ///  
        /// <para>
        /// The response is the group member object.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-group-membership --aws-account-id=111122223333 --namespace=default
        /// --group-name=Sales --member-name=Pat </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership service method.</param>
        /// 
        /// <returns>The response from the CreateGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        CreateGroupMembershipResponse CreateGroupMembership(CreateGroupMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroupMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        IAsyncResult BeginCreateGroupMembership(CreateGroupMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroupMembership.</param>
        /// 
        /// <returns>Returns a  CreateGroupMembershipResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        CreateGroupMembershipResponse EndCreateGroupMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIAMPolicyAssignment


        /// <summary>
        /// Creates an assignment with one specified IAM policy ARN and will assigned to specified
        /// groups or users of QuickSight. Users and groups need to be in the same namespace.
        /// 
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-iam-policy-assignment --aws-account-id=111122223333 --assignment-name=helpAssignment
        /// --policy-arn=arn:aws:iam::aws:policy/AdministratorAccess --identities="user=user5,engineer123,group=QS-Admin"
        /// --namespace=default --region=us-west-2</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIAMPolicyAssignment service method.</param>
        /// 
        /// <returns>The response from the CreateIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in an "actionable" state that must complete before a new update
        /// can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIAMPolicyAssignment">REST API Reference for CreateIAMPolicyAssignment Operation</seealso>
        CreateIAMPolicyAssignmentResponse CreateIAMPolicyAssignment(CreateIAMPolicyAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIAMPolicyAssignment operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIAMPolicyAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIAMPolicyAssignment">REST API Reference for CreateIAMPolicyAssignment Operation</seealso>
        IAsyncResult BeginCreateIAMPolicyAssignment(CreateIAMPolicyAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIAMPolicyAssignment.</param>
        /// 
        /// <returns>Returns a  CreateIAMPolicyAssignmentResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIAMPolicyAssignment">REST API Reference for CreateIAMPolicyAssignment Operation</seealso>
        CreateIAMPolicyAssignmentResponse EndCreateIAMPolicyAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIngestion


        /// <summary>
        /// Creates and starts a new SPICE ingestion on a dataset
        /// 
        ///  
        /// <para>
        /// Any ingestions operating on tagged datasets inherit the same tags automatically for
        /// use in access-control. For an example, see <a href="https://aws.example.com/premiumsupport/knowledge-center/iam-ec2-resource-tags/">How
        /// do I create an IAM policy to control access to Amazon EC2 resources using tags?</a>.
        /// Tags will be visible on the tagged dataset, but not on the ingestion resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestion service method.</param>
        /// 
        /// <returns>The response from the CreateIngestion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIngestion">REST API Reference for CreateIngestion Operation</seealso>
        CreateIngestionResponse CreateIngestion(CreateIngestionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIngestion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestion operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIngestion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIngestion">REST API Reference for CreateIngestion Operation</seealso>
        IAsyncResult BeginCreateIngestion(CreateIngestionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIngestion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIngestion.</param>
        /// 
        /// <returns>Returns a  CreateIngestionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIngestion">REST API Reference for CreateIngestion Operation</seealso>
        CreateIngestionResponse EndCreateIngestion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTemplate


        /// <summary>
        /// Creates a template from an existing QuickSight analysis or template. The resulting
        /// template can be used to create a dashboard.
        /// 
        ///  
        /// <para>
        /// A template is an entity in QuickSight which encapsulates the metadata required to
        /// create an analysis that can be used to create dashboard. It adds a layer of abstraction
        /// by use placeholders to replace the dataset associated with the analysis. You can use
        /// templates to create dashboards by replacing dataset placeholders with datasets which
        /// follow the same schema that was used to create the source analysis and template.
        /// </para>
        ///  
        /// <para>
        /// To create a template from an existing analysis, use the analysis's ARN, <code>aws-account-id</code>,
        /// <code>template-id</code>, <code>source-entity</code>, and <code>data-set-references</code>.
        /// </para>
        ///  
        /// <para>
        /// CLI syntax to create a template: 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-template —cli-input-json file://create-template.json</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax to create a template from another template in the same AWS account:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-template --aws-account-id 111122223333 --template-id
        /// reports_test_template --data-set-references DataSetPlaceholder=reports,DataSetArn=arn:aws:quicksight:us-west-2:111122223333:dataset/0dfc789c-81f6-4f4f-b9ac-7db2453eefc8
        /// DataSetPlaceholder=Elblogs,DataSetArn=arn:aws:quicksight:us-west-2:111122223333:dataset/f60da323-af68-45db-9016-08e0d1d7ded5
        /// --source-entity SourceAnalysis='{Arn=arn:aws:quicksight:us-west-2:111122223333:analysis/7fb74527-c36d-4be8-8139-ac1be4c97365}'</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// To create template from another account’s template, you need to grant cross account
        /// resource permission for DescribeTemplate the account that contains the template.
        /// </para>
        ///  
        /// <para>
        /// You can use a file to pass JSON to the function if you prefer. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        CreateTemplateResponse CreateTemplate(CreateTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        IAsyncResult BeginCreateTemplate(CreateTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTemplate.</param>
        /// 
        /// <returns>Returns a  CreateTemplateResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        CreateTemplateResponse EndCreateTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTemplateAlias


        /// <summary>
        /// Creates a template alias for a template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-template-alias --aws-account-id 111122223333 --template-id
        /// 'reports_test_template' --alias-name PROD —version-number 1</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplateAlias">REST API Reference for CreateTemplateAlias Operation</seealso>
        CreateTemplateAliasResponse CreateTemplateAlias(CreateTemplateAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTemplateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplateAlias">REST API Reference for CreateTemplateAlias Operation</seealso>
        IAsyncResult BeginCreateTemplateAlias(CreateTemplateAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTemplateAlias.</param>
        /// 
        /// <returns>Returns a  CreateTemplateAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplateAlias">REST API Reference for CreateTemplateAlias Operation</seealso>
        CreateTemplateAliasResponse EndCreateTemplateAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDashboard


        /// <summary>
        /// Deletes a dashboard.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-dashboard --aws-account-id 111122223333 —dashboard-id
        /// 123123123</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-dashboard --aws-account-id 111122223333 —dashboard-id
        /// 123123123 —version-number 3</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// 
        /// <returns>The response from the DeleteDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        DeleteDashboardResponse DeleteDashboard(DeleteDashboardRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        IAsyncResult BeginDeleteDashboard(DeleteDashboardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDashboard.</param>
        /// 
        /// <returns>Returns a  DeleteDashboardResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        DeleteDashboardResponse EndDeleteDashboard(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataSet


        /// <summary>
        /// Deletes a dataset.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-data-set \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111111111111 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-set-id=unique-data-set-id</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSet service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        DeleteDataSetResponse DeleteDataSet(DeleteDataSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSet operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        IAsyncResult BeginDeleteDataSet(DeleteDataSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSet.</param>
        /// 
        /// <returns>Returns a  DeleteDataSetResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        DeleteDataSetResponse EndDeleteDataSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataSource


        /// <summary>
        /// Deletes the data source permanently. This action breaks all the datasets that reference
        /// the deleted data source.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-data-source \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-source-id=unique-data-source-id </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        IAsyncResult BeginDeleteDataSource(DeleteDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSource.</param>
        /// 
        /// <returns>Returns a  DeleteDataSourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        DeleteDataSourceResponse EndDeleteDataSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Removes a user group from Amazon QuickSight. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-group -\-aws-account-id=111122223333 -\-namespace=default
        /// -\-group-name=Sales-Management </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroupMembership


        /// <summary>
        /// Removes a user from a group so that the user is no longer a member of the group.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The condition resource is the user name.
        /// </para>
        ///  
        /// <para>
        /// The condition key is <code>quicksight:UserName</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-group-membership --aws-account-id=111122223333 --namespace=default
        /// --group-name=Sales-Management --member-name=Charlie </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        DeleteGroupMembershipResponse DeleteGroupMembership(DeleteGroupMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroupMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        IAsyncResult BeginDeleteGroupMembership(DeleteGroupMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroupMembership.</param>
        /// 
        /// <returns>Returns a  DeleteGroupMembershipResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        DeleteGroupMembershipResponse EndDeleteGroupMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIAMPolicyAssignment


        /// <summary>
        /// Deletes an existing assignment.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-iam-policy-assignment --aws-account-id=111122223333 --assignment-name=testtest
        /// --region=us-east-1 --namespace=default</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIAMPolicyAssignment service method.</param>
        /// 
        /// <returns>The response from the DeleteIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in an "actionable" state that must complete before a new update
        /// can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIAMPolicyAssignment">REST API Reference for DeleteIAMPolicyAssignment Operation</seealso>
        DeleteIAMPolicyAssignmentResponse DeleteIAMPolicyAssignment(DeleteIAMPolicyAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIAMPolicyAssignment operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIAMPolicyAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIAMPolicyAssignment">REST API Reference for DeleteIAMPolicyAssignment Operation</seealso>
        IAsyncResult BeginDeleteIAMPolicyAssignment(DeleteIAMPolicyAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIAMPolicyAssignment.</param>
        /// 
        /// <returns>Returns a  DeleteIAMPolicyAssignmentResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIAMPolicyAssignment">REST API Reference for DeleteIAMPolicyAssignment Operation</seealso>
        DeleteIAMPolicyAssignmentResponse EndDeleteIAMPolicyAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTemplate


        /// <summary>
        /// Deletes a template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aws quicksight delete-template --aws-account-id 111122223333 —-template-id
        /// reports_test_template --version-number 2 </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aws quicksight delete-template —aws-account-id 111122223333 —template-id reports_test_template
        /// —alias-name STAGING </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aws quicksight delete-template —aws-account-id 111122223333 —template-id reports_test_template
        /// —alias-name ‘\$LATEST’ </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aws quicksight delete-template --aws-account-id 111122223333 —-template-id
        /// reports_test_template</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If version number which is an optional field is not passed the template (including
        /// all the versions) is deleted by the API, if version number is provided, the specific
        /// template version is deleted by the API.
        /// </para>
        ///  
        /// <para>
        /// Users can explicitly describe the latest version of the template by passing <code>$LATEST</code>
        /// to the <code>alias-name</code> parameter. <code>$LATEST</code> is an internally supported
        /// alias, which points to the latest version of the template. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        IAsyncResult BeginDeleteTemplate(DeleteTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteTemplateResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        DeleteTemplateResponse EndDeleteTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTemplateAlias


        /// <summary>
        /// Update template alias of given template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-template-alias --aws-account-id 111122223333 --template-id
        /// 'reports_test_template' --alias-name 'STAGING'</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplateAlias">REST API Reference for DeleteTemplateAlias Operation</seealso>
        DeleteTemplateAliasResponse DeleteTemplateAlias(DeleteTemplateAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTemplateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplateAlias">REST API Reference for DeleteTemplateAlias Operation</seealso>
        IAsyncResult BeginDeleteTemplateAlias(DeleteTemplateAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTemplateAlias.</param>
        /// 
        /// <returns>Returns a  DeleteTemplateAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplateAlias">REST API Reference for DeleteTemplateAlias Operation</seealso>
        DeleteTemplateAliasResponse EndDeleteTemplateAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes the Amazon QuickSight user that is associated with the identity of the AWS
        /// Identity and Access Management (IAM) user or role that's making the call. The IAM
        /// user isn't deleted as a result of this call. 
        /// 
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-user --aws-account-id=111122223333 --namespace=default
        /// --user-name=Pat </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUserByPrincipalId


        /// <summary>
        /// Deletes a user identified by its principal ID. 
        /// 
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-user-by-principal-id --aws-account-id=111122223333 --namespace=default
        /// --principal-id=ABCDEFJA26JLI7EUUOEHS </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserByPrincipalId service method.</param>
        /// 
        /// <returns>The response from the DeleteUserByPrincipalId service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserByPrincipalId">REST API Reference for DeleteUserByPrincipalId Operation</seealso>
        DeleteUserByPrincipalIdResponse DeleteUserByPrincipalId(DeleteUserByPrincipalIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserByPrincipalId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserByPrincipalId operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserByPrincipalId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserByPrincipalId">REST API Reference for DeleteUserByPrincipalId Operation</seealso>
        IAsyncResult BeginDeleteUserByPrincipalId(DeleteUserByPrincipalIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserByPrincipalId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserByPrincipalId.</param>
        /// 
        /// <returns>Returns a  DeleteUserByPrincipalIdResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserByPrincipalId">REST API Reference for DeleteUserByPrincipalId Operation</seealso>
        DeleteUserByPrincipalIdResponse EndDeleteUserByPrincipalId(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDashboard


        /// <summary>
        /// Provides a summary for a dashboard.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aws quicksight describe-dashboard --aws-account-id 111122223333 —dashboard-id
        /// reports_test_report -version-number 2</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code> aws quicksight describe-dashboard --aws-account-id 111122223333 —dashboard-id
        /// reports_test_report -alias-name ‘$PUBLISHED’ </code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboard service method.</param>
        /// 
        /// <returns>The response from the DescribeDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboard">REST API Reference for DescribeDashboard Operation</seealso>
        DescribeDashboardResponse DescribeDashboard(DescribeDashboardRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboard operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboard">REST API Reference for DescribeDashboard Operation</seealso>
        IAsyncResult BeginDescribeDashboard(DescribeDashboardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDashboard.</param>
        /// 
        /// <returns>Returns a  DescribeDashboardResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboard">REST API Reference for DescribeDashboard Operation</seealso>
        DescribeDashboardResponse EndDescribeDashboard(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDashboardPermissions


        /// <summary>
        /// Describes read and write permissions on a dashboard.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-dashboard-permissions --aws-account-id 735340738645
        /// —dashboard-id reports_test_bob_report</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardPermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeDashboardPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardPermissions">REST API Reference for DescribeDashboardPermissions Operation</seealso>
        DescribeDashboardPermissionsResponse DescribeDashboardPermissions(DescribeDashboardPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDashboardPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDashboardPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardPermissions">REST API Reference for DescribeDashboardPermissions Operation</seealso>
        IAsyncResult BeginDescribeDashboardPermissions(DescribeDashboardPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDashboardPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDashboardPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeDashboardPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardPermissions">REST API Reference for DescribeDashboardPermissions Operation</seealso>
        DescribeDashboardPermissionsResponse EndDescribeDashboardPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataSet


        /// <summary>
        /// Describes a dataset. 
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-data-set \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111111111111 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-set-id=unique-data-set-id</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSet service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSet">REST API Reference for DescribeDataSet Operation</seealso>
        DescribeDataSetResponse DescribeDataSet(DescribeDataSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSet operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSet">REST API Reference for DescribeDataSet Operation</seealso>
        IAsyncResult BeginDescribeDataSet(DescribeDataSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSet.</param>
        /// 
        /// <returns>Returns a  DescribeDataSetResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSet">REST API Reference for DescribeDataSet Operation</seealso>
        DescribeDataSetResponse EndDescribeDataSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataSetPermissions


        /// <summary>
        /// Describes the permissions on a dataset.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:dataset/data-set-id</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax: 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-data-set-permissions \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-set-id=unique-data-set-id \</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSetPermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSetPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetPermissions">REST API Reference for DescribeDataSetPermissions Operation</seealso>
        DescribeDataSetPermissionsResponse DescribeDataSetPermissions(DescribeDataSetPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSetPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSetPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSetPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetPermissions">REST API Reference for DescribeDataSetPermissions Operation</seealso>
        IAsyncResult BeginDescribeDataSetPermissions(DescribeDataSetPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSetPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSetPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeDataSetPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetPermissions">REST API Reference for DescribeDataSetPermissions Operation</seealso>
        DescribeDataSetPermissionsResponse EndDescribeDataSetPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataSource


        /// <summary>
        /// Describes a data source.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:datasource/data-source-id</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSource service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        DescribeDataSourceResponse DescribeDataSource(DescribeDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        IAsyncResult BeginDescribeDataSource(DescribeDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSource.</param>
        /// 
        /// <returns>Returns a  DescribeDataSourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        DescribeDataSourceResponse EndDescribeDataSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataSourcePermissions


        /// <summary>
        /// Describes the resource permissions for a data source.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>aws:quicksight:region:aws-account-id:datasource/data-source-id</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSourcePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSourcePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSourcePermissions">REST API Reference for DescribeDataSourcePermissions Operation</seealso>
        DescribeDataSourcePermissionsResponse DescribeDataSourcePermissions(DescribeDataSourcePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSourcePermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSourcePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSourcePermissions">REST API Reference for DescribeDataSourcePermissions Operation</seealso>
        IAsyncResult BeginDescribeDataSourcePermissions(DescribeDataSourcePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSourcePermissions.</param>
        /// 
        /// <returns>Returns a  DescribeDataSourcePermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSourcePermissions">REST API Reference for DescribeDataSourcePermissions Operation</seealso>
        DescribeDataSourcePermissionsResponse EndDescribeDataSourcePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGroup


        /// <summary>
        /// Returns an Amazon QuickSight group's description and Amazon Resource Name (ARN). 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;relevant-aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is the group object. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-group -\-aws-account-id=11112222333 -\-namespace=default
        /// -\-group-name=Sales </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        DescribeGroupResponse DescribeGroup(DescribeGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        IAsyncResult BeginDescribeGroup(DescribeGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGroup.</param>
        /// 
        /// <returns>Returns a  DescribeGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        DescribeGroupResponse EndDescribeGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeIAMPolicyAssignment


        /// <summary>
        /// Describes an existing IAMPolicy Assignment by specified assignment name.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-iam-policy-assignment --aws-account-id=111122223333
        /// --assignment-name=testtest --namespace=default --region=us-east-1 </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIAMPolicyAssignment service method.</param>
        /// 
        /// <returns>The response from the DescribeIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIAMPolicyAssignment">REST API Reference for DescribeIAMPolicyAssignment Operation</seealso>
        DescribeIAMPolicyAssignmentResponse DescribeIAMPolicyAssignment(DescribeIAMPolicyAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIAMPolicyAssignment operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIAMPolicyAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIAMPolicyAssignment">REST API Reference for DescribeIAMPolicyAssignment Operation</seealso>
        IAsyncResult BeginDescribeIAMPolicyAssignment(DescribeIAMPolicyAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIAMPolicyAssignment.</param>
        /// 
        /// <returns>Returns a  DescribeIAMPolicyAssignmentResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIAMPolicyAssignment">REST API Reference for DescribeIAMPolicyAssignment Operation</seealso>
        DescribeIAMPolicyAssignmentResponse EndDescribeIAMPolicyAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeIngestion


        /// <summary>
        /// Describes a SPICE ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIngestion service method.</param>
        /// 
        /// <returns>The response from the DescribeIngestion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIngestion">REST API Reference for DescribeIngestion Operation</seealso>
        DescribeIngestionResponse DescribeIngestion(DescribeIngestionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIngestion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIngestion operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIngestion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIngestion">REST API Reference for DescribeIngestion Operation</seealso>
        IAsyncResult BeginDescribeIngestion(DescribeIngestionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIngestion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIngestion.</param>
        /// 
        /// <returns>Returns a  DescribeIngestionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIngestion">REST API Reference for DescribeIngestion Operation</seealso>
        DescribeIngestionResponse EndDescribeIngestion(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTemplate


        /// <summary>
        /// Describes a template's metadata.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-template --aws-account-id 111122223333 --template-id
        /// reports_test_template </code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-template --aws-account-id 111122223333 --template-id
        /// reports_test_template --version-number-2</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-template --aws-account-id 111122223333 --template-id
        /// reports_test_template --alias-name '\$LATEST' </code> 
        /// </para>
        ///  
        /// <para>
        /// Users can explicitly describe the latest version of the dashboard by passing <code>$LATEST</code>
        /// to the <code>alias-name</code> parameter. <code>$LATEST</code> is an internally supported
        /// alias, which points to the latest version of the dashboard. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplate service method.</param>
        /// 
        /// <returns>The response from the DescribeTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplate">REST API Reference for DescribeTemplate Operation</seealso>
        DescribeTemplateResponse DescribeTemplate(DescribeTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplate operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplate">REST API Reference for DescribeTemplate Operation</seealso>
        IAsyncResult BeginDescribeTemplate(DescribeTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTemplate.</param>
        /// 
        /// <returns>Returns a  DescribeTemplateResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplate">REST API Reference for DescribeTemplate Operation</seealso>
        DescribeTemplateResponse EndDescribeTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTemplateAlias


        /// <summary>
        /// Describes the template aliases of a template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-template-alias --aws-account-id 111122223333 --template-id
        /// 'reports_test_template' --alias-name 'STAGING'</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplateAlias service method.</param>
        /// 
        /// <returns>The response from the DescribeTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateAlias">REST API Reference for DescribeTemplateAlias Operation</seealso>
        DescribeTemplateAliasResponse DescribeTemplateAlias(DescribeTemplateAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplateAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTemplateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateAlias">REST API Reference for DescribeTemplateAlias Operation</seealso>
        IAsyncResult BeginDescribeTemplateAlias(DescribeTemplateAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTemplateAlias.</param>
        /// 
        /// <returns>Returns a  DescribeTemplateAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateAlias">REST API Reference for DescribeTemplateAlias Operation</seealso>
        DescribeTemplateAliasResponse EndDescribeTemplateAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTemplatePermissions


        /// <summary>
        /// Describes read and write permissions on a template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-template-permissions —aws-account-id 735340738645 —template-id
        /// reports_test_template</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplatePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeTemplatePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplatePermissions">REST API Reference for DescribeTemplatePermissions Operation</seealso>
        DescribeTemplatePermissionsResponse DescribeTemplatePermissions(DescribeTemplatePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTemplatePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplatePermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTemplatePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplatePermissions">REST API Reference for DescribeTemplatePermissions Operation</seealso>
        IAsyncResult BeginDescribeTemplatePermissions(DescribeTemplatePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTemplatePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTemplatePermissions.</param>
        /// 
        /// <returns>Returns a  DescribeTemplatePermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplatePermissions">REST API Reference for DescribeTemplatePermissions Operation</seealso>
        DescribeTemplatePermissionsResponse EndDescribeTemplatePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeUser


        /// <summary>
        /// Returns information about a user, given the user name. 
        /// 
        ///  
        /// <para>
        /// The response is a user object that contains the user's Amazon Resource Name (ARN),
        /// AWS Identity and Access Management (IAM) role, and email address. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-user --aws-account-id=111122223333 --namespace=default
        /// --user-name=Pat </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        DescribeUserResponse DescribeUser(DescribeUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        IAsyncResult BeginDescribeUser(DescribeUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUser.</param>
        /// 
        /// <returns>Returns a  DescribeUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        DescribeUserResponse EndDescribeUser(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDashboardEmbedUrl


        /// <summary>
        /// Generates a server-side embeddable URL and authorization code. Before this can work
        /// properly, first you need to configure the dashboards and user permissions. For more
        /// information, see <a href="https://docs.aws.example.com/en_us/quicksight/latest/user/embedding.html">
        /// Embedding Amazon QuickSight Dashboards</a>.
        /// 
        ///  
        /// <para>
        /// Currently, you can use <code>GetDashboardEmbedURL</code> only from the server, not
        /// from the user’s browser.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        /// Assume the role with permissions enabled for actions: <code>quickSight:RegisterUser</code>
        /// and <code>quicksight:GetDashboardEmbedURL</code>. You can use assume-role, assume-role-with-web-identity,
        /// or assume-role-with-saml. 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws sts assume-role --role-arn "arn:aws:iam::111122223333:role/embedding_quicksight_dashboard_role"
        /// --role-session-name embeddingsession</code> 
        /// </para>
        ///  
        /// <para>
        /// If the user does not exist in QuickSight, register the user:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight register-user --aws-account-id 111122223333 --namespace default
        /// --identity-type IAM --iam-arn "arn:aws:iam::111122223333:role/embedding_quicksight_dashboard_role"
        /// --user-role READER --session-name "embeddingsession" --email user123@example.com --region
        /// us-east-1</code> 
        /// </para>
        ///  
        /// <para>
        /// Get the URL for the embedded dashboard (<code>IAM</code> identity authentication):
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight get-dashboard-embed-url --aws-account-id 111122223333 --dashboard-id
        /// 1a1ac2b2-3fc3-4b44-5e5d-c6db6778df89 --identity-type IAM</code> 
        /// </para>
        ///  
        /// <para>
        /// Get the URL for the embedded dashboard (<code>QUICKSIGHT</code> identity authentication):
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight get-dashboard-embed-url --aws-account-id 111122223333 --dashboard-id
        /// 1a1ac2b2-3fc3-4b44-5e5d-c6db6778df89 --identity-type QUICKSIGHT --user-arn arn:aws:quicksight:us-east-1:111122223333:user/default/embedding_quicksight_dashboard_role/embeddingsession</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboardEmbedUrl service method.</param>
        /// 
        /// <returns>The response from the GetDashboardEmbedUrl service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.DomainNotWhitelistedException">
        /// The domain specified is not on the allowlist. All domains for embedded dashboards
        /// must be added to the approved list by an Amazon QuickSight admin.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.IdentityTypeNotSupportedException">
        /// The identity type specified is not supported. Supported identity types include IAM
        /// and QUICKSIGHT.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user is not found. This error can happen in any operation that requires finding
        /// a user based on a provided user name, such as <code>DeleteUser</code>, <code>DescribeUser</code>,
        /// and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session is not valid. The session
        /// lifetime must be from 15 to 600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        GetDashboardEmbedUrlResponse GetDashboardEmbedUrl(GetDashboardEmbedUrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDashboardEmbedUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDashboardEmbedUrl operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDashboardEmbedUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        IAsyncResult BeginGetDashboardEmbedUrl(GetDashboardEmbedUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDashboardEmbedUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDashboardEmbedUrl.</param>
        /// 
        /// <returns>Returns a  GetDashboardEmbedUrlResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        GetDashboardEmbedUrlResponse EndGetDashboardEmbedUrl(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDashboards


        /// <summary>
        /// Lists dashboards in the AWS account.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-dashboards --aws-account-id 111122223333 --max-results
        /// 5 —next-token 'next-10'</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        ListDashboardsResponse ListDashboards(ListDashboardsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDashboards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDashboards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        IAsyncResult BeginListDashboards(ListDashboardsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDashboards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDashboards.</param>
        /// 
        /// <returns>Returns a  ListDashboardsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        ListDashboardsResponse EndListDashboards(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDashboardVersions


        /// <summary>
        /// Lists all the versions of the dashboards in the Quicksight subscription.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        /// aws quicksight list-template-versions —aws-account-id 111122223333 —template-id reports-test-template
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboardVersions service method.</param>
        /// 
        /// <returns>The response from the ListDashboardVersions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboardVersions">REST API Reference for ListDashboardVersions Operation</seealso>
        ListDashboardVersionsResponse ListDashboardVersions(ListDashboardVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDashboardVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDashboardVersions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDashboardVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboardVersions">REST API Reference for ListDashboardVersions Operation</seealso>
        IAsyncResult BeginListDashboardVersions(ListDashboardVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDashboardVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDashboardVersions.</param>
        /// 
        /// <returns>Returns a  ListDashboardVersionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboardVersions">REST API Reference for ListDashboardVersions Operation</seealso>
        ListDashboardVersionsResponse EndListDashboardVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataSets


        /// <summary>
        /// Lists all of the datasets belonging to this account in an AWS region.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:dataset/*</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax: <code>aws quicksight list-data-sets --aws-account-id=111111111111</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets service method.</param>
        /// 
        /// <returns>The response from the ListDataSets service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        ListDataSetsResponse ListDataSets(ListDataSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        IAsyncResult BeginListDataSets(ListDataSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSets.</param>
        /// 
        /// <returns>Returns a  ListDataSetsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        ListDataSetsResponse EndListDataSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataSources


        /// <summary>
        /// Lists data sources in current AWS region that belong to this AWS account.
        /// 
        ///  
        /// <para>
        /// The permissions resource is: <code>arn:aws:quicksight:region:aws-account-id:datasource/*</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax: <code>aws quicksight list-data-sources --aws-account-id=111122223333</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        IAsyncResult BeginListDataSources(ListDataSourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSources.</param>
        /// 
        /// <returns>Returns a  ListDataSourcesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        ListDataSourcesResponse EndListDataSources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroupMemberships


        /// <summary>
        /// Lists member users in a group.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a list of group member objects.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-group-memberships -\-aws-account-id=111122223333 -\-namespace=default
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships service method.</param>
        /// 
        /// <returns>The response from the ListGroupMemberships service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        ListGroupMembershipsResponse ListGroupMemberships(ListGroupMembershipsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        IAsyncResult BeginListGroupMemberships(ListGroupMembershipsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupMemberships.</param>
        /// 
        /// <returns>Returns a  ListGroupMembershipsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        ListGroupMembershipsResponse EndListGroupMemberships(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Lists all user groups in Amazon QuickSight. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/*</code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a list of group objects. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-groups -\-aws-account-id=111122223333 -\-namespace=default
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse EndListGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIAMPolicyAssignments


        /// <summary>
        /// Lists assignments in current QuickSight account.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-iam-policy-assignments --aws-account-id=111122223333 --max-result=5
        /// --assignment-status=ENABLED --namespace=default --region=us-east-1 --next-token=3
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignments service method.</param>
        /// 
        /// <returns>The response from the ListIAMPolicyAssignments service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignments">REST API Reference for ListIAMPolicyAssignments Operation</seealso>
        ListIAMPolicyAssignmentsResponse ListIAMPolicyAssignments(ListIAMPolicyAssignmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIAMPolicyAssignments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignments operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIAMPolicyAssignments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignments">REST API Reference for ListIAMPolicyAssignments Operation</seealso>
        IAsyncResult BeginListIAMPolicyAssignments(ListIAMPolicyAssignmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIAMPolicyAssignments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIAMPolicyAssignments.</param>
        /// 
        /// <returns>Returns a  ListIAMPolicyAssignmentsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignments">REST API Reference for ListIAMPolicyAssignments Operation</seealso>
        ListIAMPolicyAssignmentsResponse EndListIAMPolicyAssignments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIAMPolicyAssignmentsForUser


        /// <summary>
        /// Lists all the assignments and the ARNs for the associated IAM policies assigned to
        /// the specified user and the group or groups that the user belongs to.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-iam-policy-assignments-for-user --aws-account-id=111122223333
        /// --user-name=user5 --namespace=default --max-result=6 --region=us-east-1 </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignmentsForUser service method.</param>
        /// 
        /// <returns>The response from the ListIAMPolicyAssignmentsForUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in an "actionable" state that must complete before a new update
        /// can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignmentsForUser">REST API Reference for ListIAMPolicyAssignmentsForUser Operation</seealso>
        ListIAMPolicyAssignmentsForUserResponse ListIAMPolicyAssignmentsForUser(ListIAMPolicyAssignmentsForUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIAMPolicyAssignmentsForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignmentsForUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIAMPolicyAssignmentsForUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignmentsForUser">REST API Reference for ListIAMPolicyAssignmentsForUser Operation</seealso>
        IAsyncResult BeginListIAMPolicyAssignmentsForUser(ListIAMPolicyAssignmentsForUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIAMPolicyAssignmentsForUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIAMPolicyAssignmentsForUser.</param>
        /// 
        /// <returns>Returns a  ListIAMPolicyAssignmentsForUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignmentsForUser">REST API Reference for ListIAMPolicyAssignmentsForUser Operation</seealso>
        ListIAMPolicyAssignmentsForUserResponse EndListIAMPolicyAssignmentsForUser(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIngestions


        /// <summary>
        /// Lists the history of SPICE ingestions for a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestions service method.</param>
        /// 
        /// <returns>The response from the ListIngestions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIngestions">REST API Reference for ListIngestions Operation</seealso>
        ListIngestionsResponse ListIngestions(ListIngestionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIngestions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIngestions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIngestions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIngestions">REST API Reference for ListIngestions Operation</seealso>
        IAsyncResult BeginListIngestions(ListIngestionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIngestions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIngestions.</param>
        /// 
        /// <returns>Returns a  ListIngestionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIngestions">REST API Reference for ListIngestions Operation</seealso>
        ListIngestionsResponse EndListIngestions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags assigned to a resource.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aws quicksight list-tags-for-resource --resource-arn arn:aws:quicksight:us-east-1:111111111111:dataset/dataset1
        /// --region us-east-1</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTemplateAliases


        /// <summary>
        /// Lists all the aliases of a template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-template-aliases --aws-account-id 111122223333 —template-id
        /// 'reports_test_template'</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateAliases service method.</param>
        /// 
        /// <returns>The response from the ListTemplateAliases service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateAliases">REST API Reference for ListTemplateAliases Operation</seealso>
        ListTemplateAliasesResponse ListTemplateAliases(ListTemplateAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplateAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateAliases operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplateAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateAliases">REST API Reference for ListTemplateAliases Operation</seealso>
        IAsyncResult BeginListTemplateAliases(ListTemplateAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplateAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplateAliases.</param>
        /// 
        /// <returns>Returns a  ListTemplateAliasesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateAliases">REST API Reference for ListTemplateAliases Operation</seealso>
        ListTemplateAliasesResponse EndListTemplateAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTemplates


        /// <summary>
        /// Lists all the templates in the QuickSight account.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-templates --aws-account-id 111122223333 --max-results 1
        /// —next-token AYADeJuxwOypAndSoOn</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        ListTemplatesResponse ListTemplates(ListTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        IAsyncResult BeginListTemplates(ListTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplates.</param>
        /// 
        /// <returns>Returns a  ListTemplatesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        ListTemplatesResponse EndListTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTemplateVersions


        /// <summary>
        /// Lists all the versions of the templates in the Quicksight account.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        /// aws quicksight list-template-versions --aws-account-id 111122223333 --aws-account-id
        /// 196359894473 --template-id reports-test-template
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateVersions service method.</param>
        /// 
        /// <returns>The response from the ListTemplateVersions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        ListTemplateVersionsResponse ListTemplateVersions(ListTemplateVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateVersions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplateVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        IAsyncResult BeginListTemplateVersions(ListTemplateVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplateVersions.</param>
        /// 
        /// <returns>Returns a  ListTemplateVersionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        ListTemplateVersionsResponse EndListTemplateVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUserGroups


        /// <summary>
        /// Lists the Amazon QuickSight groups that an Amazon QuickSight user is a member of.
        /// 
        ///  
        /// <para>
        /// The response is a one or more group objects. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-user-groups -\-user-name=Pat -\-aws-account-id=111122223333
        /// -\-namespace=default -\-region=us-east-1 </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserGroups service method.</param>
        /// 
        /// <returns>The response from the ListUserGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        ListUserGroupsResponse ListUserGroups(ListUserGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserGroups operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        IAsyncResult BeginListUserGroups(ListUserGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserGroups.</param>
        /// 
        /// <returns>Returns a  ListUserGroupsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        ListUserGroupsResponse EndListUserGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Returns a list of all of the Amazon QuickSight users belonging to this account. 
        /// 
        ///  
        /// <para>
        /// The response is a list of user objects, containing each user's Amazon Resource Name
        /// (ARN), AWS Identity and Access Management (IAM) role, and email address. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-users --aws-account-id=111122223333 --namespace=default
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse ListUsers(ListUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse EndListUsers(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterUser


        /// <summary>
        /// Creates an Amazon QuickSight user, whose identity is associated with the AWS Identity
        /// and Access Management (IAM) identity or role specified in the request. 
        /// 
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight register-user -\-aws-account-id=111122223333 -\-namespace=default
        /// -\-email=pat@example.com -\-identity-type=IAM -\-user-role=AUTHOR -\-iam-arn=arn:aws:iam::111122223333:user/Pat
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterUser service method.</param>
        /// 
        /// <returns>The response from the RegisterUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        RegisterUserResponse RegisterUser(RegisterUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        IAsyncResult BeginRegisterUser(RegisterUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterUser.</param>
        /// 
        /// <returns>Returns a  RegisterUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        RegisterUserResponse EndRegisterUser(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns a tag or tags to a resource.
        /// 
        ///  
        /// <para>
        /// Assigns one or more tags (key-value pairs) to the specified QuickSight resource. Tags
        /// can help you organize and categorize your resources. You can also use them to scope
        /// user permissions, by granting a user permission to access or change only resources
        /// with certain tag values. You can use the TagResource action with a resource that already
        /// has tags. If you specify a new tag key for the resource, this tag is appended to the
        /// list of tags associated with the resource. If you specify a tag key that is already
        /// associated with the resource, the new tag value that you specify replaces the previous
        /// value for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource. QuickSight supports tagging
        /// on data-set, data-source, dashboard, template. 
        /// </para>
        ///  
        /// <para>
        /// Tagging for QuickSight works in a similar was to tagging for other AWS services, except
        /// for the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can't use tags to track AWS costs for QuickSight, because QuickSight costs are
        /// based on users and SPICE capacity, which aren't taggable resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// QuickSight doesn't currently support the Tag Editor for AWS Resource Groups.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// CLI syntax to tag a resource:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aws quicksight tag-resource --resource-arn arn:aws:quicksight:us-east-1:111111111111:dataset/dataset1
        /// --tags Key=K1,Value=V1 Key=K2,Value=V2 --region us-east-1</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag or tags from a resource.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aws quicksight untag-resource --resource-arn arn:aws:quicksight:us-east-1:111111111111:dataset/dataset1
        /// --tag-keys K1 K2 --region us-east-1</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDashboard


        /// <summary>
        /// Updates a dashboard in the AWS account.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-dashboard --aws-account-id 111122223333 --dashboard-id
        /// 123123123 --dashboard-name "test-update102" --source-entity SourceTemplate={Arn=arn:aws:quicksight:us-west-2:111122223333:template/sales-report-template2}
        /// --data-set-references DataSetPlaceholder=SalesDataSet,DataSetArn=arn:aws:quicksight:us-west-2:111122223333:dataset/0e251aef-9ebf-46e1-b852-eb4fa33c1d3a</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-dashboard --cli-input-json file://update-dashboard.json
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        UpdateDashboardResponse UpdateDashboard(UpdateDashboardRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        IAsyncResult BeginUpdateDashboard(UpdateDashboardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDashboard.</param>
        /// 
        /// <returns>Returns a  UpdateDashboardResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        UpdateDashboardResponse EndUpdateDashboard(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDashboardPermissions


        /// <summary>
        /// Updates read and write permissions on a dashboard.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-dashboard-permissions —cli-input-json file://update-permission.json</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// A sample update-permissions.json for granting read only permissions:
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "AwsAccountId": "111122223333", "DashboardId": "reports_test_report", "GrantPermissions":
        /// [ { "Principal": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2", "Actions":
        /// [ "quicksight:DescribeDashboard", "quicksight:ListDashboardVersions", "quicksight:DescribeDashboardVersion",
        /// "quicksight:QueryDashboard" ] } ] }</code> 
        /// </para>
        ///  
        /// <para>
        /// A sample update-permissions.json for granting read and write permissions:
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "AwsAccountId": "111122223333", "DashboardId": "reports_test_report", "GrantPermissions":
        /// [ { "Principal": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2", "Actions":
        /// [ "quicksight:DescribeDashboard", "quicksight:ListDashboardVersions", "quicksight:DescribeDashboardVersion",
        /// "quicksight:QueryDashboard", "quicksight:DescribeDashboardPermissions", "quicksight:UpdateDashboardPermissions",
        /// "quicksight:DeleteDashboardVersion", "quicksight:DeleteDashboard", "quicksight:UpdateDashboard",
        /// "quicksight:UpdateDashboardPublishedVersion", ] } ] }</code> 
        /// </para>
        ///  
        /// <para>
        /// A sample update-permissions.json for revoking write permissions:
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "AwsAccountId": "111122223333", "DashboardId": "reports_test_report", "RevokePermissions":
        /// [ { "Principal": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2", "Actions":
        /// [ "quicksight:DescribeDashboardPermissions", "quicksight:UpdateDashboardPermissions",
        /// "quicksight:DeleteDashboardVersion", "quicksight:DeleteDashboard", "quicksight:UpdateDashboard",
        /// "quicksight:UpdateDashboardPublishedVersion", ] } ] }</code> 
        /// </para>
        ///  
        /// <para>
        /// A sample update-permissions.json for revoking read and write permissions:
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "AwsAccountId": "111122223333", "DashboardId": "reports_test_report", "RevokePermissions":
        /// [ { "Principal": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2", "Actions":
        /// [ "quicksight:DescribeDashboard", "quicksight:ListDashboardVersions", "quicksight:DescribeDashboardVersion",
        /// "quicksight:QueryDashboard", "quicksight:DescribeDashboardPermissions", "quicksight:UpdateDashboardPermissions",
        /// "quicksight:DeleteDashboardVersion", "quicksight:DeleteDashboard", "quicksight:UpdateDashboard",
        /// "quicksight:UpdateDashboardPublishedVersion", ] } ] }</code> 
        /// </para>
        ///  
        /// <para>
        /// To obtain the principal name of a QuickSight user or group, you can use describe-group
        /// or describe-user. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-user --aws-account-id 111122223333 --namespace default
        /// --user-name user2 --region us-east-1 { "User": { "Arn": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2",
        /// "Active": true, "Email": "user2@example.com", "Role": "ADMIN", "UserName": "user2",
        /// "PrincipalId": "federated/iam/abcd2abcdabcdeabc5ab5" }, "RequestId": "8f74bb31-6291-448a-a71c-a765a44bae31",
        /// "Status": 200 }</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboardPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPermissions">REST API Reference for UpdateDashboardPermissions Operation</seealso>
        UpdateDashboardPermissionsResponse UpdateDashboardPermissions(UpdateDashboardPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDashboardPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDashboardPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPermissions">REST API Reference for UpdateDashboardPermissions Operation</seealso>
        IAsyncResult BeginUpdateDashboardPermissions(UpdateDashboardPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDashboardPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDashboardPermissions.</param>
        /// 
        /// <returns>Returns a  UpdateDashboardPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPermissions">REST API Reference for UpdateDashboardPermissions Operation</seealso>
        UpdateDashboardPermissionsResponse EndUpdateDashboardPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDashboardPublishedVersion


        /// <summary>
        /// Updates the published version of a dashboard.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-dashboard-published-version --aws-account-id 111122223333
        /// --dashboard-id dashboard-w1 ---version-number 2</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPublishedVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboardPublishedVersion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPublishedVersion">REST API Reference for UpdateDashboardPublishedVersion Operation</seealso>
        UpdateDashboardPublishedVersionResponse UpdateDashboardPublishedVersion(UpdateDashboardPublishedVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDashboardPublishedVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPublishedVersion operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDashboardPublishedVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPublishedVersion">REST API Reference for UpdateDashboardPublishedVersion Operation</seealso>
        IAsyncResult BeginUpdateDashboardPublishedVersion(UpdateDashboardPublishedVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDashboardPublishedVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDashboardPublishedVersion.</param>
        /// 
        /// <returns>Returns a  UpdateDashboardPublishedVersionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPublishedVersion">REST API Reference for UpdateDashboardPublishedVersion Operation</seealso>
        UpdateDashboardPublishedVersionResponse EndUpdateDashboardPublishedVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataSet


        /// <summary>
        /// Updates a dataset.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-data-set \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-set-id=unique-data-set-id \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--name='My dataset' \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--import-mode=SPICE \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--physical-table-map='{</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "physical-table-id": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "RelationalTable": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "DataSourceArn": "arn:aws:quicksight:us-west-2:111111111111:datasource/data-source-id",</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Name": "table1",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "InputColumns": [</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Name": "column1",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Type": "STRING"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> }</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> ]</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> }</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> }'</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSet service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        UpdateDataSetResponse UpdateDataSet(UpdateDataSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSet operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        IAsyncResult BeginUpdateDataSet(UpdateDataSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSet.</param>
        /// 
        /// <returns>Returns a  UpdateDataSetResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        UpdateDataSetResponse EndUpdateDataSet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataSetPermissions


        /// <summary>
        /// Updates the permissions on a dataset.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:dataset/data-set-id</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax: 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-data-set-permissions \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-set-id=unique-data-set-id \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--grant-permissions='[{"Principal":"arn:aws:quicksight:us-east-1:111122223333:user/default/user1","Actions":["quicksight:DescribeDataSet","quicksight:DescribeDataSetPermissions","quicksight:PassDataSet","quicksight:ListIngestions","quicksight:DescribeIngestion"]}]'
        /// \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--revoke-permissions='[{"Principal":"arn:aws:quicksight:us-east-1:111122223333:user/default/user2","Actions":["quicksight:UpdateDataSet","quicksight:DeleteDataSet","quicksight:UpdateDataSetPermissions","quicksight:CreateIngestion","quicksight:CancelIngestion"]}]'</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSetPermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSetPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSetPermissions">REST API Reference for UpdateDataSetPermissions Operation</seealso>
        UpdateDataSetPermissionsResponse UpdateDataSetPermissions(UpdateDataSetPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSetPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSetPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSetPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSetPermissions">REST API Reference for UpdateDataSetPermissions Operation</seealso>
        IAsyncResult BeginUpdateDataSetPermissions(UpdateDataSetPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSetPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSetPermissions.</param>
        /// 
        /// <returns>Returns a  UpdateDataSetPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSetPermissions">REST API Reference for UpdateDataSetPermissions Operation</seealso>
        UpdateDataSetPermissionsResponse EndUpdateDataSetPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataSource


        /// <summary>
        /// Updates a data source.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:datasource/data-source-id</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-data-source \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-source-id=unique-data-source-id \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--name='My Data Source' \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-source-parameters='{"PostgreSqlParameters":{"Host":"my-db-host.example.com","Port":1234,"Database":"my-db"}}'
        /// \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--credentials='{"CredentialPair":{"Username":"username","Password":"password"}}</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        IAsyncResult BeginUpdateDataSource(UpdateDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSource.</param>
        /// 
        /// <returns>Returns a  UpdateDataSourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        UpdateDataSourceResponse EndUpdateDataSource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataSourcePermissions


        /// <summary>
        /// Updates the permissions to a data source.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:datasource/data-source-id</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-data-source-permissions \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-source-id=unique-data-source-id \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--name='My Data Source' \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--grant-permissions='[{"Principal":"arn:aws:quicksight:us-east-1:111122223333:user/default/user1","Actions":["quicksight:DescribeDataSource","quicksight:DescribeDataSourcePermissions","quicksight:PassDataSource"]}]'
        /// \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--revoke-permissions='[{"Principal":"arn:aws:quicksight:us-east-1:111122223333:user/default/user2","Actions":["quicksight:UpdateDataSource","quicksight:DeleteDataSource","quicksight:UpdateDataSourcePermissions"]}]'</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSourcePermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSourcePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSourcePermissions">REST API Reference for UpdateDataSourcePermissions Operation</seealso>
        UpdateDataSourcePermissionsResponse UpdateDataSourcePermissions(UpdateDataSourcePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSourcePermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSourcePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSourcePermissions">REST API Reference for UpdateDataSourcePermissions Operation</seealso>
        IAsyncResult BeginUpdateDataSourcePermissions(UpdateDataSourcePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSourcePermissions.</param>
        /// 
        /// <returns>Returns a  UpdateDataSourcePermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSourcePermissions">REST API Reference for UpdateDataSourcePermissions Operation</seealso>
        UpdateDataSourcePermissionsResponse EndUpdateDataSourcePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Changes a group description. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a group object.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-group --aws-account-id=111122223333 --namespace=default
        /// --group-name=Sales --description="Sales BI Dashboards" </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIAMPolicyAssignment


        /// <summary>
        /// Updates an existing assignment. This operation updates only the optional parameter
        /// or parameters that are specified in the request.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code/>aws quicksight update-iam-policy-assignment --aws-account-id=111122223333
        /// --assignment-name=FullAccessAssignment --assignment-status=DRAFT --policy-arns=arn:aws:iam::aws:policy/AdministratorAccess
        /// --identities="user=user-1,user-2,group=admin" --namespace=default --region=us-east-1
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIAMPolicyAssignment service method.</param>
        /// 
        /// <returns>The response from the UpdateIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in an "actionable" state that must complete before a new update
        /// can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIAMPolicyAssignment">REST API Reference for UpdateIAMPolicyAssignment Operation</seealso>
        UpdateIAMPolicyAssignmentResponse UpdateIAMPolicyAssignment(UpdateIAMPolicyAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIAMPolicyAssignment operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIAMPolicyAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIAMPolicyAssignment">REST API Reference for UpdateIAMPolicyAssignment Operation</seealso>
        IAsyncResult BeginUpdateIAMPolicyAssignment(UpdateIAMPolicyAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIAMPolicyAssignment.</param>
        /// 
        /// <returns>Returns a  UpdateIAMPolicyAssignmentResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIAMPolicyAssignment">REST API Reference for UpdateIAMPolicyAssignment Operation</seealso>
        UpdateIAMPolicyAssignmentResponse EndUpdateIAMPolicyAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTemplate


        /// <summary>
        /// Updates a template from an existing QuickSight analysis.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-template --aws-account-id 111122223333 --template-id
        /// reports_test_template --data-set-references DataSetPlaceholder=reports,DataSetArn=arn:aws:quicksight:us-west-2:111122223333:dataset/c684a204-d134-4c53-a63c-451f72c60c28
        /// DataSetPlaceholder=Elblogs,DataSetArn=arn:aws:quicksight:us-west-2:111122223333:dataset/15840b7d-b542-4491-937b-602416b367b3
        /// —source-entity SourceAnalysis=’{Arn=arn:aws:quicksight:us-west-2:111122223333:analysis/c5731fe9-4708-4598-8f6d-cf2a70875b6d}</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can also pass in a json file: <code>aws quicksight update-template —cli-input-json
        /// file://create-template.json</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        IAsyncResult BeginUpdateTemplate(UpdateTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateTemplateResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        UpdateTemplateResponse EndUpdateTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTemplateAlias


        /// <summary>
        /// Updates the template alias of a template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-template-alias --aws-account-id 111122223333 --template-id
        /// 'reports_test_template' --alias-name STAGING —template-version-number 2 </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplateAlias">REST API Reference for UpdateTemplateAlias Operation</seealso>
        UpdateTemplateAliasResponse UpdateTemplateAlias(UpdateTemplateAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplateAlias">REST API Reference for UpdateTemplateAlias Operation</seealso>
        IAsyncResult BeginUpdateTemplateAlias(UpdateTemplateAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplateAlias.</param>
        /// 
        /// <returns>Returns a  UpdateTemplateAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplateAlias">REST API Reference for UpdateTemplateAlias Operation</seealso>
        UpdateTemplateAliasResponse EndUpdateTemplateAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTemplatePermissions


        /// <summary>
        /// Updates the permissions on a template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aws quicksight describe-template-permissions —aws-account-id 111122223333 —template-id
        /// reports_test_template</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aws quicksight update-template-permissions —cli-input-json file://update-permission.json
        /// </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The structure of <code>update-permissions.json</code> to add permissions:
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "AwsAccountId": "111122223333",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "DashboardId": "reports_test_template",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "GrantPermissions": [</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> { "Principal": "arn:aws:quicksight:us-east-1:196359894473:user/default/user3",</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Actions": [</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "quicksight:DescribeTemplate",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "quicksight:ListTemplateVersions"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> ] } ] }</code> 
        /// </para>
        ///  
        /// <para>
        /// The structure of <code>update-permissions.json</code> to add permissions:
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "AwsAccountId": "111122223333",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "DashboardId": "reports_test_template",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "RevokePermissions": [</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> { "Principal": "arn:aws:quicksight:us-east-1:196359894473:user/default/user3",</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Actions": [</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "quicksight:DescribeTemplate",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "quicksight:ListTemplateVersions"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> ] } ] }</code> 
        /// </para>
        ///  
        /// <para>
        /// To obtain the principal name of a QuickSight group or user, use user describe-group
        /// or describe-user. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-user </code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id 111122223333</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--namespace default</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--user-name user2 </code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--region us-east-1</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>{</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "User": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Arn": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2",</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Active": true,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Email": "user2@example.com",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Role": "ADMIN",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "UserName": "user2",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "PrincipalId": "federated/iam/abcd2abcdabcdeabc5ab5"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> },</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "RequestId": "8f74bb31-6291-448a-a71c-a765a44bae31",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Status": 200</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>}</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplatePermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplatePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplatePermissions">REST API Reference for UpdateTemplatePermissions Operation</seealso>
        UpdateTemplatePermissionsResponse UpdateTemplatePermissions(UpdateTemplatePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplatePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplatePermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplatePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplatePermissions">REST API Reference for UpdateTemplatePermissions Operation</seealso>
        IAsyncResult BeginUpdateTemplatePermissions(UpdateTemplatePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplatePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplatePermissions.</param>
        /// 
        /// <returns>Returns a  UpdateTemplatePermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplatePermissions">REST API Reference for UpdateTemplatePermissions Operation</seealso>
        UpdateTemplatePermissionsResponse EndUpdateTemplatePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Updates an Amazon QuickSight user.
        /// 
        ///  
        /// <para>
        /// The response is a user object that contains the user's Amazon QuickSight user name,
        /// email address, active or inactive status in Amazon QuickSight, Amazon QuickSight role,
        /// and Amazon Resource Name (ARN). 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-user --user-name=Pat --role=ADMIN --email=new_address@example.com
        /// --aws-account-id=111122223333 --namespace=default --region=us-east-1 </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse UpdateUser(UpdateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult);

        #endregion
        
    }
}