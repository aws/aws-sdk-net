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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// The structure representing the items in the response for SearchRasterDataCollection.
    /// </summary>
    public partial class ItemSource
    {
        private Dictionary<string, AssetValue> _assets = new Dictionary<string, AssetValue>();
        private DateTime? _dateTime;
        private Geometry _geometry;
        private string _id;
        private Properties _properties;

        /// <summary>
        /// Gets and sets the property Assets. 
        /// <para>
        /// This is a dictionary of Asset Objects data associated with the Item that can be downloaded
        /// or streamed, each with a unique key.
        /// </para>
        /// </summary>
        public Dictionary<string, AssetValue> Assets
        {
            get { return this._assets; }
            set { this._assets = value; }
        }

        // Check to see if Assets property is set
        internal bool IsSetAssets()
        {
            return this._assets != null && this._assets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DateTime. 
        /// <para>
        /// The searchable date and time of the item, in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime DateTime
        {
            get { return this._dateTime.GetValueOrDefault(); }
            set { this._dateTime = value; }
        }

        // Check to see if DateTime property is set
        internal bool IsSetDateTime()
        {
            return this._dateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Geometry. 
        /// <para>
        /// The item Geometry in GeoJson format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Geometry Geometry
        {
            get { return this._geometry; }
            set { this._geometry = value; }
        }

        // Check to see if Geometry property is set
        internal bool IsSetGeometry()
        {
            return this._geometry != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique Id for the source item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// This field contains additional properties of the item.
        /// </para>
        /// </summary>
        public Properties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null;
        }

    }
}