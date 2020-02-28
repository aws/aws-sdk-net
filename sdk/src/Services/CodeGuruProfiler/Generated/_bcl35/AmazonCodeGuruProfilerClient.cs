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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.CodeGuruProfiler.Model;
using Amazon.CodeGuruProfiler.Model.Internal.MarshallTransformations;
using Amazon.CodeGuruProfiler.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CodeGuruProfiler
{
    /// <summary>
    /// Implementation for accessing CodeGuruProfiler
    ///
    /// This section provides documentation for the Amazon CodeGuru Profiler API operations.
    /// </summary>
    public partial class AmazonCodeGuruProfilerClient : AmazonServiceClient, IAmazonCodeGuruProfiler
    {
        private static IServiceMetadata serviceMetadata = new AmazonCodeGuruProfilerMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with the credentials loaded from the application's
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
        public AmazonCodeGuruProfilerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeGuruProfilerConfig()) { }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with the credentials loaded from the application's
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
        public AmazonCodeGuruProfilerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeGuruProfilerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCodeGuruProfilerClient Configuration Object</param>
        public AmazonCodeGuruProfilerClient(AmazonCodeGuruProfilerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodeGuruProfilerClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodeGuruProfilerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeGuruProfilerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodeGuruProfilerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Credentials and an
        /// AmazonCodeGuruProfilerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodeGuruProfilerClient Configuration Object</param>
        public AmazonCodeGuruProfilerClient(AWSCredentials credentials, AmazonCodeGuruProfilerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodeGuruProfilerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeGuruProfilerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeGuruProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeGuruProfilerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeGuruProfilerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodeGuruProfilerClient Configuration Object</param>
        public AmazonCodeGuruProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodeGuruProfilerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodeGuruProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeGuruProfilerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeGuruProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeGuruProfilerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruProfilerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeGuruProfilerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodeGuruProfilerClient Configuration Object</param>
        public AmazonCodeGuruProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodeGuruProfilerConfig clientConfig)
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

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
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


        #region  ConfigureAgent

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureAgent service method.</param>
        /// 
        /// <returns>The response from the ConfigureAgent service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ConfigureAgent">REST API Reference for ConfigureAgent Operation</seealso>
        public virtual ConfigureAgentResponse ConfigureAgent(ConfigureAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureAgentResponseUnmarshaller.Instance;

            return Invoke<ConfigureAgentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureAgent operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfigureAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ConfigureAgent">REST API Reference for ConfigureAgent Operation</seealso>
        public virtual IAsyncResult BeginConfigureAgent(ConfigureAgentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureAgentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ConfigureAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfigureAgent.</param>
        /// 
        /// <returns>Returns a  ConfigureAgentResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ConfigureAgent">REST API Reference for ConfigureAgent Operation</seealso>
        public virtual ConfigureAgentResponse EndConfigureAgent(IAsyncResult asyncResult)
        {
            return EndInvoke<ConfigureAgentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProfilingGroup

        /// <summary>
        /// Creates a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfilingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/intro.html">Service
        /// Quotas</a> to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/CreateProfilingGroup">REST API Reference for CreateProfilingGroup Operation</seealso>
        public virtual CreateProfilingGroupResponse CreateProfilingGroup(CreateProfilingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfilingGroupResponseUnmarshaller.Instance;

            return Invoke<CreateProfilingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProfilingGroup operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProfilingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/CreateProfilingGroup">REST API Reference for CreateProfilingGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateProfilingGroup(CreateProfilingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfilingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProfilingGroup.</param>
        /// 
        /// <returns>Returns a  CreateProfilingGroupResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/CreateProfilingGroup">REST API Reference for CreateProfilingGroup Operation</seealso>
        public virtual CreateProfilingGroupResponse EndCreateProfilingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProfilingGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProfilingGroup

        /// <summary>
        /// Deletes a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfilingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DeleteProfilingGroup">REST API Reference for DeleteProfilingGroup Operation</seealso>
        public virtual DeleteProfilingGroupResponse DeleteProfilingGroup(DeleteProfilingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfilingGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteProfilingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfilingGroup operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProfilingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DeleteProfilingGroup">REST API Reference for DeleteProfilingGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteProfilingGroup(DeleteProfilingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfilingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProfilingGroup.</param>
        /// 
        /// <returns>Returns a  DeleteProfilingGroupResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DeleteProfilingGroup">REST API Reference for DeleteProfilingGroup Operation</seealso>
        public virtual DeleteProfilingGroupResponse EndDeleteProfilingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProfilingGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProfilingGroup

        /// <summary>
        /// Describes a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProfilingGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DescribeProfilingGroup">REST API Reference for DescribeProfilingGroup Operation</seealso>
        public virtual DescribeProfilingGroupResponse DescribeProfilingGroup(DescribeProfilingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProfilingGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeProfilingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProfilingGroup operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProfilingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DescribeProfilingGroup">REST API Reference for DescribeProfilingGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeProfilingGroup(DescribeProfilingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProfilingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProfilingGroup.</param>
        /// 
        /// <returns>Returns a  DescribeProfilingGroupResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DescribeProfilingGroup">REST API Reference for DescribeProfilingGroup Operation</seealso>
        public virtual DescribeProfilingGroupResponse EndDescribeProfilingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProfilingGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProfile

        /// <summary>
        /// Gets the aggregated profile of a profiling group for the specified time range. If
        /// the requested time range does not align with the available aggregated profiles, it
        /// is expanded to attain alignment. If aggregated profiles are available only for part
        /// of the period requested, the profile is returned from the earliest available to the
        /// latest within the requested time range. 
        /// 
        ///  
        /// <para>
        /// For example, if the requested time range is from 00:00 to 00:20 and the available
        /// profiles are from 00:15 to 00:25, the returned profile will be from 00:15 to 00:20.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You must specify exactly two of the following parameters: <code>startTime</code>,
        /// <code>period</code>, and <code>endTime</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual GetProfileResponse GetProfile(GetProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResponseUnmarshaller.Instance;

            return Invoke<GetProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProfile operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual IAsyncResult BeginGetProfile(GetProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProfile.</param>
        /// 
        /// <returns>Returns a  GetProfileResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual GetProfileResponse EndGetProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProfileTimes

        /// <summary>
        /// List the start times of the available aggregated profiles of a profiling group for
        /// an aggregation period within the specified time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileTimes service method.</param>
        /// 
        /// <returns>The response from the ListProfileTimes service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfileTimes">REST API Reference for ListProfileTimes Operation</seealso>
        public virtual ListProfileTimesResponse ListProfileTimes(ListProfileTimesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfileTimesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileTimesResponseUnmarshaller.Instance;

            return Invoke<ListProfileTimesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfileTimes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfileTimes operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfileTimes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfileTimes">REST API Reference for ListProfileTimes Operation</seealso>
        public virtual IAsyncResult BeginListProfileTimes(ListProfileTimesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfileTimesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileTimesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfileTimes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfileTimes.</param>
        /// 
        /// <returns>Returns a  ListProfileTimesResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfileTimes">REST API Reference for ListProfileTimes Operation</seealso>
        public virtual ListProfileTimesResponse EndListProfileTimes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProfileTimesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProfilingGroups

        /// <summary>
        /// Lists profiling groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfilingGroups service method.</param>
        /// 
        /// <returns>The response from the ListProfilingGroups service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfilingGroups">REST API Reference for ListProfilingGroups Operation</seealso>
        public virtual ListProfilingGroupsResponse ListProfilingGroups(ListProfilingGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfilingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilingGroupsResponseUnmarshaller.Instance;

            return Invoke<ListProfilingGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfilingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfilingGroups operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfilingGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfilingGroups">REST API Reference for ListProfilingGroups Operation</seealso>
        public virtual IAsyncResult BeginListProfilingGroups(ListProfilingGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfilingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilingGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfilingGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfilingGroups.</param>
        /// 
        /// <returns>Returns a  ListProfilingGroupsResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfilingGroups">REST API Reference for ListProfilingGroups Operation</seealso>
        public virtual ListProfilingGroupsResponse EndListProfilingGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProfilingGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  PostAgentProfile

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostAgentProfile service method.</param>
        /// 
        /// <returns>The response from the PostAgentProfile service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/PostAgentProfile">REST API Reference for PostAgentProfile Operation</seealso>
        public virtual PostAgentProfileResponse PostAgentProfile(PostAgentProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostAgentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostAgentProfileResponseUnmarshaller.Instance;

            return Invoke<PostAgentProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PostAgentProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostAgentProfile operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPostAgentProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/PostAgentProfile">REST API Reference for PostAgentProfile Operation</seealso>
        public virtual IAsyncResult BeginPostAgentProfile(PostAgentProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostAgentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostAgentProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PostAgentProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPostAgentProfile.</param>
        /// 
        /// <returns>Returns a  PostAgentProfileResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/PostAgentProfile">REST API Reference for PostAgentProfile Operation</seealso>
        public virtual PostAgentProfileResponse EndPostAgentProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<PostAgentProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProfilingGroup

        /// <summary>
        /// Updates a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfilingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/UpdateProfilingGroup">REST API Reference for UpdateProfilingGroup Operation</seealso>
        public virtual UpdateProfilingGroupResponse UpdateProfilingGroup(UpdateProfilingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfilingGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateProfilingGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfilingGroup operation on AmazonCodeGuruProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProfilingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/UpdateProfilingGroup">REST API Reference for UpdateProfilingGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateProfilingGroup(UpdateProfilingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProfilingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfilingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProfilingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProfilingGroup.</param>
        /// 
        /// <returns>Returns a  UpdateProfilingGroupResult from CodeGuruProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/UpdateProfilingGroup">REST API Reference for UpdateProfilingGroup Operation</seealso>
        public virtual UpdateProfilingGroupResponse EndUpdateProfilingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProfilingGroupResponse>(asyncResult);
        }

        #endregion
        
    }
}