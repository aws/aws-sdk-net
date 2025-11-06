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
    /// References a parent dataset that serves as a data source, including its columns and
    /// metadata.
    /// </summary>
    public partial class ParentDataSet
    {
        private string _dataSetArn;
        private List<InputColumn> _inputColumns = AWSConfigs.InitializeCollections ? new List<InputColumn>() : null;

        /// <summary>
        /// Gets and sets the property DataSetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the parent dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSetArn
        {
            get { return this._dataSetArn; }
            set { this._dataSetArn = value; }
        }

        // Check to see if DataSetArn property is set
        internal bool IsSetDataSetArn()
        {
            return this._dataSetArn != null;
        }

        /// <summary>
        /// Gets and sets the property InputColumns. 
        /// <para>
        /// The list of input columns available from the parent dataset.
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

    }
}