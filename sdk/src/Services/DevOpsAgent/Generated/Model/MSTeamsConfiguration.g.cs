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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Configuration for connecting a Microsoft Teams team to the DevOps Agent service. Use
    /// this configuration to specify which team to connect and how to route agent notifications
    /// to channels within that team.
    /// </summary>
    public partial class MSTeamsConfiguration
    {
        /// <summary>
        /// Gets and sets the property TeamId. 
        /// <para>
        /// The identifier of the Microsoft Teams team to connect to the DevOps Agent service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 36)]
        public string TeamId { get; set; }

        /// <summary>
        /// Checks to see if the TeamId property is set.
        /// </summary>
        internal bool IsSetTeamId() => this.TeamId != null;

        /// <summary>
        /// Gets and sets the property TeamName. 
        /// <para>
        /// The name of the Microsoft Teams team to connect to the DevOps Agent service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TeamName { get; set; }

        /// <summary>
        /// Checks to see if the TeamName property is set.
        /// </summary>
        internal bool IsSetTeamName() => this.TeamName != null;

        /// <summary>
        /// Gets and sets the property TransmissionTarget. 
        /// <para>
        /// The Microsoft Teams channels that receive agent notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MSTeamsTransmissionTarget TransmissionTarget { get; set; }

        /// <summary>
        /// Checks to see if the TransmissionTarget property is set.
        /// </summary>
        internal bool IsSetTransmissionTarget() => this.TransmissionTarget != null;
    }
}
