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

#pragma warning disable CS0612,CS0618,CS1570
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
        /// environment variable by appending the <c>identifier</c> in all capital letters to
        /// <c>CODEBUILD_</c>. For example, if you specify <c>my_efs</c> for <c>identifier</c>,
        /// a new environment variable is create named <c>CODEBUILD_MY_EFS</c>. 
        /// </para>
        ///  
        /// <para>
        ///  The <c>identifier</c> is used to mount your file system. 
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
        /// format is <c>efs-dns-name:/directory-path</c>. You can find the DNS name of file system
        /// when you view it in the Amazon EFS console. The directory path is a path to a directory
        /// in the file system that CodeBuild mounts. For example, if the DNS name of a file system
        /// is <c>fs-abcd1234.efs.us-west-2.amazonaws.com</c>, and its mount directory is <c>my-efs-mount-directory</c>,
        /// then the <c>location</c> is <c>fs-abcd1234.efs.us-west-2.amazonaws.com:/my-efs-mount-directory</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The directory path in the format <c>efs-dns-name:/directory-path</c> is optional.
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
        ///  The mount options for a file system created by Amazon EFS. The default mount options
        /// used by CodeBuild are <c>nfsvers=4.1,rsize=1048576,wsize=1048576,hard,timeo=600,retrans=2</c>.
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
        ///  The type of the file system. The one supported type is <c>EFS</c>. 
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