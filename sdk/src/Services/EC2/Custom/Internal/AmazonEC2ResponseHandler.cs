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
#if AWS_ASYNC_API 

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

#elif AWS_APM_API

        /// <summary>
        /// Calls the PostInvoke methods after calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
        {
            // Process the response if an exception hasn't occured
            if (executionContext.ResponseContext.AsyncResult.Exception == null)
            {
                PostInvoke(ExecutionContext.CreateFromAsyncContext(executionContext));
            }
            base.InvokeAsyncCallback(executionContext);
        }
#endif

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

            // In case of DescribeSecurityGroupsResponse type, the Ipv4Ranges values for each of the retured IpPermissions is unmarshalled
            // and the extracted Cidr values is set on the IpRanges property of IpPermission. If the customer is using IpRanges, then they will not be broken.
            var describeSecurityGroupsResponse = response as DescribeSecurityGroupsResponse;
            if(describeSecurityGroupsResponse!=null)
            {
                if(describeSecurityGroupsResponse.IsSetSecurityGroups())
                {
                    foreach (var securityGroup in describeSecurityGroupsResponse.SecurityGroups)
                    {
                        if (securityGroup.IsSetIpPermissions())
                        {
                            SetIpRangesProperty(securityGroup.IpPermissions);
                        }
                        else if(securityGroup.IsSetIpPermissionsEgress())
                        {
                            SetIpRangesProperty(securityGroup.IpPermissionsEgress);
                        }
                    }
                }
                return;
            }

            var authorizeSecurityGroupEgressRequest = request as AuthorizeSecurityGroupEgressRequest;
            if (authorizeSecurityGroupEgressRequest != null)
                if (authorizeSecurityGroupEgressRequest.IsSetIpPermissions())
                {
                    RestoreRequestIpPermissions(authorizeSecurityGroupEgressRequest.IpPermissions);
                    return;
                }

            var authorizeSecurityGroupIngressRequest = request as AuthorizeSecurityGroupIngressRequest;
            if (authorizeSecurityGroupIngressRequest != null)
                if (authorizeSecurityGroupIngressRequest.IsSetIpPermissions())
                {
                    RestoreRequestIpPermissions(authorizeSecurityGroupIngressRequest.IpPermissions);
                    return;
                }
                    

            var revokeSecurityGroupEgressRequest = request as RevokeSecurityGroupEgressRequest;
            if (revokeSecurityGroupEgressRequest != null)
                if (revokeSecurityGroupEgressRequest.IsSetIpPermissions())
                {
                    RestoreRequestIpPermissions(revokeSecurityGroupEgressRequest.IpPermissions);
                    return;
                }
                    

            var revokeSecurityGroupIngressRequest = request as RevokeSecurityGroupIngressRequest;
            if (revokeSecurityGroupIngressRequest != null)
                if (revokeSecurityGroupIngressRequest.IsSetIpPermissions())
                {
                    RestoreRequestIpPermissions(revokeSecurityGroupIngressRequest.IpPermissions);
                    return;
                }
                    

            var updateSecurityGroupRuleDescriptionsEgressRequest = request as UpdateSecurityGroupRuleDescriptionsEgressRequest;
            if (updateSecurityGroupRuleDescriptionsEgressRequest != null)
                if (updateSecurityGroupRuleDescriptionsEgressRequest.IsSetIpPermissions())
                {
                    RestoreRequestIpPermissions(updateSecurityGroupRuleDescriptionsEgressRequest.IpPermissions);
                    return;
                }
                    

            var updateSecurityGroupRuleDescriptionsIngressRequest = request as UpdateSecurityGroupRuleDescriptionsIngressRequest;
            if (updateSecurityGroupRuleDescriptionsIngressRequest != null)
                if (updateSecurityGroupRuleDescriptionsIngressRequest.IsSetIpPermissions())
                {
                    RestoreRequestIpPermissions(updateSecurityGroupRuleDescriptionsIngressRequest.IpPermissions);
                    return;
                }
                    
        }

        /// <summary>
        /// Cidr values from Ipv4Ranges is extracted and set on IpRanges.
        /// The internal dictionary collection is also set to the Ipv4Range values.
        /// </summary>
        /// <param name="ipPermissions"></param>
        private static void SetIpRangesProperty(List<IpPermission> ipPermissions)
        {
            foreach (var ipPermission in ipPermissions)
            {
                ipPermission.IpRanges = ipPermission.Ipv4Ranges.Select(i => i.CidrIp).ToList();
                ipPermission.CopyIpv4RangesToInternalCollection(ipPermission.Ipv4Ranges);
            }
        }
        /// <summary>
        /// The original values used by the customer in the Ipv4Ranges property on the request 
        /// object is restored. This is done when the customer is using the deprecated IpRanges property.
        /// </summary>
        /// <param name="IpPermissions"></param>
        private static void RestoreRequestIpPermissions(List<IpPermission> IpPermissions)
        {
            foreach (var ipPermission in IpPermissions)
            {
                if(ipPermission.RestoreOldIpV4Range)
                {
                    ipPermission.Ipv4Ranges = ipPermission.PreIpv4Ranges;
                    ipPermission.RestoreOldIpV4Range = false;
                }
                    
            }
        }

        private static void PopulateLaunchSpecificationSecurityGroupNames(LaunchSpecification launchSpecification)
        {
            if (launchSpecification != null)
            {
                var groupNames = new List<string>();
                foreach (GroupIdentifier group in launchSpecification.AllSecurityGroups)
                {
                    groupNames.Add(group.GroupName);
                }
                launchSpecification.SecurityGroups = groupNames;
            }
        }

        private static void PopulateReservationSecurityGroupNames(Reservation reservation)
        {
            if (reservation != null)
            {
                var groupNames = new List<string>();
                foreach (GroupIdentifier group in reservation.Groups)
                {
                    groupNames.Add(group.GroupName);
                }
                reservation.GroupNames = groupNames;
            }
        }
    }
}
