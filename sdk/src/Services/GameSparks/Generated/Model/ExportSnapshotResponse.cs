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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameSparks.Model
{
    /// <summary>
    /// This is the response object from the ExportSnapshot operation.
    /// </summary>
    public partial class ExportSnapshotResponse : AmazonWebServiceResponse
    {
        private string _s3Url;

        /// <summary>
        /// Gets and sets the property S3Url. 
        /// <para>
        /// The presigned URL for the snapshot data.
        /// </para>
        ///  
        /// <para>
        ///  This URL will be available for 10 minutes, and can be used to download the snapshot
        /// content. If the URL expires, a new one can be requested using the same operation.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=2048)]
        public string S3Url
        {
            get { return this._s3Url; }
            set { this._s3Url = value; }
        }

        // Check to see if S3Url property is set
        internal bool IsSetS3Url()
        {
            return this._s3Url != null;
        }

    }
}