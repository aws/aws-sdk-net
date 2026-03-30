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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
    /// Configuration for MS Teams workspace integration.
    /// </summary>
    public partial class MSTeamsConfiguration
    {
        private string _teamId;
        private string _teamName;
        private MSTeamsTransmissionTarget _transmissionTarget;

        /// <summary>
        /// Gets and sets the property TeamId. 
        /// <para>
        /// Associated MS Teams teams ID
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=36)]
        public string TeamId
        {
            get { return this._teamId; }
            set { this._teamId = value; }
        }

        // Check to see if TeamId property is set
        internal bool IsSetTeamId()
        {
            return this._teamId != null;
        }

        /// <summary>
        /// Gets and sets the property TeamName. 
        /// <para>
        /// Associated MS Teams team name
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TeamName
        {
            get { return this._teamName; }
            set { this._teamName = value; }
        }

        // Check to see if TeamName property is set
        internal bool IsSetTeamName()
        {
            return this._teamName != null;
        }

        /// <summary>
        /// Gets and sets the property TransmissionTarget. 
        /// <para>
        /// Transmission targets for agent notification
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MSTeamsTransmissionTarget TransmissionTarget
        {
            get { return this._transmissionTarget; }
            set { this._transmissionTarget = value; }
        }

        // Check to see if TransmissionTarget property is set
        internal bool IsSetTransmissionTarget()
        {
            return this._transmissionTarget != null;
        }

    }
}