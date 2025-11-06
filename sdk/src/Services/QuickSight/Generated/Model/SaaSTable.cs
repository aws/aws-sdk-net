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
    /// A table from a Software-as-a-Service (SaaS) data source, including connection details
    /// and column definitions.
    /// </summary>
    public partial class SaaSTable
    {
        private string _dataSourceArn;
        private List<InputColumn> _inputColumns = AWSConfigs.InitializeCollections ? new List<InputColumn>() : null;
        private List<TablePathElement> _tablePath = AWSConfigs.InitializeCollections ? new List<TablePathElement>() : null;

        /// <summary>
        /// Gets and sets the property DataSourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SaaS data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSourceArn
        {
            get { return this._dataSourceArn; }
            set { this._dataSourceArn = value; }
        }

        // Check to see if DataSourceArn property is set
        internal bool IsSetDataSourceArn()
        {
            return this._dataSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property InputColumns. 
        /// <para>
        /// The list of input columns available from the SaaS table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public List<InputColumn> InputColumns
        {
            get { return this._inputColumns; }
            set { this._inputColumns = value; }
        }

        // Check to see if InputColumns property is set
        internal bool IsSetInputColumns()
        {
            return this._inputColumns != null && (this._inputColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TablePath. 
        /// <para>
        /// The hierarchical path to the table within the SaaS data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public List<TablePathElement> TablePath
        {
            get { return this._tablePath; }
            set { this._tablePath = value; }
        }

        // Check to see if TablePath property is set
        internal bool IsSetTablePath()
        {
            return this._tablePath != null && (this._tablePath.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}