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
    /// Container for the parameters to the GetHealthCheckLastFailureReason operation.
    /// If you want to learn why a health check is currently failing or why it failed most
    /// recently (if at all), you can get the failure reason for the most recent failure.
    /// Send a <code>GET</code> request to the <code>2013-04-01/healthcheck/<i>health check
    /// ID</i>/lastfailurereason</code> resource.
    /// </summary>
    public partial class GetHealthCheckLastFailureReasonRequest : AmazonRoute53Request
    {
        private string _healthCheckId;

        /// <summary>
        /// Gets and sets the property HealthCheckId. 
        /// <para>
        /// The ID of the health check for which you want to retrieve the reason for the most
        /// recent failure.
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