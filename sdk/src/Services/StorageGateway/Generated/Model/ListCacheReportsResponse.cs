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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// This is the response object from the ListCacheReports operation.
    /// </summary>
    public partial class ListCacheReportsResponse : AmazonWebServiceResponse
    {
        private List<CacheReportInfo> _cacheReportList = AWSConfigs.InitializeCollections ? new List<CacheReportInfo>() : null;
        private string _marker;

        /// <summary>
        /// Gets and sets the property CacheReportList. 
        /// <para>
        /// A list of existing cache reports for all file shares associated with your Amazon Web
        /// Services account. This list includes all information provided by the <c>DescribeCacheReport</c>
        /// action, such as report status, completion progress, start time, end time, filters,
        /// and tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CacheReportInfo> CacheReportList
        {
            get { return this._cacheReportList; }
            set { this._cacheReportList = value; }
        }

        // Check to see if CacheReportList property is set
        internal bool IsSetCacheReportList()
        {
            return this._cacheReportList != null && (this._cacheReportList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// If the request includes <c>Marker</c>, the response returns that value in this field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}