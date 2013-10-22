/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;

using Amazon.CloudWatch.Model;
using Amazon.CloudWatch.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.CloudWatch
{
    /// <summary>
    /// Implementation for accessing AmazonCloudWatch.
    ///  
    /// Amazon CloudWatch <para>This is the <i>Amazon CloudWatch API Reference</i> . This guide provides detailed information about Amazon
    /// CloudWatch actions, data types, parameters, and errors. For detailed information about Amazon CloudWatch features and their associated API
    /// calls, go to the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide" >Amazon CloudWatch Developer Guide</a> .
    /// </para> <para>Amazon CloudWatch is a web service that enables you to publish, monitor, and manage various metrics, as well as configure
    /// alarm actions based on data from metrics. For more information about this product go to <a href="http://aws.amazon.com/cloudwatch"
    /// >http://aws.amazon.com/cloudwatch</a> .
    /// </para> <para> For information about the namespace, metric names, and dimensions that other Amazon Web Services products use to send
    /// metrics to Cloudwatch, go to <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CW_Support_For_AWS.html" >Amazon
    /// CloudWatch Metrics, Namespaces, and Dimensions Reference</a> in the <i>Amazon CloudWatch Developer Guide</i> .
    /// </para> <para>Use the following links to get started using the <i>Amazon CloudWatch API Reference</i> :</para>
    /// <ul>
    /// <li> <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_Operations.html" >Actions</a> : An alphabetical list of
    /// all Amazon CloudWatch actions.</li>
    /// <li> <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_Types.html" >Data Types</a> : An alphabetical list of all
    /// Amazon CloudWatch data types.</li>
    /// <li> <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/CommonParameters.html" >Common Parameters</a> : Parameters
    /// that all Query actions can use.</li>
    /// <li> <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/CommonErrors.html" >Common Errors</a> : Client and server
    /// errors that all actions can return.</li>
    /// <li> <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html" >Regions and Endpoints</a> : Itemized regions and
    /// endpoints for all AWS products.</li>
    /// <li> <a href="http://monitoring.amazonaws.com/doc/2010-08-01/CloudWatch.wsdl" >WSDL Location</a> :
    /// http://monitoring.amazonaws.com/doc/2010-08-01/CloudWatch.wsdl</li>
    /// 
    /// </ul>
    /// <para>In addition to using the Amazon CloudWatch API, you can also use the following SDKs and third-party libraries to access Amazon
    /// CloudWatch programmatically.</para>
    /// <ul>
    /// <li> <a href="http://aws.amazon.com/documentation/sdkforjava/" >AWS SDK for Java Documentation</a> </li>
    /// <li> <a href="http://aws.amazon.com/documentation/sdkfornet/" >AWS SDK for .NET Documentation</a> </li>
    /// <li> <a href="http://aws.amazon.com/documentation/sdkforphp/" >AWS SDK for PHP Documentation</a> </li>
    /// <li> <a href="http://aws.amazon.com/documentation/sdkforruby/" >AWS SDK for Ruby Documentation</a> </li>
    /// 
    /// </ul>
    /// <para>Developers in the AWS developer community also provide their own libraries, which you can find at the following AWS developer
    /// centers:</para>
    /// <ul>
    /// <li> <a href="http://aws.amazon.com/java/" >AWS Java Developer Center</a> </li>
    /// <li> <a href="http://aws.amazon.com/php/" >AWS PHP Developer Center</a> </li>
    /// <li> <a href="http://aws.amazon.com/python/" >AWS Python Developer Center</a> </li>
    /// <li> <a href="http://aws.amazon.com/ruby/" >AWS Ruby Developer Center</a> </li>
    /// <li> <a href="http://aws.amazon.com/net/" >AWS Windows and .NET Developer Center</a> </li>
    /// 
    /// </ul>
    /// </summary>
    public partial class AmazonCloudWatchClient : AmazonWebServiceClient, IAmazonCloudWatch
    {
    AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCloudWatchClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCloudWatch Configuration Object</param>
        public AmazonCloudWatchClient(AmazonCloudWatchConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudWatchClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudWatchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudWatchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Credentials and an
        /// AmazonCloudWatchClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(AWSCredentials credentials, AmazonCloudWatchConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudWatchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudWatchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion


        #region DeleteAlarms

        /// <summary>
        /// <para> Deletes all specified alarms. In the event of an error, no alarms are deleted. </para>
        /// </summary>
        /// 
        /// <param name="deleteAlarmsRequest">Container for the necessary parameters to execute the DeleteAlarms service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        public DeleteAlarmsResponse DeleteAlarms(DeleteAlarmsRequest deleteAlarmsRequest)
        {
            IAsyncResult asyncResult = invokeDeleteAlarms(deleteAlarmsRequest, null, null, true);
            return EndDeleteAlarms(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DeleteAlarms"/>
        /// </summary>
        /// 
        /// <param name="deleteAlarmsRequest">Container for the necessary parameters to execute the DeleteAlarms operation on AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteAlarms(DeleteAlarmsRequest deleteAlarmsRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteAlarms(deleteAlarmsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DeleteAlarms"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlarms.</param>
        public DeleteAlarmsResponse EndDeleteAlarms(IAsyncResult asyncResult)
        {
            return endOperation<DeleteAlarmsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteAlarms(DeleteAlarmsRequest deleteAlarmsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteAlarmsRequestMarshaller().Marshall(deleteAlarmsRequest);
            var unmarshaller = DeleteAlarmsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeAlarmHistory

        /// <summary>
        /// <para> Retrieves history for the specified alarm. Filter alarms by date range or item type. If an alarm name is not specified, Amazon
        /// CloudWatch returns histories for all of the owner's alarms. </para> <para><b>NOTE:</b> Amazon CloudWatch retains the history of an alarm for
        /// two weeks, whether or not you delete the alarm. </para>
        /// </summary>
        /// 
        /// <param name="describeAlarmHistoryRequest">Container for the necessary parameters to execute the DescribeAlarmHistory service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeAlarmHistoryResponse DescribeAlarmHistory(DescribeAlarmHistoryRequest describeAlarmHistoryRequest)
        {
            IAsyncResult asyncResult = invokeDescribeAlarmHistory(describeAlarmHistoryRequest, null, null, true);
            return EndDescribeAlarmHistory(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmHistory operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DescribeAlarmHistory"/>
        /// </summary>
        /// 
        /// <param name="describeAlarmHistoryRequest">Container for the necessary parameters to execute the DescribeAlarmHistory operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAlarmHistory operation.</returns>
        public IAsyncResult BeginDescribeAlarmHistory(DescribeAlarmHistoryRequest describeAlarmHistoryRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeAlarmHistory(describeAlarmHistoryRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAlarmHistory operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DescribeAlarmHistory"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarmHistory.</param>
        /// 
        /// <returns>Returns a DescribeAlarmHistoryResult from AmazonCloudWatch.</returns>
        public DescribeAlarmHistoryResponse EndDescribeAlarmHistory(IAsyncResult asyncResult)
        {
            return endOperation<DescribeAlarmHistoryResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeAlarmHistory(DescribeAlarmHistoryRequest describeAlarmHistoryRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAlarmHistoryRequestMarshaller().Marshall(describeAlarmHistoryRequest);
            var unmarshaller = DescribeAlarmHistoryResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Retrieves history for the specified alarm. Filter alarms by date range or item type. If an alarm name is not specified, Amazon
        /// CloudWatch returns histories for all of the owner's alarms. </para> <para><b>NOTE:</b> Amazon CloudWatch retains the history of an alarm for
        /// two weeks, whether or not you delete the alarm. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeAlarmHistoryResponse DescribeAlarmHistory()
        {
            return DescribeAlarmHistory(new DescribeAlarmHistoryRequest());
        }
        

        #endregion
    
        #region DescribeAlarms

        /// <summary>
        /// <para> Retrieves alarms with the specified names. If no name is specified, all alarms for the user are returned. Alarms can be retrieved by
        /// using only a prefix for the alarm name, the alarm state, or a prefix for any action. </para>
        /// </summary>
        /// 
        /// <param name="describeAlarmsRequest">Container for the necessary parameters to execute the DescribeAlarms service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeAlarmsResponse DescribeAlarms(DescribeAlarmsRequest describeAlarmsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeAlarms(describeAlarmsRequest, null, null, true);
            return EndDescribeAlarms(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DescribeAlarms"/>
        /// </summary>
        /// 
        /// <param name="describeAlarmsRequest">Container for the necessary parameters to execute the DescribeAlarms operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlarms
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAlarms(DescribeAlarmsRequest describeAlarmsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeAlarms(describeAlarmsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DescribeAlarms"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarms.</param>
        /// 
        /// <returns>Returns a DescribeAlarmsResult from AmazonCloudWatch.</returns>
        public DescribeAlarmsResponse EndDescribeAlarms(IAsyncResult asyncResult)
        {
            return endOperation<DescribeAlarmsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeAlarms(DescribeAlarmsRequest describeAlarmsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAlarmsRequestMarshaller().Marshall(describeAlarmsRequest);
            var unmarshaller = DescribeAlarmsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Retrieves alarms with the specified names. If no name is specified, all alarms for the user are returned. Alarms can be retrieved by
        /// using only a prefix for the alarm name, the alarm state, or a prefix for any action. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeAlarmsResponse DescribeAlarms()
        {
            return DescribeAlarms(new DescribeAlarmsRequest());
        }
        

        #endregion
    
        #region DescribeAlarmsForMetric

        /// <summary>
        /// <para> Retrieves all alarms for a single metric. Specify a statistic, period, or unit to filter the set of alarms further. </para>
        /// </summary>
        /// 
        /// <param name="describeAlarmsForMetricRequest">Container for the necessary parameters to execute the DescribeAlarmsForMetric service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the DescribeAlarmsForMetric service method, as returned by AmazonCloudWatch.</returns>
        /// 
        public DescribeAlarmsForMetricResponse DescribeAlarmsForMetric(DescribeAlarmsForMetricRequest describeAlarmsForMetricRequest)
        {
            IAsyncResult asyncResult = invokeDescribeAlarmsForMetric(describeAlarmsForMetricRequest, null, null, true);
            return EndDescribeAlarmsForMetric(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmsForMetric operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DescribeAlarmsForMetric"/>
        /// </summary>
        /// 
        /// <param name="describeAlarmsForMetricRequest">Container for the necessary parameters to execute the DescribeAlarmsForMetric operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAlarmsForMetric operation.</returns>
        public IAsyncResult BeginDescribeAlarmsForMetric(DescribeAlarmsForMetricRequest describeAlarmsForMetricRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeAlarmsForMetric(describeAlarmsForMetricRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAlarmsForMetric operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DescribeAlarmsForMetric"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarmsForMetric.</param>
        /// 
        /// <returns>Returns a DescribeAlarmsForMetricResult from AmazonCloudWatch.</returns>
        public DescribeAlarmsForMetricResponse EndDescribeAlarmsForMetric(IAsyncResult asyncResult)
        {
            return endOperation<DescribeAlarmsForMetricResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeAlarmsForMetric(DescribeAlarmsForMetricRequest describeAlarmsForMetricRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAlarmsForMetricRequestMarshaller().Marshall(describeAlarmsForMetricRequest);
            var unmarshaller = DescribeAlarmsForMetricResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DisableAlarmActions

        /// <summary>
        /// <para> Disables actions for the specified alarms. When an alarm's actions are disabled the alarm's state may change, but none of the alarm's
        /// actions will execute. </para>
        /// </summary>
        /// 
        /// <param name="disableAlarmActionsRequest">Container for the necessary parameters to execute the DisableAlarmActions service method on
        ///          AmazonCloudWatch.</param>
        /// 
        public DisableAlarmActionsResponse DisableAlarmActions(DisableAlarmActionsRequest disableAlarmActionsRequest)
        {
            IAsyncResult asyncResult = invokeDisableAlarmActions(disableAlarmActionsRequest, null, null, true);
            return EndDisableAlarmActions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DisableAlarmActions"/>
        /// </summary>
        /// 
        /// <param name="disableAlarmActionsRequest">Container for the necessary parameters to execute the DisableAlarmActions operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDisableAlarmActions(DisableAlarmActionsRequest disableAlarmActionsRequest, AsyncCallback callback, object state)
        {
            return invokeDisableAlarmActions(disableAlarmActionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DisableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DisableAlarmActions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableAlarmActions.</param>
        public DisableAlarmActionsResponse EndDisableAlarmActions(IAsyncResult asyncResult)
        {
            return endOperation<DisableAlarmActionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDisableAlarmActions(DisableAlarmActionsRequest disableAlarmActionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DisableAlarmActionsRequestMarshaller().Marshall(disableAlarmActionsRequest);
            var unmarshaller = DisableAlarmActionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region EnableAlarmActions

        /// <summary>
        /// <para> Enables actions for the specified alarms. </para>
        /// </summary>
        /// 
        /// <param name="enableAlarmActionsRequest">Container for the necessary parameters to execute the EnableAlarmActions service method on
        ///          AmazonCloudWatch.</param>
        /// 
        public EnableAlarmActionsResponse EnableAlarmActions(EnableAlarmActionsRequest enableAlarmActionsRequest)
        {
            IAsyncResult asyncResult = invokeEnableAlarmActions(enableAlarmActionsRequest, null, null, true);
            return EndEnableAlarmActions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.EnableAlarmActions"/>
        /// </summary>
        /// 
        /// <param name="enableAlarmActionsRequest">Container for the necessary parameters to execute the EnableAlarmActions operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginEnableAlarmActions(EnableAlarmActionsRequest enableAlarmActionsRequest, AsyncCallback callback, object state)
        {
            return invokeEnableAlarmActions(enableAlarmActionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the EnableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.EnableAlarmActions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableAlarmActions.</param>
        public EnableAlarmActionsResponse EndEnableAlarmActions(IAsyncResult asyncResult)
        {
            return endOperation<EnableAlarmActionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeEnableAlarmActions(EnableAlarmActionsRequest enableAlarmActionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new EnableAlarmActionsRequestMarshaller().Marshall(enableAlarmActionsRequest);
            var unmarshaller = EnableAlarmActionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetMetricStatistics

        /// <summary>
        /// <para> Gets statistics for the specified metric. </para> <para> The maximum number of data points returned from a single
        /// <c>GetMetricStatistics</c> request is 1,440, wereas the maximum number of data points that can be queried is 50,850. If you make a request
        /// that generates more than 1,440 data points, Amazon CloudWatch returns an error. In such a case, you can alter the request by narrowing the
        /// specified time range or increasing the specified period. Alternatively, you can make multiple requests across adjacent time ranges. </para>
        /// <para> Amazon CloudWatch aggregates data points based on the length of the <c>period</c> that you specify. For example, if you request
        /// statistics with a one-minute granularity, Amazon CloudWatch aggregates data points with time stamps that fall within the same one-minute
        /// period. In such a case, the data points queried can greatly outnumber the data points returned. </para> <para> The following examples show
        /// various statistics allowed by the data point query maximum of 50,850 when you call <c>GetMetricStatistics</c> on Amazon EC2 instances with
        /// detailed (one-minute) monitoring enabled: </para>
        /// <ul>
        /// <li>Statistics for up to 400 instances for a span of one hour</li>
        /// <li>Statistics for up to 35 instances over a span of 24 hours</li>
        /// <li>Statistics for up to 2 instances over a span of 2 weeks</li>
        /// 
        /// </ul>
        /// <para> For information about the namespace, metric names, and dimensions that other Amazon Web Services products use to send metrics to
        /// Cloudwatch, go to <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CW_Support_For_AWS.html" >Amazon CloudWatch
        /// Metrics, Namespaces, and Dimensions Reference</a> in the <i>Amazon CloudWatch Developer Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="getMetricStatisticsRequest">Container for the necessary parameters to execute the GetMetricStatistics service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the GetMetricStatistics service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="MissingRequiredParameterException"/>
        public GetMetricStatisticsResponse GetMetricStatistics(GetMetricStatisticsRequest getMetricStatisticsRequest)
        {
            IAsyncResult asyncResult = invokeGetMetricStatistics(getMetricStatisticsRequest, null, null, true);
            return EndGetMetricStatistics(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetMetricStatistics operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.GetMetricStatistics"/>
        /// </summary>
        /// 
        /// <param name="getMetricStatisticsRequest">Container for the necessary parameters to execute the GetMetricStatistics operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetMetricStatistics operation.</returns>
        public IAsyncResult BeginGetMetricStatistics(GetMetricStatisticsRequest getMetricStatisticsRequest, AsyncCallback callback, object state)
        {
            return invokeGetMetricStatistics(getMetricStatisticsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetMetricStatistics operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.GetMetricStatistics"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMetricStatistics.</param>
        /// 
        /// <returns>Returns a GetMetricStatisticsResult from AmazonCloudWatch.</returns>
        public GetMetricStatisticsResponse EndGetMetricStatistics(IAsyncResult asyncResult)
        {
            return endOperation<GetMetricStatisticsResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetMetricStatistics(GetMetricStatisticsRequest getMetricStatisticsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetMetricStatisticsRequestMarshaller().Marshall(getMetricStatisticsRequest);
            var unmarshaller = GetMetricStatisticsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListMetrics

        /// <summary>
        /// <para> Returns a list of valid metrics stored for the AWS account owner. Returned metrics can be used with GetMetricStatistics to obtain
        /// statistical data for a given metric. </para> <para><b>NOTE:</b> Up to 500 results are returned for any one call. To retrieve further
        /// results, use returned NextToken values with subsequent ListMetrics operations. </para> <para><b>NOTE:</b> If you create a metric with the
        /// PutMetricData action, allow up to fifteen minutes for the metric to appear in calls to the ListMetrics action. Statistics about the metric,
        /// however, are available sooner using GetMetricStatistics. </para>
        /// </summary>
        /// 
        /// <param name="listMetricsRequest">Container for the necessary parameters to execute the ListMetrics service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public ListMetricsResponse ListMetrics(ListMetricsRequest listMetricsRequest)
        {
            IAsyncResult asyncResult = invokeListMetrics(listMetricsRequest, null, null, true);
            return EndListMetrics(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListMetrics operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.ListMetrics"/>
        /// </summary>
        /// 
        /// <param name="listMetricsRequest">Container for the necessary parameters to execute the ListMetrics operation on AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMetrics
        ///         operation.</returns>
        public IAsyncResult BeginListMetrics(ListMetricsRequest listMetricsRequest, AsyncCallback callback, object state)
        {
            return invokeListMetrics(listMetricsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListMetrics operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.ListMetrics"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMetrics.</param>
        /// 
        /// <returns>Returns a ListMetricsResult from AmazonCloudWatch.</returns>
        public ListMetricsResponse EndListMetrics(IAsyncResult asyncResult)
        {
            return endOperation<ListMetricsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListMetrics(ListMetricsRequest listMetricsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListMetricsRequestMarshaller().Marshall(listMetricsRequest);
            var unmarshaller = ListMetricsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a list of valid metrics stored for the AWS account owner. Returned metrics can be used with GetMetricStatistics to obtain
        /// statistical data for a given metric. </para> <para><b>NOTE:</b> Up to 500 results are returned for any one call. To retrieve further
        /// results, use returned NextToken values with subsequent ListMetrics operations. </para> <para><b>NOTE:</b> If you create a metric with the
        /// PutMetricData action, allow up to fifteen minutes for the metric to appear in calls to the ListMetrics action. Statistics about the metric,
        /// however, are available sooner using GetMetricStatistics. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public ListMetricsResponse ListMetrics()
        {
            return ListMetrics(new ListMetricsRequest());
        }
        

        #endregion
    
        #region PutMetricAlarm

        /// <summary>
        /// <para> Creates or updates an alarm and associates it with the specified Amazon CloudWatch metric. Optionally, this operation can associate
        /// one or more Amazon Simple Notification Service resources with the alarm. </para> <para> When this operation creates an alarm, the alarm
        /// state is immediately set to <c>INSUFFICIENT_DATA</c> . The alarm is evaluated and its <c>StateValue</c> is set appropriately. Any actions
        /// associated with the <c>StateValue</c> is then executed. </para> <para><b>NOTE:</b> When updating an existing alarm, its StateValue is left
        /// unchanged. </para>
        /// </summary>
        /// 
        /// <param name="putMetricAlarmRequest">Container for the necessary parameters to execute the PutMetricAlarm service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <exception cref="LimitExceededException"/>
        public PutMetricAlarmResponse PutMetricAlarm(PutMetricAlarmRequest putMetricAlarmRequest)
        {
            IAsyncResult asyncResult = invokePutMetricAlarm(putMetricAlarmRequest, null, null, true);
            return EndPutMetricAlarm(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricAlarm operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.PutMetricAlarm"/>
        /// </summary>
        /// 
        /// <param name="putMetricAlarmRequest">Container for the necessary parameters to execute the PutMetricAlarm operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutMetricAlarm(PutMetricAlarmRequest putMetricAlarmRequest, AsyncCallback callback, object state)
        {
            return invokePutMetricAlarm(putMetricAlarmRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutMetricAlarm operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.PutMetricAlarm"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetricAlarm.</param>
        public PutMetricAlarmResponse EndPutMetricAlarm(IAsyncResult asyncResult)
        {
            return endOperation<PutMetricAlarmResponse>(asyncResult);
        }
        
        IAsyncResult invokePutMetricAlarm(PutMetricAlarmRequest putMetricAlarmRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutMetricAlarmRequestMarshaller().Marshall(putMetricAlarmRequest);
            var unmarshaller = PutMetricAlarmResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PutMetricData

        /// <summary>
        /// <para> Publishes metric data points to Amazon CloudWatch. Amazon Cloudwatch associates the data points with the specified metric. If the
        /// specified metric does not exist, Amazon CloudWatch creates the metric. It can take up to fifteen minutes for a new metric to appear in calls
        /// to the ListMetrics action.</para> <para> The size of a PutMetricData request is limited to 8 KB for HTTP GET requests and 40 KB for HTTP
        /// POST requests. </para> <para><b>IMPORTANT:</b> Although the Value parameter accepts numbers of type Double, Amazon CloudWatch truncates
        /// values with very large exponents. Values with base-10 exponents greater than 126 (1 x 10^126) are truncated. Likewise, values with base-10
        /// exponents less than -130 (1 x 10^-130) are also truncated. </para> <para>Data that is timestamped 24 hours or more in the past may take in
        /// excess of 48 hours to become available from submission time using <c>GetMetricStatistics</c> .</para>
        /// </summary>
        /// 
        /// <param name="putMetricDataRequest">Container for the necessary parameters to execute the PutMetricData service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="MissingRequiredParameterException"/>
        public PutMetricDataResponse PutMetricData(PutMetricDataRequest putMetricDataRequest)
        {
            IAsyncResult asyncResult = invokePutMetricData(putMetricDataRequest, null, null, true);
            return EndPutMetricData(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricData operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.PutMetricData"/>
        /// </summary>
        /// 
        /// <param name="putMetricDataRequest">Container for the necessary parameters to execute the PutMetricData operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutMetricData(PutMetricDataRequest putMetricDataRequest, AsyncCallback callback, object state)
        {
            return invokePutMetricData(putMetricDataRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutMetricData operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.PutMetricData"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetricData.</param>
        public PutMetricDataResponse EndPutMetricData(IAsyncResult asyncResult)
        {
            return endOperation<PutMetricDataResponse>(asyncResult);
        }
        
        IAsyncResult invokePutMetricData(PutMetricDataRequest putMetricDataRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutMetricDataRequestMarshaller().Marshall(putMetricDataRequest);
            var unmarshaller = PutMetricDataResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetAlarmState

        /// <summary>
        /// <para> Temporarily sets the state of an alarm. When the updated <c>StateValue</c> differs from the previous value, the action configured for
        /// the appropriate state is invoked. This is not a permanent change. The next periodic alarm check (in about a minute) will set the alarm to
        /// its actual state. </para>
        /// </summary>
        /// 
        /// <param name="setAlarmStateRequest">Container for the necessary parameters to execute the SetAlarmState service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InvalidFormatException"/>
        public SetAlarmStateResponse SetAlarmState(SetAlarmStateRequest setAlarmStateRequest)
        {
            IAsyncResult asyncResult = invokeSetAlarmState(setAlarmStateRequest, null, null, true);
            return EndSetAlarmState(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetAlarmState operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.SetAlarmState"/>
        /// </summary>
        /// 
        /// <param name="setAlarmStateRequest">Container for the necessary parameters to execute the SetAlarmState operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSetAlarmState(SetAlarmStateRequest setAlarmStateRequest, AsyncCallback callback, object state)
        {
            return invokeSetAlarmState(setAlarmStateRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetAlarmState operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.SetAlarmState"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetAlarmState.</param>
        public SetAlarmStateResponse EndSetAlarmState(IAsyncResult asyncResult)
        {
            return endOperation<SetAlarmStateResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetAlarmState(SetAlarmStateRequest setAlarmStateRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetAlarmStateRequestMarshaller().Marshall(setAlarmStateRequest);
            var unmarshaller = SetAlarmStateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
