/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>Vgw Telemetry
    /// </summary>
    public class VgwTelemetry
    {
        
        private string outsideIpAddress;
        private TelemetryStatus status;
        private DateTime? lastStatusChange;
        private string statusMessage;
        private int? acceptedRouteCount;

        public string OutsideIpAddress
        {
            get { return this.outsideIpAddress; }
            set { this.outsideIpAddress = value; }
        }

        // Check to see if OutsideIpAddress property is set
        internal bool IsSetOutsideIpAddress()
        {
            return this.outsideIpAddress != null;
        }
        public TelemetryStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }
        public DateTime LastStatusChange
        {
            get { return this.lastStatusChange ?? default(DateTime); }
            set { this.lastStatusChange = value; }
        }

        // Check to see if LastStatusChange property is set
        internal bool IsSetLastStatusChange()
        {
            return this.lastStatusChange.HasValue;
        }
        public string StatusMessage
        {
            get { return this.statusMessage; }
            set { this.statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this.statusMessage != null;
        }
        public int AcceptedRouteCount
        {
            get { return this.acceptedRouteCount ?? default(int); }
            set { this.acceptedRouteCount = value; }
        }

        // Check to see if AcceptedRouteCount property is set
        internal bool IsSetAcceptedRouteCount()
        {
            return this.acceptedRouteCount.HasValue;
        }
    }
}
