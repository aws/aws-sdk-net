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
    /// Identifies a property value used in an expression.
    /// </summary>
    public partial class VariableValue
    {
        /// <summary>
        /// Gets and sets the property HierarchyId. 
        /// <para>
        /// The ID of the hierarchy to query for the property ID. You can use the hierarchy's
        /// name instead of the hierarchy's ID. If the hierarchy has an external ID, you can specify
        /// <c>externalId:</c> followed by the external ID. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-ids">Using
        /// external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You use a hierarchy ID instead of a model ID because you can have several hierarchies
        /// using the same model and therefore the same <c>propertyId</c>. For example, you might
        /// have separately grouped assets that come from the same asset model. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/asset-hierarchies.html">Asset
        /// hierarchies</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string HierarchyId { get; set; }

        /// <summary>
        /// Checks to see if the HierarchyId property is set.
        /// </summary>
        internal bool IsSetHierarchyId() => this.HierarchyId != null;

        /// <summary>
        /// Gets and sets the property PropertyId. 
        /// <para>
        /// The ID of the property to use as the variable. You can use the property <c>name</c>
        /// if it's from the same asset model. If the property has an external ID, you can specify
        /// <c>externalId:</c> followed by the external ID. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-ids">Using
        /// external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PropertyId { get; set; }

        /// <summary>
        /// Checks to see if the PropertyId property is set.
        /// </summary>
        internal bool IsSetPropertyId() => this.PropertyId != null;

        /// <summary>
        /// Gets and sets the property PropertyPath. 
        /// <para>
        /// The path of the property.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetModelPropertyPathSegment> PropertyPath { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetModelPropertyPathSegment>() : null;

        /// <summary>
        /// Checks to see if the PropertyPath property is set.
        /// </summary>
        internal bool IsSetPropertyPath() => this.PropertyPath != null && (this.PropertyPath.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
