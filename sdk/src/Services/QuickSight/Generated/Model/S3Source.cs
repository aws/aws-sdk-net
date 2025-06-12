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
    /// A physical table type for an S3 data source.
    /// </summary>
    public partial class S3Source
    {
        private string _dataSourceArn;
        private List<InputColumn> _inputColumns = AWSConfigs.InitializeCollections ? new List<InputColumn>() : null;
        private UploadSettings _uploadSettings;

        /// <summary>
        /// Gets and sets the property DataSourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the data source.
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
        /// A physical table type for an S3 data source.
        /// </para>
        ///  <note> 
        /// <para>
        /// For files that aren't JSON, only <c>STRING</c> data types are supported in input columns.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property UploadSettings. 
        /// <para>
        /// Information about the format for the S3 source file or files.
        /// </para>
        /// </summary>
        public UploadSettings UploadSettings
        {
            get { return this._uploadSettings; }
            set { this._uploadSettings = value; }
        }

        // Check to see if UploadSettings property is set
        internal bool IsSetUploadSettings()
        {
            return this._uploadSettings != null;
        }

    }
}