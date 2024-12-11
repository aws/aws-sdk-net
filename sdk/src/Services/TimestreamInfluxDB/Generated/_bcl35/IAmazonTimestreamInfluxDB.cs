/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.TimestreamInfluxDB.Model;

#pragma warning disable CS1570
namespace Amazon.TimestreamInfluxDB
{
    /// <summary>
    /// <para>Interface for accessing TimestreamInfluxDB</para>
    ///
    /// Amazon Timestream for InfluxDB is a managed time-series database engine that makes
    /// it easy for application developers and DevOps teams to run InfluxDB databases on Amazon
    /// Web Services for near real-time time-series applications using open-source APIs. With
    /// Amazon Timestream for InfluxDB, it is easy to set up, operate, and scale time-series
    /// workloads that can answer queries with single-digit millisecond query response time.
    /// </summary>
    public partial interface IAmazonTimestreamInfluxDB : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITimestreamInfluxDBPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateDbInstance


        /// <summary>
        /// Creates a new Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDbInstance service method.</param>
        /// 
        /// <returns>The response from the CreateDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbInstance">REST API Reference for CreateDbInstance Operation</seealso>
        CreateDbInstanceResponse CreateDbInstance(CreateDbInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDbInstance operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDbInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbInstance">REST API Reference for CreateDbInstance Operation</seealso>
        IAsyncResult BeginCreateDbInstance(CreateDbInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDbInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDbInstance.</param>
        /// 
        /// <returns>Returns a  CreateDbInstanceResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbInstance">REST API Reference for CreateDbInstance Operation</seealso>
        CreateDbInstanceResponse EndCreateDbInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDbParameterGroup


        /// <summary>
        /// Creates a new Timestream for InfluxDB DB parameter group to associate with DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDbParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDbParameterGroup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbParameterGroup">REST API Reference for CreateDbParameterGroup Operation</seealso>
        CreateDbParameterGroupResponse CreateDbParameterGroup(CreateDbParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDbParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDbParameterGroup operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDbParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbParameterGroup">REST API Reference for CreateDbParameterGroup Operation</seealso>
        IAsyncResult BeginCreateDbParameterGroup(CreateDbParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDbParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDbParameterGroup.</param>
        /// 
        /// <returns>Returns a  CreateDbParameterGroupResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbParameterGroup">REST API Reference for CreateDbParameterGroup Operation</seealso>
        CreateDbParameterGroupResponse EndCreateDbParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDbInstance


        /// <summary>
        /// Deletes a Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDbInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/DeleteDbInstance">REST API Reference for DeleteDbInstance Operation</seealso>
        DeleteDbInstanceResponse DeleteDbInstance(DeleteDbInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDbInstance operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDbInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/DeleteDbInstance">REST API Reference for DeleteDbInstance Operation</seealso>
        IAsyncResult BeginDeleteDbInstance(DeleteDbInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDbInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDbInstance.</param>
        /// 
        /// <returns>Returns a  DeleteDbInstanceResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/DeleteDbInstance">REST API Reference for DeleteDbInstance Operation</seealso>
        DeleteDbInstanceResponse EndDeleteDbInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDbInstance


        /// <summary>
        /// Returns a Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbInstance service method.</param>
        /// 
        /// <returns>The response from the GetDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbInstance">REST API Reference for GetDbInstance Operation</seealso>
        GetDbInstanceResponse GetDbInstance(GetDbInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDbInstance operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDbInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbInstance">REST API Reference for GetDbInstance Operation</seealso>
        IAsyncResult BeginGetDbInstance(GetDbInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDbInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDbInstance.</param>
        /// 
        /// <returns>Returns a  GetDbInstanceResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbInstance">REST API Reference for GetDbInstance Operation</seealso>
        GetDbInstanceResponse EndGetDbInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDbParameterGroup


        /// <summary>
        /// Returns a Timestream for InfluxDB DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbParameterGroup service method.</param>
        /// 
        /// <returns>The response from the GetDbParameterGroup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbParameterGroup">REST API Reference for GetDbParameterGroup Operation</seealso>
        GetDbParameterGroupResponse GetDbParameterGroup(GetDbParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDbParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDbParameterGroup operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDbParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbParameterGroup">REST API Reference for GetDbParameterGroup Operation</seealso>
        IAsyncResult BeginGetDbParameterGroup(GetDbParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDbParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDbParameterGroup.</param>
        /// 
        /// <returns>Returns a  GetDbParameterGroupResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbParameterGroup">REST API Reference for GetDbParameterGroup Operation</seealso>
        GetDbParameterGroupResponse EndGetDbParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDbInstances


        /// <summary>
        /// Returns a list of Timestream for InfluxDB DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbInstances service method.</param>
        /// 
        /// <returns>The response from the ListDbInstances service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbInstances">REST API Reference for ListDbInstances Operation</seealso>
        ListDbInstancesResponse ListDbInstances(ListDbInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDbInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDbInstances operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDbInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbInstances">REST API Reference for ListDbInstances Operation</seealso>
        IAsyncResult BeginListDbInstances(ListDbInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDbInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDbInstances.</param>
        /// 
        /// <returns>Returns a  ListDbInstancesResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbInstances">REST API Reference for ListDbInstances Operation</seealso>
        ListDbInstancesResponse EndListDbInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDbParameterGroups


        /// <summary>
        /// Returns a list of Timestream for InfluxDB DB parameter groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbParameterGroups service method.</param>
        /// 
        /// <returns>The response from the ListDbParameterGroups service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbParameterGroups">REST API Reference for ListDbParameterGroups Operation</seealso>
        ListDbParameterGroupsResponse ListDbParameterGroups(ListDbParameterGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDbParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDbParameterGroups operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDbParameterGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbParameterGroups">REST API Reference for ListDbParameterGroups Operation</seealso>
        IAsyncResult BeginListDbParameterGroups(ListDbParameterGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDbParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDbParameterGroups.</param>
        /// 
        /// <returns>Returns a  ListDbParameterGroupsResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbParameterGroups">REST API Reference for ListDbParameterGroups Operation</seealso>
        ListDbParameterGroupsResponse EndListDbParameterGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// A list of tags applied to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags are composed of a Key/Value pairs. You can use tags to categorize and track your
        /// Timestream for InfluxDB resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the tag from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDbInstance


        /// <summary>
        /// Updates a Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDbInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UpdateDbInstance">REST API Reference for UpdateDbInstance Operation</seealso>
        UpdateDbInstanceResponse UpdateDbInstance(UpdateDbInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDbInstance operation on AmazonTimestreamInfluxDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDbInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UpdateDbInstance">REST API Reference for UpdateDbInstance Operation</seealso>
        IAsyncResult BeginUpdateDbInstance(UpdateDbInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDbInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDbInstance.</param>
        /// 
        /// <returns>Returns a  UpdateDbInstanceResult from TimestreamInfluxDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UpdateDbInstance">REST API Reference for UpdateDbInstance Operation</seealso>
        UpdateDbInstanceResponse EndUpdateDbInstance(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}