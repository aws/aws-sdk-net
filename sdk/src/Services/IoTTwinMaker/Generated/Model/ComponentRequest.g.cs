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
    /// An object that sets information about a component type create or update request.
    /// </summary>
    public partial class ComponentRequest
    {
        /// <summary>
        /// Gets and sets the property ComponentTypeId. 
        /// <para>
        /// The ID of the component type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ComponentTypeId { get; set; }

        /// <summary>
        /// Checks to see if the ComponentTypeId property is set.
        /// </summary>
        internal bool IsSetComponentTypeId() => this.ComponentTypeId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the component request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// An object that maps strings to the properties to set in the component type. Each string
        /// in the mapping must be unique to this object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PropertyRequest> Properties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, PropertyRequest>() : null;

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null && (this.Properties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PropertyGroups. 
        /// <para>
        /// The property groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComponentPropertyGroupRequest> PropertyGroups { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentPropertyGroupRequest>() : null;

        /// <summary>
        /// Checks to see if the PropertyGroups property is set.
        /// </summary>
        internal bool IsSetPropertyGroups() => this.PropertyGroups != null && (this.PropertyGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
