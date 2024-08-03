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
using System.Threading;
using System.Threading.Tasks;
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAppTestPaginatorFactory Paginators { get; }

        
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
        /// Creates a test case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTestCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateTestCaseResponse> CreateTestCaseAsync(CreateTestCaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a test configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTestConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateTestConfigurationResponse> CreateTestConfigurationAsync(CreateTestConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTestSuite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateTestSuiteResponse> CreateTestSuiteAsync(CreateTestSuiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a test case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteTestCaseResponse> DeleteTestCaseAsync(DeleteTestCaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a test configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteTestConfigurationResponse> DeleteTestConfigurationAsync(DeleteTestConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a test run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteTestRunResponse> DeleteTestRunAsync(DeleteTestRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTestSuite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteTestSuiteResponse> DeleteTestSuiteAsync(DeleteTestSuiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a test case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTestCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetTestCaseResponse> GetTestCaseAsync(GetTestCaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a test configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTestConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetTestConfigurationResponse> GetTestConfigurationAsync(GetTestConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a test run step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTestRunStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetTestRunStepResponse> GetTestRunStepAsync(GetTestRunStepRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTestSuite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetTestSuiteResponse> GetTestSuiteAsync(GetTestSuiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists test cases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestCases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTestCasesResponse> ListTestCasesAsync(ListTestCasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists test configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTestConfigurationsResponse> ListTestConfigurationsAsync(ListTestConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists test runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTestRunsResponse> ListTestRunsAsync(ListTestRunsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists test run steps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestRunSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTestRunStepsResponse> ListTestRunStepsAsync(ListTestRunStepsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists test run test cases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestRunTestCases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTestRunTestCasesResponse> ListTestRunTestCasesAsync(ListTestRunTestCasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists test suites.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestSuites service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTestSuitesResponse> ListTestSuitesAsync(ListTestSuitesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts a test run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTestRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartTestRunResponse> StartTestRunAsync(StartTestRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Specifies tags of a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Untags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a test case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTestCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateTestCaseResponse> UpdateTestCaseAsync(UpdateTestCaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a test configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTestConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateTestConfigurationResponse> UpdateTestConfigurationAsync(UpdateTestConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a test suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTestSuite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateTestSuiteResponse> UpdateTestSuiteAsync(UpdateTestSuiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

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