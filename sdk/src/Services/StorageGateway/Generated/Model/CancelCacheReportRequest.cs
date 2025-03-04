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
    /// Container for the parameters to the CancelCacheReport operation.
    /// Cancels generation of a specified cache report. You can use this operation to manually
    /// cancel an IN-PROGRESS report for any reason. This action changes the report status
    /// from IN-PROGRESS to CANCELLED. You can only cancel in-progress reports. If the the
    /// report you attempt to cancel is in FAILED, ERROR, or COMPLETED state, the cancel operation
    /// returns an error.
    /// </summary>
    public partial class CancelCacheReportRequest : AmazonStorageGatewayRequest
    {
        private string _cacheReportARN;

        /// <summary>
        /// Gets and sets the property CacheReportARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cache report you want to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string CacheReportARN
        {
            get { return this._cacheReportARN; }
            set { this._cacheReportARN = value; }
        }

        // Check to see if CacheReportARN property is set
        internal bool IsSetCacheReportARN()
        {
            return this._cacheReportARN != null;
        }

    }
}