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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the PORT_PROBE action described in this finding.
    /// </summary>
    public partial class PortProbeAction
    {
        private bool? _blocked;
        private List<PortProbeDetail> _portProbeDetails = new List<PortProbeDetail>();

        /// <summary>
        /// Gets and sets the property Blocked. Port probe blocked information.
        /// </summary>
        public bool Blocked
        {
            get { return this._blocked.GetValueOrDefault(); }
            set { this._blocked = value; }
        }

        // Check to see if Blocked property is set
        internal bool IsSetBlocked()
        {
            return this._blocked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PortProbeDetails. A list of port probe details objects.
        /// </summary>
        public List<PortProbeDetail> PortProbeDetails
        {
            get { return this._portProbeDetails; }
            set { this._portProbeDetails = value; }
        }

        // Check to see if PortProbeDetails property is set
        internal bool IsSetPortProbeDetails()
        {
            return this._portProbeDetails != null && this._portProbeDetails.Count > 0; 
        }

    }
}