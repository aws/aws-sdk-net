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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AutoScalingPlans.Model;

namespace Amazon.AutoScalingPlans
{
    /// <summary>
    /// Interface for accessing AutoScalingPlans
    ///
    /// AWS Auto Scaling 
    /// <para>
    /// Use AWS Auto Scaling to quickly discover all the scalable AWS resources for your application
    /// and configure dynamic scaling and predictive scaling for your resources using scaling
    /// plans. Use this service in conjunction with the Amazon EC2 Auto Scaling, Application
    /// Auto Scaling, Amazon CloudWatch, and AWS CloudFormation services. 
    /// </para>
    ///  
    /// <para>
    /// Currently, predictive scaling is only available for Amazon EC2 Auto Scaling groups.
    /// </para>
    ///  
    /// <para>
    /// For more information about AWS Auto Scaling, see the <a href="http://docs.aws.amazon.com/autoscaling/plans/userguide/what-is-aws-auto-scaling.html">AWS
    /// Auto Scaling User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonAutoScalingPlans : IAmazonService, IDisposable
    {

        
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
        CreateScalingPlanResponse CreateScalingPlan(CreateScalingPlanRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScalingPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/CreateScalingPlan">REST API Reference for CreateScalingPlan Operation</seealso>
        Task<CreateScalingPlanResponse> CreateScalingPlanAsync(CreateScalingPlanRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteScalingPlanResponse DeleteScalingPlan(DeleteScalingPlanRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DeleteScalingPlan">REST API Reference for DeleteScalingPlan Operation</seealso>
        Task<DeleteScalingPlanResponse> DeleteScalingPlanAsync(DeleteScalingPlanRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeScalingPlanResourcesResponse DescribeScalingPlanResources(DescribeScalingPlanResourcesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPlanResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPlanResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlanResources">REST API Reference for DescribeScalingPlanResources Operation</seealso>
        Task<DescribeScalingPlanResourcesResponse> DescribeScalingPlanResourcesAsync(DescribeScalingPlanResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeScalingPlansResponse DescribeScalingPlans(DescribeScalingPlansRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPlans operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlans">REST API Reference for DescribeScalingPlans Operation</seealso>
        Task<DescribeScalingPlansResponse> DescribeScalingPlansAsync(DescribeScalingPlansRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetScalingPlanResourceForecastDataResponse GetScalingPlanResourceForecastData(GetScalingPlanResourceForecastDataRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetScalingPlanResourceForecastData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetScalingPlanResourceForecastData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/GetScalingPlanResourceForecastData">REST API Reference for GetScalingPlanResourceForecastData Operation</seealso>
        Task<GetScalingPlanResourceForecastDataResponse> GetScalingPlanResourceForecastDataAsync(GetScalingPlanResourceForecastDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateScalingPlanResponse UpdateScalingPlan(UpdateScalingPlanRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScalingPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/UpdateScalingPlan">REST API Reference for UpdateScalingPlan Operation</seealso>
        Task<UpdateScalingPlanResponse> UpdateScalingPlanAsync(UpdateScalingPlanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}