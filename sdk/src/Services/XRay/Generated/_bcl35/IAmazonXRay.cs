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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.XRay.Model;

namespace Amazon.XRay
{
    /// <summary>
    /// Interface for accessing XRay
    ///
    /// AWS X-Ray provides APIs for managing debug traces and retrieving service maps and
    /// other data created by processing those traces.
    /// </summary>
    public partial interface IAmazonXRay : IAmazonService, IDisposable
    {

        
        #region  BatchGetTraces


        /// <summary>
        /// Retrieves a list of traces specified by ID. Each trace is a collection of segment
        /// documents that originates from a single request. Use <code>GetTraceSummaries</code>
        /// to get a list of trace IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTraces service method.</param>
        /// 
        /// <returns>The response from the BatchGetTraces service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        BatchGetTracesResponse BatchGetTraces(BatchGetTracesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetTraces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTraces operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetTraces
        ///         operation.</returns>
        IAsyncResult BeginBatchGetTraces(BatchGetTracesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetTraces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetTraces.</param>
        /// 
        /// <returns>Returns a  BatchGetTracesResult from XRay.</returns>
        BatchGetTracesResponse EndBatchGetTraces(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGroup


        /// <summary>
        /// Creates a group resource with a name and a filter expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from XRay.</returns>
        CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSamplingRule


        /// <summary>
        /// Creates a rule to control sampling behavior for instrumented applications. Services
        /// retrieve rules with <a>GetSamplingRules</a>, and evaluate each rule in ascending order
        /// of <i>priority</i> for each request. If a rule matches, the service records a trace,
        /// borrowing it from the reservoir size. After 10 seconds, the service reports back to
        /// X-Ray with <a>GetSamplingTargets</a> to get updated versions of each in-use rule.
        /// The updated rule contains a trace quota that the service can use instead of borrowing
        /// from the reservoir.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSamplingRule service method.</param>
        /// 
        /// <returns>The response from the CreateSamplingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.RuleLimitExceededException">
        /// You have reached the maximum number of sampling rules.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        CreateSamplingRuleResponse CreateSamplingRule(CreateSamplingRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSamplingRule operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSamplingRule
        ///         operation.</returns>
        IAsyncResult BeginCreateSamplingRule(CreateSamplingRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSamplingRule.</param>
        /// 
        /// <returns>Returns a  CreateSamplingRuleResult from XRay.</returns>
        CreateSamplingRuleResponse EndCreateSamplingRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes a group resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from XRay.</returns>
        DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSamplingRule


        /// <summary>
        /// Deletes a sampling rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSamplingRule service method.</param>
        /// 
        /// <returns>The response from the DeleteSamplingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        DeleteSamplingRuleResponse DeleteSamplingRule(DeleteSamplingRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSamplingRule operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSamplingRule
        ///         operation.</returns>
        IAsyncResult BeginDeleteSamplingRule(DeleteSamplingRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSamplingRule.</param>
        /// 
        /// <returns>Returns a  DeleteSamplingRuleResult from XRay.</returns>
        DeleteSamplingRuleResponse EndDeleteSamplingRule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEncryptionConfig


        /// <summary>
        /// Retrieves the current encryption configuration for X-Ray data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEncryptionConfig service method.</param>
        /// 
        /// <returns>The response from the GetEncryptionConfig service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        GetEncryptionConfigResponse GetEncryptionConfig(GetEncryptionConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEncryptionConfig operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEncryptionConfig
        ///         operation.</returns>
        IAsyncResult BeginGetEncryptionConfig(GetEncryptionConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEncryptionConfig.</param>
        /// 
        /// <returns>Returns a  GetEncryptionConfigResult from XRay.</returns>
        GetEncryptionConfigResponse EndGetEncryptionConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGroup


        /// <summary>
        /// Retrieves group resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        GetGroupResponse GetGroup(GetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroup
        ///         operation.</returns>
        IAsyncResult BeginGetGroup(GetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a  GetGroupResult from XRay.</returns>
        GetGroupResponse EndGetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGroups


        /// <summary>
        /// Retrieves all active group details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroups service method.</param>
        /// 
        /// <returns>The response from the GetGroups service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        GetGroupsResponse GetGroups(GetGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroups operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroups
        ///         operation.</returns>
        IAsyncResult BeginGetGroups(GetGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroups.</param>
        /// 
        /// <returns>Returns a  GetGroupsResult from XRay.</returns>
        GetGroupsResponse EndGetGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSamplingRules


        /// <summary>
        /// Retrieves all sampling rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingRules service method.</param>
        /// 
        /// <returns>The response from the GetSamplingRules service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        GetSamplingRulesResponse GetSamplingRules(GetSamplingRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSamplingRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingRules operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSamplingRules
        ///         operation.</returns>
        IAsyncResult BeginGetSamplingRules(GetSamplingRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSamplingRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSamplingRules.</param>
        /// 
        /// <returns>Returns a  GetSamplingRulesResult from XRay.</returns>
        GetSamplingRulesResponse EndGetSamplingRules(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSamplingStatisticSummaries


        /// <summary>
        /// Retrieves information about recent sampling results for all sampling rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingStatisticSummaries service method.</param>
        /// 
        /// <returns>The response from the GetSamplingStatisticSummaries service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        GetSamplingStatisticSummariesResponse GetSamplingStatisticSummaries(GetSamplingStatisticSummariesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSamplingStatisticSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingStatisticSummaries operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSamplingStatisticSummaries
        ///         operation.</returns>
        IAsyncResult BeginGetSamplingStatisticSummaries(GetSamplingStatisticSummariesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSamplingStatisticSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSamplingStatisticSummaries.</param>
        /// 
        /// <returns>Returns a  GetSamplingStatisticSummariesResult from XRay.</returns>
        GetSamplingStatisticSummariesResponse EndGetSamplingStatisticSummaries(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSamplingTargets


        /// <summary>
        /// Requests a sampling quota for rules that the service is using to sample requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingTargets service method.</param>
        /// 
        /// <returns>The response from the GetSamplingTargets service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        GetSamplingTargetsResponse GetSamplingTargets(GetSamplingTargetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSamplingTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingTargets operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSamplingTargets
        ///         operation.</returns>
        IAsyncResult BeginGetSamplingTargets(GetSamplingTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSamplingTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSamplingTargets.</param>
        /// 
        /// <returns>Returns a  GetSamplingTargetsResult from XRay.</returns>
        GetSamplingTargetsResponse EndGetSamplingTargets(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServiceGraph


        /// <summary>
        /// Retrieves a document that describes services that process incoming requests, and downstream
        /// services that they call as a result. Root services process incoming requests and make
        /// calls to downstream services. Root services are applications that use the AWS X-Ray
        /// SDK. Downstream services can be other applications, AWS resources, HTTP web APIs,
        /// or SQL databases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceGraph service method.</param>
        /// 
        /// <returns>The response from the GetServiceGraph service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        GetServiceGraphResponse GetServiceGraph(GetServiceGraphRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceGraph operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceGraph
        ///         operation.</returns>
        IAsyncResult BeginGetServiceGraph(GetServiceGraphRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceGraph.</param>
        /// 
        /// <returns>Returns a  GetServiceGraphResult from XRay.</returns>
        GetServiceGraphResponse EndGetServiceGraph(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTraceGraph


        /// <summary>
        /// Retrieves a service graph for one or more specific trace IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTraceGraph service method.</param>
        /// 
        /// <returns>The response from the GetTraceGraph service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        GetTraceGraphResponse GetTraceGraph(GetTraceGraphRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTraceGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTraceGraph operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTraceGraph
        ///         operation.</returns>
        IAsyncResult BeginGetTraceGraph(GetTraceGraphRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTraceGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTraceGraph.</param>
        /// 
        /// <returns>Returns a  GetTraceGraphResult from XRay.</returns>
        GetTraceGraphResponse EndGetTraceGraph(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTraceSummaries


        /// <summary>
        /// Retrieves IDs and metadata for traces available for a specified time frame using an
        /// optional filter. To get the full traces, pass the trace IDs to <code>BatchGetTraces</code>.
        /// 
        ///  
        /// <para>
        /// A filter expression can target traced requests that hit specific service nodes or
        /// edges, have errors, or come from a known user. For example, the following filter expression
        /// targets traces that pass through <code>api.example.com</code>:
        /// </para>
        ///  
        /// <para>
        ///  <code>service("api.example.com")</code> 
        /// </para>
        ///  
        /// <para>
        /// This filter expression finds traces that have an annotation named <code>account</code>
        /// with the value <code>12345</code>:
        /// </para>
        ///  
        /// <para>
        ///  <code>annotation.account = "12345"</code> 
        /// </para>
        ///  
        /// <para>
        /// For a full list of indexed fields and keywords that you can use in filter expressions,
        /// see <a href="http://docs.aws.amazon.com/xray/latest/devguide/xray-console-filters.html">Using
        /// Filter Expressions</a> in the <i>AWS X-Ray Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTraceSummaries service method.</param>
        /// 
        /// <returns>The response from the GetTraceSummaries service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        GetTraceSummariesResponse GetTraceSummaries(GetTraceSummariesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTraceSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTraceSummaries operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTraceSummaries
        ///         operation.</returns>
        IAsyncResult BeginGetTraceSummaries(GetTraceSummariesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTraceSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTraceSummaries.</param>
        /// 
        /// <returns>Returns a  GetTraceSummariesResult from XRay.</returns>
        GetTraceSummariesResponse EndGetTraceSummaries(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEncryptionConfig


        /// <summary>
        /// Updates the encryption configuration for X-Ray data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEncryptionConfig service method.</param>
        /// 
        /// <returns>The response from the PutEncryptionConfig service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        PutEncryptionConfigResponse PutEncryptionConfig(PutEncryptionConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEncryptionConfig operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEncryptionConfig
        ///         operation.</returns>
        IAsyncResult BeginPutEncryptionConfig(PutEncryptionConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEncryptionConfig.</param>
        /// 
        /// <returns>Returns a  PutEncryptionConfigResult from XRay.</returns>
        PutEncryptionConfigResponse EndPutEncryptionConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  PutTelemetryRecords


        /// <summary>
        /// Used by the AWS X-Ray daemon to upload telemetry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTelemetryRecords service method.</param>
        /// 
        /// <returns>The response from the PutTelemetryRecords service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        PutTelemetryRecordsResponse PutTelemetryRecords(PutTelemetryRecordsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutTelemetryRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTelemetryRecords operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTelemetryRecords
        ///         operation.</returns>
        IAsyncResult BeginPutTelemetryRecords(PutTelemetryRecordsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutTelemetryRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTelemetryRecords.</param>
        /// 
        /// <returns>Returns a  PutTelemetryRecordsResult from XRay.</returns>
        PutTelemetryRecordsResponse EndPutTelemetryRecords(IAsyncResult asyncResult);

        #endregion
        
        #region  PutTraceSegments


        /// <summary>
        /// Uploads segment documents to AWS X-Ray. The X-Ray SDK generates segment documents
        /// and sends them to the X-Ray daemon, which uploads them in batches. A segment document
        /// can be a completed segment, an in-progress segment, or an array of subsegments.
        /// 
        ///  
        /// <para>
        /// Segments must include the following fields. For the full segment document schema,
        /// see <a href="https://docs.aws.amazon.com/xray/latest/devguide/xray-api-segmentdocuments.html">AWS
        /// X-Ray Segment Documents</a> in the <i>AWS X-Ray Developer Guide</i>.
        /// </para>
        ///  <p class="title"> <b>Required Segment Document Fields</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>name</code> - The name of the service that handled the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>id</code> - A 64-bit identifier for the segment, unique among segments in the
        /// same trace, in 16 hexadecimal digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>trace_id</code> - A unique identifier that connects all segments and subsegments
        /// originating from a single client request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>start_time</code> - Time the segment or subsegment was created, in floating
        /// point seconds in epoch time, accurate to milliseconds. For example, <code>1480615200.010</code>
        /// or <code>1.480615200010E9</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>end_time</code> - Time the segment or subsegment was closed. For example, <code>1480615200.090</code>
        /// or <code>1.480615200090E9</code>. Specify either an <code>end_time</code> or <code>in_progress</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>in_progress</code> - Set to <code>true</code> instead of specifying an <code>end_time</code>
        /// to record that a segment has been started, but is not complete. Send an in progress
        /// segment when your application receives a request that will take a long time to serve,
        /// to trace the fact that the request was received. When the response is sent, send the
        /// complete segment to overwrite the in-progress segment.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A <code>trace_id</code> consists of three numbers separated by hyphens. For example,
        /// 1-58406520-a006649127e371903a2de979. This includes:
        /// </para>
        ///  <p class="title"> <b>Trace ID Format</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The version number, i.e. <code>1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The time of the original request, in Unix epoch time, in 8 hexadecimal digits. For
        /// example, 10:00AM December 2nd, 2016 PST in epoch time is <code>1480615200</code> seconds,
        /// or <code>58406520</code> in hexadecimal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A 96-bit identifier for the trace, globally unique, in 24 hexadecimal digits.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTraceSegments service method.</param>
        /// 
        /// <returns>The response from the PutTraceSegments service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        PutTraceSegmentsResponse PutTraceSegments(PutTraceSegmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutTraceSegments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTraceSegments operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTraceSegments
        ///         operation.</returns>
        IAsyncResult BeginPutTraceSegments(PutTraceSegmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutTraceSegments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTraceSegments.</param>
        /// 
        /// <returns>Returns a  PutTraceSegmentsResult from XRay.</returns>
        PutTraceSegmentsResponse EndPutTraceSegments(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Updates a group resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from XRay.</returns>
        UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSamplingRule


        /// <summary>
        /// Modifies a sampling rule's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSamplingRule service method.</param>
        /// 
        /// <returns>The response from the UpdateSamplingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        UpdateSamplingRuleResponse UpdateSamplingRule(UpdateSamplingRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSamplingRule operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSamplingRule
        ///         operation.</returns>
        IAsyncResult BeginUpdateSamplingRule(UpdateSamplingRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSamplingRule.</param>
        /// 
        /// <returns>Returns a  UpdateSamplingRuleResult from XRay.</returns>
        UpdateSamplingRuleResponse EndUpdateSamplingRule(IAsyncResult asyncResult);

        #endregion
        
    }
}