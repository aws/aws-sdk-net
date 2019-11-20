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
using System.Threading;
using System.Threading.Tasks;
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
        /// Cancels an on-going ingestion of data into SPICE.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CancelIngestionResponse> CancelIngestionAsync(CancelIngestionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDashboardResponse> CreateDashboardAsync(CreateDashboardRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDataSetResponse> CreateDataSetAsync(CreateDataSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateGroupMembershipResponse> CreateGroupMembershipAsync(CreateGroupMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateIAMPolicyAssignmentResponse> CreateIAMPolicyAssignmentAsync(CreateIAMPolicyAssignmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateIngestionResponse> CreateIngestionAsync(CreateIngestionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateTemplateAliasResponse> CreateTemplateAliasAsync(CreateTemplateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDashboardResponse> DeleteDashboardAsync(DeleteDashboardRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDataSetResponse> DeleteDataSetAsync(DeleteDataSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteGroupMembershipResponse> DeleteGroupMembershipAsync(DeleteGroupMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteIAMPolicyAssignmentResponse> DeleteIAMPolicyAssignmentAsync(DeleteIAMPolicyAssignmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteTemplateAliasResponse> DeleteTemplateAliasAsync(DeleteTemplateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteUserByPrincipalIdResponse> DeleteUserByPrincipalIdAsync(DeleteUserByPrincipalIdRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeDashboardResponse> DescribeDashboardAsync(DescribeDashboardRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeDashboardPermissionsResponse> DescribeDashboardPermissionsAsync(DescribeDashboardPermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeDataSetResponse> DescribeDataSetAsync(DescribeDataSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeDataSetPermissionsResponse> DescribeDataSetPermissionsAsync(DescribeDataSetPermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes a data source.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:datasource/data-source-id</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeDataSourceResponse> DescribeDataSourceAsync(DescribeDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes the resource permissions for a data source.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>aws:quicksight:region:aws-account-id:datasource/data-source-id</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSourcePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeDataSourcePermissionsResponse> DescribeDataSourcePermissionsAsync(DescribeDataSourcePermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeGroupResponse> DescribeGroupAsync(DescribeGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeIAMPolicyAssignmentResponse> DescribeIAMPolicyAssignmentAsync(DescribeIAMPolicyAssignmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes a SPICE ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeIngestionResponse> DescribeIngestionAsync(DescribeIngestionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeTemplateResponse> DescribeTemplateAsync(DescribeTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeTemplateAliasResponse> DescribeTemplateAliasAsync(DescribeTemplateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeTemplatePermissionsResponse> DescribeTemplatePermissionsAsync(DescribeTemplatePermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDashboardEmbedUrlResponse> GetDashboardEmbedUrlAsync(GetDashboardEmbedUrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDashboardsResponse> ListDashboardsAsync(ListDashboardsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDashboardVersionsResponse> ListDashboardVersionsAsync(ListDashboardVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDataSetsResponse> ListDataSetsAsync(ListDataSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListGroupMembershipsResponse> ListGroupMembershipsAsync(ListGroupMembershipsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListIAMPolicyAssignmentsResponse> ListIAMPolicyAssignmentsAsync(ListIAMPolicyAssignmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListIAMPolicyAssignmentsForUserResponse> ListIAMPolicyAssignmentsForUserAsync(ListIAMPolicyAssignmentsForUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the history of SPICE ingestions for a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListIngestionsResponse> ListIngestionsAsync(ListIngestionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTemplateAliasesResponse> ListTemplateAliasesAsync(ListTemplateAliasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTemplateVersionsResponse> ListTemplateVersionsAsync(ListTemplateVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListUserGroupsResponse> ListUserGroupsAsync(ListUserGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RegisterUserResponse> RegisterUserAsync(RegisterUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateDashboardResponse> UpdateDashboardAsync(UpdateDashboardRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateDashboardPermissionsResponse> UpdateDashboardPermissionsAsync(UpdateDashboardPermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateDashboardPublishedVersionResponse> UpdateDashboardPublishedVersionAsync(UpdateDashboardPublishedVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateDataSetResponse> UpdateDataSetAsync(UpdateDataSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateDataSetPermissionsResponse> UpdateDataSetPermissionsAsync(UpdateDataSetPermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateDataSourcePermissionsResponse> UpdateDataSourcePermissionsAsync(UpdateDataSourcePermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateIAMPolicyAssignmentResponse> UpdateIAMPolicyAssignmentAsync(UpdateIAMPolicyAssignmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateTemplateAliasResponse> UpdateTemplateAliasAsync(UpdateTemplateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateTemplatePermissionsResponse> UpdateTemplatePermissionsAsync(UpdateTemplatePermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}