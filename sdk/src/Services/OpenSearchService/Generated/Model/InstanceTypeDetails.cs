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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
        private bool? _advancedSecurityEnabled;
        private bool? _appLogsEnabled;
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _cognitoEnabled;
        private bool? _encryptionEnabled;
        private List<string> _instanceRole = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private OpenSearchPartitionInstanceType _instanceType;
        private bool? _warmEnabled;

        /// <summary>
        /// Gets and sets the property AdvancedSecurityEnabled. 
        /// <para>
        /// Whether fine-grained access control is supported for the instance type.
        /// </para>
        /// </summary>
        public bool? AdvancedSecurityEnabled
        {
            get { return this._advancedSecurityEnabled; }
            set { this._advancedSecurityEnabled = value; }
        }

        // Check to see if AdvancedSecurityEnabled property is set
        internal bool IsSetAdvancedSecurityEnabled()
        {
            return this._advancedSecurityEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AppLogsEnabled. 
        /// <para>
        /// Whether logging is supported for the instance type.
        /// </para>
        /// </summary>
        public bool? AppLogsEnabled
        {
            get { return this._appLogsEnabled; }
            set { this._appLogsEnabled = value; }
        }

        // Check to see if AppLogsEnabled property is set
        internal bool IsSetAppLogsEnabled()
        {
            return this._appLogsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The supported Availability Zones for the instance type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CognitoEnabled. 
        /// <para>
        /// Whether Amazon Cognito access is supported for the instance type.
        /// </para>
        /// </summary>
        public bool? CognitoEnabled
        {
            get { return this._cognitoEnabled; }
            set { this._cognitoEnabled = value; }
        }

        // Check to see if CognitoEnabled property is set
        internal bool IsSetCognitoEnabled()
        {
            return this._cognitoEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionEnabled. 
        /// <para>
        /// Whether encryption at rest and node-to-node encryption are supported for the instance
        /// type.
        /// </para>
        /// </summary>
        public bool? EncryptionEnabled
        {
            get { return this._encryptionEnabled; }
            set { this._encryptionEnabled = value; }
        }

        // Check to see if EncryptionEnabled property is set
        internal bool IsSetEncryptionEnabled()
        {
            return this._encryptionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceRole. 
        /// <para>
        /// Whether the instance acts as a data node, a dedicated master node, or an UltraWarm
        /// node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceRole
        {
            get { return this._instanceRole; }
            set { this._instanceRole = value; }
        }

        // Check to see if InstanceRole property is set
        internal bool IsSetInstanceRole()
        {
            return this._instanceRole != null && (this._instanceRole.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public OpenSearchPartitionInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property WarmEnabled. 
        /// <para>
        /// Whether UltraWarm is supported for the instance type.
        /// </para>
        /// </summary>
        public bool? WarmEnabled
        {
            get { return this._warmEnabled; }
            set { this._warmEnabled = value; }
        }

        // Check to see if WarmEnabled property is set
        internal bool IsSetWarmEnabled()
        {
            return this._warmEnabled.HasValue; 
        }

    }
}