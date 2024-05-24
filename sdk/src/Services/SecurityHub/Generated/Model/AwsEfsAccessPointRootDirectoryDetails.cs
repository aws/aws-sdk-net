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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about the directory on the Amazon EFS file system that the access
    /// point exposes as the root directory to NFS clients using the access point.
    /// </summary>
    public partial class AwsEfsAccessPointRootDirectoryDetails
    {
        private AwsEfsAccessPointRootDirectoryCreationInfoDetails _creationInfo;
        private string _path;

        /// <summary>
        /// Gets and sets the property CreationInfo. 
        /// <para>
        /// Specifies the POSIX IDs and permissions to apply to the access point's root directory.
        /// 
        /// </para>
        /// </summary>
        public AwsEfsAccessPointRootDirectoryCreationInfoDetails CreationInfo
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
        /// Specifies the path on the Amazon EFS file system to expose as the root directory to
        /// NFS clients using the access point to access the EFS file system. A path can have
        /// up to four subdirectories. If the specified path does not exist, you are required
        /// to provide <c>CreationInfo</c>. 
        /// </para>
        /// </summary>
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