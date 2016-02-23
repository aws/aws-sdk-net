/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteHealthCheck operation.
    /// This action deletes a health check. To delete a health check, send a <code>DELETE</code>
    /// request to the <code>/<i>Route 53 API version</i>/healthcheck/<i>health check ID</i></code>
    /// resource.
    /// 
    ///  <important> You can delete a health check only if there are no resource record sets
    /// associated with this health check. If resource record sets are associated with this
    /// health check, you must disassociate them before you can delete your health check.
    /// If you try to delete a health check that is associated with resource record sets,
    /// Amazon Route 53 will deny your request with a <code>HealthCheckInUse</code> error.
    /// For information about disassociating the records from your health check, see <a>ChangeResourceRecordSets</a>.</important>
    /// </summary>
    public partial class DeleteHealthCheckRequest : AmazonRoute53Request
    {
        private string _healthCheckId;

        /// <summary>
        /// Gets and sets the property HealthCheckId. 
        /// <para>
        /// The ID of the health check to delete.
        /// </para>
        /// </summary>
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