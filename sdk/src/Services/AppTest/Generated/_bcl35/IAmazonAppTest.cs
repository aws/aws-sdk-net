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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AppTest.Model;

#pragma warning disable CS1570
namespace Amazon.AppTest
{
    /// <summary>
    /// <para>Interface for accessing AppTest</para>
    ///
    /// AWS Mainframe Modernization Application Testing provides tools and resources for automated
    /// functional equivalence testing for your migration projects.
    /// </summary>
    public partial interface IAmazonAppTest : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAppTestPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateTestCase


        /// <summary>
        /// Creates a test case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTestCase service method.</param>
        /// 
        /// <returns>The response from the CreateTestCase service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ServiceQuotaExceededException">
        /// One or more quotas for AWS Application Testing exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/CreateTestCase">REST API Reference for CreateTestCase Operation</seealso>
        CreateTestCaseResponse CreateTestCase(CreateTestCaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTestCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTestCase operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTestCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/CreateTestCase">REST API Reference for CreateTestCase Operation</seealso>
        IAsyncResult BeginCreateTestCase(CreateTestCaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTestCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTestCase.</param>
        /// 
        /// <returns>Returns a  CreateTestCaseResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/CreateTestCase">REST API Reference for CreateTestCase Operation</seealso>
        CreateTestCaseResponse EndCreateTestCase(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTestConfiguration


        /// <summary>
        /// Creates a test configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTestConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateTestConfiguration service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ServiceQuotaExceededException">
        /// One or more quotas for AWS Application Testing exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/CreateTestConfiguration">REST API Reference for CreateTestConfiguration Operation</seealso>
        CreateTestConfigurationResponse CreateTestConfiguration(CreateTestConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTestConfiguration operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTestConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/CreateTestConfiguration">REST API Reference for CreateTestConfiguration Operation</seealso>
        IAsyncResult BeginCreateTestConfiguration(CreateTestConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTestConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateTestConfigurationResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/CreateTestConfiguration">REST API Reference for CreateTestConfiguration Operation</seealso>
        CreateTestConfigurationResponse EndCreateTestConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTestSuite


        /// <summary>
        /// Creates a test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTestSuite service method.</param>
        /// 
        /// <returns>The response from the CreateTestSuite service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ServiceQuotaExceededException">
        /// One or more quotas for AWS Application Testing exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/CreateTestSuite">REST API Reference for CreateTestSuite Operation</seealso>
        CreateTestSuiteResponse CreateTestSuite(CreateTestSuiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTestSuite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTestSuite operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTestSuite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/CreateTestSuite">REST API Reference for CreateTestSuite Operation</seealso>
        IAsyncResult BeginCreateTestSuite(CreateTestSuiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTestSuite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTestSuite.</param>
        /// 
        /// <returns>Returns a  CreateTestSuiteResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/CreateTestSuite">REST API Reference for CreateTestSuite Operation</seealso>
        CreateTestSuiteResponse EndCreateTestSuite(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTestCase


        /// <summary>
        /// Deletes a test case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestCase service method.</param>
        /// 
        /// <returns>The response from the DeleteTestCase service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestCase">REST API Reference for DeleteTestCase Operation</seealso>
        DeleteTestCaseResponse DeleteTestCase(DeleteTestCaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTestCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestCase operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTestCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestCase">REST API Reference for DeleteTestCase Operation</seealso>
        IAsyncResult BeginDeleteTestCase(DeleteTestCaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTestCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTestCase.</param>
        /// 
        /// <returns>Returns a  DeleteTestCaseResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestCase">REST API Reference for DeleteTestCase Operation</seealso>
        DeleteTestCaseResponse EndDeleteTestCase(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTestConfiguration


        /// <summary>
        /// Deletes a test configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteTestConfiguration service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ServiceQuotaExceededException">
        /// One or more quotas for AWS Application Testing exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestConfiguration">REST API Reference for DeleteTestConfiguration Operation</seealso>
        DeleteTestConfigurationResponse DeleteTestConfiguration(DeleteTestConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestConfiguration operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTestConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestConfiguration">REST API Reference for DeleteTestConfiguration Operation</seealso>
        IAsyncResult BeginDeleteTestConfiguration(DeleteTestConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTestConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteTestConfigurationResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestConfiguration">REST API Reference for DeleteTestConfiguration Operation</seealso>
        DeleteTestConfigurationResponse EndDeleteTestConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTestRun


        /// <summary>
        /// Deletes a test run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestRun service method.</param>
        /// 
        /// <returns>The response from the DeleteTestRun service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestRun">REST API Reference for DeleteTestRun Operation</seealso>
        DeleteTestRunResponse DeleteTestRun(DeleteTestRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTestRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestRun operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTestRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestRun">REST API Reference for DeleteTestRun Operation</seealso>
        IAsyncResult BeginDeleteTestRun(DeleteTestRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTestRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTestRun.</param>
        /// 
        /// <returns>Returns a  DeleteTestRunResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestRun">REST API Reference for DeleteTestRun Operation</seealso>
        DeleteTestRunResponse EndDeleteTestRun(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTestSuite


        /// <summary>
        /// Deletes a test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestSuite service method.</param>
        /// 
        /// <returns>The response from the DeleteTestSuite service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ServiceQuotaExceededException">
        /// One or more quotas for AWS Application Testing exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestSuite">REST API Reference for DeleteTestSuite Operation</seealso>
        DeleteTestSuiteResponse DeleteTestSuite(DeleteTestSuiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTestSuite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestSuite operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTestSuite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestSuite">REST API Reference for DeleteTestSuite Operation</seealso>
        IAsyncResult BeginDeleteTestSuite(DeleteTestSuiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTestSuite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTestSuite.</param>
        /// 
        /// <returns>Returns a  DeleteTestSuiteResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/DeleteTestSuite">REST API Reference for DeleteTestSuite Operation</seealso>
        DeleteTestSuiteResponse EndDeleteTestSuite(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTestCase


        /// <summary>
        /// Gets a test case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTestCase service method.</param>
        /// 
        /// <returns>The response from the GetTestCase service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestCase">REST API Reference for GetTestCase Operation</seealso>
        GetTestCaseResponse GetTestCase(GetTestCaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTestCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTestCase operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTestCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestCase">REST API Reference for GetTestCase Operation</seealso>
        IAsyncResult BeginGetTestCase(GetTestCaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTestCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTestCase.</param>
        /// 
        /// <returns>Returns a  GetTestCaseResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestCase">REST API Reference for GetTestCase Operation</seealso>
        GetTestCaseResponse EndGetTestCase(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTestConfiguration


        /// <summary>
        /// Gets a test configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTestConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetTestConfiguration service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestConfiguration">REST API Reference for GetTestConfiguration Operation</seealso>
        GetTestConfigurationResponse GetTestConfiguration(GetTestConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTestConfiguration operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTestConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestConfiguration">REST API Reference for GetTestConfiguration Operation</seealso>
        IAsyncResult BeginGetTestConfiguration(GetTestConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTestConfiguration.</param>
        /// 
        /// <returns>Returns a  GetTestConfigurationResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestConfiguration">REST API Reference for GetTestConfiguration Operation</seealso>
        GetTestConfigurationResponse EndGetTestConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTestRunStep


        /// <summary>
        /// Gets a test run step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTestRunStep service method.</param>
        /// 
        /// <returns>The response from the GetTestRunStep service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestRunStep">REST API Reference for GetTestRunStep Operation</seealso>
        GetTestRunStepResponse GetTestRunStep(GetTestRunStepRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTestRunStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTestRunStep operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTestRunStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestRunStep">REST API Reference for GetTestRunStep Operation</seealso>
        IAsyncResult BeginGetTestRunStep(GetTestRunStepRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTestRunStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTestRunStep.</param>
        /// 
        /// <returns>Returns a  GetTestRunStepResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestRunStep">REST API Reference for GetTestRunStep Operation</seealso>
        GetTestRunStepResponse EndGetTestRunStep(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTestSuite


        /// <summary>
        /// Gets a test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTestSuite service method.</param>
        /// 
        /// <returns>The response from the GetTestSuite service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestSuite">REST API Reference for GetTestSuite Operation</seealso>
        GetTestSuiteResponse GetTestSuite(GetTestSuiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTestSuite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTestSuite operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTestSuite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestSuite">REST API Reference for GetTestSuite Operation</seealso>
        IAsyncResult BeginGetTestSuite(GetTestSuiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTestSuite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTestSuite.</param>
        /// 
        /// <returns>Returns a  GetTestSuiteResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/GetTestSuite">REST API Reference for GetTestSuite Operation</seealso>
        GetTestSuiteResponse EndGetTestSuite(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTestCases


        /// <summary>
        /// Lists test cases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestCases service method.</param>
        /// 
        /// <returns>The response from the ListTestCases service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestCases">REST API Reference for ListTestCases Operation</seealso>
        ListTestCasesResponse ListTestCases(ListTestCasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTestCases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTestCases operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTestCases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestCases">REST API Reference for ListTestCases Operation</seealso>
        IAsyncResult BeginListTestCases(ListTestCasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTestCases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTestCases.</param>
        /// 
        /// <returns>Returns a  ListTestCasesResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestCases">REST API Reference for ListTestCases Operation</seealso>
        ListTestCasesResponse EndListTestCases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTestConfigurations


        /// <summary>
        /// Lists test configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListTestConfigurations service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestConfigurations">REST API Reference for ListTestConfigurations Operation</seealso>
        ListTestConfigurationsResponse ListTestConfigurations(ListTestConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTestConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTestConfigurations operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTestConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestConfigurations">REST API Reference for ListTestConfigurations Operation</seealso>
        IAsyncResult BeginListTestConfigurations(ListTestConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTestConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTestConfigurations.</param>
        /// 
        /// <returns>Returns a  ListTestConfigurationsResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestConfigurations">REST API Reference for ListTestConfigurations Operation</seealso>
        ListTestConfigurationsResponse EndListTestConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTestRuns


        /// <summary>
        /// Lists test runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestRuns service method.</param>
        /// 
        /// <returns>The response from the ListTestRuns service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestRuns">REST API Reference for ListTestRuns Operation</seealso>
        ListTestRunsResponse ListTestRuns(ListTestRunsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTestRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTestRuns operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTestRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestRuns">REST API Reference for ListTestRuns Operation</seealso>
        IAsyncResult BeginListTestRuns(ListTestRunsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTestRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTestRuns.</param>
        /// 
        /// <returns>Returns a  ListTestRunsResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestRuns">REST API Reference for ListTestRuns Operation</seealso>
        ListTestRunsResponse EndListTestRuns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTestRunSteps


        /// <summary>
        /// Lists test run steps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestRunSteps service method.</param>
        /// 
        /// <returns>The response from the ListTestRunSteps service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestRunSteps">REST API Reference for ListTestRunSteps Operation</seealso>
        ListTestRunStepsResponse ListTestRunSteps(ListTestRunStepsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTestRunSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTestRunSteps operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTestRunSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestRunSteps">REST API Reference for ListTestRunSteps Operation</seealso>
        IAsyncResult BeginListTestRunSteps(ListTestRunStepsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTestRunSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTestRunSteps.</param>
        /// 
        /// <returns>Returns a  ListTestRunStepsResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestRunSteps">REST API Reference for ListTestRunSteps Operation</seealso>
        ListTestRunStepsResponse EndListTestRunSteps(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTestRunTestCases


        /// <summary>
        /// Lists test run test cases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestRunTestCases service method.</param>
        /// 
        /// <returns>The response from the ListTestRunTestCases service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestRunTestCases">REST API Reference for ListTestRunTestCases Operation</seealso>
        ListTestRunTestCasesResponse ListTestRunTestCases(ListTestRunTestCasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTestRunTestCases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTestRunTestCases operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTestRunTestCases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestRunTestCases">REST API Reference for ListTestRunTestCases Operation</seealso>
        IAsyncResult BeginListTestRunTestCases(ListTestRunTestCasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTestRunTestCases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTestRunTestCases.</param>
        /// 
        /// <returns>Returns a  ListTestRunTestCasesResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestRunTestCases">REST API Reference for ListTestRunTestCases Operation</seealso>
        ListTestRunTestCasesResponse EndListTestRunTestCases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTestSuites


        /// <summary>
        /// Lists test suites.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestSuites service method.</param>
        /// 
        /// <returns>The response from the ListTestSuites service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestSuites">REST API Reference for ListTestSuites Operation</seealso>
        ListTestSuitesResponse ListTestSuites(ListTestSuitesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTestSuites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTestSuites operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTestSuites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestSuites">REST API Reference for ListTestSuites Operation</seealso>
        IAsyncResult BeginListTestSuites(ListTestSuitesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTestSuites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTestSuites.</param>
        /// 
        /// <returns>Returns a  ListTestSuitesResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/ListTestSuites">REST API Reference for ListTestSuites Operation</seealso>
        ListTestSuitesResponse EndListTestSuites(IAsyncResult asyncResult);

        #endregion
        
        #region  StartTestRun


        /// <summary>
        /// Starts a test run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTestRun service method.</param>
        /// 
        /// <returns>The response from the StartTestRun service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ServiceQuotaExceededException">
        /// One or more quotas for AWS Application Testing exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/StartTestRun">REST API Reference for StartTestRun Operation</seealso>
        StartTestRunResponse StartTestRun(StartTestRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartTestRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTestRun operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTestRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/StartTestRun">REST API Reference for StartTestRun Operation</seealso>
        IAsyncResult BeginStartTestRun(StartTestRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartTestRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTestRun.</param>
        /// 
        /// <returns>Returns a  StartTestRunResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/StartTestRun">REST API Reference for StartTestRun Operation</seealso>
        StartTestRunResponse EndStartTestRun(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Specifies tags of a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ServiceQuotaExceededException">
        /// One or more quotas for AWS Application Testing exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTestCase


        /// <summary>
        /// Updates a test case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTestCase service method.</param>
        /// 
        /// <returns>The response from the UpdateTestCase service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UpdateTestCase">REST API Reference for UpdateTestCase Operation</seealso>
        UpdateTestCaseResponse UpdateTestCase(UpdateTestCaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTestCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTestCase operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTestCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UpdateTestCase">REST API Reference for UpdateTestCase Operation</seealso>
        IAsyncResult BeginUpdateTestCase(UpdateTestCaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTestCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTestCase.</param>
        /// 
        /// <returns>Returns a  UpdateTestCaseResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UpdateTestCase">REST API Reference for UpdateTestCase Operation</seealso>
        UpdateTestCaseResponse EndUpdateTestCase(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTestConfiguration


        /// <summary>
        /// Updates a test configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTestConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateTestConfiguration service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UpdateTestConfiguration">REST API Reference for UpdateTestConfiguration Operation</seealso>
        UpdateTestConfigurationResponse UpdateTestConfiguration(UpdateTestConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTestConfiguration operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTestConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UpdateTestConfiguration">REST API Reference for UpdateTestConfiguration Operation</seealso>
        IAsyncResult BeginUpdateTestConfiguration(UpdateTestConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTestConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateTestConfigurationResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UpdateTestConfiguration">REST API Reference for UpdateTestConfiguration Operation</seealso>
        UpdateTestConfigurationResponse EndUpdateTestConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTestSuite


        /// <summary>
        /// Updates a test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTestSuite service method.</param>
        /// 
        /// <returns>The response from the UpdateTestSuite service method, as returned by AppTest.</returns>
        /// <exception cref="Amazon.AppTest.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppTest.Model.ValidationException">
        /// One or more parameter provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UpdateTestSuite">REST API Reference for UpdateTestSuite Operation</seealso>
        UpdateTestSuiteResponse UpdateTestSuite(UpdateTestSuiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTestSuite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTestSuite operation on AmazonAppTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTestSuite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UpdateTestSuite">REST API Reference for UpdateTestSuite Operation</seealso>
        IAsyncResult BeginUpdateTestSuite(UpdateTestSuiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTestSuite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTestSuite.</param>
        /// 
        /// <returns>Returns a  UpdateTestSuiteResult from AppTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apptest-2022-12-06/UpdateTestSuite">REST API Reference for UpdateTestSuite Operation</seealso>
        UpdateTestSuiteResponse EndUpdateTestSuite(IAsyncResult asyncResult);

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