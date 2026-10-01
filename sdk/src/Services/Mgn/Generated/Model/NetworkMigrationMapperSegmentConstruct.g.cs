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
    /// Represents a construct within a mapper segment. A construct is an individual infrastructure
    /// component such as a VPC, subnet, security group, route table, or other network resource
    /// that is part of the network migration.
    /// </summary>
    public partial class NetworkMigrationMapperSegmentConstruct
    {
        /// <summary>
        /// Gets and sets the property ConstructID. 
        /// <para>
        /// The unique identifier of the construct.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ConstructID { get; set; }

        /// <summary>
        /// Checks to see if the ConstructID property is set.
        /// </summary>
        internal bool IsSetConstructID() => this.ConstructID != null;

        /// <summary>
        /// Gets and sets the property ConstructType. 
        /// <para>
        /// The type of the construct, such as VPC, subnet, security group, or route table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 24)]
        public string ConstructType { get; set; }

        /// <summary>
        /// Checks to see if the ConstructType property is set.
        /// </summary>
        internal bool IsSetConstructType() => this.ConstructType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the construct was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the construct.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 600)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Excluded. 
        /// <para>
        /// Whether this construct is excluded from the migration.
        /// </para>
        /// </summary>
        public bool? Excluded { get; set; }

        /// <summary>
        /// Checks to see if the Excluded property is set.
        /// </summary>
        internal bool IsSetExcluded() => this.Excluded.HasValue;

        /// <summary>
        /// Gets and sets the property LogicalID. 
        /// <para>
        /// The logical identifier for the construct in the infrastructure code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LogicalID { get; set; }

        /// <summary>
        /// Checks to see if the LogicalID property is set.
        /// </summary>
        internal bool IsSetLogicalID() => this.LogicalID != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the construct.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// The properties and configuration of the construct.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public Dictionary<string, string> Properties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null && (this.Properties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the construct was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
