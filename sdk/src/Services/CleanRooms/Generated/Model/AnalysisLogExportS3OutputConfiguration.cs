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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Contains output information for an analysis log export with an S3 output type.
    /// 
    ///  
    /// <para>
    /// The exported logs are written under the bucket and key prefix that you specify. The
    /// path includes the collaboration ID, the protected query ID, and the analysis log export
    /// ID. Because the path includes the export ID, exporting the same query more than once
    /// doesn't overwrite the logs from an earlier export.
    /// </para>
    ///  <note> 
    /// <para>
    /// The exported logs are encrypted using the default encryption configuration of the
    /// destination bucket. Clean Rooms doesn't accept a KMS key for log export. To encrypt
    /// the exported logs with a customer managed key, configure the bucket's default encryption
    /// to use that key before you export.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AnalysisLogExportS3OutputConfiguration
    {
        private string _bucket;
        private string _keyPrefix;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The S3 bucket that the exported analysis logs are written to. The bucket must be in
        /// the same Amazon Web Services Region as the collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPrefix. 
        /// <para>
        /// The S3 key prefix under which the exported analysis logs are written.
        /// </para>
        ///  
        /// <para>
        /// Only one export can be in progress at a time for a given query and destination. To
        /// export the same query twice at once, use a different key prefix for the second export.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string KeyPrefix
        {
            get { return this._keyPrefix; }
            set { this._keyPrefix = value; }
        }

        // Check to see if KeyPrefix property is set
        internal bool IsSetKeyPrefix()
        {
            return this._keyPrefix != null;
        }

    }
}