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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudWatchEvents.Model;

namespace Amazon.CloudWatchEvents
{
    /// <summary>
    /// Interface for accessing CloudWatchEvents
    ///
    /// Amazon CloudWatch Events helps you to respond to state changes in your AWS resources.
    /// When your resources change state they automatically send events into an event stream.
    /// You can create rules that match selected events in the stream and route them to targets
    /// to take action. You can also use rules to take action on a pre-determined schedule.
    /// For example, you can configure rules to: 
    /// 
    ///  <ul> <li>Automatically invoke an AWS Lambda function to update DNS entries when an
    /// event notifies you that Amazon EC2 instance enters the running state.</li> <li>Direct
    /// specific API records from CloudTrail to an Amazon Kinesis stream for detailed analysis
    /// of potential security or availability risks.</li> <li>Periodically invoke a built-in
    /// target to create a snapshot of an Amazon EBS volume.</li> </ul> 
    /// <para>
    ///  For more information about Amazon CloudWatch Events features, see the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide">Amazon
    /// CloudWatch Developer Guide</a>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudWatchEvents : IAmazonService, IDisposable
    {

        
        #region  DeleteRule


        /// <summary>
        /// Deletes a rule. You must remove all targets from a rule using <a>RemoveTargets</a>
        /// before you can delete the rule.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> When you delete a rule, incoming events might still continue to match
        /// to the deleted rule. Please allow a short period of time for changes to take effect.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// This exception occurs if there is concurrent modification on rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        DeleteRuleResponse DeleteRule(DeleteRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule operation on AmazonCloudWatchEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRule
        ///         operation.</returns>
        IAsyncResult BeginDeleteRule(DeleteRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRule.</param>
        /// 
        /// <returns>Returns a  DeleteRuleResult from CloudWatchEvents.</returns>
        DeleteRuleResponse EndDeleteRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRule


        /// <summary>
        /// Describes the details of the specified rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRule service method.</param>
        /// 
        /// <returns>The response from the DescribeRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// The rule does not exist.
        /// </exception>
        DescribeRuleResponse DescribeRule(DescribeRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRule operation on AmazonCloudWatchEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRule
        ///         operation.</returns>
        IAsyncResult BeginDescribeRule(DescribeRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRule.</param>
        /// 
        /// <returns>Returns a  DescribeRuleResult from CloudWatchEvents.</returns>
        DescribeRuleResponse EndDescribeRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableRule


        /// <summary>
        /// Disables a rule. A disabled rule won't match any events, and won't self-trigger if
        /// it has a schedule expression.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> When you disable a rule, incoming events might still continue to match
        /// to the disabled rule. Please allow a short period of time for changes to take effect.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableRule service method.</param>
        /// 
        /// <returns>The response from the DisableRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// This exception occurs if there is concurrent modification on rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// The rule does not exist.
        /// </exception>
        DisableRuleResponse DisableRule(DisableRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableRule operation on AmazonCloudWatchEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableRule
        ///         operation.</returns>
        IAsyncResult BeginDisableRule(DisableRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableRule.</param>
        /// 
        /// <returns>Returns a  DisableRuleResult from CloudWatchEvents.</returns>
        DisableRuleResponse EndDisableRule(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableRule


        /// <summary>
        /// Enables a rule. If the rule does not exist, the operation fails.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> When you enable a rule, incoming events might not immediately start
        /// matching to a newly enabled rule. Please allow a short period of time for changes
        /// to take effect. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableRule service method.</param>
        /// 
        /// <returns>The response from the EnableRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// This exception occurs if there is concurrent modification on rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// The rule does not exist.
        /// </exception>
        EnableRuleResponse EnableRule(EnableRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableRule operation on AmazonCloudWatchEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableRule
        ///         operation.</returns>
        IAsyncResult BeginEnableRule(EnableRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableRule.</param>
        /// 
        /// <returns>Returns a  EnableRuleResult from CloudWatchEvents.</returns>
        EnableRuleResponse EndEnableRule(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRuleNamesByTarget


        /// <summary>
        /// Lists the names of the rules that the given target is put to. You can see which of
        /// the rules in Amazon CloudWatch Events can invoke a specific target in your account.
        /// If you have more rules in your account than the given limit, the results will be paginated.
        /// In that case, use the next token returned in the response and repeat ListRulesByTarget
        /// until the NextToken in the response is returned as null.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleNamesByTarget service method.</param>
        /// 
        /// <returns>The response from the ListRuleNamesByTarget service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        ListRuleNamesByTargetResponse ListRuleNamesByTarget(ListRuleNamesByTargetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuleNamesByTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuleNamesByTarget operation on AmazonCloudWatchEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuleNamesByTarget
        ///         operation.</returns>
        IAsyncResult BeginListRuleNamesByTarget(ListRuleNamesByTargetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuleNamesByTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuleNamesByTarget.</param>
        /// 
        /// <returns>Returns a  ListRuleNamesByTargetResult from CloudWatchEvents.</returns>
        ListRuleNamesByTargetResponse EndListRuleNamesByTarget(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRules


        /// <summary>
        /// Lists the Amazon CloudWatch Events rules in your account. You can either list all
        /// the rules or you can provide a prefix to match to the rule names. If you have more
        /// rules in your account than the given limit, the results will be paginated. In that
        /// case, use the next token returned in the response and repeat ListRules until the NextToken
        /// in the response is returned as null.
        /// </summary>
        /// 
        /// <returns>The response from the ListRules service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        ListRulesResponse ListRules();

        /// <summary>
        /// Lists the Amazon CloudWatch Events rules in your account. You can either list all
        /// the rules or you can provide a prefix to match to the rule names. If you have more
        /// rules in your account than the given limit, the results will be paginated. In that
        /// case, use the next token returned in the response and repeat ListRules until the NextToken
        /// in the response is returned as null.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        ListRulesResponse ListRules(ListRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRules operation on AmazonCloudWatchEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRules
        ///         operation.</returns>
        IAsyncResult BeginListRules(ListRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRules.</param>
        /// 
        /// <returns>Returns a  ListRulesResult from CloudWatchEvents.</returns>
        ListRulesResponse EndListRules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTargetsByRule


        /// <summary>
        /// Lists of targets assigned to the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsByRule service method.</param>
        /// 
        /// <returns>The response from the ListTargetsByRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// The rule does not exist.
        /// </exception>
        ListTargetsByRuleResponse ListTargetsByRule(ListTargetsByRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTargetsByRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsByRule operation on AmazonCloudWatchEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTargetsByRule
        ///         operation.</returns>
        IAsyncResult BeginListTargetsByRule(ListTargetsByRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargetsByRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargetsByRule.</param>
        /// 
        /// <returns>Returns a  ListTargetsByRuleResult from CloudWatchEvents.</returns>
        ListTargetsByRuleResponse EndListTargetsByRule(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEvents


        /// <summary>
        /// Sends custom events to Amazon CloudWatch Events so that they can be matched to rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        PutEventsResponse PutEvents(PutEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEvents operation on AmazonCloudWatchEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEvents
        ///         operation.</returns>
        IAsyncResult BeginPutEvents(PutEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEvents.</param>
        /// 
        /// <returns>Returns a  PutEventsResult from CloudWatchEvents.</returns>
        PutEventsResponse EndPutEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRule


        /// <summary>
        /// Creates or updates a rule. Rules are enabled by default, or based on value of the
        /// State parameter. You can disable a rule using <a>DisableRule</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> When you create or update a rule, incoming events might not immediately
        /// start matching to new or updated rules. Please allow a short period of time for changes
        /// to take effect.
        /// </para>
        ///  
        /// <para>
        /// A rule must contain at least an EventPattern or ScheduleExpression. Rules with EventPatterns
        /// are triggered when a matching event is observed. Rules with ScheduleExpressions self-trigger
        /// based on the given schedule. A rule can have both an EventPattern and a ScheduleExpression,
        /// in which case the rule will trigger on matching events as well as on a schedule.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Most services in AWS treat : or / as the same character in Amazon Resource
        /// Names (ARNs). However, CloudWatch Events uses an exact match in event patterns and
        /// rules. Be sure to use the correct ARN characters when creating event patterns so that
        /// they match the ARN syntax in the event you want to match. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRule service method.</param>
        /// 
        /// <returns>The response from the PutRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// This exception occurs if there is concurrent modification on rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InvalidEventPatternException">
        /// The event pattern is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.LimitExceededException">
        /// This exception occurs if you try to create more rules or add more targets to a rule
        /// than allowed by default.
        /// </exception>
        PutRuleResponse PutRule(PutRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRule operation on AmazonCloudWatchEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRule
        ///         operation.</returns>
        IAsyncResult BeginPutRule(PutRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRule.</param>
        /// 
        /// <returns>Returns a  PutRuleResult from CloudWatchEvents.</returns>
        PutRuleResponse EndPutRule(IAsyncResult asyncResult);

        #endregion
        
        #region  PutTargets


        /// <summary>
        /// Adds target(s) to a rule. Targets are the resources that can be invoked when a rule
        /// is triggered. For example, AWS Lambda functions, Amazon Kinesis streams, and built-in
        /// targets. Updates the target(s) if they are already associated with the role. In other
        /// words, if there is already a target with the given target ID, then the target associated
        /// with that ID is updated.
        /// 
        ///  
        /// <para>
        /// In order to be able to make API calls against the resources you own, Amazon CloudWatch
        /// Events needs the appropriate permissions. For AWS Lambda and Amazon SNS resources,
        /// CloudWatch Events relies on resource-based policies. For Amazon Kinesis streams, CloudWatch
        /// Events relies on IAM roles. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/EventsTargetPermissions.html">Permissions
        /// for Sending Events to Targets</a> in the <b><i>Amazon CloudWatch Developer Guide</i></b>.
        /// </para>
        ///  
        /// <para>
        /// <b>Input</b> and <b>InputPath</b> are mutually-exclusive and optional parameters of
        /// a target. When a rule is triggered due to a matched event, if for a target:
        /// </para>
        ///  <ul> <li>Neither <b>Input</b> nor <b>InputPath</b> is specified, then the entire
        /// event is passed to the target in JSON form.</li> <li><b>InputPath</b> is specified
        /// in the form of JSONPath (e.g. <b>$.detail</b>), then only the part of the event specified
        /// in the path is passed to the target (e.g. only the detail part of the event is passed).
        /// </li> <li><b>Input</b> is specified in the form of a valid JSON, then the matched
        /// event is overridden with this constant.</li> </ul> 
        /// <para>
        ///  <b>Note:</b> When you add targets to a rule, when the associated rule triggers, new
        /// or updated targets might not be immediately invoked. Please allow a short period of
        /// time for changes to take effect. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTargets service method.</param>
        /// 
        /// <returns>The response from the PutTargets service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// This exception occurs if there is concurrent modification on rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.LimitExceededException">
        /// This exception occurs if you try to create more rules or add more targets to a rule
        /// than allowed by default.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// The rule does not exist.
        /// </exception>
        PutTargetsResponse PutTargets(PutTargetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTargets operation on AmazonCloudWatchEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTargets
        ///         operation.</returns>
        IAsyncResult BeginPutTargets(PutTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTargets.</param>
        /// 
        /// <returns>Returns a  PutTargetsResult from CloudWatchEvents.</returns>
        PutTargetsResponse EndPutTargets(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveTargets


        /// <summary>
        /// Removes target(s) from a rule so that when the rule is triggered, those targets will
        /// no longer be invoked.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> When you remove a target, when the associated rule triggers, removed
        /// targets might still continue to be invoked. Please allow a short period of time for
        /// changes to take effect. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTargets service method.</param>
        /// 
        /// <returns>The response from the RemoveTargets service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// This exception occurs if there is concurrent modification on rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// The rule does not exist.
        /// </exception>
        RemoveTargetsResponse RemoveTargets(RemoveTargetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTargets operation on AmazonCloudWatchEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTargets
        ///         operation.</returns>
        IAsyncResult BeginRemoveTargets(RemoveTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTargets.</param>
        /// 
        /// <returns>Returns a  RemoveTargetsResult from CloudWatchEvents.</returns>
        RemoveTargetsResponse EndRemoveTargets(IAsyncResult asyncResult);

        #endregion
        
        #region  TestEventPattern


        /// <summary>
        /// Tests whether an event pattern matches the provided event.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> Most services in AWS treat : or / as the same character in Amazon Resource
        /// Names (ARNs). However, CloudWatch Events uses an exact match in event patterns and
        /// rules. Be sure to use the correct ARN characters when creating event patterns so that
        /// they match the ARN syntax in the event you want to match. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestEventPattern service method.</param>
        /// 
        /// <returns>The response from the TestEventPattern service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InvalidEventPatternException">
        /// The event pattern is invalid.
        /// </exception>
        TestEventPatternResponse TestEventPattern(TestEventPatternRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestEventPattern operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestEventPattern operation on AmazonCloudWatchEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestEventPattern
        ///         operation.</returns>
        IAsyncResult BeginTestEventPattern(TestEventPatternRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestEventPattern operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestEventPattern.</param>
        /// 
        /// <returns>Returns a  TestEventPatternResult from CloudWatchEvents.</returns>
        TestEventPatternResponse EndTestEventPattern(IAsyncResult asyncResult);

        #endregion
        
    }
}