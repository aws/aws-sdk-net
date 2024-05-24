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
 * Do not modify this file. This file is generated from the launch-wizard-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LaunchWizard.Model;

#pragma warning disable CS1570
namespace Amazon.LaunchWizard
{
    /// <summary>
    /// <para>Interface for accessing LaunchWizard</para>
    ///
    /// Launch Wizard offers a guided way of sizing, configuring, and deploying Amazon Web
    /// Services resources for third party applications, such as Microsoft SQL Server Always
    /// On and HANA based SAP systems, without the need to manually identify and provision
    /// individual Amazon Web Services resources.
    /// </summary>
    public partial interface IAmazonLaunchWizard : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILaunchWizardPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateDeployment


        /// <summary>
        /// Creates a deployment for the given workload. Deployments created by this operation
        /// are not available in the Launch Wizard console to use the <c>Clone deployment</c>
        /// action on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceLimitException">
        /// You have exceeded an Launch Wizard resource limit. For example, you might have too
        /// many deployments in progress.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation on AmazonLaunchWizardClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from LaunchWizard.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDeployment


        /// <summary>
        /// Deletes a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// 
        /// <returns>The response from the DeleteDeployment service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment operation on AmazonLaunchWizardClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        IAsyncResult BeginDeleteDeployment(DeleteDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeployment.</param>
        /// 
        /// <returns>Returns a  DeleteDeploymentResult from LaunchWizard.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        DeleteDeploymentResponse EndDeleteDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeployment


        /// <summary>
        /// Returns information about the deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        GetDeploymentResponse GetDeployment(GetDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment operation on AmazonLaunchWizardClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        IAsyncResult BeginGetDeployment(GetDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployment.</param>
        /// 
        /// <returns>Returns a  GetDeploymentResult from LaunchWizard.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        GetDeploymentResponse EndGetDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkload


        /// <summary>
        /// Returns information about a workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkload service method.</param>
        /// 
        /// <returns>The response from the GetWorkload service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/GetWorkload">REST API Reference for GetWorkload Operation</seealso>
        GetWorkloadResponse GetWorkload(GetWorkloadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkload operation on AmazonLaunchWizardClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/GetWorkload">REST API Reference for GetWorkload Operation</seealso>
        IAsyncResult BeginGetWorkload(GetWorkloadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkload.</param>
        /// 
        /// <returns>Returns a  GetWorkloadResult from LaunchWizard.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/GetWorkload">REST API Reference for GetWorkload Operation</seealso>
        GetWorkloadResponse EndGetWorkload(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDeploymentEvents


        /// <summary>
        /// Lists the events of a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentEvents service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentEvents service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListDeploymentEvents">REST API Reference for ListDeploymentEvents Operation</seealso>
        ListDeploymentEventsResponse ListDeploymentEvents(ListDeploymentEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeploymentEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentEvents operation on AmazonLaunchWizardClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeploymentEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListDeploymentEvents">REST API Reference for ListDeploymentEvents Operation</seealso>
        IAsyncResult BeginListDeploymentEvents(ListDeploymentEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeploymentEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeploymentEvents.</param>
        /// 
        /// <returns>Returns a  ListDeploymentEventsResult from LaunchWizard.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListDeploymentEvents">REST API Reference for ListDeploymentEvents Operation</seealso>
        ListDeploymentEventsResponse EndListDeploymentEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDeployments


        /// <summary>
        /// Lists the deployments that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments operation on AmazonLaunchWizardClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        IAsyncResult BeginListDeployments(ListDeploymentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeployments.</param>
        /// 
        /// <returns>Returns a  ListDeploymentsResult from LaunchWizard.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        ListDeploymentsResponse EndListDeployments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkloadDeploymentPatterns


        /// <summary>
        /// Lists the workload deployment patterns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadDeploymentPatterns service method.</param>
        /// 
        /// <returns>The response from the ListWorkloadDeploymentPatterns service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ResourceNotFoundException">
        /// The specified workload or deployment resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListWorkloadDeploymentPatterns">REST API Reference for ListWorkloadDeploymentPatterns Operation</seealso>
        ListWorkloadDeploymentPatternsResponse ListWorkloadDeploymentPatterns(ListWorkloadDeploymentPatternsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkloadDeploymentPatterns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadDeploymentPatterns operation on AmazonLaunchWizardClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkloadDeploymentPatterns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListWorkloadDeploymentPatterns">REST API Reference for ListWorkloadDeploymentPatterns Operation</seealso>
        IAsyncResult BeginListWorkloadDeploymentPatterns(ListWorkloadDeploymentPatternsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkloadDeploymentPatterns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkloadDeploymentPatterns.</param>
        /// 
        /// <returns>Returns a  ListWorkloadDeploymentPatternsResult from LaunchWizard.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListWorkloadDeploymentPatterns">REST API Reference for ListWorkloadDeploymentPatterns Operation</seealso>
        ListWorkloadDeploymentPatternsResponse EndListWorkloadDeploymentPatterns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkloads


        /// <summary>
        /// Lists the workloads.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloads service method.</param>
        /// 
        /// <returns>The response from the ListWorkloads service method, as returned by LaunchWizard.</returns>
        /// <exception cref="Amazon.LaunchWizard.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details by posting a question on <a href="https://repost.aws/">re:Post</a>.
        /// </exception>
        /// <exception cref="Amazon.LaunchWizard.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        ListWorkloadsResponse ListWorkloads(ListWorkloadsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkloads operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloads operation on AmazonLaunchWizardClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkloads
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        IAsyncResult BeginListWorkloads(ListWorkloadsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkloads operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkloads.</param>
        /// 
        /// <returns>Returns a  ListWorkloadsResult from LaunchWizard.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/launch-wizard-2018-05-10/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        ListWorkloadsResponse EndListWorkloads(IAsyncResult asyncResult);

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