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
    /// Container for the parameters to the DeleteHealthCheckSource operation. Deletes a health
    /// check source. Before you delete a health check source, delete or update any health
    /// checks that reference it. Otherwise, the request fails with <c>InvalidInput</c>. The
    /// request also fails with <c>InvalidInput</c> if the status of the health check source
    /// is <c>CREATE_PENDING</c> or <c>CREATE_IN_PROGRESS</c>. Wait until the status is <c>CREATE_COMPLETED</c>
    /// or <c>CREATE_FAILED</c>, and then try again. <para> Route 53 deletes a health check
    /// source asynchronously, and the initial <c>HealthCheckSourceStatus</c> is <c>DELETE_PENDING</c>.
    /// Call <c>GetHealthCheckSource</c> to track progress. After the deletion completes,
    /// <c>GetHealthCheckSource</c> returns <c>NoSuchHealthCheckSource</c> and the health
    /// check source no longer appears in the results of <c>ListHealthCheckSources</c>. If
    /// you delete a health check source that is already deleted, the request fails with <c>NoSuchHealthCheckSource</c>.
    /// </para> <para> To use this operation, you must have the <c>route53:DeleteHealthCheckSource</c>
    /// permission. You must also have permission to create a service-linked role. </para>
    /// </summary>
    public partial class DeleteHealthCheckSourceRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property HealthCheckSourceId. 
        /// <para>
        /// The ID of the health check source that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string HealthCheckSourceId { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckSourceId property is set.
        /// </summary>
        internal bool IsSetHealthCheckSourceId() => this.HealthCheckSourceId != null;
    }
}
