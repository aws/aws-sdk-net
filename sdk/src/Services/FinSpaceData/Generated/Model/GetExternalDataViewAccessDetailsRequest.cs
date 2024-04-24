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
    /// Container for the parameters to the GetExternalDataViewAccessDetails operation.
    /// Returns the credentials to access the external Dataview from an S3 location. To call
    /// this API:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// You must retrieve the programmatic credentials.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must be a member of a FinSpace user group, where the dataset that you want to
    /// access has <c>Read Dataset Data</c> permissions.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetExternalDataViewAccessDetailsRequest : AmazonFinSpaceDataRequest
    {
        private string _datasetId;
        private string _dataViewId;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The unique identifier for the Dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=26)]
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
        /// The unique identifier for the Dataview that you want to access.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=26)]
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