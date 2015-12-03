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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.ConfigService.Model;
using Amazon.ConfigService.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ConfigService
{
    /// <summary>
    /// Implementation for accessing ConfigService
    ///
    /// AWS Config 
    /// <para>
    /// AWS Config provides a way to keep track of the configurations of all the AWS resources
    /// associated with your AWS account. You can use AWS Config to get the current and historical
    /// configurations of each AWS resource and also to get information about the relationship
    /// between the resources. An AWS resource can be an Amazon Compute Cloud (Amazon EC2)
    /// instance, an Elastic Block Store (EBS) volume, an Elastic network Interface (ENI),
    /// or a security group. For a complete list of resources currently supported by AWS Config,
    /// see <a href="http://docs.aws.amazon.com/config/latest/developerguide/resource-config-reference.html#supported-resources">Supported
    /// AWS Resources</a>.
    /// </para>
    ///  
    /// <para>
    /// You can access and manage AWS Config through the AWS Management Console, the AWS Command
    /// Line Interface (AWS CLI), the AWS Config API, or the AWS SDKs for AWS Config
    /// </para>
    ///  
    /// <para>
    /// This reference guide contains documentation for the AWS Config API and the AWS CLI
    /// commands that you can use to manage AWS Config.
    /// </para>
    ///  
    /// <para>
    /// The AWS Config API uses the Signature Version 4 protocol for signing requests. For
    /// more information about how to sign a request with this protocol, see <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a>.
    /// </para>
    ///  
    /// <para>
    /// For detailed information about AWS Config features and their associated actions or
    /// commands, as well as how to work with AWS Management Console, see <a href="http://docs.aws.amazon.com/config/latest/developerguide/WhatIsConfig.html">What
    /// Is AWS Config?</a> in the <i>AWS Config Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonConfigServiceClient : AmazonServiceClient, IAmazonConfigService
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonConfigServiceClient with the credentials loaded from the application's
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
        public AmazonConfigServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConfigServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with the credentials loaded from the application's
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
        public AmazonConfigServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConfigServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonConfigServiceClient Configuration Object</param>
        public AmazonConfigServiceClient(AmazonConfigServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonConfigServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonConfigServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConfigServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonConfigServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Credentials and an
        /// AmazonConfigServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonConfigServiceClient Configuration Object</param>
        public AmazonConfigServiceClient(AWSCredentials credentials, AmazonConfigServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConfigServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConfigServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConfigServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonConfigServiceClient Configuration Object</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonConfigServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConfigServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConfigServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConfigServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonConfigServiceClient Configuration Object</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonConfigServiceConfig clientConfig)
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

        
        #region  DeleteConfigRule

        /// <summary>
        /// Deletes the specified AWS Config rule and all of its evaluation results.
        /// 
        ///  
        /// <para>
        /// AWS Config sets the state of a rule to <code>DELETING</code> until the deletion is
        /// complete. You cannot update a rule while it is in this state. If you make a <code>PutConfigRule</code>
        /// request for the rule, you will receive a <code>ResourceInUseException</code>.
        /// </para>
        ///  
        /// <para>
        /// You can check the state of a rule by using the <code>DescribeConfigRules</code> request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigRule service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        public DeleteConfigRuleResponse DeleteConfigRule(DeleteConfigRuleRequest request)
        {
            var marshaller = new DeleteConfigRuleRequestMarshaller();
            var unmarshaller = DeleteConfigRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigRuleRequest,DeleteConfigRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigRule operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigRule
        ///         operation.</returns>
        public IAsyncResult BeginDeleteConfigRule(DeleteConfigRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteConfigRuleRequestMarshaller();
            var unmarshaller = DeleteConfigRuleResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteConfigRuleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigRule.</param>
        /// 
        /// <returns>Returns a  DeleteConfigRuleResult from ConfigService.</returns>
        public  DeleteConfigRuleResponse EndDeleteConfigRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfigRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDeliveryChannel

        /// <summary>
        /// Deletes the specified delivery channel.
        /// 
        ///  
        /// <para>
        /// The delivery channel cannot be deleted if it is the only delivery channel and the
        /// configuration recorder is still running. To delete the delivery channel, stop the
        /// running configuration recorder using the <a>StopConfigurationRecorder</a> action.
        /// </para>
        /// </summary>
        /// <param name="deliveryChannelName">The name of the delivery channel to delete.</param>
        /// 
        /// <returns>The response from the DeleteDeliveryChannel service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.LastDeliveryChannelDeleteFailedException">
        /// You cannot delete the delivery channel you specified because the configuration recorder
        /// is running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        public DeleteDeliveryChannelResponse DeleteDeliveryChannel(string deliveryChannelName)
        {
            var request = new DeleteDeliveryChannelRequest();
            request.DeliveryChannelName = deliveryChannelName;
            return DeleteDeliveryChannel(request);
        }


        /// <summary>
        /// Deletes the specified delivery channel.
        /// 
        ///  
        /// <para>
        /// The delivery channel cannot be deleted if it is the only delivery channel and the
        /// configuration recorder is still running. To delete the delivery channel, stop the
        /// running configuration recorder using the <a>StopConfigurationRecorder</a> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteDeliveryChannel service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.LastDeliveryChannelDeleteFailedException">
        /// You cannot delete the delivery channel you specified because the configuration recorder
        /// is running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        public DeleteDeliveryChannelResponse DeleteDeliveryChannel(DeleteDeliveryChannelRequest request)
        {
            var marshaller = new DeleteDeliveryChannelRequestMarshaller();
            var unmarshaller = DeleteDeliveryChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteDeliveryChannelRequest,DeleteDeliveryChannelResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeliveryChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryChannel operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeliveryChannel
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDeliveryChannel(DeleteDeliveryChannelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDeliveryChannelRequestMarshaller();
            var unmarshaller = DeleteDeliveryChannelResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDeliveryChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeliveryChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeliveryChannel.</param>
        /// 
        /// <returns>Returns a  DeleteDeliveryChannelResult from ConfigService.</returns>
        public  DeleteDeliveryChannelResponse EndDeleteDeliveryChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeliveryChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeliverConfigSnapshot

        /// <summary>
        /// Schedules delivery of a configuration snapshot to the Amazon S3 bucket in the specified
        /// delivery channel. After the delivery has started, AWS Config sends following notifications
        /// using an Amazon SNS topic that you have specified.
        /// 
        ///  <ul> <li>Notification of starting the delivery.</li> <li>Notification of delivery
        /// completed, if the delivery was successfully completed.</li> <li>Notification of delivery
        /// failure, if the delivery failed to complete.</li> </ul>
        /// </summary>
        /// <param name="deliveryChannelName">The name of the delivery channel through which the snapshot is delivered.</param>
        /// 
        /// <returns>The response from the DeliverConfigSnapshot service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoRunningConfigurationRecorderException">
        /// There is no configuration recorder running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        public DeliverConfigSnapshotResponse DeliverConfigSnapshot(string deliveryChannelName)
        {
            var request = new DeliverConfigSnapshotRequest();
            request.DeliveryChannelName = deliveryChannelName;
            return DeliverConfigSnapshot(request);
        }


        /// <summary>
        /// Schedules delivery of a configuration snapshot to the Amazon S3 bucket in the specified
        /// delivery channel. After the delivery has started, AWS Config sends following notifications
        /// using an Amazon SNS topic that you have specified.
        /// 
        ///  <ul> <li>Notification of starting the delivery.</li> <li>Notification of delivery
        /// completed, if the delivery was successfully completed.</li> <li>Notification of delivery
        /// failure, if the delivery failed to complete.</li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeliverConfigSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeliverConfigSnapshot service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoRunningConfigurationRecorderException">
        /// There is no configuration recorder running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        public DeliverConfigSnapshotResponse DeliverConfigSnapshot(DeliverConfigSnapshotRequest request)
        {
            var marshaller = new DeliverConfigSnapshotRequestMarshaller();
            var unmarshaller = DeliverConfigSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeliverConfigSnapshotRequest,DeliverConfigSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeliverConfigSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeliverConfigSnapshot operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeliverConfigSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginDeliverConfigSnapshot(DeliverConfigSnapshotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeliverConfigSnapshotRequestMarshaller();
            var unmarshaller = DeliverConfigSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<DeliverConfigSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeliverConfigSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeliverConfigSnapshot.</param>
        /// 
        /// <returns>Returns a  DeliverConfigSnapshotResult from ConfigService.</returns>
        public  DeliverConfigSnapshotResponse EndDeliverConfigSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<DeliverConfigSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeComplianceByConfigRule

        /// <summary>
        /// Indicates whether the specified AWS Config rules are compliant. If a rule is noncompliant,
        /// this action returns the number of AWS resources that do not comply with the rule.
        /// 
        ///  
        /// <para>
        /// A rule is compliant if all of the evaluated resources comply with it, and it is noncompliant
        /// if any of these resources do not comply. 
        /// </para>
        ///  
        /// <para>
        /// If AWS Config has no current evaluation results for the rule, it returns <code>InsufficientData</code>.
        /// This result might indicate one of the following conditions: <ul> <li>AWS Config has
        /// never invoked an evaluation for the rule. To check whether it has, use the <code>DescribeConfigRuleEvaluationStatus</code>
        /// action to get the <code>LastSuccessfulInvocationTime</code> and <code>LastFailedInvocationTime</code>.</li>
        /// <li>The rule's AWS Lambda function is failing to send evaluation results to AWS Config.
        /// Verify that the role that you assigned to your configuration recorder includes the
        /// <code>config:PutEvaluations</code> permission. If the rule is a customer managed rule,
        /// verify that the AWS Lambda execution role includes the <code>config:PutEvaluations</code>
        /// permission.</li> <li>The rule's AWS Lambda function has returned <code>NOT_APPLICABLE</code>
        /// for all evaluation results. This can occur if the resources were deleted or removed
        /// from the rule's scope.</li></ul>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComplianceByConfigRule service method.</param>
        /// 
        /// <returns>The response from the DescribeComplianceByConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        public DescribeComplianceByConfigRuleResponse DescribeComplianceByConfigRule(DescribeComplianceByConfigRuleRequest request)
        {
            var marshaller = new DescribeComplianceByConfigRuleRequestMarshaller();
            var unmarshaller = DescribeComplianceByConfigRuleResponseUnmarshaller.Instance;

            return Invoke<DescribeComplianceByConfigRuleRequest,DescribeComplianceByConfigRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComplianceByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComplianceByConfigRule operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComplianceByConfigRule
        ///         operation.</returns>
        public IAsyncResult BeginDescribeComplianceByConfigRule(DescribeComplianceByConfigRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeComplianceByConfigRuleRequestMarshaller();
            var unmarshaller = DescribeComplianceByConfigRuleResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeComplianceByConfigRuleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComplianceByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComplianceByConfigRule.</param>
        /// 
        /// <returns>Returns a  DescribeComplianceByConfigRuleResult from ConfigService.</returns>
        public  DescribeComplianceByConfigRuleResponse EndDescribeComplianceByConfigRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeComplianceByConfigRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeComplianceByResource

        /// <summary>
        /// Indicates whether the specified AWS resources are compliant. If a resource is noncompliant,
        /// this action returns the number of AWS Config rules that the resource does not comply
        /// with. 
        /// 
        ///  
        /// <para>
        /// A resource is compliant if it complies with all the AWS Config rules that evaluate
        /// it. It is noncompliant if it does not comply with one or more of these rules.
        /// </para>
        ///  
        /// <para>
        /// If AWS Config has no current evaluation results for the resource, it returns <code>InsufficientData</code>.
        /// This result might indicate one of the following conditions about the rules that evaluate
        /// the resource: <ul> <li>AWS Config has never invoked an evaluation for the rule. To
        /// check whether it has, use the <code>DescribeConfigRuleEvaluationStatus</code> action
        /// to get the <code>LastSuccessfulInvocationTime</code> and <code>LastFailedInvocationTime</code>.</li>
        /// <li>The rule's AWS Lambda function is failing to send evaluation results to AWS Config.
        /// Verify that the role that you assigned to your configuration recorder includes the
        /// <code>config:PutEvaluations</code> permission. If the rule is a customer managed rule,
        /// verify that the AWS Lambda execution role includes the <code>config:PutEvaluations</code>
        /// permission.</li> <li>The rule's AWS Lambda function has returned <code>NOT_APPLICABLE</code>
        /// for all evaluation results. This can occur if the resources were deleted or removed
        /// from the rule's scope.</li></ul>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComplianceByResource service method.</param>
        /// 
        /// <returns>The response from the DescribeComplianceByResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        public DescribeComplianceByResourceResponse DescribeComplianceByResource(DescribeComplianceByResourceRequest request)
        {
            var marshaller = new DescribeComplianceByResourceRequestMarshaller();
            var unmarshaller = DescribeComplianceByResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeComplianceByResourceRequest,DescribeComplianceByResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComplianceByResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComplianceByResource operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComplianceByResource
        ///         operation.</returns>
        public IAsyncResult BeginDescribeComplianceByResource(DescribeComplianceByResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeComplianceByResourceRequestMarshaller();
            var unmarshaller = DescribeComplianceByResourceResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeComplianceByResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComplianceByResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComplianceByResource.</param>
        /// 
        /// <returns>Returns a  DescribeComplianceByResourceResult from ConfigService.</returns>
        public  DescribeComplianceByResourceResponse EndDescribeComplianceByResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeComplianceByResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConfigRuleEvaluationStatus

        /// <summary>
        /// Returns status information for each of your AWS managed Config rules. The status includes
        /// information such as the last time AWS Config invoked the rule, the last time AWS Config
        /// failed to invoke the rule, and the related error for the last failure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigRuleEvaluationStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigRuleEvaluationStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        public DescribeConfigRuleEvaluationStatusResponse DescribeConfigRuleEvaluationStatus(DescribeConfigRuleEvaluationStatusRequest request)
        {
            var marshaller = new DescribeConfigRuleEvaluationStatusRequestMarshaller();
            var unmarshaller = DescribeConfigRuleEvaluationStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigRuleEvaluationStatusRequest,DescribeConfigRuleEvaluationStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigRuleEvaluationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigRuleEvaluationStatus operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigRuleEvaluationStatus
        ///         operation.</returns>
        public IAsyncResult BeginDescribeConfigRuleEvaluationStatus(DescribeConfigRuleEvaluationStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeConfigRuleEvaluationStatusRequestMarshaller();
            var unmarshaller = DescribeConfigRuleEvaluationStatusResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeConfigRuleEvaluationStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigRuleEvaluationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigRuleEvaluationStatus.</param>
        /// 
        /// <returns>Returns a  DescribeConfigRuleEvaluationStatusResult from ConfigService.</returns>
        public  DescribeConfigRuleEvaluationStatusResponse EndDescribeConfigRuleEvaluationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigRuleEvaluationStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConfigRules

        /// <summary>
        /// Returns details about your AWS Config rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigRules service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigRules service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        public DescribeConfigRulesResponse DescribeConfigRules(DescribeConfigRulesRequest request)
        {
            var marshaller = new DescribeConfigRulesRequestMarshaller();
            var unmarshaller = DescribeConfigRulesResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigRulesRequest,DescribeConfigRulesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigRules operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigRules
        ///         operation.</returns>
        public IAsyncResult BeginDescribeConfigRules(DescribeConfigRulesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeConfigRulesRequestMarshaller();
            var unmarshaller = DescribeConfigRulesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeConfigRulesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigRules.</param>
        /// 
        /// <returns>Returns a  DescribeConfigRulesResult from ConfigService.</returns>
        public  DescribeConfigRulesResponse EndDescribeConfigRules(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConfigurationRecorders

        /// <summary>
        /// Returns the name of one or more specified configuration recorders. If the recorder
        /// name is not specified, this action returns the names of all the configuration recorders
        /// associated with the account. 
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per account.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorders service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        public DescribeConfigurationRecordersResponse DescribeConfigurationRecorders()
        {
            return DescribeConfigurationRecorders(new DescribeConfigurationRecordersRequest());
        }

        /// <summary>
        /// Returns the name of one or more specified configuration recorders. If the recorder
        /// name is not specified, this action returns the names of all the configuration recorders
        /// associated with the account. 
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorders service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorders service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        public DescribeConfigurationRecordersResponse DescribeConfigurationRecorders(DescribeConfigurationRecordersRequest request)
        {
            var marshaller = new DescribeConfigurationRecordersRequestMarshaller();
            var unmarshaller = DescribeConfigurationRecordersResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationRecordersRequest,DescribeConfigurationRecordersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationRecorders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorders operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationRecorders
        ///         operation.</returns>
        public IAsyncResult BeginDescribeConfigurationRecorders(DescribeConfigurationRecordersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeConfigurationRecordersRequestMarshaller();
            var unmarshaller = DescribeConfigurationRecordersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeConfigurationRecordersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationRecorders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationRecorders.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationRecordersResult from ConfigService.</returns>
        public  DescribeConfigurationRecordersResponse EndDescribeConfigurationRecorders(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigurationRecordersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConfigurationRecorderStatus

        /// <summary>
        /// Returns the current status of the specified configuration recorder. If a configuration
        /// recorder is not specified, this action returns the status of all configuration recorder
        /// associated with the account.
        /// 
        ///  <note>Currently, you can specify only one configuration recorder per account.</note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorderStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        public DescribeConfigurationRecorderStatusResponse DescribeConfigurationRecorderStatus()
        {
            return DescribeConfigurationRecorderStatus(new DescribeConfigurationRecorderStatusRequest());
        }

        /// <summary>
        /// Returns the current status of the specified configuration recorder. If a configuration
        /// recorder is not specified, this action returns the status of all configuration recorder
        /// associated with the account.
        /// 
        ///  <note>Currently, you can specify only one configuration recorder per account.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorderStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorderStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        public DescribeConfigurationRecorderStatusResponse DescribeConfigurationRecorderStatus(DescribeConfigurationRecorderStatusRequest request)
        {
            var marshaller = new DescribeConfigurationRecorderStatusRequestMarshaller();
            var unmarshaller = DescribeConfigurationRecorderStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationRecorderStatusRequest,DescribeConfigurationRecorderStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationRecorderStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorderStatus operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationRecorderStatus
        ///         operation.</returns>
        public IAsyncResult BeginDescribeConfigurationRecorderStatus(DescribeConfigurationRecorderStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeConfigurationRecorderStatusRequestMarshaller();
            var unmarshaller = DescribeConfigurationRecorderStatusResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeConfigurationRecorderStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationRecorderStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationRecorderStatus.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationRecorderStatusResult from ConfigService.</returns>
        public  DescribeConfigurationRecorderStatusResponse EndDescribeConfigurationRecorderStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigurationRecorderStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDeliveryChannels

        /// <summary>
        /// Returns details about the specified delivery channel. If a delivery channel is not
        /// specified, this action returns the details of all delivery channels associated with
        /// the account. 
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per account.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDeliveryChannels service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        public DescribeDeliveryChannelsResponse DescribeDeliveryChannels()
        {
            return DescribeDeliveryChannels(new DescribeDeliveryChannelsRequest());
        }

        /// <summary>
        /// Returns details about the specified delivery channel. If a delivery channel is not
        /// specified, this action returns the details of all delivery channels associated with
        /// the account. 
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannels service method.</param>
        /// 
        /// <returns>The response from the DescribeDeliveryChannels service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        public DescribeDeliveryChannelsResponse DescribeDeliveryChannels(DescribeDeliveryChannelsRequest request)
        {
            var marshaller = new DescribeDeliveryChannelsRequestMarshaller();
            var unmarshaller = DescribeDeliveryChannelsResponseUnmarshaller.Instance;

            return Invoke<DescribeDeliveryChannelsRequest,DescribeDeliveryChannelsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeliveryChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannels operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeliveryChannels
        ///         operation.</returns>
        public IAsyncResult BeginDescribeDeliveryChannels(DescribeDeliveryChannelsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeDeliveryChannelsRequestMarshaller();
            var unmarshaller = DescribeDeliveryChannelsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDeliveryChannelsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeliveryChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeliveryChannels.</param>
        /// 
        /// <returns>Returns a  DescribeDeliveryChannelsResult from ConfigService.</returns>
        public  DescribeDeliveryChannelsResponse EndDescribeDeliveryChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDeliveryChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDeliveryChannelStatus

        /// <summary>
        /// Returns the current status of the specified delivery channel. If a delivery channel
        /// is not specified, this action returns the current status of all delivery channels
        /// associated with the account. 
        /// 
        ///  <note>Currently, you can specify only one delivery channel per account.</note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDeliveryChannelStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        public DescribeDeliveryChannelStatusResponse DescribeDeliveryChannelStatus()
        {
            return DescribeDeliveryChannelStatus(new DescribeDeliveryChannelStatusRequest());
        }

        /// <summary>
        /// Returns the current status of the specified delivery channel. If a delivery channel
        /// is not specified, this action returns the current status of all delivery channels
        /// associated with the account. 
        /// 
        ///  <note>Currently, you can specify only one delivery channel per account.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannelStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeDeliveryChannelStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        public DescribeDeliveryChannelStatusResponse DescribeDeliveryChannelStatus(DescribeDeliveryChannelStatusRequest request)
        {
            var marshaller = new DescribeDeliveryChannelStatusRequestMarshaller();
            var unmarshaller = DescribeDeliveryChannelStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeDeliveryChannelStatusRequest,DescribeDeliveryChannelStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeliveryChannelStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannelStatus operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeliveryChannelStatus
        ///         operation.</returns>
        public IAsyncResult BeginDescribeDeliveryChannelStatus(DescribeDeliveryChannelStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeDeliveryChannelStatusRequestMarshaller();
            var unmarshaller = DescribeDeliveryChannelStatusResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDeliveryChannelStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeliveryChannelStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeliveryChannelStatus.</param>
        /// 
        /// <returns>Returns a  DescribeDeliveryChannelStatusResult from ConfigService.</returns>
        public  DescribeDeliveryChannelStatusResponse EndDescribeDeliveryChannelStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDeliveryChannelStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComplianceDetailsByConfigRule

        /// <summary>
        /// Returns the evaluation results for the specified AWS Config rule. The results indicate
        /// which AWS resources were evaluated by the rule, when each resource was last evaluated,
        /// and whether each resource complies with the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetailsByConfigRule service method.</param>
        /// 
        /// <returns>The response from the GetComplianceDetailsByConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        public GetComplianceDetailsByConfigRuleResponse GetComplianceDetailsByConfigRule(GetComplianceDetailsByConfigRuleRequest request)
        {
            var marshaller = new GetComplianceDetailsByConfigRuleRequestMarshaller();
            var unmarshaller = GetComplianceDetailsByConfigRuleResponseUnmarshaller.Instance;

            return Invoke<GetComplianceDetailsByConfigRuleRequest,GetComplianceDetailsByConfigRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComplianceDetailsByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetailsByConfigRule operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComplianceDetailsByConfigRule
        ///         operation.</returns>
        public IAsyncResult BeginGetComplianceDetailsByConfigRule(GetComplianceDetailsByConfigRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetComplianceDetailsByConfigRuleRequestMarshaller();
            var unmarshaller = GetComplianceDetailsByConfigRuleResponseUnmarshaller.Instance;

            return BeginInvoke<GetComplianceDetailsByConfigRuleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComplianceDetailsByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComplianceDetailsByConfigRule.</param>
        /// 
        /// <returns>Returns a  GetComplianceDetailsByConfigRuleResult from ConfigService.</returns>
        public  GetComplianceDetailsByConfigRuleResponse EndGetComplianceDetailsByConfigRule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComplianceDetailsByConfigRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComplianceDetailsByResource

        /// <summary>
        /// Returns the evaluation results for the specified AWS resource. The results indicate
        /// which AWS Config rules were used to evaluate the resource, when each rule was last
        /// used, and whether the resource complies with each rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetailsByResource service method.</param>
        /// 
        /// <returns>The response from the GetComplianceDetailsByResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        public GetComplianceDetailsByResourceResponse GetComplianceDetailsByResource(GetComplianceDetailsByResourceRequest request)
        {
            var marshaller = new GetComplianceDetailsByResourceRequestMarshaller();
            var unmarshaller = GetComplianceDetailsByResourceResponseUnmarshaller.Instance;

            return Invoke<GetComplianceDetailsByResourceRequest,GetComplianceDetailsByResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComplianceDetailsByResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetailsByResource operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComplianceDetailsByResource
        ///         operation.</returns>
        public IAsyncResult BeginGetComplianceDetailsByResource(GetComplianceDetailsByResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetComplianceDetailsByResourceRequestMarshaller();
            var unmarshaller = GetComplianceDetailsByResourceResponseUnmarshaller.Instance;

            return BeginInvoke<GetComplianceDetailsByResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComplianceDetailsByResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComplianceDetailsByResource.</param>
        /// 
        /// <returns>Returns a  GetComplianceDetailsByResourceResult from ConfigService.</returns>
        public  GetComplianceDetailsByResourceResponse EndGetComplianceDetailsByResource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComplianceDetailsByResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComplianceSummaryByConfigRule

        /// <summary>
        /// Returns the number of AWS Config rules that are compliant and noncompliant, up to
        /// a maximum of 25 for each.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummaryByConfigRule service method.</param>
        /// 
        /// <returns>The response from the GetComplianceSummaryByConfigRule service method, as returned by ConfigService.</returns>
        public GetComplianceSummaryByConfigRuleResponse GetComplianceSummaryByConfigRule(GetComplianceSummaryByConfigRuleRequest request)
        {
            var marshaller = new GetComplianceSummaryByConfigRuleRequestMarshaller();
            var unmarshaller = GetComplianceSummaryByConfigRuleResponseUnmarshaller.Instance;

            return Invoke<GetComplianceSummaryByConfigRuleRequest,GetComplianceSummaryByConfigRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComplianceSummaryByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummaryByConfigRule operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComplianceSummaryByConfigRule
        ///         operation.</returns>
        public IAsyncResult BeginGetComplianceSummaryByConfigRule(GetComplianceSummaryByConfigRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetComplianceSummaryByConfigRuleRequestMarshaller();
            var unmarshaller = GetComplianceSummaryByConfigRuleResponseUnmarshaller.Instance;

            return BeginInvoke<GetComplianceSummaryByConfigRuleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComplianceSummaryByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComplianceSummaryByConfigRule.</param>
        /// 
        /// <returns>Returns a  GetComplianceSummaryByConfigRuleResult from ConfigService.</returns>
        public  GetComplianceSummaryByConfigRuleResponse EndGetComplianceSummaryByConfigRule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComplianceSummaryByConfigRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComplianceSummaryByResourceType

        /// <summary>
        /// Returns the number of resources that are compliant and the number that are noncompliant.
        /// You can specify one or more resource types to get these numbers for each resource
        /// type. The maximum number returned is 100.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummaryByResourceType service method.</param>
        /// 
        /// <returns>The response from the GetComplianceSummaryByResourceType service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        public GetComplianceSummaryByResourceTypeResponse GetComplianceSummaryByResourceType(GetComplianceSummaryByResourceTypeRequest request)
        {
            var marshaller = new GetComplianceSummaryByResourceTypeRequestMarshaller();
            var unmarshaller = GetComplianceSummaryByResourceTypeResponseUnmarshaller.Instance;

            return Invoke<GetComplianceSummaryByResourceTypeRequest,GetComplianceSummaryByResourceTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComplianceSummaryByResourceType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummaryByResourceType operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComplianceSummaryByResourceType
        ///         operation.</returns>
        public IAsyncResult BeginGetComplianceSummaryByResourceType(GetComplianceSummaryByResourceTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetComplianceSummaryByResourceTypeRequestMarshaller();
            var unmarshaller = GetComplianceSummaryByResourceTypeResponseUnmarshaller.Instance;

            return BeginInvoke<GetComplianceSummaryByResourceTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComplianceSummaryByResourceType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComplianceSummaryByResourceType.</param>
        /// 
        /// <returns>Returns a  GetComplianceSummaryByResourceTypeResult from ConfigService.</returns>
        public  GetComplianceSummaryByResourceTypeResponse EndGetComplianceSummaryByResourceType(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComplianceSummaryByResourceTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourceConfigHistory

        /// <summary>
        /// Returns a list of configuration items for the specified resource. The list contains
        /// details about each state of the resource during the specified time interval.
        /// 
        ///  
        /// <para>
        /// The response is paginated, and by default, AWS Config returns a limit of 10 configuration
        /// items per page. You can customize this number with the <code>limit</code> parameter.
        /// The response includes a <code>nextToken</code> string, and to get the next page of
        /// results, run the request again and enter this string for the <code>nextToken</code>
        /// parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// Each call to the API is limited to span a duration of seven days. It is likely that
        /// the number of records returned is smaller than the specified <code>limit</code>. In
        /// such cases, you can make another call, using the <code>nextToken</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceConfigHistory service method.</param>
        /// 
        /// <returns>The response from the GetResourceConfigHistory service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidTimeRangeException">
        /// The specified time range is not valid. The earlier time is not chronologically before
        /// the later time.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotDiscoveredException">
        /// You have specified a resource that is either unknown or has not been discovered.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        public GetResourceConfigHistoryResponse GetResourceConfigHistory(GetResourceConfigHistoryRequest request)
        {
            var marshaller = new GetResourceConfigHistoryRequestMarshaller();
            var unmarshaller = GetResourceConfigHistoryResponseUnmarshaller.Instance;

            return Invoke<GetResourceConfigHistoryRequest,GetResourceConfigHistoryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceConfigHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceConfigHistory operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceConfigHistory
        ///         operation.</returns>
        public IAsyncResult BeginGetResourceConfigHistory(GetResourceConfigHistoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetResourceConfigHistoryRequestMarshaller();
            var unmarshaller = GetResourceConfigHistoryResponseUnmarshaller.Instance;

            return BeginInvoke<GetResourceConfigHistoryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceConfigHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceConfigHistory.</param>
        /// 
        /// <returns>Returns a  GetResourceConfigHistoryResult from ConfigService.</returns>
        public  GetResourceConfigHistoryResponse EndGetResourceConfigHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceConfigHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDiscoveredResources

        /// <summary>
        /// Accepts a resource type and returns a list of resource identifiers for the resources
        /// of that type. A resource identifier includes the resource type, ID, and (if available)
        /// the custom resource name. The results consist of resources that AWS Config has discovered,
        /// including those that AWS Config is not currently recording. You can narrow the results
        /// to include only resources that have specific resource IDs or a resource name.
        /// 
        ///  <note>You can specify either resource IDs or a resource name but not both in the
        /// same request.</note> 
        /// <para>
        /// The response is paginated, and by default AWS Config lists 100 resource identifiers
        /// on each page. You can customize this number with the <code>limit</code> parameter.
        /// The response includes a <code>nextToken</code> string, and to get the next page of
        /// results, run the request again and enter this string for the <code>nextToken</code>
        /// parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources service method.</param>
        /// 
        /// <returns>The response from the ListDiscoveredResources service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        public ListDiscoveredResourcesResponse ListDiscoveredResources(ListDiscoveredResourcesRequest request)
        {
            var marshaller = new ListDiscoveredResourcesRequestMarshaller();
            var unmarshaller = ListDiscoveredResourcesResponseUnmarshaller.Instance;

            return Invoke<ListDiscoveredResourcesRequest,ListDiscoveredResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDiscoveredResources
        ///         operation.</returns>
        public IAsyncResult BeginListDiscoveredResources(ListDiscoveredResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDiscoveredResourcesRequestMarshaller();
            var unmarshaller = ListDiscoveredResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<ListDiscoveredResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDiscoveredResources.</param>
        /// 
        /// <returns>Returns a  ListDiscoveredResourcesResult from ConfigService.</returns>
        public  ListDiscoveredResourcesResponse EndListDiscoveredResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDiscoveredResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutConfigRule

        /// <summary>
        /// Adds or updates an AWS Config rule for evaluating whether your AWS resources comply
        /// with your desired configurations. 
        /// 
        ///  
        /// <para>
        /// You can use this action for customer managed Config rules and AWS managed Config rules.
        /// A customer managed Config rule is a custom rule that you develop and maintain. An
        /// AWS managed Config rule is a customizable, predefined rule that is provided by AWS
        /// Config.
        /// </para>
        ///  
        /// <para>
        /// If you are adding a new customer managed Config rule, you must first create the AWS
        /// Lambda function that the rule invokes to evaluate your resources. When you use the
        /// <code>PutConfigRule</code> action to add the rule to AWS Config, you must specify
        /// the Amazon Resource Name (ARN) that AWS Lambda assigns to the function. Specify the
        /// ARN for the <code>SourceIdentifier</code> key. This key is part of the <code>Source</code>
        /// object, which is part of the <code>ConfigRule</code> object. 
        /// </para>
        ///  
        /// <para>
        /// If you are adding a new AWS managed Config rule, specify the rule's identifier for
        /// the <code>SourceIdentifier</code> key. To reference AWS managed Config rule identifiers,
        /// see <a href="http://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_use-managed-rules.html">Using
        /// AWS Managed Config Rules</a>.
        /// </para>
        ///  
        /// <para>
        /// For any new rule that you add, specify the <code>ConfigRuleName</code> in the <code>ConfigRule</code>
        /// object. Do not specify the <code>ConfigRuleArn</code> or the <code>ConfigRuleId</code>.
        /// These values are generated by AWS Config for new rules.
        /// </para>
        ///  
        /// <para>
        /// If you are updating a rule that you have added previously, specify the rule's <code>ConfigRuleName</code>,
        /// <code>ConfigRuleId</code>, or <code>ConfigRuleArn</code> in the <code>ConfigRule</code>
        /// data type that you use in this request.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of rules that AWS Config supports is 25.
        /// </para>
        ///  
        /// <para>
        /// For more information about developing and using AWS Config rules, see <a href="http://docs.aws.amazon.com/config/latest/developerguide/evaluate-config.html">Evaluating
        /// AWS Resource Configurations with AWS Config</a> in the <i>AWS Config Developer Guide</i>.
        /// </para>
        ///  <p/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigRule service method.</param>
        /// 
        /// <returns>The response from the PutConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfConfigRulesExceededException">
        /// Failed to add the AWS Config rule because the account already contains the maximum
        /// number of 25 rules. Consider deleting any deactivated rules before adding new rules.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// The rule is currently being deleted. Wait for a while and try again.
        /// </exception>
        public PutConfigRuleResponse PutConfigRule(PutConfigRuleRequest request)
        {
            var marshaller = new PutConfigRuleRequestMarshaller();
            var unmarshaller = PutConfigRuleResponseUnmarshaller.Instance;

            return Invoke<PutConfigRuleRequest,PutConfigRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigRule operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigRule
        ///         operation.</returns>
        public IAsyncResult BeginPutConfigRule(PutConfigRuleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutConfigRuleRequestMarshaller();
            var unmarshaller = PutConfigRuleResponseUnmarshaller.Instance;

            return BeginInvoke<PutConfigRuleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigRule.</param>
        /// 
        /// <returns>Returns a  PutConfigRuleResult from ConfigService.</returns>
        public  PutConfigRuleResponse EndPutConfigRule(IAsyncResult asyncResult)
        {
            return EndInvoke<PutConfigRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  PutConfigurationRecorder

        /// <summary>
        /// Creates a new configuration recorder to record the selected resource configurations.
        /// 
        ///  
        /// <para>
        /// You can use this action to change the role <code>roleARN</code> and/or the <code>recordingGroup</code>
        /// of an existing recorder. To change the role, call the action on the existing configuration
        /// recorder and specify a role.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per account.
        /// </para>
        ///  
        /// <para>
        /// If <code>ConfigurationRecorder</code> does not have the <b>recordingGroup</b> parameter
        /// specified, the default is to record all supported resource types.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationRecorder service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidConfigurationRecorderNameException">
        /// You have provided a configuration recorder name that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidRecordingGroupException">
        /// AWS Config throws an exception if the recording group does not contain a valid list
        /// of resource types. Invalid values could also be incorrectly formatted.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidRoleException">
        /// You have provided a null or empty role ARN.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfConfigurationRecordersExceededException">
        /// You have reached the limit on the number of recorders you can create.
        /// </exception>
        public PutConfigurationRecorderResponse PutConfigurationRecorder(PutConfigurationRecorderRequest request)
        {
            var marshaller = new PutConfigurationRecorderRequestMarshaller();
            var unmarshaller = PutConfigurationRecorderResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationRecorderRequest,PutConfigurationRecorderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationRecorder operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigurationRecorder
        ///         operation.</returns>
        public IAsyncResult BeginPutConfigurationRecorder(PutConfigurationRecorderRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutConfigurationRecorderRequestMarshaller();
            var unmarshaller = PutConfigurationRecorderResponseUnmarshaller.Instance;

            return BeginInvoke<PutConfigurationRecorderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigurationRecorder.</param>
        /// 
        /// <returns>Returns a  PutConfigurationRecorderResult from ConfigService.</returns>
        public  PutConfigurationRecorderResponse EndPutConfigurationRecorder(IAsyncResult asyncResult)
        {
            return EndInvoke<PutConfigurationRecorderResponse>(asyncResult);
        }

        #endregion
        
        #region  PutDeliveryChannel

        /// <summary>
        /// Creates a new delivery channel object to deliver the configuration information to
        /// an Amazon S3 bucket, and to an Amazon SNS topic. 
        /// 
        ///  
        /// <para>
        /// You can use this action to change the Amazon S3 bucket or an Amazon SNS topic of the
        /// existing delivery channel. To change the Amazon S3 bucket or an Amazon SNS topic,
        /// call this action and specify the changed values for the S3 bucket and the SNS topic.
        /// If you specify a different value for either the S3 bucket or the SNS topic, this action
        /// will keep the existing value for the parameter that is not changed. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliveryChannel service method.</param>
        /// 
        /// <returns>The response from the PutDeliveryChannel service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientDeliveryPolicyException">
        /// Your Amazon S3 bucket policy does not permit AWS Config to write to it.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidDeliveryChannelNameException">
        /// The specified delivery channel name is not valid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidS3KeyPrefixException">
        /// The specified Amazon S3 key prefix is not valid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidSNSTopicARNException">
        /// The specified Amazon SNS topic does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfDeliveryChannelsExceededException">
        /// You have reached the limit on the number of delivery channels you can create.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchBucketException">
        /// The specified Amazon S3 bucket does not exist.
        /// </exception>
        public PutDeliveryChannelResponse PutDeliveryChannel(PutDeliveryChannelRequest request)
        {
            var marshaller = new PutDeliveryChannelRequestMarshaller();
            var unmarshaller = PutDeliveryChannelResponseUnmarshaller.Instance;

            return Invoke<PutDeliveryChannelRequest,PutDeliveryChannelResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDeliveryChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDeliveryChannel operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDeliveryChannel
        ///         operation.</returns>
        public IAsyncResult BeginPutDeliveryChannel(PutDeliveryChannelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutDeliveryChannelRequestMarshaller();
            var unmarshaller = PutDeliveryChannelResponseUnmarshaller.Instance;

            return BeginInvoke<PutDeliveryChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDeliveryChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDeliveryChannel.</param>
        /// 
        /// <returns>Returns a  PutDeliveryChannelResult from ConfigService.</returns>
        public  PutDeliveryChannelResponse EndPutDeliveryChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDeliveryChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  PutEvaluations

        /// <summary>
        /// Used by an AWS Lambda function to deliver evaluation results to AWS Config. This action
        /// is required in every AWS Lambda function that is invoked by an AWS Config rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvaluations service method.</param>
        /// 
        /// <returns>The response from the PutEvaluations service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidResultTokenException">
        /// The result token is invalid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        public PutEvaluationsResponse PutEvaluations(PutEvaluationsRequest request)
        {
            var marshaller = new PutEvaluationsRequestMarshaller();
            var unmarshaller = PutEvaluationsResponseUnmarshaller.Instance;

            return Invoke<PutEvaluationsRequest,PutEvaluationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutEvaluations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEvaluations operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEvaluations
        ///         operation.</returns>
        public IAsyncResult BeginPutEvaluations(PutEvaluationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutEvaluationsRequestMarshaller();
            var unmarshaller = PutEvaluationsResponseUnmarshaller.Instance;

            return BeginInvoke<PutEvaluationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutEvaluations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEvaluations.</param>
        /// 
        /// <returns>Returns a  PutEvaluationsResult from ConfigService.</returns>
        public  PutEvaluationsResponse EndPutEvaluations(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEvaluationsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartConfigurationRecorder

        /// <summary>
        /// Starts recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// 
        ///  
        /// <para>
        /// You must have created at least one delivery channel to successfully start the configuration
        /// recorder.
        /// </para>
        /// </summary>
        /// <param name="configurationRecorderName">The name of the recorder object that records each configuration change made to the resources.</param>
        /// 
        /// <returns>The response from the StartConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableDeliveryChannelException">
        /// There is no delivery channel available to record configurations.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        public StartConfigurationRecorderResponse StartConfigurationRecorder(string configurationRecorderName)
        {
            var request = new StartConfigurationRecorderRequest();
            request.ConfigurationRecorderName = configurationRecorderName;
            return StartConfigurationRecorder(request);
        }


        /// <summary>
        /// Starts recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// 
        ///  
        /// <para>
        /// You must have created at least one delivery channel to successfully start the configuration
        /// recorder.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationRecorder service method.</param>
        /// 
        /// <returns>The response from the StartConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableDeliveryChannelException">
        /// There is no delivery channel available to record configurations.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        public StartConfigurationRecorderResponse StartConfigurationRecorder(StartConfigurationRecorderRequest request)
        {
            var marshaller = new StartConfigurationRecorderRequestMarshaller();
            var unmarshaller = StartConfigurationRecorderResponseUnmarshaller.Instance;

            return Invoke<StartConfigurationRecorderRequest,StartConfigurationRecorderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationRecorder operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartConfigurationRecorder
        ///         operation.</returns>
        public IAsyncResult BeginStartConfigurationRecorder(StartConfigurationRecorderRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StartConfigurationRecorderRequestMarshaller();
            var unmarshaller = StartConfigurationRecorderResponseUnmarshaller.Instance;

            return BeginInvoke<StartConfigurationRecorderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartConfigurationRecorder.</param>
        /// 
        /// <returns>Returns a  StartConfigurationRecorderResult from ConfigService.</returns>
        public  StartConfigurationRecorderResponse EndStartConfigurationRecorder(IAsyncResult asyncResult)
        {
            return EndInvoke<StartConfigurationRecorderResponse>(asyncResult);
        }

        #endregion
        
        #region  StopConfigurationRecorder

        /// <summary>
        /// Stops recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// </summary>
        /// <param name="configurationRecorderName">The name of the recorder object that records each configuration change made to the resources.</param>
        /// 
        /// <returns>The response from the StopConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        public StopConfigurationRecorderResponse StopConfigurationRecorder(string configurationRecorderName)
        {
            var request = new StopConfigurationRecorderRequest();
            request.ConfigurationRecorderName = configurationRecorderName;
            return StopConfigurationRecorder(request);
        }


        /// <summary>
        /// Stops recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopConfigurationRecorder service method.</param>
        /// 
        /// <returns>The response from the StopConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        public StopConfigurationRecorderResponse StopConfigurationRecorder(StopConfigurationRecorderRequest request)
        {
            var marshaller = new StopConfigurationRecorderRequestMarshaller();
            var unmarshaller = StopConfigurationRecorderResponseUnmarshaller.Instance;

            return Invoke<StopConfigurationRecorderRequest,StopConfigurationRecorderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopConfigurationRecorder operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopConfigurationRecorder
        ///         operation.</returns>
        public IAsyncResult BeginStopConfigurationRecorder(StopConfigurationRecorderRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StopConfigurationRecorderRequestMarshaller();
            var unmarshaller = StopConfigurationRecorderResponseUnmarshaller.Instance;

            return BeginInvoke<StopConfigurationRecorderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopConfigurationRecorder.</param>
        /// 
        /// <returns>Returns a  StopConfigurationRecorderResult from ConfigService.</returns>
        public  StopConfigurationRecorderResponse EndStopConfigurationRecorder(IAsyncResult asyncResult)
        {
            return EndInvoke<StopConfigurationRecorderResponse>(asyncResult);
        }

        #endregion
        
    }
}