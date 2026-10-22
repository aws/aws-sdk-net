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

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// The structure representing the items in the response for SearchRasterDataCollection.
    /// </summary>
    public partial class ItemSource
    {
        /// <summary>
        /// Gets and sets the property Assets. 
        /// <para>
        /// This is a dictionary of Asset Objects data associated with the Item that can be downloaded
        /// or streamed, each with a unique key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AssetValue> Assets { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AssetValue>() : null;

        /// <summary>
        /// Checks to see if the Assets property is set.
        /// </summary>
        internal bool IsSetAssets() => this.Assets != null && (this.Assets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DateTime. 
        /// <para>
        /// The searchable date and time of the item, in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Checks to see if the DateTime property is set.
        /// </summary>
        internal bool IsSetDateTime() => this.DateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Geometry. 
        /// <para>
        /// The item Geometry in GeoJson format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Geometry Geometry { get; set; }

        /// <summary>
        /// Checks to see if the Geometry property is set.
        /// </summary>
        internal bool IsSetGeometry() => this.Geometry != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique Id for the source item.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// This field contains additional properties of the item.
        /// </para>
        /// </summary>
        public Properties Properties { get; set; }

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null;
    }
}
