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
    /// Defines how telemetry data should be centralized across an Amazon Web Services Organization,
    /// including source and destination configurations.
    /// </summary>
    public partial class CentralizationRule
    {
        private CentralizationRuleDestination _destination;
        private CentralizationRuleSource _source;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// Configuration determining where the telemetry data should be centralized, backed up,
        /// as well as encryption configuration for the primary and backup destinations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CentralizationRuleDestination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Configuration determining the source of the telemetry data to be centralized.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CentralizationRuleSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}