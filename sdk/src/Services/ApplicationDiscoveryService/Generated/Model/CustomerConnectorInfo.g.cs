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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Inventory data for installed discovery connectors.
    /// </summary>
    public partial class CustomerConnectorInfo
    {
        /// <summary>
        /// Gets and sets the property ActiveConnectors. 
        /// <para>
        /// Number of active discovery connectors.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ActiveConnectors { get; set; }

        /// <summary>
        /// Checks to see if the ActiveConnectors property is set.
        /// </summary>
        internal bool IsSetActiveConnectors() => this.ActiveConnectors.HasValue;

        /// <summary>
        /// Gets and sets the property BlackListedConnectors. 
        /// <para>
        /// Number of blacklisted discovery connectors.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? BlackListedConnectors { get; set; }

        /// <summary>
        /// Checks to see if the BlackListedConnectors property is set.
        /// </summary>
        internal bool IsSetBlackListedConnectors() => this.BlackListedConnectors.HasValue;

        /// <summary>
        /// Gets and sets the property HealthyConnectors. 
        /// <para>
        /// Number of healthy discovery connectors.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? HealthyConnectors { get; set; }

        /// <summary>
        /// Checks to see if the HealthyConnectors property is set.
        /// </summary>
        internal bool IsSetHealthyConnectors() => this.HealthyConnectors.HasValue;

        /// <summary>
        /// Gets and sets the property ShutdownConnectors. 
        /// <para>
        /// Number of discovery connectors with status SHUTDOWN,
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ShutdownConnectors { get; set; }

        /// <summary>
        /// Checks to see if the ShutdownConnectors property is set.
        /// </summary>
        internal bool IsSetShutdownConnectors() => this.ShutdownConnectors.HasValue;

        /// <summary>
        /// Gets and sets the property TotalConnectors. 
        /// <para>
        /// Total number of discovery connectors.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalConnectors { get; set; }

        /// <summary>
        /// Checks to see if the TotalConnectors property is set.
        /// </summary>
        internal bool IsSetTotalConnectors() => this.TotalConnectors.HasValue;

        /// <summary>
        /// Gets and sets the property UnhealthyConnectors. 
        /// <para>
        /// Number of unhealthy discovery connectors.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? UnhealthyConnectors { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthyConnectors property is set.
        /// </summary>
        internal bool IsSetUnhealthyConnectors() => this.UnhealthyConnectors.HasValue;

        /// <summary>
        /// Gets and sets the property UnknownConnectors. 
        /// <para>
        /// Number of unknown discovery connectors.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? UnknownConnectors { get; set; }

        /// <summary>
        /// Checks to see if the UnknownConnectors property is set.
        /// </summary>
        internal bool IsSetUnknownConnectors() => this.UnknownConnectors.HasValue;
    }
}
