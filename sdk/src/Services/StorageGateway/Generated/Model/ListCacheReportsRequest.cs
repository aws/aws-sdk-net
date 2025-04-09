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
    /// Container for the parameters to the ListCacheReports operation.
    /// Returns a list of existing cache reports for all file shares associated with your
    /// Amazon Web Services account. This list includes all information provided by the <c>DescribeCacheReport</c>
    /// action, such as report name, status, completion progress, start time, end time, filters,
    /// and tags.
    /// </summary>
    public partial class ListCacheReportsRequest : AmazonStorageGatewayRequest
    {
        private string _marker;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Opaque pagination token returned from a previous <c>ListCacheReports</c> operation.
        /// If present, <c>Marker</c> specifies where to continue the list from after a previous
        /// call to <c>ListCacheReports</c>. Optional.
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