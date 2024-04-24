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
    /// Container for the parameters to the GetHealthCheckLastFailureReason operation.
    /// Gets the reason that a specified health check failed most recently.
    /// </summary>
    public partial class GetHealthCheckLastFailureReasonRequest : AmazonRoute53Request
    {
        private string _healthCheckId;

        /// <summary>
        /// Gets and sets the property HealthCheckId. 
        /// <para>
        /// The ID for the health check for which you want the last failure reason. When you created
        /// the health check, <c>CreateHealthCheck</c> returned the ID in the response, in the
        /// <c>HealthCheckId</c> element.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you want to get the last failure reason for a calculated health check, you must
        /// use the Amazon Route 53 console or the CloudWatch console. You can't use <c>GetHealthCheckLastFailureReason</c>
        /// for a calculated health check.
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