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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Specifies the customer input Amazon S3 file location. If it is used inside <code>copyStepDetails.DestinationFileLocation</code>,
    /// it should be the S3 copy destination.
    /// 
    ///  
    /// <para>
    ///  You need to provide the bucket and key. The key can represent either a path or a
    /// file. This is determined by whether or not you end the key value with the forward
    /// slash (/) character. If the final character is "/", then your file is copied to the
    /// folder, and its name does not change. If, rather, the final character is alphanumeric,
    /// your uploaded file is renamed to the path value. In this case, if a file with that
    /// name already exists, it is overwritten. 
    /// </para>
    ///  
    /// <para>
    /// For example, if your path is <code>shared-files/bob/</code>, your uploaded files are
    /// copied to the <code>shared-files/bob/</code>, folder. If your path is <code>shared-files/today</code>,
    /// each uploaded file is copied to the <code>shared-files</code> folder and named <code>today</code>:
    /// each upload overwrites the previous version of the <i>bob</i> file.
    /// </para>
    /// </summary>
    public partial class S3InputFileLocation
    {
        private string _bucket;
        private string _key;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// Specifies the S3 bucket for the customer input file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
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
        /// Gets and sets the property Key. 
        /// <para>
        /// The name assigned to the file when it was created in Amazon S3. You use the object
        /// key to retrieve the object.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

    }
}