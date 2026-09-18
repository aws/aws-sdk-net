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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the StartNetworkMigrationMappingUpdate operation.
    /// Starts a job to apply customer modifications to network migration mappings, such as
    /// changing properties.
    /// </summary>
    public partial class StartNetworkMigrationMappingUpdateRequest : AmazonMgnRequest
    {
        /// <summary>
        /// Gets and sets the property Constructs. 
        /// <para>
        /// A list of construct updates to apply.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<StartNetworkMigrationMappingUpdateConstruct> Constructs { get; set; } = AWSConfigs.InitializeCollections ? new List<StartNetworkMigrationMappingUpdateConstruct>() : null;

        /// <summary>
        /// Checks to see if the Constructs property is set.
        /// </summary>
        internal bool IsSetConstructs() => this.Constructs != null && (this.Constructs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkMigrationDefinitionID. 
        /// <para>
        /// The unique identifier of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 21, Max = 21)]
        public string NetworkMigrationDefinitionID { get; set; }

        /// <summary>
        /// Checks to see if the NetworkMigrationDefinitionID property is set.
        /// </summary>
        internal bool IsSetNetworkMigrationDefinitionID() => this.NetworkMigrationDefinitionID != null;

        /// <summary>
        /// Gets and sets the property NetworkMigrationExecutionID. 
        /// <para>
        /// The unique identifier of the network migration execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string NetworkMigrationExecutionID { get; set; }

        /// <summary>
        /// Checks to see if the NetworkMigrationExecutionID property is set.
        /// </summary>
        internal bool IsSetNetworkMigrationExecutionID() => this.NetworkMigrationExecutionID != null;

        /// <summary>
        /// Gets and sets the property Segments. 
        /// <para>
        /// A list of segment updates to apply.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<StartNetworkMigrationMappingUpdateSegment> Segments { get; set; } = AWSConfigs.InitializeCollections ? new List<StartNetworkMigrationMappingUpdateSegment>() : null;

        /// <summary>
        /// Checks to see if the Segments property is set.
        /// </summary>
        internal bool IsSetSegments() => this.Segments != null && (this.Segments.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
