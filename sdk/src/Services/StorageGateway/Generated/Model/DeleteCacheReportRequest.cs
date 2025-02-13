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
    /// Container for the parameters to the DeleteCacheReport operation.
    /// Deletes the specified cache report and any associated tags from the Storage Gateway
    /// database. You can only delete completed reports. If the status of the report you attempt
    /// to delete still IN-PROGRESS, the delete operation returns an error. You can use <c>CancelCacheReport</c>
    /// to cancel an IN-PROGRESS report.
    /// 
    ///  <note> 
    /// <para>
    ///  <c>DeleteCacheReport</c> does not delete the report object from your Amazon S3 bucket.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteCacheReportRequest : AmazonStorageGatewayRequest
    {
        private string _cacheReportARN;

        /// <summary>
        /// Gets and sets the property CacheReportARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cache report you want to delete.
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