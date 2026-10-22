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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The health and connectivity status of a connector, including the last time the status
    /// was checked and any diagnostic message. Returned as part of the <c>Connector</c> structure.
    /// </summary>
    public partial class ConnectorHealth
    {
        /// <summary>
        /// Gets and sets the property ConnectorStatus. 
        /// <para>
        /// The health status of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectorHealthStatus ConnectorStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorStatus property is set.
        /// </summary>
        internal bool IsSetConnectorStatus() => this.ConnectorStatus != null;

        /// <summary>
        /// Gets and sets the property LastCheckedAt. 
        /// <para>
        /// The date and time when the connector health was last checked.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastCheckedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastCheckedAt property is set.
        /// </summary>
        internal bool IsSetLastCheckedAt() => this.LastCheckedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message providing additional details about the connector health status.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
