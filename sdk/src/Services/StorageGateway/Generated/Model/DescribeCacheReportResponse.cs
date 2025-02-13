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
    /// This is the response object from the DescribeCacheReport operation.
    /// </summary>
    public partial class DescribeCacheReportResponse : AmazonWebServiceResponse
    {
        private CacheReportInfo _cacheReportInfo;

        /// <summary>
        /// Gets and sets the property CacheReportInfo. 
        /// <para>
        /// Contains all informational fields associated with a cache report. Includes name, ARN,
        /// tags, status, progress, filters, start time, and end time.
        /// </para>
        /// </summary>
        public CacheReportInfo CacheReportInfo
        {
            get { return this._cacheReportInfo; }
            set { this._cacheReportInfo = value; }
        }

        // Check to see if CacheReportInfo property is set
        internal bool IsSetCacheReportInfo()
        {
            return this._cacheReportInfo != null;
        }

    }
}