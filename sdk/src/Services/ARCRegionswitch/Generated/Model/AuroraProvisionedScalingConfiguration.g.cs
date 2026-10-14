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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Configuration for Amazon Aurora provisioned cluster scaling used in a Region switch
    /// plan.
    /// </summary>
    public partial class AuroraProvisionedScalingConfiguration
    {
        /// <summary>
        /// Gets and sets the property CrossAccountRole. 
        /// <para>
        /// The cross account role for the configuration.
        /// </para>
        /// </summary>
        public string CrossAccountRole { get; set; }

        /// <summary>
        /// Checks to see if the CrossAccountRole property is set.
        /// </summary>
        internal bool IsSetCrossAccountRole() => this.CrossAccountRole != null;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID (secret key) for the configuration.
        /// </para>
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// The global cluster identifier for a global database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string GlobalClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GlobalClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetGlobalClusterIdentifier() => this.GlobalClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property InstanceArns. 
        /// <para>
        /// Per-Region configuration that maps each Region to the Aurora database instance ARN
        /// for scaling.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public Dictionary<string, string> InstanceArns { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the InstanceArns property is set.
        /// </summary>
        internal bool IsSetInstanceArns() => this.InstanceArns != null && (this.InstanceArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegionDatabaseClusterArns. 
        /// <para>
        /// Per-Region configuration that maps each Region to the Aurora database cluster ARN
        /// for scaling.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public Dictionary<string, string> RegionDatabaseClusterArns { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RegionDatabaseClusterArns property is set.
        /// </summary>
        internal bool IsSetRegionDatabaseClusterArns() => this.RegionDatabaseClusterArns != null && (this.RegionDatabaseClusterArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutMinutes. 
        /// <para>
        /// The timeout value specified for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? TimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetTimeoutMinutes() => this.TimeoutMinutes.HasValue;
    }
}
