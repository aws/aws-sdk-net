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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.FIS.Model;

namespace Amazon.FIS
{
    /// <summary>
    /// Interface for accessing FIS
    ///
    /// Fault Injection Simulator is a managed service that enables you to perform fault injection
    /// experiments on your Amazon Web Services workloads. For more information, see the <a
    /// href="https://docs.aws.amazon.com/fis/latest/userguide/">Fault Injection Simulator
    /// User Guide</a>.
    /// </summary>
    public partial interface IAmazonFIS : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IFISPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateExperimentTemplate


        /// <summary>
        /// Creates an experiment template. 
        /// 
        ///  
        /// <para>
        /// An experiment template includes the following components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Targets</b>: A target can be a specific resource in your Amazon Web Services environment,
        /// or one or more resources that match criteria that you specify, for example, resources
        /// that have specific tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Actions</b>: The actions to carry out on the target. You can specify multiple
        /// actions, the duration of each action, and when to start each action during an experiment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Stop conditions</b>: If a stop condition is triggered while an experiment is running,
        /// the experiment is automatically stopped. You can define a stop condition as a CloudWatch
        /// alarm.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fis/latest/userguide/experiment-templates.html">Experiment
        /// templates</a> in the <i>Fault Injection Simulator User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperimentTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ConflictException">
        /// The request could not be processed because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/CreateExperimentTemplate">REST API Reference for CreateExperimentTemplate Operation</seealso>
        CreateExperimentTemplateResponse CreateExperimentTemplate(CreateExperimentTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExperimentTemplate operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExperimentTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/CreateExperimentTemplate">REST API Reference for CreateExperimentTemplate Operation</seealso>
        IAsyncResult BeginCreateExperimentTemplate(CreateExperimentTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExperimentTemplate.</param>
        /// 
        /// <returns>Returns a  CreateExperimentTemplateResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/CreateExperimentTemplate">REST API Reference for CreateExperimentTemplate Operation</seealso>
        CreateExperimentTemplateResponse EndCreateExperimentTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteExperimentTemplate


        /// <summary>
        /// Deletes the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperimentTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/DeleteExperimentTemplate">REST API Reference for DeleteExperimentTemplate Operation</seealso>
        DeleteExperimentTemplateResponse DeleteExperimentTemplate(DeleteExperimentTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperimentTemplate operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExperimentTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/DeleteExperimentTemplate">REST API Reference for DeleteExperimentTemplate Operation</seealso>
        IAsyncResult BeginDeleteExperimentTemplate(DeleteExperimentTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExperimentTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteExperimentTemplateResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/DeleteExperimentTemplate">REST API Reference for DeleteExperimentTemplate Operation</seealso>
        DeleteExperimentTemplateResponse EndDeleteExperimentTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAction


        /// <summary>
        /// Gets information about the specified FIS action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAction service method.</param>
        /// 
        /// <returns>The response from the GetAction service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetAction">REST API Reference for GetAction Operation</seealso>
        GetActionResponse GetAction(GetActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAction operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetAction">REST API Reference for GetAction Operation</seealso>
        IAsyncResult BeginGetAction(GetActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAction.</param>
        /// 
        /// <returns>Returns a  GetActionResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetAction">REST API Reference for GetAction Operation</seealso>
        GetActionResponse EndGetAction(IAsyncResult asyncResult);

        #endregion
        
        #region  GetExperiment


        /// <summary>
        /// Gets information about the specified experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperiment service method.</param>
        /// 
        /// <returns>The response from the GetExperiment service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperiment">REST API Reference for GetExperiment Operation</seealso>
        GetExperimentResponse GetExperiment(GetExperimentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExperiment operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperiment">REST API Reference for GetExperiment Operation</seealso>
        IAsyncResult BeginGetExperiment(GetExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExperiment.</param>
        /// 
        /// <returns>Returns a  GetExperimentResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperiment">REST API Reference for GetExperiment Operation</seealso>
        GetExperimentResponse EndGetExperiment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetExperimentTemplate


        /// <summary>
        /// Gets information about the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentTemplate service method.</param>
        /// 
        /// <returns>The response from the GetExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperimentTemplate">REST API Reference for GetExperimentTemplate Operation</seealso>
        GetExperimentTemplateResponse GetExperimentTemplate(GetExperimentTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentTemplate operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExperimentTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperimentTemplate">REST API Reference for GetExperimentTemplate Operation</seealso>
        IAsyncResult BeginGetExperimentTemplate(GetExperimentTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExperimentTemplate.</param>
        /// 
        /// <returns>Returns a  GetExperimentTemplateResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperimentTemplate">REST API Reference for GetExperimentTemplate Operation</seealso>
        GetExperimentTemplateResponse EndGetExperimentTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTargetResourceType


        /// <summary>
        /// Gets information about the specified resource type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTargetResourceType service method.</param>
        /// 
        /// <returns>The response from the GetTargetResourceType service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetTargetResourceType">REST API Reference for GetTargetResourceType Operation</seealso>
        GetTargetResourceTypeResponse GetTargetResourceType(GetTargetResourceTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTargetResourceType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTargetResourceType operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTargetResourceType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetTargetResourceType">REST API Reference for GetTargetResourceType Operation</seealso>
        IAsyncResult BeginGetTargetResourceType(GetTargetResourceTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTargetResourceType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTargetResourceType.</param>
        /// 
        /// <returns>Returns a  GetTargetResourceTypeResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetTargetResourceType">REST API Reference for GetTargetResourceType Operation</seealso>
        GetTargetResourceTypeResponse EndGetTargetResourceType(IAsyncResult asyncResult);

        #endregion
        
        #region  ListActions


        /// <summary>
        /// Lists the available FIS actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActions service method.</param>
        /// 
        /// <returns>The response from the ListActions service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListActions">REST API Reference for ListActions Operation</seealso>
        ListActionsResponse ListActions(ListActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActions operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListActions">REST API Reference for ListActions Operation</seealso>
        IAsyncResult BeginListActions(ListActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActions.</param>
        /// 
        /// <returns>Returns a  ListActionsResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListActions">REST API Reference for ListActions Operation</seealso>
        ListActionsResponse EndListActions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListExperiments


        /// <summary>
        /// Lists your experiments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperiments service method.</param>
        /// 
        /// <returns>The response from the ListExperiments service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        ListExperimentsResponse ListExperiments(ListExperimentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListExperiments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExperiments operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExperiments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        IAsyncResult BeginListExperiments(ListExperimentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExperiments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExperiments.</param>
        /// 
        /// <returns>Returns a  ListExperimentsResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        ListExperimentsResponse EndListExperiments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListExperimentTemplates


        /// <summary>
        /// Lists your experiment templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentTemplates service method.</param>
        /// 
        /// <returns>The response from the ListExperimentTemplates service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentTemplates">REST API Reference for ListExperimentTemplates Operation</seealso>
        ListExperimentTemplatesResponse ListExperimentTemplates(ListExperimentTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListExperimentTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentTemplates operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExperimentTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentTemplates">REST API Reference for ListExperimentTemplates Operation</seealso>
        IAsyncResult BeginListExperimentTemplates(ListExperimentTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExperimentTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExperimentTemplates.</param>
        /// 
        /// <returns>Returns a  ListExperimentTemplatesResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentTemplates">REST API Reference for ListExperimentTemplates Operation</seealso>
        ListExperimentTemplatesResponse EndListExperimentTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTargetResourceTypes


        /// <summary>
        /// Lists the target resource types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetResourceTypes service method.</param>
        /// 
        /// <returns>The response from the ListTargetResourceTypes service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTargetResourceTypes">REST API Reference for ListTargetResourceTypes Operation</seealso>
        ListTargetResourceTypesResponse ListTargetResourceTypes(ListTargetResourceTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTargetResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargetResourceTypes operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTargetResourceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTargetResourceTypes">REST API Reference for ListTargetResourceTypes Operation</seealso>
        IAsyncResult BeginListTargetResourceTypes(ListTargetResourceTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargetResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargetResourceTypes.</param>
        /// 
        /// <returns>Returns a  ListTargetResourceTypesResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTargetResourceTypes">REST API Reference for ListTargetResourceTypes Operation</seealso>
        ListTargetResourceTypesResponse EndListTargetResourceTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  StartExperiment


        /// <summary>
        /// Starts running an experiment from the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExperiment service method.</param>
        /// 
        /// <returns>The response from the StartExperiment service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ConflictException">
        /// The request could not be processed because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StartExperiment">REST API Reference for StartExperiment Operation</seealso>
        StartExperimentResponse StartExperiment(StartExperimentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartExperiment operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StartExperiment">REST API Reference for StartExperiment Operation</seealso>
        IAsyncResult BeginStartExperiment(StartExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartExperiment.</param>
        /// 
        /// <returns>Returns a  StartExperimentResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StartExperiment">REST API Reference for StartExperiment Operation</seealso>
        StartExperimentResponse EndStartExperiment(IAsyncResult asyncResult);

        #endregion
        
        #region  StopExperiment


        /// <summary>
        /// Stops the specified experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopExperiment service method.</param>
        /// 
        /// <returns>The response from the StopExperiment service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StopExperiment">REST API Reference for StopExperiment Operation</seealso>
        StopExperimentResponse StopExperiment(StopExperimentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopExperiment operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StopExperiment">REST API Reference for StopExperiment Operation</seealso>
        IAsyncResult BeginStopExperiment(StopExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopExperiment.</param>
        /// 
        /// <returns>Returns a  StopExperimentResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StopExperiment">REST API Reference for StopExperiment Operation</seealso>
        StopExperimentResponse EndStopExperiment(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Applies the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateExperimentTemplate


        /// <summary>
        /// Updates the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperimentTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateExperimentTemplate">REST API Reference for UpdateExperimentTemplate Operation</seealso>
        UpdateExperimentTemplateResponse UpdateExperimentTemplate(UpdateExperimentTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperimentTemplate operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateExperimentTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateExperimentTemplate">REST API Reference for UpdateExperimentTemplate Operation</seealso>
        IAsyncResult BeginUpdateExperimentTemplate(UpdateExperimentTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateExperimentTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateExperimentTemplateResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateExperimentTemplate">REST API Reference for UpdateExperimentTemplate Operation</seealso>
        UpdateExperimentTemplateResponse EndUpdateExperimentTemplate(IAsyncResult asyncResult);

        #endregion
        
    }
}