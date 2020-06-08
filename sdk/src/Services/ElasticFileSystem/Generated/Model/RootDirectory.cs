/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Specifies the directory on the Amazon EFS file system that the access point provides
    /// access to. The access point exposes the specified file system path as the root directory
    /// of your file system to applications using the access point. NFS clients using the
    /// access point can only access data in the access point's <code>RootDirectory</code>
    /// and it's subdirectories.
    /// </summary>
    public partial class RootDirectory
    {
        private CreationInfo _creationInfo;
        private string _path;

        /// <summary>
        /// Gets and sets the property CreationInfo. 
        /// <para>
        /// (Optional) Specifies the POSIX IDs and permissions to apply to the access point's
        /// <code>RootDirectory</code>. If the <code>RootDirectory</code> &gt; <code>Path</code>
        /// specified does not exist, EFS creates the root directory using the <code>CreationInfo</code>
        /// settings when a client connects to an access point. When specifying the <code>CreationInfo</code>,
        /// you must provide values for all properties. 
        /// </para>
        ///  <important> 
        /// <para>
        /// If you do not provide <code>CreationInfo</code> and the specified <code>RootDirectory</code>
        /// &gt; <code>Path</code> does not exist, attempts to mount the file system using the
        /// access point will fail.
        /// </para>
        ///  </important>
        /// </summary>
        public CreationInfo CreationInfo
        {
            get { return this._creationInfo; }
            set { this._creationInfo = value; }
        }

        // Check to see if CreationInfo property is set
        internal bool IsSetCreationInfo()
        {
            return this._creationInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Specifies the path on the EFS file system to expose as the root directory to NFS clients
        /// using the access point to access the EFS file system. A path can have up to four subdirectories.
        /// If the specified path does not exist, you are required to provide the <code>CreationInfo</code>.
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