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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the S3 object that was scanned
    /// </summary>
    public partial class S3ObjectDetail
    {
        private string _eTag;
        private string _hash;
        private string _key;
        private string _objectArn;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The entity tag is a hash of the S3 object. The ETag reflects changes only to the contents
        /// of an object, and not its metadata.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property Hash. 
        /// <para>
        /// Hash of the threat detected in this finding.
        /// </para>
        /// </summary>
        public string Hash
        {
            get { return this._hash; }
            set { this._hash = value; }
        }

        // Check to see if Hash property is set
        internal bool IsSetHash()
        {
            return this._hash != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Key of the S3 object.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ObjectArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the S3 object.
        /// </para>
        /// </summary>
        public string ObjectArn
        {
            get { return this._objectArn; }
            set { this._objectArn = value; }
        }

        // Check to see if ObjectArn property is set
        internal bool IsSetObjectArn()
        {
            return this._objectArn != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID of the object.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}