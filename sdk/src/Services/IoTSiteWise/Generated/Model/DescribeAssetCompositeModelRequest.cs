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
    /// Container for the parameters to the DescribeAssetCompositeModel operation.
    /// Retrieves information about an asset composite model (also known as an asset component).
    /// An <c>AssetCompositeModel</c> is an instance of an <c>AssetModelCompositeModel</c>.
    /// If you want to see information about the model this is based on, call <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribeAssetModelCompositeModel.html">DescribeAssetModelCompositeModel</a>.
    /// </summary>
    public partial class DescribeAssetCompositeModelRequest : AmazonIoTSiteWiseRequest
    {
        private string _assetCompositeModelId;
        private string _assetId;

        /// <summary>
        /// Gets and sets the property AssetCompositeModelId. 
        /// <para>
        /// The ID of a composite model on this asset. This can be either the actual ID in UUID
        /// format, or else <c>externalId:</c> followed by the external ID, if it has one. For
        /// more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=139)]
        public string AssetCompositeModelId
        {
            get { return this._assetCompositeModelId; }
            set { this._assetCompositeModelId = value; }
        }

        // Check to see if AssetCompositeModelId property is set
        internal bool IsSetAssetCompositeModelId()
        {
            return this._assetCompositeModelId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset. This can be either the actual ID in UUID format, or else <c>externalId:</c>
        /// followed by the external ID, if it has one. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=139)]
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

    }
}