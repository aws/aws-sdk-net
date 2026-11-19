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
    /// Container for the parameters to the CreateHealthCheckSource operation. Creates a health
    /// check source, which defines the virtual private cloud (VPC), subnets, and security
    /// groups from which Route 53 sends private endpoint health check requests. To use this
    /// operation, you must have the <c>route53:CreateHealthCheckSource</c> permission. You
    /// must also have permission to create a service-linked role. <para> Specify a VPC, one
    /// subnet in each Availability Zone that Route 53 uses for private endpoint health checks
    /// in the Amazon Web Services Region, and one or more security groups for each subnet.
    /// The security groups must allow outbound traffic to the endpoints that you want to
    /// check. </para> <para> Route 53 creates a health check source asynchronously, and the
    /// initial <c>HealthCheckSourceStatus</c> is <c>CREATE_PENDING</c>. Call <c>GetHealthCheckSource</c>
    /// until the status is <c>CREATE_COMPLETED</c> before you create health checks that use
    /// the source. You can't change the configuration of a health check source after you
    /// create it. </para> <para> If AWS Identity and Access Management (IAM) is still deleting
    /// the Route 53 service-linked role for your account, the request fails with <c>InvalidInput</c>.
    /// Retry after the deletion completes. </para>
    /// </summary>
    public partial class CreateHealthCheckSourceRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique, case-sensitive identifier that ensures that the operation completes no more
        /// than one time. If you retry a <c>CreateHealthCheckSource</c> request with the same
        /// <c>CallerReference</c> and the same settings as a previous request, Route 53 returns
        /// the existing health check source without creating a duplicate. If that health check
        /// source has a status of <c>CREATE_FAILED</c>, Route 53 tries to create it again. To
        /// create a new health check source after a failure, specify a new value for <c>CallerReference</c>.
        /// If a health check source with the same <c>CallerReference</c> already exists and the
        /// settings differ, Route 53 returns a <c>HealthCheckSourceAlreadyExists</c> error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CallerReference { get; set; }

        /// <summary>
        /// Checks to see if the CallerReference property is set.
        /// </summary>
        internal bool IsSetCallerReference() => this.CallerReference != null;

        /// <summary>
        /// Gets and sets the property HealthCheckSourceConfig. 
        /// <para>
        /// A complex type that contains the virtual private cloud (VPC), subnets, and security
        /// groups for the health check source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HealthCheckSourceConfig HealthCheckSourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckSourceConfig property is set.
        /// </summary>
        internal bool IsSetHealthCheckSourceConfig() => this.HealthCheckSourceConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A complex type that contains a list of the tags that you want to apply to the health
        /// check source when you create it.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
