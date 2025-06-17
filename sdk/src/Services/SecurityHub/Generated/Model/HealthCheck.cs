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
    /// Information about the operational status and health of a connectorV2.
    /// </summary>
    public partial class HealthCheck
    {
        private ConnectorStatus _connectorStatus;
        private DateTime? _lastCheckedAt;
        private string _message;

        /// <summary>
        /// Gets and sets the property ConnectorStatus. 
        /// <para>
        /// The status of the connectorV2.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectorStatus ConnectorStatus
        {
            get { return this._connectorStatus; }
            set { this._connectorStatus = value; }
        }

        // Check to see if ConnectorStatus property is set
        internal bool IsSetConnectorStatus()
        {
            return this._connectorStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastCheckedAt. 
        /// <para>
        /// ISO 8601 UTC timestamp for the time check the health status of the connectorV2.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastCheckedAt
        {
            get { return this._lastCheckedAt; }
            set { this._lastCheckedAt = value; }
        }

        // Check to see if LastCheckedAt property is set
        internal bool IsSetLastCheckedAt()
        {
            return this._lastCheckedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message for the reason of connectorStatus change.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}