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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains information about a health check source: its ID, its
    /// status, and the virtual private cloud (VPC), subnets, and security groups from which
    /// Route 53 sends health check requests to private endpoints.
    /// </summary>
    public partial class HealthCheckSource
    {
        /// <summary>
        /// Gets and sets the property HealthCheckSourceId. 
        /// <para>
        /// The ID of the health check source. Route 53 assigns this ID when it creates the source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string HealthCheckSourceId { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckSourceId property is set.
        /// </summary>
        internal bool IsSetHealthCheckSourceId() => this.HealthCheckSourceId != null;

        /// <summary>
        /// Gets and sets the property HealthCheckSourceStatus. 
        /// <para>
        /// The current status of the health check source. The health check source status can
        /// have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_PENDING</c> - Route 53 accepted the request to create the source and hasn't
        /// started creating it. You can't use the source in a health check until its status is
        /// <c>CREATE_COMPLETED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_IN_PROGRESS</c> - Route 53 is creating the source. You can't use the source
        /// in a health check until its status is <c>CREATE_COMPLETED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_COMPLETED</c> - The source is ready to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c> - Route 53 couldn't create the source. <c>StatusReasonCode</c>
        /// and <c>StatusReason</c> explain why.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_PENDING</c> - Route 53 accepted the request to delete the source and hasn't
        /// started deleting it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_IN_PROGRESS</c> - Route 53 is deleting the source.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_COMPLETED</c> - Route 53 has deleted the source. You can't retrieve a health
        /// check source in this status: <c>GetHealthCheckSource</c> returns <c>NoSuchHealthCheckSource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_FAILED</c> - Route 53 couldn't delete the source. <c>StatusReasonCode</c>
        /// and <c>StatusReason</c> explain why.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the status is <c>CREATE_FAILED</c>, fix the cause that <c>StatusReasonCode</c>
        /// indicates, and then either retry <c>CreateHealthCheckSource</c> with the same <c>CallerReference</c>
        /// and settings, or delete the source and create a new one. If the status is <c>DELETE_FAILED</c>,
        /// retry the <c>DeleteHealthCheckSource</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HealthCheckSourceStatus HealthCheckSourceStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckSourceStatus property is set.
        /// </summary>
        internal bool IsSetHealthCheckSourceStatus() => this.HealthCheckSourceStatus != null;

        /// <summary>
        /// Gets and sets the property HealthCheckSourceConfig. 
        /// <para>
        /// The virtual private cloud (VPC), subnets, and security groups for the health check
        /// source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HealthCheckSourceConfig HealthCheckSourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckSourceConfig property is set.
        /// </summary>
        internal bool IsSetHealthCheckSourceConfig() => this.HealthCheckSourceConfig != null;

        /// <summary>
        /// Gets and sets the property StatusReasonCode. 
        /// <para>
        /// A code that indicates why the health check source has a status of <c>CREATE_FAILED</c>
        /// or <c>DELETE_FAILED</c>. Route 53 returns this member only when the status is one
        /// of those values. The code can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_SUBNET_IPS</c> - One of the specified subnets doesn't have enough
        /// free private IP addresses. Check the available IP addresses in each subnet, and delete
        /// network interfaces that you don't need.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EC2_LIMIT_EXCEEDED</c> - Your account reached an Amazon virtual private cloud
        /// (VPC) quota for network interfaces or security groups. Delete network interfaces that
        /// you don't need, specify fewer security groups, or request a quota increase.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_SUBNET</c> - One of the specified subnets doesn't exist or isn't valid,
        /// or an <c>AvailabilityZoneId</c> doesn't match the Availability Zone of its subnet.
        /// Check that each subnet ID is correct, that the subnet exists, and that each <c>AvailabilityZoneId</c>
        /// matches its subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_SECURITY_GROUP</c> - One of the specified security groups doesn't exist
        /// or isn't valid. Check that each security group ID is correct and that the security
        /// group exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_CONFIGURATION</c> - The combination of VPC, subnets, and security groups
        /// isn't valid. Check that <c>VpcId</c> is correct and exists, that each subnet is in
        /// that VPC, and that the security groups for each subnet are in the same VPC as that
        /// subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SLR_MISSING_OR_NOT_ASSUMABLE</c> - Route 53 couldn't assume its service-linked
        /// role in your account. In IAM, check that the service-linked role for Route 53 private
        /// endpoint health checks exists and that no deletion task for it is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTERNAL_ERROR</c> - Route 53 encountered an internal error. Contact Amazon Web
        /// Services Support and provide the health check source ID.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public HealthCheckSourceStatusReasonCode StatusReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusReasonCode property is set.
        /// </summary>
        internal bool IsSetStatusReasonCode() => this.StatusReasonCode != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A description of why the health check source has a status of <c>CREATE_FAILED</c>
        /// or <c>DELETE_FAILED</c>, and what you can do about it. The text corresponds to the
        /// value of <c>StatusReasonCode</c>. Route 53 returns this member only when <c>StatusReasonCode</c>
        /// is present.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
