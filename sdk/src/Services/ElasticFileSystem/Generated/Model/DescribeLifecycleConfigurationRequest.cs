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
    /// Container for the parameters to the DescribeLifecycleConfiguration operation.
    /// Returns the current <code>LifecycleConfiguration</code> object for the specified Amazon
    /// EFS file system. EFS lifecycle management uses the <code>LifecycleConfiguration</code>
    /// to identify which files to move to the EFS Infrequent Access (IA) storage class. For
    /// a file system without a <code>LifecycleConfiguration</code>, the call returns an empty
    /// array in the response.
    /// 
    ///  
    /// <para>
    /// This operation requires permissions for the <code>elasticfilesystem:DescribeLifecycleConfiguration</code>
    /// operation.
    /// </para>
    /// </summary>
    public partial class DescribeLifecycleConfigurationRequest : AmazonElasticFileSystemRequest
    {
        private string _fileSystemId;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system whose <code>LifecycleConfiguration</code> object you want
        /// to retrieve (String).
        /// </para>
        /// </summary>
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

    }
}