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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Identifies a specific data set to export from an external location.
    /// </summary>
    public partial class DataSetExportItem
    {
        private string _datasetName;
        private ExternalLocation _externalLocation;

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The data set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatasetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        // Check to see if DatasetName property is set
        internal bool IsSetDatasetName()
        {
            return this._datasetName != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalLocation. 
        /// <para>
        /// The location of the data set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExternalLocation ExternalLocation
        {
            get { return this._externalLocation; }
            set { this._externalLocation = value; }
        }

        // Check to see if ExternalLocation property is set
        internal bool IsSetExternalLocation()
        {
            return this._externalLocation != null;
        }

    }
}