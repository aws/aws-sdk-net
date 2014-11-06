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
    /// A complex type that contains the IP address of a Route 53 health checker and the reason
    /// for the health check status.
    /// </summary>
    public partial class HealthCheckObservation
    {
        private string _iPAddress;
        private StatusReport _statusReport;

        /// <summary>
        /// Gets and sets the property IPAddress. 
        /// <para>
        /// The IP address of the Route 53 health checker that performed the health check.
        /// </para>
        /// </summary>
        public string IPAddress
        {
            get { return this._iPAddress; }
            set { this._iPAddress = value; }
        }

        // Check to see if IPAddress property is set
        internal bool IsSetIPAddress()
        {
            return this._iPAddress != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReport. 
        /// <para>
        /// A complex type that contains information about the health check status for the current
        /// observation.
        /// </para>
        /// </summary>
        public StatusReport StatusReport
        {
            get { return this._statusReport; }
            set { this._statusReport = value; }
        }

        // Check to see if StatusReport property is set
        internal bool IsSetStatusReport()
        {
            return this._statusReport != null;
        }

    }
}