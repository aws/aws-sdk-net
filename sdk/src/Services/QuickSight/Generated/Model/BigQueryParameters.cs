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
    /// The parameters that are required to connect to a Google BigQuery data source.
    /// </summary>
    public partial class BigQueryParameters
    {
        private string _dataSetRegion;
        private string _projectId;

        /// <summary>
        /// Gets and sets the property DataSetRegion. 
        /// <para>
        /// The storage location where you create a Google BigQuery data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DataSetRegion
        {
            get { return this._dataSetRegion; }
            set { this._dataSetRegion = value; }
        }

        // Check to see if DataSetRegion property is set
        internal bool IsSetDataSetRegion()
        {
            return this._dataSetRegion != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The Google Cloud Platform project ID where your datasource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ProjectId
        {
            get { return this._projectId; }
            set { this._projectId = value; }
        }

        // Check to see if ProjectId property is set
        internal bool IsSetProjectId()
        {
            return this._projectId != null;
        }

    }
}