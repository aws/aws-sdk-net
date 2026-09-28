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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Provides the information for the ID namespace association input reference properties.
    /// </summary>
    public partial class IdNamespaceAssociationInputReferenceProperties
    {
        /// <summary>
        /// Gets and sets the property IdMappingWorkflowsSupported. 
        /// <para>
        /// Defines how ID mapping workflows are supported for this ID namespace association.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Amazon.Runtime.Documents.Document> IdMappingWorkflowsSupported { get; set; } = AWSConfigs.InitializeCollections ? new List<Amazon.Runtime.Documents.Document>() : null;

        /// <summary>
        /// Checks to see if the IdMappingWorkflowsSupported property is set.
        /// </summary>
        internal bool IsSetIdMappingWorkflowsSupported() => this.IdMappingWorkflowsSupported != null && (this.IdMappingWorkflowsSupported.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IdNamespaceType. 
        /// <para>
        /// The ID namespace type for this ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IdNamespaceType IdNamespaceType { get; set; }

        /// <summary>
        /// Checks to see if the IdNamespaceType property is set.
        /// </summary>
        internal bool IsSetIdNamespaceType() => this.IdNamespaceType != null;
    }
}
