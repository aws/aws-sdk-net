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
 * Do not modify this file. This file is generated from the s3files-2025-05-05.normal.json service model.
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
namespace Amazon.S3Files.Model
{
    /// <summary>
    /// Specifies the root directory path and optional creation permissions for newly created
    /// directories.
    /// </summary>
    public partial class RootDirectory
    {
        private CreationPermissions _creationPermissions;
        private string _path;

        /// <summary>
        /// Gets and sets the property CreationPermissions. 
        /// <para>
        /// The permissions to set on newly created directories.
        /// </para>
        /// </summary>
        public CreationPermissions CreationPermissions
        {
            get { return this._creationPermissions; }
            set { this._creationPermissions = value; }
        }

        // Check to see if CreationPermissions property is set
        internal bool IsSetCreationPermissions()
        {
            return this._creationPermissions != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to use as the root directory for the access point.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

    }
}