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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// The AWS IoT SiteWise soucre configuration filter.[need held with desc here]
    /// </summary>
    public partial class IotSiteWiseSourceConfigurationFilter
    {
        private FilterByAsset _filterByAsset;
        private FilterByAssetModel _filterByAssetModel;

        /// <summary>
        /// Gets and sets the property FilterByAsset. 
        /// <para>
        /// Filter by asset.
        /// </para>
        /// </summary>
        public FilterByAsset FilterByAsset
        {
            get { return this._filterByAsset; }
            set { this._filterByAsset = value; }
        }

        // Check to see if FilterByAsset property is set
        internal bool IsSetFilterByAsset()
        {
            return this._filterByAsset != null;
        }

        /// <summary>
        /// Gets and sets the property FilterByAssetModel. 
        /// <para>
        /// Filter by asset model.
        /// </para>
        /// </summary>
        public FilterByAssetModel FilterByAssetModel
        {
            get { return this._filterByAssetModel; }
            set { this._filterByAssetModel = value; }
        }

        // Check to see if FilterByAssetModel property is set
        internal bool IsSetFilterByAssetModel()
        {
            return this._filterByAssetModel != null;
        }

    }
}