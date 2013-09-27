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

using Amazon.AutoScaling.Model;
using Amazon.AutoScaling.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.AutoScaling
{
    /// <summary>
    /// Implementation for accessing AmazonAutoScaling.
    ///  
    /// Auto Scaling <para> Auto Scaling is a web service designed to automatically launch or terminate Amazon Elastic Compute Cloud (Amazon EC2)
    /// instances based on user-defined policies, schedules, and health checks. This service is used in conjunction with Amazon CloudWatch and
    /// Elastic Load Balancing services. </para> <para>Auto Scaling provides APIs that you can call by submitting a Query Request. Query requests
    /// are HTTP or HTTPS requests that use the HTTP verbs GET or POST and a Query parameter named <i>Action</i> or <i>Operation</i> that specifies
    /// the API you are calling. Action is used throughout this documentation, although Operation is also supported for backward compatibility with
    /// other Amazon Web Services (AWS) Query APIs. </para> <para>Calling the API using a Query request is the most direct way to access the web
    /// service, but requires that your application handle low-level details such as generating the hash to sign the request and error handling. The
    /// benefit of calling the service using a Query request is that you are assured of having access to the complete functionality of the API. For
    /// information about signing a a query request, see Use Query Requests to Call Auto Scaling APIs </para> <para> This guide provides detailed
    /// information about Auto Scaling actions, data types, parameters, and errors. For detailed information about Auto Scaling features and their
    /// associated API actions, go to the Auto Scaling Developer Guide. </para> <para>This reference is based on the current WSDL, which is
    /// available at:</para> <para> http://autoscaling.amazonaws.com/doc/2011-01-01/AutoScaling.wsdl </para> <para> <b>Endpoints</b> </para>
    /// <para>For information about this product's regions and endpoints, go to Regions and Endpoints in the Amazon Web Services General Reference.
    /// </para>
    /// </summary>
    public class AmazonAutoScalingClient : AmazonWebServiceClient, AmazonAutoScaling
    {
    
        AbstractAWSSigner signer = new AWS4Signer();

        #region Constructors

        /// <summary>
        /// Constructs AmazonAutoScalingClient with the credentials loaded from the application's
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
        public AmazonAutoScalingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAutoScalingConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with the credentials loaded from the application's
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
        public AmazonAutoScalingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAutoScalingConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAutoScaling Configuration Object</param>
        public AmazonAutoScalingClient(AmazonAutoScalingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAutoScalingClient(AWSCredentials credentials)
            : this(credentials, new AmazonAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAutoScalingConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Credentials and an
        /// AmazonAutoScalingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(AWSCredentials credentials, AmazonAutoScalingConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAutoScalingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAutoScalingClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAutoScalingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAutoScalingConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAutoScalingClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAutoScalingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion
   
        #region DescribeAutoScalingGroups

        /// <summary>
        /// <para> Returns a full description of each Auto Scaling group in the given list. This includes all Amazon EC2 instances that are members of
        /// the group. If a list of names is not provided, the service returns the full details of all Auto Scaling groups. </para> <para> This action
        /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
        /// token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="describeAutoScalingGroupsRequest">Container for the necessary parameters to execute the DescribeAutoScalingGroups service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest describeAutoScalingGroupsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeAutoScalingGroups(describeAutoScalingGroupsRequest, null, null, true);
            return EndDescribeAutoScalingGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingGroups operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeAutoScalingGroups"/>
        /// </summary>
        /// 
        /// <param name="describeAutoScalingGroupsRequest">Container for the necessary parameters to execute the DescribeAutoScalingGroups operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAutoScalingGroups operation.</returns>
        public IAsyncResult BeginDescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest describeAutoScalingGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeAutoScalingGroups(describeAutoScalingGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAutoScalingGroups operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeAutoScalingGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingGroups.</param>
        /// 
        /// <returns>Returns a DescribeAutoScalingGroupsResult from AmazonAutoScaling.</returns>
        public DescribeAutoScalingGroupsResponse EndDescribeAutoScalingGroups(IAsyncResult asyncResult)
        {
            return endOperation<DescribeAutoScalingGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest describeAutoScalingGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAutoScalingGroupsRequestMarshaller().Marshall(describeAutoScalingGroupsRequest);
            var unmarshaller = DescribeAutoScalingGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a full description of each Auto Scaling group in the given list. This includes all Amazon EC2 instances that are members of
        /// the group. If a list of names is not provided, the service returns the full details of all Auto Scaling groups. </para> <para> This action
        /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
        /// token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups()
        {
            return DescribeAutoScalingGroups(new DescribeAutoScalingGroupsRequest());
        }
        

        #endregion
    
        #region EnableMetricsCollection

        /// <summary>
        /// <para> Enables monitoring of group metrics for the Auto Scaling group specified in <c>AutoScalingGroupName</c> .
        /// You can specify the list of enabled metrics with the <c>Metrics</c> parameter. </para> <para> Auto Scaling metrics collection
        /// can be turned on only if the <c>InstanceMonitoring</c> flag, in the Auto Scaling group's launch configuration, is set to <c>True</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="enableMetricsCollectionRequest">Container for the necessary parameters to execute the EnableMetricsCollection service method on
        ///          AmazonAutoScaling.</param>
        /// 
        public EnableMetricsCollectionResponse EnableMetricsCollection(EnableMetricsCollectionRequest enableMetricsCollectionRequest)
        {
            IAsyncResult asyncResult = invokeEnableMetricsCollection(enableMetricsCollectionRequest, null, null, true);
            return EndEnableMetricsCollection(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the EnableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.EnableMetricsCollection"/>
        /// </summary>
        /// 
        /// <param name="enableMetricsCollectionRequest">Container for the necessary parameters to execute the EnableMetricsCollection operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginEnableMetricsCollection(EnableMetricsCollectionRequest enableMetricsCollectionRequest, AsyncCallback callback, object state)
        {
            return invokeEnableMetricsCollection(enableMetricsCollectionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the EnableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.EnableMetricsCollection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableMetricsCollection.</param>
        public EnableMetricsCollectionResponse EndEnableMetricsCollection(IAsyncResult asyncResult)
        {
            return endOperation<EnableMetricsCollectionResponse>(asyncResult);
        }
        
        IAsyncResult invokeEnableMetricsCollection(EnableMetricsCollectionRequest enableMetricsCollectionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new EnableMetricsCollectionRequestMarshaller().Marshall(enableMetricsCollectionRequest);
            var unmarshaller = EnableMetricsCollectionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ResumeProcesses

        /// <summary>
        /// <para> Resumes all suspended Auto Scaling processes for an Auto Scaling group. For information on suspending and resuming Auto Scaling
        /// process, see Suspend and Resume Auto Scaling Process. </para>
        /// </summary>
        /// 
        /// <param name="resumeProcessesRequest">Container for the necessary parameters to execute the ResumeProcesses service method on
        ///          AmazonAutoScaling.</param>
        /// 
        public ResumeProcessesResponse ResumeProcesses(ResumeProcessesRequest resumeProcessesRequest)
        {
            IAsyncResult asyncResult = invokeResumeProcesses(resumeProcessesRequest, null, null, true);
            return EndResumeProcesses(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ResumeProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.ResumeProcesses"/>
        /// </summary>
        /// 
        /// <param name="resumeProcessesRequest">Container for the necessary parameters to execute the ResumeProcesses operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginResumeProcesses(ResumeProcessesRequest resumeProcessesRequest, AsyncCallback callback, object state)
        {
            return invokeResumeProcesses(resumeProcessesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ResumeProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.ResumeProcesses"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeProcesses.</param>
        public ResumeProcessesResponse EndResumeProcesses(IAsyncResult asyncResult)
        {
            return endOperation<ResumeProcessesResponse>(asyncResult);
        }
        
        IAsyncResult invokeResumeProcesses(ResumeProcessesRequest resumeProcessesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ResumeProcessesRequestMarshaller().Marshall(resumeProcessesRequest);
            var unmarshaller = ResumeProcessesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteLaunchConfiguration

        /// <summary>
        /// <para> Deletes the specified LaunchConfiguration. </para> <para> The specified launch configuration must not be attached to an Auto Scaling
        /// group. When this call completes, the launch configuration is no longer available for use. </para>
        /// </summary>
        /// 
        /// <param name="deleteLaunchConfigurationRequest">Container for the necessary parameters to execute the DeleteLaunchConfiguration service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="ResourceInUseException"/>
        public DeleteLaunchConfigurationResponse DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest deleteLaunchConfigurationRequest)
        {
            IAsyncResult asyncResult = invokeDeleteLaunchConfiguration(deleteLaunchConfigurationRequest, null, null, true);
            return EndDeleteLaunchConfiguration(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DeleteLaunchConfiguration"/>
        /// </summary>
        /// 
        /// <param name="deleteLaunchConfigurationRequest">Container for the necessary parameters to execute the DeleteLaunchConfiguration operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteLaunchConfiguration(DeleteLaunchConfigurationRequest deleteLaunchConfigurationRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteLaunchConfiguration(deleteLaunchConfigurationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DeleteLaunchConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLaunchConfiguration.</param>
        public DeleteLaunchConfigurationResponse EndDeleteLaunchConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<DeleteLaunchConfigurationResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteLaunchConfiguration(DeleteLaunchConfigurationRequest deleteLaunchConfigurationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteLaunchConfigurationRequestMarshaller().Marshall(deleteLaunchConfigurationRequest);
            var unmarshaller = DeleteLaunchConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribePolicies

        /// <summary>
        /// <para> Returns descriptions of what each policy does. This action supports pagination. If the response includes a token, there are more
        /// records available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="describePoliciesRequest">Container for the necessary parameters to execute the DescribePolicies service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribePoliciesResponse DescribePolicies(DescribePoliciesRequest describePoliciesRequest)
        {
            IAsyncResult asyncResult = invokeDescribePolicies(describePoliciesRequest, null, null, true);
            return EndDescribePolicies(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePolicies operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribePolicies"/>
        /// </summary>
        /// 
        /// <param name="describePoliciesRequest">Container for the necessary parameters to execute the DescribePolicies operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePolicies
        ///         operation.</returns>
        public IAsyncResult BeginDescribePolicies(DescribePoliciesRequest describePoliciesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribePolicies(describePoliciesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribePolicies operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribePolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePolicies.</param>
        /// 
        /// <returns>Returns a DescribePoliciesResult from AmazonAutoScaling.</returns>
        public DescribePoliciesResponse EndDescribePolicies(IAsyncResult asyncResult)
        {
            return endOperation<DescribePoliciesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribePolicies(DescribePoliciesRequest describePoliciesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribePoliciesRequestMarshaller().Marshall(describePoliciesRequest);
            var unmarshaller = DescribePoliciesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns descriptions of what each policy does. This action supports pagination. If the response includes a token, there are more
        /// records available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribePoliciesResponse DescribePolicies()
        {
            return DescribePolicies(new DescribePoliciesRequest());
        }
        

        #endregion
    
        #region DescribeScalingProcessTypes

        /// <summary>
        /// <para>Returns scaling process types for use in the ResumeProcesses and SuspendProcesses actions.</para>
        /// </summary>
        /// 
        /// <param name="describeScalingProcessTypesRequest">Container for the necessary parameters to execute the DescribeScalingProcessTypes service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        public DescribeScalingProcessTypesResponse DescribeScalingProcessTypes(DescribeScalingProcessTypesRequest describeScalingProcessTypesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeScalingProcessTypes(describeScalingProcessTypesRequest, null, null, true);
            return EndDescribeScalingProcessTypes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingProcessTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeScalingProcessTypes"/>
        /// </summary>
        /// 
        /// <param name="describeScalingProcessTypesRequest">Container for the necessary parameters to execute the DescribeScalingProcessTypes operation
        ///          on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeScalingProcessTypes operation.</returns>
        public IAsyncResult BeginDescribeScalingProcessTypes(DescribeScalingProcessTypesRequest describeScalingProcessTypesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeScalingProcessTypes(describeScalingProcessTypesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeScalingProcessTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeScalingProcessTypes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingProcessTypes.</param>
        /// 
        /// <returns>Returns a DescribeScalingProcessTypesResult from AmazonAutoScaling.</returns>
        public DescribeScalingProcessTypesResponse EndDescribeScalingProcessTypes(IAsyncResult asyncResult)
        {
            return endOperation<DescribeScalingProcessTypesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeScalingProcessTypes(DescribeScalingProcessTypesRequest describeScalingProcessTypesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeScalingProcessTypesRequestMarshaller().Marshall(describeScalingProcessTypesRequest);
            var unmarshaller = DescribeScalingProcessTypesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns scaling process types for use in the ResumeProcesses and SuspendProcesses actions.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        public DescribeScalingProcessTypesResponse DescribeScalingProcessTypes()
        {
            return DescribeScalingProcessTypes(new DescribeScalingProcessTypesRequest());
        }
        

        #endregion
    
        #region CreateAutoScalingGroup

        /// <summary>
        /// <para> Creates a new Auto Scaling group with the specified name and other attributes. When the creation request is completed, the Auto
        /// Scaling group is ready to be used in other calls. </para> <para><b>NOTE:</b> The Auto Scaling group name must be unique within the scope of
        /// your AWS account. </para>
        /// </summary>
        /// 
        /// <param name="createAutoScalingGroupRequest">Container for the necessary parameters to execute the CreateAutoScalingGroup service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="AlreadyExistsException"/>
        public CreateAutoScalingGroupResponse CreateAutoScalingGroup(CreateAutoScalingGroupRequest createAutoScalingGroupRequest)
        {
            IAsyncResult asyncResult = invokeCreateAutoScalingGroup(createAutoScalingGroupRequest, null, null, true);
            return EndCreateAutoScalingGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.CreateAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="createAutoScalingGroupRequest">Container for the necessary parameters to execute the CreateAutoScalingGroup operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginCreateAutoScalingGroup(CreateAutoScalingGroupRequest createAutoScalingGroupRequest, AsyncCallback callback, object state)
        {
            return invokeCreateAutoScalingGroup(createAutoScalingGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.CreateAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAutoScalingGroup.</param>
        public CreateAutoScalingGroupResponse EndCreateAutoScalingGroup(IAsyncResult asyncResult)
        {
            return endOperation<CreateAutoScalingGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateAutoScalingGroup(CreateAutoScalingGroupRequest createAutoScalingGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateAutoScalingGroupRequestMarshaller().Marshall(createAutoScalingGroupRequest);
            var unmarshaller = CreateAutoScalingGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeScalingActivities

        /// <summary>
        /// <para> Returns the scaling activities for the specified Auto Scaling group. </para> <para> If the specified <c>ActivityIds</c> list is
        /// empty, all the activities from the past six weeks are returned. Activities are sorted by completion time. Activities still in progress
        /// appear first on the list. </para> <para> This action supports pagination. If the response includes a token, there are more records
        /// available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="describeScalingActivitiesRequest">Container for the necessary parameters to execute the DescribeScalingActivities service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest describeScalingActivitiesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeScalingActivities(describeScalingActivitiesRequest, null, null, true);
            return EndDescribeScalingActivities(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingActivities operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeScalingActivities"/>
        /// </summary>
        /// 
        /// <param name="describeScalingActivitiesRequest">Container for the necessary parameters to execute the DescribeScalingActivities operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeScalingActivities operation.</returns>
        public IAsyncResult BeginDescribeScalingActivities(DescribeScalingActivitiesRequest describeScalingActivitiesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeScalingActivities(describeScalingActivitiesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeScalingActivities operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeScalingActivities"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingActivities.</param>
        /// 
        /// <returns>Returns a DescribeScalingActivitiesResult from AmazonAutoScaling.</returns>
        public DescribeScalingActivitiesResponse EndDescribeScalingActivities(IAsyncResult asyncResult)
        {
            return endOperation<DescribeScalingActivitiesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeScalingActivities(DescribeScalingActivitiesRequest describeScalingActivitiesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeScalingActivitiesRequestMarshaller().Marshall(describeScalingActivitiesRequest);
            var unmarshaller = DescribeScalingActivitiesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns the scaling activities for the specified Auto Scaling group. </para> <para> If the specified <c>ActivityIds</c> list is
        /// empty, all the activities from the past six weeks are returned. Activities are sorted by completion time. Activities still in progress
        /// appear first on the list. </para> <para> This action supports pagination. If the response includes a token, there are more records
        /// available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeScalingActivitiesResponse DescribeScalingActivities()
        {
            return DescribeScalingActivities(new DescribeScalingActivitiesRequest());
        }
        

        #endregion
    
        #region DescribeNotificationConfigurations

        /// <summary>
        /// <para> Returns a list of notification actions associated with Auto Scaling groups for specified events. </para>
        /// </summary>
        /// 
        /// <param name="describeNotificationConfigurationsRequest">Container for the necessary parameters to execute the
        ///          DescribeNotificationConfigurations service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest describeNotificationConfigurationsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeNotificationConfigurations(describeNotificationConfigurationsRequest, null, null, true);
            return EndDescribeNotificationConfigurations(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotificationConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeNotificationConfigurations"/>
        /// </summary>
        /// 
        /// <param name="describeNotificationConfigurationsRequest">Container for the necessary parameters to execute the
        ///          DescribeNotificationConfigurations operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeNotificationConfigurations operation.</returns>
        public IAsyncResult BeginDescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest describeNotificationConfigurationsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeNotificationConfigurations(describeNotificationConfigurationsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeNotificationConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeNotificationConfigurations"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotificationConfigurations.</param>
        /// 
        /// <returns>Returns a DescribeNotificationConfigurationsResult from AmazonAutoScaling.</returns>
        public DescribeNotificationConfigurationsResponse EndDescribeNotificationConfigurations(IAsyncResult asyncResult)
        {
            return endOperation<DescribeNotificationConfigurationsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest describeNotificationConfigurationsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeNotificationConfigurationsRequestMarshaller().Marshall(describeNotificationConfigurationsRequest);
            var unmarshaller = DescribeNotificationConfigurationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a list of notification actions associated with Auto Scaling groups for specified events. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations()
        {
            return DescribeNotificationConfigurations(new DescribeNotificationConfigurationsRequest());
        }
        

        #endregion
    
        #region DescribeTerminationPolicyTypes

        /// <summary>
        /// <para> Returns a list of all termination policies supported by Auto Scaling. </para>
        /// </summary>
        /// 
        /// <param name="describeTerminationPolicyTypesRequest">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes
        ///          service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        public DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest describeTerminationPolicyTypesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeTerminationPolicyTypes(describeTerminationPolicyTypesRequest, null, null, true);
            return EndDescribeTerminationPolicyTypes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTerminationPolicyTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeTerminationPolicyTypes"/>
        /// </summary>
        /// 
        /// <param name="describeTerminationPolicyTypesRequest">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes
        ///          operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeTerminationPolicyTypes operation.</returns>
        public IAsyncResult BeginDescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest describeTerminationPolicyTypesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeTerminationPolicyTypes(describeTerminationPolicyTypesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeTerminationPolicyTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeTerminationPolicyTypes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTerminationPolicyTypes.</param>
        /// 
        /// <returns>Returns a DescribeTerminationPolicyTypesResult from AmazonAutoScaling.</returns>
        public DescribeTerminationPolicyTypesResponse EndDescribeTerminationPolicyTypes(IAsyncResult asyncResult)
        {
            return endOperation<DescribeTerminationPolicyTypesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest describeTerminationPolicyTypesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeTerminationPolicyTypesRequestMarshaller().Marshall(describeTerminationPolicyTypesRequest);
            var unmarshaller = DescribeTerminationPolicyTypesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a list of all termination policies supported by Auto Scaling. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        public DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes()
        {
            return DescribeTerminationPolicyTypes(new DescribeTerminationPolicyTypesRequest());
        }
        

        #endregion
    
        #region DescribeTags

        /// <summary>
        /// <para> Lists the Auto Scaling group tags. </para> <para> You can use filters to limit results when describing tags. For example, you can
        /// query for tags of a particular Auto Scaling group. You can specify multiple values for a filter. A tag must match at least one of the
        /// specified values for it to be included in the results. </para> <para> You can also specify multiple filters. The result includes information
        /// for a particular tag only if it matches all your filters. If there's no match, no special message is returned. </para>
        /// </summary>
        /// 
        /// <param name="describeTagsRequest">Container for the necessary parameters to execute the DescribeTags service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeTagsResponse DescribeTags(DescribeTagsRequest describeTagsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeTags(describeTagsRequest, null, null, true);
            return EndDescribeTags(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeTags"/>
        /// </summary>
        /// 
        /// <param name="describeTagsRequest">Container for the necessary parameters to execute the DescribeTags operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        public IAsyncResult BeginDescribeTags(DescribeTagsRequest describeTagsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeTags(describeTagsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeTags"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a DescribeTagsResult from AmazonAutoScaling.</returns>
        public DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult)
        {
            return endOperation<DescribeTagsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeTags(DescribeTagsRequest describeTagsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeTagsRequestMarshaller().Marshall(describeTagsRequest);
            var unmarshaller = DescribeTagsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Lists the Auto Scaling group tags. </para> <para> You can use filters to limit results when describing tags. For example, you can
        /// query for tags of a particular Auto Scaling group. You can specify multiple values for a filter. A tag must match at least one of the
        /// specified values for it to be included in the results. </para> <para> You can also specify multiple filters. The result includes information
        /// for a particular tag only if it matches all your filters. If there's no match, no special message is returned. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeTagsResponse DescribeTags()
        {
            return DescribeTags(new DescribeTagsRequest());
        }
        

        #endregion
    
        #region DeleteTags

        /// <summary>
        /// <para>Removes the specified tags or a set of tags from a set of resources.</para>
        /// </summary>
        /// 
        /// <param name="deleteTagsRequest">Container for the necessary parameters to execute the DeleteTags service method on
        ///          AmazonAutoScaling.</param>
        /// 
        public DeleteTagsResponse DeleteTags(DeleteTagsRequest deleteTagsRequest)
        {
            IAsyncResult asyncResult = invokeDeleteTags(deleteTagsRequest, null, null, true);
            return EndDeleteTags(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DeleteTags"/>
        /// </summary>
        /// 
        /// <param name="deleteTagsRequest">Container for the necessary parameters to execute the DeleteTags operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteTags(DeleteTagsRequest deleteTagsRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteTags(deleteTagsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteTags operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DeleteTags"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        public DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult)
        {
            return endOperation<DeleteTagsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteTags(DeleteTagsRequest deleteTagsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteTagsRequestMarshaller().Marshall(deleteTagsRequest);
            var unmarshaller = DeleteTagsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ExecutePolicy

        /// <summary>
        /// <para>Executes the specified policy. </para>
        /// </summary>
        /// 
        /// <param name="executePolicyRequest">Container for the necessary parameters to execute the ExecutePolicy service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <exception cref="ScalingActivityInProgressException"/>
        public ExecutePolicyResponse ExecutePolicy(ExecutePolicyRequest executePolicyRequest)
        {
            IAsyncResult asyncResult = invokeExecutePolicy(executePolicyRequest, null, null, true);
            return EndExecutePolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ExecutePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.ExecutePolicy"/>
        /// </summary>
        /// 
        /// <param name="executePolicyRequest">Container for the necessary parameters to execute the ExecutePolicy operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginExecutePolicy(ExecutePolicyRequest executePolicyRequest, AsyncCallback callback, object state)
        {
            return invokeExecutePolicy(executePolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ExecutePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.ExecutePolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecutePolicy.</param>
        public ExecutePolicyResponse EndExecutePolicy(IAsyncResult asyncResult)
        {
            return endOperation<ExecutePolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeExecutePolicy(ExecutePolicyRequest executePolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ExecutePolicyRequestMarshaller().Marshall(executePolicyRequest);
            var unmarshaller = ExecutePolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PutScalingPolicy

        /// <summary>
        /// <para> Creates or updates a policy for an Auto Scaling group. To update an existing policy, use the existing policy name and set the
        /// parameter(s) you want to change. Any existing parameter not changed in an update to an existing policy is not changed in this update
        /// request. </para>
        /// </summary>
        /// 
        /// <param name="putScalingPolicyRequest">Container for the necessary parameters to execute the PutScalingPolicy service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="LimitExceededException"/>
        public PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest putScalingPolicyRequest)
        {
            IAsyncResult asyncResult = invokePutScalingPolicy(putScalingPolicyRequest, null, null, true);
            return EndPutScalingPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.PutScalingPolicy"/>
        /// </summary>
        /// 
        /// <param name="putScalingPolicyRequest">Container for the necessary parameters to execute the PutScalingPolicy operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutScalingPolicy
        ///         operation.</returns>
        public IAsyncResult BeginPutScalingPolicy(PutScalingPolicyRequest putScalingPolicyRequest, AsyncCallback callback, object state)
        {
            return invokePutScalingPolicy(putScalingPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutScalingPolicy operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.PutScalingPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScalingPolicy.</param>
        /// 
        /// <returns>Returns a PutScalingPolicyResult from AmazonAutoScaling.</returns>
        public PutScalingPolicyResponse EndPutScalingPolicy(IAsyncResult asyncResult)
        {
            return endOperation<PutScalingPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokePutScalingPolicy(PutScalingPolicyRequest putScalingPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutScalingPolicyRequestMarshaller().Marshall(putScalingPolicyRequest);
            var unmarshaller = PutScalingPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PutNotificationConfiguration

        /// <summary>
        /// <para> Configures an Auto Scaling group to send notifications when specified events take place. Subscribers to this topic can have messages
        /// for events delivered to an endpoint such as a web server or email address. </para> <para>For more information see Get Email Notifications
        /// When Your Auto Scaling Group Changes </para> <para>A new <c>PutNotificationConfiguration</c> overwrites an existing configuration. </para>
        /// </summary>
        /// 
        /// <param name="putNotificationConfigurationRequest">Container for the necessary parameters to execute the PutNotificationConfiguration service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="LimitExceededException"/>
        public PutNotificationConfigurationResponse PutNotificationConfiguration(PutNotificationConfigurationRequest putNotificationConfigurationRequest)
        {
            IAsyncResult asyncResult = invokePutNotificationConfiguration(putNotificationConfigurationRequest, null, null, true);
            return EndPutNotificationConfiguration(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.PutNotificationConfiguration"/>
        /// </summary>
        /// 
        /// <param name="putNotificationConfigurationRequest">Container for the necessary parameters to execute the PutNotificationConfiguration
        ///          operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutNotificationConfiguration(PutNotificationConfigurationRequest putNotificationConfigurationRequest, AsyncCallback callback, object state)
        {
            return invokePutNotificationConfiguration(putNotificationConfigurationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.PutNotificationConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutNotificationConfiguration.</param>
        public PutNotificationConfigurationResponse EndPutNotificationConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<PutNotificationConfigurationResponse>(asyncResult);
        }
        
        IAsyncResult invokePutNotificationConfiguration(PutNotificationConfigurationRequest putNotificationConfigurationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutNotificationConfigurationRequestMarshaller().Marshall(putNotificationConfigurationRequest);
            var unmarshaller = PutNotificationConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeletePolicy

        /// <summary>
        /// <para>Deletes a policy created by PutScalingPolicy.</para>
        /// </summary>
        /// 
        /// <param name="deletePolicyRequest">Container for the necessary parameters to execute the DeletePolicy service method on
        ///          AmazonAutoScaling.</param>
        /// 
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest deletePolicyRequest)
        {
            IAsyncResult asyncResult = invokeDeletePolicy(deletePolicyRequest, null, null, true);
            return EndDeletePolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DeletePolicy"/>
        /// </summary>
        /// 
        /// <param name="deletePolicyRequest">Container for the necessary parameters to execute the DeletePolicy operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeletePolicy(DeletePolicyRequest deletePolicyRequest, AsyncCallback callback, object state)
        {
            return invokeDeletePolicy(deletePolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeletePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DeletePolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicy.</param>
        public DeletePolicyResponse EndDeletePolicy(IAsyncResult asyncResult)
        {
            return endOperation<DeletePolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeletePolicy(DeletePolicyRequest deletePolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeletePolicyRequestMarshaller().Marshall(deletePolicyRequest);
            var unmarshaller = DeletePolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteNotificationConfiguration

        /// <summary>
        /// <para>Deletes notifications created by PutNotificationConfiguration.</para>
        /// </summary>
        /// 
        /// <param name="deleteNotificationConfigurationRequest">Container for the necessary parameters to execute the DeleteNotificationConfiguration
        ///          service method on AmazonAutoScaling.</param>
        /// 
        public DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest deleteNotificationConfigurationRequest)
        {
            IAsyncResult asyncResult = invokeDeleteNotificationConfiguration(deleteNotificationConfigurationRequest, null, null, true);
            return EndDeleteNotificationConfiguration(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DeleteNotificationConfiguration"/>
        /// </summary>
        /// 
        /// <param name="deleteNotificationConfigurationRequest">Container for the necessary parameters to execute the DeleteNotificationConfiguration
        ///          operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteNotificationConfiguration(DeleteNotificationConfigurationRequest deleteNotificationConfigurationRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteNotificationConfiguration(deleteNotificationConfigurationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DeleteNotificationConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotificationConfiguration.</param>
        public DeleteNotificationConfigurationResponse EndDeleteNotificationConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<DeleteNotificationConfigurationResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteNotificationConfiguration(DeleteNotificationConfigurationRequest deleteNotificationConfigurationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteNotificationConfigurationRequestMarshaller().Marshall(deleteNotificationConfigurationRequest);
            var unmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteScheduledAction

        /// <summary>
        /// <para>Deletes a scheduled action previously created using the PutScheduledUpdateGroupAction.</para>
        /// </summary>
        /// 
        /// <param name="deleteScheduledActionRequest">Container for the necessary parameters to execute the DeleteScheduledAction service method on
        ///          AmazonAutoScaling.</param>
        /// 
        public DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest deleteScheduledActionRequest)
        {
            IAsyncResult asyncResult = invokeDeleteScheduledAction(deleteScheduledActionRequest, null, null, true);
            return EndDeleteScheduledAction(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScheduledAction operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DeleteScheduledAction"/>
        /// </summary>
        /// 
        /// <param name="deleteScheduledActionRequest">Container for the necessary parameters to execute the DeleteScheduledAction operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteScheduledAction(DeleteScheduledActionRequest deleteScheduledActionRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteScheduledAction(deleteScheduledActionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteScheduledAction operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DeleteScheduledAction"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScheduledAction.</param>
        public DeleteScheduledActionResponse EndDeleteScheduledAction(IAsyncResult asyncResult)
        {
            return endOperation<DeleteScheduledActionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteScheduledAction(DeleteScheduledActionRequest deleteScheduledActionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteScheduledActionRequestMarshaller().Marshall(deleteScheduledActionRequest);
            var unmarshaller = DeleteScheduledActionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetInstanceHealth

        /// <summary>
        /// <para> Sets the health status of a specified instance that belongs to any of your Auto Scaling groups. </para> <para>For more information,
        /// see Configure Health Checks for Your Auto Scaling group.</para>
        /// </summary>
        /// 
        /// <param name="setInstanceHealthRequest">Container for the necessary parameters to execute the SetInstanceHealth service method on
        ///          AmazonAutoScaling.</param>
        /// 
        public SetInstanceHealthResponse SetInstanceHealth(SetInstanceHealthRequest setInstanceHealthRequest)
        {
            IAsyncResult asyncResult = invokeSetInstanceHealth(setInstanceHealthRequest, null, null, true);
            return EndSetInstanceHealth(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetInstanceHealth operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.SetInstanceHealth"/>
        /// </summary>
        /// 
        /// <param name="setInstanceHealthRequest">Container for the necessary parameters to execute the SetInstanceHealth operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSetInstanceHealth(SetInstanceHealthRequest setInstanceHealthRequest, AsyncCallback callback, object state)
        {
            return invokeSetInstanceHealth(setInstanceHealthRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetInstanceHealth operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.SetInstanceHealth"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetInstanceHealth.</param>
        public SetInstanceHealthResponse EndSetInstanceHealth(IAsyncResult asyncResult)
        {
            return endOperation<SetInstanceHealthResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetInstanceHealth(SetInstanceHealthRequest setInstanceHealthRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetInstanceHealthRequestMarshaller().Marshall(setInstanceHealthRequest);
            var unmarshaller = SetInstanceHealthResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeAutoScalingNotificationTypes

        /// <summary>
        /// <para> Returns a list of all notification types that are supported by Auto Scaling. </para>
        /// </summary>
        /// 
        /// <param name="describeAutoScalingNotificationTypesRequest">Container for the necessary parameters to execute the
        ///          DescribeAutoScalingNotificationTypes service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        public DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest describeAutoScalingNotificationTypesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeAutoScalingNotificationTypes(describeAutoScalingNotificationTypesRequest, null, null, true);
            return EndDescribeAutoScalingNotificationTypes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingNotificationTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeAutoScalingNotificationTypes"/>
        /// </summary>
        /// 
        /// <param name="describeAutoScalingNotificationTypesRequest">Container for the necessary parameters to execute the
        ///          DescribeAutoScalingNotificationTypes operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAutoScalingNotificationTypes operation.</returns>
        public IAsyncResult BeginDescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest describeAutoScalingNotificationTypesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeAutoScalingNotificationTypes(describeAutoScalingNotificationTypesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAutoScalingNotificationTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeAutoScalingNotificationTypes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingNotificationTypes.</param>
        /// 
        /// <returns>Returns a DescribeAutoScalingNotificationTypesResult from AmazonAutoScaling.</returns>
        public DescribeAutoScalingNotificationTypesResponse EndDescribeAutoScalingNotificationTypes(IAsyncResult asyncResult)
        {
            return endOperation<DescribeAutoScalingNotificationTypesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest describeAutoScalingNotificationTypesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAutoScalingNotificationTypesRequestMarshaller().Marshall(describeAutoScalingNotificationTypesRequest);
            var unmarshaller = DescribeAutoScalingNotificationTypesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a list of all notification types that are supported by Auto Scaling. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        public DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes()
        {
            return DescribeAutoScalingNotificationTypes(new DescribeAutoScalingNotificationTypesRequest());
        }
        

        #endregion
    
        #region CreateOrUpdateTags

        /// <summary>
        /// <para> Creates new tags or updates existing tags for an Auto Scaling group. </para> <para><b>NOTE:</b> A tag's definition is composed of a
        /// resource ID, resource type, key and value, and the propagate flag. Value and the propagate flag are optional parameters. See the Request
        /// Parameters for more information. </para> <para>For information on creating tags for your Auto Scaling group, see Tag Your Auto Scaling
        /// Groups and Amazon EC2 Instances.</para>
        /// </summary>
        /// 
        /// <param name="createOrUpdateTagsRequest">Container for the necessary parameters to execute the CreateOrUpdateTags service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="AlreadyExistsException"/>
        public CreateOrUpdateTagsResponse CreateOrUpdateTags(CreateOrUpdateTagsRequest createOrUpdateTagsRequest)
        {
            IAsyncResult asyncResult = invokeCreateOrUpdateTags(createOrUpdateTagsRequest, null, null, true);
            return EndCreateOrUpdateTags(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOrUpdateTags operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.CreateOrUpdateTags"/>
        /// </summary>
        /// 
        /// <param name="createOrUpdateTagsRequest">Container for the necessary parameters to execute the CreateOrUpdateTags operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginCreateOrUpdateTags(CreateOrUpdateTagsRequest createOrUpdateTagsRequest, AsyncCallback callback, object state)
        {
            return invokeCreateOrUpdateTags(createOrUpdateTagsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateOrUpdateTags operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.CreateOrUpdateTags"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOrUpdateTags.</param>
        public CreateOrUpdateTagsResponse EndCreateOrUpdateTags(IAsyncResult asyncResult)
        {
            return endOperation<CreateOrUpdateTagsResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateOrUpdateTags(CreateOrUpdateTagsRequest createOrUpdateTagsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateOrUpdateTagsRequestMarshaller().Marshall(createOrUpdateTagsRequest);
            var unmarshaller = CreateOrUpdateTagsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SuspendProcesses

        /// <summary>
        /// <para> Suspends Auto Scaling processes for an Auto Scaling group. To suspend specific process types, specify them by name with the
        /// <c>ScalingProcesses.member.N</c> parameter. To suspend all process types, omit the <c>ScalingProcesses.member.N</c> parameter. </para>
        /// <para><b>IMPORTANT:</b> Suspending either of the two primary process types, Launch or Terminate, can prevent other process types from
        /// functioning properly. </para> <para> To resume processes that have been suspended, use ResumeProcesses For more information on suspending
        /// and resuming Auto Scaling process, see Suspend and Resume Auto Scaling Process. </para>
        /// </summary>
        /// 
        /// <param name="suspendProcessesRequest">Container for the necessary parameters to execute the SuspendProcesses service method on
        ///          AmazonAutoScaling.</param>
        /// 
        public SuspendProcessesResponse SuspendProcesses(SuspendProcessesRequest suspendProcessesRequest)
        {
            IAsyncResult asyncResult = invokeSuspendProcesses(suspendProcessesRequest, null, null, true);
            return EndSuspendProcesses(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SuspendProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.SuspendProcesses"/>
        /// </summary>
        /// 
        /// <param name="suspendProcessesRequest">Container for the necessary parameters to execute the SuspendProcesses operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSuspendProcesses(SuspendProcessesRequest suspendProcessesRequest, AsyncCallback callback, object state)
        {
            return invokeSuspendProcesses(suspendProcessesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SuspendProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.SuspendProcesses"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSuspendProcesses.</param>
        public SuspendProcessesResponse EndSuspendProcesses(IAsyncResult asyncResult)
        {
            return endOperation<SuspendProcessesResponse>(asyncResult);
        }
        
        IAsyncResult invokeSuspendProcesses(SuspendProcessesRequest suspendProcessesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SuspendProcessesRequestMarshaller().Marshall(suspendProcessesRequest);
            var unmarshaller = SuspendProcessesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeAutoScalingInstances

        /// <summary>
        /// <para> Returns a description of each Auto Scaling instance in the <c>InstanceIds</c> list. If a list is not provided, the service returns
        /// the full details of all instances up to a maximum of 50. By default, the service returns a list of 20 items. </para> <para> This action
        /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
        /// token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="describeAutoScalingInstancesRequest">Container for the necessary parameters to execute the DescribeAutoScalingInstances service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest describeAutoScalingInstancesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeAutoScalingInstances(describeAutoScalingInstancesRequest, null, null, true);
            return EndDescribeAutoScalingInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingInstances operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeAutoScalingInstances"/>
        /// </summary>
        /// 
        /// <param name="describeAutoScalingInstancesRequest">Container for the necessary parameters to execute the DescribeAutoScalingInstances
        ///          operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAutoScalingInstances operation.</returns>
        public IAsyncResult BeginDescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest describeAutoScalingInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeAutoScalingInstances(describeAutoScalingInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAutoScalingInstances operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeAutoScalingInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingInstances.</param>
        /// 
        /// <returns>Returns a DescribeAutoScalingInstancesResult from AmazonAutoScaling.</returns>
        public DescribeAutoScalingInstancesResponse EndDescribeAutoScalingInstances(IAsyncResult asyncResult)
        {
            return endOperation<DescribeAutoScalingInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest describeAutoScalingInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAutoScalingInstancesRequestMarshaller().Marshall(describeAutoScalingInstancesRequest);
            var unmarshaller = DescribeAutoScalingInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a description of each Auto Scaling instance in the <c>InstanceIds</c> list. If a list is not provided, the service returns
        /// the full details of all instances up to a maximum of 50. By default, the service returns a list of 20 items. </para> <para> This action
        /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
        /// token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances()
        {
            return DescribeAutoScalingInstances(new DescribeAutoScalingInstancesRequest());
        }
        

        #endregion
    
        #region CreateLaunchConfiguration

        /// <summary>
        /// <para> Creates a new launch configuration. The launch configuration name must be unique within the scope of the client's AWS account. The
        /// maximum limit of launch configurations, which by default is 100, must not yet have been met; otherwise, the call will fail. When created,
        /// the new launch configuration is available for immediate use. </para> <para>You can create a launch configuration with Amazon EC2 security
        /// groups or with Amazon VPC security groups. However, you can't use Amazon EC2 security groups together with Amazon VPC security groups, or
        /// vice versa.</para> <para><b>NOTE:</b> At this time, Auto Scaling launch configurations don't support compressed (e.g. zipped) user data
        /// files. </para>
        /// </summary>
        /// 
        /// <param name="createLaunchConfigurationRequest">Container for the necessary parameters to execute the CreateLaunchConfiguration service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="AlreadyExistsException"/>
        public CreateLaunchConfigurationResponse CreateLaunchConfiguration(CreateLaunchConfigurationRequest createLaunchConfigurationRequest)
        {
            IAsyncResult asyncResult = invokeCreateLaunchConfiguration(createLaunchConfigurationRequest, null, null, true);
            return EndCreateLaunchConfiguration(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.CreateLaunchConfiguration"/>
        /// </summary>
        /// 
        /// <param name="createLaunchConfigurationRequest">Container for the necessary parameters to execute the CreateLaunchConfiguration operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginCreateLaunchConfiguration(CreateLaunchConfigurationRequest createLaunchConfigurationRequest, AsyncCallback callback, object state)
        {
            return invokeCreateLaunchConfiguration(createLaunchConfigurationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.CreateLaunchConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLaunchConfiguration.</param>
        public CreateLaunchConfigurationResponse EndCreateLaunchConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<CreateLaunchConfigurationResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateLaunchConfiguration(CreateLaunchConfigurationRequest createLaunchConfigurationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateLaunchConfigurationRequestMarshaller().Marshall(createLaunchConfigurationRequest);
            var unmarshaller = CreateLaunchConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteAutoScalingGroup

        /// <summary>
        /// <para> Deletes the specified Auto Scaling group if the group has no instances and no scaling activities in progress. </para>
        /// <para><b>NOTE:</b> To remove all instances before calling DeleteAutoScalingGroup, you can call UpdateAutoScalingGroup to set the minimum and
        /// maximum size of the AutoScalingGroup to zero. </para>
        /// </summary>
        /// 
        /// <param name="deleteAutoScalingGroupRequest">Container for the necessary parameters to execute the DeleteAutoScalingGroup service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="ScalingActivityInProgressException"/>
        public DeleteAutoScalingGroupResponse DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest deleteAutoScalingGroupRequest)
        {
            IAsyncResult asyncResult = invokeDeleteAutoScalingGroup(deleteAutoScalingGroupRequest, null, null, true);
            return EndDeleteAutoScalingGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DeleteAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteAutoScalingGroupRequest">Container for the necessary parameters to execute the DeleteAutoScalingGroup operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteAutoScalingGroup(DeleteAutoScalingGroupRequest deleteAutoScalingGroupRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteAutoScalingGroup(deleteAutoScalingGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DeleteAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAutoScalingGroup.</param>
        public DeleteAutoScalingGroupResponse EndDeleteAutoScalingGroup(IAsyncResult asyncResult)
        {
            return endOperation<DeleteAutoScalingGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteAutoScalingGroup(DeleteAutoScalingGroupRequest deleteAutoScalingGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteAutoScalingGroupRequestMarshaller().Marshall(deleteAutoScalingGroupRequest);
            var unmarshaller = DeleteAutoScalingGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DisableMetricsCollection

        /// <summary>
        /// <para> Disables monitoring of group metrics for the Auto Scaling group specified in <c>AutoScalingGroupName</c> .
        /// You can specify the list of affected metrics with the <c>Metrics</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="disableMetricsCollectionRequest">Container for the necessary parameters to execute the DisableMetricsCollection service method
        ///          on AmazonAutoScaling.</param>
        /// 
        public DisableMetricsCollectionResponse DisableMetricsCollection(DisableMetricsCollectionRequest disableMetricsCollectionRequest)
        {
            IAsyncResult asyncResult = invokeDisableMetricsCollection(disableMetricsCollectionRequest, null, null, true);
            return EndDisableMetricsCollection(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DisableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DisableMetricsCollection"/>
        /// </summary>
        /// 
        /// <param name="disableMetricsCollectionRequest">Container for the necessary parameters to execute the DisableMetricsCollection operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDisableMetricsCollection(DisableMetricsCollectionRequest disableMetricsCollectionRequest, AsyncCallback callback, object state)
        {
            return invokeDisableMetricsCollection(disableMetricsCollectionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DisableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DisableMetricsCollection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableMetricsCollection.</param>
        public DisableMetricsCollectionResponse EndDisableMetricsCollection(IAsyncResult asyncResult)
        {
            return endOperation<DisableMetricsCollectionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDisableMetricsCollection(DisableMetricsCollectionRequest disableMetricsCollectionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DisableMetricsCollectionRequestMarshaller().Marshall(disableMetricsCollectionRequest);
            var unmarshaller = DisableMetricsCollectionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateAutoScalingGroup

        /// <summary>
        /// <para> Updates the configuration for the specified AutoScalingGroup. </para> <para><b>NOTE:</b> To update an Auto Scaling group with a
        /// launch configuration that has the InstanceMonitoring flag set to False, you must first ensure that collection of group metrics is disabled.
        /// Otherwise, calls to UpdateAutoScalingGroup will fail. If you have previously enabled group metrics collection, you can disable collection of
        /// all group metrics by calling DisableMetricsCollection. </para> <para> The new settings are registered upon the completion of this call. Any
        /// launch configuration settings take effect on any triggers after this call returns. Scaling activities that are currently in progress aren't
        /// affected. </para> <para><b>NOTE:</b> If a new value is specified for MinSize without specifying the value for DesiredCapacity, and if the
        /// new MinSize is larger than the current size of the Auto Scaling Group, there will be an implicit call to SetDesiredCapacity to set the group
        /// to the new MinSize. If a new value is specified for MaxSize without specifying the value for DesiredCapacity, and the new MaxSize is smaller
        /// than the current size of the Auto Scaling Group, there will be an implicit call to SetDesiredCapacity to set the group to the new MaxSize.
        /// All other optional parameters are left unchanged if not passed in the request. </para>
        /// </summary>
        /// 
        /// <param name="updateAutoScalingGroupRequest">Container for the necessary parameters to execute the UpdateAutoScalingGroup service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <exception cref="ScalingActivityInProgressException"/>
        public UpdateAutoScalingGroupResponse UpdateAutoScalingGroup(UpdateAutoScalingGroupRequest updateAutoScalingGroupRequest)
        {
            IAsyncResult asyncResult = invokeUpdateAutoScalingGroup(updateAutoScalingGroupRequest, null, null, true);
            return EndUpdateAutoScalingGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.UpdateAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="updateAutoScalingGroupRequest">Container for the necessary parameters to execute the UpdateAutoScalingGroup operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUpdateAutoScalingGroup(UpdateAutoScalingGroupRequest updateAutoScalingGroupRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateAutoScalingGroup(updateAutoScalingGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.UpdateAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAutoScalingGroup.</param>
        public UpdateAutoScalingGroupResponse EndUpdateAutoScalingGroup(IAsyncResult asyncResult)
        {
            return endOperation<UpdateAutoScalingGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateAutoScalingGroup(UpdateAutoScalingGroupRequest updateAutoScalingGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateAutoScalingGroupRequestMarshaller().Marshall(updateAutoScalingGroupRequest);
            var unmarshaller = UpdateAutoScalingGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeLaunchConfigurations

        /// <summary>
        /// <para> Returns a full description of the launch configurations, or the specified launch configurations, if they exist. </para> <para> If no
        /// name is specified, then the full details of all launch configurations are returned. </para>
        /// </summary>
        /// 
        /// <param name="describeLaunchConfigurationsRequest">Container for the necessary parameters to execute the DescribeLaunchConfigurations service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest describeLaunchConfigurationsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeLaunchConfigurations(describeLaunchConfigurationsRequest, null, null, true);
            return EndDescribeLaunchConfigurations(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLaunchConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeLaunchConfigurations"/>
        /// </summary>
        /// 
        /// <param name="describeLaunchConfigurationsRequest">Container for the necessary parameters to execute the DescribeLaunchConfigurations
        ///          operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeLaunchConfigurations operation.</returns>
        public IAsyncResult BeginDescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest describeLaunchConfigurationsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeLaunchConfigurations(describeLaunchConfigurationsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLaunchConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeLaunchConfigurations"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLaunchConfigurations.</param>
        /// 
        /// <returns>Returns a DescribeLaunchConfigurationsResult from AmazonAutoScaling.</returns>
        public DescribeLaunchConfigurationsResponse EndDescribeLaunchConfigurations(IAsyncResult asyncResult)
        {
            return endOperation<DescribeLaunchConfigurationsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest describeLaunchConfigurationsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeLaunchConfigurationsRequestMarshaller().Marshall(describeLaunchConfigurationsRequest);
            var unmarshaller = DescribeLaunchConfigurationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a full description of the launch configurations, or the specified launch configurations, if they exist. </para> <para> If no
        /// name is specified, then the full details of all launch configurations are returned. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations()
        {
            return DescribeLaunchConfigurations(new DescribeLaunchConfigurationsRequest());
        }
        

        #endregion
    
        #region DescribeAdjustmentTypes

        /// <summary>
        /// <para> Returns policy adjustment types for use in the PutScalingPolicy action. </para>
        /// </summary>
        /// 
        /// <param name="describeAdjustmentTypesRequest">Container for the necessary parameters to execute the DescribeAdjustmentTypes service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        public DescribeAdjustmentTypesResponse DescribeAdjustmentTypes(DescribeAdjustmentTypesRequest describeAdjustmentTypesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeAdjustmentTypes(describeAdjustmentTypesRequest, null, null, true);
            return EndDescribeAdjustmentTypes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAdjustmentTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeAdjustmentTypes"/>
        /// </summary>
        /// 
        /// <param name="describeAdjustmentTypesRequest">Container for the necessary parameters to execute the DescribeAdjustmentTypes operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAdjustmentTypes operation.</returns>
        public IAsyncResult BeginDescribeAdjustmentTypes(DescribeAdjustmentTypesRequest describeAdjustmentTypesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeAdjustmentTypes(describeAdjustmentTypesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAdjustmentTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeAdjustmentTypes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAdjustmentTypes.</param>
        /// 
        /// <returns>Returns a DescribeAdjustmentTypesResult from AmazonAutoScaling.</returns>
        public DescribeAdjustmentTypesResponse EndDescribeAdjustmentTypes(IAsyncResult asyncResult)
        {
            return endOperation<DescribeAdjustmentTypesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeAdjustmentTypes(DescribeAdjustmentTypesRequest describeAdjustmentTypesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAdjustmentTypesRequestMarshaller().Marshall(describeAdjustmentTypesRequest);
            var unmarshaller = DescribeAdjustmentTypesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns policy adjustment types for use in the PutScalingPolicy action. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        public DescribeAdjustmentTypesResponse DescribeAdjustmentTypes()
        {
            return DescribeAdjustmentTypes(new DescribeAdjustmentTypesRequest());
        }
        

        #endregion
    
        #region DescribeScheduledActions

        /// <summary>
        /// <para> Lists all the actions scheduled for your Auto Scaling group that haven't been executed. To see a list of actions already executed,
        /// see the activity record returned in DescribeScalingActivities. </para>
        /// </summary>
        /// 
        /// <param name="describeScheduledActionsRequest">Container for the necessary parameters to execute the DescribeScheduledActions service method
        ///          on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest describeScheduledActionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeScheduledActions(describeScheduledActionsRequest, null, null, true);
            return EndDescribeScheduledActions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledActions operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeScheduledActions"/>
        /// </summary>
        /// 
        /// <param name="describeScheduledActionsRequest">Container for the necessary parameters to execute the DescribeScheduledActions operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeScheduledActions operation.</returns>
        public IAsyncResult BeginDescribeScheduledActions(DescribeScheduledActionsRequest describeScheduledActionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeScheduledActions(describeScheduledActionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeScheduledActions operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeScheduledActions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScheduledActions.</param>
        /// 
        /// <returns>Returns a DescribeScheduledActionsResult from AmazonAutoScaling.</returns>
        public DescribeScheduledActionsResponse EndDescribeScheduledActions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeScheduledActionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeScheduledActions(DescribeScheduledActionsRequest describeScheduledActionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeScheduledActionsRequestMarshaller().Marshall(describeScheduledActionsRequest);
            var unmarshaller = DescribeScheduledActionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Lists all the actions scheduled for your Auto Scaling group that haven't been executed. To see a list of actions already executed,
        /// see the activity record returned in DescribeScalingActivities. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        public DescribeScheduledActionsResponse DescribeScheduledActions()
        {
            return DescribeScheduledActions(new DescribeScheduledActionsRequest());
        }
        

        #endregion
    
        #region PutScheduledUpdateGroupAction

        /// <summary>
        /// <para> Creates or updates a scheduled scaling action for an Auto Scaling group. When updating a scheduled scaling action, if you leave a
        /// parameter unspecified, the corresponding value remains unchanged in the affected Auto Scaling group. </para> <para>For information on
        /// creating or updating a scheduled action for your Auto Scaling group, see Scale Based on a Schedule.</para> <para><b>NOTE:</b> Auto Scaling
        /// supports the date and time expressed in "YYYY-MM-DDThh:mm:ssZ" format in UTC/GMT only. </para>
        /// </summary>
        /// 
        /// <param name="putScheduledUpdateGroupActionRequest">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction
        ///          service method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="AlreadyExistsException"/>
        public PutScheduledUpdateGroupActionResponse PutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest putScheduledUpdateGroupActionRequest)
        {
            IAsyncResult asyncResult = invokePutScheduledUpdateGroupAction(putScheduledUpdateGroupActionRequest, null, null, true);
            return EndPutScheduledUpdateGroupAction(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutScheduledUpdateGroupAction operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.PutScheduledUpdateGroupAction"/>
        /// </summary>
        /// 
        /// <param name="putScheduledUpdateGroupActionRequest">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction
        ///          operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest putScheduledUpdateGroupActionRequest, AsyncCallback callback, object state)
        {
            return invokePutScheduledUpdateGroupAction(putScheduledUpdateGroupActionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutScheduledUpdateGroupAction operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.PutScheduledUpdateGroupAction"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScheduledUpdateGroupAction.</param>
        public PutScheduledUpdateGroupActionResponse EndPutScheduledUpdateGroupAction(IAsyncResult asyncResult)
        {
            return endOperation<PutScheduledUpdateGroupActionResponse>(asyncResult);
        }
        
        IAsyncResult invokePutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest putScheduledUpdateGroupActionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutScheduledUpdateGroupActionRequestMarshaller().Marshall(putScheduledUpdateGroupActionRequest);
            var unmarshaller = PutScheduledUpdateGroupActionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeMetricCollectionTypes

        /// <summary>
        /// <para> Returns a list of metrics and a corresponding list of granularities for each metric. </para>
        /// </summary>
        /// 
        /// <param name="describeMetricCollectionTypesRequest">Container for the necessary parameters to execute the DescribeMetricCollectionTypes
        ///          service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        public DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest describeMetricCollectionTypesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeMetricCollectionTypes(describeMetricCollectionTypesRequest, null, null, true);
            return EndDescribeMetricCollectionTypes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetricCollectionTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeMetricCollectionTypes"/>
        /// </summary>
        /// 
        /// <param name="describeMetricCollectionTypesRequest">Container for the necessary parameters to execute the DescribeMetricCollectionTypes
        ///          operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeMetricCollectionTypes operation.</returns>
        public IAsyncResult BeginDescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest describeMetricCollectionTypesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeMetricCollectionTypes(describeMetricCollectionTypesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeMetricCollectionTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeMetricCollectionTypes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMetricCollectionTypes.</param>
        /// 
        /// <returns>Returns a DescribeMetricCollectionTypesResult from AmazonAutoScaling.</returns>
        public DescribeMetricCollectionTypesResponse EndDescribeMetricCollectionTypes(IAsyncResult asyncResult)
        {
            return endOperation<DescribeMetricCollectionTypesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest describeMetricCollectionTypesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeMetricCollectionTypesRequestMarshaller().Marshall(describeMetricCollectionTypesRequest);
            var unmarshaller = DescribeMetricCollectionTypesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a list of metrics and a corresponding list of granularities for each metric. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        public DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes()
        {
            return DescribeMetricCollectionTypes(new DescribeMetricCollectionTypesRequest());
        }
        

        #endregion
    
        #region SetDesiredCapacity

        /// <summary>
        /// <para> Sets the desired size of the specified AutoScalingGroup. </para>
        /// </summary>
        /// 
        /// <param name="setDesiredCapacityRequest">Container for the necessary parameters to execute the SetDesiredCapacity service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <exception cref="ScalingActivityInProgressException"/>
        public SetDesiredCapacityResponse SetDesiredCapacity(SetDesiredCapacityRequest setDesiredCapacityRequest)
        {
            IAsyncResult asyncResult = invokeSetDesiredCapacity(setDesiredCapacityRequest, null, null, true);
            return EndSetDesiredCapacity(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetDesiredCapacity operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.SetDesiredCapacity"/>
        /// </summary>
        /// 
        /// <param name="setDesiredCapacityRequest">Container for the necessary parameters to execute the SetDesiredCapacity operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSetDesiredCapacity(SetDesiredCapacityRequest setDesiredCapacityRequest, AsyncCallback callback, object state)
        {
            return invokeSetDesiredCapacity(setDesiredCapacityRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetDesiredCapacity operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.SetDesiredCapacity"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetDesiredCapacity.</param>
        public SetDesiredCapacityResponse EndSetDesiredCapacity(IAsyncResult asyncResult)
        {
            return endOperation<SetDesiredCapacityResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetDesiredCapacity(SetDesiredCapacityRequest setDesiredCapacityRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetDesiredCapacityRequestMarshaller().Marshall(setDesiredCapacityRequest);
            var unmarshaller = SetDesiredCapacityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region TerminateInstanceInAutoScalingGroup

        /// <summary>
        /// <para> Terminates the specified instance. Optionally, the desired group size can be adjusted. </para> <para><b>NOTE:</b> This call simply
        /// registers a termination request. The termination of the instance cannot happen immediately. </para>
        /// </summary>
        /// 
        /// <param name="terminateInstanceInAutoScalingGroupRequest">Container for the necessary parameters to execute the
        ///          TerminateInstanceInAutoScalingGroup service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the TerminateInstanceInAutoScalingGroup service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="ScalingActivityInProgressException"/>
        public TerminateInstanceInAutoScalingGroupResponse TerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest terminateInstanceInAutoScalingGroupRequest)
        {
            IAsyncResult asyncResult = invokeTerminateInstanceInAutoScalingGroup(terminateInstanceInAutoScalingGroupRequest, null, null, true);
            return EndTerminateInstanceInAutoScalingGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstanceInAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.TerminateInstanceInAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="terminateInstanceInAutoScalingGroupRequest">Container for the necessary parameters to execute the
        ///          TerminateInstanceInAutoScalingGroup operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndTerminateInstanceInAutoScalingGroup operation.</returns>
        public IAsyncResult BeginTerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest terminateInstanceInAutoScalingGroupRequest, AsyncCallback callback, object state)
        {
            return invokeTerminateInstanceInAutoScalingGroup(terminateInstanceInAutoScalingGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the TerminateInstanceInAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.TerminateInstanceInAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateInstanceInAutoScalingGroup.</param>
        /// 
        /// <returns>Returns a TerminateInstanceInAutoScalingGroupResult from AmazonAutoScaling.</returns>
        public TerminateInstanceInAutoScalingGroupResponse EndTerminateInstanceInAutoScalingGroup(IAsyncResult asyncResult)
        {
            return endOperation<TerminateInstanceInAutoScalingGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeTerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest terminateInstanceInAutoScalingGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new TerminateInstanceInAutoScalingGroupRequestMarshaller().Marshall(terminateInstanceInAutoScalingGroupRequest);
            var unmarshaller = TerminateInstanceInAutoScalingGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
