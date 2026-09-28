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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Dataflow details for the destination side.
    /// </summary>
    public partial class Destination
    {
        /// <summary>
        /// Gets and sets the property ConfigDetails. 
        /// <para>
        /// Additional details for a <c>Config</c>, if type is dataflow endpoint or antenna demod
        /// decode.
        /// </para>
        /// </summary>
        public ConfigDetails ConfigDetails { get; set; }

        /// <summary>
        /// Checks to see if the ConfigDetails property is set.
        /// </summary>
        internal bool IsSetConfigDetails() => this.ConfigDetails != null;

        /// <summary>
        /// Gets and sets the property ConfigId. 
        /// <para>
        /// UUID of a <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ConfigId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigId property is set.
        /// </summary>
        internal bool IsSetConfigId() => this.ConfigId != null;

        /// <summary>
        /// Gets and sets the property ConfigType. 
        /// <para>
        /// Type of a <c>Config</c>.
        /// </para>
        /// </summary>
        public ConfigCapabilityType ConfigType { get; set; }

        /// <summary>
        /// Checks to see if the ConfigType property is set.
        /// </summary>
        internal bool IsSetConfigType() => this.ConfigType != null;

        /// <summary>
        /// Gets and sets the property DataflowDestinationRegion. 
        /// <para>
        /// Region of a dataflow destination.
        /// </para>
        /// </summary>
        public string DataflowDestinationRegion { get; set; }

        /// <summary>
        /// Checks to see if the DataflowDestinationRegion property is set.
        /// </summary>
        internal bool IsSetDataflowDestinationRegion() => this.DataflowDestinationRegion != null;
    }
}
