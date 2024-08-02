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
    /// Compares the file type.
    /// </summary>
    public partial class CompareFileType
    {
        private CompareDatabaseCDCSummary _databasecdc;
        private CompareDataSetsSummary _datasets;

        /// <summary>
        /// Gets and sets the property DatabaseCDC. 
        /// <para>
        /// The database CDC of the compare file type.
        /// </para>
        /// </summary>
        public CompareDatabaseCDCSummary DatabaseCDC
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
        /// Gets and sets the property Datasets. 
        /// <para>
        /// The data sets in the compare file type.
        /// </para>
        /// </summary>
        public CompareDataSetsSummary Datasets
        {
            get { return this._datasets; }
            set { this._datasets = value; }
        }

        // Check to see if Datasets property is set
        internal bool IsSetDatasets()
        {
            return this._datasets != null;
        }

    }
}