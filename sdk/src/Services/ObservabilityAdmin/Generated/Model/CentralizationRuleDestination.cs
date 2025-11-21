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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Configuration specifying the primary destination for centralized telemetry data.
    /// </summary>
    public partial class CentralizationRuleDestination
    {
        private string _account;
        private DestinationLogsConfiguration _destinationLogsConfiguration;
        private string _region;

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The destination account (within the organization) to which the telemetry data should
        /// be centralized.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string Account
        {
            get { return this._account; }
            set { this._account = value; }
        }

        // Check to see if Account property is set
        internal bool IsSetAccount()
        {
            return this._account != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationLogsConfiguration. 
        /// <para>
        /// Log specific configuration for centralization destination log groups.
        /// </para>
        /// </summary>
        public DestinationLogsConfiguration DestinationLogsConfiguration
        {
            get { return this._destinationLogsConfiguration; }
            set { this._destinationLogsConfiguration = value; }
        }

        // Check to see if DestinationLogsConfiguration property is set
        internal bool IsSetDestinationLogsConfiguration()
        {
            return this._destinationLogsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The primary destination region to which telemetry data should be centralized.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}