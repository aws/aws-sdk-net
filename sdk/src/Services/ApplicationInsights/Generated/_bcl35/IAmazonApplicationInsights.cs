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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ApplicationInsights.Model;

namespace Amazon.ApplicationInsights
{
    /// <summary>
    /// Interface for accessing ApplicationInsights
    ///
    /// Amazon CloudWatch Application Insights 
    /// <para>
    ///  Amazon CloudWatch Application Insights is a service that helps you detect common
    /// problems with your applications. It enables you to pinpoint the source of issues in
    /// your applications (built with technologies such as Microsoft IIS, .NET, and Microsoft
    /// SQL Server), by providing key insights into detected problems.
    /// </para>
    ///  
    /// <para>
    /// After you onboard your application, CloudWatch Application Insights identifies, recommends,
    /// and sets up metrics and logs. It continuously analyzes and correlates your metrics
    /// and logs for unusual behavior to surface actionable problems with your application.
    /// For example, if your application is slow and unresponsive and leading to HTTP 500
    /// errors in your Application Load Balancer (ALB), Application Insights informs you that
    /// a memory pressure problem with your SQL Server database is occurring. It bases this
    /// analysis on impactful metrics and log errors. 
    /// </para>
    /// </summary>
    public partial interface IAmazonApplicationInsights : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IApplicationInsightsPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateApplication


        /// <summary>
        /// Adds an application that is created from a resource group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.AccessDeniedException">
        /// User does not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.TagsAlreadyExistException">
        /// Tags are already registered for the specified application ARN.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateComponent


        /// <summary>
        /// Creates a custom component by grouping similar standalone instances to monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent service method.</param>
        /// 
        /// <returns>The response from the CreateComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        CreateComponentResponse CreateComponent(CreateComponentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        IAsyncResult BeginCreateComponent(CreateComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateComponent.</param>
        /// 
        /// <returns>Returns a  CreateComponentResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        CreateComponentResponse EndCreateComponent(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLogPattern


