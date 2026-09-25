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
    /// An object that filters items in a list of entities.
    /// </summary>
    public partial class ListEntitiesFilter
    {
        /// <summary>
        /// Gets and sets the property ComponentTypeId. 
        /// <para>
        /// The ID of the component type in the entities in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ComponentTypeId { get; set; }

        /// <summary>
        /// Checks to see if the ComponentTypeId property is set.
        /// </summary>
        internal bool IsSetComponentTypeId() => this.ComponentTypeId != null;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external-Id property of a component. The external-Id property is the primary key
        /// of an external storage system.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property ParentEntityId. 
        /// <para>
        /// The parent of the entities in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ParentEntityId { get; set; }

        /// <summary>
        /// Checks to see if the ParentEntityId property is set.
        /// </summary>
        internal bool IsSetParentEntityId() => this.ParentEntityId != null;
    }
}
