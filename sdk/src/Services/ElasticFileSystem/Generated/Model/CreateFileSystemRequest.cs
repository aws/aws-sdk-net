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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFileSystem operation.
    /// Creates a new, empty file system. The operation requires a creation token in the
    /// request that Amazon EFS uses to ensure idempotent creation (calling the operation
    /// with same creation token has no effect). If a file system does not currently exist
    /// that is owned by the caller's AWS account with the specified creation token, this
    /// operation does the following: 
    /// 
    ///  <ul> <li>Creates a new, empty file system. The file system will have an Amazon EFS
    /// assigned ID, and an initial lifecycle state "creating". </li> <li> Returns with the
    /// description of the created file system. </li> </ul> 
    /// <para>
    /// Otherwise, this operation returns a <code>FileSystemAlreadyExists</code> error with
    /// the ID of the existing file system.
    /// </para>
    ///  <note>For basic use cases, you can use a randomly generated UUID for the creation
    /// token.</note> 
    /// <para>
    ///  The idempotent operation allows you to retry a <code>CreateFileSystem</code> call
    /// without risk of creating an extra file system. This can happen when an initial call
    /// fails in a way that leaves it uncertain whether or not a file system was actually
    /// created. An example might be that a transport level timeout occurred or your connection
    /// was reset. As long as you use the same creation token, if the initial call had succeeded
    /// in creating a file system, the client can learn of its existence from the <code>FileSystemAlreadyExists</code>
    /// error. 
    /// </para>
    ///  <note>The <code>CreateFileSystem</code> call returns while the file system's lifecycle
    /// state is still "creating". You can check the file system creation status by calling
    /// the <a>DescribeFileSystems</a> API, which among other things returns the file system
    /// state.</note> 
    /// <para>
    ///  After the file system is fully created, Amazon EFS sets its lifecycle state to "available",
    /// at which point you can create one or more mount targets for the file system (<a>CreateMountTarget</a>)
    /// in your VPC. You mount your Amazon EFS file system on an EC2 instances in your VPC
    /// via the mount target. For more information, see <a href="http://docs.aws.amazon.com/efs/latest/ug/how-it-works.html">Amazon
    /// EFS: How it Works</a> 
    /// </para>
    ///  
    /// <para>
    ///  This operation requires permission for the <code>elasticfilesystem:CreateFileSystem</code>
    /// action. 
    /// </para>
    /// </summary>
    public partial class CreateFileSystemRequest : AmazonElasticFileSystemRequest
    {
        private string _creationToken;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateFileSystemRequest() { }

        /// <summary>
        /// Instantiates CreateFileSystemRequest with the parameterized properties
        /// </summary>
        /// <param name="creationToken">String of up to 64 ASCII characters. Amazon EFS uses this to ensure idempotent creation.</param>
        public CreateFileSystemRequest(string creationToken)
        {
            _creationToken = creationToken;
        }

        /// <summary>
        /// Gets and sets the property CreationToken. 
        /// <para>
        /// String of up to 64 ASCII characters. Amazon EFS uses this to ensure idempotent creation.
        /// </para>
        /// </summary>
        public string CreationToken
        {
            get { return this._creationToken; }
            set { this._creationToken = value; }
        }

        // Check to see if CreationToken property is set
        internal bool IsSetCreationToken()
        {
            return this._creationToken != null;
        }

    }
}