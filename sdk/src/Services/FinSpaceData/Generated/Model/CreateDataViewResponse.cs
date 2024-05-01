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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
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
namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Response for creating a data view.
    /// </summary>
    public partial class CreateDataViewResponse : AmazonWebServiceResponse
    {
        private string _datasetId;
        private string _dataViewId;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The unique identifier of the Dataset used for the Dataview.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string DatasetId
        {
            get { return this._datasetId; }
            set { this._datasetId = value; }
        }

        // Check to see if DatasetId property is set
        internal bool IsSetDatasetId()
        {
            return this._datasetId != null;
        }

        /// <summary>
        /// Gets and sets the property DataViewId. 
        /// <para>
        /// The unique identifier for the created Dataview.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string DataViewId
        {
            get { return this._dataViewId; }
            set { this._dataViewId = value; }
        }

        // Check to see if DataViewId property is set
        internal bool IsSetDataViewId()
        {
            return this._dataViewId != null;
        }

    }
}