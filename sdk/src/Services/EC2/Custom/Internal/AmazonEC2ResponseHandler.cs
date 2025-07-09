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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.Runtime;
using Amazon.EC2.Model;
using System.IO;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Internal
{
    /// <summary>
    /// Custom pipeline handler.
    /// </summary>
    public class AmazonEC2ResponseHandler : PipelineHandler
    {
        /// <summary>
        /// Calls the post invoke logic after calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            base.InvokeSync(executionContext);
            PostInvoke(executionContext);
        }

        /// <summary>
        /// Calls the and post invoke logic after calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            var response = await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
            PostInvoke(executionContext);
            return response;
        }

        /// <summary>
        /// Custom pipeline handler
        /// </summary>
        /// <param name="executionContext"></param>
        protected virtual void PostInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.OriginalRequest;
            var response = executionContext.ResponseContext.Response;
            var webResponseData = executionContext.ResponseContext.HttpResponse;

            var dsirr = response as DescribeSpotInstanceRequestsResponse;
            if (dsirr != null)
            {
                if (dsirr.SpotInstanceRequests != null)
                {
                    foreach (var spotInstanceRequest in dsirr.SpotInstanceRequests)
                    {
                        var launchSpecification = spotInstanceRequest.LaunchSpecification;
                        PopulateLaunchSpecificationSecurityGroupNames(launchSpecification);
                    }
                }
                return;
            }

            var rsir = response as RequestSpotInstancesResponse;
            if (rsir != null)
            {
                if (rsir.SpotInstanceRequests != null)
                {
                    foreach (var spotInstanceRequest in rsir.SpotInstanceRequests)
                    {
                        var launchSpecification = spotInstanceRequest.LaunchSpecification;
                        PopulateLaunchSpecificationSecurityGroupNames(launchSpecification);
                    }
                }
                return;
            }

            var dir = response as DescribeInstancesResponse;
            if (dir != null)
            {
                if (dir.Reservations != null)
                {
                    foreach (var reservation in dir.Reservations)
                    {
                        PopulateReservationSecurityGroupNames(reservation);
                    }
                }
                return;
            }

            var rir = response as RunInstancesResponse;
            if (rir != null)
            {
                PopulateReservationSecurityGroupNames(rir.Reservation);
                return;
            }
        }

        private static void PopulateLaunchSpecificationSecurityGroupNames(LaunchSpecification launchSpecification)
        {
            if (launchSpecification == null || launchSpecification.AllSecurityGroups == null)
            {
                return;
            }

            var groupNames = new List<string>();
            foreach (GroupIdentifier group in launchSpecification.AllSecurityGroups)
            {
                groupNames.Add(group.GroupName);
            }
            launchSpecification.SecurityGroups = groupNames;
        }

        private static void PopulateReservationSecurityGroupNames(Reservation reservation)
        {
            if (reservation == null || reservation.Groups == null)
            {
                return;
            }

            var groupNames = new List<string>();
            foreach (GroupIdentifier group in reservation.Groups)
            {
                groupNames.Add(group.GroupName);
            }
            reservation.GroupNames = groupNames;
        }
    }
}
