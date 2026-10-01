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

namespace Amazon.MQ.Model
{
    /// <summary>
    /// Option for host instance type.
    /// </summary>
    public partial class BrokerInstanceOption
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The list of available az.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailabilityZone> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<AvailabilityZone>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        /// The broker's engine type.
        /// </para>
        /// </summary>
        public EngineType EngineType { get; set; }

        /// <summary>
        /// Checks to see if the EngineType property is set.
        /// </summary>
        internal bool IsSetEngineType() => this.EngineType != null;

        /// <summary>
        /// Gets and sets the property HostInstanceType. 
        /// <para>
        /// The broker's instance type.
        /// </para>
        /// </summary>
        public string HostInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the HostInstanceType property is set.
        /// </summary>
        internal bool IsSetHostInstanceType() => this.HostInstanceType != null;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The broker's storage type.
        /// </para>
        /// </summary>
        public BrokerStorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property SupportedDeploymentModes. 
        /// <para>
        /// The list of supported deployment modes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedDeploymentModes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedDeploymentModes property is set.
        /// </summary>
        internal bool IsSetSupportedDeploymentModes() => this.SupportedDeploymentModes != null && (this.SupportedDeploymentModes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedEngineVersions. 
        /// <para>
        /// The list of supported engine versions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedEngineVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedEngineVersions property is set.
        /// </summary>
        internal bool IsSetSupportedEngineVersions() => this.SupportedEngineVersions != null && (this.SupportedEngineVersions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
