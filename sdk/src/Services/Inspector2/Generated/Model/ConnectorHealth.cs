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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The health and connectivity status of a connector, including the last time the status
    /// was checked and any diagnostic message. Returned as part of the <c>Connector</c> structure.
    /// </summary>
    public partial class ConnectorHealth
    {
        private ConnectorHealthStatus _connectorStatus;
        private DateTime? _lastCheckedAt;
        private string _message;

        /// <summary>
        /// Gets and sets the property ConnectorStatus. 
        /// <para>
        /// The health status of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectorHealthStatus ConnectorStatus
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
        /// The date and time when the connector health was last checked.
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
        /// A message providing additional details about the connector health status.
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