        /// <summary>
        /// Adds an log pattern to a <code>LogPatternSet</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLogPattern service method.</param>
        /// 
        /// <returns>The response from the CreateLogPattern service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateLogPattern">REST API Reference for CreateLogPattern Operation</seealso>
        CreateLogPatternResponse CreateLogPattern(CreateLogPatternRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLogPattern operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLogPattern operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLogPattern
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateLogPattern">REST API Reference for CreateLogPattern Operation</seealso>
        IAsyncResult BeginCreateLogPattern(CreateLogPatternRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLogPattern operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLogPattern.</param>
        /// 
        /// <returns>Returns a  CreateLogPatternResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateLogPattern">REST API Reference for CreateLogPattern Operation</seealso>
        CreateLogPatternResponse EndCreateLogPattern(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Removes the specified application from monitoring. Does not delete the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.BadRequestException">
        /// The request is not understood by the server.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteComponent


        /// <summary>
        /// Ungroups a custom component. When you ungroup custom components, all applicable monitors
        /// that are set up for the component are removed and the instances revert to their standalone
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent service method.</param>
        /// 
        /// <returns>The response from the DeleteComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        DeleteComponentResponse DeleteComponent(DeleteComponentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        IAsyncResult BeginDeleteComponent(DeleteComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteComponent.</param>
        /// 
        /// <returns>Returns a  DeleteComponentResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        DeleteComponentResponse EndDeleteComponent(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLogPattern


        /// <summary>
        /// Removes the specified log pattern from a <code>LogPatternSet</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogPattern service method.</param>
        /// 
        /// <returns>The response from the DeleteLogPattern service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.BadRequestException">
        /// The request is not understood by the server.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteLogPattern">REST API Reference for DeleteLogPattern Operation</seealso>
        DeleteLogPatternResponse DeleteLogPattern(DeleteLogPatternRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLogPattern operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogPattern operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLogPattern
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteLogPattern">REST API Reference for DeleteLogPattern Operation</seealso>
        IAsyncResult BeginDeleteLogPattern(DeleteLogPatternRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLogPattern operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLogPattern.</param>
        /// 
        /// <returns>Returns a  DeleteLogPatternResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteLogPattern">REST API Reference for DeleteLogPattern Operation</seealso>
        DeleteLogPatternResponse EndDeleteLogPattern(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApplication


        /// <summary>
        /// Describes the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication service method.</param>
        /// 
        /// <returns>The response from the DescribeApplication service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        IAsyncResult BeginDescribeApplication(DescribeApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplication.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        DescribeApplicationResponse EndDescribeApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeComponent


        /// <summary>
        /// Describes a component and lists the resources that are grouped together in a component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponent service method.</param>
        /// 
        /// <returns>The response from the DescribeComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        DescribeComponentResponse DescribeComponent(DescribeComponentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponent operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        IAsyncResult BeginDescribeComponent(DescribeComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComponent.</param>
        /// 
        /// <returns>Returns a  DescribeComponentResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        DescribeComponentResponse EndDescribeComponent(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeComponentConfiguration


        /// <summary>
        /// Describes the monitoring configuration of the component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponentConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeComponentConfiguration service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfiguration">REST API Reference for DescribeComponentConfiguration Operation</seealso>
        DescribeComponentConfigurationResponse DescribeComponentConfiguration(DescribeComponentConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComponentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponentConfiguration operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComponentConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfiguration">REST API Reference for DescribeComponentConfiguration Operation</seealso>
        IAsyncResult BeginDescribeComponentConfiguration(DescribeComponentConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComponentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComponentConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeComponentConfigurationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfiguration">REST API Reference for DescribeComponentConfiguration Operation</seealso>
        DescribeComponentConfigurationResponse EndDescribeComponentConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeComponentConfigurationRecommendation


        /// <summary>
        /// Describes the recommended monitoring configuration of the component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponentConfigurationRecommendation service method.</param>
        /// 
        /// <returns>The response from the DescribeComponentConfigurationRecommendation service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfigurationRecommendation">REST API Reference for DescribeComponentConfigurationRecommendation Operation</seealso>
        DescribeComponentConfigurationRecommendationResponse DescribeComponentConfigurationRecommendation(DescribeComponentConfigurationRecommendationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComponentConfigurationRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponentConfigurationRecommendation operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComponentConfigurationRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfigurationRecommendation">REST API Reference for DescribeComponentConfigurationRecommendation Operation</seealso>
        IAsyncResult BeginDescribeComponentConfigurationRecommendation(DescribeComponentConfigurationRecommendationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComponentConfigurationRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComponentConfigurationRecommendation.</param>
        /// 
        /// <returns>Returns a  DescribeComponentConfigurationRecommendationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfigurationRecommendation">REST API Reference for DescribeComponentConfigurationRecommendation Operation</seealso>
        DescribeComponentConfigurationRecommendationResponse EndDescribeComponentConfigurationRecommendation(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLogPattern


        /// <summary>
        /// Describe a specific log pattern from a <code>LogPatternSet</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogPattern service method.</param>
        /// 
        /// <returns>The response from the DescribeLogPattern service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeLogPattern">REST API Reference for DescribeLogPattern Operation</seealso>
        DescribeLogPatternResponse DescribeLogPattern(DescribeLogPatternRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLogPattern operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogPattern operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLogPattern
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeLogPattern">REST API Reference for DescribeLogPattern Operation</seealso>
        IAsyncResult BeginDescribeLogPattern(DescribeLogPatternRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLogPattern operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLogPattern.</param>
        /// 
        /// <returns>Returns a  DescribeLogPatternResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeLogPattern">REST API Reference for DescribeLogPattern Operation</seealso>
        DescribeLogPatternResponse EndDescribeLogPattern(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeObservation


        /// <summary>
        /// Describes an anomaly or error with the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeObservation service method.</param>
        /// 
        /// <returns>The response from the DescribeObservation service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeObservation">REST API Reference for DescribeObservation Operation</seealso>
        DescribeObservationResponse DescribeObservation(DescribeObservationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeObservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeObservation operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeObservation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeObservation">REST API Reference for DescribeObservation Operation</seealso>
        IAsyncResult BeginDescribeObservation(DescribeObservationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeObservation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeObservation.</param>
        /// 
        /// <returns>Returns a  DescribeObservationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeObservation">REST API Reference for DescribeObservation Operation</seealso>
        DescribeObservationResponse EndDescribeObservation(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProblem


        /// <summary>
        /// Describes an application problem.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProblem service method.</param>
        /// 
        /// <returns>The response from the DescribeProblem service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblem">REST API Reference for DescribeProblem Operation</seealso>
        DescribeProblemResponse DescribeProblem(DescribeProblemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProblem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProblem operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProblem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblem">REST API Reference for DescribeProblem Operation</seealso>
        IAsyncResult BeginDescribeProblem(DescribeProblemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProblem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProblem.</param>
        /// 
        /// <returns>Returns a  DescribeProblemResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblem">REST API Reference for DescribeProblem Operation</seealso>
        DescribeProblemResponse EndDescribeProblem(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProblemObservations


        /// <summary>
        /// Describes the anomalies or errors associated with the problem.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProblemObservations service method.</param>
        /// 
        /// <returns>The response from the DescribeProblemObservations service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblemObservations">REST API Reference for DescribeProblemObservations Operation</seealso>
        DescribeProblemObservationsResponse DescribeProblemObservations(DescribeProblemObservationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProblemObservations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProblemObservations operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProblemObservations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblemObservations">REST API Reference for DescribeProblemObservations Operation</seealso>
        IAsyncResult BeginDescribeProblemObservations(DescribeProblemObservationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProblemObservations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProblemObservations.</param>
        /// 
        /// <returns>Returns a  DescribeProblemObservationsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblemObservations">REST API Reference for DescribeProblemObservations Operation</seealso>
        DescribeProblemObservationsResponse EndDescribeProblemObservations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Lists the IDs of the applications that you are monitoring.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListApplications">REST API Reference for ListApplications Operation</seealso>
        IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse EndListApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListComponents


        /// <summary>
        /// Lists the auto-grouped, standalone, and custom components of the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListComponents">REST API Reference for ListComponents Operation</seealso>
        ListComponentsResponse ListComponents(ListComponentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponents operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListComponents">REST API Reference for ListComponents Operation</seealso>
        IAsyncResult BeginListComponents(ListComponentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComponents.</param>
        /// 
        /// <returns>Returns a  ListComponentsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListComponents">REST API Reference for ListComponents Operation</seealso>
        ListComponentsResponse EndListComponents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConfigurationHistory


        /// <summary>
        /// Lists the INFO, WARN, and ERROR events for periodic configuration updates performed
        /// by Application Insights. Examples of events represented are: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// INFO: creating a new alarm or updating an alarm threshold.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WARN: alarm not created due to insufficient data points used to predict thresholds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ERROR: alarm not created due to permission errors or exceeding quotas. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationHistory service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationHistory service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListConfigurationHistory">REST API Reference for ListConfigurationHistory Operation</seealso>
        ListConfigurationHistoryResponse ListConfigurationHistory(ListConfigurationHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationHistory operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListConfigurationHistory">REST API Reference for ListConfigurationHistory Operation</seealso>
        IAsyncResult BeginListConfigurationHistory(ListConfigurationHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationHistory.</param>
        /// 
        /// <returns>Returns a  ListConfigurationHistoryResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListConfigurationHistory">REST API Reference for ListConfigurationHistory Operation</seealso>
        ListConfigurationHistoryResponse EndListConfigurationHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLogPatterns


        /// <summary>
        /// Lists the log patterns in the specific log <code>LogPatternSet</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogPatterns service method.</param>
        /// 
        /// <returns>The response from the ListLogPatterns service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListLogPatterns">REST API Reference for ListLogPatterns Operation</seealso>
        ListLogPatternsResponse ListLogPatterns(ListLogPatternsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLogPatterns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLogPatterns operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLogPatterns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListLogPatterns">REST API Reference for ListLogPatterns Operation</seealso>
        IAsyncResult BeginListLogPatterns(ListLogPatternsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLogPatterns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLogPatterns.</param>
        /// 
        /// <returns>Returns a  ListLogPatternsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListLogPatterns">REST API Reference for ListLogPatterns Operation</seealso>
        ListLogPatternsResponse EndListLogPatterns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLogPatternSets


        /// <summary>
        /// Lists the log pattern sets in the specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogPatternSets service method.</param>
        /// 
        /// <returns>The response from the ListLogPatternSets service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListLogPatternSets">REST API Reference for ListLogPatternSets Operation</seealso>
        ListLogPatternSetsResponse ListLogPatternSets(ListLogPatternSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLogPatternSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLogPatternSets operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLogPatternSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListLogPatternSets">REST API Reference for ListLogPatternSets Operation</seealso>
        IAsyncResult BeginListLogPatternSets(ListLogPatternSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLogPatternSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLogPatternSets.</param>
        /// 
        /// <returns>Returns a  ListLogPatternSetsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListLogPatternSets">REST API Reference for ListLogPatternSets Operation</seealso>
        ListLogPatternSetsResponse EndListLogPatternSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProblems


        /// <summary>
        /// Lists the problems with your application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProblems service method.</param>
        /// 
        /// <returns>The response from the ListProblems service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListProblems">REST API Reference for ListProblems Operation</seealso>
        ListProblemsResponse ListProblems(ListProblemsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProblems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProblems operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProblems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListProblems">REST API Reference for ListProblems Operation</seealso>
        IAsyncResult BeginListProblems(ListProblemsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProblems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProblems.</param>
        /// 
        /// <returns>Returns a  ListProblemsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListProblems">REST API Reference for ListProblems Operation</seealso>
        ListProblemsResponse EndListProblems(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieve a list of the tags (keys and values) that are associated with a specified
        /// application. A <i>tag</i> is a label that you optionally define and associate with
        /// an application. Each tag consists of a required <i>tag key</i> and an optional associated
        /// <i>tag value</i>. A tag key is a general label that acts as a category for more specific
        /// tag values. A tag value acts as a descriptor within a tag key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add one or more tags (keys and values) to a specified application. A <i>tag</i> is
        /// a label that you optionally define and associate with an application. Tags can help
        /// you categorize and manage application in different ways, such as by purpose, owner,
        /// environment, or other criteria. 
        /// 
        ///  
        /// <para>
        /// Each tag consists of a required <i>tag key</i> and an associated <i>tag value</i>,
        /// both of which you define. A tag key is a general label that acts as a category for
        /// more specific tag values. A tag value acts as a descriptor within a tag key.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.TooManyTagsException">
        /// The number of the provided tags is beyond the limit, or the number of total tags you
        /// are trying to attach to the specified resource exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove one or more tags (keys and values) from a specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateComponent


        /// <summary>
        /// Updates the custom component name and/or the list of resources that make up the component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponent service method.</param>
        /// 
        /// <returns>The response from the UpdateComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        UpdateComponentResponse UpdateComponent(UpdateComponentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponent operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        IAsyncResult BeginUpdateComponent(UpdateComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateComponent.</param>
        /// 
        /// <returns>Returns a  UpdateComponentResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        UpdateComponentResponse EndUpdateComponent(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateComponentConfiguration


        /// <summary>
        /// Updates the monitoring configurations for the component. The configuration input parameter
        /// is an escaped JSON of the configuration and should match the schema of what is returned
        /// by <code>DescribeComponentConfigurationRecommendation</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponentConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateComponentConfiguration service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponentConfiguration">REST API Reference for UpdateComponentConfiguration Operation</seealso>
        UpdateComponentConfigurationResponse UpdateComponentConfiguration(UpdateComponentConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComponentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponentConfiguration operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateComponentConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponentConfiguration">REST API Reference for UpdateComponentConfiguration Operation</seealso>
        IAsyncResult BeginUpdateComponentConfiguration(UpdateComponentConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateComponentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateComponentConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateComponentConfigurationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponentConfiguration">REST API Reference for UpdateComponentConfiguration Operation</seealso>
        UpdateComponentConfigurationResponse EndUpdateComponentConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLogPattern


        /// <summary>
        /// Adds a log pattern to a <code>LogPatternSet</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLogPattern service method.</param>
        /// 
        /// <returns>The response from the UpdateLogPattern service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateLogPattern">REST API Reference for UpdateLogPattern Operation</seealso>
        UpdateLogPatternResponse UpdateLogPattern(UpdateLogPatternRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLogPattern operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLogPattern operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLogPattern
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateLogPattern">REST API Reference for UpdateLogPattern Operation</seealso>
        IAsyncResult BeginUpdateLogPattern(UpdateLogPatternRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLogPattern operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLogPattern.</param>
        /// 
        /// <returns>Returns a  UpdateLogPatternResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateLogPattern">REST API Reference for UpdateLogPattern Operation</seealso>
        UpdateLogPatternResponse EndUpdateLogPattern(IAsyncResult asyncResult);

        #endregion
        
    }
}