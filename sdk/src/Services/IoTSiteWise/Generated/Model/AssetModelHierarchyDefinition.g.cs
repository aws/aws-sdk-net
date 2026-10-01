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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains an asset model hierarchy used in asset model creation. An asset model hierarchy
    /// determines the kind (or type) of asset that can belong to a hierarchy.
    /// </summary>
    public partial class AssetModelHierarchyDefinition
    {
        /// <summary>
        /// Gets and sets the property ChildAssetModelId. 
        /// <para>
        /// The ID of an asset model for this hierarchy. This can be either the actual ID in UUID
        /// format, or else <c>externalId:</c> followed by the external ID, if it has one. For
        /// more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 13, Max = 139)]
        public string ChildAssetModelId { get; set; }

        /// <summary>
        /// Checks to see if the ChildAssetModelId property is set.
        /// </summary>
        internal bool IsSetChildAssetModelId() => this.ChildAssetModelId != null;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// An external ID to assign to the asset model hierarchy. The external ID must be unique
        /// among asset model hierarchies within this asset model. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-ids">Using
        /// external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 128)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID to assign to the asset model hierarchy, if desired. IoT SiteWise automatically
        /// generates a unique ID for you, so this parameter is never required. However, if you
        /// prefer to supply your own ID instead, you can specify it here in UUID format. If you
        /// specify your own ID, it must be globally unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the asset model hierarchy definition (as specified in the <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_CreateAssetModel.html">CreateAssetModel</a>
        /// or <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetModel.html">UpdateAssetModel</a>
        /// API operation).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
