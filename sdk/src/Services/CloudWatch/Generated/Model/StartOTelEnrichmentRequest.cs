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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the StartOTelEnrichment operation.
    /// Enables enrichment and PromQL access for CloudWatch vended metrics for <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/UsingResourceTagsForTelemetry.html">supported
    /// AWS resources</a> in the account. Once enabled, metrics that contain a resource identifier
    /// dimension (for example, EC2 <c>CPUUtilization</c> with an <c>InstanceId</c> dimension)
    /// are enriched with resource ARN and resource tag labels and become queryable using
    /// PromQL.
    /// 
    ///  
    /// <para>
    /// Before calling this operation, you must enable resource tags on telemetry for your
    /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/EnableResourceTagsOnTelemetry.html">Enable
    /// resource tags on telemetry</a>.
    /// </para>
    /// </summary>
    public partial class StartOTelEnrichmentRequest : AmazonCloudWatchRequest
    {

    }
}