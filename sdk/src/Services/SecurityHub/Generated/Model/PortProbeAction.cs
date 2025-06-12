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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provided if <c>ActionType</c> is <c>PORT_PROBE</c>. It provides details about the
    /// attempted port probe that was detected.
    /// </summary>
    public partial class PortProbeAction
    {
        private bool? _blocked;
        private List<PortProbeDetail> _portProbeDetails = AWSConfigs.InitializeCollections ? new List<PortProbeDetail>() : null;

        /// <summary>
        /// Gets and sets the property Blocked. 
        /// <para>
        /// Indicates whether the port probe was blocked.
        /// </para>
        /// </summary>
        public bool? Blocked
        {
            get { return this._blocked; }
            set { this._blocked = value; }
        }

        // Check to see if Blocked property is set
        internal bool IsSetBlocked()
        {
            return this._blocked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PortProbeDetails. 
        /// <para>
        /// Information about the ports affected by the port probe.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PortProbeDetail> PortProbeDetails
        {
            get { return this._portProbeDetails; }
            set { this._portProbeDetails = value; }
        }

        // Check to see if PortProbeDetails property is set
        internal bool IsSetPortProbeDetails()
        {
            return this._portProbeDetails != null && (this._portProbeDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}