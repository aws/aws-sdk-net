/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeAssetProperty operation.
    /// </summary>
    public partial class DescribeAssetPropertyResponse : AmazonWebServiceResponse
    {
        private string _assetId;
        private string _assetModelId;
        private string _assetName;
        private Property _assetProperty;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset.
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
        /// The ID of the asset model.
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
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}