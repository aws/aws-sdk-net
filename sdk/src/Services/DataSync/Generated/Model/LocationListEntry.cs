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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Represents a single entry in a list of locations. <c>LocationListEntry</c> returns
    /// an array that contains a list of locations when the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_ListLocations.html">ListLocations</a>
    /// operation is called.
    /// </summary>
    public partial class LocationListEntry
    {
        private string _locationArn;
        private string _locationUri;

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the location. For Network File System (NFS) or Amazon
        /// EFS, the location is the export path. For Amazon S3, the location is the prefix path
        /// that you want to mount and use as the root of the location.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string LocationArn
        {
            get { return this._locationArn; }
            set { this._locationArn = value; }
        }

        // Check to see if LocationArn property is set
        internal bool IsSetLocationArn()
        {
            return this._locationArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// Represents a list of URIs of a location. <c>LocationUri</c> returns an array that
        /// contains a list of locations when the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_ListLocations.html">ListLocations</a>
        /// operation is called.
        /// </para>
        ///  
        /// <para>
        /// Format: <c>TYPE://GLOBAL_ID/SUBDIR</c>.
        /// </para>
        ///  
        /// <para>
        /// TYPE designates the type of location (for example, <c>nfs</c> or <c>s3</c>).
        /// </para>
        ///  
        /// <para>
        /// GLOBAL_ID is the globally unique identifier of the resource that backs the location.
        /// An example for EFS is <c>us-east-2.fs-abcd1234</c>. An example for Amazon S3 is the
        /// bucket name, such as <c>myBucket</c>. An example for NFS is a valid IPv4 or IPv6 address
        /// or a hostname that is compliant with DNS.
        /// </para>
        ///  
        /// <para>
        /// SUBDIR is a valid file system path, delimited by forward slashes as is the *nix convention.
        /// For NFS and Amazon EFS, it's the export path to mount the location. For Amazon S3,
        /// it's the prefix path that you mount to and treat as the root of the location.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4360)]
        public string LocationUri
        {
            get { return this._locationUri; }
            set { this._locationUri = value; }
        }

        // Check to see if LocationUri property is set
        internal bool IsSetLocationUri()
        {
            return this._locationUri != null;
        }

    }
}