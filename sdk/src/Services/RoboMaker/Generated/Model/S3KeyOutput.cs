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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
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
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about S3 keys.
    /// </summary>
    public partial class S3KeyOutput
    {
        private string _etag;
        private string _s3Key;

        /// <summary>
        /// Gets and sets the property Etag. 
        /// <para>
        /// The etag for the object.
        /// </para>
        /// </summary>
        public string Etag
        {
            get { return this._etag; }
            set { this._etag = value; }
        }

        // Check to see if Etag property is set
        internal bool IsSetEtag()
        {
            return this._etag != null;
        }

        /// <summary>
        /// Gets and sets the property S3Key. 
        /// <para>
        /// The S3 key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string S3Key
        {
            get { return this._s3Key; }
            set { this._s3Key = value; }
        }

        // Check to see if S3Key property is set
        internal bool IsSetS3Key()
        {
            return this._s3Key != null;
        }

    }
}