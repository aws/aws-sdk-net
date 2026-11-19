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
    /// This is the response object from the DeleteHealthCheckSource operation.
    /// </summary>
    public partial class DeleteHealthCheckSourceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property HealthCheckSourceId. 
        /// <para>
        /// The ID of the health check source that is being deleted.
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
        /// The status of the health check source after Route 53 accepts the delete request. The
        /// value is <c>DELETE_PENDING</c>, or the current status if deletion of the health check
        /// source was already in progress.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HealthCheckSourceStatus HealthCheckSourceStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckSourceStatus property is set.
        /// </summary>
        internal bool IsSetHealthCheckSourceStatus() => this.HealthCheckSourceStatus != null;
    }
}
