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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
namespace Amazon.PCS.Model
{
    /// <summary>
    /// The source location and integrity information for a node lifecycle script.
    /// </summary>
    public partial class ScriptSource
    {
        private string _checksum;
        private string _s3VersionId;
        private string _scriptLocation;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The SHA-256 checksum of the script content, as a 64-character hexadecimal string.
        /// This value is optional. When specified, PCS uses this value to verify the integrity
        /// of the downloaded script.
        /// </para>
        /// </summary>
        [AWSProperty(Min=64, Max=64)]
        public string Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this._checksum != null;
        }

        /// <summary>
        /// Gets and sets the property S3VersionId. 
        /// <para>
        /// The Amazon S3 version ID of the script. Use this value to pin the script to a specific
        /// version in a versioned Amazon S3 bucket. This value is only valid when <c>scriptLocation</c>
        /// is an Amazon S3 URI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string S3VersionId
        {
            get { return this._s3VersionId; }
            set { this._s3VersionId = value; }
        }

        // Check to see if S3VersionId property is set
        internal bool IsSetS3VersionId()
        {
            return this._s3VersionId != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptLocation. 
        /// <para>
        /// The location of the script. Specify either an Amazon S3 URI in the format <c>s3://bucket-name/key</c>
        /// or an HTTPS URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ScriptLocation
        {
            get { return this._scriptLocation; }
            set { this._scriptLocation = value; }
        }

        // Check to see if ScriptLocation property is set
        internal bool IsSetScriptLocation()
        {
            return this._scriptLocation != null;
        }

    }
}