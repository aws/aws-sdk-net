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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Specifies a file metadata.
    /// </summary>
    public partial class FileMetadata
    {
        private DatabaseCDC _databasecdc;
        private List<DataSet> _dataSets = AWSConfigs.InitializeCollections ? new List<DataSet>() : null;

        /// <summary>
        /// Gets and sets the property DatabaseCDC. 
        /// <para>
        /// The database CDC of the file metadata.
        /// </para>
        /// </summary>
        public DatabaseCDC DatabaseCDC
        {
            get { return this._databasecdc; }
            set { this._databasecdc = value; }
        }

        // Check to see if DatabaseCDC property is set
        internal bool IsSetDatabaseCDC()
        {
            return this._databasecdc != null;
        }

        /// <summary>
        /// Gets and sets the property DataSets. 
        /// <para>
        /// The data sets of the file metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataSet> DataSets
        {
            get { return this._dataSets; }
            set { this._dataSets = value; }
        }

        // Check to see if DataSets property is set
        internal bool IsSetDataSets()
        {
            return this._dataSets != null && (this._dataSets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}