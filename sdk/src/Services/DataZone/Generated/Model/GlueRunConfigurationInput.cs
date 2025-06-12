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
    /// The configuration details of the Amazon Web Services Glue data source.
    /// </summary>
    public partial class GlueRunConfigurationInput
    {
        private bool? _autoImportDataQualityResult;
        private string _catalogName;
        private string _dataAccessRole;
        private List<RelationalFilterConfiguration> _relationalFilterConfigurations = AWSConfigs.InitializeCollections ? new List<RelationalFilterConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property AutoImportDataQualityResult. 
        /// <para>
        /// Specifies whether to automatically import data quality metrics as part of the data
        /// source run.
        /// </para>
        /// </summary>
        public bool? AutoImportDataQualityResult
        {
            get { return this._autoImportDataQualityResult; }
            set { this._autoImportDataQualityResult = value; }
        }

        // Check to see if AutoImportDataQualityResult property is set
        internal bool IsSetAutoImportDataQualityResult()
        {
            return this._autoImportDataQualityResult.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CatalogName. 
        /// <para>
        /// The catalog name in the Amazon Web Services Glue run configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string CatalogName
        {
            get { return this._catalogName; }
            set { this._catalogName = value; }
        }

        // Check to see if CatalogName property is set
        internal bool IsSetCatalogName()
        {
            return this._catalogName != null;
        }

        /// <summary>
        /// Gets and sets the property DataAccessRole. 
        /// <para>
        /// The data access role included in the configuration details of the Amazon Web Services
        /// Glue data source.
        /// </para>
        /// </summary>
        public string DataAccessRole
        {
            get { return this._dataAccessRole; }
            set { this._dataAccessRole = value; }
        }

        // Check to see if DataAccessRole property is set
        internal bool IsSetDataAccessRole()
        {
            return this._dataAccessRole != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalFilterConfigurations. 
        /// <para>
        /// The relational filter configurations included in the configuration details of the
        /// Amazon Web Services Glue data source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RelationalFilterConfiguration> RelationalFilterConfigurations
        {
            get { return this._relationalFilterConfigurations; }
            set { this._relationalFilterConfigurations = value; }
        }

        // Check to see if RelationalFilterConfigurations property is set
        internal bool IsSetRelationalFilterConfigurations()
        {
            return this._relationalFilterConfigurations != null && (this._relationalFilterConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}