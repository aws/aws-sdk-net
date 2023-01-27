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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Contains the configuration to write the query results to S3.
    /// </summary>
    public partial class ProtectedQueryS3OutputConfiguration
    {
        private string _bucket;
        private string _keyPrefix;
        private ResultFormat _resultFormat;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The S3 bucket to unload the protected query results.
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
        /// The S3 prefix to unload the protected query results.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ResultFormat. 
        /// <para>
        /// Intended file format of the result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResultFormat ResultFormat
        {
            get { return this._resultFormat; }
            set { this._resultFormat = value; }
        }

        // Check to see if ResultFormat property is set
        internal bool IsSetResultFormat()
        {
            return this._resultFormat != null;
        }

    }
}