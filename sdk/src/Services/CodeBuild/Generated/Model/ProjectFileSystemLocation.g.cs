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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

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
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property MountOptions. 
        /// <para>
        ///  The mount options for a file system created by Amazon EFS. The default mount options
        /// used by CodeBuild are <c>nfsvers=4.1,rsize=1048576,wsize=1048576,hard,timeo=600,retrans=2</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/mounting-fs-nfs-mount-settings.html">Recommended
        /// NFS Mount Options</a>. 
        /// </para>
        /// </summary>
        public string MountOptions { get; set; }

        /// <summary>
        /// Checks to see if the MountOptions property is set.
        /// </summary>
        internal bool IsSetMountOptions() => this.MountOptions != null;

        /// <summary>
        /// Gets and sets the property MountPoint. 
        /// <para>
        /// The location in the container where you mount the file system. 
        /// </para>
        /// </summary>
        public string MountPoint { get; set; }

        /// <summary>
        /// Checks to see if the MountPoint property is set.
        /// </summary>
        internal bool IsSetMountPoint() => this.MountPoint != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of the file system. The one supported type is <c>EFS</c>. 
        /// </para>
        /// </summary>
        public FileSystemType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
