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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about datasets that are available to associate with: <c>DataSetId</c>,
    /// <c>DataSetName</c>.
    /// </summary>
    public partial class AnalyticsDataSetsResult
    {
        private string _dataSetId;
        private string _dataSetName;

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The identifier of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DataSetId
        {
            get { return this._dataSetId; }
            set { this._dataSetId = value; }
        }

        // Check to see if DataSetId property is set
        internal bool IsSetDataSetId()
        {
            return this._dataSetId != null;
        }

        /// <summary>
        /// Gets and sets the property DataSetName. 
        /// <para>
        /// The name of the dataset.
        /// </para>
        /// </summary>
        public string DataSetName
        {
            get { return this._dataSetName; }
            set { this._dataSetName = value; }
        }

        // Check to see if DataSetName property is set
        internal bool IsSetDataSetName()
        {
            return this._dataSetName != null;
        }

    }
}