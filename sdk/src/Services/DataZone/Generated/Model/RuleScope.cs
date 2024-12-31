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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The scope of a rule.
    /// </summary>
    public partial class RuleScope
    {
        private AssetTypesForRule _assetType;
        private bool? _dataProduct;
        private ProjectsForRule _project;

        /// <summary>
        /// Gets and sets the property AssetType. 
        /// <para>
        /// The asset type included in the rule scope.
        /// </para>
        /// </summary>
        public AssetTypesForRule AssetType
        {
            get { return this._assetType; }
            set { this._assetType = value; }
        }

        // Check to see if AssetType property is set
        internal bool IsSetAssetType()
        {
            return this._assetType != null;
        }

        /// <summary>
        /// Gets and sets the property DataProduct. 
        /// <para>
        /// The data product included in the rule scope.
        /// </para>
        /// </summary>
        public bool? DataProduct
        {
            get { return this._dataProduct; }
            set { this._dataProduct = value; }
        }

        // Check to see if DataProduct property is set
        internal bool IsSetDataProduct()
        {
            return this._dataProduct.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The project included in the rule scope.
        /// </para>
        /// </summary>
        public ProjectsForRule Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

    }
}