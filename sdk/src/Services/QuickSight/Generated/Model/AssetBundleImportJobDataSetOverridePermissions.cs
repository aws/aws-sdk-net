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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// An object that contains a list of permissions to be applied to a list of dataset IDs.
    /// </summary>
    public partial class AssetBundleImportJobDataSetOverridePermissions
    {
        private List<string> _dataSetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AssetBundleResourcePermissions _permissions;

        /// <summary>
        /// Gets and sets the property DataSetIds. 
        /// <para>
        /// A list of dataset IDs that you want to apply overrides to. You can use <c>*</c> to
        /// override all datasets in this asset bundle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> DataSetIds
        {
            get { return this._dataSetIds; }
            set { this._dataSetIds = value; }
        }

        // Check to see if DataSetIds property is set
        internal bool IsSetDataSetIds()
        {
            return this._dataSetIds != null && (this._dataSetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// A list of permissions for the datasets that you want to apply overrides to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetBundleResourcePermissions Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null;
        }

    }
}