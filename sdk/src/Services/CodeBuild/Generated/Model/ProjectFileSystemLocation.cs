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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about a file system created by Amazon Elastic File System (EFS). For
    /// more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/whatisefs.html">What
    /// Is Amazon Elastic File System?</a>
    /// </summary>
    public partial class ProjectFileSystemLocation
    {
        private string _identifier;
        private string _location;
        private string _mountOptions;
        private string _mountPoint;
        private FileSystemType _type;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The name used to access a file system created by Amazon EFS. CodeBuild creates an
        /// environment variable by appending the <code>identifier</code> in all capital letters
        /// to <code>CODEBUILD_</code>. For example, if you specify <code>my_efs</code> for <code>identifier</code>,
        /// a new environment variable is create named <code>CODEBUILD_MY_EFS</code>. 
        /// </para>
        ///  
        /// <para>
        ///  The <code>identifier</code> is used to mount your file system. 
        /// </para>
        /// </summary>
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// A string that specifies the location of the file system created by Amazon EFS. Its
        /// format is <code>efs-dns-name:/directory-path</code>. You can find the DNS name of
        /// file system when you view it in the AWS EFS console. The directory path is a path
        /// to a directory in the file system that CodeBuild mounts. For example, if the DNS name
        /// of a file system is <code>fs-abcd1234.efs.us-west-2.amazonaws.com</code>, and its
        /// mount directory is <code>my-efs-mount-directory</code>, then the <code>location</code>
        /// is <code>fs-abcd1234.efs.us-west-2.amazonaws.com:/my-efs-mount-directory</code>. 
        /// </para>
        ///  
        /// <para>
        /// The directory path in the format <code>efs-dns-name:/directory-path</code> is optional.
        /// If you do not specify a directory path, the location is only the DNS name and CodeBuild
        /// mounts the entire file system. 
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property MountOptions. 
        /// <para>
        ///  The mount options for a file system created by AWS EFS. The default mount options
        /// used by CodeBuild are <code>nfsvers=4.1,rsize=1048576,wsize=1048576,hard,timeo=600,retrans=2</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/mounting-fs-nfs-mount-settings.html">Recommended
        /// NFS Mount Options</a>. 
        /// </para>
        /// </summary>
        public string MountOptions
        {
            get { return this._mountOptions; }
            set { this._mountOptions = value; }
        }

        // Check to see if MountOptions property is set
        internal bool IsSetMountOptions()
        {
            return this._mountOptions != null;
        }

        /// <summary>
        /// Gets and sets the property MountPoint. 
        /// <para>
        /// The location in the container where you mount the file system. 
        /// </para>
        /// </summary>
        public string MountPoint
        {
            get { return this._mountPoint; }
            set { this._mountPoint = value; }
        }

        // Check to see if MountPoint property is set
        internal bool IsSetMountPoint()
        {
            return this._mountPoint != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of the file system. The one supported type is <code>EFS</code>. 
        /// </para>
        /// </summary>
        public FileSystemType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}