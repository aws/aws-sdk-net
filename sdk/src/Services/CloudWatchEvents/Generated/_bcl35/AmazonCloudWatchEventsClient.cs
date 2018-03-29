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
    /// When your resources change state, they automatically send events into an event stream.
    /// You can create rules that match selected events in the stream and route them to targets
    /// to take action. You can also use rules to take action on a pre-determined schedule.
    /// For example, you can configure rules to:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Automatically invoke an AWS Lambda function to update DNS entries when an event notifies
    /// you that Amazon EC2 instance enters the running state.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Direct specific API records from CloudTrail to an Amazon Kinesis stream for detailed
    /// analysis of potential security or availability risks.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Periodically invoke a built-in target to create a snapshot of an Amazon EBS volume.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about the features of Amazon CloudWatch Events, see the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/events">Amazon
    /// CloudWatch Events User Guide</a>.
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
        /// Deletes the specified rule.
        /// 
        ///  
        /// <para>
        /// You must remove all targets from a rule using <a>RemoveTargets</a> before you can
        /// delete the rule.
        /// </para>
        ///  
        /// <para>
        /// When you delete a rule, incoming events might continue to match to the deleted rule.
        /// Please allow a short period of time for changes to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var marshaller = DeleteRuleRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteRule(DeleteRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteRuleRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual DeleteRuleResponse EndDeleteRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEventBus

        /// <summary>
        /// Displays the external AWS accounts that are permitted to write events to your account
        /// using your account's event bus, and the associated policy. To enable your account
        /// to receive events from other accounts, use <a>PutPermission</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventBus service method.</param>
        /// 
        /// <returns>The response from the DescribeEventBus service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DescribeEventBus">REST API Reference for DescribeEventBus Operation</seealso>
        public virtual DescribeEventBusResponse DescribeEventBus(DescribeEventBusRequest request)
        {
            var marshaller = DescribeEventBusRequestMarshaller.Instance;
            var unmarshaller = DescribeEventBusResponseUnmarshaller.Instance;

            return Invoke<DescribeEventBusRequest,DescribeEventBusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventBus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventBus operation on AmazonCloudWatchEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventBus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DescribeEventBus">REST API Reference for DescribeEventBus Operation</seealso>
        public virtual IAsyncResult BeginDescribeEventBus(DescribeEventBusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeEventBusRequestMarshaller.Instance;
            var unmarshaller = DescribeEventBusResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEventBusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventBus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventBus.</param>
        /// 
        /// <returns>Returns a  DescribeEventBusResult from CloudWatchEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DescribeEventBus">REST API Reference for DescribeEventBus Operation</seealso>
        public virtual DescribeEventBusResponse EndDescribeEventBus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventBusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRule

        /// <summary>
        /// Describes the specified rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRule service method.</param>
        /// 
        /// <returns>The response from the DescribeRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        public virtual DescribeRuleResponse DescribeRule(DescribeRuleRequest request)
        {
            var marshaller = DescribeRuleRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        public virtual IAsyncResult BeginDescribeRule(DescribeRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeRuleRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        public virtual DescribeRuleResponse EndDescribeRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableRule

        /// <summary>
        /// Disables the specified rule. A disabled rule won't match any events, and won't self-trigger
        /// if it has a schedule expression.
        /// 
        ///  
        /// <para>
        /// When you disable a rule, incoming events might continue to match to the disabled rule.
        /// Please allow a short period of time for changes to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableRule service method.</param>
        /// 
        /// <returns>The response from the DisableRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DisableRule">REST API Reference for DisableRule Operation</seealso>
        public virtual DisableRuleResponse DisableRule(DisableRuleRequest request)
        {
            var marshaller = DisableRuleRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DisableRule">REST API Reference for DisableRule Operation</seealso>
        public virtual IAsyncResult BeginDisableRule(DisableRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DisableRuleRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DisableRule">REST API Reference for DisableRule Operation</seealso>
        public virtual DisableRuleResponse EndDisableRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableRule

        /// <summary>
        /// Enables the specified rule. If the rule does not exist, the operation fails.
        /// 
        ///  
        /// <para>
        /// When you enable a rule, incoming events might not immediately start matching to a
        /// newly enabled rule. Please allow a short period of time for changes to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableRule service method.</param>
        /// 
        /// <returns>The response from the EnableRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/EnableRule">REST API Reference for EnableRule Operation</seealso>
        public virtual EnableRuleResponse EnableRule(EnableRuleRequest request)
        {
            var marshaller = EnableRuleRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/EnableRule">REST API Reference for EnableRule Operation</seealso>
        public virtual IAsyncResult BeginEnableRule(EnableRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = EnableRuleRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/EnableRule">REST API Reference for EnableRule Operation</seealso>
        public virtual EnableRuleResponse EndEnableRule(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRuleNamesByTarget

        /// <summary>
        /// Lists the rules for the specified target. You can see which of the rules in Amazon
        /// CloudWatch Events can invoke a specific target in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleNamesByTarget service method.</param>
        /// 
        /// <returns>The response from the ListRuleNamesByTarget service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRuleNamesByTarget">REST API Reference for ListRuleNamesByTarget Operation</seealso>
        public virtual ListRuleNamesByTargetResponse ListRuleNamesByTarget(ListRuleNamesByTargetRequest request)
        {
            var marshaller = ListRuleNamesByTargetRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRuleNamesByTarget">REST API Reference for ListRuleNamesByTarget Operation</seealso>
        public virtual IAsyncResult BeginListRuleNamesByTarget(ListRuleNamesByTargetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListRuleNamesByTargetRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRuleNamesByTarget">REST API Reference for ListRuleNamesByTarget Operation</seealso>
        public virtual ListRuleNamesByTargetResponse EndListRuleNamesByTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRuleNamesByTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRules

        /// <summary>
        /// Lists your Amazon CloudWatch Events rules. You can either list all the rules or you
        /// can provide a prefix to match to the rule names.
        /// </summary>
        /// 
        /// <returns>The response from the ListRules service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual ListRulesResponse ListRules()
        {
            return ListRules(new ListRulesRequest());
        }

        /// <summary>
        /// Lists your Amazon CloudWatch Events rules. You can either list all the rules or you
        /// can provide a prefix to match to the rule names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual ListRulesResponse ListRules(ListRulesRequest request)
        {
            var marshaller = ListRulesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual IAsyncResult BeginListRules(ListRulesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListRulesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual ListRulesResponse EndListRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTargetsByRule

        /// <summary>
        /// Lists the targets assigned to the specified rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsByRule service method.</param>
        /// 
        /// <returns>The response from the ListTargetsByRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListTargetsByRule">REST API Reference for ListTargetsByRule Operation</seealso>
        public virtual ListTargetsByRuleResponse ListTargetsByRule(ListTargetsByRuleRequest request)
        {
            var marshaller = ListTargetsByRuleRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListTargetsByRule">REST API Reference for ListTargetsByRule Operation</seealso>
        public virtual IAsyncResult BeginListTargetsByRule(ListTargetsByRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTargetsByRuleRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListTargetsByRule">REST API Reference for ListTargetsByRule Operation</seealso>
        public virtual ListTargetsByRuleResponse EndListTargetsByRule(IAsyncResult asyncResult)
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutEvents">REST API Reference for PutEvents Operation</seealso>
        public virtual PutEventsResponse PutEvents(PutEventsRequest request)
        {
            var marshaller = PutEventsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutEvents">REST API Reference for PutEvents Operation</seealso>
        public virtual IAsyncResult BeginPutEvents(PutEventsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutEventsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutEvents">REST API Reference for PutEvents Operation</seealso>
        public virtual PutEventsResponse EndPutEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPermission

        /// <summary>
        /// Running <code>PutPermission</code> permits the specified AWS account to put events
        /// to your account's default <i>event bus</i>. CloudWatch Events rules in your account
        /// are triggered by these events arriving to your default event bus. 
        /// 
        ///  
        /// <para>
        /// For another account to send events to your account, that external account must have
        /// a CloudWatch Events rule with your account's default event bus as a target.
        /// </para>
        ///  
        /// <para>
        /// To enable multiple AWS accounts to put events to your default event bus, run <code>PutPermission</code>
        /// once for each of these accounts.
        /// </para>
        ///  
        /// <para>
        /// The permission policy on the default event bus cannot exceed 10KB in size.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermission service method.</param>
        /// 
        /// <returns>The response from the PutPermission service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.PolicyLengthExceededException">
        /// The event bus policy is too long. For more information, see the limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutPermission">REST API Reference for PutPermission Operation</seealso>
        public virtual PutPermissionResponse PutPermission(PutPermissionRequest request)
        {
            var marshaller = PutPermissionRequestMarshaller.Instance;
            var unmarshaller = PutPermissionResponseUnmarshaller.Instance;

            return Invoke<PutPermissionRequest,PutPermissionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPermission operation on AmazonCloudWatchEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutPermission">REST API Reference for PutPermission Operation</seealso>
        public virtual IAsyncResult BeginPutPermission(PutPermissionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutPermissionRequestMarshaller.Instance;
            var unmarshaller = PutPermissionResponseUnmarshaller.Instance;

            return BeginInvoke<PutPermissionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPermission.</param>
        /// 
        /// <returns>Returns a  PutPermissionResult from CloudWatchEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutPermission">REST API Reference for PutPermission Operation</seealso>
        public virtual PutPermissionResponse EndPutPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRule

        /// <summary>
        /// Creates or updates the specified rule. Rules are enabled by default, or based on value
        /// of the state. You can disable a rule using <a>DisableRule</a>.
        /// 
        ///  
        /// <para>
        /// If you are updating an existing rule, the rule is completely replaced with what you
        /// specify in this <code>PutRule</code> command. If you omit arguments in <code>PutRule</code>,
        /// the old values for those arguments are not kept. Instead, they are replaced with null
        /// values.
        /// </para>
        ///  
        /// <para>
        /// When you create or update a rule, incoming events might not immediately start matching
        /// to new or updated rules. Please allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// A rule must contain at least an EventPattern or ScheduleExpression. Rules with EventPatterns
        /// are triggered when a matching event is observed. Rules with ScheduleExpressions self-trigger
        /// based on the given schedule. A rule can have both an EventPattern and a ScheduleExpression,
        /// in which case the rule triggers on matching events as well as on a schedule.
        /// </para>
        ///  
        /// <para>
        /// Most services in AWS treat : or / as the same character in Amazon Resource Names (ARNs).
        /// However, CloudWatch Events uses an exact match in event patterns and rules. Be sure
        /// to use the correct ARN characters when creating event patterns so that they match
        /// the ARN syntax in the event you want to match.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRule service method.</param>
        /// 
        /// <returns>The response from the PutRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.LimitExceededException">
        /// You tried to create more rules or add more targets to a rule than is allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutRule">REST API Reference for PutRule Operation</seealso>
        public virtual PutRuleResponse PutRule(PutRuleRequest request)
        {
            var marshaller = PutRuleRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutRule">REST API Reference for PutRule Operation</seealso>
        public virtual IAsyncResult BeginPutRule(PutRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutRuleRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutRule">REST API Reference for PutRule Operation</seealso>
        public virtual PutRuleResponse EndPutRule(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  PutTargets

        /// <summary>
        /// Adds the specified targets to the specified rule, or updates the targets if they are
        /// already associated with the rule.
        /// 
        ///  
        /// <para>
        /// Targets are the resources that are invoked when a rule is triggered.
        /// </para>
        ///  
        /// <para>
        /// You can configure the following as targets for CloudWatch Events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// EC2 instances
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Lambda functions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Streams in Amazon Kinesis Streams
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delivery streams in Amazon Kinesis Firehose
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon ECS tasks
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Step Functions state machines
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Batch jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pipelines in Amazon Code Pipeline
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Inspector assessment templates
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SNS topics
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SQS queues, including FIFO queues
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The default event bus of another AWS account
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note that creating rules with built-in targets is supported only in the AWS Management
        /// Console.
        /// </para>
        ///  
        /// <para>
        /// For some target types, <code>PutTargets</code> provides target-specific parameters.
        /// If the target is an Amazon Kinesis stream, you can optionally specify which shard
        /// the event goes to by using the <code>KinesisParameters</code> argument. To invoke
        /// a command on multiple EC2 instances with one rule, you can use the <code>RunCommandParameters</code>
        /// field.
        /// </para>
        ///  
        /// <para>
        /// To be able to make API calls against the resources that you own, Amazon CloudWatch
        /// Events needs the appropriate permissions. For AWS Lambda and Amazon SNS resources,
        /// CloudWatch Events relies on resource-based policies. For EC2 instances, Amazon Kinesis
        /// streams, and AWS Step Functions state machines, CloudWatch Events relies on IAM roles
        /// that you specify in the <code>RoleARN</code> argument in <code>PutTargets</code>.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/events/auth-and-access-control-cwe.html">Authentication
        /// and Access Control</a> in the <i>Amazon CloudWatch Events User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If another AWS account is in the same region and has granted you permission (using
        /// <code>PutPermission</code>), you can send events to that account by setting that account's
        /// event bus as a target of the rules in your account. To send the matched events to
        /// the other account, specify that account's event bus as the <code>Arn</code> when you
        /// run <code>PutTargets</code>. If your account sends events to another account, your
        /// account is charged for each sent event. Each event sent to antoher account is charged
        /// as a custom event. The account receiving the event is not charged. For more information
        /// on pricing, see <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon CloudWatch
        /// Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about enabling cross-account events, see <a>PutPermission</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Input</b>, <b>InputPath</b> and <b>InputTransformer</b> are mutually exclusive
        /// and optional parameters of a target. When a rule is triggered due to a matched event:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If none of the following arguments are specified for a target, then the entire event
        /// is passed to the target in JSON form (unless the target is Amazon EC2 Run Command
        /// or Amazon ECS task, in which case nothing from the event is passed to the target).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>Input</b> is specified in the form of valid JSON, then the matched event is
        /// overridden with this constant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>InputPath</b> is specified in the form of JSONPath (for example, <code>$.detail</code>),
        /// then only the part of the event specified in the path is passed to the target (for
        /// example, only the detail part of the event is passed).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>InputTransformer</b> is specified, then one or more specified JSONPaths are
        /// extracted from the event and used as values in a template that you specify as the
        /// input to the target.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you specify <code>InputPath</code> or <code>InputTransformer</code>, you must
        /// use JSON dot notation, not bracket notation.
        /// </para>
        ///  
        /// <para>
        /// When you add targets to a rule and the associated rule triggers soon after, new or
        /// updated targets might not be immediately invoked. Please allow a short period of time
        /// for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// This action can partially fail if too many requests are made at the same time. If
        /// that happens, <code>FailedEntryCount</code> is non-zero in the response and each entry
        /// in <code>FailedEntries</code> provides the ID of the failed target and the error code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTargets service method.</param>
        /// 
        /// <returns>The response from the PutTargets service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.LimitExceededException">
        /// You tried to create more rules or add more targets to a rule than is allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutTargets">REST API Reference for PutTargets Operation</seealso>
        public virtual PutTargetsResponse PutTargets(PutTargetsRequest request)
        {
            var marshaller = PutTargetsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutTargets">REST API Reference for PutTargets Operation</seealso>
        public virtual IAsyncResult BeginPutTargets(PutTargetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutTargetsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutTargets">REST API Reference for PutTargets Operation</seealso>
        public virtual PutTargetsResponse EndPutTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<PutTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  RemovePermission

        /// <summary>
        /// Revokes the permission of another AWS account to be able to put events to your default
        /// event bus. Specify the account to revoke by the <code>StatementId</code> value that
        /// you associated with the account when you granted it permission with <code>PutPermission</code>.
        /// You can find the <code>StatementId</code> by using <a>DescribeEventBus</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            var marshaller = RemovePermissionRequestMarshaller.Instance;
            var unmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return Invoke<RemovePermissionRequest,RemovePermissionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation on AmazonCloudWatchEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemovePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual IAsyncResult BeginRemovePermission(RemovePermissionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RemovePermissionRequestMarshaller.Instance;
            var unmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return BeginInvoke<RemovePermissionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemovePermission.</param>
        /// 
        /// <returns>Returns a  RemovePermissionResult from CloudWatchEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual RemovePermissionResponse EndRemovePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<RemovePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTargets

        /// <summary>
        /// Removes the specified targets from the specified rule. When the rule is triggered,
        /// those targets are no longer be invoked.
        /// 
        ///  
        /// <para>
        /// When you remove a target, when the associated rule triggers, removed targets might
        /// continue to be invoked. Please allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// This action can partially fail if too many requests are made at the same time. If
        /// that happens, <code>FailedEntryCount</code> is non-zero in the response and each entry
        /// in <code>FailedEntries</code> provides the ID of the failed target and the error code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTargets service method.</param>
        /// 
        /// <returns>The response from the RemoveTargets service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/RemoveTargets">REST API Reference for RemoveTargets Operation</seealso>
        public virtual RemoveTargetsResponse RemoveTargets(RemoveTargetsRequest request)
        {
            var marshaller = RemoveTargetsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/RemoveTargets">REST API Reference for RemoveTargets Operation</seealso>
        public virtual IAsyncResult BeginRemoveTargets(RemoveTargetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RemoveTargetsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/RemoveTargets">REST API Reference for RemoveTargets Operation</seealso>
        public virtual RemoveTargetsResponse EndRemoveTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  TestEventPattern

        /// <summary>
        /// Tests whether the specified event pattern matches the provided event.
        /// 
        ///  
        /// <para>
        /// Most services in AWS treat : or / as the same character in Amazon Resource Names (ARNs).
        /// However, CloudWatch Events uses an exact match in event patterns and rules. Be sure
        /// to use the correct ARN characters when creating event patterns so that they match
        /// the ARN syntax in the event you want to match.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestEventPattern service method.</param>
        /// 
        /// <returns>The response from the TestEventPattern service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/TestEventPattern">REST API Reference for TestEventPattern Operation</seealso>
        public virtual TestEventPatternResponse TestEventPattern(TestEventPatternRequest request)
        {
            var marshaller = TestEventPatternRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/TestEventPattern">REST API Reference for TestEventPattern Operation</seealso>
        public virtual IAsyncResult BeginTestEventPattern(TestEventPatternRequest request, AsyncCallback callback, object state)
        {
            var marshaller = TestEventPatternRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/TestEventPattern">REST API Reference for TestEventPattern Operation</seealso>
        public virtual TestEventPatternResponse EndTestEventPattern(IAsyncResult asyncResult)
        {
            return EndInvoke<TestEventPatternResponse>(asyncResult);
        }

        #endregion
        
    }
}