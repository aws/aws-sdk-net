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
    /// Container for the parameters to the DescribeAssetModelCompositeModel operation.
    /// Retrieves information about an asset model composite model (also known as an asset
    /// model component). For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/custom-composite-models.html">Custom
    /// composite models (Components)</a> in the <i>IoT SiteWise User Guide</i>.
    /// </summary>
    public partial class DescribeAssetModelCompositeModelRequest : AmazonIoTSiteWiseRequest
    {
        private string _assetModelCompositeModelId;
        private string _assetModelId;
        private string _assetModelVersion;

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelId. 
        /// <para>
        /// The ID of a composite model on this asset model. This can be either the actual ID
        /// in UUID format, or else <c>externalId:</c> followed by the external ID, if it has
        /// one. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=139)]
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
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model. This can be either the actual ID in UUID format, or else
        /// <c>externalId:</c> followed by the external ID, if it has one. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=139)]
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
        /// Gets and sets the property AssetModelVersion. 
        /// <para>
        /// The version alias that specifies the latest or active version of the asset model.
        /// The details are returned in the response. The default value is <c>LATEST</c>. See
        /// <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/model-active-version.html">
        /// Asset model versions</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        public string AssetModelVersion
        {
            get { return this._assetModelVersion; }
            set { this._assetModelVersion = value; }
        }

        // Check to see if AssetModelVersion property is set
        internal bool IsSetAssetModelVersion()
        {
            return this._assetModelVersion != null;
        }

    }
}