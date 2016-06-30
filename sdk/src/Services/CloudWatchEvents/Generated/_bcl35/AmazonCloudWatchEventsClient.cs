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

using Amazon.CloudWatchEvents.Model;
using Amazon.CloudWatchEvents.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudWatchEvents
{
    /// <summary>
    /// Implementation for accessing CloudWatchEvents
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
    public partial class AmazonCloudWatchEventsClient : AmazonServiceClient, IAmazonCloudWatchEvents
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCloudWatchEventsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchEventsConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchEventsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchEventsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCloudWatchEventsClient Configuration Object</param>
        public AmazonCloudWatchEventsClient(AmazonCloudWatchEventsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudWatchEventsClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudWatchEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchEventsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudWatchEventsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Credentials and an
        /// AmazonCloudWatchEventsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudWatchEventsClient Configuration Object</param>
        public AmazonCloudWatchEventsClient(AWSCredentials credentials, AmazonCloudWatchEventsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudWatchEventsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchEventsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchEventsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchEventsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudWatchEventsClient Configuration Object</param>
        public AmazonCloudWatchEventsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudWatchEventsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudWatchEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchEventsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchEventsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudWatchEventsClient Configuration Object</param>
        public AmazonCloudWatchEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudWatchEventsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
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
        public DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var marshaller = new DeleteRuleRequestMarshaller();
            var unmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleRequest,DeleteRuleResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginDeleteRule(DeleteRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteRuleRequestMarshaller();
            var unmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteRuleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRule.</param>
        /// 
        /// <returns>Returns a  DeleteRuleResult from CloudWatchEvents.</returns>
        public  DeleteRuleResponse EndDeleteRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRuleResponse>(asyncResult);
        }

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
        public DescribeRuleResponse DescribeRule(DescribeRuleRequest request)
        {
            var marshaller = new DescribeRuleRequestMarshaller();
            var unmarshaller = DescribeRuleResponseUnmarshaller.Instance;

            return Invoke<DescribeRuleRequest,DescribeRuleResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginDescribeRule(DescribeRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeRuleRequestMarshaller();
            var unmarshaller = DescribeRuleResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeRuleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRule.</param>
        /// 
        /// <returns>Returns a  DescribeRuleResult from CloudWatchEvents.</returns>
        public  DescribeRuleResponse EndDescribeRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRuleResponse>(asyncResult);
        }

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
        public DisableRuleResponse DisableRule(DisableRuleRequest request)
        {
            var marshaller = new DisableRuleRequestMarshaller();
            var unmarshaller = DisableRuleResponseUnmarshaller.Instance;

            return Invoke<DisableRuleRequest,DisableRuleResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginDisableRule(DisableRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisableRuleRequestMarshaller();
            var unmarshaller = DisableRuleResponseUnmarshaller.Instance;

            return BeginInvoke<DisableRuleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableRule.</param>
        /// 
        /// <returns>Returns a  DisableRuleResult from CloudWatchEvents.</returns>
        public  DisableRuleResponse EndDisableRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableRuleResponse>(asyncResult);
        }

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
        public EnableRuleResponse EnableRule(EnableRuleRequest request)
        {
            var marshaller = new EnableRuleRequestMarshaller();
            var unmarshaller = EnableRuleResponseUnmarshaller.Instance;

            return Invoke<EnableRuleRequest,EnableRuleResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginEnableRule(EnableRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new EnableRuleRequestMarshaller();
            var unmarshaller = EnableRuleResponseUnmarshaller.Instance;

            return BeginInvoke<EnableRuleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableRule.</param>
        /// 
        /// <returns>Returns a  EnableRuleResult from CloudWatchEvents.</returns>
        public  EnableRuleResponse EndEnableRule(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableRuleResponse>(asyncResult);
        }

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
        public ListRuleNamesByTargetResponse ListRuleNamesByTarget(ListRuleNamesByTargetRequest request)
        {
            var marshaller = new ListRuleNamesByTargetRequestMarshaller();
            var unmarshaller = ListRuleNamesByTargetResponseUnmarshaller.Instance;

            return Invoke<ListRuleNamesByTargetRequest,ListRuleNamesByTargetResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginListRuleNamesByTarget(ListRuleNamesByTargetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListRuleNamesByTargetRequestMarshaller();
            var unmarshaller = ListRuleNamesByTargetResponseUnmarshaller.Instance;

            return BeginInvoke<ListRuleNamesByTargetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuleNamesByTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuleNamesByTarget.</param>
        /// 
        /// <returns>Returns a  ListRuleNamesByTargetResult from CloudWatchEvents.</returns>
        public  ListRuleNamesByTargetResponse EndListRuleNamesByTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRuleNamesByTargetResponse>(asyncResult);
        }

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
        public ListRulesResponse ListRules()
        {
            return ListRules(new ListRulesRequest());
        }

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
        public ListRulesResponse ListRules(ListRulesRequest request)
        {
            var marshaller = new ListRulesRequestMarshaller();
            var unmarshaller = ListRulesResponseUnmarshaller.Instance;

            return Invoke<ListRulesRequest,ListRulesResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginListRules(ListRulesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListRulesRequestMarshaller();
            var unmarshaller = ListRulesResponseUnmarshaller.Instance;

            return BeginInvoke<ListRulesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRules.</param>
        /// 
        /// <returns>Returns a  ListRulesResult from CloudWatchEvents.</returns>
        public  ListRulesResponse EndListRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRulesResponse>(asyncResult);
        }

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
        public ListTargetsByRuleResponse ListTargetsByRule(ListTargetsByRuleRequest request)
        {
            var marshaller = new ListTargetsByRuleRequestMarshaller();
            var unmarshaller = ListTargetsByRuleResponseUnmarshaller.Instance;

            return Invoke<ListTargetsByRuleRequest,ListTargetsByRuleResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginListTargetsByRule(ListTargetsByRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTargetsByRuleRequestMarshaller();
            var unmarshaller = ListTargetsByRuleResponseUnmarshaller.Instance;

            return BeginInvoke<ListTargetsByRuleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargetsByRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargetsByRule.</param>
        /// 
        /// <returns>Returns a  ListTargetsByRuleResult from CloudWatchEvents.</returns>
        public  ListTargetsByRuleResponse EndListTargetsByRule(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTargetsByRuleResponse>(asyncResult);
        }

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
        public PutEventsResponse PutEvents(PutEventsRequest request)
        {
            var marshaller = new PutEventsRequestMarshaller();
            var unmarshaller = PutEventsResponseUnmarshaller.Instance;

            return Invoke<PutEventsRequest,PutEventsResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginPutEvents(PutEventsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutEventsRequestMarshaller();
            var unmarshaller = PutEventsResponseUnmarshaller.Instance;

            return BeginInvoke<PutEventsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEvents.</param>
        /// 
        /// <returns>Returns a  PutEventsResult from CloudWatchEvents.</returns>
        public  PutEventsResponse EndPutEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEventsResponse>(asyncResult);
        }

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
        public PutRuleResponse PutRule(PutRuleRequest request)
        {
            var marshaller = new PutRuleRequestMarshaller();
            var unmarshaller = PutRuleResponseUnmarshaller.Instance;

            return Invoke<PutRuleRequest,PutRuleResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginPutRule(PutRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutRuleRequestMarshaller();
            var unmarshaller = PutRuleResponseUnmarshaller.Instance;

            return BeginInvoke<PutRuleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRule.</param>
        /// 
        /// <returns>Returns a  PutRuleResult from CloudWatchEvents.</returns>
        public  PutRuleResponse EndPutRule(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRuleResponse>(asyncResult);
        }

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
        public PutTargetsResponse PutTargets(PutTargetsRequest request)
        {
            var marshaller = new PutTargetsRequestMarshaller();
            var unmarshaller = PutTargetsResponseUnmarshaller.Instance;

            return Invoke<PutTargetsRequest,PutTargetsResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginPutTargets(PutTargetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutTargetsRequestMarshaller();
            var unmarshaller = PutTargetsResponseUnmarshaller.Instance;

            return BeginInvoke<PutTargetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTargets.</param>
        /// 
        /// <returns>Returns a  PutTargetsResult from CloudWatchEvents.</returns>
        public  PutTargetsResponse EndPutTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<PutTargetsResponse>(asyncResult);
        }

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
        public RemoveTargetsResponse RemoveTargets(RemoveTargetsRequest request)
        {
            var marshaller = new RemoveTargetsRequestMarshaller();
            var unmarshaller = RemoveTargetsResponseUnmarshaller.Instance;

            return Invoke<RemoveTargetsRequest,RemoveTargetsResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginRemoveTargets(RemoveTargetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RemoveTargetsRequestMarshaller();
            var unmarshaller = RemoveTargetsResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveTargetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTargets.</param>
        /// 
        /// <returns>Returns a  RemoveTargetsResult from CloudWatchEvents.</returns>
        public  RemoveTargetsResponse EndRemoveTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTargetsResponse>(asyncResult);
        }

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
        public TestEventPatternResponse TestEventPattern(TestEventPatternRequest request)
        {
            var marshaller = new TestEventPatternRequestMarshaller();
            var unmarshaller = TestEventPatternResponseUnmarshaller.Instance;

            return Invoke<TestEventPatternRequest,TestEventPatternResponse>(request, marshaller, unmarshaller);
        }

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
        public IAsyncResult BeginTestEventPattern(TestEventPatternRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new TestEventPatternRequestMarshaller();
            var unmarshaller = TestEventPatternResponseUnmarshaller.Instance;

            return BeginInvoke<TestEventPatternRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestEventPattern operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestEventPattern.</param>
        /// 
        /// <returns>Returns a  TestEventPatternResult from CloudWatchEvents.</returns>
        public  TestEventPatternResponse EndTestEventPattern(IAsyncResult asyncResult)
        {
            return EndInvoke<TestEventPatternResponse>(asyncResult);
        }

        #endregion
        
    }
}