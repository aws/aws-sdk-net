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
    /// This is the response object from the DescribeAssetProperty operation.
    /// </summary>
    public partial class DescribeAssetPropertyResponse : AmazonWebServiceResponse
    {
        private string _assetExternalId;
        private string _assetId;
        private string _assetModelId;
        private string _assetName;
        private Property _assetProperty;
        private CompositeModelProperty _compositeModel;

        /// <summary>
        /// Gets and sets the property AssetExternalId. 
        /// <para>
        /// The external ID of the asset. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-ids">Using
        /// external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=128)]
        public string AssetExternalId
        {
            get { return this._assetExternalId; }
            set { this._assetExternalId = value; }
        }

        // Check to see if AssetExternalId property is set
        internal bool IsSetAssetExternalId()
        {
            return this._assetExternalId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset, in UUID format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model, in UUID format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssetModelId
        {
            get { return this._assetModelId; }
            set { this._assetModelId = value; }
        }

        // Check to see if AssetModelId property is set
        internal bool IsSetAssetModelId()
        {
            return this._assetModelId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetName. 
        /// <para>
        /// The name of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AssetName
        {
            get { return this._assetName; }
            set { this._assetName = value; }
        }

        // Check to see if AssetName property is set
        internal bool IsSetAssetName()
        {
            return this._assetName != null;
        }

        /// <summary>
        /// Gets and sets the property AssetProperty. 
        /// <para>
        /// The asset property's definition, alias, and notification state.
        /// </para>
        ///  
        /// <para>
        /// This response includes this object for normal asset properties. If you describe an
        /// asset property in a composite model, this response includes the asset property information
        /// in <c>compositeModel</c>.
        /// </para>
        /// </summary>
        public Property AssetProperty
        {
            get { return this._assetProperty; }
            set { this._assetProperty = value; }
        }

        // Check to see if AssetProperty property is set
        internal bool IsSetAssetProperty()
        {
            return this._assetProperty != null;
        }

        /// <summary>
        /// Gets and sets the property CompositeModel. 
        /// <para>
        /// The composite model that declares this asset property, if this asset property exists
        /// in a composite model.
        /// </para>
        /// </summary>
        public CompositeModelProperty CompositeModel
        {
            get { return this._compositeModel; }
            set { this._compositeModel = value; }
        }

        // Check to see if CompositeModel property is set
        internal bool IsSetCompositeModel()
        {
            return this._compositeModel != null;
        }

    }
}