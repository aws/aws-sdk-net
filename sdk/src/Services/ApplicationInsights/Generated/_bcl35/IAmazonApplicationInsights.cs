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
    /// Amazon CloudWatch Application Insights for .NET and SQL Server 
    /// <para>
    ///  Amazon CloudWatch Application Insights for .NET and SQL Server is a service that
    /// helps you detect common problems with your .NET and SQL Server-based applications.
    /// It enables you to pinpoint the source of issues in your applications (built with technologies
    /// such as Microsoft IIS, .NET, and Microsoft SQL Server), by providing key insights
    /// into detected problems.
    /// </para>
    ///  
    /// <para>
    /// After you onboard your application, CloudWatch Application Insights for .NET and SQL
    /// Server identifies, recommends, and sets up metrics and logs. It continuously analyzes
    /// and correlates your metrics and logs for unusual behavior to surface actionable problems
    /// with your application. For example, if your application is slow and unresponsive and
    /// leading to HTTP 500 errors in your Application Load Balancer (ALB), Application Insights
    /// informs you that a memory pressure problem with your SQL Server database is occurring.
    /// It bases this analysis on impactful metrics and log errors. 
    /// </para>
    /// </summary>
    public partial interface IAmazonApplicationInsights : IAmazonService, IDisposable
    {

        
        #region  CreateApplication


        /// <summary>
        /// Adds an application that is created from a resource group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ApplicationInsights.</returns>
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
        
    }
}