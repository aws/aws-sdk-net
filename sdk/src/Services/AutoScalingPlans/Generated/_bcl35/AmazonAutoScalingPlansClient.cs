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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.AutoScalingPlans.Model;
using Amazon.AutoScalingPlans.Model.Internal.MarshallTransformations;
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
    /// Use AWS Auto Scaling to quickly discover all the scalable AWS resources for your application
    /// and configure dynamic scaling for your scalable resources.
    /// </para>
    ///  
    /// <para>
    /// To get started, create a scaling plan with a set of instructions used to configure
    /// dynamic scaling for the scalable resources in your application. AWS Auto Scaling creates
    /// target tracking scaling policies for the scalable resources in your scaling plan.
    /// Target tracking scaling policies adjust the capacity of your scalable resource as
    /// required to maintain resource utilization at the target value that you specified.
    /// </para>
    /// </summary>
    public partial class AmazonAutoScalingPlansClient : AmazonServiceClient, IAmazonAutoScalingPlans
    {
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
        /// 
        ///  
        /// <para>
        /// A scaling plan contains a set of instructions used to configure dynamic scaling for
        /// the scalable resources in your application. AWS Auto Scaling creates target tracking
        /// scaling policies based on the scaling instructions in your scaling plan.
        /// </para>
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
            var marshaller = CreateScalingPlanRequestMarshaller.Instance;
            var unmarshaller = CreateScalingPlanResponseUnmarshaller.Instance;

            return Invoke<CreateScalingPlanRequest,CreateScalingPlanResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateScalingPlanRequestMarshaller.Instance;
            var unmarshaller = CreateScalingPlanResponseUnmarshaller.Instance;

            return BeginInvoke<CreateScalingPlanRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DeleteScalingPlanRequestMarshaller.Instance;
            var unmarshaller = DeleteScalingPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteScalingPlanRequest,DeleteScalingPlanResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteScalingPlanRequestMarshaller.Instance;
            var unmarshaller = DeleteScalingPlanResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteScalingPlanRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DescribeScalingPlanResourcesRequestMarshaller.Instance;
            var unmarshaller = DescribeScalingPlanResourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingPlanResourcesRequest,DescribeScalingPlanResourcesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeScalingPlanResourcesRequestMarshaller.Instance;
            var unmarshaller = DescribeScalingPlanResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeScalingPlanResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Describes the specified scaling plans or all of your scaling plans.
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
            var marshaller = DescribeScalingPlansRequestMarshaller.Instance;
            var unmarshaller = DescribeScalingPlansResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingPlansRequest,DescribeScalingPlansResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeScalingPlansRequestMarshaller.Instance;
            var unmarshaller = DescribeScalingPlansResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeScalingPlansRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  UpdateScalingPlan

        /// <summary>
        /// Updates the scaling plan for the specified scaling plan.
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
            var marshaller = UpdateScalingPlanRequestMarshaller.Instance;
            var unmarshaller = UpdateScalingPlanResponseUnmarshaller.Instance;

            return Invoke<UpdateScalingPlanRequest,UpdateScalingPlanResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateScalingPlanRequestMarshaller.Instance;
            var unmarshaller = UpdateScalingPlanResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateScalingPlanRequest>(request, marshaller, unmarshaller,
                callback, state);
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