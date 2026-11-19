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
    /// An operation that updates a construct using native property value types and construct-type-specific
    /// behavioral configuration.
    /// </summary>
    public partial class UpdateOperationV2
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Construct-type-specific behavioral configuration to apply, such as security group
        /// associations or security group rule referencing.
        /// </para>
        /// </summary>
        public OperationConfigurationUnion Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property Excluded. 
        /// <para>
        /// Whether to exclude this construct from the migration.
        /// </para>
        /// </summary>
        public bool? Excluded { get; set; }

        /// <summary>
        /// Checks to see if the Excluded property is set.
        /// </summary>
        internal bool IsSetExcluded() => this.Excluded.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name for the construct.
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
        /// The properties to set or overwrite on the construct, using their native value types;
        /// omitted keys are unchanged.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public Dictionary<string, Amazon.Runtime.Documents.Document> Properties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Runtime.Documents.Document>() : null;

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null && (this.Properties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PropertiesToDelete. 
        /// <para>
        /// The property keys to remove from the construct.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> PropertiesToDelete { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PropertiesToDelete property is set.
        /// </summary>
        internal bool IsSetPropertiesToDelete() => this.PropertiesToDelete != null && (this.PropertiesToDelete.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
