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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
    /// Container for the parameters to the GetHealthCheckStatus operation.
    /// Gets status of a specified health check. 
    /// 
    ///  <important> 
    /// <para>
    /// This API is intended for use during development to diagnose behavior. It doesn’t support
    /// production use-cases with high query rates that require immediate and actionable responses.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class GetHealthCheckStatusRequest : AmazonRoute53Request
    {
        private string _healthCheckId;

        /// <summary>
        /// Gets and sets the property HealthCheckId. 
        /// <para>
        /// The ID for the health check that you want the current status for. When you created
        /// the health check, <c>CreateHealthCheck</c> returned the ID in the response, in the
        /// <c>HealthCheckId</c> element.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you want to check the status of a calculated health check, you must use the Amazon
        /// Route 53 console or the CloudWatch console. You can't use <c>GetHealthCheckStatus</c>
        /// to get the status of a calculated health check.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string HealthCheckId
        {
            get { return this._healthCheckId; }
            set { this._healthCheckId = value; }
        }

        // Check to see if HealthCheckId property is set
        internal bool IsSetHealthCheckId()
        {
            return this._healthCheckId != null;
        }

    }
}