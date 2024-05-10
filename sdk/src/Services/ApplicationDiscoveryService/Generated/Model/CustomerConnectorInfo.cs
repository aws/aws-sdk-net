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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
        private int? _activeConnectors;
        private int? _blackListedConnectors;
        private int? _healthyConnectors;
        private int? _shutdownConnectors;
        private int? _totalConnectors;
        private int? _unhealthyConnectors;
        private int? _unknownConnectors;

        /// <summary>
        /// Gets and sets the property ActiveConnectors. 
        /// <para>
        /// Number of active discovery connectors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ActiveConnectors
        {
            get { return this._activeConnectors; }
            set { this._activeConnectors = value; }
        }

        // Check to see if ActiveConnectors property is set
        internal bool IsSetActiveConnectors()
        {
            return this._activeConnectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BlackListedConnectors. 
        /// <para>
        /// Number of blacklisted discovery connectors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? BlackListedConnectors
        {
            get { return this._blackListedConnectors; }
            set { this._blackListedConnectors = value; }
        }

        // Check to see if BlackListedConnectors property is set
        internal bool IsSetBlackListedConnectors()
        {
            return this._blackListedConnectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthyConnectors. 
        /// <para>
        /// Number of healthy discovery connectors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? HealthyConnectors
        {
            get { return this._healthyConnectors; }
            set { this._healthyConnectors = value; }
        }

        // Check to see if HealthyConnectors property is set
        internal bool IsSetHealthyConnectors()
        {
            return this._healthyConnectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShutdownConnectors. 
        /// <para>
        /// Number of discovery connectors with status SHUTDOWN,
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ShutdownConnectors
        {
            get { return this._shutdownConnectors; }
            set { this._shutdownConnectors = value; }
        }

        // Check to see if ShutdownConnectors property is set
        internal bool IsSetShutdownConnectors()
        {
            return this._shutdownConnectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalConnectors. 
        /// <para>
        /// Total number of discovery connectors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TotalConnectors
        {
            get { return this._totalConnectors; }
            set { this._totalConnectors = value; }
        }

        // Check to see if TotalConnectors property is set
        internal bool IsSetTotalConnectors()
        {
            return this._totalConnectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnhealthyConnectors. 
        /// <para>
        /// Number of unhealthy discovery connectors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? UnhealthyConnectors
        {
            get { return this._unhealthyConnectors; }
            set { this._unhealthyConnectors = value; }
        }

        // Check to see if UnhealthyConnectors property is set
        internal bool IsSetUnhealthyConnectors()
        {
            return this._unhealthyConnectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnknownConnectors. 
        /// <para>
        /// Number of unknown discovery connectors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? UnknownConnectors
        {
            get { return this._unknownConnectors; }
            set { this._unknownConnectors = value; }
        }

        // Check to see if UnknownConnectors property is set
        internal bool IsSetUnknownConnectors()
        {
            return this._unknownConnectors.HasValue; 
        }

    }
}