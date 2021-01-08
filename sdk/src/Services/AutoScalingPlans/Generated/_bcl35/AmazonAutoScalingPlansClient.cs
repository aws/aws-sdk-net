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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.AutoScalingPlans.Model;
using Amazon.AutoScalingPlans.Model.Internal.MarshallTransformations;
using Amazon.AutoScalingPlans.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScalingPlans
{
    /// <summary>
    /// Implementation for accessing AutoScalingPlans
    ///
    /// AWS Auto Scaling 
    /// <para>
    /// Use AWS Auto Scaling to create scaling plans for your applications to automatically
    /// scale your scalable AWS resources. 
    /// </para>
    ///  
    /// <para>
    ///  <b>API Summary</b> 
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS Auto Scaling service API to accomplish the following tasks:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Create and manage scaling plans
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Define target tracking scaling policies to dynamically scale your resources based
    /// on utilization
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Scale Amazon EC2 Auto Scaling groups using predictive scaling and dynamic scaling
    /// to scale your Amazon EC2 capacity faster
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Set minimum and maximum capacity limits
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Retrieve information on existing scaling plans
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Access current forecast data and historical forecast data for up to 56 days previous
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To learn more about AWS Auto Scaling, including information about granting IAM users
    /// required permissions for AWS Auto Scaling actions, see the <a href="https://docs.aws.amazon.com/autoscaling/plans/userguide/what-is-aws-auto-scaling.html">AWS
    /// Auto Scaling User Guide</a>. 
    /// </para>
    /// </summary>
    public partial class AmazonAutoScalingPlansClient : AmazonServiceClient, IAmazonAutoScalingPlans
    {
        private static IServiceMetadata serviceMetadata = new AmazonAutoScalingPlansMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with the credentials loaded from the application's
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
        public AmazonAutoScalingPlansClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAutoScalingPlansConfig()) { }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with the credentials loaded from the application's
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
        public AmazonAutoScalingPlansClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAutoScalingPlansConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAutoScalingPlansClient Configuration Object</param>
        public AmazonAutoScalingPlansClient(AmazonAutoScalingPlansConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAutoScalingPlansClient(AWSCredentials credentials)
            : this(credentials, new AmazonAutoScalingPlansConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingPlansClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAutoScalingPlansConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Credentials and an
        /// AmazonAutoScalingPlansClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAutoScalingPlansClient Configuration Object</param>
        public AmazonAutoScalingPlansClient(AWSCredentials credentials, AmazonAutoScalingPlansConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAutoScalingPlansClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAutoScalingPlansConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingPlansClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAutoScalingPlansConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAutoScalingPlansClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAutoScalingPlansClient Configuration Object</param>
        public AmazonAutoScalingPlansClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAutoScalingPlansConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAutoScalingPlansClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAutoScalingPlansConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingPlansClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAutoScalingPlansConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAutoScalingPlansClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAutoScalingPlansClient Configuration Object</param>
        public AmazonAutoScalingPlansClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAutoScalingPlansConfig clientConfig)
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


        #region  CreateScalingPlan

        /// <summary>
        /// Creates a scaling plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScalingPlan service method.</param>
        /// 
        /// <returns>The response from the CreateScalingPlan service method, as returned by AutoScalingPlans.</returns>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to a
        /// scaling plan that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.LimitExceededException">
        /// Your account exceeded a limit. This exception is thrown when a per-account resource
        /// limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the parameters provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/CreateScalingPlan">REST API Reference for CreateScalingPlan Operation</seealso>
        public virtual CreateScalingPlanResponse CreateScalingPlan(CreateScalingPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScalingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScalingPlanResponseUnmarshaller.Instance;

            return Invoke<CreateScalingPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScalingPlan operation on AmazonAutoScalingPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateScalingPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/CreateScalingPlan">REST API Reference for CreateScalingPlan Operation</seealso>
        public virtual IAsyncResult BeginCreateScalingPlan(CreateScalingPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScalingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScalingPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateScalingPlan.</param>
        /// 
        /// <returns>Returns a  CreateScalingPlanResult from AutoScalingPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/CreateScalingPlan">REST API Reference for CreateScalingPlan Operation</seealso>
        public virtual CreateScalingPlanResponse EndCreateScalingPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateScalingPlanResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteScalingPlan

        /// <summary>
        /// Deletes the specified scaling plan.
        /// 
        ///  
        /// <para>
        /// Deleting a scaling plan deletes the underlying <a>ScalingInstruction</a> for all of
        /// the scalable resources that are covered by the plan.
        /// </para>
        ///  
        /// <para>
        /// If the plan has launched resources or has scaling activities in progress, you must
        /// delete those resources separately.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPlan service method.</param>
        /// 
        /// <returns>The response from the DeleteScalingPlan service method, as returned by AutoScalingPlans.</returns>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to a
        /// scaling plan that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ObjectNotFoundException">
        /// The specified object could not be found.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the parameters provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DeleteScalingPlan">REST API Reference for DeleteScalingPlan Operation</seealso>
        public virtual DeleteScalingPlanResponse DeleteScalingPlan(DeleteScalingPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScalingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScalingPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteScalingPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPlan operation on AmazonAutoScalingPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScalingPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DeleteScalingPlan">REST API Reference for DeleteScalingPlan Operation</seealso>
        public virtual IAsyncResult BeginDeleteScalingPlan(DeleteScalingPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScalingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScalingPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScalingPlan.</param>
        /// 
        /// <returns>Returns a  DeleteScalingPlanResult from AutoScalingPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DeleteScalingPlan">REST API Reference for DeleteScalingPlan Operation</seealso>
        public virtual DeleteScalingPlanResponse EndDeleteScalingPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteScalingPlanResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeScalingPlanResources

        /// <summary>
        /// Describes the scalable resources in the specified scaling plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPlanResources service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingPlanResources service method, as returned by AutoScalingPlans.</returns>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to a
        /// scaling plan that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.InvalidNextTokenException">
        /// The token provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the parameters provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlanResources">REST API Reference for DescribeScalingPlanResources Operation</seealso>
        public virtual DescribeScalingPlanResourcesResponse DescribeScalingPlanResources(DescribeScalingPlanResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingPlanResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingPlanResourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingPlanResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPlanResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPlanResources operation on AmazonAutoScalingPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScalingPlanResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlanResources">REST API Reference for DescribeScalingPlanResources Operation</seealso>
        public virtual IAsyncResult BeginDescribeScalingPlanResources(DescribeScalingPlanResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingPlanResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingPlanResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingPlanResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingPlanResources.</param>
        /// 
        /// <returns>Returns a  DescribeScalingPlanResourcesResult from AutoScalingPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlanResources">REST API Reference for DescribeScalingPlanResources Operation</seealso>
        public virtual DescribeScalingPlanResourcesResponse EndDescribeScalingPlanResources(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScalingPlanResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeScalingPlans

        /// <summary>
        /// Describes one or more of your scaling plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPlans service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingPlans service method, as returned by AutoScalingPlans.</returns>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to a
        /// scaling plan that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.InvalidNextTokenException">
        /// The token provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the parameters provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlans">REST API Reference for DescribeScalingPlans Operation</seealso>
        public virtual DescribeScalingPlansResponse DescribeScalingPlans(DescribeScalingPlansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingPlansResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingPlansResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPlans operation on AmazonAutoScalingPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScalingPlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlans">REST API Reference for DescribeScalingPlans Operation</seealso>
        public virtual IAsyncResult BeginDescribeScalingPlans(DescribeScalingPlansRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingPlansResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingPlans.</param>
        /// 
        /// <returns>Returns a  DescribeScalingPlansResult from AutoScalingPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlans">REST API Reference for DescribeScalingPlans Operation</seealso>
        public virtual DescribeScalingPlansResponse EndDescribeScalingPlans(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScalingPlansResponse>(asyncResult);
        }

        #endregion
        
        #region  GetScalingPlanResourceForecastData

        /// <summary>
        /// Retrieves the forecast data for a scalable resource.
        /// 
        ///  
        /// <para>
        /// Capacity forecasts are represented as predicted values, or data points, that are calculated
        /// using historical data points from a specified CloudWatch load metric. Data points
        /// are available for up to 56 days. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScalingPlanResourceForecastData service method.</param>
        /// 
        /// <returns>The response from the GetScalingPlanResourceForecastData service method, as returned by AutoScalingPlans.</returns>
        /// <exception cref="Amazon.AutoScalingPlans.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the parameters provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/GetScalingPlanResourceForecastData">REST API Reference for GetScalingPlanResourceForecastData Operation</seealso>
        public virtual GetScalingPlanResourceForecastDataResponse GetScalingPlanResourceForecastData(GetScalingPlanResourceForecastDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetScalingPlanResourceForecastDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScalingPlanResourceForecastDataResponseUnmarshaller.Instance;

            return Invoke<GetScalingPlanResourceForecastDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetScalingPlanResourceForecastData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetScalingPlanResourceForecastData operation on AmazonAutoScalingPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetScalingPlanResourceForecastData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/GetScalingPlanResourceForecastData">REST API Reference for GetScalingPlanResourceForecastData Operation</seealso>
        public virtual IAsyncResult BeginGetScalingPlanResourceForecastData(GetScalingPlanResourceForecastDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetScalingPlanResourceForecastDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScalingPlanResourceForecastDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetScalingPlanResourceForecastData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetScalingPlanResourceForecastData.</param>
        /// 
        /// <returns>Returns a  GetScalingPlanResourceForecastDataResult from AutoScalingPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/GetScalingPlanResourceForecastData">REST API Reference for GetScalingPlanResourceForecastData Operation</seealso>
        public virtual GetScalingPlanResourceForecastDataResponse EndGetScalingPlanResourceForecastData(IAsyncResult asyncResult)
        {
            return EndInvoke<GetScalingPlanResourceForecastDataResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateScalingPlan

        /// <summary>
        /// Updates the specified scaling plan.
        /// 
        ///  
        /// <para>
        /// You cannot update a scaling plan if it is in the process of being created, updated,
        /// or deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScalingPlan service method.</param>
        /// 
        /// <returns>The response from the UpdateScalingPlan service method, as returned by AutoScalingPlans.</returns>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to a
        /// scaling plan that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ObjectNotFoundException">
        /// The specified object could not be found.
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the parameters provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/UpdateScalingPlan">REST API Reference for UpdateScalingPlan Operation</seealso>
        public virtual UpdateScalingPlanResponse UpdateScalingPlan(UpdateScalingPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScalingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScalingPlanResponseUnmarshaller.Instance;

            return Invoke<UpdateScalingPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScalingPlan operation on AmazonAutoScalingPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateScalingPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/UpdateScalingPlan">REST API Reference for UpdateScalingPlan Operation</seealso>
        public virtual IAsyncResult BeginUpdateScalingPlan(UpdateScalingPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScalingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScalingPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateScalingPlan.</param>
        /// 
        /// <returns>Returns a  UpdateScalingPlanResult from AutoScalingPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/UpdateScalingPlan">REST API Reference for UpdateScalingPlan Operation</seealso>
        public virtual UpdateScalingPlanResponse EndUpdateScalingPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateScalingPlanResponse>(asyncResult);
        }

        #endregion
        
    }
}