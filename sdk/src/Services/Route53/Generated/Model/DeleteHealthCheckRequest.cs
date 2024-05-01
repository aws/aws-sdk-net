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
    /// Container for the parameters to the DeleteHealthCheck operation.
    /// Deletes a health check.
    /// 
    ///  <important> 
    /// <para>
    /// Amazon Route 53 does not prevent you from deleting a health check even if the health
    /// check is associated with one or more resource record sets. If you delete a health
    /// check and you don't update the associated resource record sets, the future status
    /// of the health check can't be predicted and may change. This will affect the routing
    /// of DNS queries for your DNS failover configuration. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/health-checks-creating-deleting.html#health-checks-deleting.html">Replacing
    /// and Deleting Health Checks</a> in the <i>Amazon Route 53 Developer Guide</i>.
    /// </para>
    ///  </important> 
    /// <para>
    /// If you're using Cloud Map and you configured Cloud Map to create a Route 53 health
    /// check when you register an instance, you can't use the Route 53 <c>DeleteHealthCheck</c>
    /// command to delete the health check. The health check is deleted automatically when
    /// you deregister the instance; there can be a delay of several hours before the health
    /// check is deleted from Route 53. 
    /// </para>
    /// </summary>
    public partial class DeleteHealthCheckRequest : AmazonRoute53Request
    {
        private string _healthCheckId;

        /// <summary>
        /// Gets and sets the property HealthCheckId. 
        /// <para>
        /// The ID of the health check that you want to delete.
        /// </para>
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