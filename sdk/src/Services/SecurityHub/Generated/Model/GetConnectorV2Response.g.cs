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
    /// This is the response object from the GetConnectorV2 operation.
    /// </summary>
    public partial class GetConnectorV2Response : AmazonWebServiceResponse
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
        /// Gets and sets the property Health. 
        /// <para>
        /// The current health status for connectorV2
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HealthCheck Health { get; set; }

        /// <summary>
        /// Checks to see if the Health property is set.
        /// </summary>
        internal bool IsSetHealth() => this.Health != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of KMS key used for the connectorV2.
        /// </para>
        /// </summary>
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// ISO 8601 UTC timestamp for the time update the connectorV2 connectorStatus.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connectorV2.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProviderDetail. 
        /// <para>
        /// The third-party provider detail for a service configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProviderDetail ProviderDetail { get; set; }

        /// <summary>
        /// Checks to see if the ProviderDetail property is set.
        /// </summary>
        internal bool IsSetProviderDetail() => this.ProviderDetail != null;
    }
}
