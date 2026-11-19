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
    /// A complex type that contains information about one health check that is associated
    /// with the current Amazon Web Services account.
    /// </summary>
    public partial class HealthCheck
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier that Amazon Route 53 assigned to the health check when you created
        /// it. When you add or update a resource record set, you use this value to specify which
        /// health check to use. The value can be up to 64 characters long. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique string that you specified when you created the health check.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CallerReference { get; set; }

        /// <summary>
        /// Checks to see if the CallerReference property is set.
        /// </summary>
        internal bool IsSetCallerReference() => this.CallerReference != null;

        /// <summary>
        /// Gets and sets the property LinkedService. 
        /// <para>
        /// If the health check was created by another service, the service that created the health
        /// check. When a health check is created by another service, you can't edit or delete
        /// it using Amazon Route 53. 
        /// </para>
        /// </summary>
        public LinkedService LinkedService { get; set; }

        /// <summary>
        /// Checks to see if the LinkedService property is set.
        /// </summary>
        internal bool IsSetLinkedService() => this.LinkedService != null;

        /// <summary>
        /// Gets and sets the property HealthCheckConfig. 
        /// <para>
        /// A complex type that contains detailed information about one health check.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HealthCheckConfig HealthCheckConfig { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckConfig property is set.
        /// </summary>
        internal bool IsSetHealthCheckConfig() => this.HealthCheckConfig != null;

        /// <summary>
        /// Gets and sets the property HealthCheckVersion. 
        /// <para>
        /// The version of the health check. You can optionally pass this value in a call to <c>UpdateHealthCheck</c>
        /// to prevent overwriting another change to the health check.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public long? HealthCheckVersion { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckVersion property is set.
        /// </summary>
        internal bool IsSetHealthCheckVersion() => this.HealthCheckVersion.HasValue;

        /// <summary>
        /// Gets and sets the property CloudWatchAlarmConfiguration. 
        /// <para>
        /// A complex type that contains information about the CloudWatch alarm that Amazon Route
        /// 53 is monitoring for this health check.
        /// </para>
        /// </summary>
        public CloudWatchAlarmConfiguration CloudWatchAlarmConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchAlarmConfiguration property is set.
        /// </summary>
        internal bool IsSetCloudWatchAlarmConfiguration() => this.CloudWatchAlarmConfiguration != null;
    }
}
