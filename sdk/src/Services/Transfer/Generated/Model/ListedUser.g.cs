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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Returns properties of the user that you specify.
    /// </summary>
    public partial class ListedUser
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Provides the unique Amazon Resource Name (ARN) for the user that you want to learn
        /// about.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property HomeDirectory. 
        /// <para>
        /// The landing directory (folder) for a user when they log in to the server using the
        /// client.
        /// </para>
        ///  
        /// <para>
        /// A <c>HomeDirectory</c> example is <c>/bucket_name/home/mydirectory</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use the <c>HomeDirectory</c> parameter for <c>HomeDirectoryType</c> when it
        /// is set to either <c>PATH</c> or <c>LOGICAL</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string HomeDirectory { get; set; }

        /// <summary>
        /// Checks to see if the HomeDirectory property is set.
        /// </summary>
        internal bool IsSetHomeDirectory() => this.HomeDirectory != null;

        /// <summary>
        /// Gets and sets the property HomeDirectoryType. 
        /// <para>
        /// The type of landing directory (folder) that you want your users' home directory to
        /// be when they log in to the server. If you set it to <c>PATH</c>, the user will see
        /// the absolute Amazon S3 bucket or Amazon EFS path as is in their file transfer protocol
        /// clients. If you set it to <c>LOGICAL</c>, you need to provide mappings in the <c>HomeDirectoryMappings</c>
        /// for how you want to make Amazon S3 or Amazon EFS paths visible to your users.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>HomeDirectoryType</c> is <c>LOGICAL</c>, you must provide mappings, using the
        /// <c>HomeDirectoryMappings</c> parameter. If, on the other hand, <c>HomeDirectoryType</c>
        /// is <c>PATH</c>, you provide an absolute path using the <c>HomeDirectory</c> parameter.
        /// You cannot have both <c>HomeDirectory</c> and <c>HomeDirectoryMappings</c> in your
        /// template.
        /// </para>
        ///  </note>
        /// </summary>
        public HomeDirectoryType HomeDirectoryType { get; set; }

        /// <summary>
        /// Checks to see if the HomeDirectoryType property is set.
        /// </summary>
        internal bool IsSetHomeDirectoryType() => this.HomeDirectoryType != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role that
        /// controls your users' access to your Amazon S3 bucket or Amazon EFS file system. The
        /// policies attached to this role determine the level of access that you want to provide
        /// your users when transferring files into and out of your Amazon S3 bucket or Amazon
        /// EFS file system. The IAM role should also contain a trust relationship that allows
        /// the server to access your resources when servicing your users' transfer requests.
        /// </para>
        ///  <note> 
        /// <para>
        /// The IAM role that controls your users' access to your Amazon S3 bucket for servers
        /// with <c>Domain=S3</c>, or your EFS file system for servers with <c>Domain=EFS</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The policies attached to this role determine the level of access you want to provide
        /// your users when transferring files into and out of your S3 buckets or EFS file systems.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property SshPublicKeyCount. 
        /// <para>
        /// Specifies the number of SSH public keys stored for the user you specified.
        /// </para>
        /// </summary>
        public int? SshPublicKeyCount { get; set; }

        /// <summary>
        /// Checks to see if the SshPublicKeyCount property is set.
        /// </summary>
        internal bool IsSetSshPublicKeyCount() => this.SshPublicKeyCount.HasValue;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// Specifies the name of the user whose ARN was specified. User names are used for authentication
        /// purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 100)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
