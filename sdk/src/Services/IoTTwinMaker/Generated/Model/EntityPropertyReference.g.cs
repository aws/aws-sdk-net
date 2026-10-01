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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// An object that uniquely identifies an entity property.
    /// </summary>
    public partial class EntityPropertyReference
    {
        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ComponentName { get; set; }

        /// <summary>
        /// Checks to see if the ComponentName property is set.
        /// </summary>
        internal bool IsSetComponentName() => this.ComponentName != null;

        /// <summary>
        /// Gets and sets the property ComponentPath. 
        /// <para>
        /// This string specifies the path to the composite component, starting from the top-level
        /// component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ComponentPath { get; set; }

        /// <summary>
        /// Checks to see if the ComponentPath property is set.
        /// </summary>
        internal bool IsSetComponentPath() => this.ComponentPath != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The ID of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property ExternalIdProperty. 
        /// <para>
        /// A mapping of external IDs to property names. External IDs uniquely identify properties
        /// from external data stores.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ExternalIdProperty { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ExternalIdProperty property is set.
        /// </summary>
        internal bool IsSetExternalIdProperty() => this.ExternalIdProperty != null && (this.ExternalIdProperty.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PropertyName. 
        /// <para>
        /// The name of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string PropertyName { get; set; }

        /// <summary>
        /// Checks to see if the PropertyName property is set.
        /// </summary>
        internal bool IsSetPropertyName() => this.PropertyName != null;
    }
}
