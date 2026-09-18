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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the operational status and health of a CSPM connector.
    /// </summary>
    public partial class CspmHealthCheck
    {
        /// <summary>
        /// Gets and sets the property ConnectorStatus. 
        /// <para>
        /// The connectivity status of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CspmConnectorStatus ConnectorStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorStatus property is set.
        /// </summary>
        internal bool IsSetConnectorStatus() => this.ConnectorStatus != null;

        /// <summary>
        /// Gets and sets the property Issues. 
        /// <para>
        /// A list of health issues associated with the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HealthIssue> Issues { get; set; } = AWSConfigs.InitializeCollections ? new List<HealthIssue>() : null;

        /// <summary>
        /// Checks to see if the Issues property is set.
        /// </summary>
        internal bool IsSetIssues() => this.Issues != null && (this.Issues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastCheckedAt. 
        /// <para>
        /// The ISO 8601 UTC timestamp indicating when the health status was last checked.
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
        /// A message describing the reason for the current connector status.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
