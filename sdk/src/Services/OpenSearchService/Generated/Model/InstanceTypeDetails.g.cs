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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Lists all instance types and available features for a given OpenSearch or Elasticsearch
    /// version.
    /// </summary>
    public partial class InstanceTypeDetails
    {
        /// <summary>
        /// Gets and sets the property AdvancedSecurityEnabled. 
        /// <para>
        /// Whether fine-grained access control is supported for the instance type.
        /// </para>
        /// </summary>
        public bool? AdvancedSecurityEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AdvancedSecurityEnabled property is set.
        /// </summary>
        internal bool IsSetAdvancedSecurityEnabled() => this.AdvancedSecurityEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property AppLogsEnabled. 
        /// <para>
        /// Whether logging is supported for the instance type.
        /// </para>
        /// </summary>
        public bool? AppLogsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AppLogsEnabled property is set.
        /// </summary>
        internal bool IsSetAppLogsEnabled() => this.AppLogsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The supported Availability Zones for the instance type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CognitoEnabled. 
        /// <para>
        /// Whether Amazon Cognito access is supported for the instance type.
        /// </para>
        /// </summary>
        public bool? CognitoEnabled { get; set; }

        /// <summary>
        /// Checks to see if the CognitoEnabled property is set.
        /// </summary>
        internal bool IsSetCognitoEnabled() => this.CognitoEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionEnabled. 
        /// <para>
        /// Whether encryption at rest and node-to-node encryption are supported for the instance
        /// type.
        /// </para>
        /// </summary>
        public bool? EncryptionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionEnabled property is set.
        /// </summary>
        internal bool IsSetEncryptionEnabled() => this.EncryptionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceRole. 
        /// <para>
        /// Whether the instance acts as a data node, a dedicated master node, or an UltraWarm
        /// node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceRole { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceRole property is set.
        /// </summary>
        internal bool IsSetInstanceRole() => this.InstanceRole != null && (this.InstanceRole.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public OpenSearchPartitionInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property WarmEnabled. 
        /// <para>
        /// Whether UltraWarm is supported for the instance type.
        /// </para>
        /// </summary>
        public bool? WarmEnabled { get; set; }

        /// <summary>
        /// Checks to see if the WarmEnabled property is set.
        /// </summary>
        internal bool IsSetWarmEnabled() => this.WarmEnabled.HasValue;
    }
}
