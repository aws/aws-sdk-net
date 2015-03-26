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
 * Do not modify this file. This file is generated from the config-2014-10-17.normal.json service model.
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
    /// see <a href="http://docs.aws.amazon.com/config/latest/developerguide/config-concepts.html">Supported
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

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
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
        /// your resources.
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
        /// your resources.
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
        /// </note>
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
        /// </note>
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
        
        #region  GetResourceConfigHistory

        /// <summary>
        /// Returns a list of configuration items for the specified resource. The list contains
        /// details about each state of the resource during the specified time interval. You can
        /// specify a <code>limit</code> on the number of results returned on the page. If a limit
        /// is specified, a <code>nextToken</code> is returned as part of the result that you
        /// can use to continue this request. 
        /// 
        ///  <note> 
        /// <para>
        /// Each call to the API is limited to span a duration of seven days. It is likely that
        /// the number of records returned is smaller than the specified <code>limit</code>. In
        /// such cases, you can make another call, using the <code>nextToken</code> .
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceConfigHistory service method.</param>
        /// 
        /// <returns>The response from the GetResourceConfigHistory service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// You have reached the limit on the pagination.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified nextToken for pagination is not valid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidTimeRangeException">
        /// The specified time range is not valid. The earlier time is not chronologically before
        /// the later time.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources.
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
        
        #region  PutConfigurationRecorder

        /// <summary>
        /// Creates a new configuration recorder to record the resource configurations. 
        /// 
        ///  
        /// <para>
        /// You can use this action to change the role (<code>roleARN</code>) of an existing recorder.
        /// To change the role, call the action on the existing configuration recorder and specify
        /// a role.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per account. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationRecorder service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidConfigurationRecorderNameException">
        /// You have provided a configuration recorder name that is not valid.
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
        /// your resources.
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
        
        #region  StartConfigurationRecorder

        /// <summary>
        /// Starts recording configurations of all the resources associated with the account.
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
        /// Starts recording configurations of all the resources associated with the account.
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
        /// Stops recording configurations of all the resources associated with the account.
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
        /// Stops recording configurations of all the resources associated with the account.
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