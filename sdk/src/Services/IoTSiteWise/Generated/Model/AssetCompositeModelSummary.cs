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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
    /// Contains a summary of the composite model for a specific asset.
    /// </summary>
    public partial class AssetCompositeModelSummary
    {
        private string _description;
        private string _externalId;
        private string _id;
        private string _name;
        private List<AssetCompositeModelPathSegment> _path = AWSConfigs.InitializeCollections ? new List<AssetCompositeModelPathSegment>() : null;
        private string _type;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the composite model that this summary describes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// An external ID to assign to the asset model.
        /// </para>
        ///  
        /// <para>
        /// If the composite model is a derived composite model, or one nested inside a component
        /// model, you can only set the external ID using <c>UpdateAssetModelCompositeModel</c>
        /// and specifying the derived ID of the model or property from the created model it's
        /// a part of.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=128)]
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the composite model that this summary describes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the composite model that this summary describes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path that includes all the components of the asset model for the asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetCompositeModelPathSegment> Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null && (this._path.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of asset model.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ASSET_MODEL</b> – (default) An asset model that you can use to create assets.
        /// Can't be included as a component in another asset model.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>COMPONENT_MODEL</b> – A reusable component that you can include in the composite
        /// models of other asset models. You can't create assets directly from this type of asset
        /// model. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}