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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Container for the parameters to the StartDiscovery operation.
    /// Enables this Amazon Web Services account to be able to use CloudWatch Application
    /// Signals by creating the <i>AWSServiceRoleForCloudWatchApplicationSignals</i> service-linked
    /// role. This service- linked role has the following permissions:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>xray:GetServiceGraph</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>logs:StartQuery</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>logs:GetQueryResults</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>cloudwatch:GetMetricData</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>cloudwatch:ListMetrics</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>tag:GetResources</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>autoscaling:DescribeAutoScalingGroups</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// After completing this step, you still need to instrument your Java and Python applications
    /// to send data to Application Signals. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Application-Signals-Enable.html">
    /// Enabling Application Signals</a>.
    /// </para>
    /// </summary>
    public partial class StartDiscoveryRequest : AmazonApplicationSignalsRequest
    {

    }
}