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
    /// This is the response object from the CreateAssetModelCompositeModel operation.
    /// </summary>
    public partial class CreateAssetModelCompositeModelResponse : AmazonWebServiceResponse
    {
        private string _assetModelCompositeModelId;
        private List<AssetModelCompositeModelPathSegment> _assetModelCompositeModelPath = AWSConfigs.InitializeCollections ? new List<AssetModelCompositeModelPathSegment>() : null;
        private AssetModelStatus _assetModelStatus;

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelId. 
        /// <para>
        /// The ID of the composed asset model. You can use this ID when you call other IoT SiteWise
        /// APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssetModelCompositeModelId
        {
            get { return this._assetModelCompositeModelId; }
            set { this._assetModelCompositeModelId = value; }
        }

        // Check to see if AssetModelCompositeModelId property is set
        internal bool IsSetAssetModelCompositeModelId()
        {
            return this._assetModelCompositeModelId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelPath. 
        /// <para>
        /// The path to the composite model listing the parent composite models.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetModelCompositeModelPathSegment> AssetModelCompositeModelPath
        {
            get { return this._assetModelCompositeModelPath; }
            set { this._assetModelCompositeModelPath = value; }
        }

        // Check to see if AssetModelCompositeModelPath property is set
        internal bool IsSetAssetModelCompositeModelPath()
        {
            return this._assetModelCompositeModelPath != null && (this._assetModelCompositeModelPath.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetModelStatus.
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetModelStatus AssetModelStatus
        {
            get { return this._assetModelStatus; }
            set { this._assetModelStatus = value; }
        }

        // Check to see if AssetModelStatus property is set
        internal bool IsSetAssetModelStatus()
        {
            return this._assetModelStatus != null;
        }

    }
}