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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTDeviceAdvisor.Model;

namespace Amazon.IoTDeviceAdvisor
{
    /// <summary>
    /// Interface for accessing IoTDeviceAdvisor
    ///
    /// AWS IoT Core Device Advisor is a cloud-based, fully managed test capability for validating
    /// IoT devices during device software development. Device Advisor provides pre-built
    /// tests that you can use to validate IoT devices for reliable and secure connectivity
    /// with AWS IoT Core before deploying devices to production. By using Device Advisor,
    /// you can confirm that your devices can connect to AWS IoT Core, follow security best
    /// practices and, if applicable, receive software updates from IoT Device Management.
    /// You can also download signed qualification reports to submit to the AWS Partner Network
    /// to get your device qualified for the AWS Partner Device Catalog without the need to
    /// send your device in and wait for it to be tested.
    /// </summary>
    public partial interface IAmazonIoTDeviceAdvisor : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTDeviceAdvisorPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateSuiteDefinition


        /// <summary>
        /// Creates a Device Advisor test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSuiteDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/CreateSuiteDefinition">REST API Reference for CreateSuiteDefinition Operation</seealso>
        CreateSuiteDefinitionResponse CreateSuiteDefinition(CreateSuiteDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSuiteDefinition operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSuiteDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/CreateSuiteDefinition">REST API Reference for CreateSuiteDefinition Operation</seealso>
        IAsyncResult BeginCreateSuiteDefinition(CreateSuiteDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSuiteDefinition.</param>
        /// 
        /// <returns>Returns a  CreateSuiteDefinitionResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/CreateSuiteDefinition">REST API Reference for CreateSuiteDefinition Operation</seealso>
        CreateSuiteDefinitionResponse EndCreateSuiteDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSuiteDefinition


        /// <summary>
        /// Deletes a Device Advisor test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuiteDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/DeleteSuiteDefinition">REST API Reference for DeleteSuiteDefinition Operation</seealso>
        DeleteSuiteDefinitionResponse DeleteSuiteDefinition(DeleteSuiteDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuiteDefinition operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSuiteDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/DeleteSuiteDefinition">REST API Reference for DeleteSuiteDefinition Operation</seealso>
        IAsyncResult BeginDeleteSuiteDefinition(DeleteSuiteDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSuiteDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteSuiteDefinitionResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/DeleteSuiteDefinition">REST API Reference for DeleteSuiteDefinition Operation</seealso>
        DeleteSuiteDefinitionResponse EndDeleteSuiteDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSuiteDefinition


        /// <summary>
        /// Gets information about a Device Advisor test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteDefinition service method.</param>
        /// 
        /// <returns>The response from the GetSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends Resource Not Found Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteDefinition">REST API Reference for GetSuiteDefinition Operation</seealso>
        GetSuiteDefinitionResponse GetSuiteDefinition(GetSuiteDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteDefinition operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSuiteDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteDefinition">REST API Reference for GetSuiteDefinition Operation</seealso>
        IAsyncResult BeginGetSuiteDefinition(GetSuiteDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSuiteDefinition.</param>
        /// 
        /// <returns>Returns a  GetSuiteDefinitionResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteDefinition">REST API Reference for GetSuiteDefinition Operation</seealso>
        GetSuiteDefinitionResponse EndGetSuiteDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSuiteRun


        /// <summary>
        /// Gets information about a Device Advisor test suite run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteRun service method.</param>
        /// 
        /// <returns>The response from the GetSuiteRun service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends Resource Not Found Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRun">REST API Reference for GetSuiteRun Operation</seealso>
        GetSuiteRunResponse GetSuiteRun(GetSuiteRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSuiteRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteRun operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSuiteRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRun">REST API Reference for GetSuiteRun Operation</seealso>
        IAsyncResult BeginGetSuiteRun(GetSuiteRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSuiteRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSuiteRun.</param>
        /// 
        /// <returns>Returns a  GetSuiteRunResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRun">REST API Reference for GetSuiteRun Operation</seealso>
        GetSuiteRunResponse EndGetSuiteRun(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSuiteRunReport


        /// <summary>
        /// Gets a report download link for a successful Device Advisor qualifying test suite
        /// run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteRunReport service method.</param>
        /// 
        /// <returns>The response from the GetSuiteRunReport service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends Resource Not Found Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRunReport">REST API Reference for GetSuiteRunReport Operation</seealso>
        GetSuiteRunReportResponse GetSuiteRunReport(GetSuiteRunReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSuiteRunReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteRunReport operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSuiteRunReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRunReport">REST API Reference for GetSuiteRunReport Operation</seealso>
        IAsyncResult BeginGetSuiteRunReport(GetSuiteRunReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSuiteRunReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSuiteRunReport.</param>
        /// 
        /// <returns>Returns a  GetSuiteRunReportResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRunReport">REST API Reference for GetSuiteRunReport Operation</seealso>
        GetSuiteRunReportResponse EndGetSuiteRunReport(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSuiteDefinitions


        /// <summary>
        /// Lists the Device Advisor test suites you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuiteDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListSuiteDefinitions service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteDefinitions">REST API Reference for ListSuiteDefinitions Operation</seealso>
        ListSuiteDefinitionsResponse ListSuiteDefinitions(ListSuiteDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSuiteDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSuiteDefinitions operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSuiteDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteDefinitions">REST API Reference for ListSuiteDefinitions Operation</seealso>
        IAsyncResult BeginListSuiteDefinitions(ListSuiteDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSuiteDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSuiteDefinitions.</param>
        /// 
        /// <returns>Returns a  ListSuiteDefinitionsResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteDefinitions">REST API Reference for ListSuiteDefinitions Operation</seealso>
        ListSuiteDefinitionsResponse EndListSuiteDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSuiteRuns


        /// <summary>
        /// Lists the runs of the specified Device Advisor test suite. You can list all runs of
        /// the test suite, or the runs of a specific version of the test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuiteRuns service method.</param>
        /// 
        /// <returns>The response from the ListSuiteRuns service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteRuns">REST API Reference for ListSuiteRuns Operation</seealso>
        ListSuiteRunsResponse ListSuiteRuns(ListSuiteRunsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSuiteRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSuiteRuns operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSuiteRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteRuns">REST API Reference for ListSuiteRuns Operation</seealso>
        IAsyncResult BeginListSuiteRuns(ListSuiteRunsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSuiteRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSuiteRuns.</param>
        /// 
        /// <returns>Returns a  ListSuiteRunsResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteRuns">REST API Reference for ListSuiteRuns Operation</seealso>
        ListSuiteRunsResponse EndListSuiteRuns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags attached to an IoT Device Advisor resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends Resource Not Found Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTestCases


        /// <summary>
        /// Lists all the test cases in the test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestCases service method.</param>
        /// 
        /// <returns>The response from the ListTestCases service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListTestCases">REST API Reference for ListTestCases Operation</seealso>
        ListTestCasesResponse ListTestCases(ListTestCasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTestCases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTestCases operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTestCases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListTestCases">REST API Reference for ListTestCases Operation</seealso>
        IAsyncResult BeginListTestCases(ListTestCasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTestCases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTestCases.</param>
        /// 
        /// <returns>Returns a  ListTestCasesResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListTestCases">REST API Reference for ListTestCases Operation</seealso>
        ListTestCasesResponse EndListTestCases(IAsyncResult asyncResult);

        #endregion
        
        #region  StartSuiteRun


        /// <summary>
        /// Starts a Device Advisor test suite run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSuiteRun service method.</param>
        /// 
        /// <returns>The response from the StartSuiteRun service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ConflictException">
        /// Sends Conflict Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/StartSuiteRun">REST API Reference for StartSuiteRun Operation</seealso>
        StartSuiteRunResponse StartSuiteRun(StartSuiteRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartSuiteRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSuiteRun operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSuiteRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/StartSuiteRun">REST API Reference for StartSuiteRun Operation</seealso>
        IAsyncResult BeginStartSuiteRun(StartSuiteRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSuiteRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSuiteRun.</param>
        /// 
        /// <returns>Returns a  StartSuiteRunResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/StartSuiteRun">REST API Reference for StartSuiteRun Operation</seealso>
        StartSuiteRunResponse EndStartSuiteRun(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds to and modifies existing tags of an IoT Device Advisor resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends Resource Not Found Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from an IoT Device Advisor resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends Resource Not Found Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSuiteDefinition


        /// <summary>
        /// Updates a Device Advisor test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSuiteDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends Internal Failure Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends invalid request exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UpdateSuiteDefinition">REST API Reference for UpdateSuiteDefinition Operation</seealso>
        UpdateSuiteDefinitionResponse UpdateSuiteDefinition(UpdateSuiteDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSuiteDefinition operation on AmazonIoTDeviceAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSuiteDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UpdateSuiteDefinition">REST API Reference for UpdateSuiteDefinition Operation</seealso>
        IAsyncResult BeginUpdateSuiteDefinition(UpdateSuiteDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSuiteDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSuiteDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateSuiteDefinitionResult from IoTDeviceAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UpdateSuiteDefinition">REST API Reference for UpdateSuiteDefinition Operation</seealso>
        UpdateSuiteDefinitionResponse EndUpdateSuiteDefinition(IAsyncResult asyncResult);

        #endregion
        
    }
}