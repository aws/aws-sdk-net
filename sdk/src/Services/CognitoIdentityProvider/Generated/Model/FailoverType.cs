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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Specifies failover configuration for multi-region user pool domains. Contains settings
    /// for the secondary region and health check configuration.
    /// </summary>
    public partial class FailoverType
    {
        private string _primaryRoute53HealthCheckId;
        private string _secondaryRegion;

        /// <summary>
        /// Gets and sets the property PrimaryRoute53HealthCheckId. 
        /// <para>
        /// The ID of the Amazon Web Services Route53 healthcheck that controls routing. If the
        /// healthcheck is healthy, traffic will be routed to the primary replica, and if the
        /// healthcheck is unhealthy, traffic will be routed to the secondary region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string PrimaryRoute53HealthCheckId
        {
            get { return this._primaryRoute53HealthCheckId; }
            set { this._primaryRoute53HealthCheckId = value; }
        }

        // Check to see if PrimaryRoute53HealthCheckId property is set
        internal bool IsSetPrimaryRoute53HealthCheckId()
        {
            return this._primaryRoute53HealthCheckId != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryRegion. 
        /// <para>
        /// The secondary Amazon Web Services Region to use for failover when the primary region
        /// becomes unavailable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=32)]
        public string SecondaryRegion
        {
            get { return this._secondaryRegion; }
            set { this._secondaryRegion = value; }
        }

        // Check to see if SecondaryRegion property is set
        internal bool IsSetSecondaryRegion()
        {
            return this._secondaryRegion != null;
        }

    }
}