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
    /// A condensed overview of the connectorV2..
    /// </summary>
    public partial class ConnectorSummary
    {
        /// <summary>
        /// Gets and sets the property ConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connectorV2.
        /// </para>
        /// </summary>
        public string ConnectorArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorArn property is set.
        /// </summary>
        internal bool IsSetConnectorArn() => this.ConnectorArn != null;

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The UUID of the connectorV2 to identify connectorV2 resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorId property is set.
        /// </summary>
        internal bool IsSetConnectorId() => this.ConnectorId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// ISO 8601 UTC timestamp for the time create the connectorV2.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the connectorV2.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnablementStatus. 
        /// <para>
        /// The enablement status of the connector.
        /// </para>
        /// </summary>
        public EnablementStatus EnablementStatus { get; set; }

        /// <summary>
        /// Checks to see if the EnablementStatus property is set.
        /// </summary>
        internal bool IsSetEnablementStatus() => this.EnablementStatus != null;

        /// <summary>
        /// Gets and sets the property EnablementStatusReason. 
        /// <para>
        /// The reason for the current enablement status. Provides additional context when the
        /// connector is in a failed state.
        /// </para>
        /// </summary>
        public string EnablementStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the EnablementStatusReason property is set.
        /// </summary>
        internal bool IsSetEnablementStatusReason() => this.EnablementStatusReason != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The Name field contains the user-defined name assigned to the integration connector.
        /// This helps identify and manage multiple connectors within Security Hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProviderSummary. 
        /// <para>
        /// The connectorV2 third party provider configuration summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProviderSummary ProviderSummary { get; set; }

        /// <summary>
        /// Checks to see if the ProviderSummary property is set.
        /// </summary>
        internal bool IsSetProviderSummary() => this.ProviderSummary != null;
    }
}
