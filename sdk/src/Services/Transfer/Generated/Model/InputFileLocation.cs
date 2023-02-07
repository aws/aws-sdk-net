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
    /// Specifies the location for the file that's being processed.
    /// </summary>
    public partial class InputFileLocation
    {
        private EfsFileLocation _efsFileLocation;
        private S3InputFileLocation _s3FileLocation;

        /// <summary>
        /// Gets and sets the property EfsFileLocation. 
        /// <para>
        /// Specifies the details for the Amazon Elastic File System (Amazon EFS) file that's
        /// being decrypted.
        /// </para>
        /// </summary>
        public EfsFileLocation EfsFileLocation
        {
            get { return this._efsFileLocation; }
            set { this._efsFileLocation = value; }
        }

        // Check to see if EfsFileLocation property is set
        internal bool IsSetEfsFileLocation()
        {
            return this._efsFileLocation != null;
        }

        /// <summary>
        /// Gets and sets the property S3FileLocation. 
        /// <para>
        /// Specifies the details for the Amazon S3 file that's being copied or decrypted.
        /// </para>
        /// </summary>
        public S3InputFileLocation S3FileLocation
        {
            get { return this._s3FileLocation; }
            set { this._s3FileLocation = value; }
        }

        // Check to see if S3FileLocation property is set
        internal bool IsSetS3FileLocation()
        {
            return this._s3FileLocation != null;
        }

    }
}