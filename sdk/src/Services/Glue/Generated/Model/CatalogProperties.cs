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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure that specifies data lake access properties and other custom properties.
    /// </summary>
    public partial class CatalogProperties
    {
        private Dictionary<string, string> _customProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DataLakeAccessProperties _dataLakeAccessProperties;
        private IcebergOptimizationProperties _icebergOptimizationProperties;

        /// <summary>
        /// Gets and sets the property CustomProperties. 
        /// <para>
        /// Additional key-value properties for the catalog, such as column statistics optimizations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> CustomProperties
        {
            get { return this._customProperties; }
            set { this._customProperties = value; }
        }

        // Check to see if CustomProperties property is set
        internal bool IsSetCustomProperties()
        {
            return this._customProperties != null && (this._customProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataLakeAccessProperties. 
        /// <para>
        /// A <c>DataLakeAccessProperties</c> object that specifies properties to configure data
        /// lake access for your catalog resource in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public DataLakeAccessProperties DataLakeAccessProperties
        {
            get { return this._dataLakeAccessProperties; }
            set { this._dataLakeAccessProperties = value; }
        }

        // Check to see if DataLakeAccessProperties property is set
        internal bool IsSetDataLakeAccessProperties()
        {
            return this._dataLakeAccessProperties != null;
        }

        /// <summary>
        /// Gets and sets the property IcebergOptimizationProperties. 
        /// <para>
        /// A structure that specifies Iceberg table optimization properties for the catalog.
        /// This includes configuration for compaction, retention, and orphan file deletion operations
        /// that can be applied to Iceberg tables in this catalog.
        /// </para>
        /// </summary>
        public IcebergOptimizationProperties IcebergOptimizationProperties
        {
            get { return this._icebergOptimizationProperties; }
            set { this._icebergOptimizationProperties = value; }
        }

        // Check to see if IcebergOptimizationProperties property is set
        internal bool IsSetIcebergOptimizationProperties()
        {
            return this._icebergOptimizationProperties != null;
        }

    }
}